
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class VouchersQuery

    Private Sub VouchersQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        GetVouchers()
    End Sub
    Private Sub GetVouchers()
        Dim SqlString As String
        Dim sql As New SQLControl
        SqlString = "    Select V.[ID]      ,[VouchNo]      ,[VouchDate]      ,[CustID]      ,[CustName]      ,[CustSort]
  ,[CustArea]      ,[CustAddress]      ,[WriteUser]      ,[Amount]      ,[Currency]      ,[AmountNIS]      ,[VoucherCode]
  ,[Notes]      ,[VoucherMonth]      ,[VoucherYear]      ,[VoucherType], A.[EMail] AS Email ,VoucherStatus,VoucherCancelledNotes,A.Country,A.SPhone,InputDateTime 
   FROM [CRM].[dbo].[VouchersHeader] V
   left join ALHUDA.dbo.Accounts A on V.CustID = A.AccountKey 
   where VoucherStatus is null "
        If CheckEdit1.Checked = True Then SqlString += "  or VoucherStatus is not null "
        sql.CRMRunQuery(SqlString)
        GridControl1.DataSource = sql.SQLDS.Tables(0)
        ' SetEmails()
        GridView1.BestFitColumns()
    End Sub

    Private Sub RepositoryPrint_Click(sender As Object, e As EventArgs) Handles RepositoryPrint.Click
        Dim _Currency As String
        _Currency = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Currency").ToString

        PrintVoucher(False, CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VouchNo")), False, _Currency)

        If CheckVoucherWithReport.Checked = True Then
            PrintDataTrans(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VoucherMonth").ToString,
                           GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VoucherYear").ToString,
                           GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CustID").ToString,
                           "Print", False)
        End If

    End Sub

    Private Sub RepositoryEmail_Click(sender As Object, e As EventArgs) Handles RepositoryEmail.Click
        Dim _EmailAddress As String
        _EmailAddress = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")).ToString
        If String.IsNullOrEmpty(_EmailAddress) Then MsgBox("الايميل فارغ") : Exit Sub
        EmailVoucher(False, CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VouchNo")), _EmailAddress)

        If CheckVoucherWithReport.Checked = True Then
            PrintDataTrans(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VoucherMonth").ToString,
GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VoucherYear").ToString,
GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CustID").ToString,
"Email", False)
        End If

    End Sub

    Private Sub RepositoryPreview_Click(sender As Object, e As EventArgs) Handles RepositoryPreview.Click
        Dim _Currency As String
        _Currency = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Currency").ToString

        PrintVoucher(False, CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VouchNo")), True, _Currency)

        If CheckVoucherWithReport.Checked = True Then
            PrintDataTrans(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VoucherMonth").ToString,
                   GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VoucherYear").ToString,
                   GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CustID").ToString,
                   "Preview", False)
        End If


    End Sub

    Private Sub SetEmails()
        Try
            Dim _RowsCount As Integer
            _RowsCount = GridView1.RowCount
            For i = 0 To _RowsCount - 1
                GridView1.SetRowCellValue(i, ColEmail, GetAccData(CStr(GridView1.GetRowCellValue(i, "CustID"))).email)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GetVouchers()
    End Sub

    Private Sub RepositoryCustDetails_Click(sender As Object, e As EventArgs) Handles RepositoryCustDetails.Click
        My.Forms.FinanceAccDetails.TextEditAccountKey.Text = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CustID"))
        FinanceAccDetails.Show()
    End Sub


    Private Sub RepositoryVoucherStatus_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryVoucherStatus.ButtonClick
        Dim result1 = XtraInputBox.Show(" صلاحية ", "الغاء فاتورة", "")
        If result1 <> "2985947" Then Exit Sub
        If XtraMessageBox.Show("هل تريد الغاء الفاتورة؟", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.No Then
            Dim VoucherNo As String = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VouchNo"))
            Dim result = XtraInputBox.Show(" سبب الالغاء " & VoucherNo, "الغاء فاتورة", "")
            If String.IsNullOrEmpty(result) Then
                MsgBox("يجب كتابة ملاحظة الغاء")
                Exit Sub
            End If

            Dim SQL As New SQLControl
            SQL.CRMRunQuery(" Update VouchersHeader
                              Set VoucherStatus='Cancelled' , 
                                 VoucherCancelledNotes='" & result & "'
                              Where VouchNo=" & VoucherNo)
            MsgBox("تم الغاء الفاتورة")

        End If
    End Sub

    Private Sub AddVocation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If (e.Control AndAlso e.Alt AndAlso e.KeyCode = Keys.P) Then
            Dim _Currency As String
            _Currency = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Currency").ToString
            PrintVoucher(True, CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VouchNo")), False, _Currency)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True 'this will prevent ding sound 

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class