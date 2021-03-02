
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class CRMCardIssue

    Private Sub CRMCardIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HO_DATADataSet.group_rules' table. You can move, or remove it, as needed.
        Me.Group_rulesTableAdapter.Fill(Me.HO_DATADataSet.group_rules)
        'TODO: This line of code loads data into the 'HO_DATADataSet.group_rules' table. You can move, or remove it, as needed.
        ' Me.Group_rulesTableAdapter.Fill(Me.HO_DATADataSet.group_rules)
        'TODO: This line of code loads data into the 'CRMDataSet.CardsTrans' table. You can move, or remove it, as needed.
        '      Me.CardsTransTableAdapter.FillByID(Me.CRMDataSet.CardsTrans, -1)
        'TODO: This line of code loads data into the 'CRMDataSet.Cards' table. You can move, or remove it, as needed.
        '    Me.CardsTransTableAdapter.FillByID(Me.CRMDataSet.CardsTrans, -1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        Me.IssueDate.DateTime = CDate(Format(Today, "dd/MM/yyyy"))
        DocID.EditValue = Getmax() + 1
        '    Me.KeyPreview = True
        SearchLookUpEdit1.Select()
        Me.KeyPreview = True
        SearchLookUpEdit1.Properties.DataSource = GetFleets()
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

        If CStr(SearchLookUpEdit1.Text) = "0" Then
            MsgBox("الرجاء اختيار زبون") : Exit Sub
        End If

        If CStr(TextEditPerson.Text) = "" Then MsgBox(" مستلم البطاقة فارغ ") : Exit Sub
        If CStr(RadioGroup1.Text) = "" Then MsgBox(" الرجاء اختيار المصادقة") : Exit Sub

        If GridView2.RowCount = 0 Then MsgBox(" لا يوجد بطاقات ") : Exit Sub


        '   Try

        Dim DocIDInt As Integer = Getmax() + 1

        Dim i As Integer

        For i = 0 To GridView2.RowCount
            If Not String.IsNullOrEmpty(CStr(GridView2.GetRowCellValue(i, "CardID"))) Then
                GridView2.SetRowCellValue(i, GridView2.Columns("CardTransDate"), IssueDate.DateTime)
                GridView2.SetRowCellValue(i, GridView2.Columns("AccountNo"), SearchLookUpEdit1.EditValue)
                GridView2.SetRowCellValue(i, GridView2.Columns("AccountName"), SearchLookUpEdit1.Text)
                GridView2.SetRowCellValue(i, GridView2.Columns("TransUser"), My.Settings.UserName)
                GridView2.SetRowCellValue(i, GridView2.Columns("TransNotes"), TextEditNotes.Text)
                GridView2.SetRowCellValue(i, GridView2.Columns("DocType"), RadioGroup1.Text)
                GridView2.SetRowCellValue(i, GridView2.Columns("DocID"), DocIDInt)
                GridView2.SetRowCellValue(i, GridView2.Columns("PersonName"), TextEditPerson.Text)



                IssueCards(CStr(GridView2.GetRowCellValue(i, "CardID")),
                           CStr(GridView2.GetRowCellValue(i, "CardSerial")),
                           CInt(GridView2.GetRowCellValue(i, "GroupRule")),
                           CStr(GridView2.GetRowCellValue(i, "PlateNo")),
                           TextFleetID.Text)
            End If
        Next
        Me.Validate()
        Me.CardsTransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

        AddEvents("تنبيه", "  تم اصدار بطاقات   " & " " & SearchLookUpEdit1.Text & " عدد " & " " & GridView2.RowCount, Me.Text, "1800013", My.Settings.UserName, "True")
        AddEvents("تنبيه", "  تم اصدار بطاقات   " & " " & SearchLookUpEdit1.Text & " عدد " & " " & GridView2.RowCount, Me.Text, "1800666", My.Settings.UserName, "True")
        AddEvents("تنبيه", "  تم اصدار بطاقات   " & " " & SearchLookUpEdit1.Text & " عدد " & " " & GridView2.RowCount, Me.Text, "1800102", My.Settings.UserName, "True")


        If CheckPrintDoc.Checked = True Then PrintForm()

        GridView2.SetRowCellValue(i, GridView2.Columns("CardSerial"), "")
        GridView2.SetRowCellValue(i, GridView2.Columns("CardStatus"), "")


        Me.CardsTransBindingSource.AddNew()

        Clear()

        DocID.EditValue = Getmax() + 1

        'Catch ex As Exception
        '    MsgBox("لا يمكن حفظ الملف")
        '    MsgBox(ex.ToString)
        'End Try
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
                Dim SqlString As String = " Select CardSerial,Owner,CardType  from Cards where CardID= " & CardId
                Sql.CRMRunQuery(SqlString)
                If Sql.SQLDS.Tables(0).Rows(0).Item("CardType").ToString = "Card" Then
                    GridView2.SetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("CardSerial"), Mid(CStr(Sql.SQLDS.Tables(0).Rows(0).Item("CardSerial")), 5, 8))
                Else
                    GridView2.SetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns("CardSerial"), CStr(Sql.SQLDS.Tables(0).Rows(0).Item("CardSerial")))
                End If

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
    Private Function CheckIfPlateExist(PlateNO As String) As Boolean
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT  [plate]  FROM [HO_DATA].[dbo].[means] where [plate]='" & PlateNO & "'"
            sql.RunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function CheckIfSerialExist(CardSerial As String) As Boolean
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT  [string]  FROM [HO_DATA].[dbo].[means] where [string]='" & CardSerial & "'"
            sql.RunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

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
    Private Sub IssueCards(Cname As String, Cstring As String, Crule As Integer, Cplate As String, Ccust_id As String)

        Dim Sql2 As New SQLControl
        Dim SqlString2 As String
        SqlString2 = " update indexes set id=id+1 where name='means' "
        Sql2.RunQuery(SqlString2)

        Dim query As String = String.Empty
        query = "INSERT INTO means ([name] ,[string] ,[type] ,[id] ,[status] ,[rule],
                                      [hardware_type] ,[pump] ,[employee_type] ,[plate] ,[model_id] ,[YEAR] ,[capacity],
                                      [consumption] ,[odometer] ,[cust_id] ,[address] ,[fleet_id] ,[dept_id] ,[acctyp],
                                      [available_amount] ,[update_timestamp] ,[fcc_bos_cleared] ,[use_pin_code] ,[pin_code],[auth_pin_from],[auttyp],[is_burned],[opos_plate_check_type],[nr_plate_retries],issued_date,[prompt_always_for_viu],[expire_date])
                            VALUES (  @name ,@string ,@type , (select id from indexes where name='means'),@status,@rule ,@hardware_type ,@pump ,
                                      @employee_type     ,@plate ,@model_id ,@YEAR ,@capacity ,@consumption ,@odometer ,@cust_id ,@address ,@fleet_id,
                                      (select top 1 id from depts where fleet_id= " & Ccust_id & ") ,@acctyp ,@available_amount ,GetDate() ,@fcc_bos_cleared ,@use_pin_code ,@pin_code,@auth_pin_from,@auttyp,@is_burned,@opos_plate_check_type,@nr_plate_retries,GetDate(),@prompt_always_for_viu,@expire_date )"
        Using conn As New SqlConnection(OrbakString)
            conn.Open()

            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@name", Cname)
                    .Parameters.AddWithValue("@string", Cstring)
                    .Parameters.AddWithValue("@type", 2)
                    .Parameters.AddWithValue("@status", 2)
                    .Parameters.AddWithValue("@rule", Crule)
                    .Parameters.AddWithValue("@hardware_type", 1)
                    .Parameters.AddWithValue("@pump", 0)
                    .Parameters.AddWithValue("@employee_type", 1)
                    .Parameters.AddWithValue("@plate", Cplate)
                    .Parameters.AddWithValue("@model_id", 0)
                    .Parameters.AddWithValue("@YEAR", 1900)
                    .Parameters.AddWithValue("@capacity", 0)
                    .Parameters.AddWithValue("@consumption", 0)
                    .Parameters.AddWithValue("@odometer", 0.000000)
                    .Parameters.AddWithValue("@cust_id", "")
                    .Parameters.AddWithValue("@address", "")
                    .Parameters.AddWithValue("@fleet_id", Ccust_id)
                    .Parameters.AddWithValue("@acctyp", 0)
                    .Parameters.AddWithValue("@available_amount", 0)
                    .Parameters.AddWithValue("@fcc_bos_cleared", 0)
                    .Parameters.AddWithValue("@use_pin_code", 0)
                    .Parameters.AddWithValue("@pin_code", 0)
                    .Parameters.AddWithValue("@auth_pin_from", 2)
                    .Parameters.AddWithValue("@auttyp", 14)
                    .Parameters.AddWithValue("@is_burned", 1)
                    .Parameters.AddWithValue("@opos_plate_check_type", 1)
                    .Parameters.AddWithValue("@nr_plate_retries", 0)
                    .Parameters.AddWithValue("@prompt_always_for_viu", 1)
                    .Parameters.AddWithValue("@expire_date", 0)

                    comm.ExecuteNonQuery()
                End With
            End Using
        End Using

        Dim sql As New SQLControl
        sql.RunQuery("select id from means where string='" & Cstring & "' and name ='" & Cname & "'")
        Dim CardID As Integer = CInt(sql.SQLDS.Tables(0).Rows(0).Item("id"))
        '  If String.IsNullOrEmpty(CStr(CardID)) Then Exit Sub

        MsgBox(IssueToStations(CardID, 17))

    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEdit1.EditValueChanged
        Try
            Dim sql As New SQLControl
            Dim SqlString As String = " select top 1 id from fleets where code='" & CStr(SearchLookUpEdit1.EditValue) & "'   "
            sql.RunQuery(SqlString)
            TextFleetID.Text = sql.SQLDS.Tables(0).Rows(0).Item("id").ToString
        Catch ex As Exception
            TextFleetID.Text = "0"
        End Try

    End Sub

    Private Sub View_ValidateRow(ByVal sender As Object, ByVal e As ValidateRowEventArgs) Handles GridView2.ValidateRow

        Try

            Dim view As ColumnView = TryCast(sender, ColumnView)

            Dim _ColPlateNo As GridColumn = view.Columns("PlateNo")
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "PlateNo")) = True Then
                e.Valid = False
                e.ErrorText = "Error!!!"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _ColPlateNo
                view.ShowEditor()
            End If

            If CheckIfPlateExist(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "PlateNo").ToString) = True Then
                e.Valid = False
                e.ErrorText = "رقم المركبة موجود مسبقا"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _ColPlateNo
                view.ShowEditor()
            End If


            Dim _GroupRule As GridColumn = view.Columns("GroupRule")
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "GroupRule")) = True Then
                e.Valid = False
                e.ErrorText = "يجب اختيار سقف للمركبة"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _ColPlateNo
                view.ShowEditor()
            End If


            Dim _CardSerial As GridColumn = view.Columns("CardSerial")
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "CardSerial")) = True Then
                e.Valid = False
                e.ErrorText = "سيريال البطاقة فارغة"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _CardSerial
                view.ShowEditor()
            End If



            If CheckIfSerialExist(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "CardSerial").ToString) = True Then
                e.Valid = False
                e.ErrorText = "رقم السريال موجود مسبقا"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _CardSerial
                view.ShowEditor()
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub TableView_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetRowCellValue(e.RowHandle, "GroupRule", "200000000")
    End Sub

    Private Sub RepositoryPlateNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RepositoryPlateNo.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890-/"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RepositoryCardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RepositoryCardNo.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Function GetFleets() As DataTable
        Dim FleetTable As New DataTable
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = "Select AccountKey,FullName,F.ID as AccountID from   [WIZCOUNT].[ALHUDA].[dbo].[Accounts] A
					 Right join fleets F
					 On A.AccountKey=CONVERT(nvarchar, CONVERT(VARCHAR(12), F.code))
                     where F.status <> 0 order by AccountKey desc ,SortGroup  "
            sql.RunQuery(SqlString)
            FleetTable = sql.SQLDS.Tables(0)
        Catch ex As Exception
            Return FleetTable
        End Try
        Return FleetTable

    End Function

End Class