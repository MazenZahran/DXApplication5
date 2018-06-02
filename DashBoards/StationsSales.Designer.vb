Namespace Win_Dashboards
    Partial Public Class StationsSales
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
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StationsSales))
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.ListBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ListBoxDashboardItem2 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ComboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "HO_DATAConnectionString"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            ColumnExpression1.ColumnName = "shift_id"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""1426"" />"
            Table1.Name = "transactions"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "timestamp"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "date"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "time"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "type"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "product_code"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "sale"
            ColumnExpression7.Table = Table1
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "quantity"
            ColumnExpression8.Table = Table1
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "fleet_id"
            ColumnExpression9.Table = Table1
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "mean_id"
            ColumnExpression10.Table = Table1
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "plate"
            ColumnExpression11.Table = Table1
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "product_name"
            ColumnExpression12.Table = Table1
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "mean_name"
            ColumnExpression13.Table = Table1
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "stn_name"
            Table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""875"" />"
            Table2.Name = "stations"
            ColumnExpression14.Table = Table2
            Column14.Expression = ColumnExpression14
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Columns.Add(Column7)
            SelectQuery1.Columns.Add(Column8)
            SelectQuery1.Columns.Add(Column9)
            SelectQuery1.Columns.Add(Column10)
            SelectQuery1.Columns.Add(Column11)
            SelectQuery1.Columns.Add(Column12)
            SelectQuery1.Columns.Add(Column13)
            SelectQuery1.Columns.Add(Column14)
            SelectQuery1.MetaSerializable = Nothing
            SelectQuery1.Name = "transactions"
            RelationColumnInfo1.NestedKeyColumn = "id"
            RelationColumnInfo1.ParentKeyColumn = "stn_id"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table2
            Join1.Parent = Table1
            SelectQuery1.Relations.Add(Join1)
            SelectQuery1.Tables.Add(Table1)
            SelectQuery1.Tables.Add(Table2)
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'PivotDashboardItem1
            '
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Measure1.DataMember = "quantity"
            Measure2.DataMember = "quantity"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Dimension1.DataMember = "product_name"
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem2")
            Me.PivotDashboardItem1.DataMember = "transactions"
            Me.PivotDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.PivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
            Me.PivotDashboardItem1.Name = "Pivot 1"
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.PivotDashboardItem1.ShowCaption = True
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure1, Measure2})
            '
            'ListBoxDashboardItem1
            '
            Me.ListBoxDashboardItem1.ComponentName = "ListBoxDashboardItem1"
            Dimension2.DataMember = "type"
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ListBoxDashboardItem1.DataItemRepository.Clear()
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ListBoxDashboardItem1.DataMember = "transactions"
            Me.ListBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ListBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem1.Name = "List Box 1"
            Me.ListBoxDashboardItem1.ShowCaption = True
            '
            'ListBoxDashboardItem2
            '
            Me.ListBoxDashboardItem2.ComponentName = "ListBoxDashboardItem2"
            Dimension3.DataMember = "stn_name"
            Me.ListBoxDashboardItem2.DataItemRepository.Clear()
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem0")
            Me.ListBoxDashboardItem2.DataMember = "transactions"
            Me.ListBoxDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ListBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem2.Name = "List Box 2"
            Me.ListBoxDashboardItem2.ShowCaption = True
            '
            'ComboBoxDashboardItem1
            '
            Me.ComboBoxDashboardItem1.ComponentName = "ComboBoxDashboardItem1"
            Dimension4.DataMember = "shift_id"
            Me.ComboBoxDashboardItem1.DataItemRepository.Clear()
            Me.ComboBoxDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.ComboBoxDashboardItem1.DataMember = "transactions"
            Me.ComboBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ComboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ComboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ComboBoxDashboardItem1.Name = "Combo Box 1"
            Me.ComboBoxDashboardItem1.ShowCaption = True
            '
            'StationsSales
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.PivotDashboardItem1, Me.ListBoxDashboardItem1, Me.ListBoxDashboardItem2, Me.ComboBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ListBoxDashboardItem2
            DashboardLayoutItem1.Weight = 25.029377203290245R
            DashboardLayoutItem2.DashboardItem = Me.ComboBoxDashboardItem1
            DashboardLayoutItem2.Weight = 24.911868390129261R
            DashboardLayoutItem3.DashboardItem = Me.ListBoxDashboardItem1
            DashboardLayoutItem3.Weight = 50.058754406580491R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 11.728395061728396R
            DashboardLayoutItem4.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem4.Weight = 88.271604938271608R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem4})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents ListBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ListBoxDashboardItem2 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ComboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem

#End Region
    End Class
End Namespace