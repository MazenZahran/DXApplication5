Imports DevExpress.XtraEditors

Public Class LiteImportDataToData
    Private Sub XtraForm6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextMonth.EditValue = CInt(Format(Today, "MM")) - 1
        If CInt(Format(Today, "MM")) = 1 Then Me.TextMonth.EditValue = 12
        Me.TextYear.Text = Format(Today, "yyyy")
        If CInt(Format(Today, "MM")) = 1 Then Me.TextYear.EditValue = CInt(Format(Today, "yyyy")) - 1
    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextMonth.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery("  delete from  [CRM].[dbo].[DATATemp]")
        Catch ex As Exception
            MsgBox("خطا")
            Exit Sub
        End Try


        ' نسخ بيانات الى جدول مؤقت
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " insert into [WIZCOUNT].[CRM].[dbo].[DATATemp]
        SELECT T.id as TransID  ,'1' as SerNo , FORMAT(T.date,'yyyy-MM-dd') AS TransDate ,
         CONVERT(varchar, T.time, 108) AS TransTime,A.[FullName] as Fleet,T.plate as Vehicle_Number, 
        		I.ItemName as [ProductName]  , T.quantity as Quantity,
        		T.sale - isnull(W.price,0)*T.quantity  as TotalSale ,
        		REPLACE(S.NAME_AR, 'محطة ', '') as StationName ,receipt_d.receipt_id as Receipt ,F.code as FleetCode,
        		T.mean_name as DeviceName," & TextMonth.Text & " as TransMont ," & TextYear.Text & " as TransYear,Odometer, T.product_code as ProductCode
        		, (T.sale - isnull(W.price,0)*T.quantity) /T.quantity  as Price,convert(varchar, getdate(), 20) as InputDateTime,A.SortGroup as Sort
        FROM   [HO_DATA].[dbo].[transactions] T 
                left JOIN  fleets F ON T.fleet_id = F.id 
        		left JOIN receipt_d ON T.id = receipt_d.transaction_id  AND T.stn_id = receipt_d.stn_id 
        		left join [WIZCOUNT].[ALHUDA].[dbo].[Accounts] A on A.AccountKey=CONVERT(nvarchar, CONVERT(VARCHAR(12), F.code))  
        		left join [WIZCOUNT].[WALLET].[dbo].[SPECIALPRICES] W on W.AccountKey=CONVERT(nvarchar, CONVERT(VARCHAR(12), F.code))  and W.ITEMKEY=T.product_code
        		left join [WIZCOUNT].[WALLET].[dbo].[STATIONS] S on S.[STN_ID]=T.stn_id
        		left join   [WIZCOUNT].[ALHUDA].[dbo].[Items] I on I.ItemKey =CONVERT(nvarchar, CONVERT(VARCHAR(12), T.product_code)) 
        WHERE   DatePart(year, Date) = " & TextYear.Text & " and DatePart(month, Date) = " & TextMonth.Text & " and T.type='cstmr' and T.quantity >0
        order by  T.date "
            sql.RunQuery(SqlString)
            ' OrpakTrans = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("لا يمكن نسخ البيانات الى الجدول المؤقت")
            Exit Sub
        End Try


        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery("Update [CRM].[dbo].[DATATemp] Set  
        StationName='محطة طولكرم' where StationName='محطة طولكرم القيسي'")
        Catch ex As Exception

        End Try




        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery("UPDATE [CRM].[dbo].[DATATemp]
                             SET StationName = REPLACE(StationName, 'محطة ', '') ")
        Catch ex As Exception

        End Try

        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery("Update [CRM].[dbo].[DATATemp] Set  
        StationName='بيت لحم' where StationName='بيت لحمNW'")
        Catch ex As Exception

        End Try

        Try
            Dim sql As New SQLControl
            Dim SqlString As String
            SqlString = " insert into [CRM].[dbo].[DATATemp]
      SELECT       S.[Reference] as TransID
      ,[DocNumber] as SerNo
	  ,[ValueDate] as TransDate
	  ,'00:00:00.000' [TransTime]
	  ,[AccountName] as [Fleet]
	  ,0 as [Vehicle_Number] 
	  ,M.ItemName as [ProductName]
	  ,M.[Quantity] as [Quantity]  
	  ,M.TFtal  as [TotalSale]
	  ,'Stock' as [StationName] 
	  , S.ID as [Receipt]
	  , S.[AccountKey]   as [FleetCode]
	  , 'توزيع' as DeviceName
	  , " & TextMonth.Text & " as [TransMonth]
	  , " & TextYear.Text & " as [TransYear]
	  ,0 as [Odometer]
	  , M.[ItemKey] as [ProductCode]  
	  , M.[Price] as [Price]
	  , convert(varchar, getdate(), 20) as InputDateTime
	  , A.SortGroup as [Sort]
  FROM [ALHUDA].[dbo].[Stock] S
  left join StockMoves M on m.StockID = S.ID
  left join Items I on I.ItemKey = M.ItemKey
  left join Accounts A on A.AccountKey=S.AccountKey 
  where Batch =9990 and DATEPART(month, ValueDate) =" & TextMonth.Text & "  and DATEPART(year, ValueDate)= " & TextYear.Text & " and S.AccountKey <> 'Without' "
            sql.WizCountRunQuery(SqlString)
            ' StockTable = sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("لا يمكن نسخ البيانات الى الجدول المؤقت")
        End Try

        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery(" select * from [CRM].[dbo].[DATATemp]")
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim Sql As New SQLControl
        Sql.CRMRunQuery("insert into [DATA]
select * from [DATATemp]")
        GridControl1.DataSource = Nothing
        XtraMessageBox.Show("تم ادخال كل البيانات")
    End Sub
End Class