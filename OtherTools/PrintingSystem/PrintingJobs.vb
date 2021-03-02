Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports outlook = Microsoft.Office.Interop.Outlook

Public Class PrintingJobs
    Private Sub PrintingSystemJobsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PrintingJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WALLETDataSet.STATIONS' table. You can move, or remove it, as needed.
        '  Me.STATIONSTableAdapter.Fill(Me.WALLETDataSet.STATIONS)
        'TODO: This line of code loads data into the 'CRMDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.CRMDataSet.Users)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'CRMDataSet.PrintingSystemDocs' table. You can move, or remove it, as needed.
        Me.PrintingSystemDocsTableAdapter.Fill(Me.CRMDataSet.PrintingSystemDocs)
        'TODO: This line of code loads data into the 'CRMDataSet.PrintingSystemJobs' table. You can move, or remove it, as needed.
        '     Me.PrintingSystemJobsTableAdapter.Fill(Me.CRMDataSet.PrintingSystemJobs)
        JobOrderDateDateEdit.Text = CType(Today, String)
        LoadBranches()

        Try
            Me.JobDocNoTextEdit.EditValue = CInt(FromBack.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadBranches()

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = " SELECT C.[NAME_AR]
                                    FROM   [WALLET].[dbo].[STATIONS] AS C where [STATUS] =1
                                    UNION
                                    SELECT S.[NAME_AR]
                                    FROM [WALLET].[dbo].[MARKETS] AS S "
            Sql.WalletRunQuery(SqlString)
            JobStationTextEdit.Properties.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try


    End Sub


    Private Sub JobDocFromNOTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles JobDocFromNOTextEdit.EditValueChanged
        GetToNo()
    End Sub
    Private Sub GetToNo()
        Try
            Dim FromNo As Integer = CInt(Me.JobDocFromNOTextEdit.EditValue)
            Dim Quant As Integer = CInt(Me.JobDocQuantityTextEdit.EditValue)
            Dim Count As Integer = CInt(Me.TextEditPaperCount.EditValue)
            Dim TONo As Integer = FromNo + (Quant * Count) - 1
            JobDocToNoTextEdit.Text = CStr(TONo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub JobDocNoTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles JobDocNoTextEdit.EditValueChanged
        Try
            Dim PagesNO As String = CStr(PrintingSystemDocsTableAdapter.GetPagesNo(CInt(JobDocNoTextEdit.EditValue)))
            Dim DocPrice As String = CStr(PrintingSystemDocsTableAdapter.GetPrice(CInt(JobDocNoTextEdit.EditValue)))
            TextEditPaperCount.Text = PagesNO
            JobDocPriceTextEdit.Text = DocPrice
        Catch ex As Exception
            TextEditPaperCount.Text = "0"
        End Try




        Try
            Dim DocId As Integer = CInt(JobDocNoTextEdit.EditValue)
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
                    PdfViewer1.LoadDocument(memoryStream)
                End If
            End Using
            con.Close()
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            PdfViewer1.CloseDocument()
        End Try


    End Sub

    Private Sub TextEditPaperCount_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditPaperCount.EditValueChanged
        GetToNo()
    End Sub

    Private Sub JobDocQuantityTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles JobDocQuantityTextEdit.EditValueChanged
        GetToNo()
        JobDocAmountTextEdit.EditValue = CalcAmount()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        Try
            JobStatusTextEdit.Text = "قيد الطباعة"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub JobIDTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles JobIDTextEdit.EditValueChanged
        Try
            If CInt(JobIDTextEdit.EditValue) < 0 Then
                Me.PrintingSystemJobsBindingSource.AddNew()
                JobStatusTextEdit.Text = "قيد الطباعة"
                TextEditJobID.Text = CStr(GetMaxDocNo())
            End If
        Catch ex As Exception
            JobStatusTextEdit.Text = "قيد الطباعة"
        End Try

    End Sub
    Private Function GetMaxDocNo() As Integer
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select Max(JobID) as MaxDoc from PrintingSystemJobs"
            Sql.CRMRunQuery(SqlString)
            Return CInt(Sql.SQLDS.Tables(0).Rows(0).Item("MaxDoc").ToString) + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try

            Dim result As DialogResult = XtraMessageBox.Show("هل تريد ارسال الطلبية ايميل ", "ايميل", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                SendEMailThroughOUTLOOK()
            End If

            Me.Validate()
            Me.PrintingSystemJobsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

            Me.PrintingSystemJobsBindingSource.AddNew()

        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            TextEditJobID.Text = CStr(GetMaxDocNo())
            PrintingSystemJobsBindingSource.AddNew()
            JobOrderDateDateEdit.DateTime = Today
            JobStatusTextEdit.Text = "قيد الطباعة"
            JobEmloyeeTextEdit.Text = My.Settings.UserName.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditJobID.EditValueChanged
        Me.PrintingSystemJobsTableAdapter.FillByJobID(Me.CRMDataSet.PrintingSystemJobs, CInt(TextEditJobID.Text))
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If Val(JobIDTextEdit.Text) <= 0 Then
            XtraMessageBox.Show("لا يوجد شئ لحذفه")
            Exit Sub
        End If

        Try
            Dim result As DialogResult = XtraMessageBox.Show("هل تريد حذف الطلب " & JobIDTextEdit.Text, "تحذير", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Dim Sql As New SQLControl
                Dim sqlstring As String
                sqlstring = " Delete From PrintingSystemJobs where JobID=" & JobIDTextEdit.Text
                Sql.CRMRunQuery(sqlstring)
                XtraMessageBox.Show("تم الحذف")
                PrintingSystemJobsBindingSource.AddNew()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("لا يمكن حذف السند")
        End Try
    End Sub

    Private Function CalcAmount() As Decimal

        Try
            Dim Quant As Integer = CInt(JobDocQuantityTextEdit.Text)
            Dim Price As Decimal = CDec(JobDocPriceTextEdit.Text)
            Dim Amount As Decimal = Quant * Price
            Return Amount
        Catch ex As Exception
            Return 0
        End Try


    End Function

    Private Sub JobDocPriceTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles JobDocPriceTextEdit.EditValueChanged
        JobDocAmountTextEdit.EditValue = CalcAmount()
    End Sub

    Private Function GetLastToNo() As Integer
        Try
            If Val(JobIDTextEdit.Text) > 0 Then Return 0
            Dim SqlString As String
            Dim sql As New SQLControl
            Dim LastNO As Integer
            SqlString = "select top 1 JobDocToNo,JobOrderDate from  PrintingSystemJobs where JobDocNo = " & CStr(JobDocNoTextEdit.EditValue) & " order by JobID desc "
            sql.CRMRunQuery(SqlString)
            LastNO = CInt(sql.SQLDS.Tables(0).Rows(0).Item("JobDocToNo").ToString) + 1
            TextLastOrderDate.Text = CStr(sql.SQLDS.Tables(0).Rows(0).Item("JobOrderDate").ToString)
            Return LastNO
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub JobDocNoTextEdit_Leave(sender As Object, e As EventArgs) Handles JobDocNoTextEdit.Leave


    End Sub


    Public Sub SendEMailThroughOUTLOOK()

        Dim DocColorNo As String = ""
        Dim DocSize As String = ""
        Dim DocPagesNo As String = ""
        Dim DocCopies As String = ""
        Dim DocPrice As String = ""
        Dim FromToNo As String = ""
        Dim Quantity As String = ""


        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT   DocID ,[DocName] ,[DocColorNo],[DocSize],[DocPagesNo],[DocCopies],[DocAvaragePrrint],[DocPrice],[DocFile]
                          FROM [CRM].[dbo].[PrintingSystemDocs] where DocID = " & CStr(JobDocNoTextEdit.EditValue)
            sql.CRMRunQuery(SqlString)

            Dim FileLocation As String = "0"
            Dim File As String = "0"
            Dim AttchName As String = "0"

            Try
                FileLocation = "z:\PrintFile.pdf"
                PdfViewer1.SaveDocument(FileLocation)
                File = FileLocation
                AttchName = sql.SQLDS.Tables(0).Rows(0).Item("DocName").ToString
            Catch ex As Exception

            End Try


            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocColorNo")) Then DocColorNo = "عدد الالوان" & sql.SQLDS.Tables(0).Rows(0).Item("DocColorNo").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocSize")) Then DocSize = "الحجم" & sql.SQLDS.Tables(0).Rows(0).Item("DocSize").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocPagesNo")) Then DocPagesNo = "عدد الاوراق" & sql.SQLDS.Tables(0).Rows(0).Item("DocPagesNo").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocCopies")) Then DocCopies = "عدد النسخ" & sql.SQLDS.Tables(0).Rows(0).Item("DocCopies").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocPrice")) Then DocPrice = " السعر " & sql.SQLDS.Tables(0).Rows(0).Item("DocPrice").ToString

            FromToNo = "من رقم " + JobDocFromNOTextEdit.Text + " الى رقم " + JobDocToNoTextEdit.Text
            Quantity = " الكمية " + JobDocQuantityTextEdit.Text
            Dim oApp As New outlook.Application()
            Dim oMsg As outlook.MailItem = DirectCast(oApp.CreateItem(outlook.OlItemType.olMailItem), outlook.MailItem)
            oMsg.HTMLBody = " <Font face=""Arial"">" & DocColorNo & ", <br><br>" & DocSize & "<br><br>" & DocPagesNo & "<br><br> 
                            " & DocCopies & "<br><br>" & FromToNo & "<br><br>" & Quantity & "<br><br>" & DocPrice &
                            " <br><br>" & " الفرع " & JobStationTextEdit.Text & " <br><br>" & JobDetailsTextEdit.Text
            Dim sDisplayName As [String] = AttchName
            '   Dim iPosition As Integer = CInt(oMsg.Body.Length) + 1
            Dim iAttachType As Integer = CInt(outlook.OlAttachmentType.olByValue)
            Dim oAttach As outlook.Attachment = oMsg.Attachments.Add(File, iAttachType, , sDisplayName)
            oMsg.Subject = "الرجاء طباعة " & AttchName
            Dim oRecips As outlook.Recipients = DirectCast(oMsg.Recipients, outlook.Recipients)
            Dim oRecip As outlook.Recipient = DirectCast(oRecips.Add(GetEmail), outlook.Recipient)
            oRecip.Resolve()
            oMsg.Display()
            oRecip = Nothing
            oRecips = Nothing
            oMsg = Nothing
            oApp = Nothing
        Catch ex As Exception
            MsgBox("لا يمكن ارسال الايميل")
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub FromBack_EditValueChanged(sender As Object, e As EventArgs) Handles FromBack.EditValueChanged

        Try
            Dim DocId As Integer = CInt(JobDocNoTextEdit.EditValue)
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
                    PdfViewer1.LoadDocument(memoryStream)
                End If
            End Using
            con.Close()
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            PdfViewer1.CloseDocument()
        End Try

        Try
            JobDocFromNOTextEdit.Text = CStr(GetLastToNo())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim result As DialogResult = XtraMessageBox.Show("هل تريد ارسال الطلبية ايميل ", "ايميل", MessageBoxButtons.YesNo)
        If result = System.Windows.Forms.DialogResult.Yes Then
            SendEMailThroughOUTLOOK()
        End If
    End Sub

    Private Function GetEmail() As String
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " select EMail from [Accounts] where [AccountKey] = '" & CStr(JobVendorTextEdit.EditValue) & "'"
            Sql.WizCountRunQuery(SqlString)
            Return Sql.SQLDS.Tables(0).Rows(0).Item("EMail").ToString
        Catch ex As Exception
            Return "Accounting@alhuda.ps"
        End Try
    End Function

    Private Sub JobVendorTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles JobVendorTextEdit.EditValueChanged
        JobDocFromNOTextEdit.Text = CStr(GetLastToNo())
    End Sub
End Class