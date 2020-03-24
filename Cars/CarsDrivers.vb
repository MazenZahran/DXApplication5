Public Class CarsDrivers
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub CarsDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CarsDrivers' table. You can move, or remove it, as needed.
        Me.CarsDriversTableAdapter.Fill(Me.CRMDataSet.CarsDrivers)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.CarsDriversBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
    End Sub
End Class