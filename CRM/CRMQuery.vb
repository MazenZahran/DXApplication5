Public Class CRMQuery
    Private Sub CRMTasksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CRMTasksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CRMTasksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub CRMQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CRMTasks' table. You can move, or remove it, as needed.
        Me.CRMTasksTableAdapter.Fill(Me.CRMDataSet.CRMTasks)

    End Sub
End Class