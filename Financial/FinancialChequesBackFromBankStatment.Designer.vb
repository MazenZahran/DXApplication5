<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancialChequesBackFromBankStatment
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
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialChequesBackFromBankStatment))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.FinancialChequesBackGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FinancialChequesBackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colChequesNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.Cheqs1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCheqNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrency2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuFDlr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankAccNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDepositID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDebName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTransDebID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAccID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAccountName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colChequeDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCurrency = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAmountNIS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBankAccNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colChequNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCheckPic = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryChequeImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colExchangeRate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colBankName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colInputDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colReBackDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colChequeStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colCurrency3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FinancialChequesBackTableAdapter = New DXApplication5.CRMDataSetTableAdapters.FinancialChequesBackTableAdapter()
        Me.Cheqs1TableAdapter = New DXApplication5.WizCountDataSetTableAdapters.Cheqs1TableAdapter()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.FinancialChequesBackGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinancialChequesBackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cheqs1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryChequeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DockPanel1.ID = New System.Guid("ca45d309-178d-4e02-af59-ea751176eda7")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 530)
        Me.DockPanel1.Text = "DockPanel1"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(191, 503)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LayoutControl2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.FinancialChequesBackGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(822, 530)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(596, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(214, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'FinancialChequesBackGridControl
        '
        Me.FinancialChequesBackGridControl.DataSource = Me.FinancialChequesBackBindingSource
        Me.FinancialChequesBackGridControl.Location = New System.Drawing.Point(12, 38)
        Me.FinancialChequesBackGridControl.MainView = Me.BandedGridView1
        Me.FinancialChequesBackGridControl.Name = "FinancialChequesBackGridControl"
        Me.FinancialChequesBackGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchLookUpEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryChequeImage})
        Me.FinancialChequesBackGridControl.Size = New System.Drawing.Size(798, 480)
        Me.FinancialChequesBackGridControl.TabIndex = 2
        Me.FinancialChequesBackGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'FinancialChequesBackBindingSource
        '
        Me.FinancialChequesBackBindingSource.DataMember = "FinancialChequesBack"
        Me.FinancialChequesBackBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colID, Me.colAccID, Me.colAccountName, Me.colChequesNo, Me.colBankName, Me.colAmount, Me.colChequeDate, Me.colInputDate, Me.colNotes, Me.colReBackDate, Me.colCurrency, Me.colCheckPic, Me.colChequeStatus, Me.colAmountNIS, Me.colExchangeRate, Me.colBankAccNo, Me.colChequNO, Me.ColDepositID, Me.colTransDebID, Me.colCurrency3, Me.colDebName})
        Me.BandedGridView1.GridControl = Me.FinancialChequesBackGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridBand1.Caption = "بيانات الشيك"
        Me.GridBand1.Columns.Add(Me.colID)
        Me.GridBand1.Columns.Add(Me.colChequesNo)
        Me.GridBand1.Columns.Add(Me.ColDepositID)
        Me.GridBand1.Columns.Add(Me.colDebName)
        Me.GridBand1.Columns.Add(Me.colTransDebID)
        Me.GridBand1.Columns.Add(Me.colAccID)
        Me.GridBand1.Columns.Add(Me.colAccountName)
        Me.GridBand1.Columns.Add(Me.colChequeDate)
        Me.GridBand1.Columns.Add(Me.colAmount)
        Me.GridBand1.Columns.Add(Me.colCurrency)
        Me.GridBand1.Columns.Add(Me.colAmountNIS)
        Me.GridBand1.Columns.Add(Me.colBankAccNo)
        Me.GridBand1.Columns.Add(Me.colChequNO)
        Me.GridBand1.Columns.Add(Me.colCheckPic)
        Me.GridBand1.Columns.Add(Me.colExchangeRate)
        Me.GridBand1.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 1088
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 48
        '
        'colChequesNo
        '
        Me.colChequesNo.Caption = "شيك ID"
        Me.colChequesNo.ColumnEdit = Me.RepositoryItemSearchLookUpEdit1
        Me.colChequesNo.FieldName = "ChequesNo"
        Me.colChequesNo.Name = "colChequesNo"
        Me.colChequesNo.Visible = True
        Me.colChequesNo.Width = 117
        '
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.DataSource = Me.Cheqs1BindingSource
        Me.RepositoryItemSearchLookUpEdit1.DisplayMember = "CheqNumber"
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.PopupFormMinSize = New System.Drawing.Size(1000, 0)
        Me.RepositoryItemSearchLookUpEdit1.PopupFormSize = New System.Drawing.Size(1000, 0)
        Me.RepositoryItemSearchLookUpEdit1.ValueMember = "ID"
        Me.RepositoryItemSearchLookUpEdit1.View = Me.GridView1
        '
        'Cheqs1BindingSource
        '
        Me.Cheqs1BindingSource.DataMember = "Cheqs1"
        Me.Cheqs1BindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCheqNumber, Me.colBankNumber, Me.colBranch, Me.colValueDate, Me.colSuF, Me.colCurrency2, Me.colSuFDlr, Me.colBankAccNum, Me.colAccKey, Me.colAccName, Me.colID2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 2000
        Me.GridView1.OptionsFind.FindNullPrompt = "اختر الشيك"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCheqNumber
        '
        Me.colCheqNumber.FieldName = "CheqNumber"
        Me.colCheqNumber.Name = "colCheqNumber"
        Me.colCheqNumber.Visible = True
        Me.colCheqNumber.VisibleIndex = 0
        '
        'colBankNumber
        '
        Me.colBankNumber.FieldName = "BankNumber"
        Me.colBankNumber.Name = "colBankNumber"
        Me.colBankNumber.Visible = True
        Me.colBankNumber.VisibleIndex = 1
        '
        'colBranch
        '
        Me.colBranch.FieldName = "Branch"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.Visible = True
        Me.colBranch.VisibleIndex = 2
        '
        'colValueDate
        '
        Me.colValueDate.FieldName = "ValueDate"
        Me.colValueDate.Name = "colValueDate"
        Me.colValueDate.Visible = True
        Me.colValueDate.VisibleIndex = 3
        '
        'colSuF
        '
        Me.colSuF.FieldName = "SuF"
        Me.colSuF.Name = "colSuF"
        Me.colSuF.Visible = True
        Me.colSuF.VisibleIndex = 4
        '
        'colCurrency2
        '
        Me.colCurrency2.FieldName = "Currency"
        Me.colCurrency2.Name = "colCurrency2"
        Me.colCurrency2.Visible = True
        Me.colCurrency2.VisibleIndex = 5
        '
        'colSuFDlr
        '
        Me.colSuFDlr.FieldName = "SuFDlr"
        Me.colSuFDlr.Name = "colSuFDlr"
        Me.colSuFDlr.Visible = True
        Me.colSuFDlr.VisibleIndex = 6
        '
        'colBankAccNum
        '
        Me.colBankAccNum.Caption = "رقم الحساب البنكي"
        Me.colBankAccNum.FieldName = "BankAccNum"
        Me.colBankAccNum.Name = "colBankAccNum"
        Me.colBankAccNum.Visible = True
        Me.colBankAccNum.VisibleIndex = 7
        '
        'colAccKey
        '
        Me.colAccKey.FieldName = "AccKey"
        Me.colAccKey.Name = "colAccKey"
        Me.colAccKey.Visible = True
        Me.colAccKey.VisibleIndex = 8
        '
        'colAccName
        '
        Me.colAccName.FieldName = "AccName"
        Me.colAccName.Name = "colAccName"
        Me.colAccName.Visible = True
        Me.colAccName.VisibleIndex = 9
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        Me.colID2.Visible = True
        Me.colID2.VisibleIndex = 10
        '
        'ColDepositID
        '
        Me.ColDepositID.Caption = "رقم فيشة الايداع"
        Me.ColDepositID.FieldName = "DepositID"
        Me.ColDepositID.Name = "ColDepositID"
        '
        'colDebName
        '
        Me.colDebName.Caption = "الحساب البنكي"
        Me.colDebName.FieldName = "DebName"
        Me.colDebName.Name = "colDebName"
        Me.colDebName.Visible = True
        '
        'colTransDebID
        '
        Me.colTransDebID.Caption = "رقم الحساب البنكي"
        Me.colTransDebID.FieldName = "TransDebID"
        Me.colTransDebID.Name = "colTransDebID"
        Me.colTransDebID.Visible = True
        '
        'colAccID
        '
        Me.colAccID.Caption = "رقم الحساب"
        Me.colAccID.FieldName = "AccID"
        Me.colAccID.Name = "colAccID"
        Me.colAccID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccID", "{0}")})
        Me.colAccID.Visible = True
        Me.colAccID.Width = 108
        '
        'colAccountName
        '
        Me.colAccountName.Caption = "الحساب"
        Me.colAccountName.FieldName = "AccountName"
        Me.colAccountName.Name = "colAccountName"
        Me.colAccountName.Visible = True
        Me.colAccountName.Width = 108
        '
        'colChequeDate
        '
        Me.colChequeDate.Caption = "تاريخ الاستحقاق"
        Me.colChequeDate.FieldName = "ChequeDate"
        Me.colChequeDate.Name = "colChequeDate"
        Me.colChequeDate.Visible = True
        Me.colChequeDate.Width = 105
        '
        'colAmount
        '
        Me.colAmount.Caption = "مبلغ الشيك"
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0}")})
        Me.colAmount.Visible = True
        Me.colAmount.Width = 116
        '
        'colCurrency
        '
        Me.colCurrency.Caption = "العملة"
        Me.colCurrency.FieldName = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.Visible = True
        Me.colCurrency.Width = 105
        '
        'colAmountNIS
        '
        Me.colAmountNIS.Caption = "المبلغ بالشيكل"
        Me.colAmountNIS.FieldName = "AmountNIS"
        Me.colAmountNIS.Name = "colAmountNIS"
        Me.colAmountNIS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountNIS", "{0}")})
        Me.colAmountNIS.Visible = True
        Me.colAmountNIS.Width = 98
        '
        'colBankAccNo
        '
        Me.colBankAccNo.Caption = "رقم الحساب البنكي"
        Me.colBankAccNo.FieldName = "BankAccNo"
        Me.colBankAccNo.Name = "colBankAccNo"
        Me.colBankAccNo.Visible = True
        Me.colBankAccNo.Width = 98
        '
        'colChequNO
        '
        Me.colChequNO.Caption = "رقم الشيك"
        Me.colChequNO.FieldName = "ChequNO"
        Me.colChequNO.Name = "colChequNO"
        Me.colChequNO.Width = 98
        '
        'colCheckPic
        '
        Me.colCheckPic.Caption = "صورة الشيك"
        Me.colCheckPic.ColumnEdit = Me.RepositoryChequeImage
        Me.colCheckPic.FieldName = "CheckPic"
        Me.colCheckPic.Name = "colCheckPic"
        Me.colCheckPic.Visible = True
        Me.colCheckPic.Width = 83
        '
        'RepositoryChequeImage
        '
        Me.RepositoryChequeImage.AutoHeight = False
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        Me.RepositoryChequeImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
        Me.RepositoryChequeImage.Name = "RepositoryChequeImage"
        Me.RepositoryChequeImage.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colExchangeRate
        '
        Me.colExchangeRate.Caption = "سعر الصرف"
        Me.colExchangeRate.FieldName = "ExchangeRate"
        Me.colExchangeRate.Name = "colExchangeRate"
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "بيانات الرجوع"
        Me.gridBand2.Columns.Add(Me.colBankName)
        Me.gridBand2.Columns.Add(Me.colInputDate)
        Me.gridBand2.Columns.Add(Me.colNotes)
        Me.gridBand2.Columns.Add(Me.colReBackDate)
        Me.gridBand2.Columns.Add(Me.colChequeStatus)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Visible = False
        Me.gridBand2.VisibleIndex = -1
        Me.gridBand2.Width = 543
        '
        'colBankName
        '
        Me.colBankName.Caption = "البنك"
        Me.colBankName.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Visible = True
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"الوطني", "الاسكان", "العربي", "فلسطين", "فلسطين نابلس", "الاسلامي الفلسطيني", "الاسلامي العربي", "القدس"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colInputDate
        '
        Me.colInputDate.Caption = "تاريخ الرجوع"
        Me.colInputDate.FieldName = "InputDate"
        Me.colInputDate.Name = "colInputDate"
        Me.colInputDate.Visible = True
        '
        'colNotes
        '
        Me.colNotes.Caption = "ملاحظات"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        '
        'colReBackDate
        '
        Me.colReBackDate.Caption = "تاريخ الاعادة"
        Me.colReBackDate.FieldName = "ReBackDate"
        Me.colReBackDate.Name = "colReBackDate"
        Me.colReBackDate.Visible = True
        '
        'colChequeStatus
        '
        Me.colChequeStatus.Caption = "حالة الشيك"
        Me.colChequeStatus.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colChequeStatus.FieldName = "ChequeStatus"
        Me.colChequeStatus.Name = "colChequeStatus"
        Me.colChequeStatus.Visible = True
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"راجع", "محصل"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'colCurrency3
        '
        Me.colCurrency3.Caption = "العملة"
        Me.colCurrency3.FieldName = "Currency"
        Me.colCurrency3.Name = "colCurrency3"
        Me.colCurrency3.Visible = True
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(822, 530)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.FinancialChequesBackGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(802, 484)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(584, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FinancialChequesBackTableAdapter
        '
        Me.FinancialChequesBackTableAdapter.ClearBeforeFill = True
        '
        'Cheqs1TableAdapter
        '
        Me.Cheqs1TableAdapter.ClearBeforeFill = True
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(580, 22)
        Me.LayoutControl2.TabIndex = 5
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LayoutControl2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(584, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(397, 22)
        Me.Root.TextVisible = False
        '
        'FinancialChequesBackFromBankStatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 530)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FinancialChequesBackFromBankStatment"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شيكات راجعة من تدقيق كشوفات البنك"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.FinancialChequesBackGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinancialChequesBackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cheqs1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryChequeImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FinancialChequesBackGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colChequesNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCheqNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrency2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuFDlr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDepositID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDebName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTransDebID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAccID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAccountName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colChequeDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAmountNIS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBankAccNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colChequNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCheckPic As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryChequeImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colExchangeRate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colBankName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colInputDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReBackDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colChequeStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colCurrency3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents FinancialChequesBackBindingSource As BindingSource
    Friend WithEvents FinancialChequesBackTableAdapter As CRMDataSetTableAdapters.FinancialChequesBackTableAdapter
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents Cheqs1BindingSource As BindingSource
    Friend WithEvents Cheqs1TableAdapter As WizCountDataSetTableAdapters.Cheqs1TableAdapter
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
