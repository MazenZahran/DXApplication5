

Public Class CRMPrintForms
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Try
        '    Dim FILE_NAME As String = 

        '    If System.IO.File.Exists(FILE_NAME) = True Then
        '        Process.Start(FILE_NAME)
        '    Else
        '        MsgBox("File Does Not Exist")
        '    End If

        'Catch ex As Exception

        'End Try

        MsgBox(My.Application.Info.DirectoryPath)


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        '  Dim workbook As New Workbook()

    End Sub
End Class