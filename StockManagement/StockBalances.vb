Imports DevExpress.XtraGrid.Views.Base

Public Class StockBalances
    Private Sub StockBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.ItemSortNames' table. You can move, or remove it, as needed.
        Me.ItemSortNamesTableAdapter.Fill(Me.WizCountDataSet.ItemSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)
        'TODO: This line of code loads data into the 'WizCountDataSet.AgentWarehouseNames' table. You can move, or remove it, as needed.
        Me.AgentWarehouseNamesTableAdapter.Fill(Me.WizCountDataSet.AgentWarehouseNames)
        DateEditAtDate.EditValue = Now
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        UpdateBalances()
    End Sub


    Private Sub UpdateBalances()
        Try
            Dim _DateEditAtDate As String = Format(DateEditAtDate.EditValue, "yyyy-MM-dd")
            Dim _SearcItemSort As String = ""
            If SearcItemSort.Text <> "" Then _SearcItemSort = CStr(SearcItemSort.EditValue)

            If String.IsNullOrEmpty(SearchFromWarehouse.Text) Then Exit Sub
            Dim sql As New SQLControl
            Dim SqlString As String
            Dim WhareHouse As String = "'" & CStr(SearchFromWarehouse.EditValue) & "'"
            SqlString = " select  StockID,QuanIN,QuanOUT,QuantBalance,SortGroup,i.ItemName as StockName From (
                                  Select       StockID,
                                  { fn IFNULL   ((SELECT     isnull( SUM(Quantity) ,0) AS Expr1  FROM  StockMove AS StockMove_1   WHERE DocDate <= '" & _DateEditAtDate & "' and  (DebitWhereHouse = " & WhareHouse & ") AND (StockID = a.StockID)), 0) } AS QuanIN,
                                  { fn IFNULL   ((SELECT     isnull( SUM(Quantity) ,0) AS Expr1  FROM  StockMove AS StockMove_1   WHERE DocDate <= '" & _DateEditAtDate & "' and  (CreditWhereHouse = " & WhareHouse & ") AND (StockID = a.StockID)), 0) } AS QuanOUT,
                                  { fn IFNULL   ((SELECT     isnull( SUM(Quantity) ,0) AS Expr1  FROM  StockMove AS StockMove_1   WHERE DocDate <= '" & _DateEditAtDate & "' and  (DebitWhereHouse = " & WhareHouse & ") AND (StockID = a.StockID)), 0) } -
                                  { fn IFNULL   ((SELECT     isnull( SUM(Quantity) ,0) AS Expr1  FROM  StockMove AS StockMove_1   WHERE DocDate <= '" & _DateEditAtDate & "' and  (CreditWhereHouse = " & WhareHouse & ") AND (StockID = a.StockID)), 0) } AS QuantBalance
                     FROM         StockMove AS a 
                     GROUP BY StockID  ) c
                     Left join ALHUDA.dbo.Items i on i.ItemKey =CAST(c.StockID AS nvarchar(50))  
                     where QuantBalance <> 0 "
            If Not String.IsNullOrEmpty(SearchLookItems.Text) Then SqlString += " And StockID ='" & CStr(SearchLookItems.EditValue) & "'"
            If Not String.IsNullOrEmpty(SearcItemSort.Text) Then SqlString += " And SortGroup ='" & CStr(SearcItemSort.EditValue) & "'"

            sql.CRMRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
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
            MsgBox(ex.ToString)
            Return ""
        End Try

    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class