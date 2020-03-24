
Imports System.Net.Mail
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class ArchiveDocuments
    Sub New()

        InitializeComponent()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Updatedata()
    End Sub

    Private Sub Updatedata()

        Try
            Dim AccountCode As String = CStr(SearchAccounts.EditValue)
            If String.IsNullOrEmpty(AccountCode) Then AccountCode = "Null"

            Dim DocTypes As String = CStr(SearchDocTypes.EditValue)
            If String.IsNullOrEmpty(DocTypes) Then DocTypes = "Null"

            Dim DocSort As String = CStr(SearchLookUpEditSort.Text)
            If String.IsNullOrEmpty(DocSort) Then DocSort = "Null"

            Dim CostCenter As String = CStr(SearchCostCenter.Text)
            If String.IsNullOrEmpty(CostCenter) Then CostCenter = "Null"

            Dim SqlString As String = " SELECT [DocID] ,[DocName],[DocType],[DocAccountCode],[DocDetails],[DocInputDate],
                                             UserName,[DocLocation],DocSort,DocCostCenter,
                                              [ALHUDA].[dbo].[Accounts].FullName As AccountName
                                        FROM [CRM].[dbo].[ArchiveDocs]"

            SqlString = SqlString + "  left join [ALHUDA].[dbo].[Accounts] on [CRM].[dbo].[ArchiveDocs].DocAccountCode=[ALHUDA].[dbo].[Accounts].AccountKey "
            SqlString = SqlString + "  left join [CRM].[dbo].[users] on [CRM].[dbo].[ArchiveDocs].DocInputUser  =[CRM].[dbo].[users].[UserID]
            where DocInputDate between  '" & Format(DateEditFrom.DateTime, "yyyy-MM-dd") & "' And '" & Format(DateEditTo.DateTime, "yyyy-MM-dd") & "'"

            If CStr(AccountCode) <> "Null" Then SqlString = SqlString + " And DocAccountCode ='" & CStr(AccountCode) & "'"
            If CStr(DocTypes) <> "Null" Then SqlString = SqlString + " And DocType ='" & CStr(DocTypes) & "'"
            If CStr(DocSort) <> "Null" Then SqlString = SqlString + " And DocSort ='" & CStr(DocSort) & "'"
            If CStr(CostCenter) <> "Null" Then SqlString = SqlString + " And DocCostCenter ='" & CStr(CostCenter) & "'"

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
            Dim FILE_NAME As String = GridView1.GetFocusedRowCellValue("DocLocation").ToString

            If System.IO.File.Exists(FILE_NAME) = True Then
                Process.Start(FILE_NAME)
            Else
                MsgBox("File Does Not Exist")
            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ArchiveDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WALLETDataSet.STATIONS' table. You can move, or remove it, as needed.
        Me.STATIONSTableAdapter.Fill(Me.WALLETDataSet.STATIONS)
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocsSort' table. You can move, or remove it, as needed.
        Me.ArchiveDocsSortTableAdapter.Fill(Me.CRMDataSet.ArchiveDocsSort)
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocTypes' table. You can move, or remove it, as needed.
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)

        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        Me.DateEditFrom.DateTime = Today.AddYears(-10)
        Me.DateEditTo.DateTime = Today.AddYears(+10)
        Updatedata()


    End Sub

    Private Sub RadioGroup2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup2.SelectedIndexChanged
        Select Case CStr(RadioGroup2.EditValue)
            Case "0"
                GridView1.ExpandAllGroups()

            Case "1"
                GridView1.CollapseAllGroups()
        End Select
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case CStr(RadioGroup1.EditValue)
            Case "0"
                colDocAccountCode.GroupIndex = 0
            Case "1"
                colDocType.GroupIndex = 0
        End Select
    End Sub

    Private Sub ButtEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtEdit.ButtonClick

        Try
            Dim DocID As String = GridView1.GetFocusedRowCellValue("DocID").ToString
            Dim DocName As String = GridView1.GetFocusedRowCellValue("DocName").ToString
            Dim DocType As String = GridView1.GetFocusedRowCellValue("DocType").ToString
            Dim DocAccountCode As String = GridView1.GetFocusedRowCellValue("DocAccountCode").ToString
            Dim DocDetails As String = GridView1.GetFocusedRowCellValue("DocDetails").ToString
            Dim CostCenter As String = GridView1.GetFocusedRowCellValue("DocCostCenter").ToString
            Dim DocSort As String = GridView1.GetFocusedRowCellValue("DocSort").ToString

            Dim Ans As DialogResult
            Ans = CType(MsgBox("هل تريد تعديل بيانات وثيقة رقم " & " " & DocID, MsgBoxStyle.YesNo, "تحذير"), DialogResult)

            If Ans = DialogResult.No Then Updatedata() : Exit Sub

            Dim SqlString As String = " Update ArchiveDocs Set 
                                        DocName = " & "'" & DocName & "'
                                        , DocType = " & "'" & DocType & "'
                                        , DocAccountCode = " & "'" & DocAccountCode & "'
                                        , DocDetails = " & "'" & DocDetails & "'
                                        , DocCostCenter = " & "'" & CostCenter & "'
                                        , DocSort = " & "'" & DocSort & "'
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
            Dim File As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocLocation"), String)
            Dim AttchName As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocName"), String)
            Dim DocDetails As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DocDetails"), String)

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

End Class