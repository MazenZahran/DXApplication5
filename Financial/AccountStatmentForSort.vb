Public Class AccountStatmentForSort
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim Sql As New SQLControl
        Dim SqlString As String = " SELECT a.SalaryAccountNo,a.EmployeeName,a.Branch
  FROM [truetime].[dbo].EmployeesData a
  left join  [ALHUDA].[dbo].[Accounts] b
  on a.SalaryAccountNo =b.AccountKey"
        Sql.WizCountRunQuery(SqlString)
        GridAccounts.DataSource = Sql.SQLDS.Tables(0)

    End Sub
End Class