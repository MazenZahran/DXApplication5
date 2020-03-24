Imports DevExpress.XtraGrid.Views.Grid

Public Class LiteEditTrans
    Private Sub LiteEditTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.DATA' table. You can move, or remove it, as needed.
        Me.DATATableAdapter.Fill(Me.CRMDataSet.DATA)
        'TODO: This line of code loads data into the 'HO_DATADataSet.means' table. You can move, or remove it, as needed.
        Me.MeansTableAdapter.Fill(Me.HO_DATADataSet.means)

        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Validate()
        Me.DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        DATABindingSource.RemoveCurrent()
    End Sub
    Private Sub GridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim MMonth As Integer = CInt(Format(Today, "MM")) - 1
        Dim Yyear As Integer = CInt(Format(Today, "yyyy"))
        Try
            With Me.GridView1
                .SetRowCellValue(e.RowHandle, "TransMonth", MMonth)
                .SetRowCellValue(e.RowHandle, "TransYear", Yyear)
                .SetRowCellValue(e.RowHandle, "TransTime", "00:00:00")
                .SetRowCellValue(e.RowHandle, "TransID", "1")
                .SetRowCellValue(e.RowHandle, "SerNo", "1")
                .SetRowCellValue(e.RowHandle, "DeviceName", "1")
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class