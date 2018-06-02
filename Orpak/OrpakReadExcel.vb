Imports System.Data.OleDb
Imports System.IO

Public Class OrpakReadExcel
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        GridControl1.DataSource = OpenFile()
    End Sub

    Public Shared Function OpenFile() As Object
        '  Dim fullFileName = ExcelString
        'If (Not File.Exists(fullFileName)) Then
        '    System.Windows.Forms.MessageBox.Show("File not found")
        '    Return Nothing
        'End If
        MsgBox(ExcelString)

        '   Provider="Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx; Extended Properties="Excel 12.0 Xml;HDR=YES"

        Dim connectionString As String = ExcelString
        Dim adapter = New OleDbDataAdapter("select * from [data$A1:p1000000] ", connectionString)
        Dim ds = New DataSet()
        Dim tableName As String = "excelData"
        adapter.Fill(ds, tableName)
        Dim data As DataTable = ds.Tables(tableName)
        Return data
    End Function


End Class