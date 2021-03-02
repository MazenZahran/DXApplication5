Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FinancialAlhudaWherhouses


    Private Sub FinancialAlhudaWherhouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql_string As String = "   SELECT     [AccountKey] ,  [FullName]
   FROM  [ALHUDA].[dbo].[Accounts]
   where [AccountKey] BETWEEN '2100002' AND '2100099' AND FullName LIKE '%هيئ%' "

        Dim sql As New SQLControl
        sql.WizCountRunQuery(sql_string)
        Me.GridControl2.DataSource = sql.SQLDS.Tables(0)

        'GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
        'GridColumn9.SummaryItem.DisplayFormat = "Max = {0}"

    End Sub



    Private Sub UpdateTrans(Acc As String)

        Try

            Dim FromDatee As String = Format(Me.DateEditFrom.EditValue, "MM/dd/yyyy")
            Dim ToDatee As String = Format(Me.DateEditTo.EditValue, "MM/dd/yyyy")

            If FromStock.Text = "" Then MsgBox("رقم  الصنف فارغ") : Exit Sub
            If ToStock.Text = "" Then MsgBox("رقم  الصنف فارغ") : Exit Sub
            If FromDatee = "" Then MsgBox("التاريخ فارغ ") : Exit Sub
            If ToDatee = "" Then MsgBox(" التاريخ فارغ") : Exit Sub

            '   Dim Acc As String = CStr(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "AccountKey"))

            Dim sql_string As String = " SELECT     [StockMoves].Warehouse  ,  [Stock].Reference  , " _
                                       & " [Stock].ValueDate  , stock.AccountName   "
            If CheckEdit1.Checked = True Then
                sql_string = sql_string + " ,Case When [StockMoves].ItemKey= 3 Then 2 When [StockMoves].ItemKey= 4 Then 1 Else  [StockMoves].ItemKey End As ItemKey   "
            Else
                sql_string = sql_string + " ,[StockMoves].ItemKey "
            End If

            sql_string = sql_string + "  ,Case When [Stock].TransStore=999999999 Then [StockMoves].Quantity  Else 0 End As sss , " _
                                       & " Case When [Stock].Warehouse=999999999 Then [StockMoves].Quantity When [Stock].TransStore =0 Then [StockMoves].Quantity  Else 0 End As ss     " _
                                       & " ,[StockMoves].TFtal,Year([Stock].ValueDate) As ValYear,Month([Stock].ValueDate) As ValMonth " _
                                       & " FROM [ALHUDA].[dbo].[Stock], [ALHUDA].[dbo].[StockMoves]" _
                                       & " where ([StockMoves].StockID = [Stock].ID) " _
                                       & " And  ( ValueDate between '" & FromDatee & "'  and '" & ToDatee & "' ) " _
                                       & " and ( [StockMoves].Warehouse between " & "999999999" & " and " & "999999999" & " ) " _
                                       & " and( [StockMoves].ItemKey between " & FromStock.Text & " and " & ToStock.Text & " ) " _
                                       & " and ( stock.AccountKey = '" & Acc & "' ) "

            Dim sql As New SQLControl
            sql.WizCountRunQuery(sql_string)
            Me.GridControl3.DataSource = sql.SQLDS.Tables(0)
            Calc()
        Catch ex As Exception
            MsgBox("خطا: يرجى تدقيق البيانات")
        End Try

    End Sub

    Function TransTable(Acc As String) As DataTable

        Try

            Dim FromDatee As String = Format(Me.DateEditFrom.EditValue, "MM/dd/yyyy")
            Dim ToDatee As String = Format(Me.DateEditTo.EditValue, "MM/dd/yyyy")

            If FromStock.Text = "" Then MsgBox("رقم  الصنف فارغ") : Exit Function
            If ToStock.Text = "" Then MsgBox("رقم  الصنف فارغ") : Exit Function
            If FromDatee = "" Then MsgBox("التاريخ فارغ ") : Exit Function
            If ToDatee = "" Then MsgBox(" التاريخ فارغ") : Exit Function

            '   Dim Acc As String = CStr(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "AccountKey"))

            Dim sql_string As String = " SELECT     [StockMoves].Warehouse  ,  [Stock].Reference  , " _
                                       & " [Stock].ValueDate  , stock.AccountName   "
            If CheckEdit1.Checked = True Then
                sql_string = sql_string + " ,Case When [StockMoves].ItemKey= 3 Then 2 When [StockMoves].ItemKey= 4 Then 1 Else  [StockMoves].ItemKey End As ItemKey   "
            Else
                sql_string = sql_string + " ,[StockMoves].ItemKey "
            End If
            sql_string = sql_string + "  ,Case When [Stock].TransStore=999999999 Then [StockMoves].Quantity  Else 0 End As sss , " _
                                       & " Case When [Stock].Warehouse=999999999 Then [StockMoves].Quantity When [Stock].TransStore =0 Then [StockMoves].Quantity  Else 0 End As ss     " _
                                       & " ,[StockMoves].TFtal,Year([Stock].ValueDate) As ValYear,Month([Stock].ValueDate) As ValMonth " _
                                       & " FROM [ALHUDA].[dbo].[Stock], [ALHUDA].[dbo].[StockMoves]" _
                                       & " where ([StockMoves].StockID = [Stock].ID) " _
                                       & " And  ( ValueDate between '" & FromDatee & "'  and '" & ToDatee & "' ) " _
                                       & " and ( [StockMoves].Warehouse between " & "999999999" & " and " & "999999999" & " ) " _
                                       & " and( [StockMoves].ItemKey between " & FromStock.Text & " and " & ToStock.Text & " ) " _
                                       & " and ( stock.AccountKey = '" & Acc & "' ) "

            Dim sql As New SQLControl
            sql.WizCountRunQuery(sql_string)
            TransTable = sql.SQLDS.Tables(0)
            Calc()
            Return TransTable
        Catch ex As Exception
            MsgBox("خطا: يرجى تدقيق البيانات")

        End Try

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function

#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Sub AlhudaAcc()

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles FromStock.EditValueChanged, ToStock.EditValueChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl3.ShowPrintPreview()
    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click
        UpdateTrans(CStr(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "AccountKey")))
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        UpdateTrans(AccountIDText.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Try
            If FromStock.Text = "" Or ToStock.Text = "" Then Exit Sub
            Dim i As Integer
            Dim NewTable As New DataTable
            Dim NewTable2 As New DataTable
            For i = 0 To GridView2.RowCount - 1
                Dim aa As String = CStr(GridView2.GetRowCellValue(i, "AccountKey"))
                NewTable = TransTable(aa)
                NewTable2.Merge(NewTable)

            Next
            GridControl3.DataSource = NewTable2
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Dim newRow As DataRow = (TryCast(GridControl2.DataSource, DataTable)).NewRow()
        newRow("AccountKey") = AccountIDText.Text
        newRow("FullName") = AccountNameText.Text
        TryCast(GridControl2.DataSource, DataTable).Rows.Add(newRow)
        GridControl2.RefreshDataSource()

    End Sub

    Private Sub AccountIDText_EditValueChanged(sender As Object, e As EventArgs) Handles AccountIDText.EditValueChanged
        Me.AccountNameText.Text = GetAccData(AccountIDText.Text).FullNamee
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
        GridView2.DeleteRow(GridView2.FocusedRowHandle)
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick_1(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        GridView2.DeleteRow(GridView2.FocusedRowHandle)
    End Sub

    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Calc()
    End Sub

    Private Sub Calc()
        Try
            Dim i As Integer
            Dim Asum As Integer = 0
            Dim Asum2 As Integer = 0
            Dim ASumAll As Integer = 0
            Dim Voucher As Integer = 0
            For i = 0 To GridView3.RowCount - 1
                Dim aa As Integer = CInt(GridView3.GetRowCellValue(i, "ItemKey"))
                Dim SumRow As Integer = CInt(GridView3.GetRowCellValue(i, "ss"))
                Dim SumRowQ As Integer = CInt(GridView3.GetRowCellValue(i, "TFtal"))

                If aa = 2 Or aa = 3 Then
                    Asum = Asum + SumRow
                    Asum2 = Asum2 + SumRowQ
                End If

                ASumAll = ASumAll + SumRow
                Voucher = Voucher + SumRowQ
            Next

            TtayorText.EditValue = CStr(Asum * 0.005)
            '   Me.TransportText.EditValue = Math.Floor(ASumAll / 1000) * CInt(NaqelPrice.EditValue) * 1.16
            ' MsgBox(ASumAll)
            Me.TransportText.EditValue = ASumAll * CDec(NaqelPrice.EditValue)
            UnleadedPriceText.EditValue = Decimal.Round(CDec(Asum2 / Asum), 2)
            TtayorAmountText.EditValue = CDec(UnleadedPriceText.EditValue) * CDec(TtayorText.EditValue)
            MyTotal.EditValue = Voucher - CDec(TtayorAmountText.EditValue) - CDec(Me.TransportText.EditValue)
            MyTotal.EditValue = CInt(MyTotal.EditValue)
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub GridControl3_Click(sender As Object, e As EventArgs) Handles GridControl3.Click
        Calc()
    End Sub

    Private Sub GridView3_ColumnUnboundExpressionChanged(sender As Object, e As ColumnEventArgs) Handles GridView3.ColumnUnboundExpressionChanged
        Calc()
    End Sub

End Class