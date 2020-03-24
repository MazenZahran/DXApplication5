Public Class FinanceSetDiscount
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim SqlString As String = " SELECT  S.[AccountKey]
      ,[ITEMKEY]
      ,[PRICE]
      , A.FullName
  FROM [WALLET].[dbo].[SPECIALPRICES] s
    left join ALHUDA.dbo.Accounts A
  ON A.AccountKey COLLATE SQL_Latin1_General_CP1_CI_AS = 
S.ACCOUNTKEY  COLLATE SQL_Latin1_General_CP1_CI_AS
  where IsNumeric(A.AccountKey)=1
  and A.SortGroup =2006 "

    End Sub
End Class