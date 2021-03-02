Public Class LiteEditSingleTrans
    Private Sub ID_EditValueChanged(sender As Object, e As EventArgs) Handles ID.EditValueChanged

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " select ID,Fleet,FleetCode,SerNo,TransDate,CONVERT(varchar(5), [TransTime], 108) as TransTime,Vehicle_Number,ProductName,Quantity,CONVERT(DECIMAL(10,2),TotalSale/Quantity)as Price,
                          TotalSale,StationName,Receipt,Odometer,TransMonth,TransYear
                          from [CRM].[dbo].[DATA]
                          where ID =  " & ID.Text
            Sql.CRMRunQuery(SqlString)
            FleetCode.EditValue = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("FleetCode"))
            '  FleetName.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("Fleet"))
            SerNo.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("SerNo"))
            Receipt.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("Receipt"))
            TransDate.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TransDate"))
            TransTime.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TransTime"))
            Vehicle_Number.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("Vehicle_Number"))
            StationName.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("StationName"))
            TotalSale.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TotalSale"))
            Quantity.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("Quantity"))
            ProductName.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("ProductName"))
            TransMonth.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TransMonth"))
            TransYear.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("TransYear"))
        Catch ex As Exception

        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If String.IsNullOrEmpty(FleetCode.Text) Or String.IsNullOrEmpty(FleetCode.Text) _
            Or String.IsNullOrEmpty(Quantity.Text) Or String.IsNullOrEmpty(TotalSale.Text) _
            Or String.IsNullOrEmpty(TransMonth.Text) Or String.IsNullOrEmpty(TransYear.Text) _
            Or String.IsNullOrEmpty(ProductName.Text) Or String.IsNullOrEmpty(ID.Text) Then
            MsgBox("يوجد خانات فارغة يجب تعبئتها")
        End If
        Dim Sql As New SQLControl
        Dim SqlString As String
        SqlString = " update [CRM].[dbo].[DATA] set FleetCode='" & CStr(FleetCode.EditValue) _
                       & "', Fleet='" & FleetCode.Text & "', Quantity =" & Quantity.Text _
                       & " , TotalSale=" & TotalSale.Text & " , ProductName='" & ProductName.Text & "'" _
                       & " , TransMonth=" & TransMonth.Text & " , TransYear=" & TransYear.Text _
                       & " , [Vehicle_Number]='" & Vehicle_Number.Text & "' , StationName='" & StationName.Text & "'" _
                       & "  where ID= " & ID.Text
        Sql.CRMRunQuery(SqlString)
        Me.Close()
    End Sub

    Private Sub LiteEditSingleTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)

    End Sub

    Private Sub FleetCode_EditValueChanged(sender As Object, e As EventArgs) Handles FleetCode.EditValueChanged

    End Sub

    Private Sub Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles Quantity.EditValueChanged
        Try
            Me.TextPrice.EditValue = CDec(TotalSale.EditValue) / CDec(Quantity.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TotalSale_EditValueChanged(sender As Object, e As EventArgs) Handles TotalSale.EditValueChanged
        Try
            Me.TextPrice.EditValue = CDec(TotalSale.EditValue) / CDec(Quantity.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransDate_EditValueChanged(sender As Object, e As EventArgs) Handles TransDate.EditValueChanged

    End Sub
End Class