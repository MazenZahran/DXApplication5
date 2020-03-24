Public Class CRMSendSMSMessages
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim CustMobile As String
        CustMobile = TextMobileNo.Text
        If Not String.IsNullOrEmpty(CustMobile) And Len(MemoEdit1.Text) > 2 And Len(MemoEdit1.Text) < 200 Then
            TextResponse.Text = FunSendSmS2(CustMobile, MemoEdit1.Text)
        End If
    End Sub

    Private Sub MemoEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles MemoEdit1.EditValueChanged
        TextLetters.Text = "عدد الحروف" & " " & CStr(Len(MemoEdit1.Text))
    End Sub
End Class