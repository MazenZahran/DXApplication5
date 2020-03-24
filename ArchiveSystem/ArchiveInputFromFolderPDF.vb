Imports System.IO
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class ArchiveInputFromFolderPDF
    Private Sub ArchivePDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocsSort' table. You can move, or remove it, as needed.
        Me.ArchiveDocsSortTableAdapter.Fill(Me.CRMDataSet.ArchiveDocsSort)
        'TODO: This line of code loads data into the 'WALLETDataSet.STATIONS' table. You can move, or remove it, as needed.
        Me.STATIONSTableAdapter.Fill(Me.WALLETDataSet.STATIONS)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocTypes' table. You can move, or remove it, as needed.
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)
        TextEditFolder.Text = GetArchiveFolder()
        LoadFilesFromFolder()
    End Sub

    Private Function GetArchiveFolder() As String
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = "Select ArchiveFolder From Users Where UserID ='" & My.Settings.UserName & "'"
            Sql.CRMRunQuery(SqlString)
            Return Sql.SQLDS.Tables(0).Rows(0).Item("ArchiveFolder").ToString
        Catch ex As Exception
            Return ""
        End Try


    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadFilesFromFolder()
    End Sub
    Public Sub ProcessDirectory(ByVal targetDirectory As String, ByRef dt As DataTable)
        Try
            Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
            For Each fileName As String In fileEntries
                Dim fi As FileInfo = New FileInfo(fileName)
                If fi.Extension = ".pdf" Then
                    dt.Rows.Add(Nothing, fi.Name, targetDirectory, fi.CreationTime, fi.Extension, fi.FullName)
                End If
            Next
            Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)

            For Each subdirectory As String In subdirectoryEntries
                ProcessDirectory(subdirectory, dt)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadFilesFromFolder()

        Try
            Dim dt As DataTable = New DataTable("Mydata")
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("File", GetType(String))
            dt.Columns.Add("Folder", GetType(String))
            dt.Columns.Add("CreationTime", GetType(DateTime))
            dt.Columns.Add("Extension", GetType(String))
            dt.Columns.Add("FullName", GetType(String))
            dt.Columns("ID").AutoIncrement = True
            dt.Columns("ID").AutoIncrementSeed = 1
            dt.Columns("ID").AutoIncrementStep = 1
            ProcessDirectory(TextEditFolder.Text.Trim(), dt)
            Dim dataView As New DataView(dt)
            dataView.Sort = "  CreationTime DeSC"
            Dim dataTable As DataTable = dataView.ToTable()
            GridControl1.DataSource = dataTable
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub TextEditFolder_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditFolder.EditValueChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Saveing()
    End Sub

    Private Sub Saveing()



        Dim AccFolder As String = CStr(SearchAccounts.EditValue)
        Dim DocType As String = CStr(SearchDocTypes.EditValue)
        Dim DocName As String = CStr(TextDocName.Text)
        Dim FilePath As String = TextEditFilePath.Text
        Dim Sort As String = CStr(SearchLookSort.EditValue)
        Dim CostCenter As String = SearchCostCenter.Text
        Dim FileExtension As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Extension"), String)
        Dim FileNameID As Integer


        Try


            'If String.IsNullOrEmpty(AccFolder) Or CInt(AccFolder) < -1 Then
            '    AccFolder = "Null"
            'End If

            'If String.IsNullOrEmpty(CostCenter) Or CostCenter = "Null" Then
            '    CostCenter = ""
            'End If


            If IsNothing(DocName) Or String.IsNullOrEmpty(DocName) Or String.IsNullOrWhiteSpace(DocName) Then
                MsgBox("خطا: اسم الوثيقة فارغ")
                TextDocName.Text = ""
                Exit Sub
            End If

            If String.IsNullOrEmpty(DocType) Or DocType = "Null" Then
                MsgBox("يجب اختيار تصنيف الوثيقة")
                Exit Sub
            End If

            'If String.IsNullOrEmpty(Sort) Then
            '    Sort = "Null"
            'End If



            If IsNothing(AccFolder) Or String.IsNullOrEmpty(AccFolder) Or String.IsNullOrWhiteSpace(AccFolder) Then
                MsgBox("خطا:  الحساب  فارغ")
                Exit Sub
            End If


            Dim sql2 As New SQLControl
            Dim SqlString As String = " Select Max(DocID) As FileName from ArchiveDocs"
            sql2.CRMRunQuery(SqlString)
            FileNameID = CInt(sql2.SQLDS.Tables(0).Rows(0).Item("FileName")) + 1

            Dim TargetFilePath As String

            ' If Sort = "Null" And AccFolder = "Null" Then MsgBox("يجب اختيار حساب ") : Exit Sub

            ' If Sort = "Null" Then
            TargetFilePath = "Z:\Archive\" & AccFolder & "\" & FileNameID & FileExtension
            ' Else
            ' TargetFilePath = "Z:\Archive\" & CStr(SearchLookSort.EditValue) & "\" & FileNameID & FileExtension
            '  End If

            Try
                PdfViewer1.DocumentFilePath = ""
                My.Computer.FileSystem.MoveFile(FilePath, TargetFilePath)
                LoadFilesFromFolder()
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("لا يوجد ملف لنقله")
                Exit Sub
            End Try

            If AccFolder = "Null" Then AccFolder = ""
            Dim sql As New SQLControl
            Dim SQLInsert As String = " Insert Into  [ArchiveDocs] 
                                            (  [DocName],DocType,DocAccountCode,DocDetails,DocInputDate,DocInputUser,DocLocation,DocSort,DocCostCenter) 
                                            Values (  '" & DocName & "','" & DocType & "','" & AccFolder & "','" _
                                            & TextDocementDetails.Text & "','" & Format(Now, "yyyy-MM-dd HH:mm") _
                                            & "','" & My.Settings.UserName & "','" & TargetFilePath & "','" & Sort & "','" & CostCenter & "' )"
            sql.CRMRunQuery(SQLInsert)




        Catch ex As Exception
            MsgBox(ex.ToString)
            LoadFilesFromFolder()
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        ArchiveDocuTypes.Show()
    End Sub

    Private Sub SearchDocTypes_BeforePopup(sender As Object, e As EventArgs) Handles SearchDocTypes.BeforePopup
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Try
            Dim FullName As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FullName"), String)
            Dim File As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "File"), String)
            Dim result As DialogResult = XtraMessageBox.Show("هل تريد حذف الملف " & File, "تحذير", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                PdfViewer1.DocumentFilePath = ""
                My.Computer.FileSystem.DeleteFile(FullName,
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
                LoadFilesFromFolder()
            Else
                'do something if not
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            Dim File As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FullName"), String)
            Me.PdfViewer1.LoadDocument(File)
            TextEditFilePath.Text = File
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ArchiveDocuTypes.Show()
    End Sub
End Class