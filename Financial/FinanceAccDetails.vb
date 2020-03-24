Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports outlook = Microsoft.Office.Interop.Outlook

Public Class FinanceAccDetails
    Private Sub AccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WizCountDataSet)
    End Sub

    Private Sub FinanceAccDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.CostCodes' table. You can move, or remove it, as needed.
        Me.CostCodesTableAdapter.Fill(Me.WizCountDataSet.CostCodes)
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.FinanceAccounts' table. You can move, or remove it, as needed.
        '   Me.FinanceAccountsTableAdapter.Fill(Me.WizCountDataSet.FinanceAccounts)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts' table. You can move, or remove it, as needed.
        '   Me.AccountsTableAdapter.Fill(Me.WizCountDataSet.Accounts)
        Me.KeyPreview = True
    End Sub

    Private Sub CustomersOrdersAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.F3 Then
            Saving()
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound 

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Saving()
    End Sub

    Private Sub Saving()
        Try
            Me.Validate()
            Me.AccountsBindingSource.EndEdit()
            Me.CRMContactBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WizCountDataSet)
            XtraMessageBox.Show("تم الحفظ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        UpdateAddData()
    End Sub

    Private Sub AdditionData()
        Dim sql As New SQLControl
        Dim SqlString As String
        SqlString = " Select AccAudit,AccountDateCreated,AuditEmployee,Owner,AboutJob,WorkAT,Position,Notes,EmployeeNo from FinanceAccounts where AccountKey ='" & TextEditAccountKey.Text & "'"
        sql.CRMRunQuery(SqlString)
        If sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AccountDateCreated").ToString) Then TextEditAccCreateDate.Text = sql.SQLDS.Tables(0).Rows(0).Item("AccountDateCreated").ToString

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AccAudit").ToString) Then
            If sql.SQLDS.Tables(0).Rows(0).Item("AccAudit").ToString = "True" Then
                CheckEditAudited.Checked = True
            Else
                CheckEditAudited.Checked = False
            End If
        End If

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AuditEmployee").ToString) Then AuditEmployeeTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("AuditEmployee").ToString

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Owner").ToString) Then
            If sql.SQLDS.Tables(0).Rows(0).Item("Owner").ToString = "True" Then
                OwnerCheckEdit.EditValue = True
            Else
                OwnerCheckEdit.EditValue = False
            End If
        End If

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AboutJob").ToString) Then AboutJobTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("AboutJob").ToString

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("WorkAT").ToString) Then WorkATTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("WorkAT").ToString

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Position").ToString) Then PositionTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("Position").ToString

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Notes").ToString) Then NotesTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("Notes").ToString

        If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("EmployeeNo").ToString) Then EmployeeCodeText.Text = sql.SQLDS.Tables(0).Rows(0).Item("EmployeeNo").ToString


    End Sub

    Private Sub TextEditAccountKey_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditAccountKey.EditValueChanged
        AboutJobTextEdit.Text = ""
        AboutJobTextEdit.Text = ""
        WorkATTextEdit.Text = ""
        PositionTextEdit.Text = ""
        NotesTextEdit.Text = ""
        Me.AccountsTableAdapter.FillByAccKey(Me.WizCountDataSet.Accounts, TextEditAccountKey.Text)
        AdditionData()
        Try
            Me.CRMContactTableAdapter.Fill(Me.WizCountDataSet.CRMContact, TextEditAccountKey.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateAddData()

        Dim Sql As New SQLControl
        Dim SqlString As String
        SqlString = " UPDATE [CRM].[dbo].[FinanceAccounts]
                      SET    [Owner] = '" & OwnerCheckEdit.CheckState & "'
                            ,[AboutJob] = '" & AboutJobTextEdit.Text & "'
                            ,[WorkAT] = '" & WorkATTextEdit.Text & "'
                            ,[Position] = '" & PositionTextEdit.Text & "'
                            ,[Notes] = '" & NotesTextEdit.Text & "'
                            ,[AccAudit]='" & CheckEditAudited.CheckState & "'
                            ,[AuditDateTime]=GETDATE()
                            ,[AuditEmployee]='" & GlobalVariables.UserNameString & "'
                            ,[EmployeeNo]='" & EmployeeCodeText.Text & "'
                      WHERE AccountKey='" & AccountKeyTextEdit.Text & "'"
        Sql.CRMRunQuery(SqlString)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CRMContactGridControl_Click(sender As Object, e As EventArgs) Handles CRMContactGridControl.Click

    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim view As GridView = TryCast(sender, GridView)
        view.SetRowCellValue(e.RowHandle, colCStatus, 1)
        view.SetRowCellValue(e.RowHandle, colAccountKey, AccountKeyTextEdit.Text)
        view.SetRowCellValue(e.RowHandle, ColCDate1, "1999-01-01 00:00:00.000")
        view.SetRowCellValue(e.RowHandle, ColCDate2, "1999-01-01 00:00:00.000")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click


        Try
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim row As Integer
            'Dim str As String
            con = New SqlConnection(CRMString)
            con.Open()
            cmd = New SqlCommand(" select CustImage,OrderID from  CRMCustomersOrders where AccountID=" & AccountKeyTextEdit.Text, con)
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
                    TextEditOrderID.Text = sqlQueryResult.GetValue(1).ToString
                End If
            End Using

            con.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Updatedata()
    End Sub


    Private Sub Updatedata()

        Try
            Dim AccountCode As String = CStr(AccountKeyTextEdit.Text)
            If String.IsNullOrEmpty(AccountCode) Then AccountCode = "Null"

            Dim SqlString As String = "SELECT [DocID]
                                          ,[DocName]
                                          ,[DocType]
                                          ,[DocAccountCode]
                                          ,[DocDetails]
                                          ,[DocInputDate]
                                          ,[DocInputUser]
                                          ,[DocLocation]
                                          ,[ALHUDA].[dbo].[Accounts].FullName As AccountName
                                  FROM [CRM].[dbo].[ArchiveDocs],[ALHUDA].[dbo].[Accounts]"
            SqlString = SqlString + "  where [CRM].[dbo].[ArchiveDocs].DocAccountCode=[ALHUDA].[dbo].[Accounts].AccountKey"


            If CStr(AccountCode) <> "Null" Then SqlString = SqlString + " And DocAccountCode ='" & AccountCode & "'"



            Dim Sql As New SQLControl
            Sql.CRMRunQuery(SqlString)
            If Sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
            GridView1.BestFitColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub OpenButton_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles OpenButton.ButtonClick

        Try
            Dim FILE_NAME As String = GridView3.GetFocusedRowCellValue("DocLocation").ToString

            If System.IO.File.Exists(FILE_NAME) = True Then
                Process.Start(FILE_NAME)
            Else
                MsgBox("File Does Not Exist")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub ButtEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtEdit.ButtonClick
        Try
            Dim DocID As String = GridView3.GetFocusedRowCellValue("DocID").ToString
            Dim DocName As String = GridView3.GetFocusedRowCellValue("DocName").ToString
            Dim DocType As String = GridView3.GetFocusedRowCellValue("DocType").ToString
            Dim DocAccountCode As String = GridView3.GetFocusedRowCellValue("DocAccountCode").ToString
            Dim DocDetails As String = GridView3.GetFocusedRowCellValue("DocDetails").ToString

            Dim Ans As DialogResult
            Ans = CType(MsgBox("هل تريد تعديل بيانات وثيقة رقم " & " " & DocID, MsgBoxStyle.YesNo, "تحذير"), DialogResult)

            If Ans = DialogResult.No Then Updatedata() : Exit Sub

            Dim SqlString As String = " Update ArchiveDocs Set 
                                        DocName = " & "'" & DocName & "'
                                        , DocType = " & "'" & DocType & "'
                                        , DocAccountCode = " & "'" & DocAccountCode & "'
                                        , DocDetails = " & "'" & DocDetails & "'
                                        where DocID= " & DocID
            Dim sql As New SQLControl
            sql.CRMRunQuery(SqlString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Updatedata()
        End Try

    End Sub

    Private Sub ItemEmailDoc_Click(sender As Object, e As EventArgs) Handles ItemEmailDoc.Click
        sendEMailThroughOUTLOOK()
    End Sub


    Public Sub sendEMailThroughOUTLOOK()

        Try
            Dim File As String = CType(Me.GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DocLocation"), String)
            Dim AttchName As String = CType(Me.GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DocName"), String)
            Dim DocDetails As String = CType(Me.GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DocDetails"), String)

            Dim oApp As New outlook.Application()
            Dim oMsg As outlook.MailItem = DirectCast(oApp.CreateItem(outlook.OlItemType.olMailItem), outlook.MailItem)
            oMsg.HTMLBody = DocDetails
            Dim sDisplayName As [String] = AttchName
            '   Dim iPosition As Integer = CInt(oMsg.Body.Length) + 1
            Dim iAttachType As Integer = CInt(outlook.OlAttachmentType.olByValue)
            Dim oAttach As outlook.Attachment = oMsg.Attachments.Add(File, iAttachType, , sDisplayName)
            oMsg.Subject = AttchName
            Dim oRecips As outlook.Recipients = DirectCast(oMsg.Recipients, outlook.Recipients)
            Dim oRecip As outlook.Recipient = DirectCast(oRecips.Add("accounting@alhuda.ps"), outlook.Recipient)
            oRecip.Resolve()
            oMsg.Display()
            oRecip = Nothing
            oRecips = Nothing
            oMsg = Nothing
            oApp = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

    End Sub
End Class