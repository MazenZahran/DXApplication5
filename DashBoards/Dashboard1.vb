Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace Win_Dashboards
    Partial Public Class Dashboard1
        Inherits DevExpress.DashboardCommon.Dashboard
        Public Sub New()
            InitializeComponent()
            Me.Parameters(0).Value = My.Settings.UserName
            Me.Parameters(1).Value = Format(Today, "yyyy")
            Me.Parameters(2).Value = Format(Today, "MM")
        End Sub
    End Class
End Namespace