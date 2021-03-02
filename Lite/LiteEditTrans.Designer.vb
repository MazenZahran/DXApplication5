<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiteEditTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiteEditTrans))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.MeansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HO_DATADataSet = New DXApplication5.HO_DATADataSet()
        Me.Accounts1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.DATAGridControl = New DevExpress.XtraGrid.GridControl()
        Me.DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTransID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.colFleet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVehicle_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colTotalSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStationName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFleetCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryAccounts = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDeviceName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdometer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositorySearchVechile_Number = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryCars = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Accounts1TableAdapter = New DXApplication5.WizCountDataSetTableAdapters.Accounts1TableAdapter()
        Me.MeansTableAdapter = New DXApplication5.HO_DATADataSetTableAdapters.meansTableAdapter()
        Me.DATATableAdapter = New DXApplication5.CRMDataSetTableAdapters.DATATableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DATAGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorySearchVechile_Number, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'MeansBindingSource
        '
        Me.MeansBindingSource.DataMember = "means"
        Me.MeansBindingSource.DataSource = Me.HO_DATADataSet
        '
        'HO_DATADataSet
        '
        Me.HO_DATADataSet.DataSetName = "HO_DATADataSet"
        Me.HO_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.DATAGridControl)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(983, 476)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(805, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(78, 36)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "حذف"
        '
        'DATAGridControl
        '
        Me.DATAGridControl.DataSource = Me.DATABindingSource
        Me.DATAGridControl.Location = New System.Drawing.Point(12, 52)
        Me.DATAGridControl.MainView = Me.GridView1
        Me.DATAGridControl.Name = "DATAGridControl"
        Me.DATAGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositorySearchVechile_Number, Me.RepositoryCars, Me.RepositoryAccounts, Me.RepositoryItemTimeEdit1, Me.RepositoryItemCalcEdit1})
        Me.DATAGridControl.Size = New System.Drawing.Size(959, 412)
        Me.DATAGridControl.TabIndex = 5
        Me.DATAGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DATABindingSource
        '
        Me.DATABindingSource.DataMember = "DATA"
        Me.DATABindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransID, Me.colSerNo, Me.colTransDate, Me.colTransTime, Me.colFleet, Me.colVehicle_Number, Me.colProductName, Me.colQuantity, Me.colTotalSale, Me.colStationName, Me.colReceipt, Me.colFleetCode, Me.colDeviceName, Me.colTransMonth, Me.colTransYear, Me.colOdometer, Me.colProductCode, Me.colPrice, Me.colID})
        Me.GridView1.GridControl = Me.DATAGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colTransID
        '
        Me.colTransID.FieldName = "TransID"
        Me.colTransID.Name = "colTransID"
        '
        'colSerNo
        '
        Me.colSerNo.FieldName = "SerNo"
        Me.colSerNo.Name = "colSerNo"
        '
        'colTransDate
        '
        Me.colTransDate.FieldName = "TransDate"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.Visible = True
        Me.colTransDate.VisibleIndex = 1
        Me.colTransDate.Width = 70
        '
        'colTransTime
        '
        Me.colTransTime.ColumnEdit = Me.RepositoryItemTimeEdit1
        Me.colTransTime.FieldName = "TransTime"
        Me.colTransTime.Name = "colTransTime"
        Me.colTransTime.Visible = True
        Me.colTransTime.VisibleIndex = 4
        Me.colTransTime.Width = 70
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'colFleet
        '
        Me.colFleet.FieldName = "Fleet"
        Me.colFleet.Name = "colFleet"
        Me.colFleet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fleet", "{0}")})
        Me.colFleet.Visible = True
        Me.colFleet.VisibleIndex = 6
        Me.colFleet.Width = 126
        '
        'colVehicle_Number
        '
        Me.colVehicle_Number.FieldName = "Vehicle_Number"
        Me.colVehicle_Number.Name = "colVehicle_Number"
        Me.colVehicle_Number.Visible = True
        Me.colVehicle_Number.VisibleIndex = 7
        Me.colVehicle_Number.Width = 62
        '
        'colProductName
        '
        Me.colProductName.FieldName = "ProductName"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.Visible = True
        Me.colProductName.VisibleIndex = 8
        Me.colProductName.Width = 62
        '
        'colQuantity
        '
        Me.colQuantity.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colQuantity.DisplayFormat.FormatString = "n3"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 9
        Me.colQuantity.Width = 62
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'colTotalSale
        '
        Me.colTotalSale.FieldName = "TotalSale"
        Me.colTotalSale.Name = "colTotalSale"
        Me.colTotalSale.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSale", "{0}")})
        Me.colTotalSale.Visible = True
        Me.colTotalSale.VisibleIndex = 10
        Me.colTotalSale.Width = 62
        '
        'colStationName
        '
        Me.colStationName.FieldName = "StationName"
        Me.colStationName.Name = "colStationName"
        Me.colStationName.Visible = True
        Me.colStationName.VisibleIndex = 11
        Me.colStationName.Width = 74
        '
        'colReceipt
        '
        Me.colReceipt.FieldName = "Receipt"
        Me.colReceipt.Name = "colReceipt"
        Me.colReceipt.Visible = True
        Me.colReceipt.VisibleIndex = 12
        Me.colReceipt.Width = 88
        '
        'colFleetCode
        '
        Me.colFleetCode.ColumnEdit = Me.RepositoryAccounts
        Me.colFleetCode.FieldName = "FleetCode"
        Me.colFleetCode.Name = "colFleetCode"
        Me.colFleetCode.Visible = True
        Me.colFleetCode.VisibleIndex = 5
        Me.colFleetCode.Width = 70
        '
        'RepositoryAccounts
        '
        Me.RepositoryAccounts.AutoHeight = False
        Me.RepositoryAccounts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryAccounts.DataSource = Me.Accounts1BindingSource
        Me.RepositoryAccounts.DisplayMember = "AccountKey"
        Me.RepositoryAccounts.Name = "RepositoryAccounts"
        Me.RepositoryAccounts.PopupView = Me.GridView2
        Me.RepositoryAccounts.ValueMember = "AccountKey"
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colDeviceName
        '
        Me.colDeviceName.FieldName = "DeviceName"
        Me.colDeviceName.Name = "colDeviceName"
        Me.colDeviceName.Width = 45
        '
        'colTransMonth
        '
        Me.colTransMonth.FieldName = "TransMonth"
        Me.colTransMonth.Name = "colTransMonth"
        Me.colTransMonth.Visible = True
        Me.colTransMonth.VisibleIndex = 2
        Me.colTransMonth.Width = 70
        '
        'colTransYear
        '
        Me.colTransYear.FieldName = "TransYear"
        Me.colTransYear.Name = "colTransYear"
        Me.colTransYear.Visible = True
        Me.colTransYear.VisibleIndex = 3
        Me.colTransYear.Width = 70
        '
        'colOdometer
        '
        Me.colOdometer.FieldName = "Odometer"
        Me.colOdometer.Name = "colOdometer"
        '
        'colProductCode
        '
        Me.colProductCode.FieldName = "ProductCode"
        Me.colProductCode.Name = "colProductCode"
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 44
        '
        'RepositorySearchVechile_Number
        '
        Me.RepositorySearchVechile_Number.AutoHeight = False
        Me.RepositorySearchVechile_Number.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositorySearchVechile_Number.DataSource = Me.MeansBindingSource
        Me.RepositorySearchVechile_Number.DisplayMember = "plate"
        Me.RepositorySearchVechile_Number.Name = "RepositorySearchVechile_Number"
        Me.RepositorySearchVechile_Number.NullText = ""
        Me.RepositorySearchVechile_Number.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositorySearchVechile_Number.ValueMember = "plate"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colplate, Me.colname})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colplate
        '
        Me.colplate.FieldName = "plate"
        Me.colplate.Name = "colplate"
        Me.colplate.Visible = True
        Me.colplate.VisibleIndex = 0
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 1
        '
        'RepositoryCars
        '
        Me.RepositoryCars.AutoHeight = False
        Me.RepositoryCars.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCars.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("plate", "plate", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryCars.DataSource = Me.MeansBindingSource
        Me.RepositoryCars.DisplayMember = "plate"
        Me.RepositoryCars.Name = "RepositoryCars"
        Me.RepositoryCars.NullText = ""
        Me.RepositoryCars.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(887, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(84, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "حفظ"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(983, 476)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(875, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(88, 40)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(88, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(88, 40)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DATAGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(963, 416)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(793, 40)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(793, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(82, 40)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(82, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(82, 40)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'Accounts1TableAdapter
        '
        Me.Accounts1TableAdapter.ClearBeforeFill = True
        '
        'MeansTableAdapter
        '
        Me.MeansTableAdapter.ClearBeforeFill = True
        '
        'DATATableAdapter
        '
        Me.DATATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsAddDataTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocsSortTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocsTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocTypesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CardsTableAdapter = Nothing
        Me.TableAdapterManager.CardsTransTableAdapter = Nothing
        Me.TableAdapterManager.CarsAccidentTableAdapter = Nothing
        Me.TableAdapterManager.CarsDriversTableAdapter = Nothing
        Me.TableAdapterManager.CarsInsurancCompaniesTableAdapter = Nothing
        Me.TableAdapterManager.CarsInsuranceTransTableAdapter = Nothing
        Me.TableAdapterManager.CarsMarkaTableAdapter = Nothing
        Me.TableAdapterManager.CarsModelTableAdapter = Nothing
        Me.TableAdapterManager.CarsNotesTableAdapter = Nothing
        Me.TableAdapterManager.CarsSort2TableAdapter = Nothing
        Me.TableAdapterManager.CarsSortTableAdapter = Nothing
        Me.TableAdapterManager.carsTableAdapter = Nothing
        Me.TableAdapterManager.CarsTarkhesTransTableAdapter = Nothing
        Me.TableAdapterManager.ChequeDataTableAdapter = Nothing
        Me.TableAdapterManager.CRMCustomersOrdersTableAdapter = Nothing
        Me.TableAdapterManager.CRMJobNameTableAdapter = Nothing
        Me.TableAdapterManager.CRMTasksTableAdapter = Nothing
        Me.TableAdapterManager.DATATableAdapter = Me.DATATableAdapter
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.FinancialBanksDocTableAdapter = Nothing
        Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemDocsTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemJobsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocSort11TableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocSort1TableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocStatusTableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.StockMoveTableAdapter = Nothing
        Me.TableAdapterManager.transDocTableAdapter = Nothing
        Me.TableAdapterManager.transTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'LiteEditTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 476)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "LiteEditTrans"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "تعديل حركات على ملف الداتا"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DATAGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorySearchVechile_Number, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents Accounts1BindingSource As BindingSource
    Friend WithEvents Accounts1TableAdapter As WizCountDataSetTableAdapters.Accounts1TableAdapter
    Friend WithEvents HO_DATADataSet As HO_DATADataSet
    Friend WithEvents MeansBindingSource As BindingSource
    Friend WithEvents MeansTableAdapter As HO_DATADataSetTableAdapters.meansTableAdapter
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents DATABindingSource As BindingSource
    Friend WithEvents DATATableAdapter As CRMDataSetTableAdapters.DATATableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DATAGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTransID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFleet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVehicle_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStationName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceipt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFleetCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeviceName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdometer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositorySearchVechile_Number As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryCars As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryAccounts As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
End Class
