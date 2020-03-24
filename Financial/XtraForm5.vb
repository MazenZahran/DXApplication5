Public Class XtraForm5
    Private Sub FinancialChequesBackBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FinancialChequesBackBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FinancialChequesBackBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub XtraForm5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.FinancialChequesBack' table. You can move, or remove it, as needed.
        Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)

    End Sub
End Class