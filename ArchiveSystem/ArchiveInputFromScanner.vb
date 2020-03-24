Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Dynamsoft.TWAIN
Imports Dynamsoft.Core
Imports Dynamsoft.TWAIN.Enums
Imports Dynamsoft.TWAIN.Interface
Imports System.IO
Imports System.Runtime.InteropServices

Public Class ArchiveInputFromScanner
    Implements IAcquireCallback
    Private m_TwainManager As TwainManager = Nothing
    Private m_ImageCore As ImageCore = Nothing
    Private strFileName As String
    Private m_StrProductKey As String
    Dim ssOURCE As String





    Public Sub New()
        InitializeComponent()
        m_StrProductKey = "t0068UwAAAIAS9YX9e4KiPi7VTJGzJSB0C1CxfxiVU96VOuriUOGWp6GiS3ZHoTBByr43pGIZRCE2wpXu8Mqnz0W4+ho25bo="
        m_ImageCore = New ImageCore()
        m_TwainManager = New TwainManager(m_StrProductKey)
        dsViewer1.Bind(m_ImageCore)
    End Sub
    Public Sub OnPostAllTransfers() Implements IAcquireCallback.OnPostAllTransfers
        m_ImageCore.IO.LoadImage(strFileName)
    End Sub

    Public Function OnPostTransfer(bit As Bitmap) As Boolean Implements IAcquireCallback.OnPostTransfer
        Return True
    End Function

    Public Sub OnPreAllTransfers() Implements IAcquireCallback.OnPreAllTransfers
    End Sub

    Public Function OnPreTransfer() As Boolean Implements IAcquireCallback.OnPreTransfer
        Return True
    End Function

    Public Sub OnSourceUIClose() Implements IAcquireCallback.OnSourceUIClose
    End Sub

    Public Sub OnTransferCancelled() Implements IAcquireCallback.OnTransferCancelled
    End Sub

    Public Sub OnTransferError() Implements IAcquireCallback.OnTransferError
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs)
        m_TwainManager.Dispose()
    End Sub
    Private Sub ShooseDevice()
        Dim tempList As New List(Of String)()
        For i As Integer = 0 To m_TwainManager.SourceCount - 1
            tempList.Add(m_TwainManager.SourceNameItems(CShort(i)))
        Next
        Dim temp As New SourceListForm(tempList)
        temp.ShowDialog()
        Dim iSelectSource As Integer = temp.GetSelectedIndex()
        m_TwainManager.SelectSourceByIndex(CShort(iSelectSource))

    End Sub

    Private Sub LoadPicFromScnner()

        Try
            'If dlgFileSave.ShowDialog() = DialogResult.Cancel Then
            '    Return
            'End If

            '   strFileName = dlgFileSave.FileName

            strFileName = "Z:\Archive\TempFromScanner\" & My.Settings.UserName & "\Temp.bmp"

            m_TwainManager.OpenSource()

            Try
                m_TwainManager.TransferMode = Dynamsoft.TWAIN.Enums.TWICapSetupXFer.TWSX_FILE
            Catch ex As Exception
                MessageBox.Show("The license for TWAIN module is invalid. Please contact support@dynamsoft.com to get a trial license.")
            End Try


            'Since the TWSX_FILE mode is not required by TWAIN specification,
            'it is better to read the value back to see if the File transfer mode is supported by the Source
            If m_TwainManager.TransferMode = Dynamsoft.TWAIN.Enums.TWICapSetupXFer.TWSX_FILE Then
                'the source supports the TWSX_FILE transfer mode.
                m_TwainManager.SetFileXFERInfo(strFileName, Dynamsoft.TWAIN.Enums.TWICapFileFormat.TWFF_BMP)
                'Sets file name and file format information.
                m_TwainManager.IfShowUI = False
                m_TwainManager.IfDisableSourceAfterAcquire = True
                'Acquire the image.
                m_TwainManager.EnableSource(TryCast(Me, IAcquireCallback))
                ' m_TwainManager.CloseSource()
            Else
                'the source doesn't support the TWSX_FILE transfer mode.
                MessageBox.Show("The source doesn't support the DiskFile transfer mode.")
            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub ButtonAddDoc_Click(sender As Object, e As EventArgs) Handles ButtonAddDoc.Click
        LoadPicFromScnner()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ShooseDevice()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim AccFolder As String = CStr(SearchAccounts.EditValue)
        Dim DocType As String = CStr(SearchDocTypes.EditValue)
        Dim DocName As String = CStr(TextDocName.Text)
        Dim FileNameTemp As String = "Z:\Archive\TempFromScanner\" & My.Settings.UserName & "\Temp.bmp"
        Dim FileNameID As Integer
        Dim FileName As String

        Try

            If m_ImageCore Is Nothing Then
                MsgBox("لا يوجد صورة لحفظها")
                Exit Sub
            End If
            If IsNothing(AccFolder) Or AccFolder = "Null" Then
                MsgBox("يجب اختيار حساب")
                Exit Sub
            End If
            If IsNothing(DocType) Or DocType = "Null" Then
                MsgBox("يجب اختيار نوع الوثيقة")
                Exit Sub
            End If
            If IsNothing(DocName) Or String.IsNullOrEmpty(DocName) Or String.IsNullOrWhiteSpace(DocName) Then
                MsgBox("خطا: اسم الوثيقة فارغ")
                TextDocName.Text = ""
                Exit Sub
            End If


            Dim sql2 As New SQLControl
            Dim SqlString As String = " Select Max(DocID) As FileName from ArchiveDocs"
            sql2.CRMRunQuery(SqlString)
            FileNameID = CInt(sql2.SQLDS.Tables(0).Rows(0).Item("FileName")) + 1
            FileName = "Z:\Archive\" & AccFolder & "\" & FileNameID & ".bmp"


            Dim sql As New SQLControl
            Dim SQLInsert As String = " Insert Into  [ArchiveDocs] 
                                            (  [DocName],DocType,DocAccountCode,DocDetails,DocInputDate,DocInputUser,DocLocation) 
                                            Values (  '" & DocName & "','" & DocType & "','" & AccFolder & "','" _
                                            & TextDocementDetails.Text & "','" & Format(Now, "yyyy-MM-dd HH:mm") _
                                            & "','" & My.Settings.UserName & "','" & FileName & "')"
            sql.CRMRunQuery(SQLInsert)



            m_ImageCore = New ImageCore()
            dsViewer1.Bind(m_ImageCore)

            Try
                My.Computer.FileSystem.MoveFile(FileNameTemp, FileName)
            Catch ex As Exception
                MsgBox("لا يوجد ملف لنقله")
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Sub ArchiveInputFromScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocTypes' table. You can move, or remove it, as needed.
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        ShooseDevice()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ArchiveDocuTypes.Show()
    End Sub

    Private Sub SearchDocTypes_EditValueChanged(sender As Object, e As EventArgs) Handles SearchDocTypes.EditValueChanged

    End Sub

    Private Sub SearchDocTypes_Click(sender As Object, e As EventArgs) Handles SearchDocTypes.Click
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)
    End Sub
End Class