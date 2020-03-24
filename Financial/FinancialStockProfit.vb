
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid


Public Class FinancialStockProfit

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim sql As New SQLControl
        Dim StockFrom As String = CStr(StockFromLook.EditValue)
        Dim StockTo As String = CStr(StockToLook.EditValue)
        Dim Warhouse As String = CStr(Wearhouse.EditValue)
        Dim AccountKey As String = CStr(SearchAccountKey.EditValue)
        Dim StockSort As String = CStr(SearchStockSort.EditValue)
        Dim AccSort As String = CStr(SearchAccSort.EditValue)


        Dim DateFrom As String = Format(DateEditFrom.DateTime, "yyyy-MM-dd")
        Dim DateTo As String = Format(DateEditTo.DateTime, "yyyy-MM-dd")



        Dim SqlString As String = " SELECT    [SACCOUNTNAME] , SMID  AS ALIAS1F, case when  DDOCNAME ='Invoice' then 'مبيعات' when DDOCNAME='Purchase invoice' then 'مشتريات' when DDOCNAME='Salesperson invoice' then 'مبيعات ذمم' when DDOCNAME='Transfer between warehouses' then 'سند استلام' when DDOCNAME='Transfer between warehouses - out' then 'سند ارسال'  else DDOCNAME end  AS ALIAS2F,  SACCOUNTKEY  AS ALIAS3F,  SMWAREHOUSE  AS ALIAS4F,  SMAGENT  AS ALIAS5F,  SDOCNUMBER  AS ALIAS6F
                                             , ASORTGROUP,  SMREFERENCE  AS ALIAS7F,  SMBASEDATE  AS ALIAS8F,  SMDUEDATE  AS ALIAS9F,  SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100)  AS ALIAS10F
                                             ,  SMCURRENCYCODE  AS ALIAS11F,   (CASE DSALESDOC WHEN 0 THEN SMSUPPLYQUANTITY ELSE  NULL  END)  AS ALIAS12F
                                             ,   (CASE DSALESDOC-1 WHEN 0 THEN SMSUPPLYQUANTITY ELSE  NULL  END)  AS ALIAS13F,  SMSUPPLYQUANTITY*(1-2*DSALESDOC)  AS ALIAS14F
                                             , SMITEMKEY AS ALIAS16F, IITEMNAME AS ALIAS16F_SN_1, ISORTGROUP AS ALIAS16F_SN_2 
                                             ,  case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) <=0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC) * -1  end as QuantitySale,  case when SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then SMSUPPLYQUANTITY*(1-2*DSALESDOC)   end as QuantityPurshase
                                             , (CASE DSALESDOC-1 WHEN 0 THEN SMSUPPLYQUANTITY ELSE  NULL  END) * SMPRICE as SaleAmountNIS
                                             , case when  SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then  SMSUPPLYQUANTITY*(1-2*DSALESDOC) * SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100) end  as PurchaseAmountNIS  
                                             ,(CASE DSALESDOC-1 WHEN 0 THEN SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100)  ELSE  NULL  END)  AS sss
                                             , case when  SMSUPPLYQUANTITY*(1-2*DSALESDOC) > 0 then   SMPRICE*((100-SMDISCOUNTPRC)/100*(100-SDISCOUNTPRC)/100) end as ssss
                                             ,Year(SMDUEDATE) As ValYear,Month(SMDUEDATE) as ValMonth
                                    FROM      [ALHUDA].[dbo].   TEMPDYNJOINQUERY_WIZCOUNT               
                                    WHERE     (
                                              ('" & DateTo & "' >= SMBASEDATE) AND ('" & DateFrom & "' <= SMBASEDATE) AND (0 <> SMSUPPLYQUANTITY) AND (DSTOCKUPDATE <>0) AND ('12/31/2050' >= SMDUEDATE) AND ('01/01/1980' <= SMDUEDATE) )  AND SMSTATUS <> 0 AND SMSTATUS<>2 AND SMTREE <> 1 AND IDUMI <> 3 "



        If Not String.IsNullOrEmpty(Warhouse) And Warhouse <> "0" Then SqlString = SqlString + " and SMWAREHOUSE =  " & Warhouse

        If ((StockTo <> "0" Or StockFrom <> "0") And (StockTo <> "" Or StockFrom <> "") And (Not String.IsNullOrEmpty(StockFrom) Or Not String.IsNullOrEmpty(StockTo))) Then SqlString = SqlString + " and ('" & StockTo & "' >= SMITEMKEY) AND ('" & StockFrom & "' <= SMITEMKEY) "

        If Not String.IsNullOrEmpty(AccountKey) And AccountKey <> "0" Then SqlString = SqlString + " and SACCOUNTKEY =  '" & AccountKey & "'"

        If Not String.IsNullOrEmpty(StockSort) And StockSort <> "0" Then SqlString = SqlString + " and ISORTGROUP =  '" & StockSort & "'"

        If Not String.IsNullOrEmpty(AccSort) And AccSort <> "0" Then SqlString = SqlString + " and ASORTGROUP =  '" & AccSort & "'"

        If ChekPurchases.Checked = True Or ChekTransIn.Checked = True Or ChekTransOut.Checked = True Or ChekDebitSale.Checked = True Or ChekSales.Checked = True Then
            Dim Purchaseinvoice As String = ""
            Dim Transferbetweenwarehouses As String = ""
            Dim Transferbetweenwarehousesout As String = ""
            Dim Salespersoninvoice As String = ""
            Dim Invoice As String = ""

            If ChekPurchases.Checked = True Then Purchaseinvoice = "Purchase invoice"
            If ChekTransIn.Checked = True Then Transferbetweenwarehouses = "Transfer between warehouses"
            If ChekTransOut.Checked = True Then Transferbetweenwarehousesout = "Transfer between warehouses - out"
            If ChekDebitSale.Checked = True Then Salespersoninvoice = "Salesperson invoice"
            If ChekSales.Checked = True Then Invoice = "Invoice"

            SqlString = SqlString + " And ( DDOCNAME ='" & Purchaseinvoice & "' or DDOCNAME = '" & Transferbetweenwarehouses & "'
                                      Or DDOCNAME = '" & Transferbetweenwarehousesout & "' or DDOCNAME ='" & Salespersoninvoice & "' or DDOCNAME='" & Invoice & "'"
            SqlString = SqlString + " )"
        End If



            SqlString = SqlString + " ORDER BY  ISORTGROUP ASC  , SMITEMKEY ASC ,SMBASEDATE,SMID "


        sql.WizCountRunQuery(SqlString)

        If sql.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Exit Sub

        GridControl1.DataSource = sql.SQLDS.Tables(0)


        CalcProfit()




        '   Dim TotalSales As String = BandedGridView1.Columns("SaleAmountNIS").SummaryItem.SummaryValue.ToString


    End Sub

    Private Sub CalcProfit()
        Dim TotalSales As String = BandedGridView1.Columns("SaleAmountNIS").SummaryItem.SummaryValue.ToString
        Dim PurchaseAmountNIS As String = BandedGridView1.Columns("PurchaseAmountNIS").SummaryItem.SummaryValue.ToString


        Dim UnitCost As Decimal
        Dim QuantitySale As String = BandedGridView1.Columns("QuantitySale").SummaryItem.SummaryValue.ToString
        Dim QuantityPurshase As String = BandedGridView1.Columns("QuantityPurshase").SummaryItem.SummaryValue.ToString
        If QuantityPurshase <> "0" Then
            UnitCost = CDec(PurchaseAmountNIS) / CDec(QuantityPurshase)
        Else
            UnitCost = 0
        End If

        Me.TextEditQuantityPurchase.Text = QuantityPurshase.ToString
        Me.TextEditQuantitySales.Text = QuantitySale.ToString

        Me.TextEditStock.EditValue = CInt(QuantityPurshase) - CInt(QuantitySale)

        TextEditUnitCost.EditValue = Format(CDec(UnitCost), "0.00")


        TextEditUnitCostSold.EditValue = Format(UnitCost * CDec(QuantitySale), "0.00")

        TextEditUnitProfit.EditValue = CInt(TotalSales) - CInt(TextEditUnitCostSold.EditValue)

    End Sub

    Private Sub TestStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.ItemSortNames' table. You can move, or remove it, as needed.
        Me.ItemSortNamesTableAdapter.Fill(Me.WizCountDataSet.ItemSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.AgentWarehouseNames' table. You can move, or remove it, as needed.
        Me.AgentWarehouseNamesTableAdapter.Fill(Me.WizCountDataSet.AgentWarehouseNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)
        DateEditFrom.DateTime = Today.AddDays(-1)
        DateEditTo.DateTime = Today

        CustomDrawColumnHeader(GridControl1, BandedGridView1)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
        'MsgBox(ChekPurchases.Text)
    End Sub

    Public Shared Sub CustomDrawColumnHeader(ByVal gridControl As GridControl, ByVal gridView As GridView)
        ' Handle this event to paint columns headers manually
        AddHandler gridView.CustomDrawColumnHeader, Sub(s, e)
                                                        If e.Column Is Nothing OrElse e.Column.FieldName <> "ColSalesPrice" Then
                                                            Return
                                                        End If
                                                        ' Fill column headers with the specified colors.
                                                        e.Cache.FillRectangle(Color.Coral, e.Bounds)
                                                        e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect)
                                                        ' Draw the filter and sort buttons.
                                                        For Each info As DrawElementInfo In e.Info.InnerElements
                                                            If Not info.Visible Then
                                                                Continue For
                                                            End If
                                                            ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo)
                                                        Next info
                                                        e.Handled = True
                                                    End Sub
    End Sub

    Private Sub TextEditStock_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditStock.EditValueChanged


        Try
            If CInt(TextEditStock.EditValue) < 0 Then
                TextEditStock.BackColor = Color.Red
            Else
                TextEditStock.ResetBackColor()
            End If
        Catch ex As Exception

        End Try



    End Sub



    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        CalcProfit()
    End Sub

    Private Sub StockToLook_EditValueChanged(sender As Object, e As EventArgs) Handles StockToLook.EditValueChanged

    End Sub

    Private Sub StockFromLook_EditValueChanged(sender As Object, e As EventArgs) Handles StockFromLook.EditValueChanged
        StockToLook.EditValue = StockFromLook.EditValue
    End Sub
End Class