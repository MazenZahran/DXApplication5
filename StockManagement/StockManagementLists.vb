Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class StockManagementLists
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FillData()
    End Sub
    Private Sub Financereceipt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            FillData()
        ElseIf e.KeyCode = Keys.Insert Then
            NewDoc()
        End If
    End Sub

    Private Sub FillData()


        Try
            Dim SqlString As String
            Dim Sql As New SQLControl
            Dim _DocStatus As String = CStr(LookDocStatus.Text)

            Try
                Select Case CStr(Me.DocType.EditValue)
                    Case "SalesDelivery"
                        ColCredAcc.Visible = False
                        ColCreditWhereHouse.Visible = True
                        ColDebitAcc.Visible = True
                        ColDebitWhereHouse.Visible = False
                        ColAmount.Visible = True
                        ColVoucherNo.Visible = True
                        ColIssueVouchers.Visible = True
                        gridBand2.Visible = True
                        Me.Text = "ارسالية مبيعات"
                        LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Case "PurchaseDelivery"
                        ColDebitAcc.Visible = False
                        ColDebitWhereHouse.Visible = True
                        ColCredAcc.Visible = True
                        ColCreditWhereHouse.Visible = False
                        ColVoucherNo.Visible = False
                        ColIssueVouchers.Visible = False
                        ColAmount.Visible = True
                        gridBand2.Visible = True
                        Me.Text = "ارسالية مشتريات"
                        LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Case "Transfer"
                        ColDebitAcc.Visible = False
                        ColDebitWhereHouse.Visible = True
                        ColCredAcc.Visible = False
                        ColCreditWhereHouse.Visible = True
                        ColVoucherNo.Visible = False
                        ColIssueVouchers.Visible = False
                        ColAmount.Visible = False
                        gridBand2.Visible = False
                        Me.Text = "ارسالية داخلية"
                        LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    Case "Jard"
                        ColDebitAcc.Visible = False
                        ColDebitWhereHouse.Visible = True
                        ColCredAcc.Visible = True
                        ColCreditWhereHouse.Visible = False
                        ColVoucherNo.Visible = False
                        ColIssueVouchers.Visible = False
                        ColAmount.Visible = True
                        gridBand2.Visible = False
                        SimpleButton3.Visible = True
                        LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                        Me.Text = "سند تسوية جرد"
                End Select

            Catch ex As Exception

            End Try


            If CheckShowDetails.Checked = True Then
                SqlString = " SELECT distinct DocID, DocDate, DocType, DocStatus, DebitAcc, CredAcc,
                                                 DebitWhereHouse, CreditWhereHouse, Referance, Sum(Amount) as Amount,Driver,DocSort,DocManualNo,
                                                 Sum(Quantity) as Quantity, Count(S.ID) as CountItems, '' as Audit,D.ID as DocSortID,A.IDDocName,WalletDocID,DocAhditDate,DocAuditUser,'False' As IssueVouchers,VoucherNo
                                          FROM StockMove S
                left join StockMoveDocSort1 D on S.DocSort=D.Book
                Left join StockMoveDocuments A on S.DocType=A.DocEnglishName
                                          Where   DocID > 0 and DocStatus < 9 "
                If Me.DocType.Text <> "" Then SqlString += " and DocType='" & CStr(Me.DocType.EditValue) & "'"
                If SearchDocSort.Text <> "" Then SqlString += " and DocSort='" & CStr(SearchDocSort.EditValue) & "'"
                If CStr(LookDocStatus.EditValue) <> "99" Then SqlString = SqlString + " And DocStatus= '" & CStr(LookDocStatus.EditValue) & "'"
                SqlString += "  Group By DocID, DocDate, DocType, DocStatus, DebitAcc, CredAcc,DebitWhereHouse,
                                                   CreditWhereHouse, Referance,Driver,DocSort,DocManualNo,D.ID,IDDocName,WalletDocID,DocAhditDate,DocAuditUser,VoucherNo "
                ColAmount.Visible = True
                ColQuantity.Visible = True
                ColCountItems.Visible = True
            Else
                SqlString = " SELECT distinct DocID , DocDate, DocType, DocStatus, DebitAcc, CredAcc,
                                 DebitWhereHouse, CreditWhereHouse, Referance,Driver,DocSort,DocManualNo,
                                 '' as Audit,D.ID as DocSortID,A.IDDocName,WalletDocID,DocAhditDate,DocAuditUser,'False' as IssueVouchers,VoucherNo
                          FROM StockMove S
                left join StockMoveDocSort1 D on S.DocSort=D.Book
                Left join StockMoveDocuments A on S.DocType=A.DocEnglishName
                          Where   DocID > 0 and DocStatus < 9 "
                If Me.DocType.Text <> "" Then SqlString += " and DocType='" & CStr(Me.DocType.EditValue) & "'"
                If SearchDocSort.Text <> "" Then SqlString += " and DocSort='" & CStr(SearchDocSort.EditValue) & "'"
                If CStr(LookDocStatus.EditValue) <> "99" Then SqlString = SqlString + " And DocStatus= '" & CStr(LookDocStatus.EditValue) & "'"
                SqlString += "  Group By DocID, DocDate, DocType, DocStatus, DebitAcc, CredAcc,DebitWhereHouse,
                                                   CreditWhereHouse, Referance,Driver,DocSort,DocManualNo,D.ID,IDDocName,WalletDocID,DocAhditDate,DocAuditUser,VoucherNo "
                ColAmount.Visible = False
                ColQuantity.Visible = False
                ColCountItems.Visible = False
            End If
            Sql.CRMRunQuery(SqlString)
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        BandedGridView1.BestFitColumns()




    End Sub

    Private Sub DocType_EditValueChanged(sender As Object, e As EventArgs)
        FillData()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        NewDoc()
    End Sub
    Private Sub NewDoc()
        With My.Forms.StockMoves
            .DocType.Text = CStr(DocType.EditValue)
            .DocNewOld.Text = "New"
            .Show()
        End With
    End Sub

    Private Sub StockManagementLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        'TODO: This line of code loads data into the 'CRMDataSet1.StockMoveDocSort11' table. You can move, or remove it, as needed.
        Me.StockMoveDocSort11TableAdapter.Fill(Me.CRMDataSet1.StockMoveDocSort11)
        'TODO: This line of code loads data into the 'CRMDataSet1.StockMoveDocSort1' table. You can move, or remove it, as needed.
        Me.StockMoveDocSort1TableAdapter.Fill(Me.CRMDataSet1.StockMoveDocSort1)
        'TODO: This line of code loads data into the 'CRMDataSet1.ArchiveDocsSort' table. You can move, or remove it, as needed.
        Me.ArchiveDocsSortTableAdapter.Fill(Me.CRMDataSet1.ArchiveDocsSort)
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocStatus' table. You can move, or remove it, as needed.
        Me.StockMoveDocStatusTableAdapter.Fill(Me.CRMDataSet.StockMoveDocStatus)
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocuments' table. You can move, or remove it, as needed.
        Me.StockMoveDocumentsTableAdapter.Fill(Me.CRMDataSet.StockMoveDocuments)
        'TODO: This line of code loads data into the 'CRMDataSet.ArchiveDocTypes' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'WizCountDataSet.AgentWarehouseNames' table. You can move, or remove it, as needed.
        Me.AgentWarehouseNamesTableAdapter.Fill(Me.WizCountDataSet.AgentWarehouseNames)
        Me.SearchDocSort.EditValue = GetDefaultDocSort()

        FillData()
        BandedGridView1.BestFitColumns()


        DateVoucherDate.DateTime = Today

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
    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim gw As GridView = TryCast(sender, GridView)
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub DocType_SelectedIndexChanged(sender As Object, e As EventArgs)
        FillData()
    End Sub

    Private Sub DocType_EditValueChanged_1(sender As Object, e As EventArgs) Handles DocType.EditValueChanged
        If DocType.IsHandleCreated Then
            FillData()
        End If
    End Sub

    Private Sub LookDocStatus_EditValueChanged(sender As Object, e As EventArgs) Handles LookDocStatus.EditValueChanged
        If LookDocStatus.IsHandleCreated Then
            FillData()
        End If
    End Sub


    Private Sub RepositoryOpenDoc_Click(sender As Object, e As EventArgs) Handles RepositoryOpenDoc.Click
        With My.Forms.StockMoves
            .DocType.EditValue = DocType.EditValue
            .DocSortTextEdit.EditValue = CStr(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocSort"))
            .DocID.Text = CStr(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocID"))
            .DocNewOld.Text = "Old"
            ' .DocType.Text = DocType.Text
            .Show()
        End With
    End Sub

    Private Sub RepositoryAudit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryAudit.ButtonClick

        Try
            'Dim DocID As Integer
            'DocID = CInt(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocID"))
            Dim WalletID As Integer
            Try
                WalletID = CInt(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "WalletDocID"))
            Catch ex As Exception
                WalletID = 0
            End Try


            Dim DocAhditDate As String
            DocAhditDate = Format(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocAhditDate"), "yyyy-MM-dd")
            Dim DocAuditUser As String
            DocAuditUser = BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocAuditUser").ToString
            Dim Referance As Integer
            Referance = CInt(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "Referance").ToString)

            If String.IsNullOrEmpty(CStr(WalletID)) Or String.IsNullOrEmpty(DocAhditDate) Or String.IsNullOrEmpty(DocAuditUser) Then
                MsgBox("الرجاء تعبئة كل البيانات المطلوبة") : Exit Sub
            End If

            If CheckLastWalletDocID(WalletID) = False Then
                MsgBox("رقم السند غير مرحل") : Exit Sub
            End If


            'If WalletID > 0 And CheckReferance(Referance) = True Then
            '    Dim result As DialogResult = XtraMessageBox.Show("السند مرحل، هل تريد المتابعة؟", "تنبيه", MessageBoxButtons.YesNo)
            '    If result = System.Windows.Forms.DialogResult.No Then
            '        Exit Sub
            '    End If
            'End If





            Dim DocStatus As String = CStr(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocStatus"))
                Dim DocID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocID"))
                Dim DocYear As Integer = CInt(Format(CDate(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocDate")), "yy"))
                Dim DocNameID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "IDDocName"))
                Dim DocSortID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocSortID"))
            Dim DocType As String = CStr(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocType"))
            Dim DocSort As String = CStr(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocSort"))

            Dim Refereance As String = DocYear.ToString("00") & DocNameID.ToString("0") & DocSortID.ToString("0") & DocID.ToString("00")

            Dim Sql As New SQLControl
            Dim SqlString As String = "Update StockMove
                                                set WalletDocID= " & WalletID & ", DocAhditDate='" & DocAhditDate & "' , DocAuditUser=' " & DocAuditUser & "', Referance='" & Refereance & "' , DocStatus='2' 
                                                where DocID =" & DocID & " And DocType ='" & DocType & "' and DocSort='" & DocSort & "'"

            Sql.CRMRunQuery(SqlString)
                FillData()

        Catch ex As Exception
            MsgBox("لا يمكن تدقيق السند")
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs)
        BandedGridView1.BestFitColumns()
    End Sub

    Private Sub GridView1_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)

        'Dim ImageIN As Image = My.Resources.User_Blue_icon
        'Dim ImageOut As Image = My.Resources.User_Red_icon
        'Dim ImageIN2 As Image = My.Resources.User_Green_icon
        'Dim ImageOut2 As Image = My.Resources.User_Orange_icon
        'Dim View As GridView = CType(sender, GridView)


        'If e.Column.FieldName = "DocType" Then
        '    Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("DocType"))
        '    If category = "دخول" Then
        '        e.Graphics.DrawImage(ImageIN, e.Bounds.Location)
        '        e.DisplayText = "دخول"
        '        e.Appearance.Options.CancelUpdate()
        '    End If
        '    If category = "خروج" Then
        '        e.Graphics.DrawImage(ImageOut, e.Bounds.Location)
        '        e.DisplayText = "خروج"
        '    End If
        '    If category = "دخول مغادرة" Then
        '        e.Graphics.DrawImage(ImageIN2, e.Bounds.Location)
        '        e.DisplayText = "دخول مغادرة"
        '    End If

        'End If




    End Sub

    Private Sub CheckPost_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPost.CheckedChanged
        If CheckPost.Checked = True Then
            'ColWalletDocID.Visible = True
            'ColDocAhditDate.Visible = True
            'ColDocAuditUser.Visible = True
            ColReferance.Visible = True
            gridBand5.Visible = True

            Me.Text = "شاشة ترحيل السندات"
        Else
            'ColWalletDocID.Visible = False
            'ColDocAhditDate.Visible = False
            'ColDocAuditUser.Visible = False
            ColReferance.Visible = False
            gridBand5.Visible = False
        End If
    End Sub
    Private Function GetLastWalletDocID() As Integer
        Try
            Dim sql As New SQLControl
            Dim SqlString As String = "SELECT TOP 1 [ID]   FROM [WALLET].[dbo].[TRANSPORT] order by ID desc  "
            sql.WalletRunQuery(SqlString)
            Return CInt(sql.SQLDS.Tables(0).Rows(0).Item("ID"))
        Catch ex As Exception
            Return 0
            MsgBox("تعذر الحصول على رقم سند الوالت")
        End Try
    End Function

    Private Function CheckLastWalletDocID(WalletID As Integer) As Boolean
        Try
            Dim sql As New SQLControl
            Dim SqlString As String = "SELECT  [ID]   FROM [WALLET].[dbo].[TRANSPORT] where [ID]=  " & WalletID
            sql.WalletRunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function CheckReferance(Referance As Integer) As Boolean
        Try
            Dim sql As New SQLControl
            Dim SqlString As String = "SELECT  [ID]
                                      FROM [WALLET].[dbo].[TRANSPORTDETAILS]
                                      where REFERENCE = " & Referance
            sql.WalletRunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub RepositoryCopyData_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles RepositoryCopyData.ButtonClick

        Try
            Dim LastID As Integer = 0
            LastID = GetLastWalletDocID() + 1
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, ColWalletDocID, LastID)
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, ColDocAhditDate, Format(Now, "yyyy-MM-dd HH:mm"))
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, ColDocAuditUser, GlobalVariables.UserIDString)


            Dim WalletTable As New DataTable
            Dim ColId As New DataColumn With {
                .DataType = System.Type.GetType("System.Int32"),
                .AutoIncrement = True,
                .AutoIncrementSeed = 1,
                .AutoIncrementStep = 1
            }

            With WalletTable
                .Columns.Add(ColId)
                .Columns.Add("ColDocType", GetType(Integer))
                .Columns.Add("ColAccount", GetType(String))
                .Columns.Add("ColReference", GetType(String))
                .Columns.Add("ColStockID", GetType(String))
                .Columns.Add("ColQuantity", GetType(Decimal))
                .Columns.Add("ColPrice", GetType(Decimal))
                .Columns.Add("ColTotal", GetType(Decimal))
                .Columns.Add("Coldetails", GetType(String))
            End With

            Dim DocTable As New DataTable
            Dim DocType As String = Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocType").ToString
            Dim DocSort As String = Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocSort").ToString
            Dim DocID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocID"))
            Dim DocYear As Integer = CInt(Format(CDate(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocDate")), "yy"))
            Dim DocNameID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "IDDocName"))
            Dim DocSortID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocSortID"))

            Dim Refereance As String = DocYear.ToString("00") & DocNameID.ToString("0") & DocSortID.ToString("0") & DocID.ToString("00")
            BandedGridView1.SetRowCellValue(BandedGridView1.FocusedRowHandle, ColReferance, Refereance)

            If CheckReferance(CInt(Refereance)) = True Then
                MsgBox("لا يمكن نسخ السند لانه مرحل")
            End If

            Dim sql As New SQLControl
            Dim SqlString As String = " Select DocID , DocType,DebitAcc,CredAcc,Quantity,ItemPrice,Amount,StockID,DebitWhereHouse,CreditWhereHouse,DocManualNo,DocSort
                                    From StockMove
                                    Where DocID =" & DocID & " And DocType ='" & DocType & "' and DocSort='" & DocSort & "'"
            sql.CRMRunQuery(SqlString)
            Dim TempTable As New DataTable
            TempTable = sql.SQLDS.Tables(0)


            For Each row As DataRow In TempTable.Rows

                Select Case row.Item("DocType").ToString

                    Case "PurchaseDelivery"
                        Dim R As DataRow = WalletTable.NewRow
                        R("ColDocType") = "1"
                        R("ColAccount") = row.Item("CredAcc").ToString
                        R("ColReference") = Refereance
                        R("ColStockID") = row.Item("StockID").ToString
                        R("ColQuantity") = row.Item("Quantity").ToString
                        R("ColPrice") = row.Item("ItemPrice").ToString
                        R("ColTotal") = row.Item("Amount").ToString
                        R("Coldetails") = row.Item("DocManualNo").ToString
                        WalletTable.Rows.Add(R)

                        Dim RR As DataRow = WalletTable.NewRow
                        RR("ColDocType") = "4"
                        RR("ColAccount") = row.Item("DebitWhereHouse").ToString
                        RR("ColReference") = Refereance
                        RR("ColStockID") = row.Item("StockID").ToString
                        RR("ColQuantity") = row.Item("Quantity").ToString
                        RR("ColPrice") = 0
                        RR("ColTotal") = 0
                        RR("Coldetails") = row.Item("DocManualNo").ToString
                        WalletTable.Rows.Add(RR)
                    Case "SalesDelivery"
                        Dim R As DataRow = WalletTable.NewRow
                        R("ColDocType") = "2"
                        R("ColAccount") = row.Item("CreditWhereHouse").ToString
                        R("ColReference") = Refereance
                        R("ColStockID") = row.Item("StockID").ToString
                        R("ColQuantity") = row.Item("Quantity").ToString
                        R("ColPrice") = 0
                        R("ColTotal") = 0
                        R("Coldetails") = row.Item("DocManualNo").ToString
                        WalletTable.Rows.Add(R)

                        Dim RR As DataRow = WalletTable.NewRow
                        RR("ColDocType") = "3"
                        RR("ColAccount") = row.Item("DebitAcc").ToString
                        RR("ColReference") = Refereance
                        RR("ColStockID") = row.Item("StockID").ToString
                        RR("ColQuantity") = row.Item("Quantity").ToString
                        RR("ColPrice") = row.Item("ItemPrice").ToString
                        RR("ColTotal") = row.Item("Amount").ToString
                        RR("Coldetails") = row.Item("DocManualNo").ToString
                        WalletTable.Rows.Add(RR)
                    Case "Transfer"
                        Dim R As DataRow = WalletTable.NewRow
                        R("ColDocType") = "4"
                        R("ColAccount") = row.Item("DebitWhereHouse").ToString
                        R("ColReference") = Refereance
                        R("ColStockID") = row.Item("StockID").ToString
                        R("ColQuantity") = row.Item("Quantity").ToString
                        R("ColPrice") = 0
                        R("ColTotal") = 0
                        R("Coldetails") = row.Item("DocManualNo").ToString
                        WalletTable.Rows.Add(R)

                        Dim RR As DataRow = WalletTable.NewRow
                        RR("ColDocType") = "2"
                        RR("ColAccount") = row.Item("CreditWhereHouse").ToString
                        RR("ColReference") = Refereance
                        RR("ColStockID") = row.Item("StockID").ToString
                        RR("ColQuantity") = row.Item("Quantity").ToString
                        RR("ColPrice") = 0
                        RR("ColTotal") = 0
                        RR("Coldetails") = row.Item("DocManualNo").ToString
                        WalletTable.Rows.Add(RR)
                End Select

            Next row



            Dim ClipText As String = String.Empty
            For Each row As DataRow In WalletTable.Rows
                Dim ClipRow As String = String.Empty
                ClipRow = String.Empty

                For Each col As DataColumn In WalletTable.Columns
                    If Not String.IsNullOrEmpty(ClipRow) Then
                        ClipRow += ControlChars.Tab
                    End If

                    ClipRow += row(col.ColumnName).ToString
                Next

                ClipText += ClipRow + ControlChars.NewLine
            Next

            Clipboard.SetText(ClipText)
        Catch ex As Exception
            MsgBox("لا يمكن ترحيل السند")
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub CheckShowDetails_CheckedChanged(sender As Object, e As EventArgs) Handles CheckShowDetails.CheckedChanged
        If CheckShowDetails.IsHandleCreated Then
            If CheckShowDetails.Checked = True Then
                gridBand4.Visible = True
                FillData()
            Else
                gridBand4.Visible = False
                FillData()
            End If
        End If
    End Sub



    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        rev.DateEdit1.DateTime = CDate(Format(CDate(Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocDate")), "yyyy-MM-dd"))
        rev.SearchWarehouse.EditValue = Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DebitWhereHouse")
        rev.SearchSort.EditValue = 100
        rev.TextJardDoc.EditValue = Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocID")
        rev.SearchAccount.EditValue = Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "CredAcc")
        rev.SearchDocSort.EditValue = Me.BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocSortID")


        rev.ShowDialog()
    End Sub

    Private Sub SearchDocSort_EditValueChanged(sender As Object, e As EventArgs) Handles SearchDocSort.EditValueChanged
        If SearchDocSort.IsHandleCreated Then
            FillData()
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        If IssueVoucherAuthentication() = False Then
            MsgBox("البرنامج تحت الصيانة ، اصبر اشوي يا  " & CStr(GlobalVariables.UserNameString))
            Exit Sub
        End If

        If DateVoucherDate.DateTime < CDate("2020-03-31") Then
            MsgBox("التاريخ قديم")
            Exit Sub
        End If
        Dim i As Integer
        Dim j As Integer = 0
        For i = 0 To BandedGridView1.RowCount - 1
            If CStr(Me.BandedGridView1.GetRowCellValue(i, "IssueVouchers")) = "True" Then
                j += 1
            End If
        Next

        If j = 0 Then
            MsgBox("لم يتم تحديد اي ارسالية ")
            Exit Sub
        End If



        Dim result As DialogResult = XtraMessageBox.Show(" سيتم اصدار فواتير عدد " & j, "تنبيه", MessageBoxButtons.YesNo)
        If result = System.Windows.Forms.DialogResult.Yes Then
            For i = 0 To BandedGridView1.RowCount - 1
                If CStr(Me.BandedGridView1.GetRowCellValue(i, "IssueVouchers")) = "True" Then
                    Dim DocID As Integer = CInt(Me.BandedGridView1.GetRowCellValue(i, "DocID"))
                    Dim DocType As String = CStr(Me.BandedGridView1.GetRowCellValue(i, "DocType"))
                    Dim AccId As String = CStr(Me.BandedGridView1.GetRowCellValue(i, "DebitAcc"))
                    Dim _SearchDocSort As String = SearchDocSort.EditValue
                    Dim Amount As Decimal = GetAmountFotStockMove(DocID, DocType)
                    Dim _VoucherNo As String = IssueVoucher(DocID, DocType, AccId, Amount, _SearchDocSort)
                    Dim Sql As New SQLControl
                    Sql.CRMRunQuery("Update [CRM].[dbo].[StockMove]
                                     Set VoucherNo=" & _VoucherNo & " 
                                     Where DocID=" & DocID & " and DocType='" & DocType & "'")
                End If
            Next

            FillData()

            MsgBox("تم اصدار الفواتير")
        End If

    End Sub

    Private Function GetAmountFotStockMove(DocID As Integer, DocType As String) As Decimal
        Dim _Amount As Decimal

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = " Select SUM(Amount) as Amount
                                        From  [CRM].[dbo].[StockMove]
                                        Where DocID=" & DocID & " and DocType='" & DocType & "'"
            Sql.CRMRunQuery(SqlString)
            _Amount = CDec(Sql.SQLDS.Tables(0).Rows(0).Item("Amount"))

        Catch ex As Exception
            _Amount = 0
        End Try
        Return _Amount
    End Function
    Private Function IssueVoucher(DocId As Integer, DocType As String, AccId As String, Amount As Decimal, DocSort As String) As String

        Dim _VoucherCode As String = "0"
        _VoucherCode = GetRandomString()

        Dim StockData As New DataTable
        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery(" Select StockName as SotckName,Quantity,ItemPrice as Price,Amount,StockID
                          From [CRM].[dbo].[StockMove]
                          Where DocSort ='" & DocSort & "' and  DocID=" & DocId & " and DocType = '" & CStr(Me.DocType.EditValue) & "'")
            StockData = Sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0
        End Try


        Dim _VoucherNo As String
        _VoucherNo = IssueVoucherFromOut(Format(Me.DateVoucherDate.DateTime, "yyyy-MM-dd"),
                            AccId, GetAccData(AccId).FullNamee, GetAccData(AccId).SortGroup,
                            GetAccData(AccId).costcode, GetAccData(AccId).Addresss, Amount,
                            _VoucherCode, MemoVoucherMemo.Text, CInt(Format(DateVoucherDate.DateTime, "MM")),
                            CInt(Format(DateVoucherDate.DateTime, "yyyy")), "Delivary", "NIS", StockData)

        Return _VoucherNo
    End Function

    Private Sub CheckEditIssueVoucher_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditIssueVoucher.CheckedChanged
        If CheckEditIssueVoucher.Checked = True Then
            LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub RepositoryOpenVoucher_Click(sender As Object, e As EventArgs) Handles RepositoryOpenVoucher.Click
        Try
            PrintVoucher(False, CInt(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "VoucherNo")), True, "NIS")
        Catch ex As Exception
            MsgBox("لا يوجد فاتورة ")
        End Try

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub RepositoryIssueVoucher_Click(sender As Object, e As EventArgs) Handles RepositoryIssueVoucher.Click
        MemoVoucherMemo.Text = "وذلك عن ارسالية رقم " & BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "DocID").ToString
    End Sub

    Private Sub RepositoryEmail_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles RepositoryEmail.ButtonClick
        Dim report As New LiteCustomerTrans()
        EmailDataTrans("accounting@alhuda.ps", report, "تست")
    End Sub
    'Private Sub CopyjardDoc()
    '    Try
    '        Dim StockbalanceTable As New DataTable
    '        Dim Sql As New SQLControl
    '        Dim SqlString As String = " SELECT u.ItemKey,u.ItemName,ItemBalance,ItemJard,ItemBalance-ItemJard as Adjust
    '                                    FROM 
    '                                           (SELECT [ItemKey],[ItemName],isnull(ItemBalance,0) as ItemBalance
    '                                            FROM [ALHUDA].[dbo].[Items] 
    '                                            LEFT JOIN  (Select    DISTINCT (SMITEMKEY) , IITEMNAME ,SUM(SMSUPPLYQUANTITY*(1-2*DSALESDOC)) as ItemBalance 
    '                                            FROM      [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT  
    '                                            Where     ('2019-12-31' >= SMBASEDATE) AND ('2000-01-01' <= SMBASEDATE) AND    ( ISORTGROUP='100' or  ISORTGROUP='101' ) And SMWAREHOUSE = '103'      
    '                                            Group by  IITEMNAME,SMITEMKEY    ) aa  
    '                                            ON aa.SMITEMKEY = ItemKey
    '                                            where ([SortGroup]='100' or [SortGroup]='101')) u 
    '                                    LEFT JOIN 
    '                                            (Select       [ItemKey],[ItemName],isnull(ItemBalance,0) as ItemJard
    '                                            FROM [ALHUDA].[dbo].[Items]  
    '                                            left join	   
    '                                            (Select StockID,Sum(Quantity) as ItemBalance
    '                                            From CRM.[dbo].StockMove
    '                                            Where DocID =2 And DocType ='PurchaseDelivery' group by StockID  ) vv
    '                                            on vv.StockID=ItemKey
    '                                            where ([SortGroup]='100' or [SortGroup]='101')) t 
    '                                    On t.ItemKey=u.ItemKey  "

    '        Sql.CRMRunQuery(SqlString)
    '        Dim TempTable As New DataTable
    '        TempTable = Sql.SQLDS.Tables(0)
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '        Exit Sub
    '    End Try

    'End Sub
End Class
