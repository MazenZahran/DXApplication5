<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrpakTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakTransactions))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Colshift_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTransDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTransTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Coltype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colpump = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colproduct_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colproduct_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colquantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colppv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Coltag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colfleet_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colmean_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colmean_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colstn_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFleetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colstn_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchStations = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.StationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HO_DATADataSet = New DXApplication5.HO_DATADataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colstn_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstn_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextTransCount = New DevExpress.XtraEditors.TextEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StationsTableAdapter = New DXApplication5.HO_DATADataSetTableAdapters.stationsTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchStations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextTransCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "transactions"
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1004, 530)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Colshift_id, Me.ColID, Me.ColTransDate, Me.ColTransTime, Me.Coltype, Me.Colpump, Me.Colproduct_code, Me.Colproduct_name, Me.Colquantity, Me.Colppv, Me.Colsale, Me.Coltag, Me.Colfleet_id, Me.Colmean_id, Me.Colplate, Me.Colmean_name, Me.Colstn_id, Me.Colcode, Me.ColFleetName, Me.Colstn_name})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'Colshift_id
        '
        Me.Colshift_id.Caption = "رقم الشفت"
        Me.Colshift_id.FieldName = "shift_id"
        Me.Colshift_id.Name = "Colshift_id"
        Me.Colshift_id.Visible = True
        Me.Colshift_id.VisibleIndex = 1
        '
        'ColID
        '
        Me.ColID.Caption = "رقم الحركة"
        Me.ColID.FieldName = "id"
        Me.ColID.Name = "ColID"
        Me.ColID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "عدد الحركات{0}")})
        Me.ColID.Visible = True
        Me.ColID.VisibleIndex = 2
        '
        'ColTransDate
        '
        Me.ColTransDate.Caption = "التاريخ"
        Me.ColTransDate.FieldName = "TransDate"
        Me.ColTransDate.Name = "ColTransDate"
        Me.ColTransDate.Visible = True
        Me.ColTransDate.VisibleIndex = 3
        '
        'ColTransTime
        '
        Me.ColTransTime.Caption = "الوقت"
        Me.ColTransTime.FieldName = "TransTime"
        Me.ColTransTime.Name = "ColTransTime"
        Me.ColTransTime.Visible = True
        Me.ColTransTime.VisibleIndex = 4
        '
        'Coltype
        '
        Me.Coltype.Caption = "النوع"
        Me.Coltype.FieldName = "type"
        Me.Coltype.Name = "Coltype"
        Me.Coltype.Visible = True
        Me.Coltype.VisibleIndex = 5
        '
        'Colpump
        '
        Me.Colpump.Caption = "الطرمبة"
        Me.Colpump.FieldName = "pump"
        Me.Colpump.Name = "Colpump"
        Me.Colpump.Visible = True
        Me.Colpump.VisibleIndex = 6
        '
        'Colproduct_code
        '
        Me.Colproduct_code.Caption = "رقم الصنف"
        Me.Colproduct_code.FieldName = "product_code"
        Me.Colproduct_code.Name = "Colproduct_code"
        Me.Colproduct_code.Visible = True
        Me.Colproduct_code.VisibleIndex = 7
        '
        'Colproduct_name
        '
        Me.Colproduct_name.Caption = "اسم الصنف"
        Me.Colproduct_name.FieldName = "product_name"
        Me.Colproduct_name.Name = "Colproduct_name"
        Me.Colproduct_name.Visible = True
        Me.Colproduct_name.VisibleIndex = 8
        '
        'Colquantity
        '
        Me.Colquantity.Caption = "الكمية"
        Me.Colquantity.FieldName = "quantity"
        Me.Colquantity.Name = "Colquantity"
        Me.Colquantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity", "SUM={0:0.#}")})
        Me.Colquantity.Visible = True
        Me.Colquantity.VisibleIndex = 9
        '
        'Colppv
        '
        Me.Colppv.Caption = "السعر"
        Me.Colppv.FieldName = "ppv"
        Me.Colppv.Name = "Colppv"
        Me.Colppv.Visible = True
        Me.Colppv.VisibleIndex = 10
        '
        'Colsale
        '
        Me.Colsale.Caption = "المبلغ"
        Me.Colsale.FieldName = "sale"
        Me.Colsale.Name = "Colsale"
        Me.Colsale.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sale", "SUM={0:0.#}")})
        Me.Colsale.Visible = True
        Me.Colsale.VisibleIndex = 11
        '
        'Coltag
        '
        Me.Coltag.Caption = "كود البطاقة"
        Me.Coltag.FieldName = "tag"
        Me.Coltag.Name = "Coltag"
        '
        'Colfleet_id
        '
        Me.Colfleet_id.Caption = "fleet_id"
        Me.Colfleet_id.FieldName = "fleet_id"
        Me.Colfleet_id.Name = "Colfleet_id"
        '
        'Colmean_id
        '
        Me.Colmean_id.Caption = "mean_id"
        Me.Colmean_id.FieldName = "mean_id"
        Me.Colmean_id.Name = "Colmean_id"
        '
        'Colplate
        '
        Me.Colplate.Caption = "المركبة"
        Me.Colplate.FieldName = "plate"
        Me.Colplate.Name = "Colplate"
        Me.Colplate.Visible = True
        Me.Colplate.VisibleIndex = 12
        '
        'Colmean_name
        '
        Me.Colmean_name.Caption = "رقم البطاقة"
        Me.Colmean_name.FieldName = "mean_name"
        Me.Colmean_name.Name = "Colmean_name"
        Me.Colmean_name.Visible = True
        Me.Colmean_name.VisibleIndex = 13
        '
        'Colstn_id
        '
        Me.Colstn_id.Caption = "رقم المحطة"
        Me.Colstn_id.FieldName = "stn_id"
        Me.Colstn_id.Name = "Colstn_id"
        Me.Colstn_id.Visible = True
        Me.Colstn_id.VisibleIndex = 14
        '
        'Colcode
        '
        Me.Colcode.Caption = "رقم الزبون"
        Me.Colcode.FieldName = "code"
        Me.Colcode.Name = "Colcode"
        Me.Colcode.Visible = True
        Me.Colcode.VisibleIndex = 15
        '
        'ColFleetName
        '
        Me.ColFleetName.Caption = "الزبون"
        Me.ColFleetName.FieldName = "FleetName"
        Me.ColFleetName.Name = "ColFleetName"
        Me.ColFleetName.Visible = True
        Me.ColFleetName.VisibleIndex = 16
        '
        'Colstn_name
        '
        Me.Colstn_name.Caption = "المحطة"
        Me.Colstn_name.FieldName = "stn_name"
        Me.Colstn_name.Name = "Colstn_name"
        Me.Colstn_name.Visible = True
        Me.Colstn_name.VisibleIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(96, 491)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(85, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "طباعة"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SearchStations)
        Me.LayoutControl1.Controls.Add(Me.TextTransCount)
        Me.LayoutControl1.Controls.Add(Me.DateEdit2)
        Me.LayoutControl1.Controls.Add(Me.DateEdit1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(193, 525)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 491)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(80, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "نسخ"
        '
        'SearchStations
        '
        Me.SearchStations.Location = New System.Drawing.Point(12, 84)
        Me.SearchStations.Name = "SearchStations"
        Me.SearchStations.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchStations.Properties.DataSource = Me.StationsBindingSource
        Me.SearchStations.Properties.DisplayMember = "stn_name"
        Me.SearchStations.Properties.NullText = ""
        Me.SearchStations.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchStations.Properties.ValueMember = "stn_id"
        Me.SearchStations.Size = New System.Drawing.Size(169, 20)
        Me.SearchStations.StyleController = Me.LayoutControl1
        Me.SearchStations.TabIndex = 7
        '
        'StationsBindingSource
        '
        Me.StationsBindingSource.DataMember = "stations"
        Me.StationsBindingSource.DataSource = Me.HO_DATADataSet
        '
        'HO_DATADataSet
        '
        Me.HO_DATADataSet.DataSetName = "HO_DATADataSet"
        Me.HO_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colstn_id1, Me.colstn_name1})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colstn_id1
        '
        Me.colstn_id1.FieldName = "stn_id"
        Me.colstn_id1.Name = "colstn_id1"
        Me.colstn_id1.Visible = True
        Me.colstn_id1.VisibleIndex = 0
        '
        'colstn_name1
        '
        Me.colstn_name1.FieldName = "stn_name"
        Me.colstn_name1.Name = "colstn_name1"
        Me.colstn_name1.Visible = True
        Me.colstn_name1.VisibleIndex = 1
        '
        'TextTransCount
        '
        Me.TextTransCount.Location = New System.Drawing.Point(12, 12)
        Me.TextTransCount.Name = "TextTransCount"
        Me.TextTransCount.Size = New System.Drawing.Size(101, 20)
        Me.TextTransCount.StyleController = Me.LayoutControl1
        Me.TextTransCount.TabIndex = 6
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(12, 60)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(169, 20)
        Me.DateEdit2.StyleController = Me.LayoutControl1
        Me.DateEdit2.TabIndex = 5
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(12, 36)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(169, 20)
        Me.DateEdit1.StyleController = Me.LayoutControl1
        Me.DateEdit1.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 465)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(169, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "تحديث"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(193, 525)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 357)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(84, 479)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(89, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 453)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DateEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DateEdit2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SearchStations
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TextTransCount
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem6.Text = "عدد الحركات"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(56, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton3
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 479)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
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
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("418fda37-1fd3-4ad8-971f-2478ab9e076b")
        Me.DockPanel1.Location = New System.Drawing.Point(1028, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 554)
        Me.DockPanel1.Text = "DockPanel1"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 525)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1028, 554)
        Me.LayoutControl2.TabIndex = 3
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1028, 554)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1008, 534)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'StationsTableAdapter
        '
        Me.StationsTableAdapter.ClearBeforeFill = True
        '
        'OrpakTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 554)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "OrpakTransactions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "حركات اورباك"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchStations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextTransCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextTransCount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchStations As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents HO_DATADataSet As HO_DATADataSet
    Friend WithEvents Colshift_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTransDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTransTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Coltype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colpump As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colproduct_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colproduct_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colquantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colppv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Coltag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colfleet_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colmean_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colmean_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colstn_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFleetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colstn_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StationsBindingSource As BindingSource
    Friend WithEvents StationsTableAdapter As HO_DATADataSetTableAdapters.stationsTableAdapter
    Friend WithEvents colstn_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstn_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
