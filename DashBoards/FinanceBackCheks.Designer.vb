Namespace Win_Dashboards
    Partial Public Class FinanceBackCheks
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
            Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceBackCheks))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card1 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardStretchedLayoutTemplate1 As DevExpress.DashboardCommon.CardStretchedLayoutTemplate = New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane3 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries3 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup4 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem6 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem7 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ListBoxDashboardItem3 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ListBoxDashboardItem2 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ListBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ChartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.CardDashboardItem2 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.ComboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CardDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ListBoxDashboardItem3
            '
            Me.ListBoxDashboardItem3.ComponentName = "ListBoxDashboardItem3"
            Dimension1.DataMember = "Currency"
            Me.ListBoxDashboardItem3.DataItemRepository.Clear()
            Me.ListBoxDashboardItem3.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ListBoxDashboardItem3.DataMember = "FinancialChequesBack"
            Me.ListBoxDashboardItem3.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem3.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ListBoxDashboardItem3.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem3.Name = "List Box 3"
            Me.ListBoxDashboardItem3.ShowCaption = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "CRMConnectionString"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            ColumnExpression1.ColumnName = "ID"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""343"" />"
            Table1.Name = "FinancialChequesBack"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "AccID"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "AccountName"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "ChequesNo"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "BankName"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "Amount"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "ChequeDate"
            ColumnExpression7.Table = Table1
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "InputDate"
            ColumnExpression8.Table = Table1
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "Notes"
            ColumnExpression9.Table = Table1
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "ReBackDate"
            ColumnExpression10.Table = Table1
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "Currency"
            ColumnExpression11.Table = Table1
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "CheckPic"
            ColumnExpression12.Table = Table1
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "ChequeStatus"
            ColumnExpression13.Table = Table1
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "ExchangeRate"
            ColumnExpression14.Table = Table1
            Column14.Expression = ColumnExpression14
            ColumnExpression15.ColumnName = "AmountNIS"
            ColumnExpression15.Table = Table1
            Column15.Expression = ColumnExpression15
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
            SelectQuery1.Columns.Add(Column15)
            SelectQuery1.Name = "FinancialChequesBack"
            SelectQuery1.Tables.Add(Table1)
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ListBoxDashboardItem2
            '
            Me.ListBoxDashboardItem2.ComponentName = "ListBoxDashboardItem2"
            Dimension2.DataMember = "InputDate"
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension3.DataMember = "InputDate"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
            Dimension4.DataMember = "InputDate"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Day
            Me.ListBoxDashboardItem2.DataItemRepository.Clear()
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem2")
            Me.ListBoxDashboardItem2.DataMember = "FinancialChequesBack"
            Me.ListBoxDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2, Dimension3, Dimension4})
            Me.ListBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem2.Name = "List Box 2"
            Me.ListBoxDashboardItem2.ShowCaption = True
            '
            'ListBoxDashboardItem1
            '
            Me.ListBoxDashboardItem1.ComponentName = "ListBoxDashboardItem1"
            Dimension5.DataMember = "BankName"
            Me.ListBoxDashboardItem1.DataItemRepository.Clear()
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem0")
            Me.ListBoxDashboardItem1.DataMember = "FinancialChequesBack"
            Me.ListBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5})
            Me.ListBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem1.Name = "List Box 1"
            Me.ListBoxDashboardItem1.ShowCaption = True
            '
            'ChartDashboardItem2
            '
            Dimension6.DataMember = "InputDate"
            Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6})
            Me.ChartDashboardItem2.AxisX.TitleVisible = False
            Me.ChartDashboardItem2.ComponentName = "ChartDashboardItem2"
            Measure1.DataMember = "Amount"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Measure2.DataMember = "Amount"
            Me.ChartDashboardItem2.DataItemRepository.Clear()
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension6, "DataItem0")
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem1")
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure2, "DataItem2")
            Me.ChartDashboardItem2.DataMember = "FinancialChequesBack"
            Me.ChartDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem2.Name = "Chart 2"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            ChartPane2.Name = "Pane 2"
            ChartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.TitleVisible = True
            ChartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.AddDataItem("Value", Measure2)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.ChartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1, ChartPane2})
            Me.ChartDashboardItem2.ShowCaption = True
            '
            'CardDashboardItem2
            '
            Measure3.DataMember = "Amount"
            Card1.AbsoluteVariationNumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Card1.AbsoluteVariationNumericFormat.Precision = 0
            CardStretchedLayoutTemplate1.BottomValue1.DimensionIndex = 0
            CardStretchedLayoutTemplate1.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardStretchedLayoutTemplate1.BottomValue1.Visible = True
            CardStretchedLayoutTemplate1.BottomValue2.DimensionIndex = 0
            CardStretchedLayoutTemplate1.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardStretchedLayoutTemplate1.BottomValue2.Visible = True
            CardStretchedLayoutTemplate1.DeltaIndicator.Visible = True
            CardStretchedLayoutTemplate1.MainValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardStretchedLayoutTemplate1.MainValue.Visible = True
            CardStretchedLayoutTemplate1.Sparkline.Visible = True
            CardStretchedLayoutTemplate1.SubValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardStretchedLayoutTemplate1.SubValue.Visible = True
            CardStretchedLayoutTemplate1.TopValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardStretchedLayoutTemplate1.TopValue.Visible = True
            Card1.LayoutTemplate = CardStretchedLayoutTemplate1
            Card1.PercentOfTargetNumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
            Card1.PercentVariationNumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
            Card1.AddDataItem("ActualValue", Measure3)
            Me.CardDashboardItem2.Cards.AddRange(New DevExpress.DashboardCommon.Card() {Card1})
            Me.CardDashboardItem2.ComponentName = "CardDashboardItem2"
            Dimension7.DataMember = "AccountName"
            Dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension7.TopNOptions.Count = 10
            Dimension7.TopNOptions.Enabled = True
            Dimension7.TopNOptions.Measure = Measure3
            Me.CardDashboardItem2.DataItemRepository.Clear()
            Me.CardDashboardItem2.DataItemRepository.Add(Measure3, "DataItem1")
            Me.CardDashboardItem2.DataItemRepository.Add(Dimension7, "DataItem0")
            Me.CardDashboardItem2.DataMember = "FinancialChequesBack"
            Me.CardDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.CardDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.CardDashboardItem2.Name = "Cards 2"
            Me.CardDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7})
            Me.CardDashboardItem2.ShowCaption = True
            '
            'ChartDashboardItem1
            '
            Dimension8.DataMember = "BankName"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension8})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure4.DataMember = "Amount"
            Measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure4, "DataItem1")
            Me.ChartDashboardItem1.DataMember = "FinancialChequesBack"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Chart 1"
            ChartPane3.Name = "Pane 1"
            ChartPane3.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane3.PrimaryAxisY.ShowGridLines = True
            ChartPane3.PrimaryAxisY.TitleVisible = True
            ChartPane3.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane3.SecondaryAxisY.ShowGridLines = False
            ChartPane3.SecondaryAxisY.TitleVisible = True
            SimpleSeries3.AddDataItem("Value", Measure4)
            ChartPane3.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries3})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane3})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'ComboBoxDashboardItem1
            '
            Me.ComboBoxDashboardItem1.ComponentName = "ComboBoxDashboardItem1"
            Dimension9.DataMember = "ChequeStatus"
            Me.ComboBoxDashboardItem1.DataItemRepository.Clear()
            Me.ComboBoxDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem0")
            Me.ComboBoxDashboardItem1.DataMember = "FinancialChequesBack"
            Me.ComboBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ComboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension9})
            Me.ComboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ComboBoxDashboardItem1.Name = "Combo Box 1"
            Me.ComboBoxDashboardItem1.ShowCaption = True
            '
            'FinanceBackCheks
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.ChartDashboardItem2, Me.ListBoxDashboardItem1, Me.ListBoxDashboardItem2, Me.CardDashboardItem2, Me.ListBoxDashboardItem3, Me.ComboBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ListBoxDashboardItem1
            DashboardLayoutItem1.Weight = 28.658536585365855R
            DashboardLayoutItem2.DashboardItem = Me.ListBoxDashboardItem2
            DashboardLayoutItem2.Weight = 35.975609756097562R
            DashboardLayoutItem3.DashboardItem = Me.ComboBoxDashboardItem1
            DashboardLayoutItem3.Weight = 34.246575342465754R
            DashboardLayoutItem4.DashboardItem = Me.ListBoxDashboardItem3
            DashboardLayoutItem4.Weight = 65.753424657534254R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem3, DashboardLayoutItem4})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup3.Weight = 35.365853658536587R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutGroup3})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 22.530864197530864R
            DashboardLayoutItem5.DashboardItem = Me.ChartDashboardItem2
            DashboardLayoutItem5.Weight = 28.571428571428573R
            DashboardLayoutItem6.DashboardItem = Me.CardDashboardItem2
            DashboardLayoutItem6.Weight = 28.658536585365855R
            DashboardLayoutItem7.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem7.Weight = 42.770034843205572R
            DashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem5, DashboardLayoutItem6, DashboardLayoutItem7})
            DashboardLayoutGroup4.DashboardItem = Nothing
            DashboardLayoutGroup4.Weight = 77.46913580246914R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup4})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ChartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ListBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ListBoxDashboardItem2 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents CardDashboardItem2 As DevExpress.DashboardCommon.CardDashboardItem
        Friend WithEvents ListBoxDashboardItem3 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ComboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem

#End Region
    End Class
End Namespace