<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintingAddDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintingAddDoc))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TextEditDocID = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PdfViewer2 = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.PrintingSystemDocsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintingSystemDocsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
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
        Me.PrintingSystemDocsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DocIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocColorNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocSizeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocPagesNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocCopiesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocAvaragePrrintTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DocPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextFilePath = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PrintingSystemDocsTableAdapter = New DXApplication5.CRMDataSetTableAdapters.PrintingSystemDocsTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextEditDocID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystemDocsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintingSystemDocsBindingNavigator.SuspendLayout()
        CType(Me.PrintingSystemDocsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocColorNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocPagesNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocCopiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocAvaragePrrintTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextFilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TextEditDocID)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.PdfViewer2)
        Me.LayoutControl1.Controls.Add(Me.PrintingSystemDocsBindingNavigator)
        Me.LayoutControl1.Controls.Add(Me.DocIDTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocColorNoTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocSizeTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocPagesNoTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocCopiesTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocAvaragePrrintTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DocPriceTextEdit)
        Me.LayoutControl1.Controls.Add(Me.TextFilePath)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(579, 506)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TextEditDocID
        '
        Me.TextEditDocID.Location = New System.Drawing.Point(392, 70)
        Me.TextEditDocID.Name = "TextEditDocID"
        Me.TextEditDocID.Size = New System.Drawing.Size(110, 20)
        Me.TextEditDocID.StyleController = Me.LayoutControl1
        Me.TextEditDocID.TabIndex = 59
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 238)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(99, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 57
        Me.SimpleButton1.Text = "استعراض"
        '
        'PdfViewer2
        '
        Me.PdfViewer2.Location = New System.Drawing.Point(12, 264)
        Me.PdfViewer2.Name = "PdfViewer2"
        Me.PdfViewer2.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
        Me.PdfViewer2.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None
        Me.PdfViewer2.Size = New System.Drawing.Size(555, 230)
        Me.PdfViewer2.TabIndex = 58
        Me.PdfViewer2.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible
        '
        'PrintingSystemDocsBindingNavigator
        '
        Me.PrintingSystemDocsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrintingSystemDocsBindingNavigator.AutoSize = False
        Me.PrintingSystemDocsBindingNavigator.BindingSource = Me.PrintingSystemDocsBindingSource
        Me.PrintingSystemDocsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PrintingSystemDocsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrintingSystemDocsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PrintingSystemDocsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PrintingSystemDocsBindingNavigatorSaveItem})
        Me.PrintingSystemDocsBindingNavigator.Location = New System.Drawing.Point(12, 12)
        Me.PrintingSystemDocsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PrintingSystemDocsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PrintingSystemDocsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PrintingSystemDocsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PrintingSystemDocsBindingNavigator.Name = "PrintingSystemDocsBindingNavigator"
        Me.PrintingSystemDocsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PrintingSystemDocsBindingNavigator.Size = New System.Drawing.Size(555, 30)
        Me.PrintingSystemDocsBindingNavigator.TabIndex = 1
        Me.PrintingSystemDocsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PrintingSystemDocsBindingSource
        '
        Me.PrintingSystemDocsBindingSource.DataMember = "PrintingSystemDocs"
        Me.PrintingSystemDocsBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'PrintingSystemDocsBindingNavigatorSaveItem
        '
        Me.PrintingSystemDocsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintingSystemDocsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrintingSystemDocsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrintingSystemDocsBindingNavigatorSaveItem.Name = "PrintingSystemDocsBindingNavigatorSaveItem"
        Me.PrintingSystemDocsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 27)
        Me.PrintingSystemDocsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DocIDTextEdit
        '
        Me.DocIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocID", True))
        Me.DocIDTextEdit.Location = New System.Drawing.Point(12, 46)
        Me.DocIDTextEdit.Name = "DocIDTextEdit"
        Me.DocIDTextEdit.Properties.ReadOnly = True
        Me.DocIDTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocIDTextEdit.StyleController = Me.LayoutControl1
        Me.DocIDTextEdit.TabIndex = 5
        '
        'DocNameTextEdit
        '
        Me.DocNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocName", True))
        Me.DocNameTextEdit.Location = New System.Drawing.Point(12, 70)
        Me.DocNameTextEdit.Name = "DocNameTextEdit"
        Me.DocNameTextEdit.Size = New System.Drawing.Size(311, 20)
        Me.DocNameTextEdit.StyleController = Me.LayoutControl1
        Me.DocNameTextEdit.TabIndex = 7
        '
        'DocColorNoTextEdit
        '
        Me.DocColorNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocColorNo", True))
        Me.DocColorNoTextEdit.Location = New System.Drawing.Point(12, 94)
        Me.DocColorNoTextEdit.Name = "DocColorNoTextEdit"
        Me.DocColorNoTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocColorNoTextEdit.StyleController = Me.LayoutControl1
        Me.DocColorNoTextEdit.TabIndex = 9
        '
        'DocSizeTextEdit
        '
        Me.DocSizeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocSize", True))
        Me.DocSizeTextEdit.Location = New System.Drawing.Point(12, 118)
        Me.DocSizeTextEdit.Name = "DocSizeTextEdit"
        Me.DocSizeTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocSizeTextEdit.StyleController = Me.LayoutControl1
        Me.DocSizeTextEdit.TabIndex = 11
        '
        'DocPagesNoTextEdit
        '
        Me.DocPagesNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocPagesNo", True))
        Me.DocPagesNoTextEdit.Location = New System.Drawing.Point(12, 142)
        Me.DocPagesNoTextEdit.Name = "DocPagesNoTextEdit"
        Me.DocPagesNoTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocPagesNoTextEdit.StyleController = Me.LayoutControl1
        Me.DocPagesNoTextEdit.TabIndex = 13
        '
        'DocCopiesTextEdit
        '
        Me.DocCopiesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocCopies", True))
        Me.DocCopiesTextEdit.Location = New System.Drawing.Point(12, 166)
        Me.DocCopiesTextEdit.Name = "DocCopiesTextEdit"
        Me.DocCopiesTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocCopiesTextEdit.StyleController = Me.LayoutControl1
        Me.DocCopiesTextEdit.TabIndex = 15
        '
        'DocAvaragePrrintTextEdit
        '
        Me.DocAvaragePrrintTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocAvaragePrrint", True))
        Me.DocAvaragePrrintTextEdit.Location = New System.Drawing.Point(12, 190)
        Me.DocAvaragePrrintTextEdit.Name = "DocAvaragePrrintTextEdit"
        Me.DocAvaragePrrintTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocAvaragePrrintTextEdit.StyleController = Me.LayoutControl1
        Me.DocAvaragePrrintTextEdit.TabIndex = 17
        '
        'DocPriceTextEdit
        '
        Me.DocPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingSystemDocsBindingSource, "DocPrice", True))
        Me.DocPriceTextEdit.Location = New System.Drawing.Point(12, 214)
        Me.DocPriceTextEdit.Name = "DocPriceTextEdit"
        Me.DocPriceTextEdit.Size = New System.Drawing.Size(490, 20)
        Me.DocPriceTextEdit.StyleController = Me.LayoutControl1
        Me.DocPriceTextEdit.TabIndex = 19
        '
        'TextFilePath
        '
        Me.BehaviorManager1.SetBehaviors(Me.TextFilePath, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, CType(resources.GetObject("TextFilePath.Behaviors"), System.Drawing.Image), Nothing), DevExpress.Utils.Behaviors.Behavior)})
        Me.TextFilePath.Location = New System.Drawing.Point(115, 238)
        Me.TextFilePath.Name = "TextFilePath"
        Me.TextFilePath.Properties.ContextImageOptions.Image = CType(resources.GetObject("TextFilePath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.TextFilePath.Properties.ReadOnly = True
        Me.TextFilePath.Size = New System.Drawing.Size(387, 20)
        Me.TextFilePath.StyleController = Me.LayoutControl1
        Me.TextFilePath.TabIndex = 55
        Me.TextFilePath.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem1, Me.LayoutControlItem29, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(579, 506)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DocIDTextEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem2.Text = "رقم"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DocNameTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem4.Text = "اسم الصنف"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DocColorNoTextEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem6.Text = "عدد الألوان"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DocSizeTextEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 106)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem8.Text = "الحجم"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.DocPagesNoTextEdit
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem10.Text = "عدد الأوراق"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.DocCopiesTextEdit
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem12.Text = "عدد النسخ"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.DocAvaragePrrintTextEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem14.Text = "معدل الطباعة"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.DocPriceTextEdit
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 202)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem16.Text = "سعر الحبة"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PrintingSystemDocsBindingNavigator
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(559, 34)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.TextFilePath
        Me.LayoutControlItem29.CustomizationFormText = "مرفقات"
        Me.LayoutControlItem29.Image = CType(resources.GetObject("LayoutControlItem29.Image"), System.Drawing.Image)
        Me.LayoutControlItem29.Location = New System.Drawing.Point(103, 226)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(456, 26)
        Me.LayoutControlItem29.Text = "مرفقات"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(62, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PdfViewer2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(559, 234)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 226)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(103, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TextEditDocID
        Me.LayoutControlItem7.Location = New System.Drawing.Point(380, 58)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(179, 24)
        Me.LayoutControlItem7.Text = "رقم"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(62, 13)
        '
        'PrintingSystemDocsTableAdapter
        '
        Me.PrintingSystemDocsTableAdapter.ClearBeforeFill = True
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
        'Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemDocsTableAdapter = Me.PrintingSystemDocsTableAdapter
        Me.TableAdapterManager.PrintingSystemJobsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Nothing
        Me.TableAdapterManager.transDocTableAdapter = Nothing
        Me.TableAdapterManager.transTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintingAddDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 506)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "PrintingAddDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "PrintingAddDoc"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextEditDocID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystemDocsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintingSystemDocsBindingNavigator.ResumeLayout(False)
        Me.PrintingSystemDocsBindingNavigator.PerformLayout()
        CType(Me.PrintingSystemDocsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocColorNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocPagesNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocCopiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocAvaragePrrintTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextFilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents PrintingSystemDocsBindingSource As BindingSource
    Friend WithEvents PrintingSystemDocsTableAdapter As CRMDataSetTableAdapters.PrintingSystemDocsTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintingSystemDocsBindingNavigator As BindingNavigator
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
    Friend WithEvents PrintingSystemDocsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DocIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocColorNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocSizeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocPagesNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocCopiesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocAvaragePrrintTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents PdfViewer2 As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextFilePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEditDocID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
