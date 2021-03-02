Public Class FinancePayment
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Saving
    End Sub
    Private Sub Saving()
        Dim Sql As New SQLControl
        Dim SqlString As String
        Dim _DocDate As String = Format(DocDate.DateTime,"yyyy-MM-dd")
        Dim _AccountID As String = CStr( AccountID.EditValue)
        Dim _AccountName As String = CStr(AccountName.EditValue)
        Dim _Currency As String = CStr(Currency.EditValue)
        Dim _ExchangePrice As Decimal = CDec( ExchangePrice.EditValue)
        Dim _Cash As Decimal = CDec( Cash.EditValue)
        Dim _Checks As Decimal = CDec( Checks.EditValue)
        Dim _Other As Decimal = CDec(Other.EditValue)
        Dim _DocAmount As Decimal = CDec(DocAmount.EditValue)

        Dim _DocNotes As string = DocNotes.Text
        If String.IsNullOrEmpty(_DocDate) _
            Or String.IsNullOrEmpty(_AccountID) _
            Or String.IsNullOrEmpty(_AccountName) _
            Or String.IsNullOrEmpty(_Currency) _
            Or String.IsNullOrEmpty(CStr(_ExchangePrice)) _
            Or String.IsNullOrEmpty(CStr(_Cash)) _
            Or String.IsNullOrEmpty(CStr(_Checks)) _
            Or String.IsNullOrEmpty(CStr(_Other)) _
            Or String.IsNullOrEmpty(_DocNotes) Then
            MsgBox("يجب تعبئة كل البيانات المطلوبة")
            Exit Sub
        End If
        SqlString = " INSERT INTO [dbo].[Payments] 
(DocDate,AccountID,AccountName,Currency,DocAmount,ExchangePrice,
Cash,Checks,Other,DocNotes,InputDateTime)
Values ('" & _DocDate & "','" & _AccountID & "','" _
        & _AccountName & "','" & _Currency & "','" & _DocAmount & "','" _
        & _ExchangePrice & "','" & _Cash & "','" & _Checks & "','" & _Other & "','" & _DocNotes & "',GETDATE())"
        Sql.CRMRunQuery(SqlString)
        MsgBox("تم ترحيل ")
    End Sub

    Private Sub FinancePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountID.Properties.DataSource = GetAccounts()

    End Sub

    Private Sub AccountID_EditValueChanged(sender As Object, e As EventArgs) Handles AccountID.EditValueChanged
        Me.AccountName.Text = GetAccNAme(AccountID.Text)
    End Sub
    Private Function GetAccNAme(_AccountID As String) As String
        Dim _AccName As String = "0"
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select FullName from [dbo].[Accounts] where  AccountKey='" & _AccountID & "'"
            Sql.WizCountRunQuery(SqlString)
            _AccName = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("FullName"))
        Catch ex As Exception
            Return _AccName
        End Try
        Return _AccName
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        FinancePaymentSign.Show()
    End Sub
End Class