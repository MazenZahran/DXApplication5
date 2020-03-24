Public Class OrpakLogReads
    Private Sub LOG_READSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub OrpakLogReads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WALLETDataSet.LOG_MARKET_READS' table. You can move, or remove it, as needed.
        Me.LOG_MARKET_READSTableAdapter.Fill(Me.WALLETDataSet.LOG_MARKET_READS)
        'TODO: This line of code loads data into the 'WALLETDataSet.LOG_READS' table. You can move, or remove it, as needed.
        Me.LOG_READSTableAdapter.Fill(Me.WALLETDataSet.LOG_READS)

    End Sub

    Private Sub SimpleSave_Click(sender As Object, e As EventArgs) Handles SimpleSave.Click
        Me.Validate()
        Me.LOG_READSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WALLETDataSet)
    End Sub

    Private Sub SimpleDelete_Click(sender As Object, e As EventArgs) Handles SimpleDelete.Click
        Me.LOG_READSBindingSource.RemoveCurrent()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Validate()
        Me.LOG_MARKET_READSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WALLETDataSet)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.LOG_MARKET_READSBindingSource.RemoveCurrent()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.LOG_MARKET_READSTableAdapter.Fill(Me.WALLETDataSet.LOG_MARKET_READS)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.LOG_READSTableAdapter.Fill(Me.WALLETDataSet.LOG_READS)
    End Sub
End Class