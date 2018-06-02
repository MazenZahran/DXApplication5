﻿Imports DevExpress.DashboardCommon
Imports DevExpress.Data
Imports DevExpress.XtraGrid

Public Class FinancialMatchBankDoc

    Dim customSum As Integer

    Sub New()

        InitializeComponent()

        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a SqlDataSource
        SqlDataSource1.Fill()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a SqlDataSource

    End Sub

    Private Sub FinancialMatchBankDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim sql As New SQLControl
        Dim SQLString As String = "  SELECT DISTINCT(Ref2),[DebName],[ValueDate],SUM(suf) as Total , ''  as Notes FROM [ALHUDA].[dbo].[JurnalTrans]
                                     WHERE [ALHUDA].[dbo].[JurnalTrans]. BatchNo =9999 and Ref2 is not null and  NOT EXISTS
                                     (SELECT * FROM [CRM].[dbo].[FinancialBanksDoc] WHERE [ALHUDA].[dbo].[JurnalTrans].Ref2 = [CRM].[dbo].[FinancialBanksDoc].Ref22)
                                     group by  (Ref2),[DebName],[ValueDate] order by [ValueDate] "
        sql.CRMRunQuery(SQLString)
        GridControl1.DataSource = sql.SQLDS.Tables(0)

        'Dim siAverage As New GridColumnSummaryItem()
        'siAverage.SummaryType = SummaryItemType.Sum
        'siAverage.FieldName = "Ref2"
        'siAverage.DisplayFormat = "Average: {0:#.#}"
    End Sub

    Private Sub GetDepositdata()
        Dim sql As New SQLControl
        Dim DepositID As Integer = CInt(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Ref2"))
        TextBankDocNo.EditValue = DepositID
        Dim SelectDepositString As String = "SELECT TransID, Referance  ,Ref2,[DebName],[ValueDate],suf as Total  FROM [ALHUDA].[dbo].[JurnalTrans]
                                         WHERE [ALHUDA].[dbo].[JurnalTrans].BatchNo = 9999 And Ref2 = " & DepositID & "
                                         order by [ValueDate] desc"
        sql.WizCountRunQuery(SelectDepositString)
        GridControl2.DataSource = sql.SQLDS.Tables(0)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            If TextDeff.Text = "1" Or TextDeff.Text = "-1" Or TextDeff.Text = "0" Then

                AuditBank()

            Else
                MsgBox("مجموع الفيشة لا يساوي مجموع الشيكات")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub AuditBank()
        Try
            Dim sql As New SQLControl
            Dim Ref As String, DebName As String, Referance As String, ValueDate As String, BankDocAmount As String
            Ref = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Ref2"), String)
            DebName = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DebName"), String)
            Referance = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Referance"), String)
            ValueDate = Format(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ValueDate"), "yyyy-MM-dd HH:mm")

            BankDocAmount = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Total"), String)

            Dim SQLString As String = "Insert Into [CRM].[dbo].[FinancialBanksDoc] (Ref22,BankDocAuditDate,BankDocID,BankDocDate,BankDocAmount,Notes,RefBank) values
                                                                                   (" & Ref & ",GETUTCDATE(),'" & Referance & "','" & ValueDate & "','" & BankDocAmount & "',
                                                                                    '" & TextNote.Text & "','" & DebName & "'  )  "

            sql.CRMRunQuery(SQLString)


            GridControl2.DataSource = ""
            TextDepositSum.EditValue = 0
            TextChequeSum.EditValue = 0
            LoadData()
            SqlDataSource1.Fill()

            DashboardViewer1.ReloadData()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub UpdateSelectedSum()

        Try
            customSum = 0
            For Each handle As Integer In GridView1.GetSelectedRows()
                customSum += CInt(GridView1.GetRowCellValue(handle, "Total"))
            Next
            TextChequeSum.EditValue = customSum
            TextDeff.Text = CType(customSum - CInt(colTotal.SummaryItem.SummaryValue.ToString) - CInt(TextEdit1.Text), String)
            Dim AuditNote As String = " يتم تدقيق فيشة رقم: " & " " & TextBankDocNo.Text & "، مبلغ الفيشة " & " " & TextDepositSum.Text & " " & "المبلغ المتبقي: " & TextDeff.Text
            If TextDeff.Text = "1" Or TextDeff.Text = "-1" Or TextDeff.Text = "0" Then
                AuditNote = AuditNote + "           ممتاز لقد انتهيت بامكانك ترحيل الفيشة"
                TextNotes.BackColor = Color.LightGreen
            Else
                TextNotes.BackColor = Color.Red
            End If
            TextNotes.Text = AuditNote
        Catch ex As Exception

        End Try





    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        UpdateSelectedSum()

    End Sub

    Private Sub RepositoryItemButtonEdit3_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit3.Click
        GetDepositdata()
        TextDepositSum.EditValue = CInt(colTotal.SummaryItem.SummaryValue.ToString)
        TextChequeSum.EditValue = 0

        UpdateSelectedSum()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Try
            Dim CCode As String = InputBox("ادخل الكود", "لتدقيق الكل يجب ادخال الكود، رن على مازن زهران")
            If CCode = "1031342" Then
                Dim sql As New SQLControl
                Dim SQLString As String
                SQLString = "Insert Into [CRM].[dbo].[FinancialBanksDoc] (Ref22) (
                         SELECT DISTINCT(Ref2) FROM [ALHUDA].[dbo].[JurnalTrans]
                         WHERE [ALHUDA].[dbo].[JurnalTrans]. BatchNo =9999 and Ref2 is not null and  NOT EXISTS
                         (SELECT * FROM [CRM].[dbo].[FinancialBanksDoc] WHERE [ALHUDA].[dbo].[JurnalTrans].Ref2 = [CRM].[dbo].[FinancialBanksDoc].Ref22)
                          group by  (Ref2),[DebName],[ValueDate] )"
                sql.CRMRunQuery(SQLString)
                LoadData()
                GridControl2.DataSource = ""
                TextDepositSum.EditValue = 0
                TextChequeSum.EditValue = 0
                DashboardViewer1.ReloadData()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        LoadData()
        GridControl2.DataSource = ""
        TextDepositSum.EditValue = 0
        TextChequeSum.EditValue = 0
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        UpdateSelectedSum()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SqlDataSource1.Fill()
    End Sub
End Class