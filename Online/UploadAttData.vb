Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class UploadAttData


    Private Sub UploadAttData()
        Dim MySqlConnection = New MySqlConnection
        Dim MySqlString As String = "server=alhuda.ps;Port=3306; User ID=alhudaps_mazen; password=1031342@mM; database= alhudaps_Attendance ; Connect Timeout=1000"
        MySqlConnection.ConnectionString = MySqlString
        MySqlConnection.Open()
        Dim MyAdapter As New MySqlDataAdapter
        Dim SqlQuary = " insert into alhudaps_Attendance "
        Dim Command As New MySqlCommand
        Command.Connection = MySqlConnection
        Command.CommandText = SqlQuary
        MyAdapter.SelectCommand = Command
        Dim Mydata As MySqlDataReader
        Mydata = Command.ExecuteReader
        MySqlConnection.Close()
    End Sub

    Public Shared Sub BulkToMySQL()

        Try
            Dim AttTable As New DataTable
            With AttTable
                .Columns.Add("USERID", GetType(String))
                .Columns.Add("CHECKTIME", GetType(DateTime))
                .Columns.Add("CHECKTYPE", GetType(String))
                .Columns.Add("SENSORID", GetType(String))
                .Columns.Add("ID", GetType(Integer))
            End With

            Dim sql As New SQLControl
            Dim SqlString As String
            SqlString = "    Select  [EmployeesData].EmployeeName , USERID,CHECKTIME,CHECKTYPE,MachineAlias,[AttCHECKINOUT].[ID] ,[Branch]
                         From    [AttCHECKINOUT] left join [EmployeesData] on AttCHECKINOUT.userid=[EmployeesData].EmployeeID
                                                 left join Machines on AttCHECKINOUT.[SENSORID]=Machines.sn
                         where   [AttCHECKINOUT].[ID] > 104000  "
            sql.TrueTimeRunQuery(SqlString)
            AttTable = sql.SQLDS.Tables(0)


            Dim ConnectionString As String = "server=alhuda.ps;Port=3306; User ID=alhudaps_mazen; password=1031342@mM; database= alhudaps_Attendance ; Connect Timeout=1000;CHARSET=utf8"
            Dim sCommand As StringBuilder = New StringBuilder("INSERT INTO CHECKINOUT (USERID, CHECKTIME,CHECKTYPE,MachineAlias,ID,EmployeeName,Branch) VALUES ")

            Using mConnection As MySqlConnection = New MySqlConnection(ConnectionString)
                Dim Rows As List(Of String) = New List(Of String)()


                For i = 0 To AttTable.Rows.Count - 1
                    Rows.Add(String.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                             AttTable.Rows(i).Item("USERID").ToString,
                             Format(CDate(AttTable.Rows(i).Item("CHECKTIME").ToString), "yyyy-MM-dd HH:mm"),
                             AttTable.Rows(i).Item("CHECKTYPE").ToString,
                             AttTable.Rows(i).Item("MachineAlias").ToString,
                             AttTable.Rows(i).Item("ID").ToString,
                             AttTable.Rows(i).Item("EmployeeName").ToString,
                             AttTable.Rows(i).Item("Branch").ToString))
                Next

                sCommand.Append(String.Join(",", Rows))
                sCommand.Append(";")
                mConnection.Open()


                Using myCmd As MySqlCommand = New MySqlCommand(sCommand.ToString(), mConnection)
                    myCmd.CommandType = CommandType.Text
                    myCmd.ExecuteNonQuery()
                End Using

                Dim sql2 As New SQLControl
                '  Dim SqlString2 As String
                sql.CRMRunQuery("Inset into  ")

            End Using

            MsgBox("تم رفع " & AttTable.Rows.Count)
        Catch ex As Exception

        End Try



    End Sub

    Public Shared Sub BulkToMySQLOrback()

        Try
            Dim TempTable As New DataTable
            With TempTable
                .Columns.Add("id", GetType(String))
                .Columns.Add("status", GetType(String))
                .Columns.Add("rule", GetType(String))
                .Columns.Add("fleet_id", GetType(String))
            End With

            Dim sql As New SQLControl
            Dim SqlString As String
            SqlString = "   SELECT  [id],[status],[rule],[fleet_id] from [means] where status <> 0"
            sql.RunQuery(SqlString)
            TempTable = sql.SQLDS.Tables(0)
            MsgBox(TempTable.Rows.Count)

            '   Dim ConnectionString As String = "Provider=SQLOLEDB;Data Source=SQL5043.site4now.net;Initial Catalog=DB_A4F816_orbak;User Id=DB_A4F816_orbak_admin;Password=1031342mM;"
            Dim sCommand As StringBuilder = New StringBuilder("INSERT INTO means ([id],[status],[rule],[fleet_id]) VALUES ")

            Using mConnection As New SqlConnection(OrbakOnLineString)
                Dim Rows As List(Of String) = New List(Of String)()


                For i = 0 To TempTable.Rows.Count - 1
                    Rows.Add(String.Format("('{0}','{1}','{2}','{3}')",
                             TempTable.Rows(i).Item("id").ToString,
                             TempTable.Rows(i).Item("status").ToString,
                             TempTable.Rows(i).Item("rule").ToString,
                             TempTable.Rows(i).Item("fleet_id").ToString))
                Next

                sCommand.Append(String.Join(",", Rows))
                sCommand.Append(";")
                mConnection.Open()


                Using myCmd As SqlCommand = New SqlCommand(sCommand.ToString(), mConnection)
                    myCmd.CommandType = CommandType.Text
                    myCmd.ExecuteNonQuery()
                End Using


            End Using

            MsgBox("تم رفع " & TempTable.Rows.Count)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        MeansBulk()
        FleetsBulk()
        MsgBox("Done")
    End Sub

    Private Sub MeansBulk()
        Dim strConSrc As New SqlConnection(OrbakString)
        Dim strConDest As New SqlConnection(OrbakOnLineString)

        Dim strComm As New SqlCommand("SELECT [name] ,[string] ,[type] ,[id]
      ,[status] ,[rule] ,[hardware_type] ,[plate] 
       from [means] where [status] <> 0", strConSrc)

        strConSrc.Open()
        Dim drCopy As SqlDataReader = strComm.ExecuteReader

        Dim bcCopy As New SqlBulkCopy(strConDest)

        strConDest.Open()
        bcCopy.DestinationTableName = "means"

        bcCopy.ColumnMappings.Add("name", "name")
        bcCopy.ColumnMappings.Add("string", "string")
        bcCopy.ColumnMappings.Add("type", "type")
        bcCopy.ColumnMappings.Add("id", "id")
        bcCopy.ColumnMappings.Add("status", "status")
        bcCopy.ColumnMappings.Add("rule", "rule")
        bcCopy.ColumnMappings.Add("hardware_type", "hardware_type")
        bcCopy.ColumnMappings.Add("plate", "plate")


        bcCopy.WriteToServer(drCopy)

        drCopy.Close()

        strConSrc.Close()
        strConDest.Close()



    End Sub

    Private Sub FleetsBulk()
        Dim strConSrc As New SqlConnection(OrbakString)
        Dim strConDest As New SqlConnection(OrbakOnLineString)

        Dim strComm As New SqlCommand(" select [id] ,[name] ,[status] ,[code],
          [acctyp] ,[available_amount] from [fleets] where [status] <> 0", strConSrc)

        strConSrc.Open()
        Dim drCopy As SqlDataReader = strComm.ExecuteReader

        Dim bcCopy As New SqlBulkCopy(strConDest)

        strConDest.Open()
        bcCopy.DestinationTableName = "fleets"

        bcCopy.ColumnMappings.Add("id", "id")
        bcCopy.ColumnMappings.Add("name", "name")
        bcCopy.ColumnMappings.Add("status", "status")
        bcCopy.ColumnMappings.Add("code", "code")
        bcCopy.ColumnMappings.Add("acctyp", "acctyp")
        bcCopy.ColumnMappings.Add("available_amount", "available_amount")

        bcCopy.WriteToServer(drCopy)

        drCopy.Close()

        strConSrc.Close()
        strConDest.Close()



    End Sub
End Class