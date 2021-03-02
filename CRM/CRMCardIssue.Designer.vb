<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRMCardIssue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRMCardIssue))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TextFleetID = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckPrintDoc = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButtonNew = New DevExpress.XtraEditors.SimpleButton()
        Me.PersonName = New DevExpress.XtraEditors.TextEdit()
        Me.CardsTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.TransNotes = New DevExpress.XtraEditors.TextEdit()
        Me.TransUser = New DevExpress.XtraEditors.TextEdit()
        Me.AccountNo = New DevExpress.XtraEditors.TextEdit()
        Me.CardTransDate = New DevExpress.XtraEditors.TextEdit()
        Me.DocID = New DevExpress.XtraEditors.SpinEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.CardsTransGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCardID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryCardNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCardTransDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransUser1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransNotes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCardSerial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCardStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupRule = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryRules = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HODATADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HO_DATADataSet = New DXApplication5.HO_DATADataSet()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlateNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryPlateNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEditPerson = New DevExpress.XtraEditors.TextEdit()
        Me.IssueDate = New DevExpress.XtraEditors.DateEdit()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccountKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEditNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Accounts1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WizCountDataSet = New DXApplication5.WizCountDataSet()
        Me.Accounts1TableAdapter = New DXApplication5.WizCountDataSetTableAdapters.Accounts1TableAdapter()
        Me.CardsTransTableAdapter = New DXApplication5.CRMDataSetTableAdapters.CardsTransTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.Group_rulesTableAdapter = New DXApplication5.HO_DATADataSetTableAdapters.group_rulesTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextFleetID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPrintDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardTransDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsTransGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCardNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryRules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HODATADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryPlateNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TextFleetID)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.CheckPrintDoc)
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonNew)
        Me.LayoutControl1.Controls.Add(Me.PersonName)
        Me.LayoutControl1.Controls.Add(Me.TransNotes)
        Me.LayoutControl1.Controls.Add(Me.TransUser)
        Me.LayoutControl1.Controls.Add(Me.AccountNo)
        Me.LayoutControl1.Controls.Add(Me.CardTransDate)
        Me.LayoutControl1.Controls.Add(Me.DocID)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.CardsTransGridControl)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.TextEditPerson)
        Me.LayoutControl1.Controls.Add(Me.IssueDate)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.TextEditNotes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsFocus.EnableAutoTabOrder = False
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(723, 576)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TextFleetID
        '
        Me.TextFleetID.Location = New System.Drawing.Point(224, 171)
        Me.TextFleetID.Name = "TextFleetID"
        Me.TextFleetID.Properties.ReadOnly = True
        Me.TextFleetID.Size = New System.Drawing.Size(161, 20)
        Me.TextFleetID.StyleController = Me.LayoutControl1
        Me.TextFleetID.TabIndex = 13
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(348, 64)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(108, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "طباعة"
        '
        'CheckPrintDoc
        '
        Me.CheckPrintDoc.EditValue = True
        Me.CheckPrintDoc.Location = New System.Drawing.Point(12, 64)
        Me.CheckPrintDoc.Name = "CheckPrintDoc"
        Me.CheckPrintDoc.Properties.Caption = "طباعة نموذج استلام"
        Me.CheckPrintDoc.Size = New System.Drawing.Size(220, 20)
        Me.CheckPrintDoc.StyleController = Me.LayoutControl1
        Me.CheckPrintDoc.TabIndex = 8
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "سند اصدار بطاقة"
        Me.TextEdit1.Location = New System.Drawing.Point(12, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.LightSlateGray
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.TextEdit1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(699, 48)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 11
        '
        'SimpleButtonNew
        '
        Me.SimpleButtonNew.ImageOptions.Image = CType(resources.GetObject("SimpleButtonNew.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButtonNew.Location = New System.Drawing.Point(460, 64)
        Me.SimpleButtonNew.Name = "SimpleButtonNew"
        Me.SimpleButtonNew.Size = New System.Drawing.Size(120, 22)
        Me.SimpleButtonNew.StyleController = Me.LayoutControl1
        Me.SimpleButtonNew.TabIndex = 6
        Me.SimpleButtonNew.Text = "جديد"
        '
        'PersonName
        '
        Me.PersonName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CardsTransBindingSource, "PersonName", True))
        Me.PersonName.Location = New System.Drawing.Point(24, 508)
        Me.PersonName.Name = "PersonName"
        Me.PersonName.Properties.ReadOnly = True
        Me.PersonName.Size = New System.Drawing.Size(111, 20)
        Me.PersonName.StyleController = Me.LayoutControl1
        Me.PersonName.TabIndex = 12
        '
        'CardsTransBindingSource
        '
        Me.CardsTransBindingSource.DataMember = "CardsTrans"
        Me.CardsTransBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransNotes
        '
        Me.TransNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CardsTransBindingSource, "TransNotes", True))
        Me.TransNotes.Location = New System.Drawing.Point(185, 532)
        Me.TransNotes.Name = "TransNotes"
        Me.TransNotes.Properties.ReadOnly = True
        Me.TransNotes.Size = New System.Drawing.Size(435, 20)
        Me.TransNotes.StyleController = Me.LayoutControl1
        Me.TransNotes.TabIndex = 11
        '
        'TransUser
        '
        Me.TransUser.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CardsTransBindingSource, "TransUser", True))
        Me.TransUser.Location = New System.Drawing.Point(24, 532)
        Me.TransUser.Name = "TransUser"
        Me.TransUser.Properties.ReadOnly = True
        Me.TransUser.Size = New System.Drawing.Size(103, 20)
        Me.TransUser.StyleController = Me.LayoutControl1
        Me.TransUser.TabIndex = 10
        '
        'AccountNo
        '
        Me.AccountNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CardsTransBindingSource, "AccountName", True))
        Me.AccountNo.Location = New System.Drawing.Point(185, 508)
        Me.AccountNo.Name = "AccountNo"
        Me.AccountNo.Properties.ReadOnly = True
        Me.AccountNo.Size = New System.Drawing.Size(309, 20)
        Me.AccountNo.StyleController = Me.LayoutControl1
        Me.AccountNo.TabIndex = 9
        '
        'CardTransDate
        '
        Me.CardTransDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CardsTransBindingSource, "CardTransDate", True))
        Me.CardTransDate.Location = New System.Drawing.Point(529, 508)
        Me.CardTransDate.Name = "CardTransDate"
        Me.CardTransDate.Properties.Mask.EditMask = "d"
        Me.CardTransDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.CardTransDate.Properties.ReadOnly = True
        Me.CardTransDate.Size = New System.Drawing.Size(109, 20)
        Me.CardTransDate.StyleController = Me.LayoutControl1
        Me.CardTransDate.TabIndex = 8
        '
        'DocID
        '
        Me.DocID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DocID.Location = New System.Drawing.Point(596, 102)
        Me.DocID.Name = "DocID"
        Me.DocID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DocID.Size = New System.Drawing.Size(50, 20)
        Me.DocID.StyleController = Me.LayoutControl1
        Me.DocID.TabIndex = 9
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(24, 195)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Phone", "اتصال"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Email", "ايميل"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Document", "كتاب"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Other", "أخرى")})
        Me.RadioGroup1.Size = New System.Drawing.Size(596, 25)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 2
        '
        'CardsTransGridControl
        '
        Me.CardsTransGridControl.DataSource = Me.CardsTransBindingSource
        Me.CardsTransGridControl.Location = New System.Drawing.Point(12, 236)
        Me.CardsTransGridControl.MainView = Me.GridView2
        Me.CardsTransGridControl.Name = "CardsTransGridControl"
        Me.CardsTransGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryRules, Me.RepositoryPlateNo, Me.RepositoryCardNo})
        Me.CardsTransGridControl.Size = New System.Drawing.Size(699, 140)
        Me.CardsTransGridControl.TabIndex = 3
        Me.CardsTransGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colCardID1, Me.colCardTransDate1, Me.colAccountNo1, Me.colAccountName1, Me.colTransUser1, Me.colTransNotes1, Me.colPersonName1, Me.colDocType1, Me.colCardSerial1, Me.colCardStatus1, Me.colDocID, Me.colGroupRule, Me.colPlateNo})
        Me.GridView2.GridControl = Me.CardsTransGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colCardID1
        '
        Me.colCardID1.Caption = "رقم الكرت"
        Me.colCardID1.ColumnEdit = Me.RepositoryCardNo
        Me.colCardID1.FieldName = "CardID"
        Me.colCardID1.Name = "colCardID1"
        Me.colCardID1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CardID", "{0}")})
        Me.colCardID1.Visible = True
        Me.colCardID1.VisibleIndex = 0
        '
        'RepositoryCardNo
        '
        Me.RepositoryCardNo.AutoHeight = False
        Me.RepositoryCardNo.Name = "RepositoryCardNo"
        '
        'colCardTransDate1
        '
        Me.colCardTransDate1.FieldName = "CardTransDate"
        Me.colCardTransDate1.Name = "colCardTransDate1"
        '
        'colAccountNo1
        '
        Me.colAccountNo1.FieldName = "AccountNo"
        Me.colAccountNo1.Name = "colAccountNo1"
        '
        'colAccountName1
        '
        Me.colAccountName1.FieldName = "AccountName"
        Me.colAccountName1.Name = "colAccountName1"
        '
        'colTransUser1
        '
        Me.colTransUser1.FieldName = "TransUser"
        Me.colTransUser1.Name = "colTransUser1"
        '
        'colTransNotes1
        '
        Me.colTransNotes1.FieldName = "TransNotes"
        Me.colTransNotes1.Name = "colTransNotes1"
        '
        'colPersonName1
        '
        Me.colPersonName1.FieldName = "PersonName"
        Me.colPersonName1.Name = "colPersonName1"
        '
        'colDocType1
        '
        Me.colDocType1.FieldName = "DocType"
        Me.colDocType1.Name = "colDocType1"
        '
        'colCardSerial1
        '
        Me.colCardSerial1.Caption = "السيريال"
        Me.colCardSerial1.FieldName = "CardSerial"
        Me.colCardSerial1.Name = "colCardSerial1"
        Me.colCardSerial1.OptionsColumn.ReadOnly = True
        Me.colCardSerial1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.colCardSerial1.Visible = True
        Me.colCardSerial1.VisibleIndex = 3
        '
        'colCardStatus1
        '
        Me.colCardStatus1.Caption = "حالة الكرت"
        Me.colCardStatus1.FieldName = "CardStatus"
        Me.colCardStatus1.Name = "colCardStatus1"
        '
        'colDocID
        '
        Me.colDocID.FieldName = "DocID"
        Me.colDocID.Name = "colDocID"
        '
        'colGroupRule
        '
        Me.colGroupRule.Caption = "السقف"
        Me.colGroupRule.ColumnEdit = Me.RepositoryRules
        Me.colGroupRule.FieldName = "GroupRule"
        Me.colGroupRule.Name = "colGroupRule"
        Me.colGroupRule.Visible = True
        Me.colGroupRule.VisibleIndex = 2
        '
        'RepositoryRules
        '
        Me.RepositoryRules.AutoHeight = False
        Me.RepositoryRules.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryRules.DataSource = Me.BindingSource1
        Me.RepositoryRules.DisplayMember = "name"
        Me.RepositoryRules.Name = "RepositoryRules"
        Me.RepositoryRules.NullText = ""
        Me.RepositoryRules.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.RepositoryRules.ValueMember = "id"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "group_rules"
        Me.BindingSource1.DataSource = Me.HODATADataSetBindingSource
        '
        'HODATADataSetBindingSource
        '
        Me.HODATADataSetBindingSource.DataSource = Me.HO_DATADataSet
        Me.HODATADataSetBindingSource.Position = 0
        '
        'HO_DATADataSet
        '
        Me.HO_DATADataSet.DataSetName = "HO_DATADataSet"
        Me.HO_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colname, Me.colid})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colPlateNo
        '
        Me.colPlateNo.Caption = "المركبة"
        Me.colPlateNo.ColumnEdit = Me.RepositoryPlateNo
        Me.colPlateNo.FieldName = "PlateNo"
        Me.colPlateNo.Name = "colPlateNo"
        Me.colPlateNo.Visible = True
        Me.colPlateNo.VisibleIndex = 1
        '
        'RepositoryPlateNo
        '
        Me.RepositoryPlateNo.AutoHeight = False
        Me.RepositoryPlateNo.Name = "RepositoryPlateNo"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(584, 64)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(127, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "حفظ F2"
        '
        'TextEditPerson
        '
        Me.TextEditPerson.Location = New System.Drawing.Point(24, 171)
        Me.TextEditPerson.Name = "TextEditPerson"
        Me.TextEditPerson.Size = New System.Drawing.Size(150, 20)
        Me.TextEditPerson.StyleController = Me.LayoutControl1
        Me.TextEditPerson.TabIndex = 1
        '
        'IssueDate
        '
        Me.IssueDate.EditValue = Nothing
        Me.IssueDate.Location = New System.Drawing.Point(24, 102)
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.IssueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssueDate.Size = New System.Drawing.Size(157, 20)
        Me.IssueDate.StyleController = Me.LayoutControl1
        Me.IssueDate.TabIndex = 10
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.EditValue = "Null"
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(389, 171)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DisplayMember = "FullName"
        Me.SearchLookUpEdit1.Properties.NullText = "الرجاء اختيار زبون"
        Me.SearchLookUpEdit1.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit1.Properties.ValueMember = "AccountKey"
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(279, 20)
        Me.SearchLookUpEdit1.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit1.TabIndex = 0
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccountKey, Me.colFullName})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colAccountKey
        '
        Me.colAccountKey.Caption = "رقم "
        Me.colAccountKey.FieldName = "AccountKey"
        Me.colAccountKey.Name = "colAccountKey"
        Me.colAccountKey.Visible = True
        Me.colAccountKey.VisibleIndex = 0
        '
        'colFullName
        '
        Me.colFullName.Caption = "الزبون"
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 1
        '
        'TextEditNotes
        '
        Me.TextEditNotes.Location = New System.Drawing.Point(24, 413)
        Me.TextEditNotes.Name = "TextEditNotes"
        Me.TextEditNotes.Size = New System.Drawing.Size(675, 46)
        Me.TextEditNotes.StyleController = Me.LayoutControl1
        Me.TextEditNotes.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem14, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(723, 576)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CardsTransGridControl
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 224)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(703, 144)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(572, 52)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(131, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(131, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(131, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(224, 52)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(112, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SimpleButtonNew
        Me.LayoutControlItem14.Location = New System.Drawing.Point(448, 52)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(124, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(124, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(124, 26)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem11, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 463)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(703, 93)
        Me.LayoutControlGroup2.Text = "تفاصيل"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.CardTransDate
        Me.LayoutControlItem9.Location = New System.Drawing.Point(505, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem9.Text = "تاريخ الاصدار"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(56, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.AccountNo
        Me.LayoutControlItem10.Location = New System.Drawing.Point(161, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(344, 24)
        Me.LayoutControlItem10.Text = "الزبون"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(26, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.TransNotes
        Me.LayoutControlItem12.Location = New System.Drawing.Point(161, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(518, 24)
        Me.LayoutControlItem12.Text = "ملاحظات الاصدار"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.TransUser
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(161, 24)
        Me.LayoutControlItem11.Text = "المستخدم"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.PersonName
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(161, 24)
        Me.LayoutControlItem13.Text = "المستلم"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem18})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(703, 98)
        Me.LayoutControlGroup3.Text = "بيانات المستلم"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(365, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(314, 24)
        Me.LayoutControlItem1.Text = "الزبون"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(26, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextEditPerson
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(200, 24)
        Me.LayoutControlItem3.Text = "المستلم"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.RadioGroup1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(98, 29)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(679, 29)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "المصادقة"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.TextFleetID
        Me.LayoutControlItem18.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlItem2})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(703, 48)
        Me.LayoutControlGroup4.Text = "السند"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DocID
        Me.LayoutControlItem8.Location = New System.Drawing.Point(572, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "رقم السند"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(48, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(194, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(378, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IssueDate
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem2.Text = "التاريخ"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(28, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 368)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(703, 95)
        Me.LayoutControlGroup5.Text = "ملاحظات"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TextEditNotes
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(679, 50)
        Me.LayoutControlItem5.Text = "ملاحظات"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.TextEdit1
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(703, 52)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.CheckPrintDoc
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SimpleButton2
        Me.LayoutControlItem17.Location = New System.Drawing.Point(336, 52)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
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
        'Accounts1TableAdapter
        '
        Me.Accounts1TableAdapter.ClearBeforeFill = True
        '
        'CardsTransTableAdapter
        '
        Me.CardsTransTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsAddDataTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocsSortTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocsTableAdapter = Nothing
        Me.TableAdapterManager.ArchiveDocTypesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CardsTableAdapter = Nothing
        Me.TableAdapterManager.CardsTransTableAdapter = Me.CardsTransTableAdapter
        Me.TableAdapterManager.CarsAccidentTableAdapter = Nothing
        Me.TableAdapterManager.CarsDriversTableAdapter = Nothing
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
        Me.TableAdapterManager.DATATableAdapter = Nothing
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.FinancialBanksDocTableAdapter = Nothing
        Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemDocsTableAdapter = Nothing
        Me.TableAdapterManager.PrintingSystemJobsTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocSort11TableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocSort1TableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocStatusTableAdapter = Nothing
        Me.TableAdapterManager.StockMoveDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.StockMoveTableAdapter = Nothing
        Me.TableAdapterManager.transDocTableAdapter = Nothing
        Me.TableAdapterManager.transTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Group_rulesTableAdapter
        '
        Me.Group_rulesTableAdapter.ClearBeforeFill = True
        '
        'CRMCardIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 576)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "CRMCardIssue"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اصدار بطاقة"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextFleetID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPrintDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardTransDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsTransGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCardNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryRules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HODATADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HO_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryPlateNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TextEditPerson As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IssueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WizCountDataSet As WizCountDataSet
    Friend WithEvents Accounts1BindingSource As BindingSource
    Friend WithEvents Accounts1TableAdapter As WizCountDataSetTableAdapters.Accounts1TableAdapter
    Friend WithEvents colAccountKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents CardsTransBindingSource As BindingSource
    Friend WithEvents CardsTransTableAdapter As CRMDataSetTableAdapters.CardsTransTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CardsTransGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCardID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCardTransDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransUser1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransNotes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCardSerial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCardStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DocID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TransNotes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TransUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccountNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CardTransDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PersonName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButtonNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEditNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckPrintDoc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colGroupRule As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryRules As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents GrouprulesBindingSource As BindingSource
    '   Friend WithEvents Group_rulesTableAdapter As HO_DATADataSetTableAdapters.group_rulesTableAdapter
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HODATADataSetBindingSource As BindingSource
    Friend WithEvents HO_DATADataSet As HO_DATADataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Group_rulesTableAdapter As HO_DATADataSetTableAdapters.group_rulesTableAdapter
    Friend WithEvents colPlateNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextFleetID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryPlateNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryCardNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
