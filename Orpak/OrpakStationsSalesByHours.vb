Imports System.ComponentModel
Imports System.Timers
Imports System.Windows.Controls
Imports DevExpress.DashboardWin

Public Class OrpakStationsSalesByHours
    Private timer As System.Timers.Timer
    Private Sub OrpakStationsSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Timer1 As System.Timers.Timer = New Timer(1800000)
        AddHandler Timer1.Elapsed, AddressOf OnTimedEvent
        Timer1.Enabled = True
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        DashboardViewer1.ReloadData()
    End Sub

    Private Sub DashboardViewer1_Load(sender As Object, e As EventArgs) Handles DashboardViewer1.Load

    End Sub

    'Private Sub DashboardViewer1_CustomizeDashboardTitleText(sender As Object, e As CustomizeDashboardTitleTextEventArgs) Handles DashboardViewer1.CustomizeDashboardTitleText
    '    e.Text = CType(DashboardViewer1.Dashboard.Title.Text & " " & " اخر تحديث " & " " & Format(Now, "HH:mm"), String) & " " & "تحديث على " & ":" & Format(Now.AddMinutes(30), "HH:mm")
    'End Sub
End Class