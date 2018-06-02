Public Class CarsEdit
    Private Sub CarsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub CarsEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.CRMDataSet.cars)

    End Sub
End Class