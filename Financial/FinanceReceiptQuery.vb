Public Class FinanceReceiptQuery
    Private Sub ReceiptDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceiptDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceiptDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub FinanceReceiptQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.ReceiptData' table. You can move, or remove it, as needed.
        Me.ReceiptDataTableAdapter.Fill(Me.CRMDataSet.ReceiptData)

    End Sub
End Class