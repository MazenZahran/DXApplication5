Public Class rev
    Dim TempTable As New DataTable
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim WhareHouse As String = CStr(Me.SearchWarehouse.EditValue)
        Dim Sort As String = CStr(Me.SearchSort.EditValue)
        Dim AdjustDay As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")
        Dim JardDoc As Integer = CInt(TextJardDoc.EditValue)
        CopyjardDoc(WhareHouse, Sort, AdjustDay, JardDoc)
    End Sub
    Private Sub CopyjardDoc(WhareHouse As String, Sort As String, AdjustDay As String, JardDoc As Integer)
        Try
            Dim StockbalanceTable As New DataTable
            Dim Sql As New SQLControl
            Dim SqlString As String = " SELECT u.ItemKey,u.ItemName,ItemBalance,ItemJard,ItemBalance-ItemJard as Adjust,isnull(LastPrice,0) as LastPrice,isnull(LastPrice,0)*(ItemBalance-ItemJard)*-1  as Amount, 'Jard' AS Notes
                                        FROM 
                                               (SELECT [ItemKey],[ItemName],isnull(ItemBalance,0) as ItemBalance,LastPrice =(select top 1  SMPRICE From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT v Where  DDOCNAME ='Purchase invoice'  and v.[IITEMKEY]=ww.ItemKey order by SMBASEDATE desc) 
                                                FROM [ALHUDA].[dbo].[Items] ww
                                                LEFT JOIN  (Select    DISTINCT (SMITEMKEY) , IITEMNAME ,SUM(SMSUPPLYQUANTITY*(1-2*DSALESDOC)) as ItemBalance 
                                                FROM      [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT  
                                                Where     ('" & AdjustDay & "' >= SMBASEDATE)  AND    ( ISORTGROUP='" & Sort & "'  ) And SMWAREHOUSE = '" & WhareHouse & "'      
                                                Group by  IITEMNAME,SMITEMKEY    ) aa  
                                                ON aa.SMITEMKEY = ItemKey
                                                where ([SortGroup]='" & Sort & "' )) u 
                                        LEFT JOIN 
                                                (Select       [ItemKey],[ItemName],isnull(ItemBalance,0) as ItemJard
                                                FROM [ALHUDA].[dbo].[Items]  
                                                left join	   
                                                (Select StockID,Sum(Quantity) as ItemBalance
                                                From CRM.[dbo].StockMove
                                                Where DocID =" & JardDoc & " And DocType ='Jard' group by StockID  ) vv
                                                on vv.StockID=ItemKey
                                                where ([SortGroup]='" & Sort & "' )) t 
                                        On t.ItemKey=u.ItemKey  "

            Sql.CRMRunQuery(SqlString)
            TempTable = Sql.SQLDS.Tables(0)
            GridControl1.DataSource = TempTable
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub rev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocSort11' table. You can move, or remove it, as needed.
        Me.StockMoveDocSort11TableAdapter.Fill(Me.CRMDataSet.StockMoveDocSort11)
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocSort1' table. You can move, or remove it, as needed.
        Me.StockMoveDocSort1TableAdapter.Fill(Me.CRMDataSet.StockMoveDocSort1)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'WizCountDataSet.AgentWarehouseNames' table. You can move, or remove it, as needed.
        Me.AgentWarehouseNamesTableAdapter.Fill(Me.WizCountDataSet.AgentWarehouseNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.ItemSortNames' table. You can move, or remove it, as needed.
        Me.ItemSortNamesTableAdapter.Fill(Me.WizCountDataSet.ItemSortNames)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Copydate()
    End Sub
    Private Sub Copydate()
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

        Dim DocYear As Integer = CInt(Format(DateEdit1.DateTime, "yyyy"))
        Dim DocSort As Integer = CInt(SearchDocSort.EditValue)
        Dim DocID As Integer = CInt(TextJardDoc.EditValue)
        Dim DocNameID As Integer = 4

        Dim Refereance As String = DocYear.ToString("00") & DocNameID.ToString("0") & DocSort.ToString("0") & DocID.ToString("00")
        ' Refereance = "1"
        For Each row As DataRow In TempTable.Rows

            Select Case CInt(row.Item("Adjust"))

                Case < 0 'Purchase
                    Dim R As DataRow = WalletTable.NewRow
                    R("ColDocType") = "1"
                    R("ColAccount") = SearchAccount.EditValue
                    R("ColReference") = Refereance
                    R("ColStockID") = row.Item("ItemKey").ToString
                    R("ColQuantity") = Math.Abs(CInt(row.Item("Adjust").ToString))
                    R("ColPrice") = row.Item("LastPrice").ToString
                    R("ColTotal") = Math.Abs(CInt(row.Item("Amount").ToString))
                    R("Coldetails") = row.Item("Notes").ToString
                    WalletTable.Rows.Add(R)

                    Dim RR As DataRow = WalletTable.NewRow
                    RR("ColDocType") = "4"
                    RR("ColAccount") = SearchWarehouse.EditValue
                    RR("ColReference") = Refereance
                    RR("ColStockID") = row.Item("ItemKey").ToString
                    RR("ColQuantity") = Math.Abs(CInt(row.Item("Adjust").ToString))
                    RR("ColPrice") = 0
                    RR("ColTotal") = 0
                    RR("Coldetails") = row.Item("Notes").ToString
                    WalletTable.Rows.Add(RR)
                Case > 0  '"SalesDelivery"
                    Dim R As DataRow = WalletTable.NewRow
                    R("ColDocType") = "2"
                    R("ColAccount") = SearchWarehouse.EditValue
                    R("ColReference") = Refereance
                    R("ColStockID") = row.Item("ItemKey").ToString
                    R("ColQuantity") = Math.Abs(CInt(row.Item("Adjust").ToString))
                    R("ColPrice") = Math.Abs(CInt(row.Item("LastPrice").ToString))
                    R("ColTotal") = Math.Abs(CInt(row.Item("Amount").ToString))
                    R("Coldetails") = row.Item("Notes").ToString
                    WalletTable.Rows.Add(R)

                    Dim RR As DataRow = WalletTable.NewRow
                    RR("ColDocType") = "3"
                    RR("ColAccount") = SearchAccount.EditValue
                    RR("ColReference") = Refereance
                    RR("ColStockID") = row.Item("ItemKey").ToString
                    RR("ColQuantity") = Math.Abs(CInt(row.Item("Adjust").ToString))
                    RR("ColPrice") = Math.Abs(CInt(row.Item("LastPrice").ToString))
                    RR("ColTotal") = Math.Abs(CInt(row.Item("Amount").ToString))
                    RR("Coldetails") = row.Item("Notes").ToString
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
    End Sub
End Class