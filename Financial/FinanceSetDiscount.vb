Imports DevExpress.XtraEditors

Public Class FinanceSetDiscount
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        GetData()

    End Sub
    Private Sub GetData()
        Try
            If String.IsNullOrEmpty(SearchSorts.Text) Or TypeOf (SearchSorts.EditValue) Is DBNull Then
                MsgBox("يجب اختيار تصنيف")
                Exit Sub
            End If

            Dim DiscountTable As New DataTable
            Dim sql As New SQLControl
            Dim SQLString As String = " select AccountKey,FullName from ALHUDA.dbo.Accounts where SortGroup ='" & CStr(SearchSorts.EditValue) & "'"
            sql.WizCountRunQuery(SQLString)
            DiscountTable = sql.SQLDS.Tables(0)

            With DiscountTable
                .Columns.Add("103", GetType(Integer))
                .Columns.Add("103ID", GetType(Integer))
                .Columns.Add("108", GetType(Integer))
                .Columns.Add("108ID", GetType(Integer))
            End With

            For i = 0 To DiscountTable.Rows.Count - 1

                Dim sql2 As New SQLControl
                sql2.WalletRunQuery("select PRICE,ID from [WALLET].[dbo].[SPECIALPRICES] where ACCOUNTKEY='" & DiscountTable.Rows(i).Item("AccountKey").ToString & "' and ITEMKEY='103'")
                If sql2.SQLDS.Tables(0).Rows.Count > 0 Then
                    DiscountTable.Rows(i).Item("103") = sql2.SQLDS.Tables(0).Rows(0).Item("PRICE")
                    DiscountTable.Rows(i).Item("103ID") = sql2.SQLDS.Tables(0).Rows(0).Item("ID")
                Else
                    DiscountTable.Rows(i).Item("103") = "0"
                    DiscountTable.Rows(i).Item("103ID") = 0
                End If

                Dim sql3 As New SQLControl
                sql3.WalletRunQuery("select PRICE,ID from [WALLET].[dbo].[SPECIALPRICES] where ACCOUNTKEY='" & DiscountTable.Rows(i).Item("AccountKey").ToString & "' and ITEMKEY='108'")
                If sql3.SQLDS.Tables(0).Rows.Count > 0 Then
                    DiscountTable.Rows(i).Item("108") = sql3.SQLDS.Tables(0).Rows(0).Item("PRICE")
                    DiscountTable.Rows(i).Item("108ID") = sql3.SQLDS.Tables(0).Rows(0).Item("ID")
                Else
                    DiscountTable.Rows(i).Item("108") = "0"
                    DiscountTable.Rows(i).Item("108ID") = 0
                End If

            Next

            GridControl1.DataSource = DiscountTable
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FinanceSetDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            '    'ط  Dim UserNo As Integer = SearchLookUpEdit1.EditValue

            For i = 0 To GridView1.RowCount - 1

                Dim _103ID As Integer = 0
                Dim _108ID As Integer = 0


                _103ID = CInt(GridView1.GetRowCellValue(i, GridView1.Columns("103ID")).ToString)
                _108ID = CInt(GridView1.GetRowCellValue(i, GridView1.Columns("108ID")).ToString)

                Dim ACCOUNTKEY As String = "0"
                ACCOUNTKEY = CStr(GridView1.GetRowCellValue(i, GridView1.Columns("AccountKey")))

                Dim ITEMKEY As Integer = 0
                ITEMKEY = CInt(GridView1.GetRowCellValue(i, GridView1.Columns("ITEMKEY")))

                Dim _103PRICE As Decimal = 0
                _103PRICE = CDec(GridView1.GetRowCellValue(i, GridView1.Columns("103")))

                Dim _108PRICE As Decimal = 0
                _108PRICE = CDec(GridView1.GetRowCellValue(i, GridView1.Columns("108")))

                _103ID = CInt(GridView1.GetRowCellValue(i, GridView1.Columns("103ID")))
                _108ID = CInt(GridView1.GetRowCellValue(i, GridView1.Columns("108ID")))


                '        AddAccessValue = CBool(GridView2.GetRowCellValue(i, GridView2.Columns("AddAccess")))
                '        DeleteAccessValue = CBool(GridView2.GetRowCellValue(i, GridView2.Columns("DeleteAccess")))
                '        VisibleAccessValue = CBool(GridView2.GetRowCellValue(i, GridView2.Columns("VisibleAccess")))
                '        EditAccessValue = CBool(GridView2.GetRowCellValue(i, GridView2.Columns("EditAccess")))


                If CInt(GridView1.GetRowCellValue(i, GridView1.Columns("103ID"))) = 0 Then
                    If _103PRICE > 0 And _103PRICE <= 20 Then InsertAccess(ACCOUNTKEY, 103, _103PRICE)
                Else
                    If _103PRICE >= 0 And _103PRICE <= 20 Then UpdateAccess(_103PRICE, _103ID)
                End If

                If CInt(GridView1.GetRowCellValue(i, GridView1.Columns("108ID"))) = 0 Then
                    If _108PRICE > 0 And _108PRICE <= 30 Then InsertAccess(ACCOUNTKEY, 108, _108PRICE)
                Else
                    If _108PRICE >= 0 And _108PRICE <= 30 Then UpdateAccess(_108PRICE, _108ID)
                End If
            Next

            '    CreateDataTable()

            XtraMessageBox.Show("تم حفظ الاسعار")
            GetData()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub InsertAccess(AccountKey As String, ItemKey As Integer, Dicount As Decimal)
        Dim InsertString As String = "Insert into [WALLET].[dbo].[SPECIALPRICES] (ACCOUNTKEY,[ITEMKEY],[PRICE]) Values  
                                            (" & AccountKey & ", '" & ItemKey & "'," & Dicount & ")"
        Dim SQl As New SQLControl
        SQl.WalletRunQuery(InsertString)
    End Sub

    Private Sub UpdateAccess(Dicount As Decimal, ID As Integer)
        Dim UpdateString As String = " Update  [WALLET].[dbo].[SPECIALPRICES] Set
                                              PRICE= " & Dicount & "
                                       Where ID=" & ID

        Dim SQl As New SQLControl
        SQl.WalletRunQuery(UpdateString)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim i As Integer

        For i = 0 To GridView1.RowCount - 1
            If CheckEdit1.Checked = True Then GridView1.SetRowCellValue(i, Col103, Text103.Text)
            If CheckEdit2.Checked = True Then GridView1.SetRowCellValue(i, Col108, Text108.Text)
        Next i
    End Sub

    Private Sub Text103_EditValueChanged(sender As Object, e As EventArgs) Handles Text103.EditValueChanged
        Try
            If CInt(Text103.EditValue) < 0 Or CInt(Text103.EditValue) > 20 Then
                Text103.EditValue = 0
            End If
        Catch ex As Exception
            Text103.EditValue = 0
        End Try

    End Sub

    Private Sub Text108_EditValueChanged(sender As Object, e As EventArgs) Handles Text108.EditValueChanged
        Try
            If CInt(Text108.EditValue) < 0 Or CInt(Text108.EditValue) > 30 Then
                Text108.EditValue = 0
            End If
        Catch ex As Exception
            Text108.EditValue = 0
        End Try

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            Text103.ReadOnly = False
        Else
            Text103.ReadOnly = True
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
            Text108.ReadOnly = False
        Else
            Text108.ReadOnly = True
        End If
    End Sub
End Class