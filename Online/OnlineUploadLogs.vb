Public Class OnlineUploadLogs
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        UpdateData()
    End Sub

    Private Sub UpdateData()

        Try
            Dim sql As New SQLControl
            Dim TransNo As Integer = CInt(ComboBoxEdit1.Text)
            Dim SqlString As String = "SELECT TOP " & TransNo & " [ID],[SDATETIME],[EDATETIME],[STATUS]  FROM   [WALLET].[dbo].[WEBSYNCLOG] order by ID DESC   "
            sql.WalletRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub OnlineUploadLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxEdit1.EditValue = 10
        UpdateData()
    End Sub
End Class