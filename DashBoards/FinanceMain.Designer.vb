Namespace Win_Dashboards
    Partial Public Class FinanceMain
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
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceMain))
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.TreeViewDashboardItem1 = New DevExpress.DashboardCommon.TreeViewDashboardItem()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TreeViewDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'PivotDashboardItem1
            '
            Dimension1.DataMember = "ITEMNAME"
            Me.PivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Measure1.DataMember = "PRICE"
            Dimension2.DataMember = "DATETO"
            Dimension3.DataMember = "DATETO"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3")
            Me.PivotDashboardItem1.DataMember = "PRICELIST"
            Me.PivotDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.PivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
            Me.PivotDashboardItem1.Name = "Pivot 1"
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2, Dimension3})
            Me.PivotDashboardItem1.ShowCaption = True
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure1})
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "WALLETConnectionString"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            ColumnExpression1.ColumnName = "ITEMNAME"
            Table1.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""153"" />"
            Table1.Name = "ITEMS"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "DATETO"
            Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""172"" />"
            Table2.Name = "PRICELIST"
            ColumnExpression2.Table = Table2
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "PRICE"
            ColumnExpression3.Table = Table2
            Column3.Expression = ColumnExpression3
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Name = "PRICELIST"
            RelationColumnInfo1.NestedKeyColumn = "ITEMKEY"
            RelationColumnInfo1.ParentKeyColumn = "ITEMKEY"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table1
            Join1.Parent = Table2
            SelectQuery1.Relations.Add(Join1)
            SelectQuery1.Tables.Add(Table2)
            SelectQuery1.Tables.Add(Table1)
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ChartDashboardItem1
            '
            Dimension4.DataMember = "DATETO"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure2.DataMember = "PRICE"
            Dimension5.DataMember = "ITEMNAME"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem0")
            Me.ChartDashboardItem1.DataMember = "PRICELIST"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Chart 1"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries1.AddDataItem("Value", Measure2)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'TreeViewDashboardItem1
            '
            Me.TreeViewDashboardItem1.ComponentName = "TreeViewDashboardItem1"
            Dimension6.DataMember = "PRICE"
            Dimension7.DataMember = "DATETO"
            Dimension8.DataMember = "ITEMNAME"
            Me.TreeViewDashboardItem1.DataItemRepository.Clear()
            Me.TreeViewDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem1")
            Me.TreeViewDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem2")
            Me.TreeViewDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem0")
            Me.TreeViewDashboardItem1.DataMember = "PRICELIST"
            Me.TreeViewDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.TreeViewDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7, Dimension8})
            Me.TreeViewDashboardItem1.HiddenDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6})
            Me.TreeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.TreeViewDashboardItem1.Name = "Tree View 1"
            Me.TreeViewDashboardItem1.ShowCaption = True
            '
            'FinanceMain
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.PivotDashboardItem1, Me.ChartDashboardItem1, Me.TreeViewDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem1.Weight = 50.0562429696288R
            DashboardLayoutItem2.DashboardItem = Me.TreeViewDashboardItem1
            DashboardLayoutItem2.Weight = 49.9437570303712R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 45.061728395061728R
            DashboardLayoutItem3.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem3.Weight = 54.938271604938272R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem3})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TreeViewDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents TreeViewDashboardItem1 As DevExpress.DashboardCommon.TreeViewDashboardItem

#End Region
    End Class
End Namespace