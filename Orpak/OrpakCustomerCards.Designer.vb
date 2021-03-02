<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrpakCustomerCards
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakCustomerCards))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioSpedometer = New DevExpress.XtraEditors.RadioGroup()
        Me.RadioStatus = New DevExpress.XtraEditors.RadioGroup()
        Me.RadioType = New DevExpress.XtraEditors.RadioGroup()
        Me.SearchCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Accounts1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colavailable_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colmonth_volume = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colmonth_money = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colmonth_visits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colissued_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Collast_used = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Accounts1TableAdapter = New DXApplication5.WizCountDataSetTableAdapters.Accounts1TableAdapter()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.RadioSpedometer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DockPanel1.ID = New System.Guid("cf0680f4-9774-462f-8de9-f97183ff811b")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(321, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(321, 515)
        Me.DockPanel1.Text = "خيارات التقرير"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 30)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(314, 482)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.RadioSpedometer)
        Me.LayoutControl2.Controls.Add(Me.RadioStatus)
        Me.LayoutControl2.Controls.Add(Me.RadioType)
        Me.LayoutControl2.Controls.Add(Me.SearchCustomer)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(750, 251, 650, 400)
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(314, 482)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 448)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(143, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "نسخ"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(159, 448)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(143, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "طباعة"
        '
        'RadioSpedometer
        '
        Me.RadioSpedometer.EditValue = "All"
        Me.RadioSpedometer.Location = New System.Drawing.Point(12, 112)
        Me.RadioSpedometer.Name = "RadioSpedometer"
        Me.RadioSpedometer.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("All", "الكل"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Active", "فعال"), New DevExpress.XtraEditors.Controls.RadioGroupItem("NotActive", "غير فعال")})
        Me.RadioSpedometer.Size = New System.Drawing.Size(229, 34)
        Me.RadioSpedometer.StyleController = Me.LayoutControl2
        Me.RadioSpedometer.TabIndex = 8
        '
        'RadioStatus
        '
        Me.RadioStatus.EditValue = "Active"
        Me.RadioStatus.Location = New System.Drawing.Point(12, 74)
        Me.RadioStatus.Name = "RadioStatus"
        Me.RadioStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("All", "الكل"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Active", "فعال"), New DevExpress.XtraEditors.Controls.RadioGroupItem("NotActive", "غير فعال")})
        Me.RadioStatus.Size = New System.Drawing.Size(229, 34)
        Me.RadioStatus.StyleController = Me.LayoutControl2
        Me.RadioStatus.TabIndex = 7
        '
        'RadioType
        '
        Me.RadioType.EditValue = "All"
        Me.RadioType.Location = New System.Drawing.Point(12, 36)
        Me.RadioType.Name = "RadioType"
        Me.RadioType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("All", "الكل"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Card", "بطاقة"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Ring", "حلقة")})
        Me.RadioType.Size = New System.Drawing.Size(229, 34)
        Me.RadioType.StyleController = Me.LayoutControl2
        Me.RadioType.TabIndex = 6
        '
        'SearchCustomer
        '
        Me.SearchCustomer.Location = New System.Drawing.Point(12, 12)
        Me.SearchCustomer.Name = "SearchCustomer"
        Me.SearchCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchCustomer.Properties.DataSource = Me.Accounts1BindingSource
        Me.SearchCustomer.Properties.DisplayMember = "FullName"
        Me.SearchCustomer.Properties.NullText = ""
        Me.SearchCustomer.Properties.NullValuePrompt = "الزيون"
        Me.SearchCustomer.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchCustomer.Properties.ValueMember = "AccountKey"
        Me.SearchCustomer.Size = New System.Drawing.Size(290, 20)
        Me.SearchCustomer.StyleController = Me.LayoutControl2
        Me.SearchCustomer.TabIndex = 4
        '
        'Accounts1BindingSource
        '
        Me.Accounts1BindingSource.DataMember = "Accounts1"
        Me.Accounts1BindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(314, 482)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 138)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(294, 272)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchCustomer
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.RadioType
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(294, 38)
        Me.LayoutControlItem4.Text = "النوع"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.RadioStatus
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(294, 38)
        Me.LayoutControlItem5.Text = "الحالة"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.RadioSpedometer
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(294, 38)
        Me.LayoutControlItem6.Text = "سبيدوميتر"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(147, 436)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(147, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 436)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(147, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(321, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(697, 515)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(673, 465)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Colname, Me.Colplate, Me.Colavailable_amount, Me.Colmonth_volume, Me.Colmonth_money, Me.Colmonth_visits, Me.Colissued_date, Me.Collast_used, Me.Colttype, Me.ColDescription})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Colname
        '
        Me.Colname.Caption = "رقم البطافة"
        Me.Colname.FieldName = "name"
        Me.Colname.Name = "Colname"
        Me.Colname.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "{0}")})
        Me.Colname.Visible = True
        Me.Colname.VisibleIndex = 0
        '
        'Colplate
        '
        Me.Colplate.Caption = "المركبة"
        Me.Colplate.FieldName = "plate"
        Me.Colplate.Name = "Colplate"
        Me.Colplate.Visible = True
        Me.Colplate.VisibleIndex = 1
        '
        'Colavailable_amount
        '
        Me.Colavailable_amount.Caption = "المبلغ الكلي للتعبئات"
        Me.Colavailable_amount.FieldName = "available_amount"
        Me.Colavailable_amount.Name = "Colavailable_amount"
        '
        'Colmonth_volume
        '
        Me.Colmonth_volume.Caption = "تعبئة الشهر (لتر)"
        Me.Colmonth_volume.FieldName = "month_volume"
        Me.Colmonth_volume.Name = "Colmonth_volume"
        Me.Colmonth_volume.Visible = True
        Me.Colmonth_volume.VisibleIndex = 2
        '
        'Colmonth_money
        '
        Me.Colmonth_money.Caption = "تعبئة الشهر شيكل"
        Me.Colmonth_money.FieldName = "month_money"
        Me.Colmonth_money.Name = "Colmonth_money"
        Me.Colmonth_money.Visible = True
        Me.Colmonth_money.VisibleIndex = 3
        '
        'Colmonth_visits
        '
        Me.Colmonth_visits.Caption = "زيارات الشهر"
        Me.Colmonth_visits.FieldName = "month_visits"
        Me.Colmonth_visits.Name = "Colmonth_visits"
        Me.Colmonth_visits.Visible = True
        Me.Colmonth_visits.VisibleIndex = 4
        '
        'Colissued_date
        '
        Me.Colissued_date.Caption = "تاريخ الاصدار"
        Me.Colissued_date.FieldName = "issued_date"
        Me.Colissued_date.Name = "Colissued_date"
        Me.Colissued_date.Visible = True
        Me.Colissued_date.VisibleIndex = 5
        '
        'Collast_used
        '
        Me.Collast_used.Caption = "اخر استخدام"
        Me.Collast_used.FieldName = "last_used"
        Me.Collast_used.Name = "Collast_used"
        Me.Collast_used.Visible = True
        Me.Collast_used.VisibleIndex = 6
        '
        'Colttype
        '
        Me.Colttype.Caption = "النوع"
        Me.Colttype.FieldName = "ttype"
        Me.Colttype.Name = "Colttype"
        Me.Colttype.Visible = True
        Me.Colttype.VisibleIndex = 7
        '
        'ColDescription
        '
        Me.ColDescription.Caption = "السقف"
        Me.ColDescription.FieldName = "Description"
        Me.ColDescription.Name = "ColDescription"
        Me.ColDescription.Visible = True
        Me.ColDescription.VisibleIndex = 8
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(697, 515)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(677, 469)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 469)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(677, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'Accounts1TableAdapter
        '
        Me.Accounts1TableAdapter.ClearBeforeFill = True
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 422)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(290, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl2
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "تحديث"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton3
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 410)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(294, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'OrpakCustomerCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 515)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "OrpakCustomerCards"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "بطاقات زبون"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.RadioSpedometer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SearchCustomer As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents Accounts1BindingSource As BindingSource
    Friend WithEvents Accounts1TableAdapter As WizCountDataSetTableAdapters.Accounts1TableAdapter
    Friend WithEvents RadioType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioStatus As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioSpedometer As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colavailable_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colmonth_volume As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colmonth_money As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colmonth_visits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colissued_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Collast_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
