Public Class ArchiveDocuTypes
    Private Sub ArchiveDocTypesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ArchiveDocuTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocsSort' table. You can move, or remove it, as needed.
        Me.ArchiveDocsSortTableAdapter.Fill(Me.CRMDataSet.ArchiveDocsSort)
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocTypes' table. You can move, or remove it, as needed.
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)

    End Sub

    Private Sub SimpleButtonSave_Click(sender As Object, e As EventArgs) Handles SimpleButtonSave.Click

        Try
            Me.Validate()
            Me.ArchiveDocTypesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class