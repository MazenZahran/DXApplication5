Public Class FinancialReceiptUnPaidTasks
    Private Sub FinancialReceiptUnPaidTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EndCRMTask()

        Try
            For i = 0 To GridView4.RowCount - 1
                If CType(Me.GridView4.GetRowCellValue(i, "NoteStatus"), String) = "مغلقة" Then
                    Dim TaskID As String = GridView4.GetRowCellValue(i, "TaskID").ToString
                    Dim strDate As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.000")
                    Dim sql As New SQLControl
                    Dim SQLUpdateStatus As String = "Update [CRM].[dbo].[CRMTasks]  set [NoteStatus] ='تم التحصيل' , [CloseDate] = CONVERT(DATETIME, '" & strDate & "', 102) , [CloseNote] = 'من سند قبض' where [TaskID]= " & TaskID
                    sql.CRMRunQuery(SQLUpdateStatus)
                End If
            Next

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        EndCRMTask()
        Me.Close()
    End Sub
End Class