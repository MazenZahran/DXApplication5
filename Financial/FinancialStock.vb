Public Class FinancialStock
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim FromDatee As String = Format(Me.DateEditFrom.EditValue, "dd/MM/yyyy")
        Dim ToDatee As String = Format(Me.DateEditTo.EditValue, "dd/MM/yyyy")




        Dim sql_string As String = " SELECT     [StockMoves].Warehouse ,  [Stock].Reference  , " _
    & "[Stock].ValueDate  , stock.AccountName  , " _
    & " [StockMoves].ItemKey    , " _
    & " case when [Stock].TransStore=999999999 then [StockMoves].Quantity  else 0 end as sss , " _
    & " case when [Stock].Warehouse=999999999 then [StockMoves].Quantity when [Stock].TransStore =0 then [StockMoves].Quantity  else 0 end as ss     " _
    & " ,[StockMoves].TFtal " _
    & " FROM [ALHUDA].[dbo].[Stock], [ALHUDA].[dbo].[StockMoves]" _
    & " where ([StockMoves].StockID = [Stock].ID) " _
    & " and  ( ValueDate between " & FromDatee & "  and " & ToDatee & " ) " _
    & " and ( [StockMoves].Warehouse between " & FromWhereHouse.Text & " and " & ToWhereHouse.Text & " ) " _
    & " and( [StockMoves].ItemKey between " & FromStock.Text & " and " & ToStock.Text & " ) "
        If Me.Accfrom.Text <> "" Then sql_string = sql_string + " and ( stock.AccountKey between '" & Me.Accfrom.Text & "' and '" & Me.AccTo.Text & "' ) "
        sql_string = sql_string + " order by [Stock].ValueDate,[Stock].id"
        MsgBox(sql_string)

        Dim sql As New SQLControl
        sql.WizCountRunQuery(sql_string)

    End Sub



End Class