

Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class OnlineEUCoops
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            Dim MySqlConnection = New MySqlConnection
            Dim MySqlString As String = "server=alhuda.ps;Port=3306; User ID=alhudaps_mazen; password=1031342@mM; database= " & DataBaseName.Text & " ; Connect Timeout=1000"
            '  Dim MySqlString As String = "server=alhuda.ps;Port=3306; User ID=alhudaps_mazen; password=1031342@mM; database= " & DataBaseName.Text & " ; Connect Timeout=1000"
            MySqlConnection.ConnectionString = MySqlString

            MySqlConnection.Open()
            Dim MyAdapter As New MySqlDataAdapter
            Dim SqlQuary = "SELECT   * From fuelltrans" & " ORDER BY fuelltrans.tdate DESC " & " limit " & Me.TransCountComboBox.Text
            Dim Command As New MySqlCommand
            Command.Connection = MySqlConnection
            Command.CommandText = SqlQuary
            MyAdapter.SelectCommand = Command
            Dim Mydata As MySqlDataReader
            Mydata = Command.ExecuteReader
            If CInt(Mydata.HasRows) = 0 Then
                MsgBox("Error During Login:Please Enter Valid Data")
            Else
                Me.GridControl1.DataSource = Mydata
            End If
            MySqlConnection.Close()

            MySqlConnection.Open()
            Dim MyAdapter2 As New MySqlDataAdapter
            Dim SqlQuary2 = "SELECT count(id)  From fuelltrans" & " ORDER BY fuelltrans.tdate DESC "
            Dim Command2 As New MySqlCommand
            Command2.Connection = MySqlConnection
            Command2.CommandText = SqlQuary2
            MyAdapter2.SelectCommand = Command2
            Dim Mydata2 As MySqlDataReader
            Mydata2 = Command2.ExecuteReader
            While Mydata2.Read
                If CInt(Mydata2.HasRows) = 0 Then
                    MsgBox("Error During Login:Please Enter Valid Data")
                Else
                    TotalTransTextEdit.Text = CType(Mydata2(0), String)
                End If
            End While
            MySqlConnection.Close()

        Catch ex As Exception
            MsgBox("الرجاء اعادة المحاولة")
        End Try

    End Sub

    Private Sub OnlineEUCoops_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransCountComboBox.EditValue = 1000
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        Dim gw As GridView = TryCast(sender, GridView)
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class