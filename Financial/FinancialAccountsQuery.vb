Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FinancialAccountsSTOPS
    Dim sql As New SQLControl
    Dim i As Integer

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            Dim SQLString As String = "Select AccountKey,FullName,Sphone,Email,'' as FleetStatus  from [ALHUDA].[dbo].[Accounts]
                                    Where [SortGroup]= " & TextSort.Text
            sql.WizCountRunQuery(SQLString)
            Me.GridControl1.DataSource = sql.SQLDS.Tables(0)

            Dim i As Integer
            For i = 0 To Me.GridView1.RowCount - 1
                Dim AccountKey As String = CType(GridView1.GetRowCellValue(i, "AccountKey"), String)
                Dim St As String = GetFleetStatus(AccountKey)
                GridView1.SetRowCellValue(i, GridView1.Columns("FleetStatus"), St)
            Next

            GridView1.Columns("FleetStatus").SortIndex = 1
        Catch ex As Exception

        End Try

    End Sub

    Private Function GetFleetStatus(FleetID As String) As String
        Dim SqlOrbak As String = "Select Status from fleets where code='" & FleetID & "'"
        Dim FleetStatus As String
        sql.RunQuery(SqlOrbak)
        FleetStatus = CType(sql.SQLDS.Tables(0).Rows(i).Item("Status"), String)
        GetFleetStatus = FleetStatus
    End Function

    Private Sub GridView1_CustomDrawCell(ByVal sender As Object,
  ByVal e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        Dim ImageTrue As Image = My.Resources.TrueIcon
        Dim ImageFalse As Image = My.Resources.FalseIcon
        'Dim ImageDelete As Image = Image.FromFile(Application.StartupPath + "\..\..\" + "Delete.jpg")
        Dim View As GridView = CType(sender, GridView)
        If e.Column.FieldName <> "FleetStatus" Then
            Return
        End If
        Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("FleetStatus"))
        If category = "1" Then
            e.Graphics.DrawImage(ImageFalse, e.Bounds.Location)
            e.DisplayText = "موقوف"
        End If
        If category = "2" Then
            e.Graphics.DrawImage(ImageTrue, e.Bounds.Location)
            e.DisplayText = "فعال"
        End If
        If category = "0" Then
            '  e.Graphics.DrawImage(ImageDelete, e.Bounds.Location)
            e.DisplayText = "محذوف"
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub

End Class