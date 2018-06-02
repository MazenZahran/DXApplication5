<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinanceCheksReport
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
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colFrontImage = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCHECK_NO = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colACCOUNT_NO = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colIB_BANK_ID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.ChecksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearingSystemDataSet = New DXApplication5.ClearingSystemDataSet()
        Me.ChecksTableAdapter = New DXApplication5.ClearingSystemDataSetTableAdapters.ChecksTableAdapter()
        Me.TableAdapterManager = New DXApplication5.ClearingSystemDataSetTableAdapters.TableAdapterManager()
        Me.ClearingSystemDataSet1 = New DXApplication5.ClearingSystemDataSet()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ChecksTableAdapter1 = New DXApplication5.ClearingSystemDataSetTableAdapters.ChecksTableAdapter()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SORT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.IB_BRANCH_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CHECK_NOTextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNT_NOTextBox = New System.Windows.Forms.TextBox()
        Me.RUN_DATETextBox = New System.Windows.Forms.TextBox()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.FrontImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.IB_BANK_IDTextBox = New System.Windows.Forms.TextBox()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colBANK_ID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colBRANCH_ID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colIB_BRANCH_ID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colSORT_ID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colRUN_DATE = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colRUN_USER = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colRearimage = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ChecksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ChecksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearingSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearingSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.FrontImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colFrontImage
        '
        Me.colFrontImage.FieldName = "FrontImage"
        Me.colFrontImage.Name = "colFrontImage"
        Me.colFrontImage.Visible = True
        Me.colFrontImage.VisibleIndex = 10
        '
        'colCHECK_NO
        '
        Me.colCHECK_NO.FieldName = "CHECK_NO"
        Me.colCHECK_NO.Name = "colCHECK_NO"
        Me.colCHECK_NO.Visible = True
        Me.colCHECK_NO.VisibleIndex = 6
        '
        'colACCOUNT_NO
        '
        Me.colACCOUNT_NO.FieldName = "ACCOUNT_NO"
        Me.colACCOUNT_NO.Name = "colACCOUNT_NO"
        Me.colACCOUNT_NO.Visible = True
        Me.colACCOUNT_NO.VisibleIndex = 7
        '
        'colIB_BANK_ID
        '
        Me.colIB_BANK_ID.FieldName = "IB_BANK_ID"
        Me.colIB_BANK_ID.Name = "colIB_BANK_ID"
        Me.colIB_BANK_ID.Visible = True
        Me.colIB_BANK_ID.VisibleIndex = 3
        '
        'ChecksBindingSource
        '
        Me.ChecksBindingSource.DataMember = "Checks"
        Me.ChecksBindingSource.DataSource = Me.ClearingSystemDataSet
        '
        'ClearingSystemDataSet
        '
        Me.ClearingSystemDataSet.DataSetName = "ClearingSystemDataSet"
        Me.ClearingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChecksTableAdapter
        '
        Me.ChecksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChecksTableAdapter = Me.ChecksTableAdapter
        Me.TableAdapterManager.UpdateOrder = DXApplication5.ClearingSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClearingSystemDataSet1
        '
        Me.ClearingSystemDataSet1.DataSetName = "ClearingSystemDataSet"
        Me.ClearingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'ChecksTableAdapter1
        '
        Me.ChecksTableAdapter1.ClearBeforeFill = True
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'SORT_IDTextBox
        '
        Me.SORT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecksBindingSource, "SORT_ID", True))
        Me.SORT_IDTextBox.Location = New System.Drawing.Point(678, 265)
        Me.SORT_IDTextBox.Name = "SORT_IDTextBox"
        Me.SORT_IDTextBox.ReadOnly = True
        Me.SORT_IDTextBox.Size = New System.Drawing.Size(78, 20)
        Me.SORT_IDTextBox.TabIndex = 11
        Me.SORT_IDTextBox.Visible = False
        '
        'IB_BRANCH_IDTextBox
        '
        Me.IB_BRANCH_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecksBindingSource, "IB_BRANCH_ID", True))
        Me.IB_BRANCH_IDTextBox.Location = New System.Drawing.Point(602, 265)
        Me.IB_BRANCH_IDTextBox.Name = "IB_BRANCH_IDTextBox"
        Me.IB_BRANCH_IDTextBox.ReadOnly = True
        Me.IB_BRANCH_IDTextBox.Size = New System.Drawing.Size(72, 20)
        Me.IB_BRANCH_IDTextBox.TabIndex = 9
        Me.IB_BRANCH_IDTextBox.Visible = False
        '
        'CHECK_NOTextBox
        '
        Me.CHECK_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecksBindingSource, "CHECK_NO", True))
        Me.CHECK_NOTextBox.Location = New System.Drawing.Point(446, 265)
        Me.CHECK_NOTextBox.Name = "CHECK_NOTextBox"
        Me.CHECK_NOTextBox.ReadOnly = True
        Me.CHECK_NOTextBox.Size = New System.Drawing.Size(79, 20)
        Me.CHECK_NOTextBox.TabIndex = 13
        Me.CHECK_NOTextBox.Visible = False
        '
        'ACCOUNT_NOTextBox
        '
        Me.ACCOUNT_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecksBindingSource, "ACCOUNT_NO", True))
        Me.ACCOUNT_NOTextBox.Location = New System.Drawing.Point(760, 265)
        Me.ACCOUNT_NOTextBox.Name = "ACCOUNT_NOTextBox"
        Me.ACCOUNT_NOTextBox.ReadOnly = True
        Me.ACCOUNT_NOTextBox.Size = New System.Drawing.Size(72, 20)
        Me.ACCOUNT_NOTextBox.TabIndex = 15
        Me.ACCOUNT_NOTextBox.Visible = False
        '
        'RUN_DATETextBox
        '
        Me.RUN_DATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecksBindingSource, "RUN_DATE", True))
        Me.RUN_DATETextBox.Location = New System.Drawing.Point(836, 265)
        Me.RUN_DATETextBox.Name = "RUN_DATETextBox"
        Me.RUN_DATETextBox.ReadOnly = True
        Me.RUN_DATETextBox.Size = New System.Drawing.Size(64, 20)
        Me.RUN_DATETextBox.TabIndex = 17
        Me.RUN_DATETextBox.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(253, 565)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(305, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 20
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.FrontImagePictureBox)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.IB_BANK_IDTextBox)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Controls.Add(Me.RUN_DATETextBox)
        Me.LayoutControl1.Controls.Add(Me.ACCOUNT_NOTextBox)
        Me.LayoutControl1.Controls.Add(Me.CHECK_NOTextBox)
        Me.LayoutControl1.Controls.Add(Me.IB_BRANCH_IDTextBox)
        Me.LayoutControl1.Controls.Add(Me.SORT_IDTextBox)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 272)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1086, 180, 450, 400)
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(925, 336)
        Me.LayoutControl1.TabIndex = 18
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'FrontImagePictureBox
        '
        Me.FrontImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ChecksBindingSource, "FrontImage", True))
        Me.FrontImagePictureBox.Location = New System.Drawing.Point(446, 45)
        Me.FrontImagePictureBox.Name = "FrontImagePictureBox"
        Me.FrontImagePictureBox.Size = New System.Drawing.Size(454, 216)
        Me.FrontImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FrontImagePictureBox.TabIndex = 24
        Me.FrontImagePictureBox.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 302)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(200, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "طباعة"
        '
        'IB_BANK_IDTextBox
        '
        Me.IB_BANK_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChecksBindingSource, "IB_BANK_ID", True))
        Me.IB_BANK_IDTextBox.Location = New System.Drawing.Point(529, 265)
        Me.IB_BANK_IDTextBox.Name = "IB_BANK_IDTextBox"
        Me.IB_BANK_IDTextBox.ReadOnly = True
        Me.IB_BANK_IDTextBox.Size = New System.Drawing.Size(69, 20)
        Me.IB_BANK_IDTextBox.TabIndex = 21
        Me.IB_BANK_IDTextBox.Visible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextEdit1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(241, 553)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(368, 26)
        Me.LayoutControlItem4.Text = "ID"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(56, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(925, 336)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem7, Me.LayoutControlItem11, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(421, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(484, 290)
        Me.LayoutControlGroup2.Text = "بيانات الشيك"
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.IB_BANK_IDTextBox
        Me.LayoutControlItem13.Location = New System.Drawing.Point(83, 220)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(73, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.IB_BRANCH_IDTextBox
        Me.LayoutControlItem8.Location = New System.Drawing.Point(156, 220)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(76, 24)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SORT_IDTextBox
        Me.LayoutControlItem9.Location = New System.Drawing.Point(232, 220)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(82, 24)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CHECK_NOTextBox
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(83, 24)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.ACCOUNT_NOTextBox
        Me.LayoutControlItem7.Location = New System.Drawing.Point(314, 220)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(76, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.RUN_DATETextBox
        Me.LayoutControlItem11.Location = New System.Drawing.Point(390, 220)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(68, 24)
        Me.LayoutControlItem11.Text = "تاريخ الادخال"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.FrontImagePictureBox
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(458, 220)
        Me.LayoutControlItem5.Text = "الشيك"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 290)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(204, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(204, 290)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(701, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(421, 290)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(925, 272)
        Me.LayoutControl2.TabIndex = 19
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Checks"
        Me.GridControl1.DataSource = Me.ClearingSystemDataSet1
        Me.GridControl1.Location = New System.Drawing.Point(25, 45)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(875, 202)
        Me.GridControl1.TabIndex = 23
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBANK_ID, Me.colBRANCH_ID, Me.colIB_BANK_ID, Me.colIB_BRANCH_ID, Me.colSORT_ID, Me.colCHECK_NO, Me.colACCOUNT_NO, Me.colRUN_DATE, Me.colRUN_USER, Me.colFrontImage, Me.colRearimage})
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsFind.AlwaysVisible = True
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(340, 144)
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.RowCount = 0
        TableColumnDefinition1.Length.Value = 76.0R
        TableColumnDefinition2.Length.Value = 71.0R
        TableColumnDefinition3.Length.Value = 77.0R
        Me.TileView1.TileColumns.Add(TableColumnDefinition1)
        Me.TileView1.TileColumns.Add(TableColumnDefinition2)
        Me.TileView1.TileColumns.Add(TableColumnDefinition3)
        TableRowDefinition1.Length.Value = 100.0R
        TableRowDefinition2.Length.Value = 13.0R
        TableRowDefinition3.Length.Value = 15.0R
        Me.TileView1.TileRows.Add(TableRowDefinition1)
        Me.TileView1.TileRows.Add(TableRowDefinition2)
        Me.TileView1.TileRows.Add(TableRowDefinition3)
        TableSpan1.ColumnSpan = 3
        TableSpan1.RowSpan = 2
        Me.TileView1.TileSpans.Add(TableSpan1)
        TileViewItemElement1.Column = Me.colFrontImage
        TileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.Text = "colFrontImage"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.Column = Me.colCHECK_NO
        TileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement2.RowIndex = 2
        TileViewItemElement2.Text = "colCHECK_NO"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.Column = Me.colACCOUNT_NO
        TileViewItemElement3.ColumnIndex = 2
        TileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement3.RowIndex = 2
        TileViewItemElement3.Text = "colACCOUNT_NO"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.Column = Me.colIB_BANK_ID
        TileViewItemElement4.ColumnIndex = 1
        TileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement4.RowIndex = 2
        TileViewItemElement4.Text = "colIB_BANK_ID"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        Me.TileView1.TileTemplate.Add(TileViewItemElement3)
        Me.TileView1.TileTemplate.Add(TileViewItemElement4)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colBANK_ID
        '
        Me.colBANK_ID.FieldName = "BANK_ID"
        Me.colBANK_ID.Name = "colBANK_ID"
        Me.colBANK_ID.Visible = True
        Me.colBANK_ID.VisibleIndex = 1
        '
        'colBRANCH_ID
        '
        Me.colBRANCH_ID.FieldName = "BRANCH_ID"
        Me.colBRANCH_ID.Name = "colBRANCH_ID"
        Me.colBRANCH_ID.Visible = True
        Me.colBRANCH_ID.VisibleIndex = 2
        '
        'colIB_BRANCH_ID
        '
        Me.colIB_BRANCH_ID.FieldName = "IB_BRANCH_ID"
        Me.colIB_BRANCH_ID.Name = "colIB_BRANCH_ID"
        Me.colIB_BRANCH_ID.Visible = True
        Me.colIB_BRANCH_ID.VisibleIndex = 4
        '
        'colSORT_ID
        '
        Me.colSORT_ID.FieldName = "SORT_ID"
        Me.colSORT_ID.Name = "colSORT_ID"
        Me.colSORT_ID.Visible = True
        Me.colSORT_ID.VisibleIndex = 5
        '
        'colRUN_DATE
        '
        Me.colRUN_DATE.FieldName = "RUN_DATE"
        Me.colRUN_DATE.Name = "colRUN_DATE"
        Me.colRUN_DATE.Visible = True
        Me.colRUN_DATE.VisibleIndex = 8
        '
        'colRUN_USER
        '
        Me.colRUN_USER.FieldName = "RUN_USER"
        Me.colRUN_USER.Name = "colRUN_USER"
        Me.colRUN_USER.Visible = True
        Me.colRUN_USER.VisibleIndex = 9
        '
        'colRearimage
        '
        Me.colRearimage.FieldName = "Rearimage"
        Me.colRearimage.Name = "colRearimage"
        Me.colRearimage.Visible = True
        Me.colRearimage.VisibleIndex = 11
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(925, 272)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(905, 252)
        Me.LayoutControlGroup3.Text = "الشيكات"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(879, 206)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'ChecksBindingSource1
        '
        Me.ChecksBindingSource1.DataMember = "Checks"
        Me.ChecksBindingSource1.DataSource = Me.ClearingSystemDataSet1
        '
        'FinanceCheksReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(925, 608)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FinanceCheksReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "FinanceCheksReport"
        CType(Me.ChecksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearingSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearingSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.FrontImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClearingSystemDataSet As ClearingSystemDataSet
    Friend WithEvents ChecksBindingSource As BindingSource
    Friend WithEvents ChecksTableAdapter As ClearingSystemDataSetTableAdapters.ChecksTableAdapter
    Friend WithEvents TableAdapterManager As ClearingSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClearingSystemDataSet1 As ClearingSystemDataSet
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ChecksTableAdapter1 As ClearingSystemDataSetTableAdapters.ChecksTableAdapter
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SORT_IDTextBox As TextBox
    Friend WithEvents IB_BRANCH_IDTextBox As TextBox
    Friend WithEvents CHECK_NOTextBox As TextBox
    Friend WithEvents ACCOUNT_NOTextBox As TextBox
    Friend WithEvents RUN_DATETextBox As TextBox
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IB_BANK_IDTextBox As TextBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colBANK_ID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colBRANCH_ID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colIB_BANK_ID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colIB_BRANCH_ID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colSORT_ID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCHECK_NO As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colACCOUNT_NO As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colRUN_DATE As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colRUN_USER As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colFrontImage As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colRearimage As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChecksBindingSource1 As BindingSource
    Friend WithEvents FrontImagePictureBox As PictureBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
