Public Class StockItemMoves
    Private Sub StockItemMoves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'WizCountDataSet.AgentWarehouseNames' table. You can move, or remove it, as needed.
        Me.AgentWarehouseNamesTableAdapter.Fill(Me.WizCountDataSet.AgentWarehouseNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        StockMovesData()
    End Sub
    Private Sub StockMovesData()
        Try
            Dim sql As New SQLControl
            Dim SqlString As String = " SELECT [ID] ,[DocID] ,[DocDate]  ,[DocType] ,[DocStatus] ,[DocCurrency]
                                           ,Case when [DebitAcc] IS null then [CredAcc] Else [DebitAcc] End As Account
                                           ,Case when [DebitWhereHouse] Is not Null then [Quantity]   End As [QuantityOut]
                                           ,Case when [CreditWhereHouse] IS not null then  [Quantity] End As [QuantityIn]
                                           ,[ItemPrice],[Amount],[StockID],[Unit],[DebitWhereHouse],[CreditWhereHouse] 
                                           ,[Notes],[Referance] ,[StockName],[InputUser] ,[InputDateTime]
                                   FROM [CRM].[dbo].[StockMove]
                                   Where [ID] > 1 "
            If Not String.IsNullOrWhiteSpace(SearchLookItems.Text) Then SqlString += " And StockID = '" & CStr(SearchLookItems.EditValue) & "'"
            If Not String.IsNullOrWhiteSpace(SearchWarehouse.Text) Then SqlString += " And ( [DebitWhereHouse] ='" & CStr(SearchWarehouse.EditValue) & "' or [CreditWhereHouse]='" & CStr(SearchWarehouse.EditValue) & "')"
            sql.CRMRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try


    End Sub
End Class