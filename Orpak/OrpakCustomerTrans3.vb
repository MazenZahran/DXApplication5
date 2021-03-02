Public Class OrpakCustomerTrans3
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Getdata()
    End Sub



    Private Sub Getdata()

        Dim DateFrom As String = CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd"))
        Dim DateTo As String = CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd"))
        Dim productcase As String = "CASE WHEN transactions.product_name = 'Unleaded regular' THEN '95' WHEN transactions.product_name = 'Unleaded Super' THEN '98'   else transactions.product_name  END AS product_name"

        Try


            Dim SqlString As String
            Dim sql As New SQLControl


            SqlString = "SELECT  transactions.[id] as TransID, CONVERT(varchar(10), transactions.date, 103) AS TransDate ,CONVERT(varchar, transactions.time, 108) AS TransTime,fleets.name As FleetName , " &
                                 productcase & " , transactions.quantity, transactions.sale ,stations.stn_name,receipt_d.receipt_id,fleets.code,transactions.ppv,receipt_t.pymean_code as Payment,
                             Transactions.mean_name,transactions.odometer"

            If CheckEditCarFromPos.Checked = True Then
                SqlString = SqlString + " ,case when receipt_t.car_plate = '' then transactions.plate else receipt_t.car_plate end as Plate "
                GridView1.Columns("Plate").GroupIndex = -1
            ElseIf CheckEditCarFromPos.Checked = False Then
                SqlString = SqlString + " ,transactions.plate as Plate "
                GridView1.Columns("Plate").GroupIndex = 0
            End If

            SqlString = SqlString + " From transactions 
                             left Join Fleets On transactions.fleet_id = fleets.id 
                             left Join Receipt_d On transactions.id = receipt_d.transaction_id  And transactions.stn_id = receipt_d.stn_id 
                             left Join receipt_t On Receipt_d.receipt_id = receipt_t.receipt_id  And transactions.stn_id = receipt_t.stn_id 
                             INNER Join stations On transactions.stn_id = stations.stn_id"

            SqlString = SqlString + " Where fleets.code = " & CStr(FleetCode.EditValue)
            'If Sheets("setting").Range("b30") = 1 Then SqlString = SqlString + " And DatePart(year, Date) = " & Sheet3.Range("n2") & " And DatePart(month, Date) = " & Sheet3.Range("m2")
            SqlString = SqlString + " And transactions.Date between  " & "'" & DateFrom & "'" & " and " & "'" & DateTo & "'"
            If CheckOnly1234.Checked = True Then SqlString = SqlString + " and ( transactions.product_code=1 or transactions.product_code=2 or transactions.product_code=3 or transactions.product_code=4 )  "

            SqlString = SqlString + " order by transactions.date "

            If CheckOLDDATA.Checked = False Then
                sql.RunQuery(SqlString)
            Else
                sql.OldOrpakRunQuery(SqlString)
            End If

            GridControl1.DataSource = sql.SQLDS.Tables(0)

        Catch ex As Exception

        End Try


        Try
            Dim sql As New SQLControl
            Dim SqlString As String = "Select " & productcase & " ,product_code ,Sum(quantity) as SumQ ,AVG(ppv) As Price ,Sum(Sale) As Sale from 
                                       transactions
                                       left Join Fleets On transactions.fleet_id = fleets.id  
                                       where fleets.code = " & CStr(FleetCode.EditValue) &
                                       " And transactions.Date between  " & "'" & DateFrom & "'" & " and " & "'" & DateTo & "'"
            If CheckOnly1234.Checked = True Then SqlString = SqlString + " and ( transactions.product_code=1 or transactions.product_code=2 or transactions.product_code=3 or transactions.product_code=4 )  "
            SqlString = SqlString & " group by product_code,product_name order by product_code "
            If CheckOLDDATA.Checked = False Then
                sql.RunQuery(SqlString)
            Else
                sql.OldOrpakRunQuery(SqlString)
            End If
            GridControl2.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub OrpakCustomerTrans3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ' GridControl1.ShowPrintPreview()


        Try
            Dim RightHeader As String, MiddleHeader As String, LeftHeader As String
            RightHeader = String.Empty
            If CheckEnglish.Checked = False Then
                MiddleHeader = "تقرير حركات المركبات " & " " & Me.FleetCode.Text & " " & Me.DateEditFrom.Text & " " & "  " & Me.DateEditTo.Text
            Else
                MiddleHeader = "Fuel Consumption for vehicles " & Me.FleetCode.Text & "  From:" & Me.DateEditFrom.Text & " " & " To:" & Me.DateEditTo.Text
            End If

            LeftHeader = My.Settings.UserName

            '   GridControl1.pri.SizeMode = PrintSizeMode.Stretch

            Dim grids As Control() = New Control() {GridControl1, GridControl2}

            Dim ps As New DevExpress.XtraPrinting.PrintingSystem()
            Dim compositeLink As New DevExpress.XtraPrintingLinks.CompositeLink()
            compositeLink.PrintingSystem = ps

            For Each grid As Control In grids
                Dim link As New DevExpress.XtraPrinting.PrintableComponentLink()
                link.Component = CType(grid, DevExpress.XtraPrinting.IPrintable)
                compositeLink.Links.Add(link)
                compositeLink.BreakSpace = 100
                compositeLink.Landscape = True
                ' link.PrintingSystem.Document.AutoFitToPagesWidth = 1
            Next
            'compositeLink.Landscape = True
            'compositeLink.PrintingSystem.PageMargins.Left = 0
            'compositeLink.PrintingSystem.PageMargins.Right = 0
            'compositeLink.PrintingSystem.PageMargins.Top = 0
            'compositeLink.PrintingSystem.PageMargins.Bottom = 0

            Dim phf As DevExpress.XtraPrinting.PageHeaderFooter =
           TryCast(compositeLink.PageHeaderFooter, DevExpress.XtraPrinting.PageHeaderFooter)
            phf.Header.Content.Clear()
            phf.Header.Content.AddRange(New String() _
            {RightHeader, MiddleHeader, LeftHeader})
            phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far


            compositeLink.CreateDocument()


            compositeLink.PrintingSystem.PageSettings.TopMargin = 50
            compositeLink.PrintingSystem.PageSettings.LeftMargin = 0
            compositeLink.PrintingSystem.PageSettings.RightMargin = 0
            compositeLink.PrintingSystem.PageSettings.BottomMargin = 0
            '  compositeLink.Landscape = True


            compositeLink.ShowPreview()
        Catch ex As Exception
            MsgBox("لا يوجد بيانات")
        End Try
    End Sub

    Private Sub CheckEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEnglish.CheckedChanged

        GridControl1.ForceInitialize()
        GridControl2.ForceInitialize()
        If CheckEnglish.Checked = True Then
            ColTransDate.Caption = "Date"
            ColTransTime.Caption = "Time"
            ColPlate.Caption = "Plate"
            Colreceipt_id.Caption = "Receipt No."
            Colstn_name.Caption = "Station"
            ColProduct.Caption = "Product"
            Colquantity.Caption = "Quantity"
            ColPrices.Caption = "Price"
            ColSale.Caption = "Amount"
            Colodometer.Caption = "Odometer"
            Colmean_name.Caption = "Card No."
            Colproduct_name.Caption = "Product"
            ColSumQ.Caption = "Quantity"
            ColPrice.Caption = "Price"
            ColSumSale.Caption = "Sum"
            Me.RightToLeft = RightToLeft.No

        Else
            ColTransDate.Caption = "التاريخ"
            ColTransTime.Caption = "الوقت"
            ColPlate.Caption = "المركبة"
            Colreceipt_id.Caption = "رقم الوصل"
            Colstn_name.Caption = "المحطة"
            ColProduct.Caption = "الصنف"
            Colquantity.Caption = "الكمية"
            ColPrices.Caption = "السعر"
            ColSale.Caption = "المبلغ"
            Colodometer.Caption = "العداد"
            Colmean_name.Caption = "رقم الكرت"
            Colproduct_name.Caption = "الصنف"
            ColSumQ.Caption = "المبلغ"
            ColPrice.Caption = "السعر"
            ColSumSale.Caption = "المجموع"
            Me.RightToLeft = RightToLeft.Yes
        End If



    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.SelectAll()
        GridView1.CopyToClipboard()
        GridView1.OptionsSelection.MultiSelect = False
    End Sub
End Class