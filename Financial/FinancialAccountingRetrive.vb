Public Class FinancialAccountingRetrieve

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim TransNo As Integer = CInt(TextTransNo.EditValue)
        If TextFromAmount.Text = "" Or TextToAmount.Text = "" Or ToDate.ToString = "" Or FromDate.ToString = "" _
            Or TextRefFrom.Text = "" Or TextRefTo.Text = "" Or TextFromAccount.Text = "" Or TextToAccount.Text = "" Then
            MsgBox("لايمكن قبول خانة فارغة")
            Return
        End If
        RetriveData(TransNo, CDec(TextFromAmount.EditValue), CDec(TextToAmount.EditValue),
        Format(ToDate.DateTime, "yyyy-MM-dd"), Format(FromDate.DateTime, "yyyy-MM-dd"), CInt(TextRefFrom.Text), CInt(TextRefTo.Text), TextFromAccount.Text, TextToAccount.Text, TextNotes.Text)
    End Sub

    Private Sub RetriveData(TransNo As Integer, FromAmount As Decimal, ToAmount As Decimal, FromDate As String, Todate As String,
                            FromReferenceID As Integer, ToReferenceID As Integer, FromAccountKey As String, ToAccountKey As String, Description As String)
        Dim SqlString As String
        SqlString = "SELECT top " & TransNo & " JBATCHNO  AS ALIAS1F,  JMTRANSID  AS ALIAS2F,  JTRANSTYPE  AS ALIAS3F,  JMACCOUNTKEY  AS ALIAS4F,
                                 (CASE JMDEBITCREDIT WHEN 0 THEN 'Credit' ELSE 'Debit' END)  AS ALIAS5F,
                                 CASE JMDEBITCREDIT WHEN 1 THEN  JMSUF  ELSE NULL END AS ALIAS6F_DEB, CASE JMDEBITCREDIT WHEN 0 THEN
                                 JMSUF  ELSE NULL END AS ALIAS6F_CR, (1-2*JMDEBITCREDIT)*( JMSUF ) AS ALIAS6F_BLN,  JMSUF  AS ALIAS6F,
                                 OPOSITEACC  AS ALIAS7F, CASE JMDEBITCREDIT WHEN 1 THEN  JMSUFDLR  ELSE NULL END AS ALIAS8F_DEB,
                                 CASE JMDEBITCREDIT WHEN 0 THEN  JMSUFDLR  ELSE NULL END AS ALIAS8F_CR, (1-2*JMDEBITCREDIT)*( JMSUFDLR ) AS ALIAS8F_BLN,
                                 JMSUFDLR  AS ALIAS8F,  JCURRENCYCODE  AS ALIAS9F,  JVALUEDATE  AS ALIAS10F,  JDUEDATE  AS ALIAS11F,  JREFERANCE  AS ALIAS12F,
                                 JREF2  AS ALIAS13F,  JDESCRIPTION  AS ALIAS14F,  JSUF  AS ALIAS15F
                                 FROM                RPHSTRANSRETRIV where  ( JMSUF > 0  "
        If FromAmount <> 0 And ToAmount <> 0 Then SqlString = SqlString + " and (" & FromAmount & " >= JMSUF) AND (" & ToAmount & " <= JMSUF)  "
        If FromDate.ToString <> "" And Todate.ToString <> "" Then SqlString = SqlString + " And ('" & FromDate & "' >= JVALUEDATE) AND ('" & Todate & "' <= JVALUEDATE) "
        If FromReferenceID.ToString <> "" And ToReferenceID.ToString <> "" Then SqlString = SqlString + " And (" & ToReferenceID & " >= JREFERANCE) AND (" & FromReferenceID & " <= JREFERANCE)"
        If FromAccountKey.ToString <> "" And ToAccountKey.ToString <> "" Then SqlString = SqlString + "   And ('" & ToAccountKey & " ' >= JMACCOUNTKEY) AND ('" & FromAccountKey & "' <= JMACCOUNTKEY)"
        If Description.ToString <> "" Then SqlString = SqlString + "  And JDESCRIPTION LIKE '%" & Description & "%'   AND JTYPE<>1  "
        SqlString = SqlString + " ) And ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3  ORDER BY                JBATCHNO ASC "
        Dim sql As New SQLControl

        sql.WizCountRunQuery(SqlString)
        Me.GridControl1.DataSource = sql.SQLDS.Tables(0)

    End Sub

    Private Sub FinancialAccountingRetrieve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextTransNo.EditValue = 100
    End Sub

End Class