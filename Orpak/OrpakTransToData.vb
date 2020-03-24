Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class OrpakTransToData
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            XtraOpenFileDialog1.ShowDialog()
            Me.TextFileBath.Text = XtraOpenFileDialog1.FileName
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub OrpakTransToData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If String.IsNullOrEmpty(TextFileBath.Text) Then
            MsgBox("مسار الملف فارغ")
            Exit Sub
        End If

        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DtSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & TextFileBath.Text & "';Extended Properties=Excel 8.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "Net-informations.com")
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            GridControl1.DataSource = DtSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ImportDataFromExcel(TextFileBath.Text)
    End Sub
    Public Sub ImportDataFromExcel(ByVal excelFilePath As String)
        Try


            Dim ssqltable As String = "DATA"

            Dim myexceldataquery As String = " select [TransID] ,[SerNo],[TransDate],[TransTime],[Fleet],[Vehicle_Number]
                                            , [ProductName],[Quantity] ,[TotalSale] ,[StationName],[Receipt]
                                            , [FleetCode] ,[DeviceName] ,[TransMonth] ,[TransYear],[Odometer],ProductCode,Price from [sheet1$] where [TransID] is not null "


            Dim sexcelconnectionstring As String = (Convert.ToString("provider=microsoft.jet.oledb.4.0;data source=") & excelFilePath) + ";extended properties=" + """excel 8.0;hdr=yes;"""
            Dim SqlConnection As String = CRMString
            Dim oledbconn As New OleDbConnection(sexcelconnectionstring)
            Dim oledbcmd As New OleDbCommand(myexceldataquery, oledbconn)
            oledbconn.Open()
            Dim dr As OleDbDataReader = oledbcmd.ExecuteReader()
            Dim bulkcopy As New SqlBulkCopy(SqlConnection)
            bulkcopy.DestinationTableName = ssqltable

            While dr.Read()
                bulkcopy.BulkCopyTimeout = 120
                bulkcopy.WriteToServer(dr)
            End While

            dr.Close()
            oledbconn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class