﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.OleDb
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils
Imports DevExpress.XtraPrintingLinks
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Xpf.Printing
Imports System.Windows.Documents
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts.Printing

Public Class OrpakCustomerTrans
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a ExcelDataSource
        '   ExcelDataSource1.Fill()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a ExcelDataSource
        '   ExcelDataSource1.Fill()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a ExcelDataSource
        '  ExcelDataSource1.Fill()
    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NavigationPane1_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub ProductTrans(ProductTrans As String)
    '    ProductTrans = "CASE WHEN product_name = 'Unleaded regular' THEN '95' WHEN product_name = 'Unleaded Super' THEN '98'  else product_name  END AS Product"
    'End Sub

    Public Shared Function OpenFile(ByVal fileName As String) As Object
        Dim fullFileName = String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)
        If (Not File.Exists(fullFileName)) Then
            System.Windows.Forms.MessageBox.Show("File not found")
            Return Nothing
        End If

        MsgBox(fullFileName)

        Dim connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0 Xml;", fullFileName)
        '   Dim adapter = New OleDbDataAdapter("select * from [data$A1:p1000000] where [month] = 2 and FleetCode=1013 order by [VehicleNumber]", connectionString)
        Dim adapter2 = New OleDbDataAdapter("select * from [data$A1:p1000000] ", connectionString)
        '  Dim adapter2 = New OleDbDataAdapter("select product,sum(Quantity)sum(totalsale), from [data$A1:p1000000] where month = 4 and FleetCode=1000 order by [VehicleNumber]", connectionString)
        Dim ds = New DataSet()
        Dim tableName As String = "excelData"
        adapter2.Fill(ds, tableName)
        Dim data As DataTable = ds.Tables(tableName)
        '  GridControl1.DataSource = OpenFile()
        Return data
    End Function
    Public Shared Function OpenFileSum(ByVal fileName As String) As Object

        Dim fullFileName = String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)
        If (Not File.Exists(fullFileName)) Then
            System.Windows.Forms.MessageBox.Show("File not found")
            Return Nothing
        End If
        MsgBox(fullFileName)
        Dim connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0 Xml;", fullFileName)
        Dim adapter = New OleDbDataAdapter("select Product,sum(Quantity) as Quantity ,sum(TotalSale)/sum(Quantity) as Price ,sum(TotalSale) as Amount from [data$A1:p1000000] where month = 4 and FleetCode=1000 group by Product ", connectionString)
        Dim ds = New DataSet()
        Dim tableName As String = "excelData"
        adapter.Fill(ds, tableName)
        Dim data As DataTable = ds.Tables(tableName)
        '  ExcelDataSource2
        Return data
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridControl1.DataSource = OpenFile("DATA.xlsm")


        'GridControl2.DataSource = OpenFileSum("data.xlsm")
        'Dim chartTitle1 As New ChartTitle()
        'chartTitle1.Text = "TestChart"
        'ChartControl1.Titles.Add(chartTitle1)

        'ChartControl1.DataSource = GridControl1.DataSource
        'ChartControl1.SeriesDataMember = "Month"
        'ChartControl1.SeriesTemplate.ArgumentDataMember = "VehicleNumber"
        'ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Quantity"})
        '' Specify the template's series view.
        'ChartControl1.SeriesTemplate.View = New StackedBarSeriesView()
        '' Specify the template's name prefix.
        'ChartControl1.SeriesNameTemplate.BeginText = "VehicleNumber: "
        ''  series1.Points.Add(New SeriesPoint("EmpID", i.Item("EmpID")))
        ''series1.Points.Add(New SeriesPoint("Name", i.Item("Name")))
        ''Set series members names for the X And Y values
        ''ChartControl1.Series["Series 1"].XValueMember = "Name"
        ''ChartControl1.Series["Series 1"].YValueMembers = "Sales"
        '' ChartControl1.Series.Add("Nameofthedata")

        ''GridControl1.DataSource = ExcelDataSource1
        ''Dim customerData As NorthwindDataSet.CustomersDataTable = ExcelDataSource1("select * from [data$] ")
        ''  GridControl1.DataSource = ExcelDataSource1

        Dim colReceived As GridColumn = GridView1.Columns("VehicleNumber")
        GridView1.BeginSort()
        Try
            GridView1.ClearGrouping()
            colReceived.GroupIndex = 0
        Finally
            GridView1.EndSort()
        End Try

        GridView1.ExpandAllGroups()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Not GridControl1.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If



        '  CType(printingSystem1.Links(0), Link).Images.Add(Image.FromFile("..\..\omela.png"))
        Dim link As New PrintableComponentLink(New DevExpress.XtraPrinting.PrintingSystem) With {
            .Component = GridControl1,
            .Landscape = True
        }
        link.Margins.Left = 10
        link.Margins.Right = 10
        link.Margins.Top = 80
        link.Margins.Bottom = 50
        link.PageHeaderFooter = "hjg"
        '    link.ShowPreview()


        ' Create an image and add it to the collection.
        link.Images.Add(Image.FromFile(Application.StartupPath + "\..\..\" + "Copy.jpg"))

        ' Create PageHeaderArea object and specify its content.
        ' The third (rightmost) section of the page header will contain
        ' the time when the report is printed and the first image from 
        ' the image collection of this link.
        Dim pgHArea As PageHeaderArea = New PageHeaderArea()
        pgHArea.Content.AddRange(New String() {"", "", "[Time Printed][Image 0]"})

        ' Create a PageHeaderFooter object for this link.
        link.PageHeaderFooter = New PageHeaderFooter(pgHArea, Nothing)

        ' Preview the report.
        link.ShowPreview()


        'GridControl1.DataSource = ExcelDataSource1
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim link As New PrintableComponentLink(New DevExpress.XtraPrinting.PrintingSystem())
        Dim leftColumn As String = "Pages: [Page # of Pages #]"
        Dim middleColumn As String = "User: [User Name]"
        Dim rightColumn As String = "Date: [Date Printed]"

        ' Create a PageHeaderFooter object and initializing it with
        ' the link's PageHeaderFooter.
        Dim phf As PageHeaderFooter =
            TryCast(link.PageHeaderFooter, PageHeaderFooter)

        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()

        ' Add custom information to the link's header.
        phf.Header.Content.AddRange(New String() _
            {leftColumn, middleColumn, rightColumn})
        phf.Header.LineAlignment = BrickAlignment.Far
        link.Component = GridControl1
        ' Show the document's preview.
        link.ShowPreview()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ChartControl1.OptionsPrint.SizeMode = PrintSizeMode.Stretch
        Dim grids As Control() = New Control() {GridControl1, GridControl2, ChartControl1}

        Dim ps As New DevExpress.XtraPrinting.PrintingSystem()
        Dim compositeLink As New DevExpress.XtraPrintingLinks.CompositeLink()
        compositeLink.PrintingSystem = ps

        For Each grid As Control In grids
            Dim link As New PrintableComponentLink()
            link.Component = CType(grid, IPrintable)
            compositeLink.Links.Add(link)
            compositeLink.BreakSpace = 1000
            ' link.PrintingSystem.Document.AutoFitToPagesWidth = 1
        Next
        compositeLink.Landscape = True
        compositeLink.PrintingSystem.PageMargins.Left = 5
        compositeLink.PrintingSystem.PageMargins.Right = 5
        compositeLink.PrintingSystem.PageMargins.Top = 5
        compositeLink.PrintingSystem.PageMargins.Bottom = 5
        compositeLink.CreateDocument()
        compositeLink.ShowPreview()
    End Sub



    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged
        If CheckButton1.Checked = True Then GridView1.CollapseAllGroups()
        If CheckButton1.Checked = False Then GridView1.ExpandAllGroups()
    End Sub

    Private Sub CheckButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton2.CheckedChanged
        Dim colReceived As GridColumn = GridView1.Columns("VehicleNumber")
        If CheckButton2.Checked = True Then
            GridView1.BeginSort()
            Try
                GridView1.ClearGrouping()
                colReceived.GroupIndex = 0
            Finally
                GridView1.EndSort()
            End Try

        Else

            GridView1.BeginSort()
            Try
                GridView1.ClearGrouping()
                colReceived.GroupIndex = -1
            Finally
                GridView1.EndSort()
            End Try

        End If
        '  If If CheckButton2.Checked = True Then colReceived.GroupIndex = 1

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        'Dim sumNetPrice As Double = 0
        ''gridView1
        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    Dim row As DataRow = GridView1.GetDataRow(i)
        '    If (GridView1.GetSelectedRows()(i) >= 0) Then
        '        sumNetPrice += Convert.ToDouble(row("Quantity").ToString())
        '    End If
        'Next
        'MessageBox.Show(sumNetPrice.ToString("NIS #,##0.00"))
    End Sub

    Private Sub NavigationPane1_Click_1(sender As Object, e As EventArgs) Handles NavigationPane1.Click

    End Sub


    Public Shared Function OpenExcelFile(ByVal fileName As String) As Object
        Dim fullFileName = String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)
        If Not File.Exists(fullFileName) Then
            System.Windows.Forms.MessageBox.Show("File not found")
            Return Nothing
        End If
        Dim connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fullFileName)
        Dim adapter = New OleDbDataAdapter("select * from [Sheet1$]", connectionString)
        Dim ds = New DataSet()
        Dim tableName As String = "excelData"
        adapter.Fill(ds, tableName)
        Dim data As DataTable = ds.Tables(tableName)
        Return data
    End Function

End Class