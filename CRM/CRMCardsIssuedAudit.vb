Public Class CRMCardsIssuedAudit
    Private Sub CardsTransBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CRMCardsIssuedAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CardsTrans' table. You can move, or remove it, as needed.

        '  Me.CardsTransTableAdapter.Fill(Me.CRMDataSet.CardsTrans)
        DateEdit1.DateTime = Today.AddDays(-365)
        DateEdit2.DateTime = Today.AddDays(-1)
    End Sub
    Private Sub FilterByDate()
        Try
            GridView1.ActiveFilter.Clear()
            Dim TransDate1 As String = CStr(DateEdit1.DateTime)
            Dim TransDate2 As String = CStr(DateEdit2.DateTime)
            Me.CardsTransTableAdapter.FillByDate(Me.CRMDataSet.CardsTrans, CDate(TransDate1), CDate(TransDate2))
            GridView1.ActiveFilterString = "[TransAudit] Is null"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged

        FilterByDate()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Validate()
        Me.CardsTransBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            Me.CardsTransTableAdapter.FillByStatus(Me.CRMDataSet.CardsTrans)
        End If
    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit2.EditValueChanged
        FilterByDate()
    End Sub
End Class