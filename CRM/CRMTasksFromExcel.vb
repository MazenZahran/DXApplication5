Imports System.Data.OleDb
Imports System.IO

Public Class CRMTasksFromExcel

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridControl1.DataSource = OpenFile("TasksExcel.xls")
    End Sub

    Private Function OpenFile(ByVal fileName As String) As Object
        Dim fullFileName = String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)

        If (Not File.Exists(fullFileName)) Then
            System.Windows.Forms.MessageBox.Show("File not found")
            Return Nothing
        End If
        Dim connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0 Xml;", fullFileName)
        Dim ExcelString As String = "Select * from [Sheet1$] where [Sorting] between " & TextEdit1.Text & "  and " & TextEdit2.Text & " order by [Sorting],[Amount] Desc "

        Dim adapter = New OleDbDataAdapter(ExcelString, connectionString)
        Dim ds = New DataSet()
        Dim tableName As String = "excelData"
        adapter.Fill(ds, tableName)
        Dim data As DataTable = ds.Tables(tableName)
        '  GridControl1.DataSource = OpenFile()
        Return data
    End Function

    Private Sub CRMTasksFromExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.Users' table. You can move, or remove it, as needed.
        '   Me.UsersTableAdapter.Fill(Me.CRMDataSet.Users)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        'Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim I As Integer

        Try
            If GridView1.RowCount < 0 Then MsgBox("لا يوجد بيانات ") : Exit Sub
            If MonthText.Text = "" Then MsgBox("خانة الشهر فارغة") : Exit Sub
            If ToUserText.Text = "" Then MsgBox("خانة الموظف فارغة") : Exit Sub
            For I = 0 To GridView1.RowCount - 1
                Dim sql As New SQLControl
                Dim SQLInsertTaskLog As String = " insert into  [CRM].[dbo].[CRMTasks]
                                           ( [InputDate],[InputTime],[User],[CustID] ,[CustomerName],[Person],[Note],[NoteStatus],[ToUser],[AccrualDate],
                                           [TaskType],[AccSort],[Amount],[TaskMonth] ,[Importance],[Mobile] ) values (
                                            " & "'" & Format(Today, "yyyy-MM-dd") & "', " & "
                                            " & "'" & Format(Now, "HH:mm:ss") & "', " & "
                                            " & "'" & "System" & "', " & "
                                            " & "'" & CType(Me.GridView1.GetRowCellValue(I, "Account"), String) & "', " & "
                                            " & "'" & CType(Me.GridView1.GetRowCellValue(I, "AccountName"), String) & "', " & "
                                            " & "'" & GetAccData(CType(Me.GridView1.GetRowCellValue(I, "Account"), String)).Country & "', " & "
                                            " & "'" & " تحصيل شهر  " & MonthText.Text & " ', " & "
                                            " & "'" & "مفتوحة" & "', " & "
                                            " & "'" & ToUserText.Text & "', " & "
                                            " & "'" & Format(Today, "yyyy-MM-dd") & "', " & "
                                            " & "'" & "دين" & "', " & "
                                            " & "'" & CType(Me.GridView1.GetRowCellValue(I, "Sorting"), String) & "', " & "
                                            " & "'" & CType(Me.GridView1.GetRowCellValue(I, "Amount"), String) & "', " & "
                                            " & "'" & MonthText.Text & "', " & "
                                            " & "'" & "1" & "', " & "
                                            " & " '" & GetAccData(CType(Me.GridView1.GetRowCellValue(I, "Account"), String)).sphone & "' )"
                sql.CRMRunQuery(SQLInsertTaskLog)
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class