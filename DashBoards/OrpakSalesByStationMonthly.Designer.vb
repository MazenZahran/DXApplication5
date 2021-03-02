Namespace Win_Dashboards
    Partial Public Class OrpakSalesByStationMonthly
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakSalesByStationMonthly))
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.HO_DATADataSet1 = New DXApplication5.HO_DATADataSet()
            '   Me.TransactionsTableAdapter1 = New DXApplication5.HO_DATADataSetTableAdapters.transactionsTableAdapter()
            Me.HO_DATADataSet2 = New DXApplication5.HO_DATADataSet()
            '    Me.TransactionsTableAdapter2 = New DXApplication5.HO_DATADataSetTableAdapters.transactionsTableAdapter()
            Me.HO_DATADataSet3 = New DXApplication5.HO_DATADataSet()
            '   Me.TransactionsTableAdapter3 = New DXApplication5.HO_DATADataSetTableAdapters.transactionsTableAdapter()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.ListBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            CType(Me.HO_DATADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HO_DATADataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HO_DATADataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'HO_DATADataSet1
            '
            Me.HO_DATADataSet1.DataSetName = "HO_DATADataSet"
            Me.HO_DATADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TransactionsTableAdapter1
            '
            '  Me.TransactionsTableAdapter1.ClearBeforeFill = True
            '
            'HO_DATADataSet2
            '
            Me.HO_DATADataSet2.DataSetName = "HO_DATADataSet"
            Me.HO_DATADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TransactionsTableAdapter2
            '
            '   Me.TransactionsTableAdapter2.ClearBeforeFill = True
            '
            'HO_DATADataSet3
            '
            Me.HO_DATADataSet3.DataSetName = "HO_DATADataSet"
            Me.HO_DATADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TransactionsTableAdapter3
            '
            '  Me.TransactionsTableAdapter3.ClearBeforeFill = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "HO_DATAConnectionString"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            CustomSqlQuery1.Name = "Query"
            QueryParameter1.Name = "date1"
            QueryParameter1.Type = GetType(Date)
            QueryParameter1.ValueInfo = "2017-01-01"
            QueryParameter2.Name = "date2"
            QueryParameter2.Type = GetType(Date)
            QueryParameter2.ValueInfo = "2030-01-01"
            CustomSqlQuery1.Parameters.Add(QueryParameter1)
            CustomSqlQuery1.Parameters.Add(QueryParameter2)
            CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ChartDashboardItem1
            '
            Dimension1.DataMember = "mmonth"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Dimension2.DataMember = "CurrYear"
            Dimension2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.None
            Measure1.DataMember = "Q1"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem2")
            Me.ChartDashboardItem1.DataMember = "Query"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "رسم بياني"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'ListBoxDashboardItem1
            '
            Me.ListBoxDashboardItem1.ComponentName = "ListBoxDashboardItem1"
            Dimension3.DataMember = "stn_name"
            Me.ListBoxDashboardItem1.DataItemRepository.Clear()
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem0")
            Me.ListBoxDashboardItem1.DataMember = "Query"
            Me.ListBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ListBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem1.Name = "المحطة"
            Me.ListBoxDashboardItem1.ShowCaption = True
            '
            'OrpakSalesByStationMonthly
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.ListBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ListBoxDashboardItem1
            DashboardLayoutItem1.Weight = 10.494752623688155R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 89.505247376311843R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "تقرير مبيعات المحطات شهري"
            CType(Me.HO_DATADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HO_DATADataSet2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HO_DATADataSet3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents HO_DATADataSet1 As HO_DATADataSet
        '    Friend WithEvents TransactionsTableAdapter1 As HO_DATADataSetTableAdapters.transactionsTableAdapter
        Friend WithEvents HO_DATADataSet2 As HO_DATADataSet
        '   Friend WithEvents TransactionsTableAdapter2 As HO_DATADataSetTableAdapters.transactionsTableAdapter
        Friend WithEvents HO_DATADataSet3 As HO_DATADataSet
        '  Friend WithEvents TransactionsTableAdapter3 As HO_DATADataSetTableAdapters.transactionsTableAdapter
        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ListBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem

#End Region
    End Class
End Namespace