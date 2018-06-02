Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base

Public Class FinancialChequesBack
    Sub New()

        InitializeComponent()
        Me.KeyPreview = True
    End Sub
    Private Sub FinancialChequesBack_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Saving()
        End If

        Try
            If e.KeyCode = Keys.Insert Then
                AddingNew()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FinancialChequesBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Cheqs' table. You can move, or remove it, as needed.
        '   Me.CheqsTableAdapter.Fill(Me.WizCountDataSet.Cheqs)
        'TODO: This line of code loads data into the 'WizCountDataSet.Cheqs1' table. You can move, or remove it, as needed.
        Me.Cheqs1TableAdapter.Fill(Me.WizCountDataSet.Cheqs1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Cheqs' table. You can move, or remove it, as needed.
        '   Me.CheqsTableAdapter.Fill(Me.WizCountDataSet.Cheqs)
        'TODO: This line of code loads data into the 'CRMDataSet.FinancialChequesBack' table. You can move, or remove it, as needed.
        '  If Me.NavigationPane1.SelectedPageIndex = 1 Then Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)
        Me.FinancialChequesBackTableAdapter.FillByID(Me.CRMDataSet.FinancialChequesBack, -1)
        'TODO: This line of code loads data into the 'CRMDataSet.FinancialChequesBack' table. You can move, or remove it, as needed.

        '     Me.FinancialChequesBackTableAdapter.FillByID(Me.CRMDataSet.FinancialChequesBack, -1)
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs)




    End Sub
    Private Sub BandedGridView1_ShowingEditor(sender As Object, e As CancelEventArgs) Handles BandedGridView1.ShowingEditor

        'If Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "Currency") Is DBNull.Value Then
        '    BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("Currency"), "شيكل")
        'End If

        If BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "InputDate") Is DBNull.Value Then
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("InputDate"), Today)
        End If

        If BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "ChequeStatus") Is DBNull.Value Then
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("ChequeStatus"), "راجع")
        End If

        If BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "BankName") Is DBNull.Value Then
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("BankName"), ComboBoxEdit1.SelectedItem)
        End If

    End Sub


    Private Sub Saving()
        Try
            If ComboBoxEdit1.Text = "" Then MsgBox("يجب اختيار البنك ") : Exit Sub
            Me.Validate()
            Me.FinancialChequesBackBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
            Me.FinancialChequesBackTableAdapter.FillByID(Me.CRMDataSet.FinancialChequesBack, -1)
            DevExpress.XtraEditors.XtraMessageBox.Show("تم حفظ سند القبض")
        Catch ex As Exception
            MsgBox("لا يكن حفظ السند")
        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Saving()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        AddingNew()
    End Sub
    Private Sub AddingNew()

        Try
            FinancialChequesBackBindingSource.AddNew()
        Catch ex As Exception
            MsgBox("لا يكن اضافة جديد")
        End Try


    End Sub



    Private Sub repositoryItemSearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSearchLookUpEdit1.EditValueChanged
        Dim edit As DevExpress.XtraEditors.SearchLookUpEdit = TryCast(sender, DevExpress.XtraEditors.SearchLookUpEdit)
        Dim rowHandle As Integer = edit.Properties.GetIndexByKeyValue(edit.EditValue)
        Dim row As Object = edit.Properties.View.GetRow(rowHandle)

        Dim valu As String = TryCast(row, DataRowView).Row("ValueDate").ToString()
        BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("ChequeDate"), valu)

        Dim valu2 As String = TryCast(row, DataRowView).Row("SuFDlr").ToString()
        BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("AmountNIS"), valu2)

        Dim valu3 As String = TryCast(row, DataRowView).Row("SuF").ToString()
        BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("Amount"), valu3)

        Dim valu4 As String = TryCast(row, DataRowView).Row("AccName").ToString()
        BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("AccountName"), valu4)

        Dim valu5 As String = TryCast(row, DataRowView).Row("AccKey").ToString()
        BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("AccID"), valu5)

        Dim valu6 As String = TryCast(row, DataRowView).Row("Currency").ToString()
        BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("Currency"), valu6)

        If TryCast(row, DataRowView).Row("Currency").ToString() = "NIS" Then
            Dim valu7 As String = TryCast(row, DataRowView).Row("SuF").ToString()
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, BandedGridView1.Columns("AmountNIS"), valu7)
        End If


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.FinancialChequesBackBindingSource.RemoveCurrent()
    End Sub

    Private Sub NavigationPane1_Click(sender As Object, e As EventArgs) Handles NavigationPane1.Click
        If Me.NavigationPane1.SelectedPageIndex = 2 Then Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)
        If Me.NavigationPane1.SelectedPageIndex = 1 Then Me.FinancialChequesBackTableAdapter.FillByID(Me.CRMDataSet.FinancialChequesBack, -1)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        '     Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)
        If ComboChekStatus.Text <> "الكل" Then Me.FinancialChequesBackTableAdapter.FillByStatus(Me.CRMDataSet.FinancialChequesBack, "راجع")
        '   If ComboChekStatus.Text = "الكل" Then Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)

        '   Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack, "محصل")
    End Sub

    Private Sub ComboChekStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboChekStatus.SelectedIndexChanged
        If ComboChekStatus.Text <> "الكل" Then Me.FinancialChequesBackTableAdapter.FillByStatus(Me.CRMDataSet.FinancialChequesBack, ComboChekStatus.Text)
        If ComboChekStatus.Text = "الكل" Then Me.FinancialChequesBackTableAdapter.Fill(Me.CRMDataSet.FinancialChequesBack)

    End Sub


End Class