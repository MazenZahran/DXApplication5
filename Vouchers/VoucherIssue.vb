Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class VoucherIssue
    Private Sub VoucherIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        ComboCurrency.Text = CStr("NIS")
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)
        CreateTable()

    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object,
      ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            If (MessageBox.Show("Delete row?", "Confirmation",
              MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = CType(sender, GridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If IssueVoucherAuthentication() = False Then
            MsgBox("البرنامج تحت الصيانة ، اصبر اشوي يا  " & CStr(GlobalVariables.UserNameString))
            Exit Sub
        End If

        If String.IsNullOrEmpty(ComboCurrency.Text) Then
            MsgBox("يجب اختيار العملة")
            Exit Sub
        End If
        If CInt(GetTotalVoucherForMnthByCustomer(CInt(Format(VoucherDate.DateTime, "MM")), CInt(Format(VoucherDate.DateTime, "yyyy")), CStr(Me.CustomeID.EditValue))) > 0 Then
            If XtraMessageBox.Show(" انتيه يا  " & GlobalVariables.UserNameString & " يوجد فاتورة مصدرة لهذا الحساب   هل تريد المتابعة؟ ", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Exit Sub
            End If
        End If
        If GridView1.RowCount < 0 Then
            MsgBox("جريد فارغة")
            Exit Sub
        End If
        Dim _VoucherCode As String
        Dim _CustomeID As String
        Dim _Sort As String
        Dim _Area As String
        Dim _Address As String
        If String.IsNullOrEmpty(CustomeID.Text) Then
            _CustomeID = "9999"
            _Sort = "9999"
            _Area = ""
            _Address = TextAddress.Text
        Else
            _CustomeID = CustomeID.Text
            _Sort = GetAccData(_CustomeID).SortGroup
            _Area = GetAccData(_CustomeID).costcode
            _Address = TextAddress.Text
        End If

        _VoucherCode = GetRandomString()
        Dim _VoucherDate As String = Format(VoucherDate.DateTime, "yyyy-MM-dd")
        LabelControl2.Text = IssueVoucherFromOut(_VoucherDate, _CustomeID, Me.CustomeName.Text, _Sort, _Area, _Address,
                            CDec(ColAmount.SummaryItem.SummaryValue.ToString),
                            _VoucherCode, MemoEdit1.Text, CInt(Format(VoucherDate.DateTime, "MM")),
                            CInt(Format(VoucherDate.DateTime, "yyyy")), "Out", ComboCurrency.Text, CType(GridControl1.DataSource, DataTable))

        '  GridControl1.DataSource = Nothing
    End Sub
    Private Sub CreateTable()
        Try
            Dim dt As DataTable = New DataTable("Mydata")

            dt.Columns.Add("VoucherCode", GetType(String))
            dt.Columns.Add("VouchNo", GetType(String))
            dt.Columns.Add("SotckName", GetType(String))
            dt.Columns.Add("Quantity", GetType(String))
            dt.Columns.Add("Price", GetType(String))
            dt.Columns.Add("Amount", GetType(String))
            dt.Columns.Add("TransID", GetType(String))
            dt.Columns.Add("StockID", GetType(String))
            GridControl1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        Dim gw As GridView = TryCast(sender, GridView)
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        Try
            Dim StockID As String = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "StockID"))


            If e.Column.FieldName = "Quantity" Or e.Column.FieldName = "Price" Then
                Try
                    Dim Quant As Decimal = CDec(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Quantity"))
                    Dim Pric As Decimal = CDec(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Price"))
                    Dim Amont As Decimal = CDec((Quant * Pric).ToString("N2"))
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, ColAmount, Amont)
                Catch ex As Exception
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, ColAmount, "0")
                    ' MsgBox(ex.ToString)
                End Try

            End If
            If e.Column.FieldName = "StockID" Then

                Try
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, ColStock, GetItemName(StockID))
                Catch ex As Exception

                End Try

                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, ColPrice, GetPrice(StockID, Format(VoucherDate.DateTime, "yyyy-MM-dd")))

            End If
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try


    End Sub

    Private Function GetItemName(ItemID As String) As String
        Try
            Dim SqlString As String
            Dim ItName As String
            Dim SQl As New SQLControl
            SqlString = " Select ItemName from [ALHUDA].[dbo].[Items] where  ItemKey = '" & ItemID & "'"
            SQl.WizCountRunQuery(SqlString)
            ItName = SQl.SQLDS.Tables(0).Rows(0).Item("ItemName").ToString
            Return ItName
        Catch ex As Exception
            '    MsgBox(ex.ToString)1031342
            Return ""
        End Try

    End Function

    Private Sub View_ValidateRow(ByVal sender As Object, ByVal e As ValidateRowEventArgs) Handles GridView1.ValidateRow

        Try

            Dim view As ColumnView = TryCast(sender, ColumnView)

            Dim _ColQuantity As GridColumn = view.Columns("Quantity")
            If IsDBNull(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Quantity")) = True Then
                e.Valid = False
                e.ErrorText = "Error!!!"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _ColQuantity
                view.ShowEditor()
            End If

            Dim _ColPrice As GridColumn = view.Columns("ColPrice")
            If IsDBNull(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Price")) = True Then
                e.Valid = False
                e.ErrorText = "Error!!!"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _ColPrice
                view.ShowEditor()
            End If

            Dim _ColAmount As GridColumn = view.Columns("ColAmount")
            If IsDBNull(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Amount")) = True Then
                e.Valid = False
                e.ErrorText = "Error!!!"
                view.FocusedRowHandle = e.RowHandle
                view.FocusedColumn = _ColAmount
                view.ShowEditor()
            End If

            GridView1.BestFitColumns()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)
        Dim val As Object = e.Value

        If view.FocusedColumn.FieldName = "Quantity" Then
            If val Is Nothing OrElse String.IsNullOrWhiteSpace(e.Value.ToString()) Then
                e.Valid = False
                e.ErrorText = "Enter a vaid Quantity"
            End If
        End If

        If view.FocusedColumn.FieldName = "Price" Then
            If val Is Nothing OrElse String.IsNullOrWhiteSpace(e.Value.ToString()) Then
                e.Valid = False
                e.ErrorText = "Enter ItemPrice"
            End If
        End If

        If view.FocusedColumn.FieldName = "Amount" Then
            If val Is Nothing OrElse String.IsNullOrWhiteSpace(e.Value.ToString()) Then
                e.Valid = False
                e.ErrorText = "Enter Amount"
            End If
        End If

        If view.FocusedColumn.FieldName = "StockID" Then
            If val Is Nothing OrElse String.IsNullOrWhiteSpace(e.Value.ToString()) Then
                e.Valid = False
                MsgBox("empty")
            End If
        End If
    End Sub


    Private Function GetPrice(StockID As String, _Date As String) As Decimal
        Dim Sql As New SQLControl
        Dim _ItemPrice As Decimal = 0
        Dim SqlString As String = " SELECT       [PRICE]
                                    FROM [WALLET].[dbo].[PRICELIST]
                                    where ('" & _Date & "' between DATEFROM and DATETO) and ITEMKEY='" & StockID & "' "
        Sql.WalletRunQuery(SqlString)
        _ItemPrice = CDec(Sql.SQLDS.Tables(0).Rows(0).Item("PRICE"))
        Return _ItemPrice
    End Function

    Private Sub CustomeID_EditValueChanged(sender As Object, e As EventArgs) Handles CustomeID.EditValueChanged
        CustomeName.Text = GetAccData(CustomeID.Text).FullNamee
        CheckLastVouchers()
    End Sub

    Private Sub CheckLastVouchers()
        LabelControl1.Text = " فواتير سابقة بنفس الشهر " & CStr(GetTotalVoucherForMnthByCustomer(CInt(Format(VoucherDate.DateTime, "MM")), CInt(Format(VoucherDate.DateTime, "yyyy")), CStr(Me.CustomeID.EditValue)))
    End Sub

    Private Sub VoucherDate_EditValueChanged(sender As Object, e As EventArgs) Handles VoucherDate.EditValueChanged
        CheckLastVouchers()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class