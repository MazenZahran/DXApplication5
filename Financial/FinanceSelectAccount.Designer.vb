<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinanceSelectAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceSelectAccount))
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Sorting2 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.AreaText = New DevExpress.XtraEditors.TextEdit()
        Me.SortText = New DevExpress.XtraEditors.TextEdit()
        Me.AccNoText = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.costCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colرقمالمنطقة = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colاسمالمنطقة = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchLookUpEdit3 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.accSortNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colرقمالتصنيف = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colاسمالتصنيف = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.accountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colرقمالحساب = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colالحساب = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.AccNameText = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColAccountKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colsortcodename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCostCodeName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreaText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SortText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccNoText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accSortNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccNameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TextEdit1)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.AreaText)
        Me.PanelControl1.Controls.Add(Me.SortText)
        Me.PanelControl1.Controls.Add(Me.AccNoText)
        Me.PanelControl1.Controls.Add(Me.SearchLookUpEdit2)
        Me.PanelControl1.Controls.Add(Me.SearchLookUpEdit3)
        Me.PanelControl1.Controls.Add(Me.SearchLookUpEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.AccNameText)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(880, 122)
        Me.PanelControl1.TabIndex = 0
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(6, 6)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(86, 20)
        Me.TextEdit1.TabIndex = 5
        Me.TextEdit1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 71)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(43, 47)
        Me.SimpleButton1.TabIndex = 4
        '
        'AreaText
        '
        Me.AreaText.Location = New System.Drawing.Point(370, 64)
        Me.AreaText.Name = "AreaText"
        Me.AreaText.Size = New System.Drawing.Size(101, 20)
        Me.AreaText.TabIndex = 3
        '
        'SortText
        '
        Me.SortText.Location = New System.Drawing.Point(370, 38)
        Me.SortText.Name = "SortText"
        Me.SortText.Size = New System.Drawing.Size(101, 20)
        Me.SortText.TabIndex = 3
        '
        'AccNoText
        '
        Me.AccNoText.Location = New System.Drawing.Point(370, 12)
        Me.AccNoText.Name = "AccNoText"
        Me.AccNoText.Size = New System.Drawing.Size(101, 20)
        Me.AccNoText.TabIndex = 3
        '
        'SearchLookUpEdit2
        '
        Me.SearchLookUpEdit2.EditValue = ""
        Me.SearchLookUpEdit2.Location = New System.Drawing.Point(477, 64)
        Me.SearchLookUpEdit2.Name = "SearchLookUpEdit2"
        Me.SearchLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit2.Properties.DataSource = Me.costCodesBindingSource
        Me.SearchLookUpEdit2.Properties.DisplayMember = "اسم المنطقة"
        Me.SearchLookUpEdit2.Properties.NullText = ""
        Me.SearchLookUpEdit2.Properties.ValueMember = "رقم المنطقة"
        Me.SearchLookUpEdit2.Properties.View = Me.GridView2
        Me.SearchLookUpEdit2.Size = New System.Drawing.Size(342, 20)
        Me.SearchLookUpEdit2.TabIndex = 2
        '
        'costCodesBindingSource
        '
        Me.costCodesBindingSource.DataMember = "CostCodes"
        Me.costCodesBindingSource.DataSource = Me.SqlDataSource1
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "WizCountString_ALHUDA_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Column1.Alias = "رقم الحساب"
        ColumnExpression1.ColumnName = "AccountKey"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""1749"" />"
        Table1.Name = "Accounts"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        Column2.Alias = "الحساب"
        ColumnExpression2.ColumnName = "FullName"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.FilterString = ""
        SelectQuery1.GroupFilterString = ""
        SelectQuery1.MetaSerializable = Nothing
        SelectQuery1.Name = "Accounts"
        ColumnExpression3.ColumnName = "AccountKey"
        ColumnExpression3.Table = Table1
        Sorting1.Expression = ColumnExpression3
        SelectQuery1.Sorting.Add(Sorting1)
        SelectQuery1.Tables.Add(Table1)
        Column3.Alias = "رقم التصنيف"
        ColumnExpression4.ColumnName = "AccSortCode"
        Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""115"" />"
        Table2.Name = "AccSortNames"
        ColumnExpression4.Table = Table2
        Column3.Expression = ColumnExpression4
        Column4.Alias = "اسم التصنيف"
        ColumnExpression5.ColumnName = "SortCodeName"
        ColumnExpression5.Table = Table2
        Column4.Expression = ColumnExpression5
        SelectQuery2.Columns.Add(Column3)
        SelectQuery2.Columns.Add(Column4)
        SelectQuery2.FilterString = ""
        SelectQuery2.GroupFilterString = ""
        SelectQuery2.MetaSerializable = Nothing
        SelectQuery2.Name = "AccSortNames"
        ColumnExpression6.ColumnName = "AccSortCode"
        ColumnExpression6.Table = Table2
        Sorting2.Expression = ColumnExpression6
        SelectQuery2.Sorting.Add(Sorting2)
        SelectQuery2.Tables.Add(Table2)
        Column5.Alias = "اسم المنطقة"
        ColumnExpression7.ColumnName = "CostCodeName"
        Table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""172"" />"
        Table3.Name = "CostCodes"
        ColumnExpression7.Table = Table3
        Column5.Expression = ColumnExpression7
        Column6.Alias = "رقم المنطقة"
        ColumnExpression8.ColumnName = "CostCode"
        ColumnExpression8.Table = Table3
        Column6.Expression = ColumnExpression8
        SelectQuery3.Columns.Add(Column5)
        SelectQuery3.Columns.Add(Column6)
        SelectQuery3.MetaSerializable = Nothing
        SelectQuery3.Name = "CostCodes"
        SelectQuery3.Tables.Add(Table3)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2, SelectQuery3})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colرقمالمنطقة, Me.colاسمالمنطقة})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colرقمالمنطقة
        '
        Me.colرقمالمنطقة.FieldName = "رقم المنطقة"
        Me.colرقمالمنطقة.Name = "colرقمالمنطقة"
        Me.colرقمالمنطقة.Visible = True
        Me.colرقمالمنطقة.VisibleIndex = 0
        '
        'colاسمالمنطقة
        '
        Me.colاسمالمنطقة.FieldName = "اسم المنطقة"
        Me.colاسمالمنطقة.Name = "colاسمالمنطقة"
        Me.colاسمالمنطقة.Visible = True
        Me.colاسمالمنطقة.VisibleIndex = 1
        '
        'SearchLookUpEdit3
        '
        Me.SearchLookUpEdit3.EditValue = ""
        Me.SearchLookUpEdit3.Location = New System.Drawing.Point(477, 38)
        Me.SearchLookUpEdit3.Name = "SearchLookUpEdit3"
        Me.SearchLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit3.Properties.DataSource = Me.accSortNamesBindingSource
        Me.SearchLookUpEdit3.Properties.DisplayMember = "اسم التصنيف"
        Me.SearchLookUpEdit3.Properties.NullText = ""
        Me.SearchLookUpEdit3.Properties.ValueMember = "رقم التصنيف"
        Me.SearchLookUpEdit3.Properties.View = Me.GridView3
        Me.SearchLookUpEdit3.Size = New System.Drawing.Size(342, 20)
        Me.SearchLookUpEdit3.TabIndex = 2
        '
        'accSortNamesBindingSource
        '
        Me.accSortNamesBindingSource.DataMember = "AccSortNames"
        Me.accSortNamesBindingSource.DataSource = Me.SqlDataSource1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colرقمالتصنيف, Me.colاسمالتصنيف})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colرقمالتصنيف
        '
        Me.colرقمالتصنيف.FieldName = "رقم التصنيف"
        Me.colرقمالتصنيف.Name = "colرقمالتصنيف"
        Me.colرقمالتصنيف.Visible = True
        Me.colرقمالتصنيف.VisibleIndex = 0
        '
        'colاسمالتصنيف
        '
        Me.colاسمالتصنيف.FieldName = "اسم التصنيف"
        Me.colاسمالتصنيف.Name = "colاسمالتصنيف"
        Me.colاسمالتصنيف.Visible = True
        Me.colاسمالتصنيف.VisibleIndex = 1
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.EditValue = ""
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(477, 12)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DataSource = Me.accountsBindingSource
        Me.SearchLookUpEdit1.Properties.DisplayMember = "الحساب"
        Me.SearchLookUpEdit1.Properties.NullText = ""
        Me.SearchLookUpEdit1.Properties.ValueMember = "رقم الحساب"
        Me.SearchLookUpEdit1.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(342, 20)
        Me.SearchLookUpEdit1.TabIndex = 2
        '
        'accountsBindingSource
        '
        Me.accountsBindingSource.DataMember = "Accounts"
        Me.accountsBindingSource.DataSource = Me.SqlDataSource1
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colرقمالحساب, Me.colالحساب})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colرقمالحساب
        '
        Me.colرقمالحساب.FieldName = "رقم الحساب"
        Me.colرقمالحساب.Name = "colرقمالحساب"
        Me.colرقمالحساب.Visible = True
        Me.colرقمالحساب.VisibleIndex = 0
        '
        'colالحساب
        '
        Me.colالحساب.FieldName = "الحساب"
        Me.colالحساب.Name = "colالحساب"
        Me.colالحساب.Visible = True
        Me.colالحساب.VisibleIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(833, 100)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "الاسم"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(825, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "المنطقة"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(825, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "التصنيف"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(827, 19)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "الحساب"
        '
        'AccNameText
        '
        Me.AccNameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccNameText.Location = New System.Drawing.Point(370, 93)
        Me.AccNameText.Name = "AccNameText"
        Me.AccNameText.Size = New System.Drawing.Size(449, 20)
        Me.AccNameText.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 122)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(880, 414)
        Me.PanelControl2.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(876, 410)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColAccountKey, Me.ColFullName, Me.ColCountry, Me.ColSPhone, Me.Colsortcodename, Me.ColCostCodeName})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColAccountKey
        '
        Me.ColAccountKey.Caption = "رقم الحساب"
        Me.ColAccountKey.FieldName = "AccountKey"
        Me.ColAccountKey.Name = "ColAccountKey"
        Me.ColAccountKey.Visible = True
        Me.ColAccountKey.VisibleIndex = 0
        Me.ColAccountKey.Width = 80
        '
        'ColFullName
        '
        Me.ColFullName.Caption = "الحساب"
        Me.ColFullName.FieldName = "FullName"
        Me.ColFullName.Name = "ColFullName"
        Me.ColFullName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FullName", "عدد الحسابات {0}")})
        Me.ColFullName.Visible = True
        Me.ColFullName.VisibleIndex = 1
        Me.ColFullName.Width = 308
        '
        'ColCountry
        '
        Me.ColCountry.Caption = "المسؤول"
        Me.ColCountry.FieldName = "Country"
        Me.ColCountry.Name = "ColCountry"
        Me.ColCountry.Visible = True
        Me.ColCountry.VisibleIndex = 2
        Me.ColCountry.Width = 133
        '
        'ColSPhone
        '
        Me.ColSPhone.Caption = "هاتف محمول"
        Me.ColSPhone.FieldName = "SPhone"
        Me.ColSPhone.Name = "ColSPhone"
        Me.ColSPhone.Visible = True
        Me.ColSPhone.VisibleIndex = 3
        Me.ColSPhone.Width = 123
        '
        'Colsortcodename
        '
        Me.Colsortcodename.Caption = "التصنيف"
        Me.Colsortcodename.FieldName = "sortcodename"
        Me.Colsortcodename.Name = "Colsortcodename"
        Me.Colsortcodename.Visible = True
        Me.Colsortcodename.VisibleIndex = 4
        Me.Colsortcodename.Width = 150
        '
        'ColCostCodeName
        '
        Me.ColCostCodeName.Caption = "المنطقة"
        Me.ColCostCodeName.FieldName = "CostCodeName"
        Me.ColCostCodeName.Name = "ColCostCodeName"
        Me.ColCostCodeName.Visible = True
        Me.ColCostCodeName.VisibleIndex = 5
        Me.ColCostCodeName.Width = 90
        '
        'FinanceSelectAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 536)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FinanceSelectAccount"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الحسابات"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreaText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SortText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccNoText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accSortNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccNameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AccNameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit3 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents accountsBindingSource As BindingSource
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchLookUpEdit2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colرقمالمنطقة As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colاسمالمنطقة As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colرقمالتصنيف As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colاسمالتصنيف As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colرقمالحساب As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colالحساب As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents accSortNamesBindingSource As BindingSource
    Friend WithEvents costCodesBindingSource As BindingSource
    Friend WithEvents SortText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccNoText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AreaText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColAccountKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colsortcodename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCostCodeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
