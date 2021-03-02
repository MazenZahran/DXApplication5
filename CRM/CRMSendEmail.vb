Public Class CRMSendEmail
    Private Sub CRMSendEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            Dim SortGroup As String = CStr(SearchSortGroup.EditValue)

            SqlString = " Select JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,'' As Notes,ASPHONE,
                                       ISNULL(DebitBalance, 0 ) as DebitBalance ,ACITY
                          From 
                                        ( SELECT   JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,  cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance ,'Station' As VoucherType,ACITY  ,ASPHONE  
                                         From RPHSTRANSRETRIV
                                         WHERE  JBATCHNO <> 9990 and JMDEBITCREDIT=1 and       ( ASORTGROUP = '2000' 
                                         AND  (DatePart(MONTH, JVALUEDATE)=3 and DatePart(Year, JVALUEDATE)=2020 ) 
                                         AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 
                                        GROUP BY JMACCOUNTKEY,AFULLNAME,Afilter,AEmail,ASORTGROUP,ACOSTCODE,AADDRESS,ACITY,ASPHONE) AA  "

            sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class