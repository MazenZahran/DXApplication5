Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Public Class FinancialBulkReceipt

    Sub New()

        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub FinancialBulkReceipt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            SavingRec()
        End If

        Try
            If e.KeyCode = Keys.Insert Then
                AddingNew()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReceiptDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        '    Me.Validate()
        '    Me.ReceiptDataBindingSource.EndEdit()
        '  Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub FinancialBulkReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts' table. You can move, or remove it, as needed.
        '  Me.AccountsTableAdapter.Fill(Me.WizCountDataSet.Accounts)
        'TODO: This line of code loads data into the 'WizCountDataSet.CRMContact' table. You can move, or remove it, as needed.
        '   Me.CRMContactTableAdapter.Fill(Me.WizCountDataSet.CRMContact)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts' table. You can move, or remove it, as needed.
        '   Me.AccountsTableAdapter.Fill(Me.WizCountDataSet.Accounts)
        '   'TODO: This line of code loads data into the 'WizCountDataSet.CRMContact' table. You can move, or remove it, as needed.
        '       Me.CRMContactTableAdapter.Fill(Me.WizCountDataSet.CRMContact)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts' table. You can move, or remove it, as needed.
        '    Me.AccountsTableAdapter.Fill(Me.WizCountDataSet.Accounts)
        'TODO: This line of code loads data into the 'CRMDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.CRMDataSet.Users)
        'TODO: This line of code loads data into the 'CRMDataSet.ReceiptData' table. You can move, or remove it, as needed.
        '   Me.ReceiptDataTableAdapter.Fill(Me.CRMDataSet.ReceiptData)
        Me.ReceiptDataTableAdapter.FillBy(Me.CRMDataSet.ReceiptData, -1)
        '    Me.ReceiptDataTableAdapter.FillBy(
        'TODO: This line of code loads data into the 'CRMDataSet.ReceiptData' table. You can move, or remove it, as needed.
        '   Me.ReceiptDataTableAdapter.Fill(Me.CRMDataSet.ReceiptData)
        '   ToolStripTextBox1.Text = My.Settings.UserName
    End Sub

    Private Sub ReceiptDataBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ReceiptDataBindingNavigatorSaveItem.Click

        SavingRec()

    End Sub

    Private Sub SavingRec()
        Try
            If ToolStripTextBox1.Text = "" Then MsgBox("الرجاء اختيار الموظف") : Exit Sub
            Me.Validate()
            Me.ReceiptDataBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
            Me.ReceiptDataTableAdapter.FillBy(Me.CRMDataSet.ReceiptData, -1)
            DevExpress.XtraEditors.XtraMessageBox.Show("تم حفظ سند القبض")
        Catch ex As Exception
            MsgBox("لم يتم حفظ السند")
        End Try
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow

        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecInputDate"), Now)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecStatus"), 1)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecAudit"), 0)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecDeviceName"), My.Settings.DeviceName)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecUser"), ToolStripTextBox1.Text)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecOwner"), ToolStripTextBox1.Text)
        '   GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecNote"), "دفعة من سند قبض مركب")

    End Sub

    Private Sub GridView1_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView1.ShowingEditor
        Try

            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecDate") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecDate"), Today)
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCurr") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecCurr"), "شيكل")
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecRate") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecRate"), 1)
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCash") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecCash"), 0)
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecOther") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecOther"), 0)
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCheque") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecCheque"), 0)
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecNote") Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecNote"), "دفعة من سند قبض مركب")
            End If

            GetTaskID()

            Dim cash As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCash").ToString)
            Dim cheque As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCheque").ToString)
            Dim other As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecOther").ToString)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecTotal"), cash + cheque + other)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub LookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit2.EditValueChanged
        Dim row2 As Object = LookUpEdit2.Properties.GetDataSourceRowByKeyValue(LookUpEdit2.EditValue)
        Dim aa As String = TryCast(row2, DataRowView)("userid").ToString()
        ToolStripTextBox1.Text = aa
    End Sub

    Private Sub ReceiptDataGridControl_Click(sender As Object, e As EventArgs) Handles ReceiptDataGridControl.Click

    End Sub

    'Private Sub RepositoryItemSearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSearchLookUpEdit1.EditValueChanged
    '    'With RepositoryItemSearchLookUpEdit1View
    '    '    Dim rowValLookup As System.Data.DataRow
    '    '    rowValLookup = .GetDataRow(.FocusedRowHandle)
    '    '    MsgBox(rowValLookup(1))
    '    'End With

    '    'Dim view As GridView = RepositoryItemSearchLookUpEdit1View
    '    'Dim rowHandle As Integer = view.FocusedRowHandle
    '    'Dim fieldName As String = "FullName"
    '    'Dim value As Object = view.GetRowCellValue(rowHandle, fieldName)
    '    'MsgBox(value)

    'End Sub

    Private Sub repositoryItemSearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSearchLookUpEdit1.EditValueChanged
        Dim edit As DevExpress.XtraEditors.SearchLookUpEdit = TryCast(sender, DevExpress.XtraEditors.SearchLookUpEdit)
        Dim rowHandle As Integer = edit.Properties.GetIndexByKeyValue(edit.EditValue)
        Dim row As Object = edit.Properties.View.GetRow(rowHandle)
        Dim valu As String = TryCast(row, DataRowView).Row("FullName").ToString()
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecCustName"), valu)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub AddingNew()

        Try
            ReceiptDataBindingSource.AddNew()
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        AddingNew()
    End Sub

    Private Sub GridView1_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecInputDate"), Now)
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecStatus"), 1)
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecAudit"), 0)
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecDeviceName"), My.Settings.DeviceName)
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecUser"), ToolStripTextBox1.Text)
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecOwner"), ToolStripTextBox1.Text)
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("RecNote"), "دفعة من سند قبض مركب")

    End Sub

    Private Sub gridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        If GridView1.IsNewItemRow(e.RowHandle) Then
            '''''''
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCustNo") Is DBNull.Value Then
        'Dim j As Integer

        'Dim i As Integer
        'Dim sql As New SQLControl
        ''   Try
        'For j = 0 To GridView1.RowCount - 1
        '    Dim custid As String = (GridView1.GetRowCellValue(j, "RecCustNo").ToString)
        '    Dim SqlString As String = "Select top 1 TaskID from CRMTasks where CustID = " & custid & "  and NoteStatus = 'مفتوحة' "
        '    sql.CRMRunQuery(SqlString)
        '    MsgBox(CType(sql.SQLDS.Tables(0).Rows(i).Item("TaskID"), String))
        '    MsgBox(custid)
        '    sql.SqlConCRM.Close()
        'Next j
        '    Catch ex As Exception
        '       MsgBox("خطا مهمة غير موجودة")
        '    End Try

        ' End If

        'Dim i As Integer
        'Dim sql As New SQLControl
        'Try

        '    Dim custid As String = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCustNo").ToString)
        '    Dim SqlString As String = "Select top 1 TaskID from CRMTasks where CustID = " & custid & "  and NoteStatus = 'مفتوحة' "
        '    sql.CRMRunQuery(SqlString)
        '    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("TaskID"), (CType(sql.SQLDS.Tables(0).Rows(i).Item("TaskID"), String)))

        '    '      sql.SqlConCRM.Close()
        'Catch ex As Exception
        '    MsgBox("خطا مهمة غير موجودة")
        'End Try

    End Sub

    Private Sub GetTaskID()
        '    Dim i As Integer
        '    Dim sql As New SQLControl
        '    Try

        '        Dim custid As String = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecCustNo").ToString)
        '        If custid = "" Then Exit Sub
        '        Dim SqlString As String = "Select top 1 TaskID from CRMTasks where CustID = " & custid & "  and NoteStatus = 'مفتوحة' "
        '        sql.CRMRunQuery(SqlString)

        '        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns("ColTaskID"), (CType(sql.SQLDS.Tables(0).Rows(i).Item("TaskID"), String)))

        '        '      sql.SqlConCRM.Close()
        '    Catch ex As Exception
        '        '   Exit Sub
        '    End Try
    End Sub

End Class