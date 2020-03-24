Imports System.Data.SqlClient
Imports System.IO

Public Class PrintingAddDoc
    Private Sub PrintingSystemDocsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PrintingSystemDocsBindingNavigatorSaveItem.Click
        Try
            If TextFilePath.Text = "" Or String.IsNullOrEmpty(TextFilePath.Text) Or String.IsNullOrWhiteSpace(TextFilePath.Text) Then
                MsgBox("لا يوجد ملف")
            Else
                Dim file As Byte()
                Using stream = New FileStream(TextFilePath.Text, FileMode.Open, FileAccess.Read)
                    Using reader = New BinaryReader(stream)
                        file = reader.ReadBytes(CInt(stream.Length))
                    End Using
                End Using
                Dim con As SqlConnection
                Dim cmd As SqlCommand
                Dim row As Integer
                con = New SqlConnection(CRMString)
                con.Open()
                cmd = New SqlCommand("Update PrintingSystemDocs 
                                      Set DocFile = @File
                                      Where DocID = " & DocIDTextEdit.Text, con)
                cmd.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file
                row = cmd.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            Me.Validate()
            Me.PrintingSystemDocsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Sub PrintingAddDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.PrintingSystemDocs' table. You can move, or remove it, as needed.
        '   Me.PrintingSystemDocsTableAdapter.Fill(Me.CRMDataSet.PrintingSystemDocs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            TextFilePath.Text = ""
            Me.OpenFileDialog1.ShowDialog()
            Me.TextFilePath.Text = OpenFileDialog1.FileName
            Me.PdfViewer2.LoadDocument(OpenFileDialog1.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        PdfViewer2.CloseDocument()
    End Sub

    Private Sub DocIDTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles DocIDTextEdit.EditValueChanged
        Try
            '    If OrderIDTextBox.Text = "" Then Exit Try
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim row As Integer
            'Dim str As String
            con = New SqlConnection(CRMString)
            con.Open()
            cmd = New SqlCommand(" select DocFile from  PrintingSystemDocs where DocID= " & DocIDTextEdit.Text, con)
            row = cmd.ExecuteNonQuery()

            Using sqlQueryResult = cmd.ExecuteReader()

                If sqlQueryResult IsNot Nothing Then
                    sqlQueryResult.Read()
#Disable Warning BC42016 ' Implicit conversion
                    Dim blob = New Byte((sqlQueryResult.GetBytes(0, 0, Nothing, 0, Integer.MaxValue)) - 1) {}
#Enable Warning BC42016 ' Implicit conversion
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length)
                    memoryStream.Write(blob, 0, blob.Length)
                    PdfViewer2.LoadDocument(memoryStream)
                End If
            End Using
            con.Close()
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            PdfViewer2.CloseDocument()
        End Try
    End Sub

    Private Sub TextEditDocID_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditDocID.EditValueChanged
        Me.PrintingSystemDocsTableAdapter.FillByID(Me.CRMDataSet.PrintingSystemDocs, CInt(TextEditDocID.Text))
    End Sub
End Class