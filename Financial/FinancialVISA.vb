﻿Public Class FinancialVISA
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a SqlDataSource

    End Sub

    Private Sub FinancialVISA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEditVisaFrom.DateTime = Today.AddYears(-10)
        DateEditVisaTo.DateTime = Today

        DateEdit1.DateTime = Today.AddYears(-10)
        DateEdit2.DateTime = Today

    End Sub
    Private Sub UpdateData()
        Dim sql As New SQLControl

        Dim TextAmountString As String = TextAmount.Text
        If String.IsNullOrEmpty(TextAmountString) Then TextAmountString = "Null"

        Dim TextVoucherString As String = TextVoucher.Text
        If String.IsNullOrEmpty(TextVoucherString) Then TextVoucherString = "Null"

        Dim TextTransTextString As String = TextTransText.Text
        If String.IsNullOrEmpty(TextTransTextString) Then TextTransTextString = "Null"

        Dim TextDocIDString As String = TextDocID.Text
        If String.IsNullOrEmpty(TextDocIDString) Then TextDocIDString = "Null"

        Dim DateEditVisaString As String = Format(DateEditVisaFrom.DateTime, "yyyy-MM-dd")
        If String.IsNullOrEmpty(DateEditVisaString) Then DateEditVisaString = "Null"

        Dim DateEditTOVisaString As String = Format(DateEditVisaTo.DateTime, "yyyy-MM-dd")
        If String.IsNullOrEmpty(DateEditTOVisaString) Then DateEditTOVisaString = "Null"






        Dim SqlString As String = "SELECT  [CREDITS].[ID]
                                  ,[CREDITS].[DOCID]
                                  ,[CREDITS].[STATUS]
                                  ,[CREDITS].[CARDNUM]
                                  ,[CREDITS].[CARDTYPE]
                                  ,[CREDITS].[VOUCHERNO]
                                  ,[CREDITS].[EXPDATE]
                                  ,[CREDITS].[CURRCODE]
                                  ,[CREDITS].[AMOUNT]
                                  ,[CREDITS].[AMOUNTFC]
                                  ,[CREDITS].[CURRRATE]
                                  ,[CREDITS].[DETAILS]
                                  ,[CREDITS].[USERID]
                                  ,[CREDITS].[ACCOUNTKEY]
                                  ,[STATIONS].NAME_AR
                                  ,[USERS].[USERNAME]
                              FROM [WALLET].[dbo].[CREDITS]
                               left join [WALLET].[dbo].[DOCUMENTS]
                               on [CREDITS].DOCID =[DOCUMENTS].DOCID
                               left join [WALLET].[dbo].[STATIONS]
                               on [DOCUMENTS].STN_ID =[STATIONS].[STN_ID]
                               left join [WALLET].[dbo].USERS
                               on [CREDITS].[USERID]=[USERS].[USERID] where AMOUNTFC > 0  "
        If TextAmountString <> "Null" Then SqlString = SqlString + " and  AMOUNTFC =  " & TextAmountString
        If TextVoucherString <> "Null" Then SqlString = SqlString + " and  VOUCHERNO =  " & TextVoucherString
        If TextTransTextString <> "Null" Then SqlString = SqlString + " and  CREDITS.DETAILS =  '" & TextTransTextString & "'"
        If TextDocIDString <> "Null" Then SqlString = SqlString + " and  DOCID =  " & TextDocIDString
        If DateEditVisaString <> "Null" Or DateEditTOVisaString <> "Null" Then SqlString = SqlString + " and  EXPDATE between '" & DateEditVisaString & "' and '" & DateEditTOVisaString & "'"

        sql.WalletRunQuery(SqlString)
        If sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub
        GridControl1.DataSource = sql.SQLDS.Tables(0)
        GridView1.BestFitColumns()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        UpdateData()
    End Sub

    Private Sub GetDublicateVisa()
        Dim DateFrom As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")
        Dim DateTo As String = Format(DateEdit2.DateTime, "yyyy-MM-dd")

        Dim sql As New SQLControl
        Dim SqlString As String
        SqlString = "   select [DETAILS],[VOUCHERNO],[AMOUNTFC],[ACCOUNTKEY],[EXPDATE], COUNT(*) as countof
                              FROM [WALLET].[dbo].[CREDITS] 
                              where [EXPDATE] between '" & DateFrom & "' And '" & DateTo & "'
                              group by [VOUCHERNO],[AMOUNTFC],[DETAILS],[ACCOUNTKEY],[EXPDATE]
                              having COUNT (*) > 1
                              order by [EXPDATE]"

        sql.WalletRunQuery(SqlString)
        If sql.SQLDS.Tables(0).Rows.Count = 0 Then MsgBox("لا يوجد بيانات") : Exit Sub
        Me.GridControl2.DataSource = sql.SQLDS.Tables(0)
        GridView2.BestFitColumns()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetDublicateVisa()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        GridControl2.ShowPrintPreview()
    End Sub
End Class