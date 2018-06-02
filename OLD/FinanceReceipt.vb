Public Class FinanceReceipt
    Private Sub ReceiptDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FinanceReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.ChequeData' table. You can move, or remove it, as needed.
        '  Me.ChequeDataTableAdapter.Fill(Me.CRMDataSet.ChequeData)
        'TODO: This line of code loads data into the 'CRMDataSet.ReceiptData' table. You can move, or remove it, as needed.
        Me.ReceiptDataTableAdapter.Fill(Me.CRMDataSet.ReceiptData)

        '  Me.ChequeDataBindingSource.AddNew()
        '  Me.ReceiptDataBindingSource.AddNew()

        Me.ReceiptDataBindingSource.MoveLast()

        Me.KeyPreview = True








    End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If RecCustNoTextEdit.Text = "" Or RecCustNameTextEdit.Text = "" Or RecDateDateEdit.Text = "" Or RecCurrTextEdit.Text = "" Or RecRateSpinEdit.Text = "" _
            Or AmountInNisText.Text = "" Or RecTotalSpinEdit.Text = "" Then
            MsgBox("الرجاء تعبئة كل البيانات المطلوبة")
            Exit Sub
        End If

        If RecNoteTextEdit.Text = "" Then MsgBox("لا تنسى كتابة ملاحظة") : Exit Sub

        If SumChequesLabel.Text <> RecChequeSpinEdit.Text Then
            MsgBox("خطا: مجموع الشيكات لا يتفق مع المبلغ في خانة الشيكات")
            Exit Sub
        End If

        If CInt(RecNOSpinEdit.Text) < 0 Then
            For i As Integer = 0 To Me.ChequeDataDataGridView.Rows.Count - 1
                ChequeDataDataGridView.Rows(i).Cells(6).Value = Me.ReceiptDataTableAdapter.GetMaxRec.ToString
            Next i
        End If

        SaveEdit()

        MsgBox("/// تم \\\")
        Me.ChequeDataBindingSource.AddNew()
        Me.ReceiptDataBindingSource.AddNew()
        ClearRecData()
    End Sub
    Private Sub SaveEdit()
        Me.Validate()
        Me.ChequeDataBindingSource.EndEdit()
        Me.ReceiptDataBindingSource.EndEdit()

        Dim deletedOrders As CRMDataSet.ChequeDataDataTable = CType(
        CRMDataSet.ChequeData.GetChanges(Data.DataRowState.Deleted), CRMDataSet.ChequeDataDataTable)

        Dim newOrders As CRMDataSet.ChequeDataDataTable = CType(
        CRMDataSet.ChequeData.GetChanges(Data.DataRowState.Added), CRMDataSet.ChequeDataDataTable)

        Dim modifiedOrders As CRMDataSet.ChequeDataDataTable = CType(
        CRMDataSet.ChequeData.GetChanges(Data.DataRowState.Modified), CRMDataSet.ChequeDataDataTable)


        Try
            ' Remove all deleted orders from the Orders table.
            If Not deletedOrders Is Nothing Then
                ChequeDataTableAdapter.Update(deletedOrders)
            End If

            ' Update the Customers table.
            ReceiptDataTableAdapter.Update(CRMDataSet.ReceiptData)

            ' Add new orders to the Orders table.
            If Not newOrders Is Nothing Then
                ChequeDataTableAdapter.Update(newOrders)
            End If

            ' Update all modified Orders.
            If Not modifiedOrders Is Nothing Then
                ChequeDataTableAdapter.Update(modifiedOrders)
            End If

            CRMDataSet.AcceptChanges()

        Catch ex As Exception
            MsgBox("خطا: الرجاء اعادة فحص البيانات")

        Finally
            If Not deletedOrders Is Nothing Then
                deletedOrders.Dispose()
            End If

            If Not newOrders Is Nothing Then
                newOrders.Dispose()
            End If

            If Not modifiedOrders Is Nothing Then
                modifiedOrders.Dispose()
            End If
        End Try
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.ReceiptDataBindingSource.CancelEdit()
        ReceiptDataBindingSource.MoveFirst()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Me.Validate()
        'Me.ChequeDataBindingSource.EndEdit()
        'Me.ReceiptDataBindingSource.EndEdit()

        If CInt(RecNOSpinEdit.Text) < 0 Then
            ClearRecData()
            Exit Sub
        End If

        Try
            Me.ChequeDataBindingSource.AddNew()
            Me.ReceiptDataBindingSource.AddNew()
            ClearRecData()
        Catch
            Exit Sub
        End Try

        RecCustNoTextEdit.Select()

    End Sub
    Private Sub ClearRecData()


        RecCustNoTextEdit.Text = ""
        RecCustNameTextEdit.Text = ""
        RecCurrTextEdit.Text = "شيكل"
        RecRateSpinEdit.EditValue = 1
        AmountInNisText.EditValue = 0
        RecCashSpinEdit.EditValue = 0
        RecChequeSpinEdit.EditValue = 0
        RecOtherSpinEdit.EditValue = 0
        RecTotalSpinEdit.EditValue = 0
        RecNoteTextEdit.Text = ""
        RecDateDateEdit.EditValue = Today
        Me.RecDeviceNameTextEdit.Text = My.Settings.DeviceName
        Me.RecUserTextEdit.Text = My.Settings.UserName
        RecAuditSpinEdit.EditValue = 0
        RecInputDateDateEdit.EditValue = Today
        RecStatusSpinEdit.EditValue = 0

        RecCustNoTextEdit.Select()

        SumChequesLabel.Text = "0"

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.ReceiptDataBindingSource.CancelEdit()
        Me.ReceiptDataBindingSource.MoveNext()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Me.ReceiptDataBindingSource.CancelEdit()
        Try
            Me.ReceiptDataBindingSource.EndEdit()
            Me.ReceiptDataBindingSource.MovePrevious()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Me.ReceiptDataBindingSource.CancelEdit()
        Me.ReceiptDataBindingSource.MoveLast()
    End Sub

    Private Sub RecNOSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles RecNOSpinEdit.EditValueChanged

        If RecNOSpinEdit.Text = "" Then Exit Sub
        Try
            Me.ChequeDataTableAdapter.FillBy(Me.CRMDataSet.ChequeData, New System.Nullable(Of Integer)(CType(RecNOSpinEdit.Text, Integer)))
            '  Me.ReceiptDataTableAdapter.FillBy(Me.CRMDataSet.ReceiptData, New System.Nullable(Of Integer)(CType(RecNOSpinEdit.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ChequeDataDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ChequeDataDataGridView.CellEndEdit
        SendKeys.Send("{enter}")
        SendKeys.Send("{up}")
    End Sub


    Private Sub ChequeDataDataGridView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles ChequeDataDataGridView.CellLeave
        'SendKeys.Send("{enter}")
        'SendKeys.Send("{up}")
    End Sub

    Private Sub ChequeDataDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ChequeDataDataGridView.CellContentClick

    End Sub

    Private Sub FinanceReceipt_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '  ClearRecData()
    End Sub

    Private Sub ChequeDataDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ChequeDataDataGridView.CellValueChanged
        On Error Resume Next
        'Dim Stotal As Integer = 0
        'For i As Integer = 0 To Me.ChequeDataDataGridView.Rows.Count - 1
        '    '     If ChequeDataDataGridView.Rows(i).Cells(5).Value IsNot DBNull Then
        '    ChequeDataDataGridView.Rows(i).Cells(5).Value = ChequeDataDataGridView.Rows(i).Cells(5).Value + Stotal
        '    '  End If
        'Next i
        'RecChequeSpinEdit.Text = Stotal

        Dim total As Integer = 0
        For i As Integer = 0 To ChequeDataDataGridView.RowCount - 1
#Disable Warning BC42016 ' Implicit conversion
#Disable Warning BC42019 ' Operands of type Object used for operator
            total = ChequeDataDataGridView.Rows(i).Cells(5).Value + total
#Enable Warning BC42019 ' Operands of type Object used for operator
#Enable Warning BC42016 ' Implicit conversion
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        SumChequesLabel.Text = total.ToString

    End Sub

    Private Sub ChequeDataDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ChequeDataDataGridView.RowsAdded
        On Error Resume Next
        'Dim Stotal As Integer = 0
        'For i As Integer = 0 To Me.ChequeDataDataGridView.Rows.Count - 1
        '    '     If ChequeDataDataGridView.Rows(i).Cells(5).Value IsNot DBNull Then
        '    ChequeDataDataGridView.Rows(i).Cells(5).Value = ChequeDataDataGridView.Rows(i).Cells(5).Value + Stotal
        '    '  End If
        'Next i
        'RecChequeSpinEdit.Text = Stotal

        Dim total As Integer = 0
        For i As Integer = 0 To ChequeDataDataGridView.RowCount - 1
#Disable Warning BC42016 ' Implicit conversion
#Disable Warning BC42019 ' Operands of type Object used for operator
            total = ChequeDataDataGridView.Rows(i).Cells(5).Value + total
#Enable Warning BC42019 ' Operands of type Object used for operator
#Enable Warning BC42016 ' Implicit conversion
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        SumChequesLabel.Text = total.ToString
        CountChequesLabel.Text = CType(CInt(ChequeDataDataGridView.Rows.Count.ToString) - 1, String)
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) 


    End Sub
End Class