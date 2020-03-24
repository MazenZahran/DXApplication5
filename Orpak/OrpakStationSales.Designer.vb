<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrpakStationSales
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim BarGrowUpAnimation1 As DevExpress.XtraCharts.BarGrowUpAnimation = New DevExpress.XtraCharts.BarGrowUpAnimation()
        Dim BounceEasingFunction1 As DevExpress.XtraCharts.BounceEasingFunction = New DevExpress.XtraCharts.BounceEasingFunction()
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
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Group1 As DevExpress.DataAccess.Sql.Group = New DevExpress.DataAccess.Sql.Group()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Group2 As DevExpress.DataAccess.Sql.Group = New DevExpress.DataAccess.Sql.Group()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Group3 As DevExpress.DataAccess.Sql.Group = New DevExpress.DataAccess.Sql.Group()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakStationSales))
        Dim ChartControlCommandGalleryItemGroup2DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
        Dim CreateBarChartItem1 As DevExpress.XtraCharts.UI.CreateBarChartItem = New DevExpress.XtraCharts.UI.CreateBarChartItem()
        Dim CreateFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
        Dim CreateSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
        Dim CreateSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
        Dim CreateStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
        Dim ChartControlCommandGalleryItemGroup3DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
        Dim CreateBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateBar3DChartItem = New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
        Dim CreateFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
        Dim CreateManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
        Dim CreateSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
        Dim CreateSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
        Dim CreateStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroupCylinderColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
        Dim CreateCylinderBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
        Dim CreateCylinderFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
        Dim CreateCylinderManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
        Dim CreateCylinderSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
        Dim CreateCylinderSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
        Dim CreateCylinderStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroupConeColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
        Dim CreateConeBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
        Dim CreateConeFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
        Dim CreateConeManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
        Dim CreateConeSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
        Dim CreateConeSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
        Dim CreateConeStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroupPyramidColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
        Dim CreatePyramidBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
        Dim CreatePyramidFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
        Dim CreatePyramidManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
        Dim CreatePyramidSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
        Dim CreatePyramidSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
        Dim CreatePyramidStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroup2DLine1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
        Dim CreateLineChartItem1 As DevExpress.XtraCharts.UI.CreateLineChartItem = New DevExpress.XtraCharts.UI.CreateLineChartItem()
        Dim CreateFullStackedLineChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
        Dim CreateScatterLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
        Dim CreateSplineChartItem1 As DevExpress.XtraCharts.UI.CreateSplineChartItem = New DevExpress.XtraCharts.UI.CreateSplineChartItem()
        Dim CreateStackedLineChartItem1 As DevExpress.XtraCharts.UI.CreateStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
        Dim CreateStepLineChartItem1 As DevExpress.XtraCharts.UI.CreateStepLineChartItem = New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
        Dim ChartControlCommandGalleryItemGroup3DLine1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
        Dim CreateLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateLine3DChartItem = New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
        Dim CreateFullStackedLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
        Dim CreateSpline3DChartItem1 As DevExpress.XtraCharts.UI.CreateSpline3DChartItem = New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
        Dim CreateStackedLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
        Dim CreateStepLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateStepLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
        Dim ChartControlCommandGalleryItemGroup2DPie1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
        Dim CreatePieChartItem1 As DevExpress.XtraCharts.UI.CreatePieChartItem = New DevExpress.XtraCharts.UI.CreatePieChartItem()
        Dim CreateDoughnutChartItem1 As DevExpress.XtraCharts.UI.CreateDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
        Dim CreateNestedDoughnutChartItem1 As DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
        Dim ChartControlCommandGalleryItemGroup3DPie1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
        Dim CreatePie3DChartItem1 As DevExpress.XtraCharts.UI.CreatePie3DChartItem = New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
        Dim CreateDoughnut3DChartItem1 As DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem = New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
        Dim ChartControlCommandGalleryItemGroup2DBar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
        Dim CreateRotatedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
        Dim CreateRotatedFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
        Dim CreateRotatedSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
        Dim CreateRotatedSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
        Dim CreateRotatedStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
        Dim ChartControlCommandGalleryItemGroup2DArea1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
        Dim CreateAreaChartItem1 As DevExpress.XtraCharts.UI.CreateAreaChartItem = New DevExpress.XtraCharts.UI.CreateAreaChartItem()
        Dim CreateFullStackedAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
        Dim CreateFullStackedSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
        Dim CreateFullStackedStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem()
        Dim CreateSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
        Dim CreateStackedAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
        Dim CreateStackedStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem()
        Dim CreateStackedSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
        Dim CreateStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
        Dim ChartControlCommandGalleryItemGroup3DArea1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
        Dim CreateArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateArea3DChartItem = New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
        Dim CreateFullStackedArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
        Dim CreateFullStackedSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
        Dim CreateSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
        Dim CreateStackedArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
        Dim CreateStackedSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
        Dim CreateStepArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStepArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
        Dim ChartControlCommandGalleryItemGroupPoint1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
        Dim CreatePointChartItem1 As DevExpress.XtraCharts.UI.CreatePointChartItem = New DevExpress.XtraCharts.UI.CreatePointChartItem()
        Dim CreateBubbleChartItem1 As DevExpress.XtraCharts.UI.CreateBubbleChartItem = New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
        Dim ChartControlCommandGalleryItemGroupFunnel1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
        Dim CreateFunnelChartItem1 As DevExpress.XtraCharts.UI.CreateFunnelChartItem = New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
        Dim CreateFunnel3DChartItem1 As DevExpress.XtraCharts.UI.CreateFunnel3DChartItem = New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
        Dim ChartControlCommandGalleryItemGroupFinancial1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
        Dim CreateStockChartItem1 As DevExpress.XtraCharts.UI.CreateStockChartItem = New DevExpress.XtraCharts.UI.CreateStockChartItem()
        Dim CreateCandleStickChartItem1 As DevExpress.XtraCharts.UI.CreateCandleStickChartItem = New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
        Dim ChartControlCommandGalleryItemGroupRadar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
        Dim CreateRadarPointChartItem1 As DevExpress.XtraCharts.UI.CreateRadarPointChartItem = New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
        Dim CreateRadarLineChartItem1 As DevExpress.XtraCharts.UI.CreateRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
        Dim CreateRadarAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRadarAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
        Dim CreateRadarRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem()
        Dim CreateScatterRadarLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem()
        Dim ChartControlCommandGalleryItemGroupPolar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
        Dim CreatePolarPointChartItem1 As DevExpress.XtraCharts.UI.CreatePolarPointChartItem = New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
        Dim CreatePolarLineChartItem1 As DevExpress.XtraCharts.UI.CreatePolarLineChartItem = New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
        Dim CreatePolarAreaChartItem1 As DevExpress.XtraCharts.UI.CreatePolarAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
        Dim CreatePolarRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem()
        Dim CreateScatterPolarLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem()
        Dim ChartControlCommandGalleryItemGroupRange1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
        Dim CreateRangeBarChartItem1 As DevExpress.XtraCharts.UI.CreateRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
        Dim CreateSideBySideRangeBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
        Dim CreateRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
        Dim CreateRangeArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem = New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
        Dim ChartControlCommandGalleryItemGroupGantt1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
        Dim CreateGanttChartItem1 As DevExpress.XtraCharts.UI.CreateGanttChartItem = New DevExpress.XtraCharts.UI.CreateGanttChartItem()
        Dim CreateSideBySideGanttChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
        Dim SkinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
        Dim SkinPaddingEdges2 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.transactionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.transactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.ChartTypeBar1 = New DevExpress.XtraCharts.UI.ChartTypeBar()
        Me.CreateBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
        Me.CommandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CreateLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
        Me.CommandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CreatePieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
        Me.CommandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CreateRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
        Me.CommandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CreateAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
        Me.CommandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CreateOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
        Me.CommandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.ChartAppearanceBar1 = New DevExpress.XtraCharts.UI.ChartAppearanceBar()
        Me.ChangePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
        Me.CommandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.ChangeAppearanceGalleryBaseBarManagerItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem()
        Me.CommandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.ChartWizardBar1 = New DevExpress.XtraCharts.UI.ChartWizardBar()
        Me.RunDesignerChartItem1 = New DevExpress.XtraCharts.UI.RunDesignerChartItem()
        Me.ChartTemplatesBar1 = New DevExpress.XtraCharts.UI.ChartTemplatesBar()
        Me.SaveAsTemplateChartItem1 = New DevExpress.XtraCharts.UI.SaveAsTemplateChartItem()
        Me.LoadTemplateChartItem1 = New DevExpress.XtraCharts.UI.LoadTemplateChartItem()
        Me.ChartPrintExportBar1 = New DevExpress.XtraCharts.UI.ChartPrintExportBar()
        Me.PrintPreviewChartItem1 = New DevExpress.XtraCharts.UI.PrintPreviewChartItem()
        Me.PrintChartItem1 = New DevExpress.XtraCharts.UI.PrintChartItem()
        Me.CreateExportBaseItem1 = New DevExpress.XtraCharts.UI.CreateExportBaseItem()
        Me.ExportToPDFChartItem1 = New DevExpress.XtraCharts.UI.ExportToPDFChartItem()
        Me.ExportToHTMLChartItem1 = New DevExpress.XtraCharts.UI.ExportToHTMLChartItem()
        Me.ExportToMHTChartItem1 = New DevExpress.XtraCharts.UI.ExportToMHTChartItem()
        Me.ExportToXLSChartItem1 = New DevExpress.XtraCharts.UI.ExportToXLSChartItem()
        Me.ExportToXLSXChartItem1 = New DevExpress.XtraCharts.UI.ExportToXLSXChartItem()
        Me.ExportToRTFChartItem1 = New DevExpress.XtraCharts.UI.ExportToRTFChartItem()
        Me.CreateExportToImageBaseItem1 = New DevExpress.XtraCharts.UI.CreateExportToImageBaseItem()
        Me.ExportToBMPChartItem1 = New DevExpress.XtraCharts.UI.ExportToBMPChartItem()
        Me.ExportToGIFChartItem1 = New DevExpress.XtraCharts.UI.ExportToGIFChartItem()
        Me.ExportToJPEGChartItem1 = New DevExpress.XtraCharts.UI.ExportToJPEGChartItem()
        Me.ExportToPNGChartItem1 = New DevExpress.XtraCharts.UI.ExportToPNGChartItem()
        Me.ExportToTIFFChartItem1 = New DevExpress.XtraCharts.UI.ExportToTIFFChartItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ChartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transactionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        Me.ChartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.transactionsBindingSource1
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
        Me.ChartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
        Me.ChartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 26)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "product_name"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "stn_name"
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Sum_quantity"
        BarGrowUpAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.5000000")
        BarGrowUpAnimation1.Duration = System.TimeSpan.Parse("00:00:02.5000000")
        BarGrowUpAnimation1.EasingFunction = BounceEasingFunction1
        BarGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
        SideBySideBarSeriesView1.Animation = BarGrowUpAnimation1
        Me.ChartControl1.SeriesTemplate.View = SideBySideBarSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(1089, 455)
        Me.ChartControl1.TabIndex = 0
        '
        'transactionsBindingSource1
        '
        Me.transactionsBindingSource1.DataMember = "transactions"
        Me.transactionsBindingSource1.DataSource = Me.SqlDataSource1
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "HO_DATAConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "date"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""1426"" />"
        Table1.Name = "transactions"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        Column2.Alias = "Sum_quantity"
        ColumnExpression2.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum
        ColumnExpression2.ColumnName = "quantity"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "product_name"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "stn_name"
        Table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""875"" />"
        Table2.Name = "stations"
        ColumnExpression4.Table = Table2
        Column4.Expression = ColumnExpression4
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.FilterString = "[transactions.date] = ?Parameter1 And [transactions.product_code] Between(1, 2) A" &
    "nd [transactions.type] In (?Parameter2)"
        SelectQuery1.GroupFilterString = ""
        ColumnExpression5.ColumnName = "date"
        ColumnExpression5.Table = Table1
        Group1.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "product_name"
        ColumnExpression6.Table = Table1
        Group2.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "stn_name"
        ColumnExpression7.Table = Table2
        Group3.Expression = ColumnExpression7
        SelectQuery1.Groups.Add(Group1)
        SelectQuery1.Groups.Add(Group2)
        SelectQuery1.Groups.Add(Group3)
        SelectQuery1.Name = "transactions"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("TODAY()", GetType(Date))
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(String)
        SelectQuery1.Parameters.Add(QueryParameter1)
        SelectQuery1.Parameters.Add(QueryParameter2)
        RelationColumnInfo1.NestedKeyColumn = "stn_id"
        RelationColumnInfo1.ParentKeyColumn = "stn_id"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Join1.Nested = Table2
        Join1.Parent = Table1
        SelectQuery1.Relations.Add(Join1)
        Sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
        ColumnExpression8.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum
        ColumnExpression8.ColumnName = "quantity"
        ColumnExpression8.Table = Table1
        Sorting1.Expression = ColumnExpression8
        SelectQuery1.Sorting.Add(Sorting1)
        SelectQuery1.Tables.Add(Table1)
        SelectQuery1.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'transactionsBindingSource
        '
        Me.transactionsBindingSource.DataMember = "transactions"
        Me.transactionsBindingSource.DataSource = Me.SqlDataSource1
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.ChartTypeBar1, Me.ChartAppearanceBar1, Me.ChartWizardBar1, Me.ChartTemplatesBar1, Me.ChartPrintExportBar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CreateBarBaseItem1, Me.CreateLineBaseItem1, Me.CreatePieBaseItem1, Me.CreateRotatedBarBaseItem1, Me.CreateAreaBaseItem1, Me.CreateOtherSeriesTypesBaseItem1, Me.ChangePaletteGalleryBaseItem1, Me.ChangeAppearanceGalleryBaseBarManagerItem1, Me.RunDesignerChartItem1, Me.SaveAsTemplateChartItem1, Me.LoadTemplateChartItem1, Me.PrintPreviewChartItem1, Me.PrintChartItem1, Me.CreateExportBaseItem1, Me.ExportToPDFChartItem1, Me.ExportToHTMLChartItem1, Me.ExportToMHTChartItem1, Me.ExportToXLSChartItem1, Me.ExportToXLSXChartItem1, Me.ExportToRTFChartItem1, Me.ExportToBMPChartItem1, Me.ExportToGIFChartItem1, Me.ExportToJPEGChartItem1, Me.ExportToPNGChartItem1, Me.ExportToTIFFChartItem1, Me.CreateExportToImageBaseItem1})
        Me.BarManager1.MaxItemId = 26
        '
        'ChartTypeBar1
        '
        Me.ChartTypeBar1.Control = Me.ChartControl1
        Me.ChartTypeBar1.DockCol = 3
        Me.ChartTypeBar1.DockRow = 0
        Me.ChartTypeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ChartTypeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CreateBarBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateLineBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreatePieBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateRotatedBarBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateAreaBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateOtherSeriesTypesBaseItem1)})
        '
        'CreateBarBaseItem1
        '
        Me.CreateBarBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown1
        Me.CreateBarBaseItem1.Id = 0
        Me.CreateBarBaseItem1.Name = "CreateBarBaseItem1"
        '
        'CommandBarGalleryDropDown1
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown1.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown1.Gallery.ColumnCount = 4
        ChartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBarChartItem1, CreateFullStackedBarChartItem1, CreateSideBySideFullStackedBarChartItem1, CreateSideBySideStackedBarChartItem1, CreateStackedBarChartItem1})
        ChartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBar3DChartItem1, CreateFullStackedBar3DChartItem1, CreateManhattanBarChartItem1, CreateSideBySideFullStackedBar3DChartItem1, CreateSideBySideStackedBar3DChartItem1, CreateStackedBar3DChartItem1})
        ChartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateCylinderBar3DChartItem1, CreateCylinderFullStackedBar3DChartItem1, CreateCylinderManhattanBarChartItem1, CreateCylinderSideBySideFullStackedBar3DChartItem1, CreateCylinderSideBySideStackedBar3DChartItem1, CreateCylinderStackedBar3DChartItem1})
        ChartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateConeBar3DChartItem1, CreateConeFullStackedBar3DChartItem1, CreateConeManhattanBarChartItem1, CreateConeSideBySideFullStackedBar3DChartItem1, CreateConeSideBySideStackedBar3DChartItem1, CreateConeStackedBar3DChartItem1})
        ChartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePyramidBar3DChartItem1, CreatePyramidFullStackedBar3DChartItem1, CreatePyramidManhattanBarChartItem1, CreatePyramidSideBySideFullStackedBar3DChartItem1, CreatePyramidSideBySideStackedBar3DChartItem1, CreatePyramidStackedBar3DChartItem1})
        Me.CommandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DColumn1, ChartControlCommandGalleryItemGroup3DColumn1, ChartControlCommandGalleryItemGroupCylinderColumn1, ChartControlCommandGalleryItemGroupConeColumn1, ChartControlCommandGalleryItemGroupPyramidColumn1})
        Me.CommandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.CommandBarGalleryDropDown1.Gallery.RowCount = 10
        Me.CommandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown1.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown1.Name = "CommandBarGalleryDropDown1"
        '
        'CreateLineBaseItem1
        '
        Me.CreateLineBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown2
        Me.CreateLineBaseItem1.Id = 1
        Me.CreateLineBaseItem1.Name = "CreateLineBaseItem1"
        '
        'CommandBarGalleryDropDown2
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown2.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown2.Gallery.ColumnCount = 3
        ChartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLineChartItem1, CreateFullStackedLineChartItem1, CreateScatterLineChartItem1, CreateSplineChartItem1, CreateStackedLineChartItem1, CreateStepLineChartItem1})
        ChartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLine3DChartItem1, CreateFullStackedLine3DChartItem1, CreateSpline3DChartItem1, CreateStackedLine3DChartItem1, CreateStepLine3DChartItem1})
        Me.CommandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DLine1, ChartControlCommandGalleryItemGroup3DLine1})
        Me.CommandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.CommandBarGalleryDropDown2.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown2.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown2.Name = "CommandBarGalleryDropDown2"
        '
        'CreatePieBaseItem1
        '
        Me.CreatePieBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown3
        Me.CreatePieBaseItem1.Id = 2
        Me.CreatePieBaseItem1.Name = "CreatePieBaseItem1"
        '
        'CommandBarGalleryDropDown3
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown3.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown3.Gallery.ColumnCount = 3
        ChartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePieChartItem1, CreateDoughnutChartItem1, CreateNestedDoughnutChartItem1})
        ChartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePie3DChartItem1, CreateDoughnut3DChartItem1})
        Me.CommandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DPie1, ChartControlCommandGalleryItemGroup3DPie1})
        Me.CommandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.CommandBarGalleryDropDown3.Gallery.RowCount = 2
        Me.CommandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown3.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown3.Name = "CommandBarGalleryDropDown3"
        '
        'CreateRotatedBarBaseItem1
        '
        Me.CreateRotatedBarBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown4
        Me.CreateRotatedBarBaseItem1.Id = 3
        Me.CreateRotatedBarBaseItem1.Name = "CreateRotatedBarBaseItem1"
        '
        'CommandBarGalleryDropDown4
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown4.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown4.Gallery.ColumnCount = 3
        ChartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRotatedBarChartItem1, CreateRotatedFullStackedBarChartItem1, CreateRotatedSideBySideFullStackedBarChartItem1, CreateRotatedSideBySideStackedBarChartItem1, CreateRotatedStackedBarChartItem1})
        Me.CommandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DBar1})
        Me.CommandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.CommandBarGalleryDropDown4.Gallery.RowCount = 2
        Me.CommandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown4.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown4.Name = "CommandBarGalleryDropDown4"
        '
        'CreateAreaBaseItem1
        '
        Me.CreateAreaBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown5
        Me.CreateAreaBaseItem1.Id = 4
        Me.CreateAreaBaseItem1.Name = "CreateAreaBaseItem1"
        '
        'CommandBarGalleryDropDown5
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown5.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown5.Gallery.ColumnCount = 4
        ChartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateAreaChartItem1, CreateFullStackedAreaChartItem1, CreateFullStackedSplineAreaChartItem1, CreateFullStackedStepAreaChartItem1, CreateSplineAreaChartItem1, CreateStackedAreaChartItem1, CreateStackedStepAreaChartItem1, CreateStackedSplineAreaChartItem1, CreateStepAreaChartItem1})
        ChartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateArea3DChartItem1, CreateFullStackedArea3DChartItem1, CreateFullStackedSplineArea3DChartItem1, CreateSplineArea3DChartItem1, CreateStackedArea3DChartItem1, CreateStackedSplineArea3DChartItem1, CreateStepArea3DChartItem1})
        Me.CommandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DArea1, ChartControlCommandGalleryItemGroup3DArea1})
        Me.CommandBarGalleryDropDown5.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.CommandBarGalleryDropDown5.Gallery.RowCount = 5
        Me.CommandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown5.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown5.Name = "CommandBarGalleryDropDown5"
        '
        'CreateOtherSeriesTypesBaseItem1
        '
        Me.CreateOtherSeriesTypesBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown6
        Me.CreateOtherSeriesTypesBaseItem1.Id = 5
        Me.CreateOtherSeriesTypesBaseItem1.Name = "CreateOtherSeriesTypesBaseItem1"
        '
        'CommandBarGalleryDropDown6
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown6.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown6.Gallery.ColumnCount = 4
        ChartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePointChartItem1, CreateBubbleChartItem1})
        ChartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateFunnelChartItem1, CreateFunnel3DChartItem1})
        ChartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateStockChartItem1, CreateCandleStickChartItem1})
        ChartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRadarPointChartItem1, CreateRadarLineChartItem1, CreateRadarAreaChartItem1, CreateRadarRangeAreaChartItem1, CreateScatterRadarLineChartItem1})
        ChartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePolarPointChartItem1, CreatePolarLineChartItem1, CreatePolarAreaChartItem1, CreatePolarRangeAreaChartItem1, CreateScatterPolarLineChartItem1})
        ChartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRangeBarChartItem1, CreateSideBySideRangeBarChartItem1, CreateRangeAreaChartItem1, CreateRangeArea3DChartItem1})
        ChartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateGanttChartItem1, CreateSideBySideGanttChartItem1})
        Me.CommandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroupPoint1, ChartControlCommandGalleryItemGroupFunnel1, ChartControlCommandGalleryItemGroupFinancial1, ChartControlCommandGalleryItemGroupRadar1, ChartControlCommandGalleryItemGroupPolar1, ChartControlCommandGalleryItemGroupRange1, ChartControlCommandGalleryItemGroupGantt1})
        Me.CommandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.CommandBarGalleryDropDown6.Gallery.RowCount = 9
        Me.CommandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown6.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown6.Name = "CommandBarGalleryDropDown6"
        '
        'ChartAppearanceBar1
        '
        Me.ChartAppearanceBar1.Control = Me.ChartControl1
        Me.ChartAppearanceBar1.DockCol = 4
        Me.ChartAppearanceBar1.DockRow = 0
        Me.ChartAppearanceBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ChartAppearanceBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ChangePaletteGalleryBaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ChangeAppearanceGalleryBaseBarManagerItem1)})
        '
        'ChangePaletteGalleryBaseItem1
        '
        Me.ChangePaletteGalleryBaseItem1.DropDownControl = Me.CommandBarGalleryDropDown7
        Me.ChangePaletteGalleryBaseItem1.Id = 6
        Me.ChangePaletteGalleryBaseItem1.Name = "ChangePaletteGalleryBaseItem1"
        '
        'CommandBarGalleryDropDown7
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown7.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
        Me.CommandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CommandBarGalleryDropDown7.Gallery.ColumnCount = 1
        Me.CommandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(160, 10)
        Me.CommandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.CommandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
        SkinPaddingEdges1.Bottom = -3
        SkinPaddingEdges1.Top = -3
        Me.CommandBarGalleryDropDown7.Gallery.ItemImagePadding = SkinPaddingEdges1
        SkinPaddingEdges2.Bottom = -3
        SkinPaddingEdges2.Top = -3
        Me.CommandBarGalleryDropDown7.Gallery.ItemTextPadding = SkinPaddingEdges2
        Me.CommandBarGalleryDropDown7.Gallery.RowCount = 10
        Me.CommandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown7.Gallery.ShowItemText = True
        Me.CommandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown7.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown7.Name = "CommandBarGalleryDropDown7"
        '
        'ChangeAppearanceGalleryBaseBarManagerItem1
        '
        Me.ChangeAppearanceGalleryBaseBarManagerItem1.DropDownControl = Me.CommandBarGalleryDropDown8
        Me.ChangeAppearanceGalleryBaseBarManagerItem1.Id = 7
        Me.ChangeAppearanceGalleryBaseBarManagerItem1.Name = "ChangeAppearanceGalleryBaseBarManagerItem1"
        '
        'CommandBarGalleryDropDown8
        '
        '
        '
        '
        Me.CommandBarGalleryDropDown8.Gallery.AllowFilter = False
        Me.CommandBarGalleryDropDown8.Gallery.ColumnCount = 7
        Me.CommandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(80, 50)
        Me.CommandBarGalleryDropDown8.Gallery.RowCount = 4
        Me.CommandBarGalleryDropDown8.Gallery.ShowGroupCaption = False
        Me.CommandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.[Auto]
        Me.CommandBarGalleryDropDown8.Manager = Me.BarManager1
        Me.CommandBarGalleryDropDown8.Name = "CommandBarGalleryDropDown8"
        '
        'ChartWizardBar1
        '
        Me.ChartWizardBar1.Control = Me.ChartControl1
        Me.ChartWizardBar1.DockCol = 2
        Me.ChartWizardBar1.DockRow = 0
        Me.ChartWizardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ChartWizardBar1.FloatLocation = New System.Drawing.Point(661, 181)
        Me.ChartWizardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.RunDesignerChartItem1)})
        Me.ChartWizardBar1.Offset = 25
        '
        'RunDesignerChartItem1
        '
        Me.RunDesignerChartItem1.Id = 8
        Me.RunDesignerChartItem1.Name = "RunDesignerChartItem1"
        '
        'ChartTemplatesBar1
        '
        Me.ChartTemplatesBar1.Control = Me.ChartControl1
        Me.ChartTemplatesBar1.DockCol = 1
        Me.ChartTemplatesBar1.DockRow = 0
        Me.ChartTemplatesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ChartTemplatesBar1.FloatLocation = New System.Drawing.Point(509, 141)
        Me.ChartTemplatesBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SaveAsTemplateChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.LoadTemplateChartItem1)})
        Me.ChartTemplatesBar1.Offset = 36
        '
        'SaveAsTemplateChartItem1
        '
        Me.SaveAsTemplateChartItem1.Id = 9
        Me.SaveAsTemplateChartItem1.Name = "SaveAsTemplateChartItem1"
        '
        'LoadTemplateChartItem1
        '
        Me.LoadTemplateChartItem1.Id = 10
        Me.LoadTemplateChartItem1.Name = "LoadTemplateChartItem1"
        '
        'ChartPrintExportBar1
        '
        Me.ChartPrintExportBar1.Control = Me.ChartControl1
        Me.ChartPrintExportBar1.DockCol = 0
        Me.ChartPrintExportBar1.DockRow = 0
        Me.ChartPrintExportBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ChartPrintExportBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPreviewChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateExportBaseItem1)})
        '
        'PrintPreviewChartItem1
        '
        Me.PrintPreviewChartItem1.Id = 11
        Me.PrintPreviewChartItem1.Name = "PrintPreviewChartItem1"
        '
        'PrintChartItem1
        '
        Me.PrintChartItem1.Id = 12
        Me.PrintChartItem1.Name = "PrintChartItem1"
        '
        'CreateExportBaseItem1
        '
        Me.CreateExportBaseItem1.Id = 13
        Me.CreateExportBaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToPDFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToHTMLChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToMHTChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToXLSChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToXLSXChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToRTFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CreateExportToImageBaseItem1)})
        Me.CreateExportBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
        Me.CreateExportBaseItem1.Name = "CreateExportBaseItem1"
        '
        'ExportToPDFChartItem1
        '
        Me.ExportToPDFChartItem1.Id = 14
        Me.ExportToPDFChartItem1.Name = "ExportToPDFChartItem1"
        '
        'ExportToHTMLChartItem1
        '
        Me.ExportToHTMLChartItem1.Id = 15
        Me.ExportToHTMLChartItem1.Name = "ExportToHTMLChartItem1"
        '
        'ExportToMHTChartItem1
        '
        Me.ExportToMHTChartItem1.Id = 16
        Me.ExportToMHTChartItem1.Name = "ExportToMHTChartItem1"
        '
        'ExportToXLSChartItem1
        '
        Me.ExportToXLSChartItem1.Id = 17
        Me.ExportToXLSChartItem1.Name = "ExportToXLSChartItem1"
        '
        'ExportToXLSXChartItem1
        '
        Me.ExportToXLSXChartItem1.Id = 18
        Me.ExportToXLSXChartItem1.Name = "ExportToXLSXChartItem1"
        '
        'ExportToRTFChartItem1
        '
        Me.ExportToRTFChartItem1.Id = 19
        Me.ExportToRTFChartItem1.Name = "ExportToRTFChartItem1"
        '
        'CreateExportToImageBaseItem1
        '
        Me.CreateExportToImageBaseItem1.Id = 20
        Me.CreateExportToImageBaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToBMPChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToGIFChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToJPEGChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToPNGChartItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportToTIFFChartItem1)})
        Me.CreateExportToImageBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
        Me.CreateExportToImageBaseItem1.Name = "CreateExportToImageBaseItem1"
        '
        'ExportToBMPChartItem1
        '
        Me.ExportToBMPChartItem1.Id = 21
        Me.ExportToBMPChartItem1.Name = "ExportToBMPChartItem1"
        '
        'ExportToGIFChartItem1
        '
        Me.ExportToGIFChartItem1.Id = 22
        Me.ExportToGIFChartItem1.Name = "ExportToGIFChartItem1"
        '
        'ExportToJPEGChartItem1
        '
        Me.ExportToJPEGChartItem1.Id = 23
        Me.ExportToJPEGChartItem1.Name = "ExportToJPEGChartItem1"
        '
        'ExportToPNGChartItem1
        '
        Me.ExportToPNGChartItem1.Id = 24
        Me.ExportToPNGChartItem1.Name = "ExportToPNGChartItem1"
        '
        'ExportToTIFFChartItem1
        '
        Me.ExportToTIFFChartItem1.Id = 25
        Me.ExportToTIFFChartItem1.Name = "ExportToTIFFChartItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1089, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 481)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1089, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 455)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1089, 26)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 455)
        '
        'ChartBarController1
        '
        Me.ChartBarController1.BarItems.Add(Me.CreateBarBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreateLineBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreatePieBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreateRotatedBarBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreateAreaBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreateOtherSeriesTypesBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.ChangePaletteGalleryBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.ChangeAppearanceGalleryBaseBarManagerItem1)
        Me.ChartBarController1.BarItems.Add(Me.RunDesignerChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.SaveAsTemplateChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.LoadTemplateChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.PrintPreviewChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.PrintChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreateExportBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToPDFChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToHTMLChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToMHTChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToXLSChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToXLSXChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToRTFChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.CreateExportToImageBaseItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToBMPChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToGIFChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToJPEGChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToPNGChartItem1)
        Me.ChartBarController1.BarItems.Add(Me.ExportToTIFFChartItem1)
        Me.ChartBarController1.Control = Me.ChartControl1
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(780, 5)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"All", "CSTMR", "ATNDT"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBoxEdit1.TabIndex = 5
        '
        'OrpakStationSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 481)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "OrpakStationSales"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "المبيعات اليومية"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transactionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents transactionsBindingSource As BindingSource
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents transactionsBindingSource1 As BindingSource
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents ChartTypeBar1 As DevExpress.XtraCharts.UI.ChartTypeBar
    Friend WithEvents CreateBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
    Friend WithEvents CommandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CreateLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
    Friend WithEvents CommandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CreatePieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
    Friend WithEvents CommandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CreateRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
    Friend WithEvents CommandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CreateAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
    Friend WithEvents CommandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CreateOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
    Friend WithEvents CommandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents ChartAppearanceBar1 As DevExpress.XtraCharts.UI.ChartAppearanceBar
    Friend WithEvents ChangePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
    Friend WithEvents CommandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents ChangeAppearanceGalleryBaseBarManagerItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem
    Friend WithEvents CommandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents ChartWizardBar1 As DevExpress.XtraCharts.UI.ChartWizardBar
    Friend WithEvents RunDesignerChartItem1 As DevExpress.XtraCharts.UI.RunDesignerChartItem
    Friend WithEvents ChartTemplatesBar1 As DevExpress.XtraCharts.UI.ChartTemplatesBar
    Friend WithEvents SaveAsTemplateChartItem1 As DevExpress.XtraCharts.UI.SaveAsTemplateChartItem
    Friend WithEvents LoadTemplateChartItem1 As DevExpress.XtraCharts.UI.LoadTemplateChartItem
    Friend WithEvents ChartPrintExportBar1 As DevExpress.XtraCharts.UI.ChartPrintExportBar
    Friend WithEvents PrintPreviewChartItem1 As DevExpress.XtraCharts.UI.PrintPreviewChartItem
    Friend WithEvents PrintChartItem1 As DevExpress.XtraCharts.UI.PrintChartItem
    Friend WithEvents CreateExportBaseItem1 As DevExpress.XtraCharts.UI.CreateExportBaseItem
    Friend WithEvents ExportToPDFChartItem1 As DevExpress.XtraCharts.UI.ExportToPDFChartItem
    Friend WithEvents ExportToHTMLChartItem1 As DevExpress.XtraCharts.UI.ExportToHTMLChartItem
    Friend WithEvents ExportToMHTChartItem1 As DevExpress.XtraCharts.UI.ExportToMHTChartItem
    Friend WithEvents ExportToXLSChartItem1 As DevExpress.XtraCharts.UI.ExportToXLSChartItem
    Friend WithEvents ExportToXLSXChartItem1 As DevExpress.XtraCharts.UI.ExportToXLSXChartItem
    Friend WithEvents ExportToRTFChartItem1 As DevExpress.XtraCharts.UI.ExportToRTFChartItem
    Friend WithEvents CreateExportToImageBaseItem1 As DevExpress.XtraCharts.UI.CreateExportToImageBaseItem
    Friend WithEvents ExportToBMPChartItem1 As DevExpress.XtraCharts.UI.ExportToBMPChartItem
    Friend WithEvents ExportToGIFChartItem1 As DevExpress.XtraCharts.UI.ExportToGIFChartItem
    Friend WithEvents ExportToJPEGChartItem1 As DevExpress.XtraCharts.UI.ExportToJPEGChartItem
    Friend WithEvents ExportToPNGChartItem1 As DevExpress.XtraCharts.UI.ExportToPNGChartItem
    Friend WithEvents ExportToTIFFChartItem1 As DevExpress.XtraCharts.UI.ExportToTIFFChartItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ChartBarController1 As DevExpress.XtraCharts.UI.ChartBarController
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
End Class
