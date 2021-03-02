Imports System.Data.SqlClient
Imports System.IO
Imports outlook = Microsoft.Office.Interop.Outlook

Public Class PrintingDocs
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        RefreshData()
    End Sub
    Private Sub RefreshData()

        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT   DocID ,[DocName] ,[DocColorNo],[DocSize],[DocPagesNo],[DocCopies],[DocAvaragePrrint],[DocPrice],[DocFile]
                      FROM [CRM].[dbo].[PrintingSystemDocs]"
            sql.CRMRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemOpen.Click
        'My.Forms.PrintingAddDoc.DocIDTextEdit.Select()
        Dim DocId As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocID"))
        My.Forms.PrintingAddDoc.DocIDTextEdit.Text = CStr(DocId)
        'My.Forms.PrintingAddDoc.DocNameTextEdit.Select()

        My.Forms.PrintingAddDoc.PrintingSystemDocsTableAdapter.FillByID(My.Forms.PrintingAddDoc.CRMDataSet.PrintingSystemDocs, DocId)

        PrintingAddDoc.Show()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

        Dim DocId As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocID"))

        Try
            '    If OrderIDTextBox.Text = "" Then Exit Try
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim row As Integer
            'Dim str As String
            con = New SqlConnection(CRMString)
            con.Open()
            cmd = New SqlCommand(" select DocFile from  PrintingSystemDocs where DocID= " & DocId, con)
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

    Private Sub RepositoryItemNewOrder_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemNewOrder.ButtonClick
        Try
            My.Forms.PrintingJobs.PrintingSystemJobsBindingSource.AddNew()
            My.Forms.PrintingJobs.JobDocNoTextEdit.EditValue = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocID"))
            My.Forms.PrintingJobs.FromBack.Text = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocID"))
            My.Forms.PrintingJobs.JobEmloyeeTextEdit.Text = My.Settings.UserName.ToString
            My.Forms.PrintingJobs.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        sendEMailThroughOUTLOOK()
    End Sub

    Private Sub PrintingDocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Public Sub sendEMailThroughOUTLOOK()

        Try
            Dim FileLocation As String = "z:\PrintFile.pdf"
            PdfViewer2.SaveDocument(FileLocation)
            Dim File As String = FileLocation
            Dim AttchName As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocName"), String)
            Dim DocColorNo As String = "عدد الالوان" & CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocColorNo"), String)
            Dim DocSize As String = "الحجم" & CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocSize"), String)
            Dim DocPagesNo As String = "عدد الاوراق" & CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocPagesNo"), String)
            Dim DocCopies As String = "عدد النسخ" & CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocCopies"), String)

            Dim oApp As New outlook.Application()
            Dim oMsg As outlook.MailItem = DirectCast(oApp.CreateItem(outlook.OlItemType.olMailItem), outlook.MailItem)
            oMsg.HTMLBody = "<Font face=""Arial"">" & DocColorNo & ", <br><br>" & DocSize & "<br><br>" & DocPagesNo & "<br><br> " & DocCopies
            Dim sDisplayName As [String] = AttchName
            '   Dim iPosition As Integer = CInt(oMsg.Body.Length) + 1
            Dim iAttachType As Integer = CInt(outlook.OlAttachmentType.olByValue)
            Dim oAttach As outlook.Attachment = oMsg.Attachments.Add(File, iAttachType, , sDisplayName)
            oMsg.Subject = "الرجاء طباعة " & AttchName
            Dim oRecips As outlook.Recipients = DirectCast(oMsg.Recipients, outlook.Recipients)
            Dim oRecip As outlook.Recipient = DirectCast(oRecips.Add("accounting@alhuda.ps"), outlook.Recipient)
            oRecip.Resolve()
            oMsg.Display()
            oRecip = Nothing
            oRecips = Nothing
            oMsg = Nothing
            oApp = Nothing
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        PdfViewer2.Print()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class