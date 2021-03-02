Public Class FinanceEditTransNote
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        UpdateTrans(CInt(TextTransID.EditValue), MemoEdit1.Text)
        MemoEdit1.Text = GetTransIDData(CInt(TextTransID.EditValue))
    End Sub

    Private Sub TextTransID_EditValueChanged(sender As Object, e As EventArgs) Handles TextTransID.EditValueChanged
        MemoEdit1.Text = GetTransIDData(CInt(TextTransID.EditValue))
    End Sub
End Class