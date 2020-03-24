Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class CarsOtherLists
    Private Sub CarsInsurancCompaniesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CarsOtherLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CarsSort' table. You can move, or remove it, as needed.
        Me.CarsSortTableAdapter.Fill(Me.CRMDataSet.CarsSort)
        'TODO: This line of code loads data into the 'CRMDataSet.CarsModel' table. You can move, or remove it, as needed.
        Me.CarsModelTableAdapter.Fill(Me.CRMDataSet.CarsModel)
        'TODO: This line of code loads data into the 'CRMDataSet.CarsMarka' table. You can move, or remove it, as needed.
        Me.CarsMarkaTableAdapter.Fill(Me.CRMDataSet.CarsMarka)
        'TODO: This line of code loads data into the 'CRMDataSet.CarsInsurancCompanies' table. You can move, or remove it, as needed.
        Me.CarsInsurancCompaniesTableAdapter.Fill(Me.CRMDataSet.CarsInsurancCompanies)
        Me.KeyPreview = True
    End Sub

    Private Sub CarsInsurancCompaniesGridControl_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles CarsInsurancCompaniesGridControl.ProcessGridKey
        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            e.Handled = False
            Dim result As DialogResult = XtraMessageBox.Show("هل انت متأكد من حذف السطر؟", "تنبيه", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                view.DeleteSelectedRows()
                XtraMessageBox.Show("تم الحذف")
                e.Handled = True
            Else
                XtraMessageBox.Show("لم يتم الحذف")
            End If
        End If
    End Sub


    Private Sub CarsModelGridControl_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles CarsModelGridControl.ProcessGridKey
        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            e.Handled = False
            Dim result As DialogResult = XtraMessageBox.Show("هل انت متأكد من حذف السطر؟", "تنبيه", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                view.DeleteSelectedRows()
                XtraMessageBox.Show("تم الحذف")
                e.Handled = True
            Else
                XtraMessageBox.Show("لم يتم الحذف")
            End If
        End If
    End Sub



    Private Sub CarsMarkaGridControl_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles CarsMarkaGridControl.ProcessGridKey
        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            e.Handled = False
            Dim result As DialogResult = XtraMessageBox.Show("هل انت متأكد من حذف السطر؟", "تنبيه", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                view.DeleteSelectedRows()
                XtraMessageBox.Show("تم الحذف")
                e.Handled = True
            Else
                XtraMessageBox.Show("لم يتم الحذف")
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Saving()
    End Sub
    Private Sub Saving()
        Me.Validate()
        Me.CarsInsurancCompaniesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
    End Sub

    Private Sub CarsOtherLists_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.F3 Then
            Saving()
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True 'this will prevent ding sound 
    End Sub

    Private Sub CarsInsurancCompaniesGridControl_Click(sender As Object, e As EventArgs) Handles CarsInsurancCompaniesGridControl.Click

    End Sub

    Private Sub CarsMarkaGridControl_Click(sender As Object, e As EventArgs) Handles CarsMarkaGridControl.Click

    End Sub
End Class