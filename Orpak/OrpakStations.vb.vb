Imports System.Timers
Public Class OrpakStations
    Private Sub GetStationsData()

        Try
            Dim sql As New SQLControl
            Dim SqlGetStations As String
            SqlGetStations = "Select stn_id,stn_name,host_ip,last_update from stations  order by  stn_id "
            sql.RunQuery(SqlGetStations)

            Dim StationsTable As New DataTable
            StationsTable = sql.SQLDS.Tables(0)

            With StationsTable
                .Columns.Add("TablesSizeMB", GetType(Int32))
                .Columns.Add("TotalRows", GetType(Int32))
                .Columns.Add("LastUpdateBalances", GetType(DateTime))
                .Columns.Add("ServerName", GetType(String))
                .Columns.Add("SSIze", GetType(Int32))
                .Columns.Add("AvailableSSIze", GetType(Int32))
                .Columns.Add("ElapseTime", GetType(TimeSpan))
                .Columns.Add("ElapseTimeForConnect", GetType(TimeSpan))
                .Columns.Add("ElapseTimeForUpdateBalances", GetType(TimeSpan))
                .Columns.Add("LastMeansUpdate", GetType(String))
            End With

            Try
                For i As Integer = 0 To StationsTable.Rows.Count - 1
                    Dim sql2 As New SQLControl
                    Dim SqlString As String = " Select top(1) * from [CRM].[dbo].OrpakUpdateBalanceLogs
                                                Where LastMeansUpdate is null and [LogStationName]= '" & StationsTable.Rows(i).Item("host_ip").ToString & "' order by LogID desc"
                    sql2.CRMRunQuery(SqlString)
                    If sql2.SQLDS.Tables(0).Rows.Count > 0 Then
                        StationsTable.Rows(i).Item("TablesSizeMB") = sql2.SQLDS.Tables(0).Rows(0).Item("TablesSizeMB").ToString
                        StationsTable.Rows(i).Item("TotalRows") = sql2.SQLDS.Tables(0).Rows(0).Item("TablesRowCount").ToString
                        StationsTable.Rows(i).Item("LastUpdateBalances") = (sql2.SQLDS.Tables(0).Rows(0).Item("LogDateTime").ToString)
                        StationsTable.Rows(i).Item("ServerName") = (sql2.SQLDS.Tables(0).Rows(0).Item("ServerName").ToString)
                        StationsTable.Rows(i).Item("SSIze") = (sql2.SQLDS.Tables(0).Rows(0).Item("SSIze").ToString)

                        StationsTable.Rows(i).Item("AvailableSSIze") = (sql2.SQLDS.Tables(0).Rows(0).Item("AvailableSSIze").ToString)
                        StationsTable.Rows(i).Item("ElapseTime") = (sql2.SQLDS.Tables(0).Rows(0).Item("ElapseTime").ToString)

                        If Not IsDBNull(StationsTable.Rows(i).Item("last_update")) Then
                            StationsTable.Rows(i).Item("ElapseTimeForConnect") = (Now).Subtract(Convert.ToDateTime(StationsTable.Rows(i).Item("last_update")))
                        End If

                        'If Not IsDBNull(StationsTable.Rows(i).Item("LastUpdateBalances")) Then
                        '    StationsTable.Rows(i).Item("ElapseTimeForUpdateBalances") = (Now).Subtract(Convert.ToDateTime(StationsTable.Rows(i).Item("LastUpdateBalances")))
                        'End If

                        ' LastMeansUpdate
                        StationsTable.Rows(i).Item("LastMeansUpdate") = GetLastMeansUpdate(StationsTable.Rows(i).Item("host_ip").ToString)
                    End If


                    'Try
                    '    Dim TableSize = StationsTable.Rows(i).Item("TablesSizeMB").ToString
                    '    If CInt(TableSize) > 3900 Then
                    '        '        TableSize = (StationsTable.Rows(i).Item("TablesSizeMB").ToString)
                    '        Dim Message As String = "Attention:  " + StationsTable.Rows(i).Item("stn_name").ToString + " TablesSize reach " + TableSize + "MB, @" + CStr(Now)
                    '        FunSendSmS2("597505029", Message)
                    '        FunSendSmS2("594270270", Message)
                    '    End If
                    'Catch ex As Exception

                    'End Try


                    'Try
                    '    If Not IsDBNull(StationsTable.Rows(i).Item("last_update")) Then
                    '        Dim ElapseTimeForConnect As TimeSpan
                    '        Dim Diff As TimeSpan = New TimeSpan(0, 30, 0)
                    '        ElapseTimeForConnect = (Now).Subtract(Convert.ToDateTime(StationsTable.Rows(i).Item("last_update")))
                    '        If ElapseTimeForConnect.TotalMinutes > Diff.TotalMinutes Then
                    '            Dim Message As String = "Attention:  " + (StationsTable.Rows(i).Item("stn_name").ToString) + " are disconntectd from " + String.Format("{0:n2}", ElapseTimeForConnect.TotalHours) + " Hours, @" + CStr(Now)
                    '            FunSendSmS2("597505029", Message)
                    '            FunSendSmS2("594270270", Message)
                    '        End If
                    '        '  StationsTable.Rows(i).Item("ElapseTimeForConnect") = (Now).Subtract(Convert.ToDateTime(StationsTable.Rows(i).Item("last_update")))
                    '    End If
                    'Catch ex As Exception

                    'End Try



                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            GridControl1.DataSource = StationsTable


            GridView1.BestFitColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetStationsData()


    End Sub

    Private Sub GetLogs()
        Try
            Dim sql As New SQLControl
            Dim SqlString As String
            SqlString = "SELECT TOP " & ComboBoxEdit1.Text & "   LogStationName,LogDateTime,ServerName,
                                      LogID,SSIze,AvailableSSIze,ElapseTime,TablesRowCount,TablesSizeMB,StationName
                         FROM [CRM].[dbo].[OrpakUpdateBalanceLogs]
                         Order by logid Desc"
            sql.RunQuery(SqlString)
            GridControl2.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetLogs()
    End Sub

    Private Sub OrpakStations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEditTimerInterval.EditValue = 60
        ComboBoxEdit1.EditValue = 1000

        'Dim Timer1 As System.Timers.Timer = New Timer(10000)
        'AddHandler Timer1.Elapsed, AddressOf OnTimedEvent


        Timer1.Enabled = True

        ' GetStationsData()
        GetLogs()
        GetStationsData()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim ServerIP As String
        ServerIP = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "host_ip"), String)
        Process.Start("Cmd.exe", "/C mstsc /v:" & ServerIP)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TextEdit1.EditValue = CInt(TextEdit1.EditValue) - 1
    End Sub

    Private Sub TextEditTimerInterval_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditTimerInterval.EditValueChanged
        TextEditLastUpdate.Text = "اخر تحديث : " + CStr(Now) + ", " + "  التحديث القادم:  " + CStr(Now.AddMinutes(CInt(TextEditTimerInterval.EditValue)))
        TextEdit1.EditValue = Val(TextEditTimerInterval.EditValue) * 60
        Timer1.Enabled = False
        Timer1.Interval = CInt(TextEditTimerInterval.EditValue) * 1000
        Timer1.Enabled = True
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        If CInt(TextEdit1.EditValue) = 0 Then
            GetStationsData()
            TextEditLastUpdate.Text = "اخر تحديث : " + CStr(Now) + ", " + "  التحديث القادم:  " + CStr(Now.AddMinutes(CInt(TextEditTimerInterval.EditValue)))
            TextEdit1.EditValue = Val(TextEditTimerInterval.EditValue) * 60
        End If
    End Sub



    'Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
    '    GetStationsData()
    '    GetLogs()
    'End Sub

    Private Function GetLastMeansUpdate(Stn_Ip As String) As String
        Dim _LastTransDate As String
        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery("Select top(1) LastMeansUpdate from OrpakUpdateBalanceLogs
             where LogStationName='" & Stn_Ip & "'   AND LastMeansUpdate IS NOT NULL order by LogID desc ")
            _LastTransDate = Sql.SQLDS.Tables(0).Rows(0).Item("LastMeansUpdate").ToString
        Catch ex As Exception
            _LastTransDate = "0"
        End Try
        Return _LastTransDate

    End Function

End Class