Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Windows
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class VouchersWriting
    Dim ShowPrintPreview As Boolean = False
    Private Sub VouchersWriting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.CostCodes' table. You can move, or remove it, as needed.
        Me.CostCodesTableAdapter.Fill(Me.WizCountDataSet.CostCodes)
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)
        ' Me.VoucherDate.DateTime = New DateTime(CInt(Format(Today, "yyyy")), CInt(Format(Today, "MM")) - 1, DateTime.DaysInMonth(CInt(Format(Today, "yyyy")), CInt(Format(Today, "MM")) - 1))

        Me.TextMonth.EditValue = CInt(Format(Today, "MM")) - 1
        If CInt(Format(Today, "MM")) = 1 Then Me.TextMonth.EditValue = 12
        Me.TextYear.Text = Format(Today, "yyyy")
        If CInt(Format(Today, "MM")) = 1 Then Me.TextYear.EditValue = CInt(Format(Today, "yyyy")) - 1
        Me.VoucherDate.DateTime = New DateTime(CInt(Me.TextYear.Text), CInt(Me.TextMonth.Text), DateTime.DaysInMonth(CInt(Me.TextYear.Text), CInt(Me.TextMonth.Text)))
        '
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetVouchers()
        BandedGridView1.BestFitColumns()
    End Sub

    Private Sub GetVouchers()
        Try
            Dim DateFrom As String = Format(VoucherDate.DateTime, "yyyy-MM-dd")

            Dim Sort As String = CStr(SearchSort.EditValue)
            Dim Area As String = CStr(SearchArea.EditValue)
            If String.IsNullOrEmpty(Sort) Then Sort = "%%"
            If String.IsNullOrEmpty(Area) Then Area = "%%"
            Dim sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,'' As Notes,
                                       ISNULL(DebitBalance, 0 ) as DebitBalance ,ISNULL(DebitInData, 0 ) as DebitInData ,ISNULL((CAST( DebitInData-DebitBalance AS int)),0) as Diff ,'True' as IssueVoucher,'' As VouchNo,
                                       CONVERT(varchar(255), NEWID()) As VoucherCode,VoucherType,ACITY,ISNULL(LastVouchers, 0 ) as LastVouchers, 'True' As IssueTrans
                          From 

                                        ( SELECT   JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,  cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance ,'Station' As VoucherType,ACITY    
                                         From RPHSTRANSRETRIV
                                         WHERE  JBATCHNO <> 9990 and JMDEBITCREDIT=1 and       ( ASORTGROUP = '" & Sort & "' 
                                         AND  (DatePart(MONTH, JVALUEDATE)=" & TextMonth.Text & " and DatePart(Year, JVALUEDATE)=" & TextYear.Text & " ) 
                                         AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 
                                        GROUP BY JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,ACITY) AA 

                          Left join 
                                       ( SELECT [FleetCode],SUM(totalsale) as DebitInData 
                                         FROM [CRM].[dbo].[DATA]
                                         where [TransMonth]=" & TextMonth.Text & " and [TransYear]=" & TextYear.Text & " and StationName<>'Stock'
                                         group by [FleetCode] ) BB
                          On AA.JMACCOUNTKEY=BB.FleetCode 

                          Left join 
                                      (select CustID,ISNULL(SUM([Amount]),0) as LastVouchers
                                       from [CRM].[dbo].[VouchersHeader]
                                       where VoucherMonth=" & TextMonth.Text & " and VoucherYear=" & TextYear.Text & " and VoucherType<>'Stock' group by CustID) DD
                          on AA.JMACCOUNTKEY=DD.CustID


                          union 

                          Select JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,'' As Notes,
                                       DebitBalance,DebitInData,(DebitInData-DebitBalance) as Diff ,'True' as IssueVoucher,'' As VouchNo,
                                       CONVERT(varchar(255), NEWID()) As VoucherCode,VoucherType,ACITY,ISNULL(LastVouchers, 0 ) as LastVouchers, 'True' As IssueTrans
                          From 
                                        ( SELECT   JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,  cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance  , 'Stock' As VoucherType,ACITY   
                                         From RPHSTRANSRETRIV
                                         WHERE  JBATCHNO=9990 and JMDEBITCREDIT=1 and       ( ASORTGROUP = '" & Sort & "'  
                                         AND  (DatePart(MONTH, JVALUEDATE)=" & TextMonth.Text & " and DatePart(Year, JVALUEDATE)=" & TextYear.Text & " ) 
                                         AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 
                                        GROUP BY JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,ACITY) AA 
                           left join 
                                       ( SELECT [FleetCode],SUM(totalsale) as DebitInData 
                                         FROM [CRM].[dbo].[DATA]
                                         where [TransMonth]=" & TextMonth.Text & " and [TransYear]=" & TextYear.Text & " and StationName='Stock'
                                         group by [FleetCode] ) BB
                           On AA.JMACCOUNTKEY=BB.FleetCode

                          Left join 
                                      (select CustID,SUM([Amount]) as LastVouchers
                                       from [CRM].[dbo].[VouchersHeader]
                                       where VoucherMonth=" & TextMonth.Text & " and VoucherYear=" & TextYear.Text & " and VoucherType='Stock' group by CustID) DD
                          on AA.JMACCOUNTKEY=DD.CustID

                           order by JMACCOUNTKEY"
            sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
            'Dim _RowsCount As Integer = BandedGridView1.RowCount
            'For i = 0 To _RowsCount - 1
            '    BandedGridView1.SetRowCellValue(i, ColNotes, "يجب تسديد الفاتورة قبل تاريخ " & VoucherDate.Text)
            'Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim TempVoucherCode As String = ""
        Dim _WriteUser As String = CStr(GlobalVariables.UserNameString)
        Dim _VouchDate As String = Format(VoucherDate.DateTime, "yyyy-MM-dd")

        Dim _RowsCount As Integer = BandedGridView1.RowCount

        If XtraMessageBox.Show("هل تريد اصدار فواتير عدد " & _RowsCount, "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim query As String = String.Empty
        query = "INSERT INTO VouchersHeader ([VouchNo] ,[VouchDate],[CustID],[CustName],[CustSort], 
                                             [CustArea], [CustAddress], [WriteUser], [Amount], [Currency],
                                             [AmountNIS], [VoucherCode], [Notes],[VoucherMonth],[VoucherYear],VoucherType,InputDateTime)
                             VALUES ( @VoucherNo ,@VouchDate,@CustID,@CustName,@CustSort, 
                                      @CustArea,@CustAddress,@WriteUser,@Amount,@Currency,@AmountNIS,@VoucherCode,@Notes,@VoucherMonth,@VoucherYear,@VoucherType,convert(varchar, getdate(), 20))"
        Using conn As New SqlConnection(CRMString)
            conn.Open()
            For i = 0 To _RowsCount - 1
                Dim AccountID As String = Me.BandedGridView1.GetRowCellValue(i, "JMACCOUNTKEY").ToString
                If Me.BandedGridView1.GetRowCellValue(i, "IssueVoucher").ToString = "True" Then

                    Using comm As New SqlCommand()
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@VoucherNo", SetVoucherNo(CInt(TextMonth.Text), CInt(TextYear.Text)))
                            .Parameters.AddWithValue("@VouchDate", _VouchDate)
                            .Parameters.AddWithValue("@CustID", AccountID)
                            .Parameters.AddWithValue("@CustName", Me.BandedGridView1.GetRowCellValue(i, "AFULLNAME").ToString)
                            .Parameters.AddWithValue("@CustSort", Me.BandedGridView1.GetRowCellValue(i, "ASORTGROUP").ToString)
                            .Parameters.AddWithValue("@CustArea", Me.BandedGridView1.GetRowCellValue(i, "ACOSTCODE").ToString)
                            .Parameters.AddWithValue("@CustAddress", CStr(Me.BandedGridView1.GetRowCellDisplayText(i, "ACOSTCODE")) + " " + Me.BandedGridView1.GetRowCellValue(i, "AADDRESS").ToString)
                            .Parameters.AddWithValue("@WriteUser", _WriteUser)
                            .Parameters.AddWithValue("@Amount", CDec(Me.BandedGridView1.GetRowCellValue(i, "DebitInData")))
                            .Parameters.AddWithValue("@Currency", "NIS")
                            .Parameters.AddWithValue("@AmountNIS", CDec(Me.BandedGridView1.GetRowCellValue(i, "DebitInData")))
                            .Parameters.AddWithValue("@VoucherCode", Me.BandedGridView1.GetRowCellValue(i, "VoucherCode").ToString)
                            .Parameters.AddWithValue("@Notes", Me.BandedGridView1.GetRowCellValue(i, "Notes").ToString)
                            .Parameters.AddWithValue("@VoucherMonth", TextMonth.Text)
                            .Parameters.AddWithValue("@VoucherYear", TextYear.Text)
                            .Parameters.AddWithValue("@VoucherType", Me.BandedGridView1.GetRowCellValue(i, "VoucherType").ToString)
                            comm.ExecuteNonQuery()
                        End With
                    End Using

                    Try
                        Dim SqlString As String
                        Dim Sql As New SQLControl
                        SqlString = " select VouchNo from VouchersHeader where VoucherCode='" & Me.BandedGridView1.GetRowCellValue(i, "VoucherCode").ToString & "' "
                        Sql.CRMRunQuery(SqlString)
                        BandedGridView1.SetRowCellValue(i, ColVouchNo, Sql.SQLDS.Tables(0).Rows(0).Item("VouchNo"))
                    Catch ex As Exception
                        BandedGridView1.SetRowCellValue(i, ColVouchNo, "0")
                    End Try


                    Dim Sql2 As New SQLControl
                    Dim SqlInsertDetials As String
                    SqlInsertDetials = "    insert into [CRM].[dbo].VouchersDetails (VoucherCode,VouchNo,SotckName,Quantity,Price,Amount )
                                                select VoucherCode,VouchNo,ProductName,Quantity,price,Amount from 
                                                        (select [FleetCode],[TransMonth],[TransYear],ProductName,SUM([Quantity]) as Quantity,
                                                        case when SUM([Quantity]) =0 then 0 else  SUM(totalsale)/SUM([Quantity]) end as price, SUM(totalsale) as Amount 
                                                        FROM [CRM].[dbo].[DATA]
                                                        where [FleetCode]='" & AccountID & "' and [TransMonth]='" & TextMonth.Text & "' and [TransYear]=" & TextYear.Text
                    If Me.BandedGridView1.GetRowCellValue(i, "VoucherType").ToString = "Stock" Then
                        SqlInsertDetials += " and stationName ='Stock' "
                    ElseIf Me.BandedGridView1.GetRowCellValue(i, "VoucherType").ToString <> "Stock" Then
                        SqlInsertDetials += " and stationName <> 'Stock' "
                    End If
                    SqlInsertDetials += "      group by ProductName,[FleetCode],[TransMonth],[TransYear]) AA
                                                left Join 
                                                    (Select CustID,[VoucherMonth],VoucherYear,VoucherCode,VouchNo
                                                     FROM [CRM].[dbo].[VouchersHeader] where VouchNo='" & Me.BandedGridView1.GetRowCellValue(i, "VouchNo").ToString & "' and CustID='" & AccountID & "' and [VoucherMonth]='" & TextMonth.Text & "' and [VoucherYear]= " & TextYear.Text & "  ) BB
                                                on AA.FleetCode=BB.CustID "
                    Sql2.CRMRunQuery(SqlInsertDetials)

                    PrintVoucher(True, CInt(BandedGridView1.GetRowCellValue(i, "VouchNo")), False, "NIS")


                    If CheckEditSendEmail.Checked = True And Not IsDBNull(BandedGridView1.GetRowCellValue(i, "AEmail")) Then
                        EmailVoucher(False, CInt(BandedGridView1.GetRowCellValue(i, "VouchNo")), CStr(BandedGridView1.GetRowCellValue(i, "AEmail")))
                        PrintDataTrans(TextMonth.Text, TextYear.Text, AccountID, "Email", False)
                    End If

                End If

                If Me.BandedGridView1.GetRowCellValue(i, "IssueTrans").ToString = "True" Then
                    If CheckEditAccountBalance.Checked = True Then
                        PrintDataTrans(TextMonth.Text, TextYear.Text, AccountID, "Print", True)
                    Else
                        PrintDataTrans(TextMonth.Text, TextYear.Text, AccountID, "Print", False)
                    End If

                    If CheckEditSendEmail.Checked = True Then
                        PrintDataTrans(TextMonth.Text, TextYear.Text, AccountID, "Email", False)
                    End If
                End If

                BandedGridView1.RefreshData()
                GridControl1.Refresh()

            Next
        End Using

        GetVouchers()
        MsgBox("تم")
    End Sub


    Private Sub RepositoryProcess_Click(sender As Object, e As EventArgs) Handles RepositoryProcess.Click
        Try
            My.Forms.VouchersProccess.YyearText.Text = Me.TextYear.Text
            My.Forms.VouchersProccess.MmonthText.Text = Me.TextMonth.Text
            My.Forms.VouchersProccess.SearchFleetID.EditValue = BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "JMACCOUNTKEY")
            My.Forms.VouchersProccess.TextDiff.Text = CStr(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "Diff"))
            VouchersProccess.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub VoucherDate_EditValueChanged(sender As Object, e As EventArgs) Handles VoucherDate.EditValueChanged
        '   Me.MemoEdit1.Text = "يجب تسديد الفاتورة قبل تاريخ " & " " & VoucherDate.DateTime.AddMonths(1)
    End Sub

    Private Sub RepositoryOpenCust_Click(sender As Object, e As EventArgs) Handles RepositoryOpenCust.Click
        My.Forms.FinanceAccDetails.TextEditAccountKey.Text = CStr(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "JMACCOUNTKEY"))
        FinanceAccDetails.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class