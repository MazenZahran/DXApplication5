<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinancialBulkReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialBulkReceipt))
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.ReceiptDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptDataTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ReceiptDataTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.ReceiptDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ReceiptDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ReceiptDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCustNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.Accounts1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecCustName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecOther = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecInputDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCurr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRecRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecAudit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecDeviceName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecOwner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.UsersTableAdapter = New DXApplication5.CRMDataSetTableAdapters.UsersTableAdapter()
        Me.Accounts1TableAdapter = New DXApplication5.WizCountDataSetTableAdapters.Accounts1TableAdapter()
        Me.ColTaskID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiptDataBindingNavigator.SuspendLayout()
        CType(Me.ReceiptDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiptDataBindingSource
        '
        Me.ReceiptDataBindingSource.DataMember = "ReceiptData"
        Me.ReceiptDataBindingSource.DataSource = Me.CRMDataSet
        '
        'ReceiptDataTableAdapter
        '
        Me.ReceiptDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChequeDataTableAdapter = Nothing
        Me.TableAdapterManager.CRMTasksTableAdapter = Nothing
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Me.ReceiptDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ReceiptDataBindingNavigator
        '
        Me.ReceiptDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceiptDataBindingNavigator.BindingSource = Me.ReceiptDataBindingSource
        Me.ReceiptDataBindingNavigator.CountItem = Nothing
        Me.ReceiptDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReceiptDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceiptDataBindingNavigatorSaveItem, Me.ToolStripTextBox1, Me.ToolStripButton1})
        Me.ReceiptDataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceiptDataBindingNavigator.MoveFirstItem = Nothing
        Me.ReceiptDataBindingNavigator.MoveLastItem = Nothing
        Me.ReceiptDataBindingNavigator.MoveNextItem = Nothing
        Me.ReceiptDataBindingNavigator.MovePreviousItem = Nothing
        Me.ReceiptDataBindingNavigator.Name = "ReceiptDataBindingNavigator"
        Me.ReceiptDataBindingNavigator.PositionItem = Nothing
        Me.ReceiptDataBindingNavigator.Size = New System.Drawing.Size(1361, 25)
        Me.ReceiptDataBindingNavigator.TabIndex = 0
        Me.ReceiptDataBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ReceiptDataBindingNavigatorSaveItem
        '
        Me.ReceiptDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReceiptDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceiptDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceiptDataBindingNavigatorSaveItem.Name = "ReceiptDataBindingNavigatorSaveItem"
        Me.ReceiptDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReceiptDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ReceiptDataGridControl
        '
        Me.ReceiptDataGridControl.DataSource = Me.ReceiptDataBindingSource
        Me.ReceiptDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiptDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ReceiptDataGridControl.MainView = Me.GridView1
        Me.ReceiptDataGridControl.Name = "ReceiptDataGridControl"
        Me.ReceiptDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemSearchLookUpEdit1})
        Me.ReceiptDataGridControl.Size = New System.Drawing.Size(1361, 839)
        Me.ReceiptDataGridControl.TabIndex = 1
        Me.ReceiptDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecNO, Me.colRecDate, Me.colRecCustNo, Me.colRecCustName, Me.colRecCash, Me.colRecCheque, Me.colRecOther, Me.colRecNote, Me.colRecUser, Me.colRecInputDate, Me.colRecStatus, Me.colRecCurr, Me.colRecRate, Me.colRecTotal, Me.colRecAudit, Me.colRecDeviceName, Me.colRecOwner, Me.ColTaskID})
        Me.GridView1.GridControl = Me.ReceiptDataGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRecNO
        '
        Me.colRecNO.FieldName = "RecNO"
        Me.colRecNO.Name = "colRecNO"
        '
        'colRecDate
        '
        Me.colRecDate.Caption = "تاريخ الدفعة"
        Me.colRecDate.FieldName = "RecDate"
        Me.colRecDate.Name = "colRecDate"
        Me.colRecDate.Visible = True
        Me.colRecDate.VisibleIndex = 0
        Me.colRecDate.Width = 134
        '
        'colRecCustNo
        '
        Me.colRecCustNo.Caption = "رقم الزبون"
        Me.colRecCustNo.ColumnEdit = Me.RepositoryItemSearchLookUpEdit1
        Me.colRecCustNo.FieldName = "RecCustNo"
        Me.colRecCustNo.Name = "colRecCustNo"
        Me.colRecCustNo.Visible = True
        Me.colRecCustNo.VisibleIndex = 1
        Me.colRecCustNo.Width = 134
        '
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.DataSource = Me.Accounts1BindingSource
        Me.RepositoryItemSearchLookUpEdit1.DisplayMember = "FullName"
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.ValueMember = "AccountKey"
        Me.RepositoryItemSearchLookUpEdit1.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'Accounts1BindingSource
        '
        Me.Accounts1BindingSource.DataMember = "Accounts1"
        Me.Accounts1BindingSource.DataSource = Me.WizCountDataSet
        '
        'WizCountDataSet
        '
        Me.WizCountDataSet.DataSetName = "WizCountDataSet"
        Me.WizCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRecCustName
        '
        Me.colRecCustName.Caption = "اسم الزبون"
        Me.colRecCustName.FieldName = "RecCustName"
        Me.colRecCustName.Name = "colRecCustName"
        Me.colRecCustName.Width = 250
        '
        'colRecCash
        '
        Me.colRecCash.Caption = "نقدا"
        Me.colRecCash.FieldName = "RecCash"
        Me.colRecCash.Name = "colRecCash"
        Me.colRecCash.Visible = True
        Me.colRecCash.VisibleIndex = 2
        Me.colRecCash.Width = 117
        '
        'colRecCheque
        '
        Me.colRecCheque.Caption = "شيكات"
        Me.colRecCheque.FieldName = "RecCheque"
        Me.colRecCheque.Name = "colRecCheque"
        Me.colRecCheque.Visible = True
        Me.colRecCheque.VisibleIndex = 3
        Me.colRecCheque.Width = 117
        '
        'colRecOther
        '
        Me.colRecOther.Caption = "اخرى"
        Me.colRecOther.FieldName = "RecOther"
        Me.colRecOther.Name = "colRecOther"
        Me.colRecOther.Visible = True
        Me.colRecOther.VisibleIndex = 4
        Me.colRecOther.Width = 117
        '
        'colRecNote
        '
        Me.colRecNote.Caption = "ملاحظات"
        Me.colRecNote.FieldName = "RecNote"
        Me.colRecNote.Name = "colRecNote"
        Me.colRecNote.Visible = True
        Me.colRecNote.VisibleIndex = 5
        Me.colRecNote.Width = 250
        '
        'colRecUser
        '
        Me.colRecUser.Caption = "المستخدم"
        Me.colRecUser.FieldName = "RecUser"
        Me.colRecUser.Name = "colRecUser"
        '
        'colRecInputDate
        '
        Me.colRecInputDate.Caption = "تاريخ الادخال"
        Me.colRecInputDate.FieldName = "RecInputDate"
        Me.colRecInputDate.Name = "colRecInputDate"
        '
        'colRecStatus
        '
        Me.colRecStatus.Caption = "حالة السند"
        Me.colRecStatus.FieldName = "RecStatus"
        Me.colRecStatus.Name = "colRecStatus"
        '
        'colRecCurr
        '
        Me.colRecCurr.Caption = "العملة"
        Me.colRecCurr.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colRecCurr.FieldName = "RecCurr"
        Me.colRecCurr.Name = "colRecCurr"
        Me.colRecCurr.Visible = True
        Me.colRecCurr.VisibleIndex = 6
        Me.colRecCurr.Width = 73
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"شيكل", "دولار", "دينار", "يورو"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colRecRate
        '
        Me.colRecRate.Caption = "سعر الصرف"
        Me.colRecRate.FieldName = "RecRate"
        Me.colRecRate.Name = "colRecRate"
        Me.colRecRate.Visible = True
        Me.colRecRate.VisibleIndex = 7
        Me.colRecRate.Width = 117
        '
        'colRecTotal
        '
        Me.colRecTotal.Caption = "المجموع"
        Me.colRecTotal.FieldName = "RecTotal"
        Me.colRecTotal.Name = "colRecTotal"
        Me.colRecTotal.Visible = True
        Me.colRecTotal.VisibleIndex = 8
        Me.colRecTotal.Width = 123
        '
        'colRecAudit
        '
        Me.colRecAudit.Caption = "مدقق"
        Me.colRecAudit.FieldName = "RecAudit"
        Me.colRecAudit.Name = "colRecAudit"
        '
        'colRecDeviceName
        '
        Me.colRecDeviceName.Caption = "الجهاز"
        Me.colRecDeviceName.FieldName = "RecDeviceName"
        Me.colRecDeviceName.Name = "colRecDeviceName"
        '
        'colRecOwner
        '
        Me.colRecOwner.Caption = "المالك"
        Me.colRecOwner.FieldName = "RecOwner"
        Me.colRecOwner.Name = "colRecOwner"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.CRMDataSet
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSplitContainer1.Grid = Me.ReceiptDataGridControl
        Me.GridSplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.ReceiptDataGridControl)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(1361, 839)
        Me.GridSplitContainer1.TabIndex = 1
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.Location = New System.Drawing.Point(214, 2)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "User ID", 46, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserPassword", "User Password", 81, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserType", "User Type", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserLastLogIn", "User Last Log In", 88, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserDevice", "User Device", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit2.Properties.DataSource = Me.UsersBindingSource
        Me.LookUpEdit2.Properties.DisplayMember = "UserName"
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.ValueMember = "ID"
        Me.LookUpEdit2.Size = New System.Drawing.Size(291, 20)
        Me.LookUpEdit2.TabIndex = 3
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'Accounts1TableAdapter
        '
        Me.Accounts1TableAdapter.ClearBeforeFill = True
        '
        'ColTaskID
        '
        Me.ColTaskID.Caption = "رقم المهمة"
        Me.ColTaskID.FieldName = "TaskID"
        Me.ColTaskID.Name = "ColTaskID"
        Me.ColTaskID.Visible = True
        Me.ColTaskID.VisibleIndex = 9
        '
        'FinancialBulkReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1361, 864)
        Me.Controls.Add(Me.LookUpEdit2)
        Me.Controls.Add(Me.GridSplitContainer1)
        Me.Controls.Add(Me.ReceiptDataBindingNavigator)
        Me.Name = "FinancialBulkReceipt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "سند قبض تجميعي"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiptDataBindingNavigator.ResumeLayout(False)
        Me.ReceiptDataBindingNavigator.PerformLayout()
        CType(Me.ReceiptDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents ReceiptDataBindingSource As BindingSource
    Friend WithEvents ReceiptDataTableAdapter As CRMDataSetTableAdapters.ReceiptDataTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceiptDataBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents ReceiptDataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ReceiptDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecCustNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecCustName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecCash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecOther As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecInputDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecCurr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecAudit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecDeviceName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents colRecOwner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As CRMDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents Accounts1BindingSource As BindingSource
    Friend WithEvents Accounts1TableAdapter As WizCountDataSetTableAdapters.Accounts1TableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ColTaskID As DevExpress.XtraGrid.Columns.GridColumn
End Class
