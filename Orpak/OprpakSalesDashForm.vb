Public Class OprpakSalesDashForm
    Private Sub OprpakSalesDashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case CStr(RadioGroup1.EditValue)
            Case "Monthly"
                Me.DashboardViewer1.DashboardSource = "DXApplication5.Win_Dashboards.OrpakSalesByStationMonthly"
                Me.Text = "تقرير مبيعات المحطات شهري"
            Case "Daily"
                Me.DashboardViewer1.DashboardSource = "DXApplication5.Win_Dashboards.OrpakSles"
                Me.Text = "تقرير مبيعات المحطات يومي"
        End Select

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DashboardViewer1.ShowPrintPreview()
    End Sub
End Class