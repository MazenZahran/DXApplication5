<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceCustomersBalancesWithPeriods
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.ColOldDebit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFleetStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.ColStop = New DevExpress.XtraEditors.SimpleButton()
        Me.DateTo = New DevExpress.XtraEditors.DateEdit()
        Me.DateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.TextSortTo = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextSortFrom = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColAccountKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBegBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDebit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEndBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLastTransDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFleetID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAccountSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSortCodeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.DXApplication5.WaitForm1), True, True)
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.DateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSortTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSortFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColOldDebit
        '
        Me.ColOldDebit.Caption = "ديون قديمة"
        Me.ColOldDebit.DisplayFormat.FormatString = "N0"
        Me.ColOldDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColOldDebit.FieldName = "OldDebit"
        Me.ColOldDebit.Name = "ColOldDebit"
        Me.ColOldDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OldDebit", "{0:N0}")})
        Me.ColOldDebit.Visible = True
        Me.ColOldDebit.VisibleIndex = 8
        '
        'ColFleetStatus
        '
        Me.ColFleetStatus.Caption = "حالة الزبون"
        Me.ColFleetStatus.FieldName = "FleetStatus"
        Me.ColFleetStatus.Name = "ColFleetStatus"
        Me.ColFleetStatus.Visible = True
        Me.ColFleetStatus.VisibleIndex = 3
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("e8b3c70f-a44d-48db-98da-c7e0111aa085")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 461)
        Me.DockPanel1.Text = "خيارات التقرير"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 432)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.ColStop)
        Me.LayoutControl2.Controls.Add(Me.DateTo)
        Me.LayoutControl2.Controls.Add(Me.DateFrom)
        Me.LayoutControl2.Controls.Add(Me.TextSortTo)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.TextSortFrom)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(193, 432)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'ColStop
        '
        Me.ColStop.Location = New System.Drawing.Point(12, 372)
        Me.ColStop.Name = "ColStop"
        Me.ColStop.Size = New System.Drawing.Size(169, 22)
        Me.ColStop.StyleController = Me.LayoutControl2
        Me.ColStop.TabIndex = 9
        Me.ColStop.Text = "ايقاف البطاقات"
        '
        'DateTo
        '
        Me.DateTo.EditValue = Nothing
        Me.DateTo.Location = New System.Drawing.Point(12, 36)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTo.Properties.NullDate = New Date(2021, 1, 1, 12, 21, 41, 0)
        Me.DateTo.Size = New System.Drawing.Size(169, 20)
        Me.DateTo.StyleController = Me.LayoutControl2
        Me.DateTo.TabIndex = 8
        '
        'DateFrom
        '
        Me.DateFrom.EditValue = Nothing
        Me.DateFrom.Location = New System.Drawing.Point(12, 12)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateFrom.Properties.NullDate = New Date(2021, 1, 1, 12, 21, 5, 0)
        Me.DateFrom.Size = New System.Drawing.Size(169, 20)
        Me.DateFrom.StyleController = Me.LayoutControl2
        Me.DateFrom.TabIndex = 7
        '
        'TextSortTo
        '
        Me.TextSortTo.Location = New System.Drawing.Point(12, 84)
        Me.TextSortTo.Name = "TextSortTo"
        Me.TextSortTo.Properties.NullValuePrompt = "الى تصنيف"
        Me.TextSortTo.Size = New System.Drawing.Size(169, 20)
        Me.TextSortTo.StyleController = Me.LayoutControl2
        Me.TextSortTo.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 346)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(169, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "تحديث"
        '
        'TextSortFrom
        '
        Me.TextSortFrom.Location = New System.Drawing.Point(12, 60)
        Me.TextSortFrom.Name = "TextSortFrom"
        Me.TextSortFrom.Properties.NullValuePrompt = "من تصنيف"
        Me.TextSortFrom.Size = New System.Drawing.Size(169, 20)
        Me.TextSortFrom.StyleController = Me.LayoutControl2
        Me.TextSortFrom.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(193, 432)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 238)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextSortFrom
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 334)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextSortTo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.ColStop
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 360)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DateFrom
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DateTo
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(488, 461)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(464, 437)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColAccountKey, Me.ColAccountName, Me.ColBegBalance, Me.ColDebit, Me.ColCredit, Me.ColEndBalance, Me.ColOldDebit, Me.ColLastTransDate, Me.ColFleetStatus, Me.ColFleetID, Me.ColAccountSort, Me.ColSortCodeName})
        GridFormatRule1.Column = Me.ColOldDebit
        GridFormatRule1.ColumnApplyTo = Me.ColOldDebit
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue1.PredefinedName = "Red Fill"
        FormatConditionRuleValue1.Value1 = "10"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.ColFleetStatus
        GridFormatRule2.ColumnApplyTo = Me.ColFleetStatus
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.PredefinedName = "Red Fill"
        FormatConditionRuleValue2.Value1 = "Blocked"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccountSort", Me.ColBegBalance, "({0:N0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", Me.ColDebit, "({0:N0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", Me.ColCredit, "({0:N0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EndBalance", Me.ColEndBalance, "({0:N0})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OldDebit", Me.ColOldDebit, "({0:N0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColAccountSort, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColAccountKey
        '
        Me.ColAccountKey.Caption = "رقم الحساب"
        Me.ColAccountKey.FieldName = "AccountKey"
        Me.ColAccountKey.Name = "ColAccountKey"
        Me.ColAccountKey.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccountKey", "{0}")})
        Me.ColAccountKey.Visible = True
        Me.ColAccountKey.VisibleIndex = 1
        '
        'ColAccountName
        '
        Me.ColAccountName.Caption = "الحساب"
        Me.ColAccountName.FieldName = "AccountName"
        Me.ColAccountName.Name = "ColAccountName"
        Me.ColAccountName.Visible = True
        Me.ColAccountName.VisibleIndex = 2
        '
        'ColBegBalance
        '
        Me.ColBegBalance.Caption = "رصيد أول الفترة"
        Me.ColBegBalance.DisplayFormat.FormatString = "N0"
        Me.ColBegBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBegBalance.FieldName = "BegBalance"
        Me.ColBegBalance.Name = "ColBegBalance"
        Me.ColBegBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BegBalance", "{0:N0}")})
        Me.ColBegBalance.Visible = True
        Me.ColBegBalance.VisibleIndex = 4
        '
        'ColDebit
        '
        Me.ColDebit.Caption = "المبلغ المسحوب"
        Me.ColDebit.DisplayFormat.FormatString = "N0"
        Me.ColDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDebit.FieldName = "Debit"
        Me.ColDebit.Name = "ColDebit"
        Me.ColDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "{0:N0}")})
        Me.ColDebit.Visible = True
        Me.ColDebit.VisibleIndex = 5
        '
        'ColCredit
        '
        Me.ColCredit.Caption = "المدفوع"
        Me.ColCredit.DisplayFormat.FormatString = "N0"
        Me.ColCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColCredit.FieldName = "Credit"
        Me.ColCredit.Name = "ColCredit"
        Me.ColCredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "{0:N0}")})
        Me.ColCredit.Visible = True
        Me.ColCredit.VisibleIndex = 6
        '
        'ColEndBalance
        '
        Me.ColEndBalance.Caption = "رصيد نهاية الفترة"
        Me.ColEndBalance.DisplayFormat.FormatString = "N0"
        Me.ColEndBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColEndBalance.FieldName = "EndBalance"
        Me.ColEndBalance.Name = "ColEndBalance"
        Me.ColEndBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EndBalance", "{0:N0}")})
        Me.ColEndBalance.Visible = True
        Me.ColEndBalance.VisibleIndex = 7
        '
        'ColLastTransDate
        '
        Me.ColLastTransDate.Caption = "تاريخ اخر حركة على الحساب"
        Me.ColLastTransDate.FieldName = "LastTransDate"
        Me.ColLastTransDate.Name = "ColLastTransDate"
        Me.ColLastTransDate.Visible = True
        Me.ColLastTransDate.VisibleIndex = 9
        '
        'ColFleetID
        '
        Me.ColFleetID.Caption = "FleetID"
        Me.ColFleetID.FieldName = "FleetID"
        Me.ColFleetID.Name = "ColFleetID"
        '
        'ColAccountSort
        '
        Me.ColAccountSort.Caption = "التصنيف"
        Me.ColAccountSort.FieldName = "AccountSort"
        Me.ColAccountSort.Name = "ColAccountSort"
        Me.ColAccountSort.Visible = True
        Me.ColAccountSort.VisibleIndex = 10
        '
        'ColSortCodeName
        '
        Me.ColSortCodeName.Caption = "التصنيف"
        Me.ColSortCodeName.FieldName = "SortCodeName"
        Me.ColSortCodeName.Name = "ColSortCodeName"
        Me.ColSortCodeName.Visible = True
        Me.ColSortCodeName.VisibleIndex = 10
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(488, 461)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(468, 441)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 398)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(169, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "طباعة"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton2
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 386)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'FinanceCustomersBalancesWithPeriods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 461)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FinanceCustomersBalancesWithPeriods"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقرير الشهري لزبائن محطة"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.DateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSortTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSortFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextSortFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextSortTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColAccountKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBegBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDebit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEndBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLastTransDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColOldDebit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColFleetStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFleetID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents ColAccountSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSortCodeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
