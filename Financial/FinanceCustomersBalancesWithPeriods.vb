Public Class FinanceCustomersBalancesWithPeriods
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetReport()
    End Sub

    Private Sub GetReport()


        Try
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
            SplashScreenManager1.ShowWaitForm()
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

Select AccountKey,AccountName,BegBalance,Debit,Credit,EndBalance,(EndBalance-Debit) as OldDebit ,LastTransDate,FleetStatus,FleetID,AccountSort,SortCodeName  FROM
(select A.JMACCOUNTKEY as AccountKey ,E.FullName AS AccountName ,E.SortGroup as AccountSort, (isnull(A.DebitBalance,0) - isnull(B.CreditBalance,0)) As BegBalance,isnull(C.DebitBalance,0) as Debit ,IsNull(D.CreditBalance,0) as Credit ,SortCodeName,
  isnull(A.DebitBalance,0) - isnull(B.CreditBalance,0) + isnull(C.DebitBalance,0) - IsNull(D.CreditBalance,0)  as EndBalance,LastTransDate,Case when FF.[status]=1 then 'Blocked' when FF.[status]=2 then 'Active' End as FleetStatus,isnull(FF.ID,0) as FleetID
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
left join [HO].[ho_data].dbo.[fleets] FF on FF.Code=A.JMACCOUNTKEY
left join AccSortNames S on E.SortGroup=S.AccSortCode
left join 
(Select  max(JVALUEDATE) as LastTransDate,JMACCOUNTKEY  from [ALHUDA].[dbo].RPHSTRANSRETRIV WHERE    (  ASORTGROUP between @FromSort and @ToSort )
AND  (JVALUEDATE < @FromDate) group by JMACCOUNTKEY  ) F
on F.JMACCOUNTKEY=A.JMACCOUNTKEY
where (isnull(A.DebitBalance,0) - isnull(B.CreditBalance,0) + isnull(C.DebitBalance,0) - IsNull(D.CreditBalance,0)) > 0 
) Z
order by LastTransDate  "
            Sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try


        SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub FinanceCustomersBalancesWithPeriods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ToDateString As New Date(Today.Year, Today.Month - 1, System.DateTime.DaysInMonth(Today.Year, Today.Month - 1))
        Dim FromDateString As New Date(Today.Year, Today.Month - 1, 1)
        ' Me.DateFrom.DateTime = startDt
        DateFrom.DateTime = CDate(FromDateString)
        DateTo.DateTime = CDate(ToDateString)
    End Sub

    Private Sub ColStop_Click(sender As Object, e As EventArgs) Handles ColStop.Click
        Dim J As Integer = 0
        For i As Integer = 0 To GridView1.DataRowCount - 1
            If GridView1.IsRowSelected(i) = True Then
                Dim _AccountKey As Integer = CInt(Me.GridView1.GetRowCellValue(i, "AccountKey"))
                Dim _FleetID As Integer = CInt(Me.GridView1.GetRowCellValue(i, "FleetID"))
                Dim _Status As String = CStr(Me.GridView1.GetRowCellValue(i, "FleetStatus"))
                If _Status = "Active" Then
                    If StopFleet(_FleetID, 1) = False Then
                        MsgBox("لا يمكن ايقاف زبون " & _FleetID)
                    Else
                        J += 1
                    End If
                End If
            End If
        Next
        MsgBox("تم ايقاف زبائن عدد: " & J)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class