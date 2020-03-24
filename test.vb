Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Management
Imports System.Net.WebRequestMethods
Imports System.Text

Public Class test
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub CopyDataGridViewToClipboard(ByRef dgv As DataGridView)
        Dim s As String = ""
        Dim oCurrentCol As DataGridViewColumn    'Get header
        oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Do
            s &= oCurrentCol.HeaderText & Chr(Keys.Tab)
            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
         DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        Loop Until oCurrentCol Is Nothing
        s = s.Substring(0, s.Length - 1)
        s &= Environment.NewLine    'Get rows
        For Each row As DataGridViewRow In dgv.Rows
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
            Do
                If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then
                    s &= row.Cells(oCurrentCol.Index).Value.ToString
                End If
                s &= Chr(Keys.Tab)
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
              DataGridViewElementStates.Visible, DataGridViewElementStates.None)
            Loop Until oCurrentCol Is Nothing
            s = s.Substring(0, s.Length - 1)
            s &= Environment.NewLine
        Next    'Put to clipboard
        Dim o As New DataObject
        o.SetText(s)
        Clipboard.SetDataObject(o, True)
    End Sub
    Private Sub CopyDataGridViewToClipboard(ByVal dgv As DataGridView, ByVal Optional includeHeaders As Boolean = True, ByVal Optional allRows As Boolean = False)
        Try
            Dim s As String = ""
            Dim oCurrentCol As DataGridViewColumn = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)

            If includeHeaders Then

                Do
                    s = s & oCurrentCol.HeaderText & vbTab
                    oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None)
                Loop While oCurrentCol IsNot Nothing

                s = s.Substring(0, s.Length - 1)
                s = s & Environment.NewLine
            End If

            For Each row As DataGridViewRow In dgv.Rows
                oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)

                If row.Selected OrElse allRows Then

                    Do
                        If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then s = s & row.Cells(oCurrentCol.Index).Value.ToString()
                        s = s & vbTab
                        oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None)
                    Loop While oCurrentCol IsNot Nothing

                    s = s.Substring(0, s.Length - 1)
                    s = s & Environment.NewLine
                End If
            Next

            Clipboard.SetText(s)
        Catch ex As Exception
            '  toolStripStatusLabel2.Text = "Error: " & ex.Message
        End Try
    End Sub


    Private Function UniqueMachineId() As String
        Dim builder As StringBuilder = New StringBuilder()
        Dim query As String = "SELECT * FROM Win32_BIOS"
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher(query)

        For Each item As ManagementObject In searcher.[Get]()
            Dim obj As Object = item("Manufacturer")
            builder.Append(Convert.ToString(obj))
            builder.Append(":"c)
            obj = item("SerialNumber")
            builder.Append(Convert.ToString(obj))
        Next

        Return builder.ToString()
    End Function


    Public Function GetMACAddress() As String
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty

        For Each mo As ManagementObject In moc

            If MACAddress = String.Empty Then
                If CBool(mo("IPEnabled")) = True Then MACAddress = mo("MacAddress").ToString()
            End If

            mo.Dispose()
        Next

        Return MACAddress
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ImportDataFromExcel("E:\Book.xls")
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
            Label1.Text = "File imported into sql server."

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

