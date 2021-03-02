<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockMoves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockMoves))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.ColStockBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchSalesPerson = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CarNoText = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DocManualNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DriverTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocStatusLabel = New DevExpress.XtraEditors.TextEdit()
        Me.TextAccMobile = New DevExpress.XtraEditors.TextEdit()
        Me.TextAccAddress = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DocStatus = New DevExpress.XtraEditors.TextEdit()
        Me.DebitAcc = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.InputDateTime = New DevExpress.XtraEditors.TextEdit()
        Me.CredAcc = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DocNewOld = New DevExpress.XtraEditors.TextEdit()
        Me.DocCurrency = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.SearchFromWarehouse = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNameID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchToWarehouse = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.InputUser = New DevExpress.XtraEditors.TextEdit()
        Me.Referance = New DevExpress.XtraEditors.TextEdit()
        Me.StockMoveGridControl = New DevExpress.XtraGrid.GridControl()
        Me.StockMoveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDebitAcc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCredAcc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDebitWhereHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreditWhereHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountMobile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocManualNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDriver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSalesPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocID = New DevExpress.XtraEditors.TextEdit()
        Me.DocDate = New DevExpress.XtraEditors.DateEdit()
        Me.DocType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DocSortTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.StockMoveDocSort11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.searchwarehousefrom = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchWarehouseTo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItemDocType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchVendors = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchCustomers = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StockMoveDocSort1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockMoveTableAdapter = New DXApplication5.CRMDataSetTableAdapters.StockMoveTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.ItemsTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.ItemsTableAdapter()
        Me.StockMoveDocSort1TableAdapter = New DXApplication5.CRMDataSetTableAdapters.StockMoveDocSort1TableAdapter()
        Me.StockMoveDocSort11TableAdapter = New DXApplication5.CRMDataSetTableAdapters.StockMoveDocSort11TableAdapter()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchSalesPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarNoText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocManualNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocStatusLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextAccMobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextAccAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DebitAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputDateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CredAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocNewOld.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchFromWarehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchToWarehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Referance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocSortTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveDocSort11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchwarehousefrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchWarehouseTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItemDocType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockMoveDocSort1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColStockBalance
        '
        Me.ColStockBalance.Caption = "الرصيد"
        Me.ColStockBalance.FieldName = "StockBalance"
        Me.ColStockBalance.Name = "ColStockBalance"
        Me.ColStockBalance.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.ColStockBalance.Visible = True
        Me.ColStockBalance.VisibleIndex = 6
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Appearance.ControlFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LayoutControl1.Appearance.ControlFocused.BackColor2 = System.Drawing.Color.White
        Me.LayoutControl1.Appearance.ControlFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LayoutControl1.Appearance.ControlFocused.Options.UseBackColor = True
        Me.LayoutControl1.Appearance.ControlFocused.Options.UseBorderColor = True
        Me.LayoutControl1.Controls.Add(Me.SearchSalesPerson)
        Me.LayoutControl1.Controls.Add(Me.CarNoText)
        Me.LayoutControl1.Controls.Add(Me.PictureEdit1)
        Me.LayoutControl1.Controls.Add(Me.DocManualNoTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DriverTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocStatusLabel)
        Me.LayoutControl1.Controls.Add(Me.TextAccMobile)
        Me.LayoutControl1.Controls.Add(Me.TextAccAddress)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.DocStatus)
        Me.LayoutControl1.Controls.Add(Me.DebitAcc)
        Me.LayoutControl1.Controls.Add(Me.InputDateTime)
        Me.LayoutControl1.Controls.Add(Me.CredAcc)
        Me.LayoutControl1.Controls.Add(Me.DocNewOld)
        Me.LayoutControl1.Controls.Add(Me.DocCurrency)
        Me.LayoutControl1.Controls.Add(Me.Notes)
        Me.LayoutControl1.Controls.Add(Me.SearchFromWarehouse)
        Me.LayoutControl1.Controls.Add(Me.SearchToWarehouse)
        Me.LayoutControl1.Controls.Add(Me.InputUser)
        Me.LayoutControl1.Controls.Add(Me.Referance)
        Me.LayoutControl1.Controls.Add(Me.StockMoveGridControl)
        Me.LayoutControl1.Controls.Add(Me.DocID)
        Me.LayoutControl1.Controls.Add(Me.DocDate)
        Me.LayoutControl1.Controls.Add(Me.DocType)
        Me.LayoutControl1.Controls.Add(Me.DocSortTextEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(971, 186, 450, 400)
        Me.LayoutControl1.OptionsFocus.MoveFocusRightToLeft = True
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(838, 534)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchSalesPerson
        '
        Me.SearchSalesPerson.Location = New System.Drawing.Point(553, 108)
        Me.SearchSalesPerson.Name = "SearchSalesPerson"
        Me.SearchSalesPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchSalesPerson.Properties.DisplayMember = "FullName"
        Me.SearchSalesPerson.Properties.NullText = ""
        Me.SearchSalesPerson.Properties.PopupView = Me.GridView3
        Me.SearchSalesPerson.Properties.ValueMember = "AccountKey"
        Me.SearchSalesPerson.Size = New System.Drawing.Size(198, 20)
        Me.SearchSalesPerson.StyleController = Me.LayoutControl1
        Me.SearchSalesPerson.TabIndex = 30
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'CarNoText
        '
        Me.CarNoText.Location = New System.Drawing.Point(154, 132)
        Me.CarNoText.Name = "CarNoText"
        Me.CarNoText.Size = New System.Drawing.Size(113, 20)
        Me.CarNoText.StyleController = Me.LayoutControl1
        Me.CarNoText.TabIndex = 29
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.DXApplication5.My.Resources.Resources.oil
        Me.PictureEdit1.Location = New System.Drawing.Point(318, 36)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.InitialImageOptions.Image = Global.DXApplication5.My.Resources.Resources.oil
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(86, 20)
        Me.PictureEdit1.StyleController = Me.LayoutControl1
        Me.PictureEdit1.TabIndex = 28
        '
        'DocManualNoTextEdit
        '
        Me.DocManualNoTextEdit.Location = New System.Drawing.Point(12, 36)
        Me.DocManualNoTextEdit.Name = "DocManualNoTextEdit"
        Me.DocManualNoTextEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DocManualNoTextEdit.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.DocManualNoTextEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DocManualNoTextEdit.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.DocManualNoTextEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DocManualNoTextEdit.Size = New System.Drawing.Size(125, 20)
        Me.DocManualNoTextEdit.StyleController = Me.LayoutControl1
        Me.DocManualNoTextEdit.TabIndex = 27
        '
        'DriverTextEdit
        '
        Me.DriverTextEdit.Location = New System.Drawing.Point(12, 132)
        Me.DriverTextEdit.Name = "DriverTextEdit"
        Me.DriverTextEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DriverTextEdit.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.DriverTextEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DriverTextEdit.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.DriverTextEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DriverTextEdit.Size = New System.Drawing.Size(95, 20)
        Me.DriverTextEdit.StyleController = Me.LayoutControl1
        Me.DriverTextEdit.TabIndex = 25
        '
        'DocStatusLabel
        '
        Me.DocStatusLabel.Location = New System.Drawing.Point(12, 502)
        Me.DocStatusLabel.Name = "DocStatusLabel"
        Me.DocStatusLabel.Properties.ReadOnly = True
        Me.DocStatusLabel.Size = New System.Drawing.Size(68, 20)
        Me.DocStatusLabel.StyleController = Me.LayoutControl1
        Me.DocStatusLabel.TabIndex = 11
        '
        'TextAccMobile
        '
        Me.TextAccMobile.Location = New System.Drawing.Point(84, 108)
        Me.TextAccMobile.Name = "TextAccMobile"
        Me.TextAccMobile.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextAccMobile.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.TextAccMobile.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextAccMobile.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextAccMobile.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TextAccMobile.Size = New System.Drawing.Size(107, 20)
        Me.TextAccMobile.StyleController = Me.LayoutControl1
        Me.TextAccMobile.TabIndex = 10
        '
        'TextAccAddress
        '
        Me.TextAccAddress.Location = New System.Drawing.Point(270, 108)
        Me.TextAccAddress.Name = "TextAccAddress"
        Me.TextAccAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextAccAddress.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.TextAccAddress.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextAccAddress.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextAccAddress.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TextAccAddress.Size = New System.Drawing.Size(204, 20)
        Me.TextAccAddress.StyleController = Me.LayoutControl1
        Me.TextAccAddress.TabIndex = 9
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 476)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(68, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "طباعة"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(84, 476)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(65, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "حفظ F3"
        '
        'DocStatus
        '
        Me.DocStatus.Location = New System.Drawing.Point(84, 502)
        Me.DocStatus.Name = "DocStatus"
        Me.DocStatus.Properties.ReadOnly = True
        Me.DocStatus.Size = New System.Drawing.Size(69, 20)
        Me.DocStatus.StyleController = Me.LayoutControl1
        Me.DocStatus.TabIndex = 4
        '
        'DebitAcc
        '
        Me.DebitAcc.Location = New System.Drawing.Point(578, 84)
        Me.DebitAcc.Name = "DebitAcc"
        Me.DebitAcc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DebitAcc.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.DebitAcc.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DebitAcc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.DebitAcc.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DebitAcc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DebitAcc.Properties.DisplayMember = "FullName"
        Me.DebitAcc.Properties.NullText = ""
        Me.DebitAcc.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.DebitAcc.Properties.ValueMember = "AccountKey"
        Me.DebitAcc.Size = New System.Drawing.Size(173, 20)
        Me.DebitAcc.StyleController = Me.LayoutControl1
        Me.DebitAcc.TabIndex = 3
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'InputDateTime
        '
        Me.InputDateTime.Location = New System.Drawing.Point(157, 502)
        Me.InputDateTime.Name = "InputDateTime"
        Me.InputDateTime.Properties.ReadOnly = True
        Me.InputDateTime.Size = New System.Drawing.Size(139, 20)
        Me.InputDateTime.StyleController = Me.LayoutControl1
        Me.InputDateTime.TabIndex = 3
        '
        'CredAcc
        '
        Me.CredAcc.Location = New System.Drawing.Point(325, 84)
        Me.CredAcc.Name = "CredAcc"
        Me.CredAcc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CredAcc.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.CredAcc.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CredAcc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.CredAcc.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CredAcc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CredAcc.Properties.DisplayMember = "FullName"
        Me.CredAcc.Properties.NullText = ""
        Me.CredAcc.Properties.PopupView = Me.GridView2
        Me.CredAcc.Properties.ValueMember = "AccountKey"
        Me.CredAcc.Size = New System.Drawing.Size(174, 20)
        Me.CredAcc.StyleController = Me.LayoutControl1
        Me.CredAcc.TabIndex = 4
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'DocNewOld
        '
        Me.DocNewOld.Location = New System.Drawing.Point(489, 502)
        Me.DocNewOld.Name = "DocNewOld"
        Me.DocNewOld.Properties.ReadOnly = True
        Me.DocNewOld.Size = New System.Drawing.Size(155, 20)
        Me.DocNewOld.StyleController = Me.LayoutControl1
        Me.DocNewOld.TabIndex = 1
        '
        'DocCurrency
        '
        Me.DocCurrency.EditValue = "NIS"
        Me.DocCurrency.Location = New System.Drawing.Point(300, 502)
        Me.DocCurrency.Name = "DocCurrency"
        Me.DocCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocCurrency.Properties.Items.AddRange(New Object() {"NIS", "USD", "JD"})
        Me.DocCurrency.Properties.ReadOnly = True
        Me.DocCurrency.Size = New System.Drawing.Size(185, 20)
        Me.DocCurrency.StyleController = Me.LayoutControl1
        Me.DocCurrency.TabIndex = 2
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(12, 412)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(814, 60)
        Me.Notes.StyleController = Me.LayoutControl1
        Me.Notes.TabIndex = 2
        '
        'SearchFromWarehouse
        '
        Me.SearchFromWarehouse.EditValue = ""
        Me.SearchFromWarehouse.Location = New System.Drawing.Point(558, 132)
        Me.SearchFromWarehouse.Name = "SearchFromWarehouse"
        Me.SearchFromWarehouse.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SearchFromWarehouse.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.SearchFromWarehouse.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchFromWarehouse.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.SearchFromWarehouse.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.SearchFromWarehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchFromWarehouse.Properties.DisplayMember = "Name"
        Me.SearchFromWarehouse.Properties.NullText = ""
        Me.SearchFromWarehouse.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.SearchFromWarehouse.Properties.ValueMember = "NameID"
        Me.SearchFromWarehouse.Size = New System.Drawing.Size(193, 20)
        Me.SearchFromWarehouse.StyleController = Me.LayoutControl1
        Me.SearchFromWarehouse.TabIndex = 6
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
        'SearchToWarehouse
        '
        Me.SearchToWarehouse.Location = New System.Drawing.Point(309, 132)
        Me.SearchToWarehouse.Name = "SearchToWarehouse"
        Me.SearchToWarehouse.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SearchToWarehouse.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.SearchToWarehouse.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchToWarehouse.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.SearchToWarehouse.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.SearchToWarehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchToWarehouse.Properties.DisplayMember = "Name"
        Me.SearchToWarehouse.Properties.NullText = ""
        Me.SearchToWarehouse.Properties.PopupView = Me.SearchLookUpEdit3View
        Me.SearchToWarehouse.Properties.ValueMember = "NameID"
        Me.SearchToWarehouse.Size = New System.Drawing.Size(170, 20)
        Me.SearchToWarehouse.StyleController = Me.LayoutControl1
        Me.SearchToWarehouse.TabIndex = 7
        '
        'SearchLookUpEdit3View
        '
        Me.SearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit3View.Name = "SearchLookUpEdit3View"
        Me.SearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'InputUser
        '
        Me.InputUser.Location = New System.Drawing.Point(648, 502)
        Me.InputUser.Name = "InputUser"
        Me.InputUser.Properties.ReadOnly = True
        Me.InputUser.Size = New System.Drawing.Size(178, 20)
        Me.InputUser.StyleController = Me.LayoutControl1
        Me.InputUser.TabIndex = 0
        '
        'Referance
        '
        Me.Referance.Location = New System.Drawing.Point(12, 84)
        Me.Referance.Name = "Referance"
        Me.Referance.Properties.ReadOnly = True
        Me.Referance.Size = New System.Drawing.Size(80, 20)
        Me.Referance.StyleController = Me.LayoutControl1
        Me.Referance.TabIndex = 5
        '
        'StockMoveGridControl
        '
        Me.StockMoveGridControl.DataSource = Me.StockMoveBindingSource
        Me.StockMoveGridControl.Location = New System.Drawing.Point(12, 180)
        Me.StockMoveGridControl.MainView = Me.GridView1
        Me.StockMoveGridControl.Name = "StockMoveGridControl"
        Me.StockMoveGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItem})
        Me.StockMoveGridControl.Size = New System.Drawing.Size(814, 228)
        Me.StockMoveGridControl.TabIndex = 0
        Me.StockMoveGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StockMoveBindingSource
        '
        Me.StockMoveBindingSource.DataMember = "StockMove"
        Me.StockMoveBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colDocID, Me.colDocDate, Me.colDocType, Me.colDocStatus, Me.colDocCurrency, Me.colDebitAcc, Me.colCredAcc, Me.colStockID, Me.colQuantity, Me.colItemPrice, Me.colAmount, Me.colUnit, Me.colDebitWhereHouse, Me.colCreditWhereHouse, Me.colNotes, Me.colReferance, Me.colStockName, Me.colInputUser, Me.colInputDateTime, Me.ColStockBalance, Me.colAccountMobile, Me.colAccountAddress, Me.colDocManualNo, Me.colDocSort, Me.colDriver, Me.ColDiff, Me.colCarNo, Me.ColSalesPerson})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.ColStockBalance
        GridFormatRule1.ColumnApplyTo = Me.ColStockBalance
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.AllowAnimation = DevExpress.Utils.DefaultBoolean.[True]
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue1.PredefinedName = "Red Fill"
        FormatConditionRuleValue1.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.StockMoveGridControl
        Me.GridView1.IndicatorWidth = 25
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colDocID
        '
        Me.colDocID.FieldName = "DocID"
        Me.colDocID.Name = "colDocID"
        '
        'colDocDate
        '
        Me.colDocDate.FieldName = "DocDate"
        Me.colDocDate.Name = "colDocDate"
        '
        'colDocType
        '
        Me.colDocType.FieldName = "DocType"
        Me.colDocType.Name = "colDocType"
        '
        'colDocStatus
        '
        Me.colDocStatus.FieldName = "DocStatus"
        Me.colDocStatus.Name = "colDocStatus"
        '
        'colDocCurrency
        '
        Me.colDocCurrency.FieldName = "DocCurrency"
        Me.colDocCurrency.Name = "colDocCurrency"
        '
        'colDebitAcc
        '
        Me.colDebitAcc.FieldName = "DebitAcc"
        Me.colDebitAcc.Name = "colDebitAcc"
        '
        'colCredAcc
        '
        Me.colCredAcc.FieldName = "CredAcc"
        Me.colCredAcc.Name = "colCredAcc"
        '
        'colStockID
        '
        Me.colStockID.Caption = "الصنف"
        Me.colStockID.ColumnEdit = Me.RepositoryItem
        Me.colStockID.FieldName = "StockID"
        Me.colStockID.Name = "colStockID"
        Me.colStockID.Visible = True
        Me.colStockID.VisibleIndex = 0
        '
        'RepositoryItem
        '
        Me.RepositoryItem.AutoHeight = False
        Me.RepositoryItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItem.DataSource = Me.ItemsBindingSource
        Me.RepositoryItem.DisplayMember = "ItemKey"
        Me.RepositoryItem.Name = "RepositoryItem"
        Me.RepositoryItem.NullText = "اختر صنف "
        Me.RepositoryItem.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositoryItem.ValueMember = "ItemKey"
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
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemKey, Me.colItemName})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemKey
        '
        Me.colItemKey.Caption = "رقم"
        Me.colItemKey.FieldName = "ItemKey"
        Me.colItemKey.Name = "colItemKey"
        Me.colItemKey.Visible = True
        Me.colItemKey.VisibleIndex = 0
        '
        'colItemName
        '
        Me.colItemName.Caption = "الصنف"
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 1
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "الكمية"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        '
        'colItemPrice
        '
        Me.colItemPrice.Caption = "السعر"
        Me.colItemPrice.FieldName = "ItemPrice"
        Me.colItemPrice.Name = "colItemPrice"
        Me.colItemPrice.Visible = True
        Me.colItemPrice.VisibleIndex = 4
        '
        'colAmount
        '
        Me.colAmount.Caption = "المبلغ"
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "المجموع {0}")})
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 5
        '
        'colUnit
        '
        Me.colUnit.Caption = "الوحدة"
        Me.colUnit.FieldName = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.Visible = True
        Me.colUnit.VisibleIndex = 2
        '
        'colDebitWhereHouse
        '
        Me.colDebitWhereHouse.FieldName = "DebitWhereHouse"
        Me.colDebitWhereHouse.Name = "colDebitWhereHouse"
        '
        'colCreditWhereHouse
        '
        Me.colCreditWhereHouse.FieldName = "CreditWhereHouse"
        Me.colCreditWhereHouse.Name = "colCreditWhereHouse"
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'colReferance
        '
        Me.colReferance.Caption = "المرجع"
        Me.colReferance.FieldName = "Referance"
        Me.colReferance.Name = "colReferance"
        '
        'colStockName
        '
        Me.colStockName.Caption = "الصنف"
        Me.colStockName.FieldName = "StockName"
        Me.colStockName.Name = "colStockName"
        Me.colStockName.Visible = True
        Me.colStockName.VisibleIndex = 1
        '
        'colInputUser
        '
        Me.colInputUser.FieldName = "InputUser"
        Me.colInputUser.Name = "colInputUser"
        '
        'colInputDateTime
        '
        Me.colInputDateTime.FieldName = "InputDateTime"
        Me.colInputDateTime.Name = "colInputDateTime"
        '
        'colAccountMobile
        '
        Me.colAccountMobile.FieldName = "AccountMobile"
        Me.colAccountMobile.Name = "colAccountMobile"
        '
        'colAccountAddress
        '
        Me.colAccountAddress.FieldName = "AccountAddress"
        Me.colAccountAddress.Name = "colAccountAddress"
        '
        'colDocManualNo
        '
        Me.colDocManualNo.FieldName = "DocManualNo"
        Me.colDocManualNo.Name = "colDocManualNo"
        '
        'colDocSort
        '
        Me.colDocSort.FieldName = "DocSort"
        Me.colDocSort.Name = "colDocSort"
        '
        'colDriver
        '
        Me.colDriver.FieldName = "Driver"
        Me.colDriver.Name = "colDriver"
        '
        'ColDiff
        '
        Me.ColDiff.Caption = "الفرق"
        Me.ColDiff.FieldName = "Diff"
        Me.ColDiff.Name = "ColDiff"
        Me.ColDiff.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'colCarNo
        '
        Me.colCarNo.Caption = "رقم المركبة"
        Me.colCarNo.FieldName = "CarNo"
        Me.colCarNo.Name = "colCarNo"
        '
        'ColSalesPerson
        '
        Me.ColSalesPerson.Caption = "مندوب المبيعات"
        Me.ColSalesPerson.FieldName = "SalesPerson"
        Me.ColSalesPerson.Name = "ColSalesPerson"
        '
        'DocID
        '
        Me.DocID.Location = New System.Drawing.Point(646, 60)
        Me.DocID.Name = "DocID"
        Me.DocID.Properties.ReadOnly = True
        Me.DocID.Size = New System.Drawing.Size(105, 20)
        Me.DocID.StyleController = Me.LayoutControl1
        Me.DocID.TabIndex = 1
        '
        'DocDate
        '
        Me.DocDate.EditValue = Nothing
        Me.DocDate.Location = New System.Drawing.Point(12, 60)
        Me.DocDate.Name = "DocDate"
        Me.DocDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocDate.Size = New System.Drawing.Size(155, 20)
        Me.DocDate.StyleController = Me.LayoutControl1
        Me.DocDate.TabIndex = 2
        '
        'DocType
        '
        Me.DocType.Location = New System.Drawing.Point(12, 12)
        Me.DocType.Name = "DocType"
        Me.DocType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocType.Properties.Items.AddRange(New Object() {"SalesDelivery", "PurchaseDelivery", "SalesVoucher", "PurchaseVoucher", "SalesReturn", "PurchaseReturn", "Transfer", "Jard"})
        Me.DocType.Size = New System.Drawing.Size(739, 20)
        Me.DocType.StyleController = Me.LayoutControl1
        Me.DocType.TabIndex = 0
        Me.DocType.Visible = False
        '
        'DocSortTextEdit
        '
        Me.DocSortTextEdit.Location = New System.Drawing.Point(596, 36)
        Me.DocSortTextEdit.Name = "DocSortTextEdit"
        Me.DocSortTextEdit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Gainsboro
        Me.DocSortTextEdit.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.DocSortTextEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DocSortTextEdit.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.DocSortTextEdit.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DocSortTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocSortTextEdit.Properties.DataSource = Me.StockMoveDocSort11BindingSource
        Me.DocSortTextEdit.Properties.DisplayMember = "StockMoveDocSort1"
        Me.DocSortTextEdit.Properties.NullText = ""
        Me.DocSortTextEdit.Properties.ValueMember = "Book"
        Me.DocSortTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.DocSortTextEdit.StyleController = Me.LayoutControl1
        Me.DocSortTextEdit.TabIndex = 26
        '
        'StockMoveDocSort11BindingSource
        '
        Me.StockMoveDocSort11BindingSource.DataMember = "StockMoveDocSort11"
        Me.StockMoveDocSort11BindingSource.DataSource = Me.CRMDataSet
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.searchwarehousefrom, Me.SearchWarehouseTo, Me.EmptySpaceItem2, Me.LayoutControlItemDocType, Me.EmptySpaceItem3, Me.LayoutControlItem5, Me.SearchVendors, Me.SearchCustomers, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem10, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.EmptySpaceItem6, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.LayoutControlItem2, Me.LayoutControlItem20, Me.LayoutControlItem21})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(838, 534)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DocDate
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem1.Text = "التاريخ"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DocID
        Me.LayoutControlItem4.Location = New System.Drawing.Point(634, 48)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "رقم السند"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(72, 13)
        '
        'searchwarehousefrom
        '
        Me.searchwarehousefrom.Control = Me.SearchToWarehouse
        Me.searchwarehousefrom.Location = New System.Drawing.Point(297, 120)
        Me.searchwarehousefrom.Name = "searchwarehousefrom"
        Me.searchwarehousefrom.Size = New System.Drawing.Size(249, 24)
        Me.searchwarehousefrom.Text = "الى مستودع"
        Me.searchwarehousefrom.TextSize = New System.Drawing.Size(72, 13)
        '
        'SearchWarehouseTo
        '
        Me.SearchWarehouseTo.Control = Me.SearchFromWarehouse
        Me.SearchWarehouseTo.Location = New System.Drawing.Point(546, 120)
        Me.SearchWarehouseTo.MinSize = New System.Drawing.Size(129, 24)
        Me.SearchWarehouseTo.Name = "SearchWarehouseTo"
        Me.SearchWarehouseTo.Size = New System.Drawing.Size(272, 24)
        Me.SearchWarehouseTo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SearchWarehouseTo.Text = "من مستودع"
        Me.SearchWarehouseTo.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(159, 72)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(154, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItemDocType
        '
        Me.LayoutControlItemDocType.Control = Me.DocType
        Me.LayoutControlItemDocType.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItemDocType.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItemDocType.Name = "LayoutControlItemDocType"
        Me.LayoutControlItemDocType.Size = New System.Drawing.Size(818, 24)
        Me.LayoutControlItemDocType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItemDocType.Text = "نوع السند"
        Me.LayoutControlItemDocType.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(234, 48)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(400, 24)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Referance
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem5.Text = "المرجع"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(72, 13)
        '
        'SearchVendors
        '
        Me.SearchVendors.Control = Me.CredAcc
        Me.SearchVendors.Location = New System.Drawing.Point(313, 72)
        Me.SearchVendors.Name = "SearchVendors"
        Me.SearchVendors.Size = New System.Drawing.Size(253, 24)
        Me.SearchVendors.Text = "المورد"
        Me.SearchVendors.TextSize = New System.Drawing.Size(72, 13)
        '
        'SearchCustomers
        '
        Me.SearchCustomers.Control = Me.DebitAcc
        Me.SearchCustomers.Location = New System.Drawing.Point(566, 72)
        Me.SearchCustomers.MinSize = New System.Drawing.Size(129, 24)
        Me.SearchCustomers.Name = "SearchCustomers"
        Me.SearchCustomers.Size = New System.Drawing.Size(252, 24)
        Me.SearchCustomers.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SearchCustomers.Text = "الزبون"
        Me.SearchCustomers.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.StockMoveGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(818, 232)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Notes
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 400)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(14, 20)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(818, 64)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.InputUser
        Me.LayoutControlItem6.Location = New System.Drawing.Point(636, 490)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(54, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(182, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DocNewOld
        Me.LayoutControlItem8.Location = New System.Drawing.Point(477, 490)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.DocCurrency
        Me.LayoutControlItem9.Location = New System.Drawing.Point(288, 490)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(189, 24)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.InputDateTime
        Me.LayoutControlItem11.Location = New System.Drawing.Point(145, 490)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(143, 24)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.DocStatus
        Me.LayoutControlItem12.Location = New System.Drawing.Point(72, 490)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(73, 24)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(72, 464)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(69, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(141, 464)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(677, 26)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 144)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(818, 24)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SimpleButton2
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 464)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(72, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.TextAccMobile
        Me.LayoutControlItem15.Location = New System.Drawing.Point(72, 96)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(186, 24)
        Me.LayoutControlItem15.Text = "رقم الموبايل"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.TextAccAddress
        Me.LayoutControlItem14.Location = New System.Drawing.Point(258, 96)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(283, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "العنوان"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(72, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.DocStatusLabel
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 490)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(72, 24)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.DriverTextEdit
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem17.Text = "السائق:"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.DocSortTextEdit
        Me.LayoutControlItem18.Location = New System.Drawing.Point(584, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(129, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "نوع السند"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.DocManualNoTextEdit
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem19.Text = "رقم سند يدوي:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(204, 24)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(102, 24)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(396, 24)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(188, 24)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PictureEdit1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(306, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(90, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.CarNoText
        Me.LayoutControlItem20.Location = New System.Drawing.Point(142, 120)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(155, 24)
        Me.LayoutControlItem20.Text = "المركبة"
        Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(33, 13)
        Me.LayoutControlItem20.TextToControlDistance = 5
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.SearchSalesPerson
        Me.LayoutControlItem21.Location = New System.Drawing.Point(541, 96)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(277, 24)
        Me.LayoutControlItem21.Text = "مندوب المبيعات"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(72, 13)
        '
        'StockMoveDocSort1BindingSource
        '
        Me.StockMoveDocSort1BindingSource.DataMember = "StockMoveDocSort1"
        Me.StockMoveDocSort1BindingSource.DataSource = Me.CRMDataSet
        '
        'StockMoveTableAdapter
        '
        Me.StockMoveTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DATATableAdapter = Nothing
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
        Me.TableAdapterManager.StockMoveTableAdapter = Me.StockMoveTableAdapter
        Me.TableAdapterManager.transDocTableAdapter = Nothing
        Me.TableAdapterManager.transTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'StockMoveDocSort1TableAdapter
        '
        Me.StockMoveDocSort1TableAdapter.ClearBeforeFill = True
        '
        'StockMoveDocSort11TableAdapter
        '
        Me.StockMoveDocSort11TableAdapter.ClearBeforeFill = True
        '
        'StockMoves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 534)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "StockMoves"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فاتورة"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchSalesPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarNoText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocManualNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocStatusLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextAccMobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextAccAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DebitAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputDateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CredAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocNewOld.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchFromWarehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchToWarehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Referance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocSortTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveDocSort11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchwarehousefrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchWarehouseTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItemDocType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockMoveDocSort1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents StockMoveBindingSource As BindingSource
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents StockMoveTableAdapter As CRMDataSetTableAdapters.StockMoveTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockMoveGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocCurrency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebitAcc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredAcc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebitWhereHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreditWhereHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DocType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItemDocType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchToWarehouse As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents InputUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Referance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents searchwarehousefrom As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DocCurrency As DevExpress.XtraEditors.ComboBoxEdit

    Friend WithEvents SearchFromWarehouse As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchWarehouseTo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColNameID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CredAcc As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchVendors As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colInputUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DebitAcc As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchCustomers As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItem As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As WizCountDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents colItemKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocNewOld As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents InputDateTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ColStockBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextAccMobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextAccAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colAccountMobile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DocStatusLabel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DriverTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DocManualNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DocSortTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents StockMoveDocSort1BindingSource As BindingSource
    Friend WithEvents StockMoveDocSort1TableAdapter As CRMDataSetTableAdapters.StockMoveDocSort1TableAdapter
    Friend WithEvents colDocManualNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDriver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StockMoveDocSort11BindingSource As BindingSource
    Friend WithEvents StockMoveDocSort11TableAdapter As CRMDataSetTableAdapters.StockMoveDocSort11TableAdapter
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColDiff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CarNoText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCarNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SearchSalesPerson As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColSalesPerson As DevExpress.XtraGrid.Columns.GridColumn
End Class
