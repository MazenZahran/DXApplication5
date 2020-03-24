<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancialAccountsBalances
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialAccountsBalances))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Me.ColAMAXCREDIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckShowZeroBalances = New DevExpress.XtraEditors.CheckEdit()
        Me.MonthText = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.ToUserText = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditTo = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditFrom = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColAccountID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDebit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAFilter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACOSTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColASphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACOSTCODEName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAccLastTrans = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnAccrualChecks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColOpen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemOpen = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.FromSortText = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.AccSortNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccSortCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSortCodeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToSortText = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccSortCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSortCodeName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UsersTableAdapter = New DXApplication5.CRMDataSetTableAdapters.UsersTableAdapter()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.DXApplication5.WaitForm1), True, True)
        Me.AccSortNamesTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.AccSortNamesTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckShowZeroBalances.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToUserText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromSortText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccSortNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToSortText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColAMAXCREDIT
        '
        Me.ColAMAXCREDIT.Caption = "السقف المالي"
        Me.ColAMAXCREDIT.FieldName = "AMAXCREDIT"
        Me.ColAMAXCREDIT.Name = "ColAMAXCREDIT"
        Me.ColAMAXCREDIT.Visible = True
        Me.ColAMAXCREDIT.VisibleIndex = 11
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckShowZeroBalances)
        Me.LayoutControl1.Controls.Add(Me.MonthText)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.ToUserText)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.DateEditTo)
        Me.LayoutControl1.Controls.Add(Me.DateEditFrom)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.FromSortText)
        Me.LayoutControl1.Controls.Add(Me.ToSortText)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(956, 405)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckShowZeroBalances
        '
        Me.CheckShowZeroBalances.Location = New System.Drawing.Point(330, 12)
        Me.CheckShowZeroBalances.Name = "CheckShowZeroBalances"
        Me.CheckShowZeroBalances.Properties.Caption = "اظهار الارصدة الصفرية"
        Me.CheckShowZeroBalances.Size = New System.Drawing.Size(191, 19)
        Me.CheckShowZeroBalances.StyleController = Me.LayoutControl1
        Me.CheckShowZeroBalances.TabIndex = 15
        '
        'MonthText
        '
        Me.MonthText.Location = New System.Drawing.Point(470, 359)
        Me.MonthText.Name = "MonthText"
        Me.MonthText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MonthText.Size = New System.Drawing.Size(146, 20)
        Me.MonthText.StyleController = Me.LayoutControl1
        Me.MonthText.TabIndex = 14
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(24, 359)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(225, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 13
        Me.SimpleButton3.Text = "تحول الى مهام"
        '
        'ToUserText
        '
        Me.ToUserText.Location = New System.Drawing.Point(673, 359)
        Me.ToUserText.Name = "ToUserText"
        Me.ToUserText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToUserText.Properties.DataSource = Me.UsersBindingSource
        Me.ToUserText.Properties.DisplayMember = "UserName"
        Me.ToUserText.Properties.NullText = ""
        Me.ToUserText.Properties.ValueMember = "UserID"
        Me.ToUserText.Properties.View = Me.SearchLookUpEdit1View
        Me.ToUserText.Size = New System.Drawing.Size(206, 20)
        Me.ToUserText.StyleController = Me.LayoutControl1
        Me.ToUserText.TabIndex = 11
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUserID, Me.colUserName})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUserID
        '
        Me.colUserID.FieldName = "UserID"
        Me.colUserID.Name = "colUserID"
        Me.colUserID.Visible = True
        Me.colUserID.VisibleIndex = 0
        '
        'colUserName
        '
        Me.colUserName.FieldName = "UserName"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.Visible = True
        Me.colUserName.VisibleIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 38)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "طباعة"
        '
        'DateEditTo
        '
        Me.DateEditTo.EditValue = Nothing
        Me.DateEditTo.Location = New System.Drawing.Point(525, 36)
        Me.DateEditTo.Name = "DateEditTo"
        Me.DateEditTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Size = New System.Drawing.Size(180, 20)
        Me.DateEditTo.StyleController = Me.LayoutControl1
        Me.DateEditTo.TabIndex = 9
        '
        'DateEditFrom
        '
        Me.DateEditFrom.EditValue = Nothing
        Me.DateEditFrom.Location = New System.Drawing.Point(525, 12)
        Me.DateEditFrom.Name = "DateEditFrom"
        Me.DateEditFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Size = New System.Drawing.Size(180, 20)
        Me.DateEditFrom.StyleController = Me.LayoutControl1
        Me.DateEditFrom.TabIndex = 8
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "تحديث"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemOpen})
        Me.GridControl1.Size = New System.Drawing.Size(932, 261)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColAccountID, Me.ColAccountName, Me.ColSort, Me.ColDebit, Me.ColCredit, Me.ColBalance, Me.ColCountry, Me.ColPhone, Me.ColAFilter, Me.ColAEmail, Me.ColACOSTCODE, Me.ColASphone, Me.ColACOSTCODEName, Me.ColAccLastTrans, Me.ColUnAccrualChecks, Me.ColOpen, Me.ColAMAXCREDIT})
        GridFormatRule1.Column = Me.ColAMAXCREDIT
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Expression = "[AMAXCREDIT] < [AccBalance] + [UnAccrualChecks]"
        FormatConditionRuleExpression1.PredefinedName = "Red Fill"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccBalance", Me.ColBalance, "{0:C2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DebitBalance", Me.ColDebit, "{0:C2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CreditBalance", Me.ColCredit, "{0:C2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccountID", Me.ColAccountID, "عدد = {0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColACOSTCODEName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColAccountID
        '
        Me.ColAccountID.Caption = "رقم الحساب"
        Me.ColAccountID.FieldName = "AccountID"
        Me.ColAccountID.Name = "ColAccountID"
        Me.ColAccountID.OptionsColumn.AllowEdit = False
        Me.ColAccountID.OptionsColumn.ReadOnly = True
        Me.ColAccountID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccountID", "{0}")})
        Me.ColAccountID.Visible = True
        Me.ColAccountID.VisibleIndex = 0
        '
        'ColAccountName
        '
        Me.ColAccountName.Caption = "الحساب"
        Me.ColAccountName.FieldName = "AFULLNAME"
        Me.ColAccountName.MinWidth = 200
        Me.ColAccountName.Name = "ColAccountName"
        Me.ColAccountName.OptionsColumn.AllowEdit = False
        Me.ColAccountName.OptionsColumn.ReadOnly = True
        Me.ColAccountName.Visible = True
        Me.ColAccountName.VisibleIndex = 1
        Me.ColAccountName.Width = 200
        '
        'ColSort
        '
        Me.ColSort.Caption = "التصنيف"
        Me.ColSort.FieldName = "ASORTGROUP"
        Me.ColSort.Name = "ColSort"
        Me.ColSort.OptionsColumn.AllowEdit = False
        Me.ColSort.OptionsColumn.ReadOnly = True
        Me.ColSort.Visible = True
        Me.ColSort.VisibleIndex = 2
        '
        'ColDebit
        '
        Me.ColDebit.Caption = "مدين"
        Me.ColDebit.FieldName = "DebitBalance"
        Me.ColDebit.Name = "ColDebit"
        Me.ColDebit.OptionsColumn.AllowEdit = False
        Me.ColDebit.OptionsColumn.ReadOnly = True
        Me.ColDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DebitBalance", "{0:c2}")})
        '
        'ColCredit
        '
        Me.ColCredit.Caption = "الدائن"
        Me.ColCredit.FieldName = "CreditBalance"
        Me.ColCredit.Name = "ColCredit"
        Me.ColCredit.OptionsColumn.AllowEdit = False
        Me.ColCredit.OptionsColumn.ReadOnly = True
        Me.ColCredit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CreditBalance", "{0:c2}")})
        '
        'ColBalance
        '
        Me.ColBalance.Caption = "الرصيد"
        Me.ColBalance.FieldName = "AccBalance"
        Me.ColBalance.Name = "ColBalance"
        Me.ColBalance.OptionsColumn.AllowEdit = False
        Me.ColBalance.OptionsColumn.ReadOnly = True
        Me.ColBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccBalance", "{0:c2}")})
        Me.ColBalance.Visible = True
        Me.ColBalance.VisibleIndex = 9
        '
        'ColCountry
        '
        Me.ColCountry.Caption = "المسؤول"
        Me.ColCountry.FieldName = "Acountry"
        Me.ColCountry.Name = "ColCountry"
        Me.ColCountry.OptionsColumn.AllowEdit = False
        Me.ColCountry.OptionsColumn.ReadOnly = True
        Me.ColCountry.Visible = True
        Me.ColCountry.VisibleIndex = 5
        '
        'ColPhone
        '
        Me.ColPhone.Caption = "الهاتف"
        Me.ColPhone.FieldName = "APHONE"
        Me.ColPhone.Name = "ColPhone"
        Me.ColPhone.OptionsColumn.AllowEdit = False
        Me.ColPhone.OptionsColumn.ReadOnly = True
        Me.ColPhone.Visible = True
        Me.ColPhone.VisibleIndex = 7
        '
        'ColAFilter
        '
        Me.ColAFilter.Caption = "فلتر"
        Me.ColAFilter.FieldName = "Afilter"
        Me.ColAFilter.Name = "ColAFilter"
        Me.ColAFilter.OptionsColumn.AllowEdit = False
        Me.ColAFilter.OptionsColumn.ReadOnly = True
        Me.ColAFilter.Visible = True
        Me.ColAFilter.VisibleIndex = 3
        '
        'ColAEmail
        '
        Me.ColAEmail.Caption = "الايميل"
        Me.ColAEmail.FieldName = "AEmail"
        Me.ColAEmail.Name = "ColAEmail"
        Me.ColAEmail.OptionsColumn.AllowEdit = False
        Me.ColAEmail.OptionsColumn.ReadOnly = True
        Me.ColAEmail.Visible = True
        Me.ColAEmail.VisibleIndex = 8
        '
        'ColACOSTCODE
        '
        Me.ColACOSTCODE.Caption = "المنطقة"
        Me.ColACOSTCODE.FieldName = "ACOSTCODE"
        Me.ColACOSTCODE.Name = "ColACOSTCODE"
        Me.ColACOSTCODE.OptionsColumn.AllowEdit = False
        Me.ColACOSTCODE.OptionsColumn.ReadOnly = True
        Me.ColACOSTCODE.Visible = True
        Me.ColACOSTCODE.VisibleIndex = 4
        '
        'ColASphone
        '
        Me.ColASphone.Caption = "رقم المحمول"
        Me.ColASphone.FieldName = "ASphone"
        Me.ColASphone.Name = "ColASphone"
        Me.ColASphone.OptionsColumn.AllowEdit = False
        Me.ColASphone.OptionsColumn.ReadOnly = True
        Me.ColASphone.Visible = True
        Me.ColASphone.VisibleIndex = 6
        '
        'ColACOSTCODEName
        '
        Me.ColACOSTCODEName.Caption = "اسم التصنيف"
        Me.ColACOSTCODEName.FieldName = "ACSORTCODENAME"
        Me.ColACOSTCODEName.Name = "ColACOSTCODEName"
        Me.ColACOSTCODEName.OptionsColumn.AllowEdit = False
        Me.ColACOSTCODEName.OptionsColumn.ReadOnly = True
        Me.ColACOSTCODEName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccBalance", "{0:c2}")})
        '
        'ColAccLastTrans
        '
        Me.ColAccLastTrans.Caption = "اخر حركة"
        Me.ColAccLastTrans.FieldName = "AccLastTrans"
        Me.ColAccLastTrans.Name = "ColAccLastTrans"
        Me.ColAccLastTrans.OptionsColumn.AllowEdit = False
        Me.ColAccLastTrans.OptionsColumn.ReadOnly = True
        Me.ColAccLastTrans.Visible = True
        Me.ColAccLastTrans.VisibleIndex = 12
        '
        'ColUnAccrualChecks
        '
        Me.ColUnAccrualChecks.Caption = "شيكات اجلة"
        Me.ColUnAccrualChecks.FieldName = "UnAccrualChecks"
        Me.ColUnAccrualChecks.Name = "ColUnAccrualChecks"
        Me.ColUnAccrualChecks.OptionsColumn.AllowEdit = False
        Me.ColUnAccrualChecks.OptionsColumn.ReadOnly = True
        Me.ColUnAccrualChecks.Visible = True
        Me.ColUnAccrualChecks.VisibleIndex = 10
        '
        'ColOpen
        '
        Me.ColOpen.Caption = "فتح"
        Me.ColOpen.ColumnEdit = Me.RepositoryItemOpen
        Me.ColOpen.FieldName = "AccOpen"
        Me.ColOpen.MaxWidth = 50
        Me.ColOpen.Name = "ColOpen"
        Me.ColOpen.Visible = True
        Me.ColOpen.VisibleIndex = 13
        Me.ColOpen.Width = 50
        '
        'RepositoryItemOpen
        '
        Me.RepositoryItemOpen.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.RepositoryItemOpen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "فتح", -1, True, True, False, EditorButtonImageOptions1)})
        Me.RepositoryItemOpen.Name = "RepositoryItemOpen"
        Me.RepositoryItemOpen.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'FromSortText
        '
        Me.FromSortText.Location = New System.Drawing.Point(762, 12)
        Me.FromSortText.Name = "FromSortText"
        Me.FromSortText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromSortText.Properties.DataSource = Me.AccSortNamesBindingSource
        Me.FromSortText.Properties.DisplayMember = "SortCodeName"
        Me.FromSortText.Properties.NullText = ""
        Me.FromSortText.Properties.ValueMember = "AccSortCode"
        Me.FromSortText.Properties.View = Me.GridView2
        Me.FromSortText.Size = New System.Drawing.Size(129, 20)
        Me.FromSortText.StyleController = Me.LayoutControl1
        Me.FromSortText.TabIndex = 4
        '
        'AccSortNamesBindingSource
        '
        Me.AccSortNamesBindingSource.DataMember = "AccSortNames"
        Me.AccSortNamesBindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccSortCode, Me.colSortCodeName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colAccSortCode
        '
        Me.colAccSortCode.Caption = "رقم التصنيف"
        Me.colAccSortCode.FieldName = "AccSortCode"
        Me.colAccSortCode.Name = "colAccSortCode"
        Me.colAccSortCode.Visible = True
        Me.colAccSortCode.VisibleIndex = 0
        '
        'colSortCodeName
        '
        Me.colSortCodeName.Caption = "اسم التصنيف"
        Me.colSortCodeName.FieldName = "SortCodeName"
        Me.colSortCodeName.Name = "colSortCodeName"
        Me.colSortCodeName.Visible = True
        Me.colSortCodeName.VisibleIndex = 1
        '
        'ToSortText
        '
        Me.ToSortText.Location = New System.Drawing.Point(762, 36)
        Me.ToSortText.Name = "ToSortText"
        Me.ToSortText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToSortText.Properties.DataSource = Me.AccSortNamesBindingSource
        Me.ToSortText.Properties.DisplayMember = "SortCodeName"
        Me.ToSortText.Properties.NullText = ""
        Me.ToSortText.Properties.ValueMember = "AccSortCode"
        Me.ToSortText.Properties.View = Me.GridView3
        Me.ToSortText.Size = New System.Drawing.Size(129, 20)
        Me.ToSortText.StyleController = Me.LayoutControl1
        Me.ToSortText.TabIndex = 5
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccSortCode1, Me.colSortCodeName1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colAccSortCode1
        '
        Me.colAccSortCode1.Caption = "رقم التصنيف"
        Me.colAccSortCode1.FieldName = "AccSortCode"
        Me.colAccSortCode1.Name = "colAccSortCode1"
        Me.colAccSortCode1.Visible = True
        Me.colAccSortCode1.VisibleIndex = 0
        '
        'colSortCodeName1
        '
        Me.colSortCodeName1.Caption = "اسم التصنيف"
        Me.colSortCodeName1.FieldName = "SortCodeName"
        Me.colSortCodeName1.Name = "colSortCodeName1"
        Me.colSortCodeName1.Visible = True
        Me.colSortCodeName1.VisibleIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlGroup2, Me.EmptySpaceItem3, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(956, 405)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.FromSortText
        Me.LayoutControlItem1.Location = New System.Drawing.Point(750, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(186, 24)
        Me.LayoutControlItem1.Text = "من تصنيف"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(936, 265)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(124, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ToSortText
        Me.LayoutControlItem2.Location = New System.Drawing.Point(750, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(186, 28)
        Me.LayoutControlItem2.Text = "الى تصنيف"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DateEditFrom
        Me.LayoutControlItem5.Location = New System.Drawing.Point(513, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem5.Text = "من تاريخ"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DateEditTo
        Me.LayoutControlItem6.Location = New System.Drawing.Point(513, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(237, 28)
        Me.LayoutControlItem6.Text = "الى تاريخ"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(124, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(124, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(194, 23)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 317)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(936, 68)
        Me.LayoutControlGroup2.Text = "هل تريد تحويل الارصدة الى مهام لموظف"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.ToUserText
        Me.LayoutControlItem8.Location = New System.Drawing.Point(649, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(263, 26)
        Me.LayoutControlItem8.Text = "تحويل الى"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.MonthText
        Me.LayoutControlItem9.Location = New System.Drawing.Point(446, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(203, 26)
        Me.LayoutControlItem9.Text = "الشهر"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton3
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(229, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(217, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(124, 23)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(389, 29)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.CheckShowZeroBalances
        Me.LayoutControlItem11.Location = New System.Drawing.Point(318, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(195, 23)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'AccSortNamesTableAdapter
        '
        Me.AccSortNamesTableAdapter.ClearBeforeFill = True
        '
        'FinancialAccountsBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 405)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FinancialAccountsBalances"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ارصدة حسابات"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckShowZeroBalances.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToUserText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromSortText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccSortNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToSortText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DateEditTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColAccountID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDebit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAFilter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColACOSTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColASphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToUserText As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As CRMDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents MonthText As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents FromSortText As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToSortText As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents AccSortNamesBindingSource As BindingSource
    Friend WithEvents AccSortNamesTableAdapter As WizCountDataSetTableAdapters.AccSortNamesTableAdapter
    Friend WithEvents colAccSortCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSortCodeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccSortCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSortCodeName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColACOSTCODEName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAccLastTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnAccrualChecks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColOpen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemOpen As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColAMAXCREDIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckShowZeroBalances As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
End Class
