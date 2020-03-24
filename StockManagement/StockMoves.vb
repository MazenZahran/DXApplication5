Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI

Public Class StockMoves
    Dim ShowPrintPreview As Boolean = False
    Dim ItemBalance As Decimal = 0
    Private Sub StockMoveBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StockMoveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        Dim gw As GridView = TryCast(sender, GridView)
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub StockMoves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocSort11' table. You can move, or remove it, as needed.
        Me.StockMoveDocSort11TableAdapter.Fill(Me.CRMDataSet.StockMoveDocSort11)
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocSort1' table. You can move, or remove it, as needed.
        '  Me.StockMoveDocSort1TableAdapter.Fill(Me.CRMDataSet.StockMoveDocSort1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        Me.KeyPreview = True
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)
        FillAccounts()
        FillWhareHouses()
        Me.DocID.Select()
        ' OptionsFocus.EnterMoveNextControl = False
        LayoutControlItemDocType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub DocID_EditValueChanged(sender As Object, e As EventArgs) Handles DocID.EditValueChanged
        Try
            Me.StockMoveTableAdapter.FillDocID(Me.CRMDataSet.StockMove, New System.Nullable(Of Integer)(CType(DocID.Text, Integer)), (CType(DocType.Text, String)), (CType(DocSortTextEdit.EditValue, String)))
            If DocNewOld.Text = "Old" Then FillControls()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillControls()
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT Top(1)  DocID, DocDate, DocType, DocStatus, DocCurrency,DebitAcc,CredAcc,
                                 DebitWhereHouse,CreditWhereHouse, Notes, Referance,InputUser, InputDateTime,AccountAddress,AccountMobile,Driver,DocSort,DocManualNo,CarNo,SalesPerson
                           FROM   StockMove
                           Where DocID =" & DocID.Text & " And DocType ='" & CStr(DocType.EditValue) & "'" & " And DocSort ='" & CStr(DocSortTextEdit.EditValue) & "'"


            sql.CRMRunQuery(SqlString)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocDate").ToString) Then DocDate.Text = Format(CDate(sql.SQLDS.Tables(0).Rows(0).Item("DocDate").ToString), "yyyy/MM/dd")
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocType").ToString) Then DocType.Text = sql.SQLDS.Tables(0).Rows(0).Item("DocType").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocStatus").ToString) Then DocStatus.Text = sql.SQLDS.Tables(0).Rows(0).Item("DocStatus").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocCurrency").ToString) Then DocCurrency.Text = sql.SQLDS.Tables(0).Rows(0).Item("DocCurrency").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DebitAcc").ToString) Then DebitAcc.EditValue = CStr(sql.SQLDS.Tables(0).Rows(0).Item("DebitAcc").ToString)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("CredAcc").ToString) Then CredAcc.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("CredAcc").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DebitWhereHouse").ToString) Then SearchToWarehouse.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("DebitWhereHouse").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("CreditWhereHouse").ToString) Then SearchFromWarehouse.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("CreditWhereHouse").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Notes").ToString) Then Notes.Text = sql.SQLDS.Tables(0).Rows(0).Item("Notes").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Referance").ToString) Then Referance.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("Referance").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("InputUser").ToString) Then InputUser.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("InputUser").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("InputDateTime").ToString) Then InputDateTime.Text = Format(CDate(sql.SQLDS.Tables(0).Rows(0).Item("InputDateTime").ToString), "dd/MM/yyyy HH:mm")
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AccountAddress").ToString) Then TextAccAddress.Text = sql.SQLDS.Tables(0).Rows(0).Item("AccountAddress").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("AccountMobile").ToString) Then TextAccMobile.Text = sql.SQLDS.Tables(0).Rows(0).Item("AccountMobile").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Driver").ToString) Then DriverTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("Driver").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocSort").ToString) Then DocSortTextEdit.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("DocSort").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("DocManualNo").ToString) Then DocManualNoTextEdit.Text = sql.SQLDS.Tables(0).Rows(0).Item("DocManualNo").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("CarNo").ToString) Then CarNoText.Text = sql.SQLDS.Tables(0).Rows(0).Item("CarNo").ToString
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("SalesPerson").ToString) Then SearchSalesPerson.EditValue = sql.SQLDS.Tables(0).Rows(0).Item("SalesPerson").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Saving()
    End Sub
    Private Sub Saving()

        If Me.DocType.Text = "PurchaseDelivery" And DocManualNoTextEdit.Text = "" Then
            MsgBox("يجب تعبئة رقم السند اليدوي في فاتورة المشتريات")
            Exit Sub
        End If

        FillColumns()
        Me.Validate()
        Me.StockMoveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
        If DocNewOld.Text = "New" Then
            Dim result As DialogResult = XtraMessageBox.Show("هل تريد طباعة السند", "تنبيه", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                PrintDoc(True)
                PrintDoc(False)
            End If
            DocNewOld.Text = "Old"
        End If
        DocNewOld.Text = "New"
        DocDate.Select()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StockMoveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
    End Sub
    Private Sub FillWhareHouses()

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select NameID,Name 
                          From [ALHUDA].[dbo].[AgentWarehouseNames] 
                          Where Sort=2 and NameID between 1 and 999 order by NameID "
            Sql.WizCountRunQuery(SqlString)
            SearchFromWarehouse.Properties.DataSource = Sql.SQLDS.Tables(0)
            SearchToWarehouse.Properties.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception
            '   MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub FillAccounts()

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select AccountKey,FullName 
                          From [ALHUDA].[dbo].[Accounts] 
                          Where  ISNUMERIC([AccountKey])=1 "
            Sql.WizCountRunQuery(SqlString)
            DebitAcc.Properties.DataSource = Sql.SQLDS.Tables(0)
            CredAcc.Properties.DataSource = Sql.SQLDS.Tables(0)
            SearchSalesPerson.Properties.DataSource = Sql.SQLDS.Tables(0)

        Catch ex As Exception
            '  MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub NewForm()
        DocDate.DateTime = Today
        DocCurrency.Text = "NIS"
    End Sub


    Private Sub FillColumns()
        Dim i As Integer
        Dim DcDate As String = Format(DocDate.DateTime, "yyyy-MM-dd")

        Dim _DoID As Integer
        If DocNewOld.Text = "New" Then
            _DoID = GetMax() + 1
        Else
            _DoID = CInt(DocID.EditValue)
        End If


        For i = 0 To GridView1.RowCount - 1
            GridView1.SetRowCellValue(i, colDocID, _DoID)
            GridView1.SetRowCellValue(i, colDocDate, DcDate)
            GridView1.SetRowCellValue(i, colDocCurrency, DocCurrency.Text)
            GridView1.SetRowCellValue(i, colDocType, DocType.Text)
            GridView1.SetRowCellValue(i, colDebitAcc, DebitAcc.EditValue)
            GridView1.SetRowCellValue(i, colCredAcc, CredAcc.EditValue)
            GridView1.SetRowCellValue(i, colReferance, Referance.Text)
            GridView1.SetRowCellValue(i, colDebitWhereHouse, SearchToWarehouse.EditValue)
            GridView1.SetRowCellValue(i, colCreditWhereHouse, SearchFromWarehouse.EditValue)
            GridView1.SetRowCellValue(i, colDebitAcc, DebitAcc.EditValue)
            GridView1.SetRowCellValue(i, colCredAcc, CredAcc.EditValue)
            GridView1.SetRowCellValue(i, colInputUser, InputUser.Text)
            GridView1.SetRowCellValue(i, colNotes, Notes.Text)
            GridView1.SetRowCellValue(i, colInputDateTime, Now())
            GridView1.SetRowCellValue(i, colAccountAddress, TextAccAddress.Text)
            GridView1.SetRowCellValue(i, colAccountMobile, TextAccMobile.Text)
            GridView1.SetRowCellValue(i, colDocManualNo, DocManualNoTextEdit.Text)
            GridView1.SetRowCellValue(i, colDocSort, DocSortTextEdit.EditValue)
            GridView1.SetRowCellValue(i, colDriver, DriverTextEdit.Text)
            GridView1.SetRowCellValue(i, colDocStatus, "1")
            GridView1.SetRowCellValue(i, colCarNo, CarNoText.Text)
            GridView1.SetRowCellValue(i, ColSalesPerson, SearchSalesPerson.EditValue)
            ' If DocNewOld.Text = "New" Then GridView1.SetRowCellValue(i, colDocStatus, "1")
        Next

    End Sub

    Private Sub SearchToWarehouse_QueryPopUp(sender As Object, e As EventArgs) Handles SearchToWarehouse.QueryPopUp
        FillWhareHouses()
    End Sub
    Private Sub SearchFromWarehouse_QueryPopUp(sender As Object, e As CancelEventArgs) Handles SearchFromWarehouse.QueryPopUp
        FillWhareHouses()
    End Sub

    Private Sub DebitAcc_QueryPopUp(sender As Object, e As EventArgs) Handles DebitAcc.QueryPopUp
        FillAccounts()
    End Sub

    Private Sub CredAcc_QueryPopUp(sender As Object, e As EventArgs) Handles CredAcc.QueryPopUp
        FillAccounts()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        Try
            Dim StockID As String = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "StockID"))

            If e.Column.FieldName = "Quantity" Or e.Column.FieldName = "ItemPrice" Then
                Try
                    Dim Quant As Decimal = CDec(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Quantity"))
                    Dim Pric As Decimal = CDec(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ItemPrice"))
                    Dim Amont As Decimal = Quant * Pric
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, colAmount, Amont)
                Catch ex As Exception
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, colAmount, "0")
                    ' MsgBox(ex.ToString)
                End Try

            End If
            If e.Column.FieldName = "StockID" Then

                Try
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, colStockName, GetItemName(StockID))
                Catch ex As Exception

                End Try

                Try
                    Dim WhareHouse = ""
                    If DocType.Text = "SalesDelivery" And Not String.IsNullOrEmpty(SearchFromWarehouse.Text) Then WhareHouse = CStr(SearchFromWarehouse.EditValue)
                    If DocType.Text = "PurchaseDelivery" And Not String.IsNullOrEmpty(SearchToWarehouse.Text) Then WhareHouse = CStr(SearchToWarehouse.EditValue)
                    If DocType.Text = "Jard" And Not String.IsNullOrEmpty(SearchToWarehouse.Text) Then WhareHouse = CStr(SearchToWarehouse.EditValue)
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, ColStockBalance, GetItemBalanceWallet(StockID, "", "", WhareHouse))
                Catch ex As Exception

                End Try

                Try
                    Dim Account As String = "0"
                    If DocType.Text = "SalesDelivery" And Not String.IsNullOrEmpty(DebitAcc.Text) Then Account = CStr(DebitAcc.EditValue)
                    If DocType.Text = "PurchaseDelivery" And Not String.IsNullOrEmpty(CredAcc.Text) Then Account = CStr(CredAcc.EditValue)
                    If DocType.Text = "SalesDelivery" Or DocType.Text = "PurchaseDelivery" Then
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, colItemPrice, GetLastPrice(StockID, Account))
                    ElseIf DocType.Text = "Jard" Then
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, colItemPrice, GetLastPrice(StockID, Account))
                    Else
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, colItemPrice, 0)
                    End If


                Catch ex As Exception

                End Try


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
            '    MsgBox(ex.ToString)
            Return ""
        End Try

    End Function

    Private Function GetMax() As Integer
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            Dim _DocSort As String
            _DocSort = (DocSortTextEdit.EditValue).ToString
            SqlString = "Select max(DocID) As DocID from StockMove where DocType= '" & DocType.Text & "' and DocSort='" & _DocSort & "'"
            Sql.CRMRunQuery(SqlString)
            If Sql.SQLDS.Tables(0).Rows.Count > 0 Then
                Return CInt(Sql.SQLDS.Tables(0).Rows(0).Item("DocID"))
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0
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

            Dim _ColPrice As GridColumn = view.Columns("ColItemPrice")
            If IsDBNull(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ItemPrice")) = True Then
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

        If view.FocusedColumn.FieldName = "ItemPrice" Then
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

    Private Sub DocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocType.SelectedIndexChanged
        Select Case DocType.Text
            Case "SalesDelivery"
                SearchVendors.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                searchwarehousefrom.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                SearchCustomers.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                SearchWarehouseTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.Text = "ارسالية مبيعات"
            Case "PurchaseDelivery"
                SearchCustomers.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                SearchWarehouseTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                SearchVendors.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                searchwarehousefrom.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.Text = "ارسالية مشتريات"
            Case "Transfer"
                SearchCustomers.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                SearchWarehouseTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                SearchVendors.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                searchwarehousefrom.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.Text = "ارسالية داخلية"
            Case "Jard"
                Me.Text = "سند تسوية مخزون"
                SearchCustomers.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                SearchWarehouseTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                SearchVendors.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                searchwarehousefrom.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ' ColDiff.Visible = True
                ' ColDiff.VisibleIndex = 100
        End Select

    End Sub

    Private Sub DocNewOld_EditValueChanged(sender As Object, e As EventArgs) Handles DocNewOld.EditValueChanged
        Select Case DocNewOld.Text
            Case "New"
                DocSortTextEdit.EditValue = GetDefaultDocSort()
                DocID.EditValue = GetMax() + 1
                InputUser.Text = GlobalVariables.UserIDString
                DocDate.DateTime = Now
                DocStatus.Text = "0"
                TextAccAddress.Text = ""
                TextAccMobile.Text = ""
                DebitAcc.EditValue = ""
                CredAcc.EditValue = ""
                Referance.Text = ""
                TextAccAddress.Text = ""
                TextAccMobile.Text = ""
                SearchFromWarehouse.Text = ""
                SearchToWarehouse.Text = ""
                DocManualNoTextEdit.Text = ""
                DriverTextEdit.Text = ""

            Case "Old"
                FillControls()

        End Select

        GridView1.BestFitColumns()
    End Sub
    Private Function GetDefaultDocSort() As String
        Try
            Dim sql As New SQLControl
            Dim SqlStrign As String = " select DefaultDocType from users where UserID='" & GlobalVariables.UserIDString & "'"
            sql.CRMRunQuery(SqlStrign)
            Return sql.SQLDS.Tables(0).Rows(0).Item("DefaultDocType").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ""
        End Try
    End Function

    Private Sub StockMoveGridControl_Click(sender As Object, e As EventArgs) Handles StockMoveGridControl.Click

    End Sub
    Private Sub GridControl_ProcessGridKey(ByVal sender As Object, ByVal e As KeyEventArgs) Handles StockMoveGridControl.ProcessGridKey
        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            view.DeleteSelectedRows()
            e.Handled = True
        End If
    End Sub
    Private Function GetLastPrice(Item As String, Account As String) As Decimal
        Dim sql As New SQLControl
        Dim _GetLastPrice As Decimal = 0
        Dim SqlString As String
        SqlString = "Select top 1 SMPRICE  
                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT 
                     Where smitemkey='" & Item & "' "
        If Account <> "0" Then
            SqlString += " and SACCOUNTKEY ='" & Account & "'"
        Else
            If Me.DocType.Text = "Jard" Then SqlString += " and DDOCNAME ='Purchase invoice' "
        End If

        SqlString += " ORDER BY SMBASEDATE DESC "

        sql.WizCountRunQuery(SqlString)

        _GetLastPrice = CDec(sql.SQLDS.Tables(0).Rows(0).Item("SMPRICE").ToString)
        Return _GetLastPrice
    End Function
    Private Function GetBalance(Item As String, whareHouse As String) As Integer
        Try
            Dim _GetBalance As Integer = 0
            Dim sql As New SQLControl
            Dim Sqlstring As String = "  select  QuantBalance From (
                                  Select       StockID,
                                  { fn IFNULL   ((SELECT     SUM(Quantity) AS Expr1  FROM  [CRM].[dbo].[StockMove] AS StockMove_1   WHERE (DebitWhereHouse = " & whareHouse & ") AND (StockID = a.StockID)), 0) } -
                                  { fn IFNULL   ((SELECT     SUM(Quantity) AS Expr1  FROM  [CRM].[dbo].[StockMove] AS StockMove_1   WHERE (CreditWhereHouse = " & whareHouse & ") AND (StockID = a.StockID)), 0) } AS QuantBalance
                                  FROM         [CRM].[dbo].[StockMove] AS a 
                                  GROUP BY StockID  ) c
                                  where  StockID ='" & Item & "'"
            sql.WizCountRunQuery(Sqlstring)
            _GetBalance = CInt(sql.SQLDS.Tables(0).Rows(0).Item("QuantBalance").ToString)
            Return _GetBalance
        Catch ex As Exception
            '  MsgBox(ex.ToString)
            Return 0
        End Try

    End Function

    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData

        'Dim IND As Integer = e.ListSourceRowIndex
        'If e.Column.FieldName = "StockBalance" Then
        '    If e.IsGetData Then
        '        Try

        '            Dim StockID As String = GridView1.GetListSourceRowCellValue(IND, "StockID").ToString
        '            Dim WhareHouse As String = ""
        '            If DocType.Text = "SalesDelivery" And Not String.IsNullOrEmpty(SearchFromWarehouse.Text) Then WhareHouse = CStr(SearchFromWarehouse.EditValue)
        '            If DocType.Text = "PurchaseDelivery" And Not String.IsNullOrEmpty(SearchToWarehouse.Text) Then WhareHouse = CStr(SearchToWarehouse.EditValue)
        '            If DocType.Text = "Jard" And Not String.IsNullOrEmpty(SearchToWarehouse.Text) Then WhareHouse = CStr(SearchToWarehouse.EditValue)

        '            '  GridView1.SetRowCellValue(GridView1.FocusedRowHandle, ColStockBalance, GetBalance(StockID, WhareHouse))

        '            e.Value = (GetItemBalanceWallet(StockID, "", "", WhareHouse))



        '        Catch ex As Exception
        '            MsgBox(ex.ToString)
        '        End Try
        '    End If


        'ElseIf e.Column.FieldName = "Diff" Then
        '    Try
        '        e.Value = CInt(GridView1.GetListSourceRowCellValue(IND, "StockBalance").ToString) - CInt(GridView1.GetListSourceRowCellValue(IND, "Diff").ToString)
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        'End If
    End Sub
    Private Sub AddVocation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            '  SelectNextControl(ActiveControl, True, True, True, True)
        ElseIf e.KeyCode = Keys.F3 Then
            Saving()
            DocNewOld.Text = "New"
        ElseIf e.KeyCode = Keys.Insert Then
            DocNewOld.Text = "New"
        ElseIf (e.Control AndAlso e.Alt AndAlso e.KeyCode = Keys.P) Then
            PrintCopy(True)
        Else

            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound 

    End Sub


    Private Sub SearchFromWarehouse_EditValueChanged(sender As Object, e As EventArgs) Handles SearchFromWarehouse.Leave
        'LayoutControl2.Select()
        GridView1.FocusedColumn = GridView1.Columns("ID")

    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        PrintCopy(False)

    End Sub
    Private Sub PrintCopy(PrintCopy As Boolean)
        If GridView1.RowCount = 0 Then
            XtraMessageBox.Show("لا يوجد بيانات للطباعة")
            Exit Sub
        End If
        ShowPrintPreview = True
        PrintDoc(PrintCopy)
        ShowPrintPreview = False
    End Sub

    Private Sub PrintDoc(IsOrigional As Boolean)
        Dim Report As New StockInvoiceReport
        StockReportViwer.DocumentViewer1.DocumentSource = Report

        With Report
            .Parameters("DocID").Value = DocID.Text
            .Parameters("DocType").Value = DocType.Text
            .Parameters("DocSort").Value = DocSortTextEdit.EditValue
            If IsOrigional = True Then .DocOriginal.Text = "نسخة أصلية"
            Select Case DocType.Text
                Case "SalesDelivery"
                    .XrLabelDocName.Text = "ارسالية مبيعات"
                    .Parameters("Account").Value = DebitAcc.Text
                    .Parameters("AccountID").Value = DebitAcc.EditValue
                    .XrLabel11.Visible = False
                    .XrLabel10.Visible = True
                Case "PurchaseDelivery"
                    .XrLabelDocName.Text = "ارسالية مشتريات"
                    .Parameters("Account").Value = CredAcc.Text
                    .Parameters("AccountID").Value = CredAcc.EditValue
                    .XrLabel11.Visible = True
                    .XrLabel10.Visible = False
                Case "Transfer"
                    .XrLabelDocName.Text = "ارسالية داخلية"
                    .Parameters("Account").Value = ""
                    .Parameters("AccountID").Value = ""
                    .XrLabel11.Visible = True
                    .XrLabel10.Visible = True
            End Select
            .XrTableCell30.Value = 0
            .XrTableCell31.Value = 0
            .Parameters("DebitWhereHouse").Value = SearchToWarehouse.Text
            .Parameters("CreditWhereHouse").Value = SearchFromWarehouse.Text
            .Parameters("Driver").Value = DriverTextEdit.Text
            .Parameters("SalesPerson").Value = SearchSalesPerson.EditValue
            .Parameters("SalesPersonName").Value = SearchSalesPerson.Text
        End With

        Report.CreateDocument()
        Report.PrintingSystem.ShowMarginsWarning = False

        If ShowPrintPreview = False Then
            Report.Print()
        Else
            StockReportViwer.Show()
            ' Report.Print(printerName:="Brother MFC-L2710DN series Printer")
        End If
    End Sub

    Private Sub DocStatus_EditValueChanged(sender As Object, e As EventArgs) Handles DocStatus.EditValueChanged
        Select Case DocStatus.Text
            Case "0"
                DocStatusLabel.Text = "جديد"
            Case "1"
                DocStatusLabel.Text = "محفوظ"
            Case "2"
                DocStatusLabel.Text = "مرحل"
        End Select

    End Sub

    Private Sub DocSortTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles DocSortTextEdit.EditValueChanged

    End Sub
End Class