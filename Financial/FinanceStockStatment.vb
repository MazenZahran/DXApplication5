Public Class FinanceStockStatment
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetTable()
    End Sub

    Private Sub GetTable()
        Dim DateFrom As String = Format(DateEditFrom.DateTime, "yyyy-MM-dd")
        Dim DateTo As String = Format(DateEditTo.DateTime, "yyyy-MM-dd")

        Dim StockStatment As New DataTable
        With StockStatment
            .Columns.Add("Description", GetType(String))
            .Columns.Add("Diesle", GetType(String))
            .Columns.Add("95", GetType(String))
            .Columns.Add("98", GetType(String))
            .Columns.Add("Kerosine", GetType(String))
        End With

        StockStatment.Rows.Add()
        StockStatment.Rows(0).Item("Description") = "أول مدة"
        StockStatment.Rows(0).Item("Diesle") = GetBegBalance("1", DateFrom)
        StockStatment.Rows(0).Item("95") = GetBegBalance("2", DateFrom)
        StockStatment.Rows(0).Item("98") = GetBegBalance("3", DateFrom)
        StockStatment.Rows(0).Item("Kerosine") = GetBegBalance("4", DateFrom)

        StockStatment.Rows.Add()
        StockStatment.Rows(1).Item("Description") = "مشتريات"
        StockStatment.Rows(1).Item("Diesle") = GetPurchases("1", DateFrom, DateTo)
        StockStatment.Rows(1).Item("95") = GetPurchases("2", DateFrom, DateTo)
        StockStatment.Rows(1).Item("98") = GetPurchases("3", DateFrom, DateTo)
        StockStatment.Rows(1).Item("Kerosine") = GetPurchases("4", DateFrom, DateTo)

        StockStatment.Rows.Add()
        StockStatment.Rows(2).Item("Description") = "مبيعات"
        StockStatment.Rows(2).Item("Diesle") = GetSales("1", DateFrom, DateTo)
        StockStatment.Rows(2).Item("95") = GetSales("2", DateFrom, DateTo)
        StockStatment.Rows(2).Item("98") = GetSales("3", DateFrom, DateTo)
        StockStatment.Rows(2).Item("Kerosine") = GetSales("4", DateFrom, DateTo)

        StockStatment.Rows.Add()
        StockStatment.Rows(3).Item("Description") = "اخر مدة"
        StockStatment.Rows(3).Item("Diesle") = GetEndBalance("1", DateTo)
        StockStatment.Rows(3).Item("95") = GetEndBalance("2", DateTo)
        StockStatment.Rows(3).Item("98") = GetEndBalance("3", DateTo)
        StockStatment.Rows(3).Item("Kerosine") = GetEndBalance("4", DateTo)



        GridControl1.DataSource = StockStatment

    End Sub

    Private Function GetPurchases(Item As String, DateFrom As String, DateTo As String) As String

        Try
            Dim SqlString As String = "  Select  SUM(SMSUPPLYQUANTITY)  As PurchaseQuantity 
                                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                                     Where (('" & DateTo & "' >= SMBASEDATE) AND ('" & DateFrom & "' <= SMBASEDATE) )   and ( SMITEMKEY='" & Item & "')
                                           and (DDOCNAME = 'Purchase invoice')    "
            Dim sql As New SQLControl
            sql.WizCountRunQuery(SqlString)
            If sql.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Return "0"
            Return Format(sql.SQLDS.Tables(0).Rows(0).Item("PurchaseQuantity"), "n0")
        Catch ex As Exception
            Return "0"
        End Try

    End Function


    Private Function GetSales(Item As String, DateFrom As String, DateTo As String) As String
        Try
            Dim SqlString2 As String = " Select  SUM(SMSUPPLYQUANTITY)  As SalesQuantity 
                                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                                     Where (('" & DateTo & "' >= SMBASEDATE) AND ('" & DateFrom & "' <= SMBASEDATE) )   and ( SMITEMKEY='" & Item & "') 
                                           and (DDOCNAME = 'Salesperson invoice' or DDOCNAME='Invoice')    "
            Dim sql As New SQLControl
            sql.WizCountRunQuery(SqlString2)
            If sql.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Return "0"
            Return Format(sql.SQLDS.Tables(0).Rows(0).Item("SalesQuantity"), "n0")
        Catch ex As Exception
            Return "0"
        End Try


    End Function

    Private Sub FinanceStockStatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DateEditFrom.DateTime = Today.AddDays(-30)
        Me.DateEditTo.DateTime = Today
    End Sub


    Private Function GetBegBalance(Item As String, DateFrom As String) As String

        Try
            Dim TotalIn As Integer
            Dim SqlString As String = "  Select  SUM(SMSUPPLYQUANTITY)  As PurchaseQuantity 
                                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                                     Where  ('" & DateFrom & "' > SMBASEDATE)  And ( SMITEMKEY='" & Item & "')
                                            And (DDOCNAME = 'Purchase invoice')    "
            Dim sql As New SQLControl
            sql.WizCountRunQuery(SqlString)
            If sql.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Return "0"
            TotalIn = CInt(Format(sql.SQLDS.Tables(0).Rows(0).Item("PurchaseQuantity"), "n0"))

            Dim TotalOut As Integer
            Dim SqlString2 As String = "  Select  SUM(SMSUPPLYQUANTITY)  As SalesQuantity 
                                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                                     Where  ('" & DateFrom & "' > SMBASEDATE)  And ( SMITEMKEY='" & Item & "')
                                             and (DDOCNAME = 'Salesperson invoice' or DDOCNAME='Invoice')  "
            Dim sql2 As New SQLControl
            sql2.WizCountRunQuery(SqlString2)
            If sql2.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Return "0"
            TotalOut = CInt(Format(sql2.SQLDS.Tables(0).Rows(0).Item("SalesQuantity"), "n0"))

            Dim BegBalance As Integer = CInt(Format(TotalIn - TotalOut, "n0"))
            Return CStr(BegBalance)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            Return "0"
        End Try

    End Function



    Private Function GetEndBalance(Item As String, DateTo As String) As String

        Try
            Dim TotalIn As Integer
            Dim SqlString As String = "  Select  SUM(SMSUPPLYQUANTITY)  As PurchaseQuantity 
                                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                                     Where  ('" & DateTo & "' >= SMBASEDATE)  And ( SMITEMKEY='" & Item & "')
                                            And (DDOCNAME = 'Purchase invoice')    "
            Dim sql As New SQLControl
            sql.WizCountRunQuery(SqlString)
            If sql.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Return "0"
            TotalIn = CInt(Format(sql.SQLDS.Tables(0).Rows(0).Item("PurchaseQuantity"), "n0"))

            Dim TotalOut As Integer
            Dim SqlString2 As String = "  Select  SUM(SMSUPPLYQUANTITY)  As SalesQuantity 
                                     From [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                                     Where  ('" & DateTo & "' >= SMBASEDATE)  And ( SMITEMKEY='" & Item & "')
                                             and (DDOCNAME = 'Salesperson invoice' or DDOCNAME='Invoice')  "
            Dim sql2 As New SQLControl
            sql2.WizCountRunQuery(SqlString2)
            If sql2.SQLDS.Tables.Count = 0 Then MsgBox("لا يوجد بيانات") : Return "0"
            TotalOut = CInt(Format(sql2.SQLDS.Tables(0).Rows(0).Item("SalesQuantity"), "n0"))

            Dim BegBalance As Integer = CInt(Format(TotalIn - TotalOut, "n0"))
            Return CStr(BegBalance)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            Return "0"
        End Try

    End Function
End Class