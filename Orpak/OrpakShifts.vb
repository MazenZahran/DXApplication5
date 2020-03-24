Public Class OrpakShifts
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        RefreshData()
    End Sub
    Private Sub RefreshData()

        Try
            GridControl1.DataSource = ""
            Dim SqlString As String = ""
            Dim sql As New SQLControl
            ' Dim Station As String
            Dim DateFrom As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")
            Dim DateTo As String = Format(DateEdit2.DateTime, "yyyy-MM-dd")
            '  Station = CStr(SearcStations.EditValue)

            Dim Station As String = CStr(SearcStations.EditValue)
            If String.IsNullOrEmpty(Station) Then Station = "Null"


            SqlString = "  select [shift_id],[plate],stations.[stn_name],type,sum([quantity]) as Quantity,sum([sale]) as Sales
  FROM [HO_DATA].[dbo].[transactions],[HO_DATA].[dbo].[stations]
  where (transactions.stn_id = stations.stn_id)  and ([date] between '" & DateFrom & "' and '" & DateTo & "') "
            If Station <> "Null" Then SqlString = SqlString + " and transactions.stn_id ='" & CStr(Station) & "'"
            Select Case CStr(RadioGroup2.EditValue)
                Case "1"
                    SqlString = SqlString + " and type='atndt' "
                Case "2"
                    SqlString = SqlString + " and type='CSTMR' "
            End Select

            SqlString = SqlString + " group by [shift_id],[plate],[stn_name],type  HAVING sum([quantity]) > " & CStr(TextEditGreater.EditValue)


            sql.RunQuery(SqlString)

            If sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub

            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub OrpakShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WALLETDataSet.STATIONS' table. You can move, or remove it, as needed.
        Me.STATIONSTableAdapter.Fill(Me.WALLETDataSet.STATIONS)
        DateEdit1.DateTime = Today.AddDays(-1)
        DateEdit2.DateTime = Today
        TextEditGreater.EditValue = 0
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If CStr(RadioGroup1.EditValue) = "1" Then Colplate.GroupIndex = 0
        If CStr(RadioGroup1.EditValue) = "2" Then Colshift_id.GroupIndex = 0
        If CStr(RadioGroup1.EditValue) = "3" Then
            Colshift_id.GroupIndex = -1
            Colplate.GroupIndex = -1
        End If
    End Sub
End Class