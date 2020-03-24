<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrbakSumForSort
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrbakSumForSort))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ColDiff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.RadioFromData = New DevExpress.XtraEditors.RadioGroup()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboYear = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SearchSort = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.AccSortNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccSortCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSortCodeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColFleetCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSortGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDebitBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColOrpakBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEMail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEmployeeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColOpen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryOpenAccount = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.AccSortNamesTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.AccSortNamesTableAdapter()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.RadioFromData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchSort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccSortNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryOpenAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColDiff
        '
        Me.ColDiff.Caption = "الفرق"
        Me.ColDiff.FieldName = "Diff"
        Me.ColDiff.Name = "ColDiff"
        Me.ColDiff.OptionsColumn.AllowEdit = False
        Me.ColDiff.Visible = True
        Me.ColDiff.VisibleIndex = 6
        Me.ColDiff.Width = 42
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
        Me.DockPanel1.ID = New System.Guid("73e55f3a-8e5b-4b10-8dfd-140c34d2358e")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 591)
        Me.DockPanel1.Text = "خيارات التقرير"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 562)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.RadioFromData)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.ComboYear)
        Me.LayoutControl1.Controls.Add(Me.ComboMonth)
        Me.LayoutControl1.Controls.Add(Me.SearchSort)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(193, 562)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'RadioFromData
        '
        Me.RadioFromData.EditValue = "1"
        Me.RadioFromData.Location = New System.Drawing.Point(12, 84)
        Me.RadioFromData.Name = "RadioFromData"
        Me.RadioFromData.Properties.Columns = 1
        Me.RadioFromData.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RadioFromData.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "قراءة من ملف الداتا"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "قراءة من اورباك")})
        Me.RadioFromData.Size = New System.Drawing.Size(169, 68)
        Me.RadioFromData.StyleController = Me.LayoutControl1
        Me.RadioFromData.TabIndex = 9
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 528)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(169, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "طباعة"
        '
        'ComboYear
        '
        Me.ComboYear.Location = New System.Drawing.Point(12, 60)
        Me.ComboYear.Name = "ComboYear"
        Me.ComboYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboYear.Size = New System.Drawing.Size(137, 20)
        Me.ComboYear.StyleController = Me.LayoutControl1
        Me.ComboYear.TabIndex = 7
        '
        'ComboMonth
        '
        Me.ComboMonth.Location = New System.Drawing.Point(12, 36)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboMonth.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboMonth.Size = New System.Drawing.Size(137, 20)
        Me.ComboMonth.StyleController = Me.LayoutControl1
        Me.ComboMonth.TabIndex = 6
        '
        'SearchSort
        '
        Me.SearchSort.Location = New System.Drawing.Point(12, 12)
        Me.SearchSort.Name = "SearchSort"
        Me.SearchSort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchSort.Properties.DataSource = Me.AccSortNamesBindingSource
        Me.SearchSort.Properties.DisplayMember = "SortCodeName"
        Me.SearchSort.Properties.NullText = ""
        Me.SearchSort.Properties.NullValuePrompt = "الرجاء تعبئة التصنيف"
        Me.SearchSort.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchSort.Properties.ValueMember = "AccSortCode"
        Me.SearchSort.Size = New System.Drawing.Size(169, 20)
        Me.SearchSort.StyleController = Me.LayoutControl1
        Me.SearchSort.TabIndex = 5
        '
        'AccSortNamesBindingSource
        '
        Me.AccSortNamesBindingSource.DataMember = "AccSortNames"
        Me.AccSortNamesBindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccSortCode, Me.colSortCodeName})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colAccSortCode
        '
        Me.colAccSortCode.FieldName = "AccSortCode"
        Me.colAccSortCode.Name = "colAccSortCode"
        Me.colAccSortCode.Visible = True
        Me.colAccSortCode.VisibleIndex = 0
        '
        'colSortCodeName
        '
        Me.colSortCodeName.FieldName = "SortCodeName"
        Me.colSortCodeName.Name = "colSortCodeName"
        Me.colSortCodeName.Visible = True
        Me.colSortCodeName.VisibleIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 156)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(169, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "تحديث"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(193, 562)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 170)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 346)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ComboMonth
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem3.Text = "الشهر"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(29, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ComboYear
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem4.Text = "السنة"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(29, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchSort
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton2
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 516)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.RadioFromData
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(173, 72)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(200, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryOpenAccount})
        Me.GridControl1.Size = New System.Drawing.Size(620, 591)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColFleetCode, Me.ColFullName, Me.ColSortGroup, Me.ColDebitBalance, Me.ColOrpakBalance, Me.ColDiff, Me.ColSPhone, Me.ColEMail, Me.ColEmployeeNo, Me.ColOpen})
        GridFormatRule1.Column = Me.ColDiff
        GridFormatRule1.ColumnApplyTo = Me.ColDiff
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.AllowAnimation = DevExpress.Utils.DefaultBoolean.[True]
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Less
        FormatConditionRuleValue1.PredefinedName = "Red Fill"
        FormatConditionRuleValue1.Value1 = "-1"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColFleetCode
        '
        Me.ColFleetCode.Caption = "رقم الحساب"
        Me.ColFleetCode.FieldName = "FleetCode"
        Me.ColFleetCode.Name = "ColFleetCode"
        Me.ColFleetCode.OptionsColumn.AllowEdit = False
        Me.ColFleetCode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FleetCode", "{0}")})
        Me.ColFleetCode.Visible = True
        Me.ColFleetCode.VisibleIndex = 0
        Me.ColFleetCode.Width = 59
        '
        'ColFullName
        '
        Me.ColFullName.Caption = "الحساب"
        Me.ColFullName.FieldName = "FullName"
        Me.ColFullName.Name = "ColFullName"
        Me.ColFullName.OptionsColumn.AllowEdit = False
        Me.ColFullName.Visible = True
        Me.ColFullName.VisibleIndex = 1
        Me.ColFullName.Width = 200
        '
        'ColSortGroup
        '
        Me.ColSortGroup.Caption = "التصنيف"
        Me.ColSortGroup.FieldName = "SortGroup"
        Me.ColSortGroup.Name = "ColSortGroup"
        Me.ColSortGroup.OptionsColumn.AllowEdit = False
        Me.ColSortGroup.Visible = True
        Me.ColSortGroup.VisibleIndex = 3
        Me.ColSortGroup.Width = 42
        '
        'ColDebitBalance
        '
        Me.ColDebitBalance.Caption = "مبلغ المدين"
        Me.ColDebitBalance.FieldName = "DebitBalance"
        Me.ColDebitBalance.Name = "ColDebitBalance"
        Me.ColDebitBalance.OptionsColumn.AllowEdit = False
        Me.ColDebitBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DebitBalance", "{0}")})
        Me.ColDebitBalance.Visible = True
        Me.ColDebitBalance.VisibleIndex = 4
        Me.ColDebitBalance.Width = 42
        '
        'ColOrpakBalance
        '
        Me.ColOrpakBalance.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ColOrpakBalance.AppearanceCell.Options.UseBackColor = True
        Me.ColOrpakBalance.Caption = "سحوبات البطاقات"
        Me.ColOrpakBalance.FieldName = "OrpakBalance"
        Me.ColOrpakBalance.Name = "ColOrpakBalance"
        Me.ColOrpakBalance.OptionsColumn.AllowEdit = False
        Me.ColOrpakBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrpakBalance", "{0}")})
        Me.ColOrpakBalance.Visible = True
        Me.ColOrpakBalance.VisibleIndex = 5
        Me.ColOrpakBalance.Width = 42
        '
        'ColSPhone
        '
        Me.ColSPhone.Caption = "رقم الموبايل"
        Me.ColSPhone.FieldName = "SPhone"
        Me.ColSPhone.Name = "ColSPhone"
        Me.ColSPhone.OptionsColumn.AllowEdit = False
        Me.ColSPhone.Visible = True
        Me.ColSPhone.VisibleIndex = 7
        Me.ColSPhone.Width = 42
        '
        'ColEMail
        '
        Me.ColEMail.Caption = "البريد الالكتروني"
        Me.ColEMail.FieldName = "EMail"
        Me.ColEMail.Name = "ColEMail"
        Me.ColEMail.OptionsColumn.AllowEdit = False
        Me.ColEMail.Visible = True
        Me.ColEMail.VisibleIndex = 8
        Me.ColEMail.Width = 42
        '
        'ColEmployeeNo
        '
        Me.ColEmployeeNo.Caption = "الرقم الوظيفي"
        Me.ColEmployeeNo.FieldName = "EmployeeNo"
        Me.ColEmployeeNo.Name = "ColEmployeeNo"
        Me.ColEmployeeNo.OptionsColumn.AllowEdit = False
        Me.ColEmployeeNo.Visible = True
        Me.ColEmployeeNo.VisibleIndex = 9
        Me.ColEmployeeNo.Width = 49
        '
        'ColOpen
        '
        Me.ColOpen.Caption = "فتح"
        Me.ColOpen.ColumnEdit = Me.RepositoryOpenAccount
        Me.ColOpen.FieldName = "openaccount"
        Me.ColOpen.MaxWidth = 75
        Me.ColOpen.Name = "ColOpen"
        Me.ColOpen.Visible = True
        Me.ColOpen.VisibleIndex = 2
        Me.ColOpen.Width = 35
        '
        'RepositoryOpenAccount
        '
        Me.RepositoryOpenAccount.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.RepositoryOpenAccount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryOpenAccount.Name = "RepositoryOpenAccount"
        Me.RepositoryOpenAccount.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'AccSortNamesTableAdapter
        '
        Me.AccSortNamesTableAdapter.ClearBeforeFill = True
        '
        'OrbakSumForSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 591)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "OrbakSumForSort"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقرير تجميعي لتصنيف"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.RadioFromData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchSort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccSortNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryOpenAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ComboYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboMonth As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SearchSort As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents AccSortNamesBindingSource As BindingSource
    Friend WithEvents AccSortNamesTableAdapter As WizCountDataSetTableAdapters.AccSortNamesTableAdapter
    Friend WithEvents colAccSortCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSortCodeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFleetCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSortGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDebitBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColOrpakBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEmployeeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioFromData As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColOpen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryOpenAccount As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
