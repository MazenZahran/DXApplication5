<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoucherIssue
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
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckBoxWithoutTax = New System.Windows.Forms.CheckBox()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CustomeID = New DevExpress.XtraEditors.TextEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.VoucherDate = New DevExpress.XtraEditors.DateEdit()
        Me.CustomeName = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryAmount = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColStockID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryStock = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColVoucherCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVouchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemsTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.ItemsTableAdapter()
        Me.ComboCurrency = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ComboCurrency)
        Me.LayoutControl1.Controls.Add(Me.CheckBoxWithoutTax)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Controls.Add(Me.TextAddress)
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.CustomeID)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.VoucherDate)
        Me.LayoutControl1.Controls.Add(Me.CustomeName)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(558, 222, 650, 400)
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(648, 485)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckBoxWithoutTax
        '
        Me.CheckBoxWithoutTax.Location = New System.Drawing.Point(525, 451)
        Me.CheckBoxWithoutTax.Name = "CheckBoxWithoutTax"
        Me.CheckBoxWithoutTax.Size = New System.Drawing.Size(103, 20)
        Me.CheckBoxWithoutTax.TabIndex = 15
        Me.CheckBoxWithoutTax.Text = "فاتورة صفرية"
        Me.CheckBoxWithoutTax.UseVisualStyleBackColor = True
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(454, 60)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(138, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 14
        '
        'TextAddress
        '
        Me.TextAddress.Location = New System.Drawing.Point(12, 60)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(394, 20)
        Me.TextAddress.StyleController = Me.LayoutControl1
        Me.TextAddress.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(632, 451)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "."
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(479, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(157, 22)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "فواتير سابقة بنفس الشهر"
        '
        'CustomeID
        '
        Me.CustomeID.Location = New System.Drawing.Point(475, 36)
        Me.CustomeID.Name = "CustomeID"
        Me.CustomeID.Size = New System.Drawing.Size(117, 20)
        Me.CustomeID.StyleController = Me.LayoutControl1
        Me.CustomeID.TabIndex = 10
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(12, 363)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(624, 84)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 9
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 451)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(140, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "اصدار فاتورة"
        '
        'VoucherDate
        '
        Me.VoucherDate.EditValue = Nothing
        Me.VoucherDate.Location = New System.Drawing.Point(430, 12)
        Me.VoucherDate.Name = "VoucherDate"
        Me.VoucherDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VoucherDate.Size = New System.Drawing.Size(162, 20)
        Me.VoucherDate.StyleController = Me.LayoutControl1
        Me.VoucherDate.TabIndex = 6
        '
        'CustomeName
        '
        Me.CustomeName.Location = New System.Drawing.Point(214, 36)
        Me.CustomeName.Name = "CustomeName"
        Me.CustomeName.Size = New System.Drawing.Size(257, 20)
        Me.CustomeName.StyleController = Me.LayoutControl1
        Me.CustomeName.TabIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 110)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryStock, Me.RepositoryQuantity, Me.RepositoryPrice, Me.RepositoryAmount})
        Me.GridControl1.Size = New System.Drawing.Size(624, 249)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColStock, Me.ColQuantity, Me.ColPrice, Me.ColAmount, Me.ColStockID, Me.ColVoucherCode, Me.ColVouchNo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.IndicatorWidth = 50
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColStock
        '
        Me.ColStock.Caption = "الصنف"
        Me.ColStock.FieldName = "SotckName"
        Me.ColStock.Name = "ColStock"
        Me.ColStock.Visible = True
        Me.ColStock.VisibleIndex = 1
        '
        'ColQuantity
        '
        Me.ColQuantity.Caption = "الكمية"
        Me.ColQuantity.ColumnEdit = Me.RepositoryQuantity
        Me.ColQuantity.FieldName = "Quantity"
        Me.ColQuantity.Name = "ColQuantity"
        Me.ColQuantity.Visible = True
        Me.ColQuantity.VisibleIndex = 2
        '
        'RepositoryQuantity
        '
        Me.RepositoryQuantity.AutoHeight = False
        Me.RepositoryQuantity.BeepOnError = False
        Me.RepositoryQuantity.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.RepositoryQuantity.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.RepositoryQuantity.MaskSettings.Set("mask", "n3")
        Me.RepositoryQuantity.Name = "RepositoryQuantity"
        Me.RepositoryQuantity.NullText = "0"
        Me.RepositoryQuantity.NullValuePrompt = "0"
        Me.RepositoryQuantity.UseMaskAsDisplayFormat = True
        Me.RepositoryQuantity.ValidateOnEnterKey = True
        '
        'ColPrice
        '
        Me.ColPrice.Caption = "السعر"
        Me.ColPrice.ColumnEdit = Me.RepositoryPrice
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 3
        '
        'RepositoryPrice
        '
        Me.RepositoryPrice.AutoHeight = False
        Me.RepositoryPrice.BeepOnError = False
        Me.RepositoryPrice.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.RepositoryPrice.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.RepositoryPrice.MaskSettings.Set("mask", "n4")
        Me.RepositoryPrice.Name = "RepositoryPrice"
        Me.RepositoryPrice.NullText = "0"
        Me.RepositoryPrice.NullValuePrompt = "0"
        Me.RepositoryPrice.UseMaskAsDisplayFormat = True
        Me.RepositoryPrice.ValidateOnEnterKey = True
        '
        'ColAmount
        '
        Me.ColAmount.Caption = "المبلغ"
        Me.ColAmount.ColumnEdit = Me.RepositoryAmount
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0}")})
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 4
        '
        'RepositoryAmount
        '
        Me.RepositoryAmount.AutoHeight = False
        Me.RepositoryAmount.BeepOnError = False
        Me.RepositoryAmount.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.RepositoryAmount.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.RepositoryAmount.MaskSettings.Set("mask", "n")
        Me.RepositoryAmount.Name = "RepositoryAmount"
        Me.RepositoryAmount.NullText = "0"
        Me.RepositoryAmount.NullValuePrompt = "0"
        Me.RepositoryAmount.UseMaskAsDisplayFormat = True
        '
        'ColStockID
        '
        Me.ColStockID.Caption = "رقم الصنف"
        Me.ColStockID.ColumnEdit = Me.RepositoryStock
        Me.ColStockID.FieldName = "StockID"
        Me.ColStockID.Name = "ColStockID"
        Me.ColStockID.Visible = True
        Me.ColStockID.VisibleIndex = 0
        '
        'RepositoryStock
        '
        Me.RepositoryStock.AutoHeight = False
        Me.RepositoryStock.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryStock.DataSource = Me.ItemsBindingSource
        Me.RepositoryStock.DisplayMember = "ItemKey"
        Me.RepositoryStock.Name = "RepositoryStock"
        Me.RepositoryStock.NullText = "الصنف"
        Me.RepositoryStock.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositoryStock.ValueMember = "ItemKey"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ColVoucherCode
        '
        Me.ColVoucherCode.Caption = "كود الفاتورة"
        Me.ColVoucherCode.FieldName = "VoucherCode"
        Me.ColVoucherCode.Name = "ColVoucherCode"
        '
        'ColVouchNo
        '
        Me.ColVouchNo.Caption = "رقم الفاتورة"
        Me.ColVouchNo.FieldName = "VouchNo"
        Me.ColVouchNo.Name = "ColVouchNo"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem4, Me.EmptySpaceItem3, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(648, 485)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(628, 253)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CustomeName
        Me.LayoutControlItem2.Location = New System.Drawing.Point(202, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem2.Text = "الزيون"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.VoucherDate
        Me.LayoutControlItem3.Location = New System.Drawing.Point(418, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem3.Text = "التاريخ"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(32, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(89, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(329, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(202, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 439)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(144, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(144, 439)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(369, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.MemoEdit1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 351)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(628, 88)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CustomeID
        Me.LayoutControlItem5.Location = New System.Drawing.Point(463, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem5.Text = "الزبون"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(32, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.LabelControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(628, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.LabelControl2
        Me.LayoutControlItem8.Location = New System.Drawing.Point(620, 439)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(8, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TextAddress
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(442, 24)
        Me.LayoutControlItem9.Text = "العنوان"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(32, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.TextEdit1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(442, 48)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(186, 24)
        Me.LayoutControlItem10.Text = "المدينة"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(32, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.CheckBoxWithoutTax
        Me.LayoutControlItem11.Location = New System.Drawing.Point(513, 439)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(107, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ComboCurrency
        '
        Me.ComboCurrency.Location = New System.Drawing.Point(12, 12)
        Me.ComboCurrency.Name = "ComboCurrency"
        Me.ComboCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboCurrency.Properties.Items.AddRange(New Object() {"NIS", "USD", "JD", "EUR"})
        Me.ComboCurrency.Size = New System.Drawing.Size(85, 20)
        Me.ComboCurrency.StyleController = Me.LayoutControl1
        Me.ComboCurrency.TabIndex = 16
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.ComboCurrency
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(89, 24)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'VoucherIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 485)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "VoucherIssue"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اصدار فاتورة"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VoucherDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CustomeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryStock As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As WizCountDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents ColStockID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVoucherCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVouchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CustomeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryQuantity As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryAmount As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckBoxWithoutTax As CheckBox
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ComboCurrency As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
End Class
