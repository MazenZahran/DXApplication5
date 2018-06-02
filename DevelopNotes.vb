Public Class DevelopNotes


    Private Sub DevelopNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.DevelopNotes' table. You can move, or remove it, as needed.
        Me.DevelopNotesTableAdapter.Fill(Me.CRMDataSet.DevelopNotes)

    End Sub

    Private Sub DevelopNotesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        'If CInt(RecNOSpinEdit.Text) < 0 Then
        '    For i As Integer = 0 To Me.ChequeDataDataGridView.Rows.Count - 1
        '        ChequeDataDataGridView.Rows(i).Cells(6).Value = Me.ReceiptDataTableAdapter.GetMaxRec.ToString
        '    Next i
        'End If

        Me.Validate()
        Me.DevelopNotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
    End Sub


End Class