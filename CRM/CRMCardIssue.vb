
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class CRMCardIssue

    Private Sub CRMCardIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CardsTrans' table. You can move, or remove it, as needed.
        '      Me.CardsTransTableAdapter.FillByID(Me.CRMDataSet.CardsTrans, -1)
        'TODO: This line of code loads data into the 'CRMDataSet.Cards' table. You can move, or remove it, as needed.
        '    Me.CardsTransTableAdapter.FillByID(Me.CRMDataSet.CardsTrans, -1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        Me.IssueDate.DateTime = CDate(Format(Today, "dd/MM/yyyy"))
        DocID.EditValue = Getmax() + 1
        Me.KeyPreview = True
        SearchLookUpEdit1.Select()

    End Sub

    Private Sub CustomersOrdersAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.F2 Then
            Saving()
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True 'this will prevent ding sound 

    End Sub


    Private Function Getmax() As Integer
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = " Select max(DocID) as Max from CardsTrans "
            Sql.CRMRunQuery(SqlString)
            Getmax = CInt(Sql.SQLDS.Tables(0).Rows(0).Item("max"))
        Catch ex As Exception
            Getmax = 0
        End Try


    End Function


    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' If CStr(SearchLookUpEdit1.EditValue) = "Null" Then MsgBox("الرجاء اختيار زبون") : Exit Sub
        Saving()

    End Sub

    Private Sub PrintForm()

        Try
            If GridView2.RowCount = 0 Then Exit Sub
            Dim report As New CardsIssues()
            report.Parameter1.Value = DocID.EditValue
            report.Parameter1.Visible = False
            report.CreateDocument()
            report.PrintingSystem.ShowMarginsWarning = False
            report.Print()
        Catch ex As Exception
            MsgBox("خطا: لم يتمكن البرنامج من طباعة سند القبض")
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Saving()

        SearchLookUpEdit1.Select()

        If IsDBNull(SearchLookUpEdit1.EditValue) Then
            MsgBox("الرجاء اختيار زبون") : Exit Sub
        End If

        If CStr(TextEditPerson.Text) = "" Then MsgBox(" مستلم البطاقة فارغ ") : Exit Sub
        If CStr(RadioGroup1.Text) = "" Then MsgBox(" الرجاء اختيار المصادقة") : Exit Sub

        If GridView2.RowCount = 0 Then MsgBox(" لا يوجد بطاقات ") : Exit Sub


        Try

            Dim DocIDInt As Integer = Getmax() + 1

            Dim i As Integer
            For i = 0 To GridView2.RowCount - 1
                GridView2.SetRowCellValue(i, GridView2.Columns("CardTransDate"), IssueDate.DateTime)
                GridView2.SetRowCellValue(i, GridView2.Columns("AccountNo"), SearchLookUpEdit1.EditValue)
                GridView2.SetRowCellValue(i, GridView2.Columns("AccountName"), SearchLookUpEdit1.Text)
                GridView2.SetRowCellValue(i, GridView2.Columns("TransUser"), My.Settings.UserName)
                GridView2.SetRowCellValue(i, GridView2.Columns("TransNotes"), TextEditNotes.Text)
                GridView2.SetRowCellValue(i, GridView2.Columns("DocType"), RadioGroup1.Text)
                GridView2.SetRowCellValue(i, GridView2.Columns("DocID"), DocIDInt)
                GridView2.SetRowCellValue(i, GridView2.Columns("PersonName"), TextEditPerson.Text)

                GridView2.SetRowCellValue(i, GridView2.Columns("CardSerial"), "")
                GridView2.SetRowCellValue(i, GridView2.Columns("CardStatus"), "")
            Next
            Me.Validate()
            Me.CardsTransBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

            AddEvents("تنبيه", "  تم اصدار بطاقات   " & " " & SearchLookUpEdit1.Text & " عدد " & " " & GridView2.RowCount, Me.Text, "1800013", My.Settings.UserName, "True")
            AddEvents("تنبيه", "  تم اصدار بطاقات   " & " " & SearchLookUpEdit1.Text & " عدد " & " " & GridView2.RowCount, Me.Text, "1800666", My.Settings.UserName, "True")
            AddEvents("تنبيه", "  تم اصدار بطاقات   " & " " & SearchLookUpEdit1.Text & " عدد " & " " & GridView2.RowCount, Me.Text, "1800102", My.Settings.UserName, "True")


            If CheckPrintDoc.Checked = True Then PrintForm()

            Me.CardsTransBindingSource.AddNew()

            Clear()

            DocID.EditValue = Getmax() + 1

        Catch ex As Exception
            MsgBox("لا يمكن حفظ الملف")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Clear()
        IssueDate.DateTime = Today
        SearchLookUpEdit1.EditValue = "Null"
        TextEditNotes.Text = ""
        '    DocID.EditValue = Getmax() + 1
        TextEditPerson.Text = ""
        Me.IssueDate.DateTime = CDate(Format(Today, "dd/MM/yyyy"))
        SearchLookUpEdit1.Select()
    End Sub

    Private Sub gridView2_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView2.FocusedColumnChanged
        Dim view As GridView = TryCast(sender, GridView)

        If view.FocusedColumn.Name.ToString = "colCardSerial1" Then
            Dim CardId As String = CType(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "CardID"), String)
            If IsDBNull(CardId) Or CardId Is Nothing Then Exit Sub
            '  MsgBox(CardId)
            Try
                Dim Sql As New SQLControl
                Dim SqlString As String = " Select CardSerial,Owner from Cards where CardID= " & CardId
                Sql.CRMRunQuery(SqlString)
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("CardSerial"), Mid(CStr(Sql.SQLDS.Tables(0).Rows(0).Item("CardSerial")), 5, 8))
            Catch ex As Exception
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("CardSerial"), "غير موجود")
            End Try


            Try
                CardTransDate.Text = "" : AccountNo.Text = "" : TransUser.Text = "" : TransNotes.Text = "" : PersonName.Text = ""
                Dim Sql As New SQLControl
                Dim SqlString As String = " Select [ID],CardTransDate,AccountNo,AccountName,TransUser,TransNotes,PersonName  from CardsTrans where CardId = " & CardId
                Sql.CRMRunQuery(SqlString)
                If CStr(Sql.SQLDS.Tables(0).Rows(0).Item("ID")) <> "" Then
                    GridView2.SetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("CardStatus"), "مصدر")
                    CardTransDate.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("CardTransDate"))
                    AccountNo.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("AccountNo")) & " " & CStr(Sql.SQLDS.Tables(0).Rows(0).Item("AccountName"))
                    TransUser.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TransUser"))
                    TransNotes.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TransNotes"))
                    PersonName.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("PersonName"))
                    MsgBox("هذا الكرت مصدر ")
                End If
            Catch ex As Exception
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("CardStatus"), "متوفر")
            End Try

        End If

    End Sub

    Private Sub CardsTransGridControl_Click(sender As Object, e As EventArgs) Handles CardsTransGridControl.Click

    End Sub

    Private Sub DocID_EditValueChanged(sender As Object, e As EventArgs) Handles DocID.EditValueChanged
        Clear()


        If DocID.IsHandleCreated = True Then
            If DocID.Visible = True Then Me.CardsTransTableAdapter.FillByDocID(Me.CRMDataSet.CardsTrans, CInt(DocID.EditValue))
        End If

        Try
            Dim sql As New SQLControl
            Dim SqlString As String = " Select top 1   CardTransDate, AccountNo, TransNotes, PersonName, DocType from CardsTrans where DocID= " & Me.DocID.Text
            sql.CRMRunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Try
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("CardTransDate")) Then IssueDate.DateTime = CDate(sql.SQLDS.Tables(0).Rows(0).Item("CardTransDate"))
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AccountNo")) Then SearchLookUpEdit1.EditValue = CStr(sql.SQLDS.Tables(0).Rows(0).Item("AccountNo"))
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("PersonName")) Then TextEditPerson.Text = CStr(sql.SQLDS.Tables(0).Rows(0).Item("PersonName"))
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("TransNotes")) Then TextEditNotes.Text = CStr(sql.SQLDS.Tables(0).Rows(0).Item("TransNotes"))
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocType")) Then RadioGroup1.EditValue = CStr(sql.SQLDS.Tables(0).Rows(0).Item("DocType"))

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub CardsTransGridControl_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles CardsTransGridControl.ProcessGridKey
        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            view.DeleteSelectedRows()
            e.Handled = True
        End If

    End Sub

    Private Sub SimpleButtonNew_Click(sender As Object, e As EventArgs) Handles SimpleButtonNew.Click

        Try
            Me.CardsTransBindingSource.AddNew()
            Clear()
            DocID.EditValue = Getmax() + 1
        Catch ex As Exception
            Clear()
        End Try


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        PrintForm()
    End Sub
End Class