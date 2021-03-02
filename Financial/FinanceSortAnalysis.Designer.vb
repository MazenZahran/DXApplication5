<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceSortAnalysis
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceSortAnalysis))
        Dim ChartControlCommandGalleryItemGroup2DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
        Dim CreateBarChartItem1 As DevExpress.XtraCharts.UI.CreateBarChartItem = New DevExpress.XtraCharts.UI.CreateBarChartItem()
        Dim CreateFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
        Dim CreateSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
        Dim CreateSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
        Dim CreateStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
        Dim CreateWaterfallChartItem1 As DevExpress.XtraCharts.UI.CreateWaterfallChartItem = New DevExpress.XtraCharts.UI.CreateWaterfallChartItem()
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
        Dim ChartControlCommandGalleryItemGroupBoxPlot1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupBoxPlot = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupBoxPlot()
        Dim CreateBoxPlotChartItem1 As DevExpress.XtraCharts.UI.CreateBoxPlotChartItem = New DevExpress.XtraCharts.UI.CreateBoxPlotChartItem()
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim ChangePaletteGalleryItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem2 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem3 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem4 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem5 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem6 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem7 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem8 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem9 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem10 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem11 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem12 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem13 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem14 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem15 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem16 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem17 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem18 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem19 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem20 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem21 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem22 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem23 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem24 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem25 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem26 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem27 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem28 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem29 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem30 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem31 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem32 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem33 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem34 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem35 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem36 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem37 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem38 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem39 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem40 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem41 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem42 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem43 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem44 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem45 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem46 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem47 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem48 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Dim ChangePaletteGalleryItem49 As DevExpress.XtraCharts.UI.ChangePaletteGalleryItem = New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.TextYear = New DevExpress.XtraEditors.TextEdit()
        Me.TextMonth = New DevExpress.XtraEditors.TextEdit()
        Me.TextSortTo = New DevExpress.XtraEditors.TextEdit()
        Me.TextSortFrom = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDebitBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colASORTGROUP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACSORTCODENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SqlDataSource2 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ChartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController(Me.components)
        Me.CommandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.TextYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSortTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSortFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("576fa9b8-7d85-4a11-bea1-2a274eb594dc")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 578)
        Me.DockPanel1.Text = "خيارات التقرير"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 549)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.TextYear)
        Me.LayoutControl2.Controls.Add(Me.TextMonth)
        Me.LayoutControl2.Controls.Add(Me.TextSortTo)
        Me.LayoutControl2.Controls.Add(Me.TextSortFrom)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(193, 549)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'TextYear
        '
        Me.TextYear.Location = New System.Drawing.Point(12, 36)
        Me.TextYear.Name = "TextYear"
        Me.TextYear.Size = New System.Drawing.Size(116, 20)
        Me.TextYear.StyleController = Me.LayoutControl2
        Me.TextYear.TabIndex = 8
        '
        'TextMonth
        '
        Me.TextMonth.Location = New System.Drawing.Point(12, 12)
        Me.TextMonth.Name = "TextMonth"
        Me.TextMonth.Size = New System.Drawing.Size(116, 20)
        Me.TextMonth.StyleController = Me.LayoutControl2
        Me.TextMonth.TabIndex = 7
        '
        'TextSortTo
        '
        Me.TextSortTo.Location = New System.Drawing.Point(12, 84)
        Me.TextSortTo.Name = "TextSortTo"
        Me.TextSortTo.Size = New System.Drawing.Size(116, 20)
        Me.TextSortTo.StyleController = Me.LayoutControl2
        Me.TextSortTo.TabIndex = 6
        '
        'TextSortFrom
        '
        Me.TextSortFrom.Location = New System.Drawing.Point(12, 60)
        Me.TextSortFrom.Name = "TextSortFrom"
        Me.TextSortFrom.Size = New System.Drawing.Size(116, 20)
        Me.TextSortFrom.StyleController = Me.LayoutControl2
        Me.TextSortFrom.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 108)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(169, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "تحديث"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(193, 549)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 122)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 407)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextSortFrom
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem4.Text = "من تصنيف"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TextSortTo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem5.Text = "الى تصنيف"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TextMonth
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem6.Text = "الشهر"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextYear
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem7.Text = "السنة"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ChartControl1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(679, 578)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ChartControl1
        '
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(12, 280)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(655, 286)
        Me.ChartControl1.TabIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(655, 264)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDebitBalance, Me.colASORTGROUP, Me.colACSORTCODENAME})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDebitBalance
        '
        Me.colDebitBalance.Caption = "المبلغ"
        Me.colDebitBalance.DisplayFormat.FormatString = "N0"
        Me.colDebitBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDebitBalance.FieldName = "DebitBalance"
        Me.colDebitBalance.Name = "colDebitBalance"
        Me.colDebitBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DebitBalance", "{0:N0}")})
        Me.colDebitBalance.Visible = True
        Me.colDebitBalance.VisibleIndex = 2
        '
        'colASORTGROUP
        '
        Me.colASORTGROUP.Caption = "رقم التصنيف"
        Me.colASORTGROUP.FieldName = "ASORTGROUP"
        Me.colASORTGROUP.Name = "colASORTGROUP"
        Me.colASORTGROUP.Visible = True
        Me.colASORTGROUP.VisibleIndex = 0
        '
        'colACSORTCODENAME
        '
        Me.colACSORTCODENAME.Caption = "التصنيف"
        Me.colACSORTCODENAME.FieldName = "ACSORTCODENAME"
        Me.colACSORTCODENAME.Name = "colACSORTCODENAME"
        Me.colACSORTCODENAME.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ACSORTCODENAME", "{0}")})
        Me.colACSORTCODENAME.Visible = True
        Me.colACSORTCODENAME.VisibleIndex = 1
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(679, 578)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(659, 268)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChartControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 268)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(659, 290)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionName = "WizcountConnectionString"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource2.ResultSchemaSerializable = resources.GetString("SqlDataSource2.ResultSchemaSerializable")
        '
        'ChartBarController1
        '
        Me.ChartBarController1.Control = Me.ChartControl1
        '
        'CommandBarGalleryDropDown1
        '
        '
        '
        '
        ChartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBarChartItem1, CreateFullStackedBarChartItem1, CreateSideBySideFullStackedBarChartItem1, CreateSideBySideStackedBarChartItem1, CreateStackedBarChartItem1, CreateWaterfallChartItem1})
        ChartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBar3DChartItem1, CreateFullStackedBar3DChartItem1, CreateManhattanBarChartItem1, CreateSideBySideFullStackedBar3DChartItem1, CreateSideBySideStackedBar3DChartItem1, CreateStackedBar3DChartItem1})
        ChartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateCylinderBar3DChartItem1, CreateCylinderFullStackedBar3DChartItem1, CreateCylinderManhattanBarChartItem1, CreateCylinderSideBySideFullStackedBar3DChartItem1, CreateCylinderSideBySideStackedBar3DChartItem1, CreateCylinderStackedBar3DChartItem1})
        ChartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateConeBar3DChartItem1, CreateConeFullStackedBar3DChartItem1, CreateConeManhattanBarChartItem1, CreateConeSideBySideFullStackedBar3DChartItem1, CreateConeSideBySideStackedBar3DChartItem1, CreateConeStackedBar3DChartItem1})
        ChartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePyramidBar3DChartItem1, CreatePyramidFullStackedBar3DChartItem1, CreatePyramidManhattanBarChartItem1, CreatePyramidSideBySideFullStackedBar3DChartItem1, CreatePyramidSideBySideStackedBar3DChartItem1, CreatePyramidStackedBar3DChartItem1})
        Me.CommandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DColumn1, ChartControlCommandGalleryItemGroup3DColumn1, ChartControlCommandGalleryItemGroupCylinderColumn1, ChartControlCommandGalleryItemGroupConeColumn1, ChartControlCommandGalleryItemGroupPyramidColumn1})
        Me.CommandBarGalleryDropDown1.Manager = Nothing
        Me.CommandBarGalleryDropDown1.Name = "CommandBarGalleryDropDown1"
        '
        'CommandBarGalleryDropDown2
        '
        '
        '
        '
        ChartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLineChartItem1, CreateFullStackedLineChartItem1, CreateScatterLineChartItem1, CreateSplineChartItem1, CreateStackedLineChartItem1, CreateStepLineChartItem1})
        ChartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLine3DChartItem1, CreateFullStackedLine3DChartItem1, CreateSpline3DChartItem1, CreateStackedLine3DChartItem1, CreateStepLine3DChartItem1})
        Me.CommandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DLine1, ChartControlCommandGalleryItemGroup3DLine1})
        Me.CommandBarGalleryDropDown2.Manager = Nothing
        Me.CommandBarGalleryDropDown2.Name = "CommandBarGalleryDropDown2"
        '
        'CommandBarGalleryDropDown3
        '
        '
        '
        '
        ChartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePieChartItem1, CreateDoughnutChartItem1, CreateNestedDoughnutChartItem1})
        ChartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePie3DChartItem1, CreateDoughnut3DChartItem1})
        Me.CommandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DPie1, ChartControlCommandGalleryItemGroup3DPie1})
        Me.CommandBarGalleryDropDown3.Manager = Nothing
        Me.CommandBarGalleryDropDown3.Name = "CommandBarGalleryDropDown3"
        '
        'CommandBarGalleryDropDown4
        '
        '
        '
        '
        ChartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRotatedBarChartItem1, CreateRotatedFullStackedBarChartItem1, CreateRotatedSideBySideFullStackedBarChartItem1, CreateRotatedSideBySideStackedBarChartItem1, CreateRotatedStackedBarChartItem1})
        Me.CommandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DBar1})
        Me.CommandBarGalleryDropDown4.Manager = Nothing
        Me.CommandBarGalleryDropDown4.Name = "CommandBarGalleryDropDown4"
        '
        'CommandBarGalleryDropDown5
        '
        '
        '
        '
        ChartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateAreaChartItem1, CreateFullStackedAreaChartItem1, CreateFullStackedSplineAreaChartItem1, CreateFullStackedStepAreaChartItem1, CreateSplineAreaChartItem1, CreateStackedAreaChartItem1, CreateStackedStepAreaChartItem1, CreateStackedSplineAreaChartItem1, CreateStepAreaChartItem1})
        ChartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateArea3DChartItem1, CreateFullStackedArea3DChartItem1, CreateFullStackedSplineArea3DChartItem1, CreateSplineArea3DChartItem1, CreateStackedArea3DChartItem1, CreateStackedSplineArea3DChartItem1, CreateStepArea3DChartItem1})
        Me.CommandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DArea1, ChartControlCommandGalleryItemGroup3DArea1})
        Me.CommandBarGalleryDropDown5.Manager = Nothing
        Me.CommandBarGalleryDropDown5.Name = "CommandBarGalleryDropDown5"
        '
        'CommandBarGalleryDropDown6
        '
        '
        '
        '
        ChartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePointChartItem1, CreateBubbleChartItem1})
        ChartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateFunnelChartItem1, CreateFunnel3DChartItem1})
        ChartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateStockChartItem1, CreateCandleStickChartItem1})
        ChartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRadarPointChartItem1, CreateRadarLineChartItem1, CreateRadarAreaChartItem1, CreateRadarRangeAreaChartItem1, CreateScatterRadarLineChartItem1})
        ChartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePolarPointChartItem1, CreatePolarLineChartItem1, CreatePolarAreaChartItem1, CreatePolarRangeAreaChartItem1, CreateScatterPolarLineChartItem1})
        ChartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRangeBarChartItem1, CreateSideBySideRangeBarChartItem1, CreateRangeAreaChartItem1, CreateRangeArea3DChartItem1})
        ChartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateGanttChartItem1, CreateSideBySideGanttChartItem1})
        ChartControlCommandGalleryItemGroupBoxPlot1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBoxPlotChartItem1})
        Me.CommandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroupPoint1, ChartControlCommandGalleryItemGroupFunnel1, ChartControlCommandGalleryItemGroupFinancial1, ChartControlCommandGalleryItemGroupRadar1, ChartControlCommandGalleryItemGroupPolar1, ChartControlCommandGalleryItemGroupRange1, ChartControlCommandGalleryItemGroupGantt1, ChartControlCommandGalleryItemGroupBoxPlot1})
        Me.CommandBarGalleryDropDown6.Manager = Nothing
        Me.CommandBarGalleryDropDown6.Name = "CommandBarGalleryDropDown6"
        '
        'CommandBarGalleryDropDown7
        '
        '
        '
        '
        ChangePaletteGalleryItem1.Caption = "Apex"
        ChangePaletteGalleryItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ChangePaletteGalleryItem1.Tag = "Apex"
        ChangePaletteGalleryItem2.Caption = "Aspect"
        ChangePaletteGalleryItem2.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ChangePaletteGalleryItem2.Tag = "Aspect"
        ChangePaletteGalleryItem3.Caption = "Black and White"
        ChangePaletteGalleryItem3.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ChangePaletteGalleryItem3.Tag = "Black and White"
        ChangePaletteGalleryItem4.Caption = "Blue"
        ChangePaletteGalleryItem4.ImageOptions.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        ChangePaletteGalleryItem4.Tag = "Blue"
        ChangePaletteGalleryItem5.Caption = "Blue Green"
        ChangePaletteGalleryItem5.ImageOptions.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        ChangePaletteGalleryItem5.Tag = "Blue Green"
        ChangePaletteGalleryItem6.Caption = "Blue II"
        ChangePaletteGalleryItem6.ImageOptions.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        ChangePaletteGalleryItem6.Tag = "Blue II"
        ChangePaletteGalleryItem7.Caption = "Blue Warm"
        ChangePaletteGalleryItem7.ImageOptions.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        ChangePaletteGalleryItem7.Tag = "Blue Warm"
        ChangePaletteGalleryItem8.Caption = "Chameleon"
        ChangePaletteGalleryItem8.ImageOptions.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        ChangePaletteGalleryItem8.Tag = "Chameleon"
        ChangePaletteGalleryItem9.Caption = "Civic"
        ChangePaletteGalleryItem9.ImageOptions.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        ChangePaletteGalleryItem9.Tag = "Civic"
        ChangePaletteGalleryItem10.Caption = "Concourse"
        ChangePaletteGalleryItem10.ImageOptions.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        ChangePaletteGalleryItem10.Tag = "Concourse"
        ChangePaletteGalleryItem11.Caption = "Default"
        ChangePaletteGalleryItem11.Checked = True
        ChangePaletteGalleryItem11.ImageOptions.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        ChangePaletteGalleryItem11.Tag = "Default"
        ChangePaletteGalleryItem12.Caption = "Equity"
        ChangePaletteGalleryItem12.ImageOptions.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
        ChangePaletteGalleryItem12.Tag = "Equity"
        ChangePaletteGalleryItem13.Caption = "Flow"
        ChangePaletteGalleryItem13.ImageOptions.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
        ChangePaletteGalleryItem13.Tag = "Flow"
        ChangePaletteGalleryItem14.Caption = "Foundry"
        ChangePaletteGalleryItem14.ImageOptions.Image = CType(resources.GetObject("resource.Image13"), System.Drawing.Image)
        ChangePaletteGalleryItem14.Tag = "Foundry"
        ChangePaletteGalleryItem15.Caption = "Grayscale"
        ChangePaletteGalleryItem15.ImageOptions.Image = CType(resources.GetObject("resource.Image14"), System.Drawing.Image)
        ChangePaletteGalleryItem15.Tag = "Grayscale"
        ChangePaletteGalleryItem16.Caption = "Green"
        ChangePaletteGalleryItem16.ImageOptions.Image = CType(resources.GetObject("resource.Image15"), System.Drawing.Image)
        ChangePaletteGalleryItem16.Tag = "Green"
        ChangePaletteGalleryItem17.Caption = "Green Yellow"
        ChangePaletteGalleryItem17.ImageOptions.Image = CType(resources.GetObject("resource.Image16"), System.Drawing.Image)
        ChangePaletteGalleryItem17.Tag = "Green Yellow"
        ChangePaletteGalleryItem18.Caption = "In A Fog"
        ChangePaletteGalleryItem18.ImageOptions.Image = CType(resources.GetObject("resource.Image17"), System.Drawing.Image)
        ChangePaletteGalleryItem18.Tag = "In A Fog"
        ChangePaletteGalleryItem19.Caption = "Marquee"
        ChangePaletteGalleryItem19.ImageOptions.Image = CType(resources.GetObject("resource.Image18"), System.Drawing.Image)
        ChangePaletteGalleryItem19.Tag = "Marquee"
        ChangePaletteGalleryItem20.Caption = "Median"
        ChangePaletteGalleryItem20.ImageOptions.Image = CType(resources.GetObject("resource.Image19"), System.Drawing.Image)
        ChangePaletteGalleryItem20.Tag = "Median"
        ChangePaletteGalleryItem21.Caption = "Metro"
        ChangePaletteGalleryItem21.ImageOptions.Image = CType(resources.GetObject("resource.Image20"), System.Drawing.Image)
        ChangePaletteGalleryItem21.Tag = "Metro"
        ChangePaletteGalleryItem22.Caption = "Mixed"
        ChangePaletteGalleryItem22.ImageOptions.Image = CType(resources.GetObject("resource.Image21"), System.Drawing.Image)
        ChangePaletteGalleryItem22.Tag = "Mixed"
        ChangePaletteGalleryItem23.Caption = "Module"
        ChangePaletteGalleryItem23.ImageOptions.Image = CType(resources.GetObject("resource.Image22"), System.Drawing.Image)
        ChangePaletteGalleryItem23.Tag = "Module"
        ChangePaletteGalleryItem24.Caption = "Nature Colors"
        ChangePaletteGalleryItem24.ImageOptions.Image = CType(resources.GetObject("resource.Image23"), System.Drawing.Image)
        ChangePaletteGalleryItem24.Tag = "Nature Colors"
        ChangePaletteGalleryItem25.Caption = "Northern Lights"
        ChangePaletteGalleryItem25.ImageOptions.Image = CType(resources.GetObject("resource.Image24"), System.Drawing.Image)
        ChangePaletteGalleryItem25.Tag = "Northern Lights"
        ChangePaletteGalleryItem26.Caption = "Office"
        ChangePaletteGalleryItem26.ImageOptions.Image = CType(resources.GetObject("resource.Image25"), System.Drawing.Image)
        ChangePaletteGalleryItem26.Tag = "Office"
        ChangePaletteGalleryItem27.Caption = "Office 2013"
        ChangePaletteGalleryItem27.ImageOptions.Image = CType(resources.GetObject("resource.Image26"), System.Drawing.Image)
        ChangePaletteGalleryItem27.Tag = "Office 2013"
        ChangePaletteGalleryItem28.Caption = "Opulent"
        ChangePaletteGalleryItem28.ImageOptions.Image = CType(resources.GetObject("resource.Image27"), System.Drawing.Image)
        ChangePaletteGalleryItem28.Tag = "Opulent"
        ChangePaletteGalleryItem29.Caption = "Orange"
        ChangePaletteGalleryItem29.ImageOptions.Image = CType(resources.GetObject("resource.Image28"), System.Drawing.Image)
        ChangePaletteGalleryItem29.Tag = "Orange"
        ChangePaletteGalleryItem30.Caption = "Orange Red"
        ChangePaletteGalleryItem30.ImageOptions.Image = CType(resources.GetObject("resource.Image29"), System.Drawing.Image)
        ChangePaletteGalleryItem30.Tag = "Orange Red"
        ChangePaletteGalleryItem31.Caption = "Oriel"
        ChangePaletteGalleryItem31.ImageOptions.Image = CType(resources.GetObject("resource.Image30"), System.Drawing.Image)
        ChangePaletteGalleryItem31.Tag = "Oriel"
        ChangePaletteGalleryItem32.Caption = "Origin"
        ChangePaletteGalleryItem32.ImageOptions.Image = CType(resources.GetObject("resource.Image31"), System.Drawing.Image)
        ChangePaletteGalleryItem32.Tag = "Origin"
        ChangePaletteGalleryItem33.Caption = "Paper"
        ChangePaletteGalleryItem33.ImageOptions.Image = CType(resources.GetObject("resource.Image32"), System.Drawing.Image)
        ChangePaletteGalleryItem33.Tag = "Paper"
        ChangePaletteGalleryItem34.Caption = "Pastel Kit"
        ChangePaletteGalleryItem34.ImageOptions.Image = CType(resources.GetObject("resource.Image33"), System.Drawing.Image)
        ChangePaletteGalleryItem34.Tag = "Pastel Kit"
        ChangePaletteGalleryItem35.Caption = "Red"
        ChangePaletteGalleryItem35.ImageOptions.Image = CType(resources.GetObject("resource.Image34"), System.Drawing.Image)
        ChangePaletteGalleryItem35.Tag = "Red"
        ChangePaletteGalleryItem36.Caption = "Red Orange"
        ChangePaletteGalleryItem36.ImageOptions.Image = CType(resources.GetObject("resource.Image35"), System.Drawing.Image)
        ChangePaletteGalleryItem36.Tag = "Red Orange"
        ChangePaletteGalleryItem37.Caption = "Red Violet"
        ChangePaletteGalleryItem37.ImageOptions.Image = CType(resources.GetObject("resource.Image36"), System.Drawing.Image)
        ChangePaletteGalleryItem37.Tag = "Red Violet"
        ChangePaletteGalleryItem38.Caption = "Slipstream"
        ChangePaletteGalleryItem38.ImageOptions.Image = CType(resources.GetObject("resource.Image37"), System.Drawing.Image)
        ChangePaletteGalleryItem38.Tag = "Slipstream"
        ChangePaletteGalleryItem39.Caption = "Solstice"
        ChangePaletteGalleryItem39.ImageOptions.Image = CType(resources.GetObject("resource.Image38"), System.Drawing.Image)
        ChangePaletteGalleryItem39.Tag = "Solstice"
        ChangePaletteGalleryItem40.Caption = "Technic"
        ChangePaletteGalleryItem40.ImageOptions.Image = CType(resources.GetObject("resource.Image39"), System.Drawing.Image)
        ChangePaletteGalleryItem40.Tag = "Technic"
        ChangePaletteGalleryItem41.Caption = "Terracotta Pie"
        ChangePaletteGalleryItem41.ImageOptions.Image = CType(resources.GetObject("resource.Image40"), System.Drawing.Image)
        ChangePaletteGalleryItem41.Tag = "Terracotta Pie"
        ChangePaletteGalleryItem42.Caption = "The Trees"
        ChangePaletteGalleryItem42.ImageOptions.Image = CType(resources.GetObject("resource.Image41"), System.Drawing.Image)
        ChangePaletteGalleryItem42.Tag = "The Trees"
        ChangePaletteGalleryItem43.Caption = "Trek"
        ChangePaletteGalleryItem43.ImageOptions.Image = CType(resources.GetObject("resource.Image42"), System.Drawing.Image)
        ChangePaletteGalleryItem43.Tag = "Trek"
        ChangePaletteGalleryItem44.Caption = "Urban"
        ChangePaletteGalleryItem44.ImageOptions.Image = CType(resources.GetObject("resource.Image43"), System.Drawing.Image)
        ChangePaletteGalleryItem44.Tag = "Urban"
        ChangePaletteGalleryItem45.Caption = "Verve"
        ChangePaletteGalleryItem45.ImageOptions.Image = CType(resources.GetObject("resource.Image44"), System.Drawing.Image)
        ChangePaletteGalleryItem45.Tag = "Verve"
        ChangePaletteGalleryItem46.Caption = "Violet"
        ChangePaletteGalleryItem46.ImageOptions.Image = CType(resources.GetObject("resource.Image45"), System.Drawing.Image)
        ChangePaletteGalleryItem46.Tag = "Violet"
        ChangePaletteGalleryItem47.Caption = "Violet II"
        ChangePaletteGalleryItem47.ImageOptions.Image = CType(resources.GetObject("resource.Image46"), System.Drawing.Image)
        ChangePaletteGalleryItem47.Tag = "Violet II"
        ChangePaletteGalleryItem48.Caption = "Yellow"
        ChangePaletteGalleryItem48.ImageOptions.Image = CType(resources.GetObject("resource.Image47"), System.Drawing.Image)
        ChangePaletteGalleryItem48.Tag = "Yellow"
        ChangePaletteGalleryItem49.Caption = "Yellow Orange"
        ChangePaletteGalleryItem49.ImageOptions.Image = CType(resources.GetObject("resource.Image48"), System.Drawing.Image)
        ChangePaletteGalleryItem49.Tag = "Yellow Orange"
        GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {ChangePaletteGalleryItem1, ChangePaletteGalleryItem2, ChangePaletteGalleryItem3, ChangePaletteGalleryItem4, ChangePaletteGalleryItem5, ChangePaletteGalleryItem6, ChangePaletteGalleryItem7, ChangePaletteGalleryItem8, ChangePaletteGalleryItem9, ChangePaletteGalleryItem10, ChangePaletteGalleryItem11, ChangePaletteGalleryItem12, ChangePaletteGalleryItem13, ChangePaletteGalleryItem14, ChangePaletteGalleryItem15, ChangePaletteGalleryItem16, ChangePaletteGalleryItem17, ChangePaletteGalleryItem18, ChangePaletteGalleryItem19, ChangePaletteGalleryItem20, ChangePaletteGalleryItem21, ChangePaletteGalleryItem22, ChangePaletteGalleryItem23, ChangePaletteGalleryItem24, ChangePaletteGalleryItem25, ChangePaletteGalleryItem26, ChangePaletteGalleryItem27, ChangePaletteGalleryItem28, ChangePaletteGalleryItem29, ChangePaletteGalleryItem30, ChangePaletteGalleryItem31, ChangePaletteGalleryItem32, ChangePaletteGalleryItem33, ChangePaletteGalleryItem34, ChangePaletteGalleryItem35, ChangePaletteGalleryItem36, ChangePaletteGalleryItem37, ChangePaletteGalleryItem38, ChangePaletteGalleryItem39, ChangePaletteGalleryItem40, ChangePaletteGalleryItem41, ChangePaletteGalleryItem42, ChangePaletteGalleryItem43, ChangePaletteGalleryItem44, ChangePaletteGalleryItem45, ChangePaletteGalleryItem46, ChangePaletteGalleryItem47, ChangePaletteGalleryItem48, ChangePaletteGalleryItem49})
        Me.CommandBarGalleryDropDown7.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.CommandBarGalleryDropDown7.Manager = Nothing
        Me.CommandBarGalleryDropDown7.Name = "CommandBarGalleryDropDown7"
        '
        'FinanceSortAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 578)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FinanceSortAnalysis"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقرير تحليلي لتصنيف"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.TextYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSortTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSortFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TextSortTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextSortFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SqlDataSource2 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents colDebitBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colASORTGROUP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACSORTCODENAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents ChartBarController1 As DevExpress.XtraCharts.UI.ChartBarController
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
