<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrpakEditCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakEditCard))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchCardID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.MeansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HO_DATADataSet = New DXApplication5.HO_DATADataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextID = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.DepID = New DevExpress.XtraEditors.TextEdit()
        Me.TexOldVlaues = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchFleet = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.FleetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LookStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextString = New DevExpress.XtraEditors.TextEdit()
        Me.TextPlate = New DevExpress.XtraEditors.TextEdit()
        Me.TextCardNo = New DevExpress.XtraEditors.TextEdit()
        Me.TextGroupRules = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GrouprulesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FleetsTableAdapter = New DXApplication5.HO_DATADataSetTableAdapters.fleetsTableAdapter()
        Me.MeansTableAdapter = New DXApplication5.HO_DATADataSetTableAdapters.meansTableAdapter()
        Me.Group_rulesTableAdapter = New DXApplication5.HO_DATADataSetTableAdapters.group_rulesTableAdapter()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.DepID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchFleet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FleetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPlate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextCardNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextGroupRules.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrouprulesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colstatus
        '
        Me.colstatus.Caption = "الحالة"
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SearchCardID)
        Me.LayoutControl1.Controls.Add(Me.TextID)
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(594, 372)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchCardID
        '
        Me.SearchCardID.EditValue = ""
        Me.SearchCardID.Location = New System.Drawing.Point(271, 12)
        Me.SearchCardID.Name = "SearchCardID"
        Me.SearchCardID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchCardID.Properties.DataSource = Me.MeansBindingSource
        Me.SearchCardID.Properties.DisplayMember = "name"
        Me.SearchCardID.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchCardID.Properties.ValueMember = "id"
        Me.SearchCardID.Size = New System.Drawing.Size(190, 20)
        Me.SearchCardID.StyleController = Me.LayoutControl1
        Me.SearchCardID.TabIndex = 8
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
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "رقم البطاقة"
        Me.GridColumn2.FieldName = "name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "الكود"
        Me.GridColumn3.FieldName = "string"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "الزبون"
        Me.GridColumn4.FieldName = "Fleet"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(12, 12)
        Me.TextID.Name = "TextID"
        Me.TextID.Properties.ReadOnly = True
        Me.TextID.Size = New System.Drawing.Size(570, 20)
        Me.TextID.StyleController = Me.LayoutControl1
        Me.TextID.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LayoutControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 36)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(570, 324)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "بيانات البطاقة"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.DepID)
        Me.LayoutControl2.Controls.Add(Me.TexOldVlaues)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.SearchFleet)
        Me.LayoutControl2.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl2.Controls.Add(Me.LookStatus)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.TextString)
        Me.LayoutControl2.Controls.Add(Me.TextPlate)
        Me.LayoutControl2.Controls.Add(Me.TextCardNo)
        Me.LayoutControl2.Controls.Add(Me.TextGroupRules)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 23)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(566, 299)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'DepID
        '
        Me.DepID.Location = New System.Drawing.Point(12, 36)
        Me.DepID.Name = "DepID"
        Me.DepID.Size = New System.Drawing.Size(153, 20)
        Me.DepID.StyleController = Me.LayoutControl2
        Me.DepID.TabIndex = 16
        '
        'TexOldVlaues
        '
        Me.TexOldVlaues.Location = New System.Drawing.Point(12, 288)
        Me.TexOldVlaues.Name = "TexOldVlaues"
        Me.TexOldVlaues.Size = New System.Drawing.Size(417, 20)
        Me.TexOldVlaues.TabIndex = 15
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 265)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(103, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "اغلاق"
        '
        'SearchFleet
        '
        Me.SearchFleet.EditValue = ""
        Me.SearchFleet.Location = New System.Drawing.Point(202, 36)
        Me.SearchFleet.Name = "SearchFleet"
        Me.SearchFleet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchFleet.Properties.DataSource = Me.FleetsBindingSource
        Me.SearchFleet.Properties.DisplayMember = "name"
        Me.SearchFleet.Properties.PopupView = Me.GridView1
        Me.SearchFleet.Properties.ValueMember = "id"
        Me.SearchFleet.Size = New System.Drawing.Size(288, 20)
        Me.SearchFleet.StyleController = Me.LayoutControl2
        Me.SearchFleet.TabIndex = 13
        '
        'FleetsBindingSource
        '
        Me.FleetsBindingSource.DataMember = "fleets"
        Me.FleetsBindingSource.DataSource = Me.HO_DATADataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcode, Me.colname1, Me.colstatus})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colstatus
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
        FormatConditionRuleValue1.PredefinedName = "Red Fill"
        FormatConditionRuleValue1.Value1 = "2"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colcode
        '
        Me.colcode.Caption = "رقم"
        Me.colcode.FieldName = "code"
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 0
        '
        'colname1
        '
        Me.colname1.Caption = "الزبون"
        Me.colname1.FieldName = "name"
        Me.colname1.Name = "colname1"
        Me.colname1.Visible = True
        Me.colname1.VisibleIndex = 1
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(12, 156)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(478, 105)
        Me.MemoEdit1.StyleController = Me.LayoutControl2
        Me.MemoEdit1.TabIndex = 12
        '
        'LookStatus
        '
        Me.LookStatus.Location = New System.Drawing.Point(12, 108)
        Me.LookStatus.Name = "LookStatus"
        Me.LookStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookStatus.Properties.DisplayMember = "CardStatus"
        Me.LookStatus.Properties.NullText = ""
        Me.LookStatus.Properties.ValueMember = "ID"
        Me.LookStatus.Size = New System.Drawing.Size(478, 20)
        Me.LookStatus.StyleController = Me.LayoutControl2
        Me.LookStatus.TabIndex = 10
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(119, 265)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(126, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "حفظ التعديلات"
        '
        'TextString
        '
        Me.TextString.Location = New System.Drawing.Point(12, 84)
        Me.TextString.Name = "TextString"
        Me.TextString.Size = New System.Drawing.Size(478, 20)
        Me.TextString.StyleController = Me.LayoutControl2
        Me.TextString.TabIndex = 8
        '
        'TextPlate
        '
        Me.TextPlate.Location = New System.Drawing.Point(309, 60)
        Me.TextPlate.Name = "TextPlate"
        Me.TextPlate.Size = New System.Drawing.Size(181, 20)
        Me.TextPlate.StyleController = Me.LayoutControl2
        Me.TextPlate.TabIndex = 6
        '
        'TextCardNo
        '
        Me.TextCardNo.Location = New System.Drawing.Point(12, 12)
        Me.TextCardNo.Name = "TextCardNo"
        Me.TextCardNo.Size = New System.Drawing.Size(478, 20)
        Me.TextCardNo.StyleController = Me.LayoutControl2
        Me.TextCardNo.TabIndex = 4
        '
        'TextGroupRules
        '
        Me.TextGroupRules.Location = New System.Drawing.Point(12, 60)
        Me.TextGroupRules.Name = "TextGroupRules"
        Me.TextGroupRules.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextGroupRules.Properties.DataSource = Me.GrouprulesBindingSource
        Me.TextGroupRules.Properties.DisplayMember = "name"
        Me.TextGroupRules.Properties.NullText = ""
        Me.TextGroupRules.Properties.PopupView = Me.GridView2
        Me.TextGroupRules.Properties.ValueMember = "id"
        Me.TextGroupRules.Size = New System.Drawing.Size(229, 20)
        Me.TextGroupRules.StyleController = Me.LayoutControl2
        Me.TextGroupRules.TabIndex = 7
        '
        'GrouprulesBindingSource
        '
        Me.GrouprulesBindingSource.DataMember = "group_rules"
        Me.GrouprulesBindingSource.DataSource = Me.HO_DATADataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColID, Me.Colname})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ColID
        '
        Me.ColID.Caption = "ID"
        Me.ColID.FieldName = "ID"
        Me.ColID.Name = "ColID"
        '
        'Colname
        '
        Me.Colname.Caption = "السقف"
        Me.Colname.FieldName = "name"
        Me.Colname.Name = "Colname"
        Me.Colname.Visible = True
        Me.Colname.VisibleIndex = 0
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.TexOldVlaues
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 276)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(535, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.EmptySpaceItem3, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem12, Me.LayoutControlItem14})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(566, 299)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TextPlate
        Me.LayoutControlItem6.Location = New System.Drawing.Point(297, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(249, 24)
        Me.LayoutControlItem6.Text = "المركبة"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(52, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(546, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton2
        Me.LayoutControlItem9.Location = New System.Drawing.Point(107, 253)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(130, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.MemoEdit1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(546, 109)
        Me.LayoutControlItem11.Text = "ملاحظات"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextGroupRules
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem7.Text = "السقف"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TextString
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(546, 24)
        Me.LayoutControlItem8.Text = "الكود"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.LookStatus
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(546, 24)
        Me.LayoutControlItem10.Text = "الحالة"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SearchFleet
        Me.LayoutControlItem5.Location = New System.Drawing.Point(190, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(356, 24)
        Me.LayoutControlItem5.Text = "الزبون"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextCardNo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(546, 24)
        Me.LayoutControlItem4.Text = "رقم البطاقة"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(52, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(237, 253)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(309, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SimpleButton1
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 253)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(107, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.DepID
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem14.Text = "الدائرة"
        Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(28, 13)
        Me.LayoutControlItem14.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchCardID
        Me.LayoutControlItem2.Location = New System.Drawing.Point(259, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem2.Text = "البطاقة"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(32, 13)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(594, 372)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(574, 328)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextID
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(574, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'FleetsTableAdapter
        '
        Me.FleetsTableAdapter.ClearBeforeFill = True
        '
        'MeansTableAdapter
        '
        Me.MeansTableAdapter.ClearBeforeFill = True
        '
        'Group_rulesTableAdapter
        '
        Me.Group_rulesTableAdapter.ClearBeforeFill = True
        '
        'NavigationPane1
        '
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPane1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(682, 445)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage1
        Me.NavigationPane1.Size = New System.Drawing.Size(682, 445)
        Me.NavigationPane1.TabIndex = 1
        Me.NavigationPane1.Text = "تعديل بطاقة"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "تعديل بيانات البطاقة"
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.ImageOptions.SvgImage = CType(resources.GetObject("NavigationPage1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(594, 372)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "حركات البطاقة"
        Me.NavigationPage2.Controls.Add(Me.GridControl1)
        Me.NavigationPage2.ImageOptions.SvgImage = CType(resources.GetObject("NavigationPage2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(594, 372)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItem, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(594, 372)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Row.Options.UseTextOptions = True
        Me.GridView3.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView3.Appearance.SelectedRow.Options.UseTextOptions = True
        Me.GridView3.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "CardTransDate"
        Me.GridColumn5.FieldName = "CardTransDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "TransUser"
        Me.GridColumn6.FieldName = "TransUser"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn7.Caption = "TransNotes"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn7.FieldName = "TransNotes"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn8.Caption = "OldValues"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.GridColumn8.FieldName = "OldValues"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItem
        '
        Me.RepositoryItem.Appearance.Options.UseTextOptions = True
        Me.RepositoryItem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItem.Name = "RepositoryItem"
        '
        'OrpakEditCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 445)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Name = "OrpakEditCard"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعديل بطاقة"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.DepID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchFleet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FleetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPlate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextCardNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextGroupRules.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrouprulesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchCardID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LookStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextString As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextPlate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextCardNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchFleet As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents HO_DATADataSet As HO_DATADataSet
    Friend WithEvents FleetsBindingSource As BindingSource
    Friend WithEvents FleetsTableAdapter As HO_DATADataSetTableAdapters.fleetsTableAdapter
    Friend WithEvents MeansBindingSource As BindingSource
    Friend WithEvents MeansTableAdapter As HO_DATADataSetTableAdapters.meansTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextGroupRules As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GrouprulesBindingSource As BindingSource
    Friend WithEvents Group_rulesTableAdapter As HO_DATADataSetTableAdapters.group_rulesTableAdapter
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TexOldVlaues As TextBox
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItem As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
