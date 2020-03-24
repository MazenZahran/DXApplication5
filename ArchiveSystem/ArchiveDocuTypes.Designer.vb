<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchiveDocuTypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArchiveDocuTypes))
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.ArchiveDocTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArchiveDocTypesTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ArchiveDocTypesTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.ArchiveDocTypesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ArchiveDocsSortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArchiveDocsSortTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ArchiveDocsSortTableAdapter()
        Me.ArchiveDocsSortGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDocTypes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArchiveSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButtonSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchiveDocTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchiveDocTypesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.ArchiveDocsSortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchiveDocsSortGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArchiveDocTypesBindingSource
        '
        Me.ArchiveDocTypesBindingSource.DataMember = "ArchiveDocTypes"
        Me.ArchiveDocTypesBindingSource.DataSource = Me.CRMDataSet
        '
        'ArchiveDocTypesTableAdapter
        '
        Me.ArchiveDocTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsAddDataTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocsSortTableAdapter = Me.ArchiveDocsSortTableAdapter
        Me.TableAdapterManager.ArchiveDocsTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocTypesTableAdapter = Me.ArchiveDocTypesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CardsTableAdapter = Nothing
        Me.TableAdapterManager.CardsTransTableAdapter = Nothing
        Me.TableAdapterManager.CarsMarkaTableAdapter = Nothing
        Me.TableAdapterManager.CarsModelTableAdapter = Nothing
        Me.TableAdapterManager.CarsNotesTableAdapter = Nothing
        Me.TableAdapterManager.CarsSort2TableAdapter = Nothing
        Me.TableAdapterManager.CarsSortTableAdapter = Nothing
        Me.TableAdapterManager.carsTableAdapter = Nothing
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
        'ArchiveDocTypesGridControl
        '
        Me.ArchiveDocTypesGridControl.DataSource = Me.ArchiveDocTypesBindingSource
        Me.ArchiveDocTypesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArchiveDocTypesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ArchiveDocTypesGridControl.MainView = Me.GridView1
        Me.ArchiveDocTypesGridControl.Name = "ArchiveDocTypesGridControl"
        Me.ArchiveDocTypesGridControl.Size = New System.Drawing.Size(350, 301)
        Me.ArchiveDocTypesGridControl.TabIndex = 1
        Me.ArchiveDocTypesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDocTypes})
        Me.GridView1.GridControl = Me.ArchiveDocTypesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'NavigationPane1
        '
        Me.NavigationPane1.AllowHtmlDraw = True
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Location = New System.Drawing.Point(12, 38)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(441, 362)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage2
        Me.NavigationPane1.Size = New System.Drawing.Size(441, 362)
        Me.NavigationPane1.TabIndex = 2
        Me.NavigationPane1.Text = "NavigationPane1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "تصنيف الوثائق"
        Me.NavigationPage1.Controls.Add(Me.ArchiveDocsSortGridControl)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(350, 301)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "انواع الوثائق"
        Me.NavigationPage2.Controls.Add(Me.ArchiveDocTypesGridControl)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(350, 301)
        '
        'ArchiveDocsSortBindingSource
        '
        Me.ArchiveDocsSortBindingSource.DataMember = "ArchiveDocsSort"
        Me.ArchiveDocsSortBindingSource.DataSource = Me.CRMDataSet
        '
        'ArchiveDocsSortTableAdapter
        '
        Me.ArchiveDocsSortTableAdapter.ClearBeforeFill = True
        '
        'ArchiveDocsSortGridControl
        '
        Me.ArchiveDocsSortGridControl.DataSource = Me.ArchiveDocsSortBindingSource
        Me.ArchiveDocsSortGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArchiveDocsSortGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ArchiveDocsSortGridControl.MainView = Me.GridView2
        Me.ArchiveDocsSortGridControl.Name = "ArchiveDocsSortGridControl"
        Me.ArchiveDocsSortGridControl.Size = New System.Drawing.Size(350, 301)
        Me.ArchiveDocsSortGridControl.TabIndex = 0
        Me.ArchiveDocsSortGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArchiveSort})
        Me.GridView2.GridControl = Me.ArchiveDocsSortGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colDocTypes
        '
        Me.colDocTypes.Caption = "نوع الوثيقة"
        Me.colDocTypes.FieldName = "DocTypes"
        Me.colDocTypes.Name = "colDocTypes"
        Me.colDocTypes.Visible = True
        Me.colDocTypes.VisibleIndex = 0
        '
        'colArchiveSort
        '
        Me.colArchiveSort.Caption = "التصنيف"
        Me.colArchiveSort.FieldName = "ArchiveSort"
        Me.colArchiveSort.Name = "colArchiveSort"
        Me.colArchiveSort.Visible = True
        Me.colArchiveSort.VisibleIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonSave)
        Me.LayoutControl1.Controls.Add(Me.NavigationPane1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(465, 412)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(465, 412)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.NavigationPane1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(445, 366)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleButtonSave
        '
        Me.SimpleButtonSave.ImageOptions.Image = CType(resources.GetObject("SimpleButtonSave.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButtonSave.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButtonSave.Name = "SimpleButtonSave"
        Me.SimpleButtonSave.Size = New System.Drawing.Size(107, 22)
        Me.SimpleButtonSave.StyleController = Me.LayoutControl1
        Me.SimpleButtonSave.TabIndex = 2
        Me.SimpleButtonSave.Text = "حفظ"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButtonSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(111, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(334, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ArchiveDocuTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 412)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ArchiveDocuTypes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "انواع الوثائق"
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchiveDocTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchiveDocTypesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.ArchiveDocsSortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchiveDocsSortGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents ArchiveDocTypesBindingSource As BindingSource
    Friend WithEvents ArchiveDocTypesTableAdapter As CRMDataSetTableAdapters.ArchiveDocTypesTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArchiveDocTypesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents ArchiveDocsSortBindingSource As BindingSource
    Friend WithEvents ArchiveDocsSortTableAdapter As CRMDataSetTableAdapters.ArchiveDocsSortTableAdapter
    Friend WithEvents ArchiveDocsSortGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDocTypes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArchiveSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButtonSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
