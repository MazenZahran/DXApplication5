Public Class FinancialChequesBackFromBankStatment
    Private Sub FinancialChequesBackFromBankStatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Cheqs1' table. You can move, or remove it, as needed.
        Me.Cheqs1TableAdapter.Fill(Me.WizCountDataSet.Cheqs1)
        'TODO: This line of code loads data into the 'CRMDataSet.FinancialChequesBack' table. You can move, or remove it, as needed.
        Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class