Public Class FinancialStockBalances
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim sql As New SQLControl
        Dim StockSort As String = CStr(SearchLookSort.EditValue)
        Dim DateTo As String = Format(DateEditTo.DateTime, "yyyy-MM-dd")
        Dim DateFrom As String = Format(DateEditFrom.DateTime, "yyyy-MM-dd")
        Dim WearhouseString As String = CStr(Wearhouse.EditValue)

        Dim SqlString As String = "Select    DISTINCT (SMITEMKEY), IITEMNAME ,SUM(SMSUPPLYQUANTITY*(1-2*DSALESDOC)) as ItemBalance 
                                             , Sum (case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC) else 0  end ) as PurchUnits
                                             , SUM( case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) <=0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC) * -1 else 0 end ) as SaleUnits
                                             , SUM ( case when  SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then  SMSUPPLYQUANTITY*(1-2*DSALESDOC) * SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100) else 0 end    ) as  PurchAmount 
                                             , ISNULL(  SUM ( case when  SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then  SMSUPPLYQUANTITY*(1-2*DSALESDOC) * SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100) else 0 end    ) /  sum (case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC) end ),0) as UnitCost
                                             , ISNULL( SUM ( case when  SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then  SMSUPPLYQUANTITY*(1-2*DSALESDOC) * SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100) else 0 end    ) / sum (case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC)   end ) * SUM( case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) <=0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC) * -1 else 0 end ),0) as UnitProfit
                                             , convert(DECIMAL(16,0),Isnull( SUM(SMSUPPLYQUANTITY*(1-2*DSALESDOC)),0) *  ISNULL(  SUM ( case when  SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then  SMSUPPLYQUANTITY*(1-2*DSALESDOC) * SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100) else 0 end    ) /  sum (case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC) end ),0))  as InventoryNis
                                   FROM      [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT  
                                   Where     ('" & DateTo & "' >= SMBASEDATE) AND ('" & DateFrom & "' <= SMBASEDATE) "
        If StockSort <> "0" Then SqlString = SqlString + " AND     ISORTGROUP='" & StockSort & "' "
        If Not String.IsNullOrEmpty(WearhouseString) Then SqlString = SqlString + " And SMWAREHOUSE = " & WearhouseString

        SqlString = SqlString + " Group by  IITEMNAME,SMITEMKEY Order by  SMITEMKEY "

        ' MsgBox(SqlString)

        sql.WizCountRunQuery(SqlString)

        If sql.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Exit Sub

        Me.GridControl1.DataSource = sql.SQLDS.Tables(0)

        GridView1.BestFitColumns()

    End Sub

    Private Sub FinancialStockBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.AgentWarehouseNames' table. You can move, or remove it, as needed.
        Me.AgentWarehouseNamesTableAdapter.Fill(Me.WizCountDataSet.AgentWarehouseNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.ItemSortNames' table. You can move, or remove it, as needed.
        Me.ItemSortNamesTableAdapter.Fill(Me.WizCountDataSet.ItemSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.

        DateEditFrom.DateTime = cdate("2000-01-01")
        DateEditTo.DateTime = Today
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class