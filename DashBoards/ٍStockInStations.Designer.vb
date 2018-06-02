Namespace Win_Dashboards
    Partial Public Class tock2
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
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim CustomExpression1 As DevExpress.DataAccess.Sql.CustomExpression = New DevExpress.DataAccess.Sql.CustomExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tock2))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ComboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.TreemapDashboardItem1 = New DevExpress.DashboardCommon.TreemapDashboardItem()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TreemapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ComboBoxDashboardItem1
            '
            Me.ComboBoxDashboardItem1.ComponentName = "ComboBoxDashboardItem1"
            Dimension1.DataMember = "ProductName"
            Me.ComboBoxDashboardItem1.DataItemRepository.Clear()
            Me.ComboBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ComboBoxDashboardItem1.DataMember = "tanks_state"
            Me.ComboBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ComboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ComboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ComboBoxDashboardItem1.Name = "الصنف"
            Me.ComboBoxDashboardItem1.ShowCaption = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "DXApplication5.Settings.HO_DATAConnectionString"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            ColumnExpression1.ColumnName = "stn_id"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""438"" />"
            Table1.Name = "tanks_state"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "stn_name"
            Table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""875"" />"
            Table2.Name = "stations"
            ColumnExpression2.Table = Table2
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "product_id"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            Column4.Alias = "ProductName"
            CustomExpression1.Expression = "IIF([products.name]='Unleaded Super', 'Unleaded regular' , [products.name] )"
            Column4.Expression = CustomExpression1
            ColumnExpression4.ColumnName = "capacity"
            Table3.MetaSerializable = "<Meta X=""495"" Y=""30"" Width=""125"" Height=""1084"" />"
            Table3.Name = "tanks"
            ColumnExpression4.Table = Table3
            Column5.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "timestamp"
            ColumnExpression5.Table = Table1
            Column6.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "stock"
            ColumnExpression6.Table = Table1
            Column7.Expression = ColumnExpression6
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Columns.Add(Column7)
            SelectQuery1.FilterString = "[tanks_state.stock] > 0.0"
            SelectQuery1.GroupFilterString = ""
            SelectQuery1.MetaSerializable = Nothing
            SelectQuery1.Name = "tanks_state"
            RelationColumnInfo1.NestedKeyColumn = "stn_id"
            RelationColumnInfo1.ParentKeyColumn = "stn_id"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table2
            Join1.Parent = Table1
            RelationColumnInfo2.NestedKeyColumn = "id"
            RelationColumnInfo2.ParentKeyColumn = "product_id"
            Join2.KeyColumns.Add(RelationColumnInfo2)
            Table4.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""457"" />"
            Table4.Name = "products"
            Join2.Nested = Table4
            Join2.Parent = Table1
            RelationColumnInfo3.NestedKeyColumn = "id"
            RelationColumnInfo3.ParentKeyColumn = "tank_id"
            Join3.KeyColumns.Add(RelationColumnInfo3)
            Join3.Nested = Table3
            Join3.Parent = Table1
            SelectQuery1.Relations.Add(Join1)
            SelectQuery1.Relations.Add(Join2)
            SelectQuery1.Relations.Add(Join3)
            SelectQuery1.Tables.Add(Table1)
            SelectQuery1.Tables.Add(Table2)
            SelectQuery1.Tables.Add(Table4)
            SelectQuery1.Tables.Add(Table3)
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ChartDashboardItem1
            '
            Dimension2.DataMember = "stn_name"
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure1.DataMember = "stock"
            Measure2.DataMember = "capacity"
            Dimension3.DataMember = "ProductName"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ChartDashboardItem1.DataMember = "tanks_state"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "مخزون المحطات"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "حالي"
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.FullStackedBar
            SimpleSeries1.AddDataItem("Value", Measure1)
            SimpleSeries2.Name = "سعة التنك"
            SimpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.FullStackedBar
            SimpleSeries2.AddDataItem("Value", Measure2)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1, SimpleSeries2})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'TreemapDashboardItem1
            '
            Dimension4.DataMember = "stn_name"
            Me.TreemapDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.TreemapDashboardItem1.ComponentName = "TreemapDashboardItem1"
            Measure3.DataMember = "stock"
            Me.TreemapDashboardItem1.DataItemRepository.Clear()
            Me.TreemapDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1")
            Me.TreemapDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0")
            Me.TreemapDashboardItem1.DataMember = "tanks_state"
            Me.TreemapDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.TreemapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.TreemapDashboardItem1.Name = ""
            Me.TreemapDashboardItem1.ShowCaption = True
            Me.TreemapDashboardItem1.TilesLabelContentType = CType((DevExpress.DashboardCommon.TreemapValueType.Argument Or DevExpress.DashboardCommon.TreemapValueType.Value), DevExpress.DashboardCommon.TreemapValueType)
            Me.TreemapDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure3})
            '
            'tock2
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.ComboBoxDashboardItem1, Me.TreemapDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ComboBoxDashboardItem1
            DashboardLayoutItem1.Weight = 7.27802037845706R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 46.433770014556039R
            DashboardLayoutItem3.DashboardItem = Me.TreemapDashboardItem1
            DashboardLayoutItem3.Weight = 46.2882096069869R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TreemapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ComboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents TreemapDashboardItem1 As DevExpress.DashboardCommon.TreemapDashboardItem

#End Region
    End Class
End Namespace