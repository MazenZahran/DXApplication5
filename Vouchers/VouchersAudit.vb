Public Class VouchersAudit
    Private Sub VouchersAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)
        Dim ToDateString As New Date(Today.Year, Today.Month - 1, System.DateTime.DaysInMonth(Today.Year, Today.Month - 1))
        Dim FromDateString As New Date(Today.Year, Today.Month - 1, 1)
        ' Me.DateFrom.DateTime = startDt
        DateFrom.DateTime = CDate(FromDateString)
        DateTo.DateTime = CDate(ToDateString)
    End Sub

    Private Sub SearchSortFrom_EditValueChanged(sender As Object, e As EventArgs) Handles TextSortFrom.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If String.IsNullOrEmpty(TextSortFrom.Text) Or String.IsNullOrEmpty(TextSortTo.Text) Then
            MsgBox("يجب تعبئى  كل البيانات")
            Exit Sub
        End If

        If CInt(TextSortFrom.EditValue) < 2000 Or CInt(TextSortFrom.EditValue) > 2700 Then
            MsgBox("لا يوجد صلاحية")
            Exit Sub
        End If

        If CInt(TextSortTo.EditValue) < 2000 Or CInt(TextSortTo.EditValue) > 2700 Then
            MsgBox("لا يوجد صلاحية")
            Exit Sub
        End If
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = "
Declare @FromDate datetime
set @FromDate ='" & Format(DateFrom.DateTime, "yyyy-MM-dd") & "'
Declare @ToDate datetime
set @ToDate ='" & Format(DateTo.DateTime, "yyyy-MM-dd") & "'
Declare @FromSort int
set @FromSort ='" & CStr(TextSortFrom.EditValue) & "'
Declare @ToSort int
set @ToSort ='" & CStr(TextSortTo.EditValue) & "'

Select A.JMACCOUNTKEY as AccountKey ,E.FullName AS AccountName ,
E.SortGroup as AccountSort,isnull(A.DebitBalance,0) as Debit ,
SortCodeName,Isnull(VouchersAmount,0) As VouchersAmount,(isnull(A.DebitBalance,0)-Isnull(VouchersAmount,0)) As Differance
From 
	( SELECT   JMACCOUNTKEY , cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance     
	  From RPHSTRANSRETRIV
	  WHERE   JMDEBITCREDIT=1 and       (  ASORTGROUP between @FromSort and @ToSort )
			  AND  (JVALUEDATE between @FromDate and @ToDate ) Group by JMACCOUNTKEY ) A
Left Join 
	( Select CustID,Sum(AmountNIS) As VouchersAmount 
	  From [CRM].[dbo].[VouchersHeader] where VouchDate between @FromDate and @ToDate  Group By CustID ) B
On B.CustID=A.JMACCOUNTKEY
	left join Accounts E on E.AccountKey=A.JMACCOUNTKEY
	left join AccSortNames S on E.SortGroup=S.AccSortCode"
            Sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class