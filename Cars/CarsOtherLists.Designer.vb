<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarsOtherLists
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarsOtherLists))
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CarsInsurancCompaniesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CarsInsurancCompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInsurancCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CarsMarkaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CarsMarkaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMarka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CarsModelGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CarsModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.CarsSortGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CarsSortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCarSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CarsInsurancCompaniesTableAdapter = New DXApplication5.CRMDataSetTableAdapters.CarsInsurancCompaniesTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.CarsMarkaTableAdapter = New DXApplication5.CRMDataSetTableAdapters.CarsMarkaTableAdapter()
        Me.CarsModelTableAdapter = New DXApplication5.CRMDataSetTableAdapters.CarsModelTableAdapter()
        Me.CarsSortTableAdapter = New DXApplication5.CRMDataSetTableAdapters.CarsSortTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.CarsInsurancCompaniesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsInsurancCompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.CarsMarkaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsMarkaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage3.SuspendLayout()
        CType(Me.CarsModelGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage4.SuspendLayout()
        CType(Me.CarsSortGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsSortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationPane1
        '
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage3)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage4)
        Me.NavigationPane1.Location = New System.Drawing.Point(12, 38)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3, Me.NavigationPage4})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(601, 381)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage2
        Me.NavigationPane1.Size = New System.Drawing.Size(601, 381)
        Me.NavigationPane1.TabIndex = 0
        Me.NavigationPane1.Text = "NavigationPane1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "شركات التأمين"
        Me.NavigationPage1.Controls.Add(Me.CarsInsurancCompaniesGridControl)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(498, 321)
        '
        'CarsInsurancCompaniesGridControl
        '
        Me.CarsInsurancCompaniesGridControl.DataSource = Me.CarsInsurancCompaniesBindingSource
        Me.CarsInsurancCompaniesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarsInsurancCompaniesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CarsInsurancCompaniesGridControl.MainView = Me.GridView1
        Me.CarsInsurancCompaniesGridControl.Name = "CarsInsurancCompaniesGridControl"
        Me.CarsInsurancCompaniesGridControl.Size = New System.Drawing.Size(498, 321)
        Me.CarsInsurancCompaniesGridControl.TabIndex = 0
        Me.CarsInsurancCompaniesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CarsInsurancCompaniesBindingSource
        '
        Me.CarsInsurancCompaniesBindingSource.DataMember = "CarsInsurancCompanies"
        Me.CarsInsurancCompaniesBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInsurancCompany})
        Me.GridView1.GridControl = Me.CarsInsurancCompaniesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colInsurancCompany
        '
        Me.colInsurancCompany.Caption = "شركات التأمين"
        Me.colInsurancCompany.FieldName = "InsurancCompany"
        Me.colInsurancCompany.Name = "colInsurancCompany"
        Me.colInsurancCompany.Visible = True
        Me.colInsurancCompany.VisibleIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "أنواع المركبات"
        Me.NavigationPage2.Controls.Add(Me.CarsMarkaGridControl)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(498, 321)
        '
        'CarsMarkaGridControl
        '
        Me.CarsMarkaGridControl.DataSource = Me.CarsMarkaBindingSource
        Me.CarsMarkaGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarsMarkaGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CarsMarkaGridControl.MainView = Me.GridView2
        Me.CarsMarkaGridControl.Name = "CarsMarkaGridControl"
        Me.CarsMarkaGridControl.Size = New System.Drawing.Size(498, 321)
        Me.CarsMarkaGridControl.TabIndex = 0
        Me.CarsMarkaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'CarsMarkaBindingSource
        '
        Me.CarsMarkaBindingSource.DataMember = "CarsMarka"
        Me.CarsMarkaBindingSource.DataSource = Me.CRMDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMarka})
        Me.GridView2.GridControl = Me.CarsMarkaGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colMarka
        '
        Me.colMarka.Caption = "نوع المركبة"
        Me.colMarka.FieldName = "Marka"
        Me.colMarka.Name = "colMarka"
        Me.colMarka.Visible = True
        Me.colMarka.VisibleIndex = 0
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "موديل المركبات"
        Me.NavigationPage3.Controls.Add(Me.CarsModelGridControl)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(601, 364)
        '
        'CarsModelGridControl
        '
        Me.CarsModelGridControl.DataSource = Me.CarsModelBindingSource
        Me.CarsModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarsModelGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CarsModelGridControl.MainView = Me.GridView3
        Me.CarsModelGridControl.Name = "CarsModelGridControl"
        Me.CarsModelGridControl.Size = New System.Drawing.Size(601, 364)
        Me.CarsModelGridControl.TabIndex = 0
        Me.CarsModelGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'CarsModelBindingSource
        '
        Me.CarsModelBindingSource.DataMember = "CarsModel"
        Me.CarsModelBindingSource.DataSource = Me.CRMDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colModel})
        Me.GridView3.GridControl = Me.CarsModelGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colModel
        '
        Me.colModel.Caption = "الموديل"
        Me.colModel.FieldName = "Model"
        Me.colModel.Name = "colModel"
        Me.colModel.Visible = True
        Me.colModel.VisibleIndex = 0
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Caption = "التصنيفات"
        Me.NavigationPage4.Controls.Add(Me.CarsSortGridControl)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(498, 321)
        '
        'CarsSortGridControl
        '
        Me.CarsSortGridControl.DataSource = Me.CarsSortBindingSource
        Me.CarsSortGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarsSortGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CarsSortGridControl.MainView = Me.GridView4
        Me.CarsSortGridControl.Name = "CarsSortGridControl"
        Me.CarsSortGridControl.Size = New System.Drawing.Size(498, 321)
        Me.CarsSortGridControl.TabIndex = 0
        Me.CarsSortGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'CarsSortBindingSource
        '
        Me.CarsSortBindingSource.DataMember = "CarsSort"
        Me.CarsSortBindingSource.DataSource = Me.CRMDataSet
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCarSort})
        Me.GridView4.GridControl = Me.CarsSortGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCarSort
        '
        Me.colCarSort.Caption = "التصنيف"
        Me.colCarSort.FieldName = "CarSort"
        Me.colCarSort.Name = "colCarSort"
        Me.colCarSort.Visible = True
        Me.colCarSort.VisibleIndex = 0
        '
        'CarsInsurancCompaniesTableAdapter
        '
        Me.CarsInsurancCompaniesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CarsInsurancCompaniesTableAdapter = Me.CarsInsurancCompaniesTableAdapter
        Me.TableAdapterManager.CarsInsuranceTransTableAdapter = Nothing
        Me.TableAdapterManager.CarsMarkaTableAdapter = Me.CarsMarkaTableAdapter
        Me.TableAdapterManager.CarsModelTableAdapter = Me.CarsModelTableAdapter
        Me.TableAdapterManager.CarsNotesTableAdapter = Nothing
        Me.TableAdapterManager.CarsSort2TableAdapter = Nothing
        Me.TableAdapterManager.CarsSortTableAdapter = Me.CarsSortTableAdapter
        Me.TableAdapterManager.carsTableAdapter = Nothing
        Me.TableAdapterManager.CarsTarkhesTransTableAdapter = Nothing
        Me.TableAdapterManager.ChequeDataTableAdapter = Nothing
        Me.TableAdapterManager.CRMCustomersOrdersTableAdapter = Nothing
        Me.TableAdapterManager.CRMJobNameTableAdapter = Nothing
        Me.TableAdapterManager.CRMTasksTableAdapter = Nothing
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.FinancialBanksDocTableAdapter = Nothing
        'Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemDocsTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemJobsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Nothing
        Me.TableAdapterManager.transDocTableAdapter = Nothing
        Me.TableAdapterManager.transTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'CarsMarkaTableAdapter
        '
        Me.CarsMarkaTableAdapter.ClearBeforeFill = True
        '
        'CarsModelTableAdapter
        '
        Me.CarsModelTableAdapter.ClearBeforeFill = True
        '
        'CarsSortTableAdapter
        '
        Me.CarsSortTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.NavigationPane1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(625, 431)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(116, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "حفظ"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(625, 431)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.NavigationPane1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(605, 385)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(120, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(485, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'CarsOtherLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 431)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "CarsOtherLists"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ثوابت المركبات"
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.CarsInsurancCompaniesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsInsurancCompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.CarsMarkaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsMarkaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage3.ResumeLayout(False)
        CType(Me.CarsModelGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage4.ResumeLayout(False)
        CType(Me.CarsSortGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsSortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents CarsInsurancCompaniesBindingSource As BindingSource
    Friend WithEvents CarsInsurancCompaniesTableAdapter As CRMDataSetTableAdapters.CarsInsurancCompaniesTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarsInsurancCompaniesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CarsMarkaTableAdapter As CRMDataSetTableAdapters.CarsMarkaTableAdapter
    Friend WithEvents CarsMarkaBindingSource As BindingSource
    Friend WithEvents CarsMarkaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CarsModelTableAdapter As CRMDataSetTableAdapters.CarsModelTableAdapter
    Friend WithEvents CarsModelBindingSource As BindingSource
    Friend WithEvents CarsModelGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colInsurancCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents CarsSortBindingSource As BindingSource
    Friend WithEvents CarsSortTableAdapter As CRMDataSetTableAdapters.CarsSortTableAdapter
    Friend WithEvents CarsSortGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCarSort As DevExpress.XtraGrid.Columns.GridColumn
End Class
