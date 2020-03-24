<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockMoveAudit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockMoveAudit))
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchDocSort = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.StockMoveDocSort1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBook = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockMoveDocSort1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LookDocStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.StockMoveDocStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocType = New DevExpress.XtraEditors.LookUpEdit()
        Me.StockMoveDocumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColDocID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryDocType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColDocStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryDocStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColDebitAcc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryDebitAccount = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColCredAcc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryCreditAccount = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColDebitWhereHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryDebitWhareHouse = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColCreditWhereHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryCreditWhareHouse = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColReferance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCountItems = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColOpenDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryOpenDoc = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColAudit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryAudit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDriver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocManualNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocSortID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIDDocName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StockMoveDocumentsTableAdapter = New DXApplication5.CRMDataSetTableAdapters.StockMoveDocumentsTableAdapter()
        Me.StockMoveDocStatusTableAdapter = New DXApplication5.CRMDataSetTableAdapters.StockMoveDocStatusTableAdapter()
        Me.StockMoveDocSort1TableAdapter = New DXApplication5.CRMDataSetTableAdapters.StockMoveDocSort1TableAdapter()
        Me.ColWalletDocID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocAhditDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocAuditUser = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchDocSort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveDocSort1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookDocStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveDocStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveDocumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDocType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDocStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDebitAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCreditAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDebitWhareHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCreditWhareHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryOpenDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryAudit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DockPanel1.ID = New System.Guid("c715f101-0ce9-4d4e-bf5a-9781f2f5e302")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(205, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(205, 539)
        Me.DockPanel1.Text = "خيارات البحث"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 30)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(198, 506)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SearchDocSort)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.LookDocStatus)
        Me.LayoutControl1.Controls.Add(Me.DocType)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(198, 506)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchDocSort
        '
        Me.SearchDocSort.Location = New System.Drawing.Point(12, 60)
        Me.SearchDocSort.Name = "SearchDocSort"
        Me.SearchDocSort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchDocSort.Properties.DataSource = Me.StockMoveDocSort1BindingSource
        Me.SearchDocSort.Properties.DisplayMember = "StockMoveDocSort1"
        Me.SearchDocSort.Properties.NullText = ""
        Me.SearchDocSort.Properties.NullValuePrompt = "تصنيف السند"
        Me.SearchDocSort.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchDocSort.Properties.ValueMember = "Book"
        Me.SearchDocSort.Size = New System.Drawing.Size(174, 20)
        Me.SearchDocSort.StyleController = Me.LayoutControl1
        Me.SearchDocSort.TabIndex = 11
        '
        'StockMoveDocSort1BindingSource
        '
        Me.StockMoveDocSort1BindingSource.DataMember = "StockMoveDocSort1"
        Me.StockMoveDocSort1BindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBook, Me.colStockMoveDocSort1})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBook
        '
        Me.colBook.Caption = "الدفتر"
        Me.colBook.FieldName = "Book"
        Me.colBook.Name = "colBook"
        Me.colBook.Visible = True
        Me.colBook.VisibleIndex = 0
        '
        'colStockMoveDocSort1
        '
        Me.colStockMoveDocSort1.Caption = "التصنيف"
        Me.colStockMoveDocSort1.FieldName = "StockMoveDocSort1"
        Me.colStockMoveDocSort1.Name = "colStockMoveDocSort1"
        Me.colStockMoveDocSort1.Visible = True
        Me.colStockMoveDocSort1.VisibleIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 472)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(174, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "تحديث"
        '
        'LookDocStatus
        '
        Me.LookDocStatus.Location = New System.Drawing.Point(12, 36)
        Me.LookDocStatus.Name = "LookDocStatus"
        Me.LookDocStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookDocStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocStatus", "حالة السند", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookDocStatus.Properties.DataSource = Me.StockMoveDocStatusBindingSource
        Me.LookDocStatus.Properties.DisplayMember = "DocStatus"
        Me.LookDocStatus.Properties.NullText = ""
        Me.LookDocStatus.Properties.ValueMember = "ID"
        Me.LookDocStatus.Size = New System.Drawing.Size(174, 20)
        Me.LookDocStatus.StyleController = Me.LayoutControl1
        Me.LookDocStatus.TabIndex = 10
        '
        'StockMoveDocStatusBindingSource
        '
        Me.StockMoveDocStatusBindingSource.DataMember = "StockMoveDocStatus"
        Me.StockMoveDocStatusBindingSource.DataSource = Me.CRMDataSet
        '
        'DocType
        '
        Me.DocType.Location = New System.Drawing.Point(12, 12)
        Me.DocType.Name = "DocType"
        Me.DocType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocEnglishName", "Doc English Name", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocArabicName", "السند", 91, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.DocType.Properties.DataSource = Me.StockMoveDocumentsBindingSource
        Me.DocType.Properties.DisplayMember = "DocArabicName"
        Me.DocType.Properties.NullText = ""
        Me.DocType.Properties.PopupSizeable = False
        Me.DocType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DocType.Properties.ValueMember = "DocEnglishName"
        Me.DocType.Size = New System.Drawing.Size(174, 20)
        Me.DocType.StyleController = Me.LayoutControl1
        Me.DocType.TabIndex = 9
        '
        'StockMoveDocumentsBindingSource
        '
        Me.StockMoveDocumentsBindingSource.DataMember = "StockMoveDocuments"
        Me.StockMoveDocumentsBindingSource.DataSource = Me.CRMDataSet
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(198, 506)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(178, 388)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 460)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(178, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LookDocStatus
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(178, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SearchDocSort
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(178, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.DocType
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(178, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(205, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryDebitWhareHouse, Me.RepositoryCreditWhareHouse, Me.RepositoryDebitAccount, Me.RepositoryCreditAccount, Me.RepositoryDocType, Me.RepositoryDocStatus, Me.RepositoryOpenDoc, Me.RepositoryAudit})
        Me.GridControl1.Size = New System.Drawing.Size(638, 539)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColDocID, Me.ColDocDate, Me.ColDocType, Me.ColDocStatus, Me.ColDebitAcc, Me.ColCredAcc, Me.ColDebitWhereHouse, Me.ColCreditWhereHouse, Me.ColReferance, Me.ColAmount, Me.ColQuantity, Me.ColCountItems, Me.ColOpenDoc, Me.ColAudit, Me.ColDriver, Me.ColDocSort, Me.ColDocManualNo, Me.ColDocSortID, Me.ColIDDocName, Me.ColWalletDocID, Me.ColDocAhditDate, Me.ColDocAuditUser})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.IndicatorWidth = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColDocID
        '
        Me.ColDocID.Caption = "رقم السند"
        Me.ColDocID.FieldName = "DocID"
        Me.ColDocID.ImageOptions.Image = CType(resources.GetObject("ColDocID.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDocID.MaxWidth = 100
        Me.ColDocID.Name = "ColDocID"
        Me.ColDocID.OptionsColumn.AllowEdit = False
        Me.ColDocID.OptionsColumn.ReadOnly = True
        Me.ColDocID.Visible = True
        Me.ColDocID.VisibleIndex = 0
        Me.ColDocID.Width = 30
        '
        'ColDocDate
        '
        Me.ColDocDate.Caption = "التاريخ"
        Me.ColDocDate.FieldName = "DocDate"
        Me.ColDocDate.ImageOptions.Image = CType(resources.GetObject("ColDocDate.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDocDate.Name = "ColDocDate"
        Me.ColDocDate.OptionsColumn.AllowEdit = False
        Me.ColDocDate.OptionsColumn.ReadOnly = True
        Me.ColDocDate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DocDate", "عدد السندات {0}")})
        Me.ColDocDate.Visible = True
        Me.ColDocDate.VisibleIndex = 2
        Me.ColDocDate.Width = 49
        '
        'ColDocType
        '
        Me.ColDocType.Caption = "نوع السند"
        Me.ColDocType.ColumnEdit = Me.RepositoryDocType
        Me.ColDocType.FieldName = "DocType"
        Me.ColDocType.ImageOptions.Image = CType(resources.GetObject("ColDocType.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDocType.Name = "ColDocType"
        Me.ColDocType.OptionsColumn.AllowEdit = False
        Me.ColDocType.OptionsColumn.ReadOnly = True
        Me.ColDocType.Visible = True
        Me.ColDocType.VisibleIndex = 4
        Me.ColDocType.Width = 47
        '
        'RepositoryDocType
        '
        Me.RepositoryDocType.AutoHeight = False
        Me.RepositoryDocType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDocType.DisplayMember = "DocArabicName"
        Me.RepositoryDocType.Name = "RepositoryDocType"
        Me.RepositoryDocType.ValueMember = "DocEnglishName"
        '
        'ColDocStatus
        '
        Me.ColDocStatus.Caption = "حالة السند"
        Me.ColDocStatus.ColumnEdit = Me.RepositoryDocStatus
        Me.ColDocStatus.FieldName = "DocStatus"
        Me.ColDocStatus.ImageOptions.Image = CType(resources.GetObject("ColDocStatus.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDocStatus.Name = "ColDocStatus"
        Me.ColDocStatus.OptionsColumn.AllowEdit = False
        Me.ColDocStatus.OptionsColumn.ReadOnly = True
        Me.ColDocStatus.Visible = True
        Me.ColDocStatus.VisibleIndex = 5
        Me.ColDocStatus.Width = 47
        '
        'RepositoryDocStatus
        '
        Me.RepositoryDocStatus.AutoHeight = False
        Me.RepositoryDocStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDocStatus.DisplayMember = "DocStatus"
        Me.RepositoryDocStatus.Name = "RepositoryDocStatus"
        Me.RepositoryDocStatus.ValueMember = "ID"
        '
        'ColDebitAcc
        '
        Me.ColDebitAcc.Caption = "الزبون"
        Me.ColDebitAcc.ColumnEdit = Me.RepositoryDebitAccount
        Me.ColDebitAcc.FieldName = "DebitAcc"
        Me.ColDebitAcc.ImageOptions.Image = CType(resources.GetObject("ColDebitAcc.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDebitAcc.Name = "ColDebitAcc"
        Me.ColDebitAcc.OptionsColumn.AllowEdit = False
        Me.ColDebitAcc.OptionsColumn.ReadOnly = True
        Me.ColDebitAcc.Visible = True
        Me.ColDebitAcc.VisibleIndex = 6
        Me.ColDebitAcc.Width = 47
        '
        'RepositoryDebitAccount
        '
        Me.RepositoryDebitAccount.AutoHeight = False
        Me.RepositoryDebitAccount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDebitAccount.DisplayMember = "FullName"
        Me.RepositoryDebitAccount.Name = "RepositoryDebitAccount"
        Me.RepositoryDebitAccount.NullText = ""
        Me.RepositoryDebitAccount.PopupView = Me.GridView3
        Me.RepositoryDebitAccount.ValueMember = "AccountKey"
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'ColCredAcc
        '
        Me.ColCredAcc.Caption = "المورد"
        Me.ColCredAcc.ColumnEdit = Me.RepositoryCreditAccount
        Me.ColCredAcc.FieldName = "CredAcc"
        Me.ColCredAcc.ImageOptions.Image = CType(resources.GetObject("ColCredAcc.ImageOptions.Image"), System.Drawing.Image)
        Me.ColCredAcc.Name = "ColCredAcc"
        Me.ColCredAcc.OptionsColumn.AllowEdit = False
        Me.ColCredAcc.OptionsColumn.ReadOnly = True
        Me.ColCredAcc.Visible = True
        Me.ColCredAcc.VisibleIndex = 7
        Me.ColCredAcc.Width = 47
        '
        'RepositoryCreditAccount
        '
        Me.RepositoryCreditAccount.AutoHeight = False
        Me.RepositoryCreditAccount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCreditAccount.DisplayMember = "FullName"
        Me.RepositoryCreditAccount.Name = "RepositoryCreditAccount"
        Me.RepositoryCreditAccount.NullText = ""
        Me.RepositoryCreditAccount.PopupView = Me.GridView4
        Me.RepositoryCreditAccount.ValueMember = "AccountKey"
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'ColDebitWhereHouse
        '
        Me.ColDebitWhereHouse.Caption = "الى مستودع"
        Me.ColDebitWhereHouse.ColumnEdit = Me.RepositoryDebitWhareHouse
        Me.ColDebitWhereHouse.FieldName = "DebitWhereHouse"
        Me.ColDebitWhereHouse.ImageOptions.Image = CType(resources.GetObject("ColDebitWhereHouse.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDebitWhereHouse.Name = "ColDebitWhereHouse"
        Me.ColDebitWhereHouse.OptionsColumn.AllowEdit = False
        Me.ColDebitWhereHouse.OptionsColumn.ReadOnly = True
        Me.ColDebitWhereHouse.Visible = True
        Me.ColDebitWhereHouse.VisibleIndex = 9
        Me.ColDebitWhereHouse.Width = 47
        '
        'RepositoryDebitWhareHouse
        '
        Me.RepositoryDebitWhareHouse.AutoHeight = False
        Me.RepositoryDebitWhareHouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDebitWhareHouse.DisplayMember = "Name"
        Me.RepositoryDebitWhareHouse.Name = "RepositoryDebitWhareHouse"
        Me.RepositoryDebitWhareHouse.NullText = ""
        Me.RepositoryDebitWhareHouse.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositoryDebitWhareHouse.ValueMember = "NameID"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ColCreditWhereHouse
        '
        Me.ColCreditWhereHouse.Caption = "من مستودع"
        Me.ColCreditWhereHouse.ColumnEdit = Me.RepositoryCreditWhareHouse
        Me.ColCreditWhereHouse.FieldName = "CreditWhereHouse"
        Me.ColCreditWhereHouse.ImageOptions.Image = CType(resources.GetObject("ColCreditWhereHouse.ImageOptions.Image"), System.Drawing.Image)
        Me.ColCreditWhereHouse.Name = "ColCreditWhereHouse"
        Me.ColCreditWhereHouse.OptionsColumn.AllowEdit = False
        Me.ColCreditWhereHouse.OptionsColumn.ReadOnly = True
        Me.ColCreditWhereHouse.Visible = True
        Me.ColCreditWhereHouse.VisibleIndex = 8
        Me.ColCreditWhereHouse.Width = 47
        '
        'RepositoryCreditWhareHouse
        '
        Me.RepositoryCreditWhareHouse.AutoHeight = False
        Me.RepositoryCreditWhareHouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCreditWhareHouse.DisplayMember = "Name"
        Me.RepositoryCreditWhareHouse.Name = "RepositoryCreditWhareHouse"
        Me.RepositoryCreditWhareHouse.NullText = ""
        Me.RepositoryCreditWhareHouse.PopupView = Me.GridView2
        Me.RepositoryCreditWhareHouse.ValueMember = "NameID"
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ColReferance
        '
        Me.ColReferance.Caption = "المرجع"
        Me.ColReferance.FieldName = "Referance"
        Me.ColReferance.Name = "ColReferance"
        Me.ColReferance.OptionsColumn.AllowEdit = False
        Me.ColReferance.OptionsColumn.ReadOnly = True
        Me.ColReferance.Width = 47
        '
        'ColAmount
        '
        Me.ColAmount.Caption = "المبلغ (شيكل)"
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.ImageOptions.Image = CType(resources.GetObject("ColAmount.ImageOptions.Image"), System.Drawing.Image)
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowEdit = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "شيكل {0}")})
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 10
        Me.ColAmount.Width = 48
        '
        'ColQuantity
        '
        Me.ColQuantity.Caption = "مجموع الكميات"
        Me.ColQuantity.FieldName = "Quantity"
        Me.ColQuantity.ImageOptions.Image = CType(resources.GetObject("ColQuantity.ImageOptions.Image"), System.Drawing.Image)
        Me.ColQuantity.Name = "ColQuantity"
        Me.ColQuantity.OptionsColumn.AllowEdit = False
        Me.ColQuantity.OptionsColumn.ReadOnly = True
        Me.ColQuantity.Visible = True
        Me.ColQuantity.VisibleIndex = 11
        Me.ColQuantity.Width = 50
        '
        'ColCountItems
        '
        Me.ColCountItems.Caption = "عدد الاصناف"
        Me.ColCountItems.FieldName = "CountItems"
        Me.ColCountItems.ImageOptions.Image = CType(resources.GetObject("ColCountItems.ImageOptions.Image"), System.Drawing.Image)
        Me.ColCountItems.MaxWidth = 100
        Me.ColCountItems.Name = "ColCountItems"
        Me.ColCountItems.OptionsColumn.AllowEdit = False
        Me.ColCountItems.OptionsColumn.ReadOnly = True
        Me.ColCountItems.Visible = True
        Me.ColCountItems.VisibleIndex = 12
        Me.ColCountItems.Width = 47
        '
        'ColOpenDoc
        '
        Me.ColOpenDoc.Caption = "فتح"
        Me.ColOpenDoc.ColumnEdit = Me.RepositoryOpenDoc
        Me.ColOpenDoc.FieldName = "OpenDoc"
        Me.ColOpenDoc.MaxWidth = 60
        Me.ColOpenDoc.Name = "ColOpenDoc"
        Me.ColOpenDoc.Visible = True
        Me.ColOpenDoc.VisibleIndex = 17
        Me.ColOpenDoc.Width = 27
        '
        'RepositoryOpenDoc
        '
        Me.RepositoryOpenDoc.AutoHeight = False
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        Me.RepositoryOpenDoc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryOpenDoc.Name = "RepositoryOpenDoc"
        Me.RepositoryOpenDoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColAudit
        '
        Me.ColAudit.Caption = "تدقيق"
        Me.ColAudit.ColumnEdit = Me.RepositoryAudit
        Me.ColAudit.FieldName = "Audit"
        Me.ColAudit.MaxWidth = 60
        Me.ColAudit.Name = "ColAudit"
        Me.ColAudit.Visible = True
        Me.ColAudit.VisibleIndex = 16
        Me.ColAudit.Width = 33
        '
        'RepositoryAudit
        '
        Me.RepositoryAudit.AutoHeight = False
        EditorButtonImageOptions4.Image = CType(resources.GetObject("EditorButtonImageOptions4.Image"), System.Drawing.Image)
        Me.RepositoryAudit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryAudit.Name = "RepositoryAudit"
        Me.RepositoryAudit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDriver
        '
        Me.ColDriver.Caption = "السائق"
        Me.ColDriver.Name = "ColDriver"
        '
        'ColDocSort
        '
        Me.ColDocSort.Caption = "الدفتر"
        Me.ColDocSort.FieldName = "DocSort"
        Me.ColDocSort.ImageOptions.Image = CType(resources.GetObject("ColDocSort.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDocSort.MaxWidth = 70
        Me.ColDocSort.Name = "ColDocSort"
        Me.ColDocSort.Visible = True
        Me.ColDocSort.VisibleIndex = 1
        Me.ColDocSort.Width = 70
        '
        'ColDocManualNo
        '
        Me.ColDocManualNo.Caption = "رقم السند اليدوي"
        Me.ColDocManualNo.FieldName = "DocManualNo"
        Me.ColDocManualNo.ImageOptions.Image = CType(resources.GetObject("ColDocManualNo.ImageOptions.Image"), System.Drawing.Image)
        Me.ColDocManualNo.Name = "ColDocManualNo"
        Me.ColDocManualNo.Visible = True
        Me.ColDocManualNo.VisibleIndex = 3
        '
        'ColDocSortID
        '
        Me.ColDocSortID.Caption = "التصنيف"
        Me.ColDocSortID.FieldName = "DocSortID"
        Me.ColDocSortID.Name = "ColDocSortID"
        '
        'ColIDDocName
        '
        Me.ColIDDocName.Caption = "IDDocName"
        Me.ColIDDocName.FieldName = "IDDocName"
        Me.ColIDDocName.Name = "ColIDDocName"
        '
        'StockMoveDocumentsTableAdapter
        '
        Me.StockMoveDocumentsTableAdapter.ClearBeforeFill = True
        '
        'StockMoveDocStatusTableAdapter
        '
        Me.StockMoveDocStatusTableAdapter.ClearBeforeFill = True
        '
        'StockMoveDocSort1TableAdapter
        '
        Me.StockMoveDocSort1TableAdapter.ClearBeforeFill = True
        '
        'ColWalletDocID
        '
        Me.ColWalletDocID.Caption = "رقم السند ب الوالت"
        Me.ColWalletDocID.FieldName = "WalletDocID"
        Me.ColWalletDocID.Name = "ColWalletDocID"
        Me.ColWalletDocID.Visible = True
        Me.ColWalletDocID.VisibleIndex = 13
        '
        'ColDocAhditDate
        '
        Me.ColDocAhditDate.Caption = "تاريخ الترحيل"
        Me.ColDocAhditDate.FieldName = "DocAhditDate"
        Me.ColDocAhditDate.Name = "ColDocAhditDate"
        Me.ColDocAhditDate.Visible = True
        Me.ColDocAhditDate.VisibleIndex = 14
        '
        'ColDocAuditUser
        '
        Me.ColDocAuditUser.Caption = "المستخدم"
        Me.ColDocAuditUser.FieldName = "DocAuditUser"
        Me.ColDocAuditUser.Name = "ColDocAuditUser"
        Me.ColDocAuditUser.Visible = True
        Me.ColDocAuditUser.VisibleIndex = 15
        '
        'StockMoveAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 539)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "StockMoveAudit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ترحيل ارساليات الاصناف"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchDocSort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveDocSort1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookDocStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveDocStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveDocumentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDocType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDocStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDebitAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCreditAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDebitWhareHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCreditWhareHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryOpenDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColDocID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryDocType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColDocStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryDocStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColDebitAcc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryDebitAccount As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColCredAcc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryCreditAccount As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColDebitWhereHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryDebitWhareHouse As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColCreditWhereHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryCreditWhareHouse As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColReferance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCountItems As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColOpenDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryOpenDoc As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColAudit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryAudit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColDriver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocManualNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocSortID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIDDocName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchDocSort As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBook As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockMoveDocSort1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookDocStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DocType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents StockMoveDocumentsBindingSource As BindingSource
    Friend WithEvents StockMoveDocumentsTableAdapter As CRMDataSetTableAdapters.StockMoveDocumentsTableAdapter
    Friend WithEvents StockMoveDocStatusBindingSource As BindingSource
    Friend WithEvents StockMoveDocStatusTableAdapter As CRMDataSetTableAdapters.StockMoveDocStatusTableAdapter
    Friend WithEvents StockMoveDocSort1BindingSource As BindingSource
    Friend WithEvents StockMoveDocSort1TableAdapter As CRMDataSetTableAdapters.StockMoveDocSort1TableAdapter
    Friend WithEvents ColWalletDocID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocAhditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocAuditUser As DevExpress.XtraGrid.Columns.GridColumn
End Class
