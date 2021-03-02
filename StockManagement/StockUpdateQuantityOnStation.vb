Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Globalization

Public Class StockUpdateQuantityOnStation
    Private Sub StockUpdateQuantityOnStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HO_DATADataSet.stations' table. You can move, or remove it, as needed.
        Me.StationsTableAdapter.Fill(Me.HO_DATADataSet.stations)

    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEdit1.EditValueChanged
        GetconnectionString()
    End Sub
    Private Function GetConnectionString(Stn_ID As String) As String
        Dim _GetConnectionString As String
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = " select ConnectionString from Stations where Stn_ID= '" & Stn_ID & "'"
            Sql.CRMRunQuery(SqlString)
            _GetConnectionString = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("ConnectionString"))
        Catch ex As Exception
            _GetConnectionString = "0"
        End Try
        Return _GetConnectionString
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetData()
    End Sub
    Private Sub GetData()
        GetconnectionString()

        GridControl1.DataSource = ""

        If String.IsNullOrEmpty(SearchLookUpEdit1.Text) Then
            MsgBox("يجب اختيار محطة")
            Exit Sub
        End If

        If String.IsNullOrEmpty(TextConnectionString.Text) Or TextConnectionString.Text = "0" Then
            MsgBox("اعدادات المحطة غير متوفرة")
            Exit Sub
        End If

        Dim con As New SqlConnection(TextConnectionString.Text)
        Dim sqlString As String = " SELECT [warehouse_id]      ,[product_id]      ,[start_inventory],
                                           [current_inventory]	  ,[name]	  ,[code]
                                    FROM [DATA].[dbo].[warehouse_inventory] W
                                    left join [DATA].[dbo].[products] P on W.product_id=P.[ID] "
        Dim cmd As New SqlCommand(sqlString, con)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)

        GridControl1.DataSource = table


    End Sub

    Private Sub RepositoryEditQuantity_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryEditQuantity.ButtonClick

        Dim StockID As Integer = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "product_id"))
        Dim Quantity As Integer = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "current_inventory"))

        If String.IsNullOrEmpty(Me.TextConnectionString.Text) Then
            MsgBox("لا يمكن تعديل الصنف")
            Exit Sub
        End If

        Using sqlCon = New SqlConnection(Me.TextConnectionString.Text)
            sqlCon.Open()
            Dim sqlText = " UPDATE [DATA].[dbo].[warehouse_inventory] 
                            SET [current_inventory] = " & Quantity & "  WHERE product_id = @name"
#Disable Warning CA2100 ' Review SQL queries for security vulnerabilities
            Dim cmd = New SqlCommand(sqlText, sqlCon)
#Enable Warning CA2100 ' Review SQL queries for security vulnerabilities
            cmd.Parameters.AddWithValue("@name", StockID)
            cmd.ExecuteNonQuery()
            MsgBox("تم تعديل كمية الصنف")
            ' GridControl1.DataSource = ""
            '   GetData()
        End Using
    End Sub
    Private Sub GetconnectionString()
        Dim Stn_ID As String
        Stn_ID = CStr(SearchLookUpEdit1.EditValue)
        If String.IsNullOrEmpty(Stn_ID) Then Exit Sub
        TextConnectionString.Text = GetConnectionString(Stn_ID)
    End Sub

End Class