<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraForm5))
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.FinancialChequesBackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinancialChequesBackTableAdapter = New DXApplication5.CRMDataSetTableAdapters.FinancialChequesBackTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.FinancialChequesBackBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.FinancialChequesBackBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FinancialChequesBackGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinancialChequesBackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinancialChequesBackBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinancialChequesBackBindingNavigator.SuspendLayout()
        CType(Me.FinancialChequesBackGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinancialChequesBackBindingSource
        '
        Me.FinancialChequesBackBindingSource.DataMember = "FinancialChequesBack"
        Me.FinancialChequesBackBindingSource.DataSource = Me.CRMDataSet
        '
        'FinancialChequesBackTableAdapter
        '
        Me.FinancialChequesBackTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.FinancialBanksDocTableAdapter = Nothing
        Me.TableAdapterManager.FinancialChequesBackTableAdapter = Me.FinancialChequesBackTableAdapter
        Me.TableAdapterManager.PrintingSystemDocsTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemJobsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Nothing
        Me.TableAdapterManager.transDocTableAdapter = Nothing
        Me.TableAdapterManager.transTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'FinancialChequesBackBindingNavigator
        '
        Me.FinancialChequesBackBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FinancialChequesBackBindingNavigator.BindingSource = Me.FinancialChequesBackBindingSource
        Me.FinancialChequesBackBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FinancialChequesBackBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FinancialChequesBackBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FinancialChequesBackBindingNavigatorSaveItem})
        Me.FinancialChequesBackBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinancialChequesBackBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FinancialChequesBackBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FinancialChequesBackBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FinancialChequesBackBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FinancialChequesBackBindingNavigator.Name = "FinancialChequesBackBindingNavigator"
        Me.FinancialChequesBackBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FinancialChequesBackBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.FinancialChequesBackBindingNavigator.TabIndex = 0
        Me.FinancialChequesBackBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FinancialChequesBackBindingNavigatorSaveItem
        '
        Me.FinancialChequesBackBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FinancialChequesBackBindingNavigatorSaveItem.Image = CType(resources.GetObject("FinancialChequesBackBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FinancialChequesBackBindingNavigatorSaveItem.Name = "FinancialChequesBackBindingNavigatorSaveItem"
        Me.FinancialChequesBackBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FinancialChequesBackBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FinancialChequesBackGridControl
        '
        Me.FinancialChequesBackGridControl.DataSource = Me.FinancialChequesBackBindingSource
        Me.FinancialChequesBackGridControl.Location = New System.Drawing.Point(400, 206)
        Me.FinancialChequesBackGridControl.MainView = Me.GridView1
        Me.FinancialChequesBackGridControl.Name = "FinancialChequesBackGridControl"
        Me.FinancialChequesBackGridControl.Size = New System.Drawing.Size(300, 220)
        Me.FinancialChequesBackGridControl.TabIndex = 1
        Me.FinancialChequesBackGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.FinancialChequesBackGridControl
        Me.GridView1.Name = "GridView1"
        '
        'XtraForm5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 493)
        Me.Controls.Add(Me.FinancialChequesBackGridControl)
        Me.Controls.Add(Me.FinancialChequesBackBindingNavigator)
        Me.Name = "XtraForm5"
        Me.Text = "XtraForm5"
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinancialChequesBackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinancialChequesBackBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinancialChequesBackBindingNavigator.ResumeLayout(False)
        Me.FinancialChequesBackBindingNavigator.PerformLayout()
        CType(Me.FinancialChequesBackGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents FinancialChequesBackBindingSource As BindingSource
    Friend WithEvents FinancialChequesBackTableAdapter As CRMDataSetTableAdapters.FinancialChequesBackTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinancialChequesBackBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FinancialChequesBackBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FinancialChequesBackGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
