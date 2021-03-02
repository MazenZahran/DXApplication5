Public Class FinanceCustomersBalancesWithPeriodsDet
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If String.IsNullOrEmpty(TextSortFrom.Text) Or String.IsNullOrEmpty(TextSortTo.Text) Then
            MsgBox("يجب تعبئى  كل البيانات")
            Exit Sub
        End If

        If CInt(TextSortFrom.Text) < 2000 Or CInt(TextSortFrom.Text) > 2700 Then
            MsgBox("لا يوجد صلاحية")
            Exit Sub
        End If

        If CInt(TextSortTo.Text) < 2000 Or CInt(TextSortTo.Text) > 2700 Then
            MsgBox("لا يوجد صلاحية")
            Exit Sub
        End If

        Dim Sql As New SQLControl
        Dim SqlString As String
        SqlString = "
Declare @FromDate datetime
set @FromDate ='" & Format(DateFrom.DateTime, "yyyy-MM-dd") & "'

Declare @ToDate datetime
set @ToDate ='" & Format(DateTo.DateTime, "yyyy-MM-dd") & "'

Declare @FromSort int
set @FromSort ='" & TextSortFrom.Text & "'
Declare @ToSort int
set @ToSort ='" & TextSortTo.Text & "'


Select sum(BegBalance) as BegBalance ,sum(Debit) as Debit,sum(Credit) as Credit,sum(EndBalance) as EndBalance,sum(OldDebit) as OldDebit,SortCodeName from 
(
Select AccountKey,AccountName,BegBalance,Debit,Credit,EndBalance,(EndBalance-Debit) as OldDebit ,AccountSort,SortCodeName  FROM
(select A.JMACCOUNTKEY as AccountKey,E.FullName AS AccountName, E.SortGroup as AccountSort , (isnull(A.DebitBalance,0) - isnull(B.CreditBalance,0)) As BegBalance,isnull(C.DebitBalance,0) as Debit ,IsNull(D.CreditBalance,0) as Credit ,S.SortCodeName as SortCodeName,
  isnull(A.DebitBalance,0) - isnull(B.CreditBalance,0) + isnull(C.DebitBalance,0) - IsNull(D.CreditBalance,0)  as EndBalance
  from 
(SELECT   JMACCOUNTKEY , cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance     
 From RPHSTRANSRETRIV
WHERE   JMDEBITCREDIT=1 and       (  ASORTGROUP between @FromSort and @ToSort )
AND  (JVALUEDATE < @FromDate) Group by JMACCOUNTKEY ) A
left Join 
(SELECT   JMACCOUNTKEY , cast(  sum( JMSUF ) as decimal(10,2)) As CreditBalance     
 From RPHSTRANSRETRIV
WHERE   JMDEBITCREDIT=0 and       ( ASORTGROUP between @FromSort and @ToSort)
AND  (JVALUEDATE < @FromDate ) Group by JMACCOUNTKEY ) B  
on A.JMACCOUNTKEY=B.JMACCOUNTKEY
Left Join
(SELECT   JMACCOUNTKEY , cast(sum( JMSUF ) as decimal(10,2)) As DebitBalance     
From RPHSTRANSRETRIV
WHERE   JMDEBITCREDIT=1 and       (  ASORTGROUP between @FromSort and @ToSort )
AND  (JVALUEDATE between @FromDate and @ToDate) Group by JMACCOUNTKEY ) C
on A.JMACCOUNTKEY=C.JMACCOUNTKEY 
left Join
(SELECT   JMACCOUNTKEY , cast(sum( JMSUF ) as decimal(10,2)) As CreditBalance     
From RPHSTRANSRETRIV
WHERE   JMDEBITCREDIT=0 and       (  ASORTGROUP between @FromSort and @ToSort )
AND  (JVALUEDATE between @FromDate and @ToDate) Group by JMACCOUNTKEY ) D
On A.JMACCOUNTKEY=D.JMACCOUNTKEY 
left join Accounts E on E.AccountKey=A.JMACCOUNTKEY
left join AccSortNames S on E.SortGroup=S.AccSortCode
where  (isnull(A.DebitBalance,0) - isnull(B.CreditBalance,0) + isnull(C.DebitBalance,0) - IsNull(D.CreditBalance,0)) > 0 
) Z 
)   X
 group by SortCodeName
 "
        Sql.WizCountRunQuery(SqlString)
        GridControl1.DataSource = Sql.SQLDS.Tables(0)
    End Sub

    Private Sub FinanceCustomersBalancesWithPeriodsDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ToDateString As New Date(Today.Year, Today.Month - 1, System.DateTime.DaysInMonth(Today.Year, Today.Month - 1))
        Dim FromDateString As New Date(Today.Year, Today.Month - 1, 1)
        DateFrom.DateTime = CDate(FromDateString)
        DateTo.DateTime = CDate(ToDateString)
    End Sub
End Class