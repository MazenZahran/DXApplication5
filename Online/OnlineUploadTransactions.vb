Imports System.Text
Imports MySql.Data.MySqlClient

Public Class OnlineUploadTransactions
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        BulkToMySQL()
    End Sub
    Public Shared Sub BulkToMySQL()


        Dim MaxsIDTable As New DataTable
        With MaxsIDTable
            .Columns.Add("stnid", GetType(Integer))
            .Columns.Add("MaxID", GetType(Integer))
        End With
        Dim ds As New DataSet
        Dim MySqlConnection = New MySqlConnection
        Dim MySqlString As String = "server=alhuda.ps;Port=3306; User ID=alhudaps_mazen; password=1031342@mM; database= alhudaps_fuells ; Connect Timeout=1000"
        MySqlConnection.ConnectionString = MySqlString

        MySqlConnection.Open()
        Dim MyAdapter As New MySqlDataAdapter
        Dim SqlQuary = "select stnid,max(transid) as MaxID from fuelltrans group by stnid"
        Dim Command As New MySqlCommand With {
            .Connection = MySqlConnection,
            .CommandText = SqlQuary
        }
        MyAdapter.SelectCommand = Command
        Dim Mydata As MySqlDataReader
        Mydata = Command.ExecuteReader
        If CInt(Mydata.HasRows) = 0 Then
            MsgBox("Error During Login:Please Enter Valid Data")
        Else
            MaxsIDTable.Load(Mydata)
            MsgBox(MaxsIDTable.Rows.Count)
            '  MaxsIDTable = Mydata
        End If
        MySqlConnection.Close()

        Dim i As Integer
        Dim _MaxID As Integer : Dim _StnID As Integer
        For i = 0 To MaxsIDTable.Rows.Count - 1
            _MaxID = CInt(MaxsIDTable.Rows(i).Item("MaxID").ToString)
            _StnID = CInt(MaxsIDTable.Rows(i).Item("stnid").ToString)

        Next


    End Sub

    Private Sub SelectAndUpload(MaxID As Integer)
        Dim AttTable As New DataTable
        With AttTable
            .Columns.Add("transid", GetType(String))
            .Columns.Add("custcode", GetType(DateTime))
            .Columns.Add("stnid", GetType(String))
            .Columns.Add("deviceid", GetType(String))
            .Columns.Add("tdate", GetType(Integer))
            .Columns.Add("ttime", GetType(Integer))
            .Columns.Add("quantity", GetType(Integer))
            .Columns.Add("price", GetType(Integer))
            .Columns.Add("total", GetType(Integer))
            .Columns.Add("product_code", GetType(Integer))
            .Columns.Add("product_name", GetType(Integer))
            .Columns.Add("recptno", GetType(Integer))
            .Columns.Add("meanname", GetType(Integer))
            .Columns.Add("meanid", GetType(Integer))
        End With
        Dim sql As New SQLControl
        Dim SqlString As String
        SqlString = " SELECT     id, date, time, type, pump, nozzle, product_code, sale, ppv, quantity, density, temperature, tag, tank_id, track1, track2, odometer, engine_hours, 
                      fleet_id, mean_id, plate, coupon_id, external_tran_id, external_auth_number, trx_seq_no, fcc_bos_cleared, tank_name, mean_name, product_name, pump_id, 
                      nozzle_id, driver_object_id, driver_name, stn_id, txn_calc_status, sent_to_dho, sent_to_fho, counter2, counter3, timer2, timer3, previous_odometer, 
                      previous_engine_hours, hose_number, cash_customer_id, total_price_after_discount, receipt_id, entry_type, changed_trans_flag, billing_sale, pir_payment_type, 
                      pir_trans_date_time, pir_refuel_method, start_flow, end_flow, night_shift, pir_additional_plate, pir_additional_tag, pir_additional_type, fleet_code, fleet_name, 
                      proxy_id, base_price, price_list_id, base_product_percent, aux1_eh, aux2_eh, totalizer_vol, preset_volume, preset_money
FROM         transactions  "
        sql.TrueTimeRunQuery(SqlString)
        AttTable = sql.SQLDS.Tables(0)


        Dim ConnectionString As String = "server=alhuda.ps;Port=3306; User ID=alhudaps_mazen; password=1031342@mM; database= alhudaps_Attendance ; Connect Timeout=1000;CHARSET=utf8"
        Dim sCommand As StringBuilder = New StringBuilder("INSERT INTO fuelltransMazen ( transid, custcode, stnid, deviceid, tdate, ttime, quantity, price, total, product_code, product_name, recptno, stnname, meanname, meanid) VALUES ")

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



        End Using
    End Sub

End Class