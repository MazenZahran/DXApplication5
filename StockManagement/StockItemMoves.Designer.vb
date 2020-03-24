<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockItemMoves
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
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchWarehouse = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.AgentWarehouseNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNameID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchLookItems = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAccount = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.Accounts1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColQuantityIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColQuantityOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColItemPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColStockID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColStockName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDebitWhereHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryDebitWhereHouse = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColCreditWhereHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryCreditWheerHouse = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColReferance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInputUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInputDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemsTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.ItemsTableAdapter()
        Me.AgentWarehouseNamesTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.AgentWarehouseNamesTableAdapter()
        Me.Accounts1TableAdapter = New DXApplication5.WizCountDataSetTableAdapters.Accounts1TableAdapter()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchWarehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentWarehouseNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDebitWhereHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCreditWheerHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("1421a2a9-7d5c-465e-8c33-645af5d76742")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 495)
        Me.DockPanel1.Text = "خيارات التقرير"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 24)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(195, 469)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SearchWarehouse)
        Me.LayoutControl1.Controls.Add(Me.SearchLookItems)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(195, 469)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchWarehouse
        '
        Me.SearchWarehouse.EditValue = ""
        Me.SearchWarehouse.Location = New System.Drawing.Point(12, 12)
        Me.SearchWarehouse.Name = "SearchWarehouse"
        Me.SearchWarehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchWarehouse.Properties.DataSource = Me.AgentWarehouseNamesBindingSource
        Me.SearchWarehouse.Properties.DisplayMember = "Name"
        Me.SearchWarehouse.Properties.NullText = ""
        Me.SearchWarehouse.Properties.NullValuePrompt = "المستودع"
        Me.SearchWarehouse.Properties.NullValuePromptShowForEmptyValue = True
        Me.SearchWarehouse.Properties.ValueMember = "NameID"
        Me.SearchWarehouse.Properties.View = Me.SearchLookUpEdit2View
        Me.SearchWarehouse.Size = New System.Drawing.Size(171, 20)
        Me.SearchWarehouse.StyleController = Me.LayoutControl1
        Me.SearchWarehouse.TabIndex = 20
        '
        'AgentWarehouseNamesBindingSource
        '
        Me.AgentWarehouseNamesBindingSource.DataMember = "AgentWarehouseNames"
        Me.AgentWarehouseNamesBindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNameID, Me.ColName})
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'ColNameID
        '
        Me.ColNameID.Caption = "رقم"
        Me.ColNameID.FieldName = "NameID"
        Me.ColNameID.Name = "ColNameID"
        Me.ColNameID.Visible = True
        Me.ColNameID.VisibleIndex = 0
        '
        'ColName
        '
        Me.ColName.Caption = "المستودع"
        Me.ColName.FieldName = "Name"
        Me.ColName.Name = "ColName"
        Me.ColName.Visible = True
        Me.ColName.VisibleIndex = 1
        '
        'SearchLookItems
        '
        Me.SearchLookItems.EditValue = "0"
        Me.SearchLookItems.Location = New System.Drawing.Point(12, 36)
        Me.SearchLookItems.Name = "SearchLookItems"
        Me.SearchLookItems.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookItems.Properties.DataSource = Me.ItemsBindingSource
        Me.SearchLookItems.Properties.DisplayMember = "ItemName"
        Me.SearchLookItems.Properties.NullText = ""
        Me.SearchLookItems.Properties.NullValuePrompt = "الصنف"
        Me.SearchLookItems.Properties.NullValuePromptShowForEmptyValue = True
        Me.SearchLookItems.Properties.ValueMember = "ItemKey"
        Me.SearchLookItems.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookItems.Size = New System.Drawing.Size(171, 20)
        Me.SearchLookItems.StyleController = Me.LayoutControl1
        Me.SearchLookItems.TabIndex = 19
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.WizCountDataSet
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemKey, Me.colItemName})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemKey
        '
        Me.colItemKey.FieldName = "ItemKey"
        Me.colItemKey.Name = "colItemKey"
        Me.colItemKey.Visible = True
        Me.colItemKey.VisibleIndex = 0
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 435)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(171, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "تحديث"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(195, 469)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(175, 375)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 423)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(175, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchLookItems
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SearchWarehouse
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(200, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAccount, Me.RepositoryDebitWhereHouse, Me.RepositoryCreditWheerHouse})
        Me.GridControl1.Size = New System.Drawing.Size(864, 495)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColID, Me.ColDocID, Me.ColDocDate, Me.ColDocType, Me.ColDocStatus, Me.ColDocCurrency, Me.ColAccount, Me.ColQuantityIn, Me.ColQuantityOut, Me.ColItemPrice, Me.ColAmount, Me.ColStockID, Me.ColStockName, Me.ColUnit, Me.ColDebitWhereHouse, Me.ColCreditWhereHouse, Me.ColNotes, Me.ColReferance, Me.ColInputUser, Me.ColInputDateTime})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColID
        '
        Me.ColID.Caption = "رقم"
        Me.ColID.FieldName = "ID"
        Me.ColID.Name = "ColID"
        '
        'ColDocID
        '
        Me.ColDocID.Caption = "رقم السند"
        Me.ColDocID.FieldName = "DocID"
        Me.ColDocID.Name = "ColDocID"
        Me.ColDocID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DocID", "عدد السندات {0}")})
        Me.ColDocID.Visible = True
        Me.ColDocID.VisibleIndex = 0
        '
        'ColDocDate
        '
        Me.ColDocDate.Caption = "التاريخ"
        Me.ColDocDate.FieldName = "DocDate"
        Me.ColDocDate.Name = "ColDocDate"
        Me.ColDocDate.Visible = True
        Me.ColDocDate.VisibleIndex = 2
        '
        'ColDocType
        '
        Me.ColDocType.Caption = "نوع السند"
        Me.ColDocType.FieldName = "DocType"
        Me.ColDocType.Name = "ColDocType"
        Me.ColDocType.Visible = True
        Me.ColDocType.VisibleIndex = 3
        '
        'ColDocStatus
        '
        Me.ColDocStatus.Caption = "حالة السند"
        Me.ColDocStatus.FieldName = "DocStatus"
        Me.ColDocStatus.Name = "ColDocStatus"
        '
        'ColDocCurrency
        '
        Me.ColDocCurrency.Caption = "العملة"
        Me.ColDocCurrency.FieldName = "DocCurrency"
        Me.ColDocCurrency.Name = "ColDocCurrency"
        '
        'ColAccount
        '
        Me.ColAccount.Caption = "الحساب"
        Me.ColAccount.ColumnEdit = Me.RepositoryItemAccount
        Me.ColAccount.FieldName = "Account"
        Me.ColAccount.Name = "ColAccount"
        Me.ColAccount.Visible = True
        Me.ColAccount.VisibleIndex = 4
        '
        'RepositoryItemAccount
        '
        Me.RepositoryItemAccount.AutoHeight = False
        Me.RepositoryItemAccount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAccount.DataSource = Me.Accounts1BindingSource
        Me.RepositoryItemAccount.DisplayMember = "FullName"
        Me.RepositoryItemAccount.Name = "RepositoryItemAccount"
        Me.RepositoryItemAccount.NullText = ""
        Me.RepositoryItemAccount.ValueMember = "AccountKey"
        Me.RepositoryItemAccount.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'Accounts1BindingSource
        '
        Me.Accounts1BindingSource.DataMember = "Accounts1"
        Me.Accounts1BindingSource.DataSource = Me.WizCountDataSet
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ColQuantityIn
        '
        Me.ColQuantityIn.Caption = "داخل"
        Me.ColQuantityIn.DisplayFormat.FormatString = "n0"
        Me.ColQuantityIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColQuantityIn.FieldName = "QuantityIn"
        Me.ColQuantityIn.Name = "ColQuantityIn"
        Me.ColQuantityIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityIn", "{0:n0}")})
        Me.ColQuantityIn.Visible = True
        Me.ColQuantityIn.VisibleIndex = 9
        '
        'ColQuantityOut
        '
        Me.ColQuantityOut.Caption = "خارج"
        Me.ColQuantityOut.DisplayFormat.FormatString = "n0"
        Me.ColQuantityOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColQuantityOut.FieldName = "QuantityOut"
        Me.ColQuantityOut.Name = "ColQuantityOut"
        Me.ColQuantityOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOut", "{0:n0}")})
        Me.ColQuantityOut.Visible = True
        Me.ColQuantityOut.VisibleIndex = 10
        '
        'ColItemPrice
        '
        Me.ColItemPrice.Caption = "السعر"
        Me.ColItemPrice.DisplayFormat.FormatString = "n2"
        Me.ColItemPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColItemPrice.FieldName = "ItemPrice"
        Me.ColItemPrice.Name = "ColItemPrice"
        Me.ColItemPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "ItemPrice", "{0:n2}")})
        Me.ColItemPrice.Visible = True
        Me.ColItemPrice.VisibleIndex = 11
        '
        'ColAmount
        '
        Me.ColAmount.Caption = "المبلغ"
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0}")})
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 12
        '
        'ColStockID
        '
        Me.ColStockID.Caption = "رقم الصنف"
        Me.ColStockID.FieldName = "StockID"
        Me.ColStockID.Name = "ColStockID"
        Me.ColStockID.Visible = True
        Me.ColStockID.VisibleIndex = 5
        '
        'ColStockName
        '
        Me.ColStockName.Caption = "الصنف"
        Me.ColStockName.FieldName = "StockName"
        Me.ColStockName.Name = "ColStockName"
        Me.ColStockName.Visible = True
        Me.ColStockName.VisibleIndex = 6
        '
        'ColUnit
        '
        Me.ColUnit.Caption = "الوحدة"
        Me.ColUnit.FieldName = "Unit"
        Me.ColUnit.Name = "ColUnit"
        '
        'ColDebitWhereHouse
        '
        Me.ColDebitWhereHouse.Caption = "من مستودع"
        Me.ColDebitWhereHouse.ColumnEdit = Me.RepositoryDebitWhereHouse
        Me.ColDebitWhereHouse.FieldName = "DebitWhereHouse"
        Me.ColDebitWhereHouse.Name = "ColDebitWhereHouse"
        Me.ColDebitWhereHouse.Visible = True
        Me.ColDebitWhereHouse.VisibleIndex = 7
        '
        'RepositoryDebitWhereHouse
        '
        Me.RepositoryDebitWhereHouse.AutoHeight = False
        Me.RepositoryDebitWhereHouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDebitWhereHouse.DataSource = Me.AgentWarehouseNamesBindingSource
        Me.RepositoryDebitWhereHouse.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryDebitWhereHouse.DisplayMember = "Name"
        Me.RepositoryDebitWhereHouse.Name = "RepositoryDebitWhereHouse"
        Me.RepositoryDebitWhereHouse.NullText = ""
        Me.RepositoryDebitWhereHouse.ValueMember = "NameID"
        '
        'ColCreditWhereHouse
        '
        Me.ColCreditWhereHouse.Caption = "الى مستودع"
        Me.ColCreditWhereHouse.ColumnEdit = Me.RepositoryCreditWheerHouse
        Me.ColCreditWhereHouse.FieldName = "CreditWhereHouse"
        Me.ColCreditWhereHouse.Name = "ColCreditWhereHouse"
        Me.ColCreditWhereHouse.Visible = True
        Me.ColCreditWhereHouse.VisibleIndex = 8
        '
        'RepositoryCreditWheerHouse
        '
        Me.RepositoryCreditWheerHouse.AutoHeight = False
        Me.RepositoryCreditWheerHouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCreditWheerHouse.DataSource = Me.AgentWarehouseNamesBindingSource
        Me.RepositoryCreditWheerHouse.DisplayMember = "Name"
        Me.RepositoryCreditWheerHouse.Name = "RepositoryCreditWheerHouse"
        Me.RepositoryCreditWheerHouse.NullText = ""
        Me.RepositoryCreditWheerHouse.ValueMember = "NameID"
        '
        'ColNotes
        '
        Me.ColNotes.Caption = "ملاحظات"
        Me.ColNotes.FieldName = "Notes"
        Me.ColNotes.Name = "ColNotes"
        '
        'ColReferance
        '
        Me.ColReferance.Caption = "رقم المرجع"
        Me.ColReferance.FieldName = "Referance"
        Me.ColReferance.Name = "ColReferance"
        Me.ColReferance.Visible = True
        Me.ColReferance.VisibleIndex = 1
        '
        'ColInputUser
        '
        Me.ColInputUser.Caption = "المستخدم"
        Me.ColInputUser.FieldName = "InputUser"
        Me.ColInputUser.Name = "ColInputUser"
        '
        'ColInputDateTime
        '
        Me.ColInputDateTime.Caption = "تاريخ الادخال"
        Me.ColInputDateTime.FieldName = "InputDateTime"
        Me.ColInputDateTime.Name = "ColInputDateTime"
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'AgentWarehouseNamesTableAdapter
        '
        Me.AgentWarehouseNamesTableAdapter.ClearBeforeFill = True
        '
        'Accounts1TableAdapter
        '
        Me.Accounts1TableAdapter.ClearBeforeFill = True
        '
        'StockItemMoves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 495)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "StockItemMoves"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "بطاقة صنف"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchWarehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentWarehouseNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDebitWhereHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCreditWheerHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchLookItems As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As WizCountDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCurrency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQuantityIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQuantityOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColItemPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStockID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStockName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDebitWhereHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCreditWhereHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColReferance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInputUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInputDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SearchWarehouse As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNameID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AgentWarehouseNamesBindingSource As BindingSource
    Friend WithEvents AgentWarehouseNamesTableAdapter As WizCountDataSetTableAdapters.AgentWarehouseNamesTableAdapter
    Friend WithEvents RepositoryItemAccount As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Accounts1BindingSource As BindingSource
    Friend WithEvents Accounts1TableAdapter As WizCountDataSetTableAdapters.Accounts1TableAdapter
    Friend WithEvents RepositoryDebitWhereHouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryCreditWheerHouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
