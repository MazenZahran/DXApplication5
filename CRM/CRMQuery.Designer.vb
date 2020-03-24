<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMQuery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRMQuery))
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.CRMTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMTasksTableAdapter = New DXApplication5.CRMDataSetTableAdapters.CRMTasksTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.CRMTasksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CRMTasksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CRMTasksGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTaskID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoteStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccrualDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCloseDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCloseNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportance = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMTasksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CRMTasksBindingNavigator.SuspendLayout()
        CType(Me.CRMTasksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRMTasksBindingSource
        '
        Me.CRMTasksBindingSource.DataMember = "CRMTasks"
        Me.CRMTasksBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMTasksTableAdapter
        '
        Me.CRMTasksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChequeDataTableAdapter = Nothing
        Me.TableAdapterManager.CRMTasksTableAdapter = Me.CRMTasksTableAdapter
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        'Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'CRMTasksBindingNavigator
        '
        Me.CRMTasksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CRMTasksBindingNavigator.BindingSource = Me.CRMTasksBindingSource
        Me.CRMTasksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CRMTasksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CRMTasksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CRMTasksBindingNavigatorSaveItem})
        Me.CRMTasksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CRMTasksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CRMTasksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CRMTasksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CRMTasksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CRMTasksBindingNavigator.Name = "CRMTasksBindingNavigator"
        Me.CRMTasksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CRMTasksBindingNavigator.Size = New System.Drawing.Size(1095, 25)
        Me.CRMTasksBindingNavigator.TabIndex = 0
        Me.CRMTasksBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CRMTasksBindingNavigatorSaveItem
        '
        Me.CRMTasksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CRMTasksBindingNavigatorSaveItem.Image = CType(resources.GetObject("CRMTasksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CRMTasksBindingNavigatorSaveItem.Name = "CRMTasksBindingNavigatorSaveItem"
        Me.CRMTasksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CRMTasksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CRMTasksGridControl
        '
        Me.CRMTasksGridControl.DataSource = Me.CRMTasksBindingSource
        Me.CRMTasksGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRMTasksGridControl.Location = New System.Drawing.Point(0, 25)
        Me.CRMTasksGridControl.MainView = Me.GridView1
        Me.CRMTasksGridControl.Name = "CRMTasksGridControl"
        Me.CRMTasksGridControl.Size = New System.Drawing.Size(1095, 495)
        Me.CRMTasksGridControl.TabIndex = 1
        Me.CRMTasksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTaskID, Me.colInputDate, Me.colInputTime, Me.colUser, Me.colCustID, Me.colCustomerName, Me.colPerson, Me.colNote, Me.colNoteStatus, Me.colToUser, Me.colAccrualDate, Me.colCloseDate, Me.colCloseNote, Me.colTaskType, Me.colAccSort, Me.colAmount, Me.colTaskMonth, Me.colImportance})
        Me.GridView1.GridControl = Me.CRMTasksGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colTaskID
        '
        Me.colTaskID.FieldName = "TaskID"
        Me.colTaskID.Name = "colTaskID"
        Me.colTaskID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TaskID", "{0}")})
        Me.colTaskID.Visible = True
        Me.colTaskID.VisibleIndex = 0
        '
        'colInputDate
        '
        Me.colInputDate.FieldName = "InputDate"
        Me.colInputDate.Name = "colInputDate"
        Me.colInputDate.Visible = True
        Me.colInputDate.VisibleIndex = 1
        '
        'colInputTime
        '
        Me.colInputTime.FieldName = "InputTime"
        Me.colInputTime.Name = "colInputTime"
        Me.colInputTime.Visible = True
        Me.colInputTime.VisibleIndex = 2
        '
        'colUser
        '
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 3
        '
        'colCustID
        '
        Me.colCustID.FieldName = "CustID"
        Me.colCustID.Name = "colCustID"
        Me.colCustID.Visible = True
        Me.colCustID.VisibleIndex = 4
        '
        'colCustomerName
        '
        Me.colCustomerName.FieldName = "CustomerName"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.Visible = True
        Me.colCustomerName.VisibleIndex = 5
        '
        'colPerson
        '
        Me.colPerson.FieldName = "Person"
        Me.colPerson.Name = "colPerson"
        Me.colPerson.Visible = True
        Me.colPerson.VisibleIndex = 6
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 7
        '
        'colNoteStatus
        '
        Me.colNoteStatus.FieldName = "NoteStatus"
        Me.colNoteStatus.Name = "colNoteStatus"
        Me.colNoteStatus.Visible = True
        Me.colNoteStatus.VisibleIndex = 8
        '
        'colToUser
        '
        Me.colToUser.FieldName = "ToUser"
        Me.colToUser.Name = "colToUser"
        Me.colToUser.Visible = True
        Me.colToUser.VisibleIndex = 9
        '
        'colAccrualDate
        '
        Me.colAccrualDate.FieldName = "AccrualDate"
        Me.colAccrualDate.Name = "colAccrualDate"
        Me.colAccrualDate.Visible = True
        Me.colAccrualDate.VisibleIndex = 10
        '
        'colCloseDate
        '
        Me.colCloseDate.FieldName = "CloseDate"
        Me.colCloseDate.Name = "colCloseDate"
        Me.colCloseDate.Visible = True
        Me.colCloseDate.VisibleIndex = 11
        '
        'colCloseNote
        '
        Me.colCloseNote.FieldName = "CloseNote"
        Me.colCloseNote.Name = "colCloseNote"
        Me.colCloseNote.Visible = True
        Me.colCloseNote.VisibleIndex = 12
        '
        'colTaskType
        '
        Me.colTaskType.FieldName = "TaskType"
        Me.colTaskType.Name = "colTaskType"
        Me.colTaskType.Visible = True
        Me.colTaskType.VisibleIndex = 13
        '
        'colAccSort
        '
        Me.colAccSort.FieldName = "AccSort"
        Me.colAccSort.Name = "colAccSort"
        Me.colAccSort.Visible = True
        Me.colAccSort.VisibleIndex = 14
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0}")})
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 15
        '
        'colTaskMonth
        '
        Me.colTaskMonth.FieldName = "TaskMonth"
        Me.colTaskMonth.Name = "colTaskMonth"
        Me.colTaskMonth.Visible = True
        Me.colTaskMonth.VisibleIndex = 16
        '
        'colImportance
        '
        Me.colImportance.FieldName = "Importance"
        Me.colImportance.Name = "colImportance"
        Me.colImportance.Visible = True
        Me.colImportance.VisibleIndex = 17
        '
        'CRMQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 520)
        Me.Controls.Add(Me.CRMTasksGridControl)
        Me.Controls.Add(Me.CRMTasksBindingNavigator)
        Me.Name = "CRMQuery"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "استعلام و تعديل المهام"
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMTasksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CRMTasksBindingNavigator.ResumeLayout(False)
        Me.CRMTasksBindingNavigator.PerformLayout()
        CType(Me.CRMTasksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents CRMTasksBindingSource As BindingSource
    Friend WithEvents CRMTasksTableAdapter As CRMDataSetTableAdapters.CRMTasksTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CRMTasksBindingNavigator As BindingNavigator
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
    Friend WithEvents CRMTasksBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CRMTasksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTaskID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoteStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccrualDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCloseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCloseNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportance As DevExpress.XtraGrid.Columns.GridColumn
End Class
