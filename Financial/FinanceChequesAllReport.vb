Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class FinanceChequesAllReport
    Private Sub FinanceReportAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCheks()
    End Sub



    Private Sub GetCheks()
        Try
            Dim sql As New SQLControl
            Dim SqlString As String = " SELECT  [CheqNumber]      ,[BankNumber]      ,[Branch]      ,[BankAccNum]      ,[ValueDate]      ,[SuF] ,
                                           [Currency]      ,[DepositID]      ,[DepositFlag]      ,CASE WHEN SuFDlr  = 0 THEN SuF   else SuFDlr   END AS NIS , [AccKey] ,[AccName]
                                    FROM [ALHUDA].[dbo].[Cheqs]
                                      Order By ValueDate"

            sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        'Try
        '    Dim CheqNO As String = CType(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CheqNumber"), String)
        '    Dim CheqAccNo As String = CType(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "BankAccNum"), String)
        '    Dim SqlString As String = "Select (ID) As ChequeID from Checks where [ACCOUNT_NO]= '" & CheqAccNo & "' and [CHECK_NO] ='" & CheqNO & "'"
        '    Dim CheuqeID As Integer
        '    Dim sql As New SQLControl

        '    sql.ChuquesRunQuery(SqlString)
        '    If sql.SQLDS.Tables(0).Rows.Count = 0 Then XtraMessageBox.Show("لا يوجد صورة متوفرة للشيك المطلوب") : Exit Sub
        '    CheuqeID = CInt((sql.SQLDS.Tables(0).Rows(0).Item("ChequeID")))

        '    Dim report As New ChequesImages()
        '    report.Parameter1.Value = CheuqeID
        '    report.Parameter2.Value = "0"
        '    report.Parameter1.Visible = False
        '    report.Parameter2.Visible = False
        '    report.CreateDocument()
        '    report.PrintingSystem.ShowMarginsWarning = False
        '    report.Print()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        '    MsgBox("خطا: لم يتمكن البرنامج من طباعة الشيك")
        'End Try
        ChequeImage()
    End Sub


    Private Sub ChequeImage()
        Try
            Dim ChequesNo As String
            Dim BankAccNum As String
            ChequesNo = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CheqNumber"))
            BankAccNum = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "BankAccNum"))
            With FinanceChequsImages
                .SqlDataSource1.Queries(0).Parameters(0).Value = ChequesNo
                .SqlDataSource1.Queries(0).Parameters(1).Value = BankAccNum
                .SqlDataSource1.Fill()
            End With
            FinanceChequsImages.Show()
        Catch ex As Exception
            MsgBox("لا يوجد صورة متوفرة")
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class