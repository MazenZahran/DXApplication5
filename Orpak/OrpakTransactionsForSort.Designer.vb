<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrpakTransactionsForSort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakTransactionsForSort))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ComboYear = New System.Windows.Forms.ComboBox()
        Me.ComboMonth = New System.Windows.Forms.ComboBox()
        Me.ButtonPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchSort = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.AccSortNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ButtonRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColTheDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTheTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colppv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colmean_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColStationName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFleetCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEmployeeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccSortNamesTableAdapter = New DXApplication5.WizCountDataSetTableAdapters.AccSortNamesTableAdapter()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchSort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccSortNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DockPanel1.ID = New System.Guid("11025474-748f-41be-beb0-e61fea47421c")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 541)
        Me.DockPanel1.Text = "خيارات البحث"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 512)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ComboYear)
        Me.LayoutControl1.Controls.Add(Me.ComboMonth)
        Me.LayoutControl1.Controls.Add(Me.ButtonPrint)
        Me.LayoutControl1.Controls.Add(Me.SearchSort)
        Me.LayoutControl1.Controls.Add(Me.ButtonRefresh)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(193, 512)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ComboYear
        '
        Me.ComboYear.FormattingEnabled = True
        Me.ComboYear.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.ComboYear.Location = New System.Drawing.Point(12, 36)
        Me.ComboYear.Name = "ComboYear"
        Me.ComboYear.Size = New System.Drawing.Size(137, 21)
        Me.ComboYear.TabIndex = 8
        '
        'ComboMonth
        '
        Me.ComboMonth.FormattingEnabled = True
        Me.ComboMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboMonth.Location = New System.Drawing.Point(12, 61)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Size = New System.Drawing.Size(137, 21)
        Me.ComboMonth.TabIndex = 7
        '
        'ButtonPrint
        '
        Me.ButtonPrint.ImageOptions.Image = CType(resources.GetObject("ButtonPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.ButtonPrint.Location = New System.Drawing.Point(12, 478)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(169, 22)
        Me.ButtonPrint.StyleController = Me.LayoutControl1
        Me.ButtonPrint.TabIndex = 6
        Me.ButtonPrint.Text = "طباعة"
        '
        'SearchSort
        '
        Me.SearchSort.Location = New System.Drawing.Point(12, 12)
        Me.SearchSort.Name = "SearchSort"
        Me.SearchSort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchSort.Properties.DataSource = Me.AccSortNamesBindingSource
        Me.SearchSort.Properties.DisplayMember = "SortCodeName"
        Me.SearchSort.Properties.NullText = ""
        Me.SearchSort.Properties.NullValuePrompt = "اختيار تصنيف"
        Me.SearchSort.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchSort.Properties.ValueMember = "AccSortCode"
        Me.SearchSort.Size = New System.Drawing.Size(169, 20)
        Me.SearchSort.StyleController = Me.LayoutControl1
        Me.SearchSort.TabIndex = 5
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
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.ImageOptions.Image = CType(resources.GetObject("ButtonRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.ButtonRefresh.Location = New System.Drawing.Point(12, 452)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(169, 22)
        Me.ButtonRefresh.StyleController = Me.LayoutControl1
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "تحديث"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(193, 512)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 74)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 366)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchSort
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ButtonRefresh
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 440)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ButtonPrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 466)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ComboMonth
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(173, 25)
        Me.LayoutControlItem4.Text = "الشهر"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(29, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ComboYear
        Me.LayoutControlItem5.CustomizationFormText = "السنة"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(173, 25)
        Me.LayoutControlItem5.Text = "السنة"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(29, 13)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(200, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(690, 541)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColTheDate, Me.ColTheTime, Me.Colsale, Me.Colppv, Me.ColQuantity, Me.Colplate, Me.Colmean_name, Me.ColProductName, Me.ColStationName, Me.ColFleetCode, Me.ColFullName, Me.ColEmployeeNo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sale", Me.Colsale, "{0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowChildrenInGroupPanel = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
        '
        'ColTheDate
        '
        Me.ColTheDate.Caption = "التاريخ"
        Me.ColTheDate.FieldName = "TheDate"
        Me.ColTheDate.Name = "ColTheDate"
        Me.ColTheDate.Visible = True
        Me.ColTheDate.VisibleIndex = 3
        '
        'ColTheTime
        '
        Me.ColTheTime.Caption = "الوقت"
        Me.ColTheTime.FieldName = "TheTime"
        Me.ColTheTime.Name = "ColTheTime"
        Me.ColTheTime.Visible = True
        Me.ColTheTime.VisibleIndex = 4
        '
        'Colsale
        '
        Me.Colsale.Caption = "المبلغ"
        Me.Colsale.FieldName = "sale"
        Me.Colsale.Name = "Colsale"
        Me.Colsale.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sale", "{0}")})
        Me.Colsale.Visible = True
        Me.Colsale.VisibleIndex = 5
        '
        'Colppv
        '
        Me.Colppv.Caption = "السعر"
        Me.Colppv.DisplayFormat.FormatString = "d2"
        Me.Colppv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Colppv.FieldName = "ppv"
        Me.Colppv.Name = "Colppv"
        Me.Colppv.Visible = True
        Me.Colppv.VisibleIndex = 6
        '
        'ColQuantity
        '
        Me.ColQuantity.Caption = "الكمية"
        Me.ColQuantity.FieldName = "Quantity"
        Me.ColQuantity.Name = "ColQuantity"
        Me.ColQuantity.Visible = True
        Me.ColQuantity.VisibleIndex = 7
        '
        'Colplate
        '
        Me.Colplate.Caption = "المركبة"
        Me.Colplate.FieldName = "plate"
        Me.Colplate.Name = "Colplate"
        Me.Colplate.Visible = True
        Me.Colplate.VisibleIndex = 8
        '
        'Colmean_name
        '
        Me.Colmean_name.Caption = "رقم البطاقة"
        Me.Colmean_name.FieldName = "mean_name"
        Me.Colmean_name.Name = "Colmean_name"
        Me.Colmean_name.Visible = True
        Me.Colmean_name.VisibleIndex = 9
        '
        'ColProductName
        '
        Me.ColProductName.Caption = "الصنف"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 10
        '
        'ColStationName
        '
        Me.ColStationName.Caption = "المحطة"
        Me.ColStationName.FieldName = "StationName"
        Me.ColStationName.Name = "ColStationName"
        Me.ColStationName.Visible = True
        Me.ColStationName.VisibleIndex = 11
        '
        'ColFleetCode
        '
        Me.ColFleetCode.Caption = "رقم الزبون"
        Me.ColFleetCode.FieldName = "FleetCode"
        Me.ColFleetCode.Name = "ColFleetCode"
        Me.ColFleetCode.Visible = True
        Me.ColFleetCode.VisibleIndex = 1
        '
        'ColFullName
        '
        Me.ColFullName.Caption = "الاسم"
        Me.ColFullName.FieldName = "FullName"
        Me.ColFullName.Name = "ColFullName"
        Me.ColFullName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FullName", "{0}")})
        Me.ColFullName.Visible = True
        Me.ColFullName.VisibleIndex = 0
        '
        'ColEmployeeNo
        '
        Me.ColEmployeeNo.Caption = "الرقم الوظيفي"
        Me.ColEmployeeNo.FieldName = "EmployeeNo"
        Me.ColEmployeeNo.Name = "ColEmployeeNo"
        Me.ColEmployeeNo.Visible = True
        Me.ColEmployeeNo.VisibleIndex = 2
        '
        'AccSortNamesTableAdapter
        '
        Me.AccSortNamesTableAdapter.ClearBeforeFill = True
        '
        'OrpakTransactionsForSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 541)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "OrpakTransactionsForSort"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقرير حركات تصنيف"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchSort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccSortNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ButtonRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SearchSort As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents AccSortNamesBindingSource As BindingSource
    Friend WithEvents AccSortNamesTableAdapter As WizCountDataSetTableAdapters.AccSortNamesTableAdapter
    Friend WithEvents ButtonPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ComboYear As ComboBox
    Friend WithEvents ComboMonth As ComboBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColTheDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTheTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colppv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colmean_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStationName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFleetCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEmployeeNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
