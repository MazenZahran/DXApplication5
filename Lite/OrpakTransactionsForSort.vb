Public Class OrpakTransactionsForSort
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        If String.IsNullOrWhiteSpace(SearchSort.Text) Then
            MsgBox("يجب اختيار تصنيف")
            Exit Sub
        Else
            LoadData(CStr(SearchSort.EditValue), ComboMonth.Text, ComboYear.Text)
        End If

    End Sub

    Private Sub LoadData(Sort As String, Mmonth As String, Yyear As String)

        Try
            Dim sql As New SQLControl
            'Dim SqlString As String = " SELECT  CONVERT(varchar(10), transactions.date, 103) AS TheDate ,CONVERT(varchar, transactions.time, 108) AS TheTime
            '                                ,[sale]      ,[ppv]      ,[quantity]      ,[plate]      ,[mean_name]      ,[product_name]
            '                                ,[stn_id]      ,code      ,aa.FullName      ,CRM.EmployeeNo
            '                        FROM [HO_DATA].[dbo].[transactions]
            '                              left join  [HO_DATA].dbo.fleets HO on [HO_DATA].[dbo].[transactions].fleet_id=HO.id
            '                              left join FINANCE.Alhuda.dbo.Accounts aa on CAST(HO.code as nvarchar(15)) =aa.AccountKey
            '                              left join FINANCE.crm.dbo.FinanceAccounts CRM	 on CAST(HO.code as nvarchar(15)) =CRM.AccountKey
            '                        Where   aa.SortGroup='" & Sort & "'  
            '                        Order by [transactions].id desc "

            Dim SqlString As String = "  SELECT    CONVERT(varchar(10), [TransDate], 103) AS TheDate   ,CONVERT(varchar, [TransTime], 108) AS TheTime ,
                           [TotalSale] as sale , CONVERT(DECIMAL(10,2), ISNULL([TotalSale],0) / NULLIF( [Quantity],0)) As [ppv],  [Quantity]  , [Vehicle_Number] as plate, [DeviceName] as mean_name,[ProductName] ,
[StationName]  , [FleetCode], A.FullName  , F.EmployeeNo
                 FROM [CRM].[dbo].[DATA] D
                  left join ALHUDA.dbo.Accounts A
                  on D.FleetCode = A.AccountKey 
                  left join CRM.dbo.FinanceAccounts F
                  on F.AccountKey= D.FleetCode 
                  where SortGroup ='" & Sort & "'  AND TransMonth='" & Mmonth & "' AND TransYear='" & Yyear & "' "
            sql.CRMRunQuery(SqlString)
            Me.GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub OrpakTransactionsForSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.WizCountDataSet.Accounts)
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)

    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class