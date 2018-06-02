<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrpakCardsQuery
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakCardsQuery))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleDateOccuring1 As DevExpress.XtraEditors.FormatConditionRuleDateOccuring = New DevExpress.XtraEditors.FormatConditionRuleDateOccuring()
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
        Dim QueryParameter7 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter8 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter9 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Sorting2 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Me.Colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collast_used = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Plate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CardCode = New DevExpress.XtraEditors.TextEdit()
        Me.PlatePart = New DevExpress.XtraEditors.TextEdit()
        Me.Card = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfleets_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstring = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmonth_money = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.month_volume = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckActive = New DevExpress.XtraEditors.CheckEdit()
        Me.FleetCode = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlDataSource4 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.SqlDataSource3 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.NavigationPage8 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.TextAvailableCard = New DevExpress.XtraEditors.TextEdit()
        Me.FleetIDText = New DevExpress.XtraEditors.TextEdit()
        Me.TextFleetID = New DevExpress.XtraEditors.TextEdit()
        Me.TextIssueDate = New DevExpress.XtraEditors.TextEdit()
        Me.TextFleetName = New DevExpress.XtraEditors.TextEdit()
        Me.TextLastEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextFleetType = New DevExpress.XtraEditors.TextEdit()
        Me.TextAvailableFleet = New DevExpress.XtraEditors.TextEdit()
        Me.WeekLIT = New DevExpress.XtraEditors.TextEdit()
        Me.TextFleetStatus = New DevExpress.XtraEditors.TextEdit()
        Me.TextLastUsed = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.DelivPersonText = New DevExpress.XtraEditors.TextEdit()
        Me.TextName = New DevExpress.XtraEditors.TextEdit()
        Me.TextDayLit = New DevExpress.XtraEditors.TextEdit()
        Me.TextCstatus = New DevExpress.XtraEditors.TextEdit()
        Me.TextDayMony = New DevExpress.XtraEditors.TextEdit()
        Me.TextCardType = New DevExpress.XtraEditors.TextEdit()
        Me.WeekMony = New DevExpress.XtraEditors.TextEdit()
        Me.TextID = New DevExpress.XtraEditors.TextEdit()
        Me.TextRule = New DevExpress.XtraEditors.TextEdit()
        Me.TextString = New DevExpress.XtraEditors.TextEdit()
        Me.TextPlate = New DevExpress.XtraEditors.TextEdit()
        Me.TextOdometer = New DevExpress.XtraEditors.TextEdit()
        Me.TextMonthNIS = New DevExpress.XtraEditors.TextEdit()
        Me.TextMonthLIT = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl11 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colquantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colppv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colplate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduct_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstn_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpump = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCardName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFleetCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFleetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colodometer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.TextNote = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.TextِAddress = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.TextCountry = New DevExpress.XtraEditors.TextEdit()
        Me.TextFleetID2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.TextSphone = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.TextEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.TextPhone = New DevExpress.XtraEditors.TextEdit()
        Me.TextSort = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.TextFleetName2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextPhax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.TextFilter = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl13 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ALIAS6F = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ALIAS8F = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ALIAS9F = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ALIAS10F = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ALIAS12F_DEB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ALIAS12F_CR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditFrom = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditTo = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.NavigationPage5 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCheqNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankAccNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.CheckButton1 = New DevExpress.XtraEditors.CheckButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.NavigationPage6 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.NavigationPage7 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextYear = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NavigationPage9 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.data = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.field1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.field2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.field6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.field7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.field8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ColtheDayName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.Plate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlatePart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.CheckActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FleetCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextAvailableCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FleetIDText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFleetID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextIssueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFleetName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextLastEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFleetType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextAvailableFleet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekLIT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFleetStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextLastUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelivPersonText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDayLit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextCstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDayMony.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextCardType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekMony.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextRule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPlate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextOdometer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextMonthNIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextMonthLIT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage3.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.TextNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextِAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.TextCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFleetID2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSphone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFleetName2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPhax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage4.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.GridControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage5.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage6.SuspendLayout()
        Me.NavigationPage7.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.TextYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage9.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Colstatus
        '
        Me.Colstatus.Caption = "الحالة"
        Me.Colstatus.FieldName = "status"
        Me.Colstatus.Name = "Colstatus"
        Me.Colstatus.Visible = True
        Me.Colstatus.VisibleIndex = 6
        '
        'collast_used
        '
        Me.collast_used.Caption = "اخر استخدام"
        Me.collast_used.FieldName = "last_used"
        Me.collast_used.Name = "collast_used"
        Me.collast_used.Visible = True
        Me.collast_used.VisibleIndex = 2
        '
        'SplashScreenManager2
        '
        SplashScreenManager2.ClosingDelay = 500
        '
        'Plate
        '
        Me.Plate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Plate.Location = New System.Drawing.Point(6, 35)
        Me.Plate.Name = "Plate"
        Me.Plate.Size = New System.Drawing.Size(157, 20)
        Me.Plate.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(169, 90)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "كود البطاقة"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(168, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "بحث شامل"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(166, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "رقم المركبة"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(167, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "رقم البطاقة"
        '
        'CardCode
        '
        Me.CardCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CardCode.Location = New System.Drawing.Point(6, 83)
        Me.CardCode.Name = "CardCode"
        Me.CardCode.Size = New System.Drawing.Size(157, 20)
        Me.CardCode.TabIndex = 0
        '
        'PlatePart
        '
        Me.PlatePart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlatePart.Location = New System.Drawing.Point(6, 58)
        Me.PlatePart.Name = "PlatePart"
        Me.PlatePart.Size = New System.Drawing.Size(157, 20)
        Me.PlatePart.TabIndex = 0
        '
        'Card
        '
        Me.Card.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Card.EditValue = ""
        Me.Card.Location = New System.Drawing.Point(6, 11)
        Me.Card.Name = "Card"
        Me.Card.Size = New System.Drawing.Size(157, 20)
        Me.Card.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupControl1.Controls.Add(Me.PanelControl6)
        Me.GroupControl1.Controls.Add(Me.PanelControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(1108, 252)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "بيانات البحث"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.GridControl3)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(875, 230)
        Me.PanelControl6.TabIndex = 1
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "means"
        Me.GridControl3.DataSource = Me.SqlDataSource1
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.CardView1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(871, 226)
        Me.GridControl3.TabIndex = 7
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "HO_DATAConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "means"
        QueryParameter1.Name = "PrPlate"
        QueryParameter1.Type = GetType(String)
        QueryParameter2.Name = "PrPlatePart"
        QueryParameter2.Type = GetType(String)
        QueryParameter3.Name = "PrString"
        QueryParameter3.Type = GetType(String)
        QueryParameter4.Name = "PrName"
        QueryParameter4.Type = GetType(String)
        QueryParameter5.Name = "PrCardStatus"
        QueryParameter5.Type = GetType(String)
        QueryParameter6.Name = "PrStatus"
        QueryParameter6.Type = GetType(String)
        CustomSqlQuery1.Parameters.Add(QueryParameter1)
        CustomSqlQuery1.Parameters.Add(QueryParameter2)
        CustomSqlQuery1.Parameters.Add(QueryParameter3)
        CustomSqlQuery1.Parameters.Add(QueryParameter4)
        CustomSqlQuery1.Parameters.Add(QueryParameter5)
        CustomSqlQuery1.Parameters.Add(QueryParameter6)
        CustomSqlQuery1.Sql = Nothing
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'CardView1
        '
        Me.CardView1.Appearance.Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CardView1.Appearance.Card.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CardView1.Appearance.Card.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.CardView1.Appearance.Card.Options.UseBackColor = True
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colname, Me.colplate, Me.colfleets_name, Me.colid, Me.colstring, Me.collast_used, Me.colcode, Me.colmonth_money, Me.month_volume, Me.Description, Me.Colstatus})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.Colstatus
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.PredefinedName = "Red Fill, Red Text"
        FormatConditionRuleValue1.Value1 = "Active"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.collast_used
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleDateOccuring1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        FormatConditionRuleDateOccuring1.Appearance.Options.UseBackColor = True
        FormatConditionRuleDateOccuring1.DateType = CType((DevExpress.XtraEditors.FilterDateType.Yesterday Or DevExpress.XtraEditors.FilterDateType.ThisMonth), DevExpress.XtraEditors.FilterDateType)
        FormatConditionRuleDateOccuring1.PredefinedName = "Green Fill"
        GridFormatRule2.Rule = FormatConditionRuleDateOccuring1
        Me.CardView1.FormatRules.Add(GridFormatRule1)
        Me.CardView1.FormatRules.Add(GridFormatRule2)
        Me.CardView1.GridControl = Me.GridControl3
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsFilter.AllowFilterEditor = False
        Me.CardView1.OptionsFind.AlwaysVisible = True
        Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
        '
        'colname
        '
        Me.colname.Caption = "رقم البطاقة"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        '
        'colplate
        '
        Me.colplate.Caption = "رقم المركبة"
        Me.colplate.FieldName = "plate"
        Me.colplate.Name = "colplate"
        Me.colplate.Visible = True
        Me.colplate.VisibleIndex = 1
        '
        'colfleets_name
        '
        Me.colfleets_name.Caption = "الزبون"
        Me.colfleets_name.FieldName = "fleets_name"
        Me.colfleets_name.Name = "colfleets_name"
        '
        'colid
        '
        Me.colid.Caption = "ID"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colstring
        '
        Me.colstring.Caption = "الكود"
        Me.colstring.FieldName = "string"
        Me.colstring.Name = "colstring"
        '
        'colcode
        '
        Me.colcode.Caption = "رقم الزبون"
        Me.colcode.FieldName = "code"
        Me.colcode.Name = "colcode"
        '
        'colmonth_money
        '
        Me.colmonth_money.Caption = "المبلغ الشهري"
        Me.colmonth_money.FieldName = "month_money"
        Me.colmonth_money.Name = "colmonth_money"
        Me.colmonth_money.Visible = True
        Me.colmonth_money.VisibleIndex = 3
        '
        'month_volume
        '
        Me.month_volume.Caption = "تعبئة الشهر لتر"
        Me.month_volume.FieldName = "month_volume"
        Me.month_volume.Name = "month_volume"
        Me.month_volume.Visible = True
        Me.month_volume.VisibleIndex = 4
        '
        'Description
        '
        Me.Description.Caption = "السقف الشهري"
        Me.Description.FieldName = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 5
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Card)
        Me.PanelControl2.Controls.Add(Me.CheckActive)
        Me.PanelControl2.Controls.Add(Me.FleetCode)
        Me.PanelControl2.Controls.Add(Me.PlatePart)
        Me.PanelControl2.Controls.Add(Me.CardCode)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.CheckEdit2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl23)
        Me.PanelControl2.Controls.Add(Me.Plate)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(877, 20)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(229, 230)
        Me.PanelControl2.TabIndex = 0
        '
        'CheckActive
        '
        Me.CheckActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckActive.Location = New System.Drawing.Point(185, 140)
        Me.CheckActive.Name = "CheckActive"
        Me.CheckActive.Properties.Caption = "فعال"
        Me.CheckActive.Size = New System.Drawing.Size(41, 19)
        Me.CheckActive.TabIndex = 3
        '
        'FleetCode
        '
        Me.FleetCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FleetCode.Location = New System.Drawing.Point(6, 109)
        Me.FleetCode.Name = "FleetCode"
        Me.FleetCode.Size = New System.Drawing.Size(157, 20)
        Me.FleetCode.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(57, 132)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(45, 35)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Tag = ""
        Me.SimpleButton3.ToolTip = "يمكنك الضغط على زر F2 "
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit2.Location = New System.Drawing.Point(108, 140)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "بحث بسيط"
        Me.CheckEdit2.Size = New System.Drawing.Size(72, 19)
        Me.CheckEdit2.TabIndex = 3
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.SimpleButton6.Location = New System.Drawing.Point(6, 132)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(45, 35)
        Me.SimpleButton6.TabIndex = 8
        '
        'LabelControl23
        '
        Me.LabelControl23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl23.Location = New System.Drawing.Point(173, 116)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl23.TabIndex = 4
        Me.LabelControl23.Text = "رقم الزبون"
        '
        'SqlDataSource4
        '
        Me.SqlDataSource4.ConnectionName = "WizCountString_ALHUDA_Connection"
        Me.SqlDataSource4.Name = "SqlDataSource4"
        ColumnExpression1.ColumnName = "CheqNumber"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""571"" />"
        Table1.Name = "Cheqs"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "BankAccNum"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "BankNumber"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Branch"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "ValueDate"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "SuF"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Currency"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "Details"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "DepositID"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.FilterString = "[Cheqs.AccKey] = ?PrAccountID And [Cheqs.ValueDate] Between(?Parameter1, ?Paramet" &
    "er2)"
        SelectQuery1.GroupFilterString = ""
        SelectQuery1.Name = "Cheqs"
        QueryParameter7.Name = "PrAccountID"
        QueryParameter7.Type = GetType(Integer)
        QueryParameter7.ValueInfo = "0"
        QueryParameter8.Name = "Parameter1"
        QueryParameter8.Type = GetType(Date)
        QueryParameter8.ValueInfo = "1753-01-01"
        QueryParameter9.Name = "Parameter2"
        QueryParameter9.Type = GetType(Date)
        QueryParameter9.ValueInfo = "1753-01-01"
        SelectQuery1.Parameters.Add(QueryParameter7)
        SelectQuery1.Parameters.Add(QueryParameter8)
        SelectQuery1.Parameters.Add(QueryParameter9)
        Sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
        ColumnExpression10.ColumnName = "ValueDate"
        ColumnExpression10.Table = Table1
        Sorting1.Expression = ColumnExpression10
        Sorting2.Direction = System.ComponentModel.ListSortDirection.Descending
        ColumnExpression11.ColumnName = "SuF"
        ColumnExpression11.Table = Table1
        Sorting2.Expression = ColumnExpression11
        SelectQuery1.Sorting.Add(Sorting1)
        SelectQuery1.Sorting.Add(Sorting2)
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource4.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource4.ResultSchemaSerializable = resources.GetString("SqlDataSource4.ResultSchemaSerializable")
        '
        'SqlDataSource3
        '
        Me.SqlDataSource3.Name = "SqlDataSource3"
        '
        'NavigationPage8
        '
        Me.NavigationPage8.Caption = "NavigationPage8"
        Me.NavigationPage8.Name = "NavigationPage8"
        Me.NavigationPage8.Size = New System.Drawing.Size(1328, 436)
        '
        'NavigationPane1
        '
        Me.NavigationPane1.AllowResize = False
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage3)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage4)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage5)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage6)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage7)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage9)
        Me.NavigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPane1.Location = New System.Drawing.Point(2, 2)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3, Me.NavigationPage4, Me.NavigationPage5, Me.NavigationPage7, Me.NavigationPage9, Me.NavigationPage6})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(1104, 706)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage1
        Me.NavigationPane1.Size = New System.Drawing.Size(1104, 706)
        Me.NavigationPane1.TabIndex = 5
        Me.NavigationPane1.Text = "بحث عن بطاقة / مركبة"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "بيانات البطاقة"
        Me.NavigationPage1.Controls.Add(Me.LayoutControl3)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(969, 646)
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.ListBoxControl1)
        Me.LayoutControl3.Controls.Add(Me.TextAvailableCard)
        Me.LayoutControl3.Controls.Add(Me.FleetIDText)
        Me.LayoutControl3.Controls.Add(Me.TextFleetID)
        Me.LayoutControl3.Controls.Add(Me.TextIssueDate)
        Me.LayoutControl3.Controls.Add(Me.TextFleetName)
        Me.LayoutControl3.Controls.Add(Me.TextLastEdit)
        Me.LayoutControl3.Controls.Add(Me.TextFleetType)
        Me.LayoutControl3.Controls.Add(Me.TextAvailableFleet)
        Me.LayoutControl3.Controls.Add(Me.WeekLIT)
        Me.LayoutControl3.Controls.Add(Me.TextFleetStatus)
        Me.LayoutControl3.Controls.Add(Me.TextLastUsed)
        Me.LayoutControl3.Controls.Add(Me.TextEdit1)
        Me.LayoutControl3.Controls.Add(Me.DelivPersonText)
        Me.LayoutControl3.Controls.Add(Me.TextName)
        Me.LayoutControl3.Controls.Add(Me.TextDayLit)
        Me.LayoutControl3.Controls.Add(Me.TextCstatus)
        Me.LayoutControl3.Controls.Add(Me.TextDayMony)
        Me.LayoutControl3.Controls.Add(Me.TextCardType)
        Me.LayoutControl3.Controls.Add(Me.WeekMony)
        Me.LayoutControl3.Controls.Add(Me.TextID)
        Me.LayoutControl3.Controls.Add(Me.TextRule)
        Me.LayoutControl3.Controls.Add(Me.TextString)
        Me.LayoutControl3.Controls.Add(Me.TextPlate)
        Me.LayoutControl3.Controls.Add(Me.TextOdometer)
        Me.LayoutControl3.Controls.Add(Me.TextMonthNIS)
        Me.LayoutControl3.Controls.Add(Me.TextMonthLIT)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(969, 646)
        Me.LayoutControl3.TabIndex = 4
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListBoxControl1.Appearance.Options.UseFont = True
        Me.ListBoxControl1.Appearance.Options.UseForeColor = True
        Me.ListBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListBoxControl1.Items.AddRange(New Object() {"مشاكل البطاقة"})
        Me.ListBoxControl1.Location = New System.Drawing.Point(134, 546)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(823, 88)
        Me.ListBoxControl1.StyleController = Me.LayoutControl3
        Me.ListBoxControl1.TabIndex = 4
        '
        'TextAvailableCard
        '
        Me.TextAvailableCard.Location = New System.Drawing.Point(548, 448)
        Me.TextAvailableCard.Name = "TextAvailableCard"
        Me.TextAvailableCard.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAvailableCard.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextAvailableCard.Properties.Appearance.Options.UseFont = True
        Me.TextAvailableCard.Properties.Appearance.Options.UseForeColor = True
        Me.TextAvailableCard.Properties.Appearance.Options.UseTextOptions = True
        Me.TextAvailableCard.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextAvailableCard.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextAvailableCard.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextAvailableCard.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextAvailableCard.Properties.ReadOnly = True
        Me.TextAvailableCard.Size = New System.Drawing.Size(284, 22)
        Me.TextAvailableCard.StyleController = Me.LayoutControl3
        Me.TextAvailableCard.TabIndex = 0
        '
        'FleetIDText
        '
        Me.FleetIDText.Location = New System.Drawing.Point(146, 266)
        Me.FleetIDText.Name = "FleetIDText"
        Me.FleetIDText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FleetIDText.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.FleetIDText.Properties.Appearance.Options.UseFont = True
        Me.FleetIDText.Properties.Appearance.Options.UseForeColor = True
        Me.FleetIDText.Properties.Appearance.Options.UseTextOptions = True
        Me.FleetIDText.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FleetIDText.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.FleetIDText.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.FleetIDText.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.FleetIDText.Properties.ReadOnly = True
        Me.FleetIDText.Size = New System.Drawing.Size(261, 22)
        Me.FleetIDText.StyleController = Me.LayoutControl3
        Me.FleetIDText.TabIndex = 0
        '
        'TextFleetID
        '
        Me.TextFleetID.Location = New System.Drawing.Point(146, 396)
        Me.TextFleetID.Name = "TextFleetID"
        Me.TextFleetID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFleetID.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextFleetID.Properties.Appearance.Options.UseFont = True
        Me.TextFleetID.Properties.Appearance.Options.UseForeColor = True
        Me.TextFleetID.Properties.Appearance.Options.UseTextOptions = True
        Me.TextFleetID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextFleetID.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextFleetID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextFleetID.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextFleetID.Properties.ReadOnly = True
        Me.TextFleetID.Size = New System.Drawing.Size(261, 22)
        Me.TextFleetID.StyleController = Me.LayoutControl3
        Me.TextFleetID.TabIndex = 0
        '
        'TextIssueDate
        '
        Me.TextIssueDate.EditValue = ""
        Me.TextIssueDate.Location = New System.Drawing.Point(146, 42)
        Me.TextIssueDate.Name = "TextIssueDate"
        Me.TextIssueDate.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextIssueDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextIssueDate.Properties.Appearance.Options.UseFont = True
        Me.TextIssueDate.Properties.Appearance.Options.UseForeColor = True
        Me.TextIssueDate.Properties.Appearance.Options.UseTextOptions = True
        Me.TextIssueDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextIssueDate.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextIssueDate.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextIssueDate.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextIssueDate.Properties.ReadOnly = True
        Me.TextIssueDate.Size = New System.Drawing.Size(261, 22)
        Me.TextIssueDate.StyleController = Me.LayoutControl3
        Me.TextIssueDate.TabIndex = 0
        '
        'TextFleetName
        '
        Me.TextFleetName.Location = New System.Drawing.Point(146, 370)
        Me.TextFleetName.Name = "TextFleetName"
        Me.TextFleetName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFleetName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextFleetName.Properties.Appearance.Options.UseFont = True
        Me.TextFleetName.Properties.Appearance.Options.UseForeColor = True
        Me.TextFleetName.Properties.Appearance.Options.UseTextOptions = True
        Me.TextFleetName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextFleetName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextFleetName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextFleetName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextFleetName.Properties.ReadOnly = True
        Me.TextFleetName.Size = New System.Drawing.Size(261, 22)
        Me.TextFleetName.StyleController = Me.LayoutControl3
        Me.TextFleetName.TabIndex = 0
        '
        'TextLastEdit
        '
        Me.TextLastEdit.EditValue = ""
        Me.TextLastEdit.Location = New System.Drawing.Point(146, 94)
        Me.TextLastEdit.Name = "TextLastEdit"
        Me.TextLastEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLastEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextLastEdit.Properties.Appearance.Options.UseFont = True
        Me.TextLastEdit.Properties.Appearance.Options.UseForeColor = True
        Me.TextLastEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.TextLastEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextLastEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextLastEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextLastEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextLastEdit.Properties.ReadOnly = True
        Me.TextLastEdit.Size = New System.Drawing.Size(261, 22)
        Me.TextLastEdit.StyleController = Me.LayoutControl3
        Me.TextLastEdit.TabIndex = 0
        '
        'TextFleetType
        '
        Me.TextFleetType.Location = New System.Drawing.Point(146, 344)
        Me.TextFleetType.Name = "TextFleetType"
        Me.TextFleetType.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFleetType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextFleetType.Properties.Appearance.Options.UseFont = True
        Me.TextFleetType.Properties.Appearance.Options.UseForeColor = True
        Me.TextFleetType.Properties.Appearance.Options.UseTextOptions = True
        Me.TextFleetType.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextFleetType.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextFleetType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextFleetType.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextFleetType.Properties.ReadOnly = True
        Me.TextFleetType.Size = New System.Drawing.Size(261, 22)
        Me.TextFleetType.StyleController = Me.LayoutControl3
        Me.TextFleetType.TabIndex = 0
        '
        'TextAvailableFleet
        '
        Me.TextAvailableFleet.Location = New System.Drawing.Point(146, 318)
        Me.TextAvailableFleet.Name = "TextAvailableFleet"
        Me.TextAvailableFleet.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAvailableFleet.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextAvailableFleet.Properties.Appearance.Options.UseFont = True
        Me.TextAvailableFleet.Properties.Appearance.Options.UseForeColor = True
        Me.TextAvailableFleet.Properties.Appearance.Options.UseTextOptions = True
        Me.TextAvailableFleet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextAvailableFleet.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextAvailableFleet.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextAvailableFleet.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextAvailableFleet.Properties.ReadOnly = True
        Me.TextAvailableFleet.Size = New System.Drawing.Size(261, 22)
        Me.TextAvailableFleet.StyleController = Me.LayoutControl3
        Me.TextAvailableFleet.TabIndex = 0
        '
        'WeekLIT
        '
        Me.WeekLIT.Location = New System.Drawing.Point(548, 422)
        Me.WeekLIT.Name = "WeekLIT"
        Me.WeekLIT.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekLIT.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.WeekLIT.Properties.Appearance.Options.UseFont = True
        Me.WeekLIT.Properties.Appearance.Options.UseForeColor = True
        Me.WeekLIT.Properties.Appearance.Options.UseTextOptions = True
        Me.WeekLIT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WeekLIT.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.WeekLIT.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.WeekLIT.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.WeekLIT.Properties.ReadOnly = True
        Me.WeekLIT.Size = New System.Drawing.Size(284, 22)
        Me.WeekLIT.StyleController = Me.LayoutControl3
        Me.WeekLIT.TabIndex = 0
        '
        'TextFleetStatus
        '
        Me.TextFleetStatus.Location = New System.Drawing.Point(146, 292)
        Me.TextFleetStatus.Name = "TextFleetStatus"
        Me.TextFleetStatus.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFleetStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextFleetStatus.Properties.Appearance.Options.UseFont = True
        Me.TextFleetStatus.Properties.Appearance.Options.UseForeColor = True
        Me.TextFleetStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.TextFleetStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextFleetStatus.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextFleetStatus.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextFleetStatus.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextFleetStatus.Properties.ReadOnly = True
        Me.TextFleetStatus.Size = New System.Drawing.Size(261, 22)
        Me.TextFleetStatus.StyleController = Me.LayoutControl3
        Me.TextFleetStatus.TabIndex = 0
        '
        'TextLastUsed
        '
        Me.TextLastUsed.EditValue = ""
        Me.TextLastUsed.Location = New System.Drawing.Point(146, 68)
        Me.TextLastUsed.Name = "TextLastUsed"
        Me.TextLastUsed.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLastUsed.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextLastUsed.Properties.Appearance.Options.UseFont = True
        Me.TextLastUsed.Properties.Appearance.Options.UseForeColor = True
        Me.TextLastUsed.Properties.Appearance.Options.UseTextOptions = True
        Me.TextLastUsed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextLastUsed.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextLastUsed.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextLastUsed.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextLastUsed.Properties.ReadOnly = True
        Me.TextLastUsed.Size = New System.Drawing.Size(261, 22)
        Me.TextLastUsed.StyleController = Me.LayoutControl3
        Me.TextLastUsed.TabIndex = 0
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(146, 172)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(261, 22)
        Me.TextEdit1.StyleController = Me.LayoutControl3
        Me.TextEdit1.TabIndex = 0
        '
        'DelivPersonText
        '
        Me.DelivPersonText.Location = New System.Drawing.Point(146, 198)
        Me.DelivPersonText.Name = "DelivPersonText"
        Me.DelivPersonText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelivPersonText.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DelivPersonText.Properties.Appearance.Options.UseFont = True
        Me.DelivPersonText.Properties.Appearance.Options.UseForeColor = True
        Me.DelivPersonText.Properties.Appearance.Options.UseTextOptions = True
        Me.DelivPersonText.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DelivPersonText.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.DelivPersonText.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DelivPersonText.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.DelivPersonText.Properties.ReadOnly = True
        Me.DelivPersonText.Size = New System.Drawing.Size(261, 22)
        Me.DelivPersonText.StyleController = Me.LayoutControl3
        Me.DelivPersonText.TabIndex = 0
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(548, 68)
        Me.TextName.Name = "TextName"
        Me.TextName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextName.Properties.Appearance.Options.UseFont = True
        Me.TextName.Properties.Appearance.Options.UseForeColor = True
        Me.TextName.Properties.Appearance.Options.UseTextOptions = True
        Me.TextName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextName.Properties.ReadOnly = True
        Me.TextName.Size = New System.Drawing.Size(284, 22)
        Me.TextName.StyleController = Me.LayoutControl3
        Me.TextName.TabIndex = 0
        '
        'TextDayLit
        '
        Me.TextDayLit.Location = New System.Drawing.Point(548, 396)
        Me.TextDayLit.Name = "TextDayLit"
        Me.TextDayLit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDayLit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextDayLit.Properties.Appearance.Options.UseFont = True
        Me.TextDayLit.Properties.Appearance.Options.UseForeColor = True
        Me.TextDayLit.Properties.Appearance.Options.UseTextOptions = True
        Me.TextDayLit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextDayLit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextDayLit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextDayLit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextDayLit.Properties.ReadOnly = True
        Me.TextDayLit.Size = New System.Drawing.Size(284, 22)
        Me.TextDayLit.StyleController = Me.LayoutControl3
        Me.TextDayLit.TabIndex = 0
        '
        'TextCstatus
        '
        Me.TextCstatus.Location = New System.Drawing.Point(548, 94)
        Me.TextCstatus.Name = "TextCstatus"
        Me.TextCstatus.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCstatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextCstatus.Properties.Appearance.Options.UseFont = True
        Me.TextCstatus.Properties.Appearance.Options.UseForeColor = True
        Me.TextCstatus.Properties.Appearance.Options.UseTextOptions = True
        Me.TextCstatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextCstatus.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextCstatus.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextCstatus.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextCstatus.Properties.ReadOnly = True
        Me.TextCstatus.Size = New System.Drawing.Size(284, 22)
        Me.TextCstatus.StyleController = Me.LayoutControl3
        Me.TextCstatus.TabIndex = 0
        '
        'TextDayMony
        '
        Me.TextDayMony.Location = New System.Drawing.Point(548, 370)
        Me.TextDayMony.Name = "TextDayMony"
        Me.TextDayMony.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDayMony.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextDayMony.Properties.Appearance.Options.UseFont = True
        Me.TextDayMony.Properties.Appearance.Options.UseForeColor = True
        Me.TextDayMony.Properties.Appearance.Options.UseTextOptions = True
        Me.TextDayMony.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextDayMony.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextDayMony.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextDayMony.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextDayMony.Properties.ReadOnly = True
        Me.TextDayMony.Size = New System.Drawing.Size(284, 22)
        Me.TextDayMony.StyleController = Me.LayoutControl3
        Me.TextDayMony.TabIndex = 0
        '
        'TextCardType
        '
        Me.TextCardType.Location = New System.Drawing.Point(548, 120)
        Me.TextCardType.Name = "TextCardType"
        Me.TextCardType.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCardType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextCardType.Properties.Appearance.Options.UseFont = True
        Me.TextCardType.Properties.Appearance.Options.UseForeColor = True
        Me.TextCardType.Properties.Appearance.Options.UseTextOptions = True
        Me.TextCardType.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextCardType.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextCardType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextCardType.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextCardType.Properties.ReadOnly = True
        Me.TextCardType.Size = New System.Drawing.Size(284, 22)
        Me.TextCardType.StyleController = Me.LayoutControl3
        Me.TextCardType.TabIndex = 0
        '
        'WeekMony
        '
        Me.WeekMony.Location = New System.Drawing.Point(548, 344)
        Me.WeekMony.Name = "WeekMony"
        Me.WeekMony.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekMony.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.WeekMony.Properties.Appearance.Options.UseFont = True
        Me.WeekMony.Properties.Appearance.Options.UseForeColor = True
        Me.WeekMony.Properties.Appearance.Options.UseTextOptions = True
        Me.WeekMony.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WeekMony.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.WeekMony.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.WeekMony.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.WeekMony.Properties.ReadOnly = True
        Me.WeekMony.Size = New System.Drawing.Size(284, 22)
        Me.WeekMony.StyleController = Me.LayoutControl3
        Me.WeekMony.TabIndex = 0
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(548, 198)
        Me.TextID.Name = "TextID"
        Me.TextID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextID.Properties.Appearance.Options.UseFont = True
        Me.TextID.Properties.Appearance.Options.UseForeColor = True
        Me.TextID.Properties.Appearance.Options.UseTextOptions = True
        Me.TextID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextID.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextID.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextID.Properties.ReadOnly = True
        Me.TextID.Size = New System.Drawing.Size(284, 22)
        Me.TextID.StyleController = Me.LayoutControl3
        Me.TextID.TabIndex = 0
        '
        'TextRule
        '
        Me.TextRule.Location = New System.Drawing.Point(548, 318)
        Me.TextRule.Name = "TextRule"
        Me.TextRule.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRule.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextRule.Properties.Appearance.Options.UseFont = True
        Me.TextRule.Properties.Appearance.Options.UseForeColor = True
        Me.TextRule.Properties.Appearance.Options.UseTextOptions = True
        Me.TextRule.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextRule.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextRule.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextRule.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextRule.Properties.ReadOnly = True
        Me.TextRule.Size = New System.Drawing.Size(284, 22)
        Me.TextRule.StyleController = Me.LayoutControl3
        Me.TextRule.TabIndex = 0
        '
        'TextString
        '
        Me.TextString.Location = New System.Drawing.Point(548, 172)
        Me.TextString.Name = "TextString"
        Me.TextString.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextString.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextString.Properties.Appearance.Options.UseFont = True
        Me.TextString.Properties.Appearance.Options.UseForeColor = True
        Me.TextString.Properties.Appearance.Options.UseTextOptions = True
        Me.TextString.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextString.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextString.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextString.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextString.Properties.ReadOnly = True
        Me.TextString.Size = New System.Drawing.Size(284, 22)
        Me.TextString.StyleController = Me.LayoutControl3
        Me.TextString.TabIndex = 0
        '
        'TextPlate
        '
        Me.TextPlate.Location = New System.Drawing.Point(548, 42)
        Me.TextPlate.Name = "TextPlate"
        Me.TextPlate.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPlate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextPlate.Properties.Appearance.Options.UseFont = True
        Me.TextPlate.Properties.Appearance.Options.UseForeColor = True
        Me.TextPlate.Properties.Appearance.Options.UseTextOptions = True
        Me.TextPlate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextPlate.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextPlate.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextPlate.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextPlate.Properties.ReadOnly = True
        Me.TextPlate.Size = New System.Drawing.Size(284, 22)
        Me.TextPlate.StyleController = Me.LayoutControl3
        Me.TextPlate.TabIndex = 0
        '
        'TextOdometer
        '
        Me.TextOdometer.Location = New System.Drawing.Point(548, 146)
        Me.TextOdometer.Name = "TextOdometer"
        Me.TextOdometer.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextOdometer.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextOdometer.Properties.Appearance.Options.UseFont = True
        Me.TextOdometer.Properties.Appearance.Options.UseForeColor = True
        Me.TextOdometer.Properties.Appearance.Options.UseTextOptions = True
        Me.TextOdometer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextOdometer.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextOdometer.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextOdometer.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextOdometer.Properties.ReadOnly = True
        Me.TextOdometer.Size = New System.Drawing.Size(284, 22)
        Me.TextOdometer.StyleController = Me.LayoutControl3
        Me.TextOdometer.TabIndex = 0
        '
        'TextMonthNIS
        '
        Me.TextMonthNIS.Location = New System.Drawing.Point(548, 266)
        Me.TextMonthNIS.Name = "TextMonthNIS"
        Me.TextMonthNIS.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMonthNIS.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextMonthNIS.Properties.Appearance.Options.UseFont = True
        Me.TextMonthNIS.Properties.Appearance.Options.UseForeColor = True
        Me.TextMonthNIS.Properties.Appearance.Options.UseTextOptions = True
        Me.TextMonthNIS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextMonthNIS.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextMonthNIS.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextMonthNIS.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextMonthNIS.Properties.ReadOnly = True
        Me.TextMonthNIS.Size = New System.Drawing.Size(284, 22)
        Me.TextMonthNIS.StyleController = Me.LayoutControl3
        Me.TextMonthNIS.TabIndex = 0
        '
        'TextMonthLIT
        '
        Me.TextMonthLIT.Location = New System.Drawing.Point(548, 292)
        Me.TextMonthLIT.Name = "TextMonthLIT"
        Me.TextMonthLIT.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMonthLIT.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextMonthLIT.Properties.Appearance.Options.UseFont = True
        Me.TextMonthLIT.Properties.Appearance.Options.UseForeColor = True
        Me.TextMonthLIT.Properties.Appearance.Options.UseTextOptions = True
        Me.TextMonthLIT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextMonthLIT.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.TextMonthLIT.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextMonthLIT.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TextMonthLIT.Properties.ReadOnly = True
        Me.TextMonthLIT.Size = New System.Drawing.Size(284, 22)
        Me.TextMonthLIT.StyleController = Me.LayoutControl3
        Me.TextMonthLIT.TabIndex = 0
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup7, Me.LayoutControlItem34, Me.EmptySpaceItem4})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(969, 646)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem23, Me.LayoutControlItem20, Me.LayoutControlItem17, Me.LayoutControlItem16, Me.LayoutControlItem22, Me.LayoutControlItem27, Me.LayoutControlItem19})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(524, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(425, 224)
        Me.LayoutControlGroup1.Text = "بيانات البطاقة"
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.TextID
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem23.Text = "ID"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.TextOdometer
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem20.Text = "سبيدوميتر"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.TextCardType
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem17.Text = "النوع"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.TextCstatus
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem16.Text = "حالة البطاقة"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.TextPlate
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem22.Text = "رقم المركبة"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.TextName
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem27.Text = "رقم البطاقة"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.TextString
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem19.Text = "الكود"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem18, Me.EmptySpaceItem5, Me.LayoutControlItem21, Me.LayoutControlItem31})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(122, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(402, 224)
        Me.LayoutControlGroup4.Text = "تواريخ مهمة"
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.TextIssueDate
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem14.Text = "تاريخ اصدار البطاقة"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.TextLastUsed
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem15.Text = "تاريخ اخر استخدام"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.TextLastEdit
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem18.Text = "تاريخ اخر تعديل"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 78)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(378, 52)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.TextEdit1
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem21.Text = "تاريخ التسليم"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.DelivPersonText
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem31.Text = "مستلم البطاقة"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem30, Me.LayoutControlItem29, Me.LayoutControlItem28, Me.LayoutControlItem26, Me.LayoutControlItem25, Me.LayoutControlItem24, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.EmptySpaceItem2})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(524, 224)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(425, 310)
        Me.LayoutControlGroup5.Text = "بيانات"
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.TextDayLit
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem30.Text = "سحوبات اليوم لتر"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.TextDayMony
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem29.Text = "سحوبات اليوم شيكل"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.WeekMony
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem28.Text = "سحوبات الاسبوع شيكل"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.TextRule
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem26.Text = "السقف"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.TextMonthLIT
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem25.Text = "سحوبات الشهر لتر"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.TextMonthNIS
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem24.Text = "سحوبات الشهر شيكل"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.WeekLIT
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem32.Text = "سحوبات الاسبوع لتر"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.TextAvailableCard
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(401, 26)
        Me.LayoutControlItem33.Text = "المبلغ المسحوب"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 208)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(401, 60)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem3})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(122, 224)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(402, 310)
        Me.LayoutControlGroup7.Text = "بيانات الزبون"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.FleetIDText
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem7.Text = "رقم الزبون"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextFleetStatus
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem2.Text = "حالة الزبون"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextAvailableFleet
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem3.Text = "رصيد الزبون"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextFleetType
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem1.Text = "نوع الزبون"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextFleetName
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem4.Text = "الزبون"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TextFleetID
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem5.Text = "ID الزبون"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 156)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(378, 112)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.ListBoxControl1
        Me.LayoutControlItem34.Location = New System.Drawing.Point(122, 534)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(827, 92)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(122, 626)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "حركات البطاقة"
        Me.NavigationPage2.Controls.Add(Me.PanelControl3)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(969, 646)
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LayoutControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(969, 646)
        Me.PanelControl3.TabIndex = 1
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridControl11)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton8)
        Me.LayoutControl2.Controls.Add(Me.RadioButton3)
        Me.LayoutControl2.Controls.Add(Me.RadioButton2)
        Me.LayoutControl2.Controls.Add(Me.RadioButton1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(965, 642)
        Me.LayoutControl2.TabIndex = 9
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'GridControl11
        '
        Me.GridControl11.Location = New System.Drawing.Point(12, 67)
        Me.GridControl11.MainView = Me.GridView2
        Me.GridControl11.Name = "GridControl11"
        Me.GridControl11.Size = New System.Drawing.Size(941, 563)
        Me.GridControl11.TabIndex = 1
        Me.GridControl11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GridView2.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldate, Me.coltime, Me.colquantity, Me.colppv, Me.colsale, Me.colplate1, Me.colproduct_name, Me.colstn_name, Me.colpump, Me.ColCardName, Me.ColFleetCode, Me.ColFleetName, Me.Colodometer, Me.ColtheDayName})
        Me.GridView2.GridControl = Me.GridControl11
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sale", Me.colsale, "(sale: SUM={0:0.##})")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'coldate
        '
        Me.coldate.Caption = "التاريخ"
        Me.coldate.FieldName = "TransDate"
        Me.coldate.Name = "coldate"
        Me.coldate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "date", "عدد الحركات {0}", "")})
        Me.coldate.Visible = True
        Me.coldate.VisibleIndex = 0
        Me.coldate.Width = 107
        '
        'coltime
        '
        Me.coltime.Caption = "الوقت"
        Me.coltime.DisplayFormat.FormatString = "hh:mm tt"
        Me.coltime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coltime.FieldName = "time"
        Me.coltime.Name = "coltime"
        Me.coltime.Visible = True
        Me.coltime.VisibleIndex = 1
        Me.coltime.Width = 107
        '
        'colquantity
        '
        Me.colquantity.Caption = " الكمية"
        Me.colquantity.FieldName = "quantity"
        Me.colquantity.Name = "colquantity"
        Me.colquantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity", "{0}")})
        Me.colquantity.Visible = True
        Me.colquantity.VisibleIndex = 2
        Me.colquantity.Width = 107
        '
        'colppv
        '
        Me.colppv.Caption = "سعر (اللتر)"
        Me.colppv.FieldName = "ppv"
        Me.colppv.Name = "colppv"
        Me.colppv.Visible = True
        Me.colppv.VisibleIndex = 3
        Me.colppv.Width = 107
        '
        'colsale
        '
        Me.colsale.Caption = "المبلغ"
        Me.colsale.FieldName = "sale"
        Me.colsale.Name = "colsale"
        Me.colsale.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sale", "{0}")})
        Me.colsale.Visible = True
        Me.colsale.VisibleIndex = 4
        Me.colsale.Width = 107
        '
        'colplate1
        '
        Me.colplate1.Caption = "المركبة"
        Me.colplate1.FieldName = "plate"
        Me.colplate1.Name = "colplate1"
        Me.colplate1.Visible = True
        Me.colplate1.VisibleIndex = 5
        Me.colplate1.Width = 107
        '
        'colproduct_name
        '
        Me.colproduct_name.Caption = "الصنف"
        Me.colproduct_name.FieldName = "product_name"
        Me.colproduct_name.Name = "colproduct_name"
        Me.colproduct_name.Visible = True
        Me.colproduct_name.VisibleIndex = 6
        Me.colproduct_name.Width = 107
        '
        'colstn_name
        '
        Me.colstn_name.Caption = "المحطة"
        Me.colstn_name.FieldName = "stn_name"
        Me.colstn_name.Name = "colstn_name"
        Me.colstn_name.Visible = True
        Me.colstn_name.VisibleIndex = 8
        Me.colstn_name.Width = 118
        '
        'colpump
        '
        Me.colpump.Caption = "الطرمبة"
        Me.colpump.FieldName = "pump"
        Me.colpump.MaxWidth = 50
        Me.colpump.MinWidth = 50
        Me.colpump.Name = "colpump"
        Me.colpump.Visible = True
        Me.colpump.VisibleIndex = 9
        Me.colpump.Width = 50
        '
        'ColCardName
        '
        Me.ColCardName.Caption = "البطاقة"
        Me.ColCardName.FieldName = "mean_name"
        Me.ColCardName.Name = "ColCardName"
        Me.ColCardName.Visible = True
        Me.ColCardName.VisibleIndex = 7
        Me.ColCardName.Width = 107
        '
        'ColFleetCode
        '
        Me.ColFleetCode.Caption = "رقم الزبون"
        Me.ColFleetCode.FieldName = "FleetCode"
        Me.ColFleetCode.Name = "ColFleetCode"
        '
        'ColFleetName
        '
        Me.ColFleetName.Caption = "الزبون"
        Me.ColFleetName.FieldName = "FleetName"
        Me.ColFleetName.MinWidth = 150
        Me.ColFleetName.Name = "ColFleetName"
        Me.ColFleetName.Visible = True
        Me.ColFleetName.VisibleIndex = 10
        Me.ColFleetName.Width = 150
        '
        'Colodometer
        '
        Me.Colodometer.Caption = "عداد المركبة"
        Me.Colodometer.FieldName = "odometer"
        Me.Colodometer.Name = "Colodometer"
        Me.Colodometer.Visible = True
        Me.Colodometer.VisibleIndex = 11
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(110, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "طباعة"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.ImageOptions.Image = CType(resources.GetObject("SimpleButton8.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(126, 12)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(107, 22)
        Me.SimpleButton8.StyleController = Me.LayoutControl2
        Me.SimpleButton8.TabIndex = 7
        Me.SimpleButton8.Text = "بحث"
        '
        'RadioButton3
        '
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(749, 12)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(204, 25)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "بحث حسب رقم البطاقة"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(520, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(225, 25)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "بحث حسب رقم المركبة"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(237, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(279, 25)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "بحث حسب ID"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem9, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(965, 642)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.RadioButton1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(225, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(283, 29)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.RadioButton3
        Me.LayoutControlItem10.Location = New System.Drawing.Point(737, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(208, 29)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton8
        Me.LayoutControlItem11.Location = New System.Drawing.Point(114, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 29)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SimpleButton1
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(114, 29)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.GridControl11
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(945, 567)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.RadioButton2
        Me.LayoutControlItem9.Location = New System.Drawing.Point(508, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(229, 29)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 29)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(945, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "بيانات الزبون"
        Me.NavigationPage3.Controls.Add(Me.GroupControl8)
        Me.NavigationPage3.Controls.Add(Me.GroupControl6)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(969, 646)
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.LabelControl34)
        Me.GroupControl8.Controls.Add(Me.TextNote)
        Me.GroupControl8.Controls.Add(Me.LabelControl25)
        Me.GroupControl8.Controls.Add(Me.TextِAddress)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl8.Location = New System.Drawing.Point(-57, 0)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(456, 646)
        Me.GroupControl8.TabIndex = 10
        Me.GroupControl8.Text = "بيانات أخرى"
        '
        'LabelControl34
        '
        Me.LabelControl34.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl34.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl34.Location = New System.Drawing.Point(348, 31)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(100, 165)
        Me.LabelControl34.TabIndex = 5
        Me.LabelControl34.Text = "الملاحظات"
        '
        'TextNote
        '
        Me.TextNote.Location = New System.Drawing.Point(14, 30)
        Me.TextNote.Name = "TextNote"
        Me.TextNote.Properties.AutoHeight = False
        Me.TextNote.Properties.ReadOnly = True
        Me.TextNote.Size = New System.Drawing.Size(328, 166)
        Me.TextNote.TabIndex = 2
        '
        'LabelControl25
        '
        Me.LabelControl25.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl25.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl25.Location = New System.Drawing.Point(348, 202)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(100, 172)
        Me.LabelControl25.TabIndex = 5
        Me.LabelControl25.Text = "العنوان"
        '
        'TextِAddress
        '
        Me.TextِAddress.Location = New System.Drawing.Point(14, 202)
        Me.TextِAddress.Name = "TextِAddress"
        Me.TextِAddress.Properties.AutoHeight = False
        Me.TextِAddress.Properties.ReadOnly = True
        Me.TextِAddress.Size = New System.Drawing.Size(328, 172)
        Me.TextِAddress.TabIndex = 2
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.TextCountry)
        Me.GroupControl6.Controls.Add(Me.TextFleetID2)
        Me.GroupControl6.Controls.Add(Me.LabelControl35)
        Me.GroupControl6.Controls.Add(Me.LabelControl21)
        Me.GroupControl6.Controls.Add(Me.TextSphone)
        Me.GroupControl6.Controls.Add(Me.LabelControl30)
        Me.GroupControl6.Controls.Add(Me.TextArea)
        Me.GroupControl6.Controls.Add(Me.TextEmail)
        Me.GroupControl6.Controls.Add(Me.LabelControl22)
        Me.GroupControl6.Controls.Add(Me.TextPhone)
        Me.GroupControl6.Controls.Add(Me.TextSort)
        Me.GroupControl6.Controls.Add(Me.LabelControl31)
        Me.GroupControl6.Controls.Add(Me.TextFleetName2)
        Me.GroupControl6.Controls.Add(Me.TextPhax)
        Me.GroupControl6.Controls.Add(Me.LabelControl27)
        Me.GroupControl6.Controls.Add(Me.LabelControl33)
        Me.GroupControl6.Controls.Add(Me.LabelControl28)
        Me.GroupControl6.Controls.Add(Me.LabelControl32)
        Me.GroupControl6.Controls.Add(Me.TextFilter)
        Me.GroupControl6.Controls.Add(Me.LabelControl29)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl6.Location = New System.Drawing.Point(399, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(570, 646)
        Me.GroupControl6.TabIndex = 8
        '
        'TextCountry
        '
        Me.TextCountry.Location = New System.Drawing.Point(6, 202)
        Me.TextCountry.Name = "TextCountry"
        Me.TextCountry.Properties.AutoHeight = False
        Me.TextCountry.Properties.ReadOnly = True
        Me.TextCountry.Size = New System.Drawing.Size(385, 30)
        Me.TextCountry.TabIndex = 2
        '
        'TextFleetID2
        '
        Me.TextFleetID2.Location = New System.Drawing.Point(188, 27)
        Me.TextFleetID2.Name = "TextFleetID2"
        Me.TextFleetID2.Properties.AutoHeight = False
        Me.TextFleetID2.Properties.ReadOnly = True
        Me.TextFleetID2.Size = New System.Drawing.Size(202, 30)
        Me.TextFleetID2.TabIndex = 2
        '
        'LabelControl35
        '
        Me.LabelControl35.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl35.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl35.Location = New System.Drawing.Point(397, 201)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl35.TabIndex = 5
        Me.LabelControl35.Text = "الشخص المسؤول"
        '
        'LabelControl21
        '
        Me.LabelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl21.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl21.Location = New System.Drawing.Point(396, 27)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl21.TabIndex = 5
        Me.LabelControl21.Text = "رقم الزبون"
        '
        'TextSphone
        '
        Me.TextSphone.Location = New System.Drawing.Point(6, 238)
        Me.TextSphone.Name = "TextSphone"
        Me.TextSphone.Properties.AutoHeight = False
        Me.TextSphone.Properties.ReadOnly = True
        Me.TextSphone.Size = New System.Drawing.Size(385, 30)
        Me.TextSphone.TabIndex = 2
        '
        'LabelControl30
        '
        Me.LabelControl30.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl30.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl30.Location = New System.Drawing.Point(397, 238)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl30.TabIndex = 5
        Me.LabelControl30.Text = "رقم المحمول"
        '
        'TextArea
        '
        Me.TextArea.Location = New System.Drawing.Point(232, 93)
        Me.TextArea.Name = "TextArea"
        Me.TextArea.Properties.AutoHeight = False
        Me.TextArea.Properties.ReadOnly = True
        Me.TextArea.Size = New System.Drawing.Size(158, 30)
        Me.TextArea.TabIndex = 2
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(6, 344)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Properties.AutoHeight = False
        Me.TextEmail.Properties.ReadOnly = True
        Me.TextEmail.Size = New System.Drawing.Size(385, 30)
        Me.TextEmail.TabIndex = 2
        '
        'LabelControl22
        '
        Me.LabelControl22.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl22.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl22.Location = New System.Drawing.Point(396, 60)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl22.TabIndex = 5
        Me.LabelControl22.Text = "اسم الزبون"
        '
        'TextPhone
        '
        Me.TextPhone.Location = New System.Drawing.Point(6, 274)
        Me.TextPhone.Name = "TextPhone"
        Me.TextPhone.Properties.AutoHeight = False
        Me.TextPhone.Properties.ReadOnly = True
        Me.TextPhone.Size = New System.Drawing.Size(385, 30)
        Me.TextPhone.TabIndex = 2
        '
        'TextSort
        '
        Me.TextSort.Location = New System.Drawing.Point(232, 130)
        Me.TextSort.Name = "TextSort"
        Me.TextSort.Properties.AutoHeight = False
        Me.TextSort.Properties.ReadOnly = True
        Me.TextSort.Size = New System.Drawing.Size(158, 30)
        Me.TextSort.TabIndex = 2
        '
        'LabelControl31
        '
        Me.LabelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl31.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl31.Location = New System.Drawing.Point(397, 273)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl31.TabIndex = 5
        Me.LabelControl31.Text = "رقم الهاتف"
        '
        'TextFleetName2
        '
        Me.TextFleetName2.Location = New System.Drawing.Point(97, 61)
        Me.TextFleetName2.Name = "TextFleetName2"
        Me.TextFleetName2.Properties.AutoHeight = False
        Me.TextFleetName2.Properties.ReadOnly = True
        Me.TextFleetName2.Size = New System.Drawing.Size(293, 30)
        Me.TextFleetName2.TabIndex = 2
        '
        'TextPhax
        '
        Me.TextPhax.Location = New System.Drawing.Point(6, 308)
        Me.TextPhax.Name = "TextPhax"
        Me.TextPhax.Properties.AutoHeight = False
        Me.TextPhax.Properties.ReadOnly = True
        Me.TextPhax.Size = New System.Drawing.Size(385, 30)
        Me.TextPhax.TabIndex = 2
        '
        'LabelControl27
        '
        Me.LabelControl27.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl27.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl27.Location = New System.Drawing.Point(396, 129)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl27.TabIndex = 5
        Me.LabelControl27.Text = "التصنيف"
        '
        'LabelControl33
        '
        Me.LabelControl33.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl33.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl33.Location = New System.Drawing.Point(397, 343)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl33.TabIndex = 5
        Me.LabelControl33.Text = "الايميل"
        '
        'LabelControl28
        '
        Me.LabelControl28.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl28.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl28.Location = New System.Drawing.Point(396, 93)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl28.TabIndex = 5
        Me.LabelControl28.Text = "المنطقة"
        '
        'LabelControl32
        '
        Me.LabelControl32.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl32.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl32.Location = New System.Drawing.Point(397, 309)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl32.TabIndex = 5
        Me.LabelControl32.Text = "رقم الفاكس"
        '
        'TextFilter
        '
        Me.TextFilter.Location = New System.Drawing.Point(232, 166)
        Me.TextFilter.Name = "TextFilter"
        Me.TextFilter.Properties.AutoHeight = False
        Me.TextFilter.Properties.ReadOnly = True
        Me.TextFilter.Size = New System.Drawing.Size(158, 30)
        Me.TextFilter.TabIndex = 2
        '
        'LabelControl29
        '
        Me.LabelControl29.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl29.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl29.Location = New System.Drawing.Point(396, 166)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(158, 30)
        Me.LabelControl29.TabIndex = 5
        Me.LabelControl29.Text = "الفلتر"
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Caption = "كشف حساب الزبون"
        Me.NavigationPage4.Controls.Add(Me.PanelControl8)
        Me.NavigationPage4.Controls.Add(Me.PanelControl5)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(969, 646)
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.GridControl13)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl8.Location = New System.Drawing.Point(0, 32)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(969, 614)
        Me.PanelControl8.TabIndex = 2
        '
        'GridControl13
        '
        Me.GridControl13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl13.Location = New System.Drawing.Point(2, 2)
        Me.GridControl13.MainView = Me.GridView3
        Me.GridControl13.Name = "GridControl13"
        Me.GridControl13.Size = New System.Drawing.Size(965, 610)
        Me.GridControl13.TabIndex = 0
        Me.GridControl13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ALIAS6F, Me.ALIAS8F, Me.ALIAS9F, Me.ALIAS10F, Me.ALIAS12F_DEB, Me.ALIAS12F_CR})
        Me.GridView3.GridControl = Me.GridControl13
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'ALIAS6F
        '
        Me.ALIAS6F.Caption = "التاريخ"
        Me.ALIAS6F.FieldName = "ALIAS6F"
        Me.ALIAS6F.Name = "ALIAS6F"
        Me.ALIAS6F.Visible = True
        Me.ALIAS6F.VisibleIndex = 0
        '
        'ALIAS8F
        '
        Me.ALIAS8F.Caption = "سند 1"
        Me.ALIAS8F.FieldName = "ALIAS8F"
        Me.ALIAS8F.Name = "ALIAS8F"
        Me.ALIAS8F.Visible = True
        Me.ALIAS8F.VisibleIndex = 1
        '
        'ALIAS9F
        '
        Me.ALIAS9F.Caption = "سند 2"
        Me.ALIAS9F.FieldName = "ALIAS9F"
        Me.ALIAS9F.Name = "ALIAS9F"
        Me.ALIAS9F.Visible = True
        Me.ALIAS9F.VisibleIndex = 2
        '
        'ALIAS10F
        '
        Me.ALIAS10F.Caption = "البيان"
        Me.ALIAS10F.FieldName = "ALIAS10F"
        Me.ALIAS10F.Name = "ALIAS10F"
        Me.ALIAS10F.Visible = True
        Me.ALIAS10F.VisibleIndex = 3
        '
        'ALIAS12F_DEB
        '
        Me.ALIAS12F_DEB.Caption = "مدين"
        Me.ALIAS12F_DEB.FieldName = "ALIAS12F_DEB"
        Me.ALIAS12F_DEB.Name = "ALIAS12F_DEB"
        Me.ALIAS12F_DEB.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALIAS12F_DEB", "{0:0.##}")})
        Me.ALIAS12F_DEB.Visible = True
        Me.ALIAS12F_DEB.VisibleIndex = 4
        '
        'ALIAS12F_CR
        '
        Me.ALIAS12F_CR.Caption = "دائن"
        Me.ALIAS12F_CR.FieldName = "ALIAS12F_CR"
        Me.ALIAS12F_CR.Name = "ALIAS12F_CR"
        Me.ALIAS12F_CR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALIAS12F_CR", "{0:0.##}")})
        Me.ALIAS12F_CR.Visible = True
        Me.ALIAS12F_CR.VisibleIndex = 5
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.SimpleButton5)
        Me.PanelControl5.Controls.Add(Me.DateEditFrom)
        Me.PanelControl5.Controls.Add(Me.DateEditTo)
        Me.PanelControl5.Controls.Add(Me.SimpleButton4)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(969, 32)
        Me.PanelControl5.TabIndex = 1
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(570, 5)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton5.TabIndex = 9
        Me.SimpleButton5.Text = "تحديث الكشف"
        '
        'DateEditFrom
        '
        Me.DateEditFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEditFrom.EditValue = Nothing
        Me.DateEditFrom.Location = New System.Drawing.Point(825, 5)
        Me.DateEditFrom.Name = "DateEditFrom"
        Me.DateEditFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Size = New System.Drawing.Size(139, 20)
        Me.DateEditFrom.TabIndex = 7
        '
        'DateEditTo
        '
        Me.DateEditTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEditTo.EditValue = Nothing
        Me.DateEditTo.Location = New System.Drawing.Point(680, 5)
        Me.DateEditTo.Name = "DateEditTo"
        Me.DateEditTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Size = New System.Drawing.Size(139, 20)
        Me.DateEditTo.TabIndex = 7
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(462, 5)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(102, 20)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "طباعة"
        '
        'NavigationPage5
        '
        Me.NavigationPage5.Caption = "شيكات الزبون"
        Me.NavigationPage5.Controls.Add(Me.PanelControl7)
        Me.NavigationPage5.Controls.Add(Me.PanelControl4)
        Me.NavigationPage5.Name = "NavigationPage5"
        Me.NavigationPage5.Size = New System.Drawing.Size(969, 646)
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.GridControl1)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(0, 32)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(969, 614)
        Me.PanelControl7.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Cheqs"
        Me.GridControl1.DataSource = Me.SqlDataSource4
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView4
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(965, 610)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCheqNumber, Me.colBankAccNum, Me.colBankNumber, Me.colBranch, Me.colValueDate, Me.colSuF, Me.colCurrency})
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCheqNumber
        '
        Me.colCheqNumber.Caption = "رقم الشيك"
        Me.colCheqNumber.FieldName = "CheqNumber"
        Me.colCheqNumber.Name = "colCheqNumber"
        Me.colCheqNumber.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CheqNumber", "عدد  {0}")})
        Me.colCheqNumber.Visible = True
        Me.colCheqNumber.VisibleIndex = 0
        '
        'colBankAccNum
        '
        Me.colBankAccNum.Caption = "رقم الحساب"
        Me.colBankAccNum.FieldName = "BankAccNum"
        Me.colBankAccNum.Name = "colBankAccNum"
        Me.colBankAccNum.Visible = True
        Me.colBankAccNum.VisibleIndex = 1
        '
        'colBankNumber
        '
        Me.colBankNumber.Caption = "رقم البنك"
        Me.colBankNumber.FieldName = "BankNumber"
        Me.colBankNumber.Name = "colBankNumber"
        Me.colBankNumber.Visible = True
        Me.colBankNumber.VisibleIndex = 2
        '
        'colBranch
        '
        Me.colBranch.Caption = "رقم الفرع"
        Me.colBranch.FieldName = "Branch"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.Visible = True
        Me.colBranch.VisibleIndex = 3
        '
        'colValueDate
        '
        Me.colValueDate.Caption = "تاريخ الاستحقاق"
        Me.colValueDate.FieldName = "ValueDate"
        Me.colValueDate.Name = "colValueDate"
        Me.colValueDate.Visible = True
        Me.colValueDate.VisibleIndex = 4
        '
        'colSuF
        '
        Me.colSuF.Caption = "القيمة"
        Me.colSuF.FieldName = "SuF"
        Me.colSuF.Name = "colSuF"
        Me.colSuF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SuF", "المجموع {0}")})
        Me.colSuF.Visible = True
        Me.colSuF.VisibleIndex = 5
        '
        'colCurrency
        '
        Me.colCurrency.Caption = "العملة"
        Me.colCurrency.FieldName = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.Visible = True
        Me.colCurrency.VisibleIndex = 6
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.SimpleButton10)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Controls.Add(Me.DateEdit2)
        Me.PanelControl4.Controls.Add(Me.CheckButton1)
        Me.PanelControl4.Controls.Add(Me.SimpleButton2)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(969, 32)
        Me.PanelControl4.TabIndex = 1
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton10.ImageOptions.Image = CType(resources.GetObject("SimpleButton10.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton10.Location = New System.Drawing.Point(529, 5)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(90, 22)
        Me.SimpleButton10.TabIndex = 10
        Me.SimpleButton10.Text = "تحدبث"
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(792, 5)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AutoHeight = False
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(159, 22)
        Me.DateEdit1.TabIndex = 9
        '
        'DateEdit2
        '
        Me.DateEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(627, 5)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.AutoHeight = False
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(159, 22)
        Me.DateEdit2.TabIndex = 8
        '
        'CheckButton1
        '
        Me.CheckButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckButton1.ImageOptions.Image = CType(resources.GetObject("CheckButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.CheckButton1.Location = New System.Drawing.Point(434, 5)
        Me.CheckButton1.Name = "CheckButton1"
        Me.CheckButton1.Size = New System.Drawing.Size(90, 22)
        Me.CheckButton1.TabIndex = 7
        Me.CheckButton1.Text = "غير مستحق"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(340, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(90, 22)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "طباعة"
        '
        'NavigationPage6
        '
        Me.NavigationPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NavigationPage6.Caption = ".."
        Me.NavigationPage6.Controls.Add(Me.LabelControl36)
        Me.NavigationPage6.Name = "NavigationPage6"
        Me.NavigationPage6.Size = New System.Drawing.Size(1522, 530)
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Arabic Typesetting", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl36.Appearance.Options.UseFont = True
        Me.LabelControl36.Appearance.Options.UseForeColor = True
        Me.LabelControl36.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl36.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl36.Location = New System.Drawing.Point(410, 138)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(504, 76)
        Me.LabelControl36.TabIndex = 7
        Me.LabelControl36.Text = "جاري البحث ..."
        '
        'NavigationPage7
        '
        Me.NavigationPage7.Caption = "ملخص شهري للبطاقة"
        Me.NavigationPage7.Controls.Add(Me.PanelControl9)
        Me.NavigationPage7.Name = "NavigationPage7"
        Me.NavigationPage7.Size = New System.Drawing.Size(969, 646)
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.SimpleButton7)
        Me.PanelControl9.Controls.Add(Me.TextYear)
        Me.PanelControl9.Controls.Add(Me.ChartControl1)
        Me.PanelControl9.Controls.Add(Me.GridControl2)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl9.Location = New System.Drawing.Point(125, 0)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(844, 646)
        Me.PanelControl9.TabIndex = 5
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(520, 6)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(27, 22)
        Me.SimpleButton7.TabIndex = 5
        '
        'TextYear
        '
        Me.TextYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextYear.Location = New System.Drawing.Point(553, 6)
        Me.TextYear.Name = "TextYear"
        Me.TextYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextYear.Size = New System.Drawing.Size(284, 20)
        Me.TextYear.TabIndex = 3
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(26, 30)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(491, 279)
        Me.ChartControl1.TabIndex = 4
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Location = New System.Drawing.Point(520, 32)
        Me.GridControl2.MainView = Me.GridView5
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(318, 277)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl2
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'NavigationPage9
        '
        Me.NavigationPage9.Caption = "حركات شحن الزبون"
        Me.NavigationPage9.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage9.Name = "NavigationPage9"
        Me.NavigationPage9.Size = New System.Drawing.Size(969, 646)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton11)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton9)
        Me.LayoutControl1.Controls.Add(Me.GridControl4)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup6
        Me.LayoutControl1.Size = New System.Drawing.Size(969, 646)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(470, 22)
        Me.SimpleButton11.StyleController = Me.LayoutControl1
        Me.SimpleButton11.TabIndex = 5
        Me.SimpleButton11.Text = "طباعة"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Location = New System.Drawing.Point(486, 12)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(471, 22)
        Me.SimpleButton9.StyleController = Me.LayoutControl1
        Me.SimpleButton9.TabIndex = 4
        Me.SimpleButton9.Text = "تحديث"
        '
        'GridControl4
        '
        Me.GridControl4.Location = New System.Drawing.Point(12, 38)
        Me.GridControl4.MainView = Me.GridView1
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(945, 596)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.data, Me.field1, Me.field2, Me.field6, Me.field7, Me.field8})
        Me.GridView1.GridControl = Me.GridControl4
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'data
        '
        Me.data.Caption = "التاريخ"
        Me.data.FieldName = "date"
        Me.data.Name = "data"
        Me.data.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "date", "عدد الحركات {0}")})
        Me.data.Visible = True
        Me.data.VisibleIndex = 0
        '
        'field1
        '
        Me.field1.Caption = "المستخدم"
        Me.field1.FieldName = "field1"
        Me.field1.Name = "field1"
        Me.field1.Visible = True
        Me.field1.VisibleIndex = 1
        '
        'field2
        '
        Me.field2.Caption = "الحركة"
        Me.field2.FieldName = "field2"
        Me.field2.Name = "field2"
        Me.field2.Visible = True
        Me.field2.VisibleIndex = 2
        '
        'field6
        '
        Me.field6.Caption = "رصيد سابق"
        Me.field6.FieldName = "field6"
        Me.field6.Name = "field6"
        Me.field6.Visible = True
        Me.field6.VisibleIndex = 3
        '
        'field7
        '
        Me.field7.Caption = "رصيد بعد الشحن"
        Me.field7.FieldName = "field7"
        Me.field7.Name = "field7"
        Me.field7.Visible = True
        Me.field7.VisibleIndex = 4
        '
        'field8
        '
        Me.field8.Caption = "الفرق"
        Me.field8.FieldName = "field8"
        Me.field8.Name = "field8"
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem35, Me.LayoutControlItem36, Me.LayoutControlItem37})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(969, 646)
        Me.LayoutControlGroup6.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.GridControl4
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(949, 600)
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.SimpleButton9
        Me.LayoutControlItem36.Location = New System.Drawing.Point(474, 0)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(475, 26)
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.SimpleButton11
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(474, 26)
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.NavigationPane1)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl10.Location = New System.Drawing.Point(0, 252)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(1108, 710)
        Me.PanelControl10.TabIndex = 6
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 392)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(335, 25)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 20)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 144)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(402, 64)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'ColtheDayName
        '
        Me.ColtheDayName.Caption = "اليوم"
        Me.ColtheDayName.FieldName = "TheDayName"
        Me.ColtheDayName.Name = "ColtheDayName"
        Me.ColtheDayName.Visible = True
        Me.ColtheDayName.VisibleIndex = 12
        '
        'OrpakCardsQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1108, 962)
        Me.Controls.Add(Me.PanelControl10)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "OrpakCardsQuery"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "استعلام عن بطاقة"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Plate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlatePart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.CheckActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FleetCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextAvailableCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FleetIDText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFleetID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextIssueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFleetName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextLastEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFleetType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextAvailableFleet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekLIT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFleetStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextLastUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelivPersonText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDayLit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextCstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDayMony.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextCardType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekMony.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextRule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPlate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextOdometer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextMonthNIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextMonthLIT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage3.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.TextNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextِAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.TextCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFleetID2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSphone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFleetName2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPhax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage4.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.GridControl13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage5.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage6.ResumeLayout(False)
        Me.NavigationPage7.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.TextYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage9.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlatePart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Plate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Card As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CardCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents CheckActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfleets_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonth_money As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlDataSource3 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents SqlDataSource4 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents NavigationPage8 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents FleetCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents TextFleetID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextFleetType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextFleetStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextAvailableFleet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextFleetName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextAvailableCard As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeekLIT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextDayLit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextDayMony As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeekMony As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextRule As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextMonthLIT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextMonthNIS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextIssueDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextPlate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextLastEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextOdometer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextString As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextLastUsed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextCardType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextCstatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colquantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colppv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colplate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduct_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstn_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextِAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextCountry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextFleetID2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextSphone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextSort As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextFleetName2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextPhax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextFilter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl13 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALIAS6F As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ALIAS8F As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ALIAS9F As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ALIAS10F As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ALIAS12F_DEB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ALIAS12F_CR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEditFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavigationPage5 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCheqNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CheckButton1 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavigationPage6 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavigationPage7 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents NavigationPage9 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FleetIDText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents field1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents field2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents field6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents field7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents field8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents month_volume As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DelivPersonText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    '  Friend WithEvents AccountsTableAdapter As ALHUDADataSetTableAdapters.AccountsTableAdapter
    '  Friend WithEvents ALHUDADataSet As ALHUDADataSet
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents Colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpump As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ColCardName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ColFleetCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFleetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Colodometer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColtheDayName As DevExpress.XtraGrid.Columns.GridColumn
End Class
