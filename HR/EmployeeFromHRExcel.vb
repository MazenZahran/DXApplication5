Imports System.Data.OleDb
Imports System.IO

Public Class EmployeeFromHRExcel
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridControl1.DataSource = ExcelDataSource1
    End Sub

    Sub ImportFromExcel()
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        '   Dim excel As String
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\ma_ze\Desktop\testesttest.xlsx" + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
        dts = New DataSet
        dta.Fill(dts, "[Sheet1$]")
        GridControl1.DataSource = dts
        GridControl1.DataMember = "[Sheet1$]"
        conn.Close()
    End Sub
End Class