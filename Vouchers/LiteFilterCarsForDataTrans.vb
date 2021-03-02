Public Class LiteFilterCarsForDataTrans
    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextFleetCode.EditValueChanged
        Dim Sql As New SQLControl
        Sql.RunQuery("SELECT       [plate]
  FROM [HO_DATA].[dbo].[means]
  left join fleets F on F.id=means.fleet_id
  where F.code='" & TextFleetCode.Text & "' ")
        GridControl1.DataSource = Sql.SQLDS.Tables(0)
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        Dim _Text As String = "(''"
        GlobalVariables.FilteredCars = ""
        For i As Integer = 0 To selectedRowHandles.Length - 1
            Dim value As Object = GridView1.GetRowCellValue(selectedRowHandles(i), "plate")
            _Text += ",'" & CStr(value) & "'"
        Next
        TextEdit1.Text = _Text & " )"
        ' and T.plate in ('78-024-12','28183H basel','6-3559-95 amen')
        GlobalVariables.FilteredCars = TextEdit1.Text
        Me.Close()
        '   Dim jurisdictionData As String() = _Text.Split(","c)
        ' GridControl2.DataSource = jurisdictionData
    End Sub
End Class