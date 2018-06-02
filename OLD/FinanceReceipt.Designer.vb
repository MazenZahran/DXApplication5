<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinanceReceipt
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
        Dim RecNOLabel As System.Windows.Forms.Label
        Dim RecDateLabel As System.Windows.Forms.Label
        Dim RecCustNoLabel As System.Windows.Forms.Label
        Dim RecCashLabel As System.Windows.Forms.Label
        Dim RecChequeLabel As System.Windows.Forms.Label
        Dim RecOtherLabel As System.Windows.Forms.Label
        Dim RecRateLabel As System.Windows.Forms.Label
        Dim RecTotalLabel As System.Windows.Forms.Label
        Dim RecDeviceNameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceReceipt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RecDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ReceiptDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.RecNOSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.RecCustNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecCustNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.AmountInNisText = New DevExpress.XtraEditors.TextEdit()
        Me.RecCurrTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.RecRateSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.RecCashSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecChequeSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecTotalSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecOtherSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecDeviceNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.RecInputDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RecUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecAuditSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecStatusSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ReceiptDataTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ReceiptDataTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.ChequeDataTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ChequeDataTableAdapter()
        Me.RecNoteTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CountChequesLabel = New DevExpress.XtraEditors.LabelControl()
        Me.SumChequesLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ChequeDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        RecNOLabel = New System.Windows.Forms.Label()
        RecDateLabel = New System.Windows.Forms.Label()
        RecCustNoLabel = New System.Windows.Forms.Label()
        RecCashLabel = New System.Windows.Forms.Label()
        RecChequeLabel = New System.Windows.Forms.Label()
        RecOtherLabel = New System.Windows.Forms.Label()
        RecRateLabel = New System.Windows.Forms.Label()
        RecTotalLabel = New System.Windows.Forms.Label()
        RecDeviceNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.RecDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecNOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.RecCustNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecCustNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.AmountInNisText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecCurrTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecRateSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.RecCashSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecTotalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecOtherSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecDeviceNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.RecInputDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecInputDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecAuditSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecStatusSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecNoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ChequeDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecNOLabel
        '
        RecNOLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecNOLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecNOLabel.Location = New System.Drawing.Point(814, 16)
        RecNOLabel.Name = "RecNOLabel"
        RecNOLabel.Size = New System.Drawing.Size(74, 22)
        RecNOLabel.TabIndex = 0
        RecNOLabel.Text = "رقم السند:"
        '
        'RecDateLabel
        '
        RecDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecDateLabel.AutoSize = True
        RecDateLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecDateLabel.Location = New System.Drawing.Point(341, 15)
        RecDateLabel.Name = "RecDateLabel"
        RecDateLabel.Size = New System.Drawing.Size(79, 19)
        RecDateLabel.TabIndex = 2
        RecDateLabel.Text = "تاريخ السند:"
        '
        'RecCustNoLabel
        '
        RecCustNoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecCustNoLabel.AutoSize = True
        RecCustNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecCustNoLabel.Location = New System.Drawing.Point(823, 14)
        RecCustNoLabel.Name = "RecCustNoLabel"
        RecCustNoLabel.Size = New System.Drawing.Size(57, 19)
        RecCustNoLabel.TabIndex = 4
        RecCustNoLabel.Text = "الحساب:"
        '
        'RecCashLabel
        '
        RecCashLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecCashLabel.AutoSize = True
        RecCashLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecCashLabel.Location = New System.Drawing.Point(852, 20)
        RecCashLabel.Name = "RecCashLabel"
        RecCashLabel.Size = New System.Drawing.Size(36, 19)
        RecCashLabel.TabIndex = 8
        RecCashLabel.Text = "نقدا:"
        '
        'RecChequeLabel
        '
        RecChequeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecChequeLabel.AutoSize = True
        RecChequeLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecChequeLabel.Location = New System.Drawing.Point(634, 20)
        RecChequeLabel.Name = "RecChequeLabel"
        RecChequeLabel.Size = New System.Drawing.Size(51, 19)
        RecChequeLabel.TabIndex = 10
        RecChequeLabel.Text = "شيكات:"
        '
        'RecOtherLabel
        '
        RecOtherLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecOtherLabel.AutoSize = True
        RecOtherLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecOtherLabel.Location = New System.Drawing.Point(421, 20)
        RecOtherLabel.Name = "RecOtherLabel"
        RecOtherLabel.Size = New System.Drawing.Size(46, 19)
        RecOtherLabel.TabIndex = 12
        RecOtherLabel.Text = "أخرى:"
        '
        'RecRateLabel
        '
        RecRateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecRateLabel.AutoSize = True
        RecRateLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecRateLabel.Location = New System.Drawing.Point(509, 16)
        RecRateLabel.Name = "RecRateLabel"
        RecRateLabel.Size = New System.Drawing.Size(83, 19)
        RecRateLabel.TabIndex = 24
        RecRateLabel.Text = "سعر الصرف:"
        '
        'RecTotalLabel
        '
        RecTotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecTotalLabel.AutoSize = True
        RecTotalLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecTotalLabel.Location = New System.Drawing.Point(182, 16)
        RecTotalLabel.Name = "RecTotalLabel"
        RecTotalLabel.Size = New System.Drawing.Size(63, 19)
        RecTotalLabel.TabIndex = 26
        RecTotalLabel.Text = "المجموع:"
        '
        'RecDeviceNameLabel
        '
        RecDeviceNameLabel.AutoSize = True
        RecDeviceNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecDeviceNameLabel.Location = New System.Drawing.Point(499, 437)
        RecDeviceNameLabel.Name = "RecDeviceNameLabel"
        RecDeviceNameLabel.Size = New System.Drawing.Size(143, 19)
        RecDeviceNameLabel.TabIndex = 30
        RecDeviceNameLabel.Text = "Rec Device Name:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(27, 55)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(861, 30)
        Label1.TabIndex = 14
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(829, 22)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 19)
        Label2.TabIndex = 24
        Label2.Text = "العملة:"
        '
        'Label3
        '
        Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(198, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 19)
        Label3.TabIndex = 24
        Label3.Text = "المبلغ مقيم:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl1.Controls.Add(Me.SimpleButton6)
        Me.PanelControl1.Controls.Add(Me.SimpleButton5)
        Me.PanelControl1.Controls.Add(Me.SimpleButton4)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(900, 43)
        Me.PanelControl1.TabIndex = 100
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(622, 5)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(43, 30)
        Me.SimpleButton6.TabIndex = 0
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(533, 5)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(43, 30)
        Me.SimpleButton5.TabIndex = 0
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(489, 5)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(43, 30)
        Me.SimpleButton4.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(578, 5)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(43, 30)
        Me.SimpleButton3.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(671, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(109, 30)
        Me.SimpleButton2.TabIndex = 0
        Me.SimpleButton2.Text = "جديد"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(786, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 30)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "حفظ"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl2.Controls.Add(RecDateLabel)
        Me.PanelControl2.Controls.Add(RecNOLabel)
        Me.PanelControl2.Controls.Add(Me.RecDateDateEdit)
        Me.PanelControl2.Controls.Add(Me.RecNOSpinEdit)
        Me.PanelControl2.Location = New System.Drawing.Point(0, 43)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(900, 47)
        Me.PanelControl2.TabIndex = 99
        '
        'RecDateDateEdit
        '
        Me.RecDateDateEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecDate", True))
        Me.RecDateDateEdit.EditValue = Nothing
        Me.RecDateDateEdit.Location = New System.Drawing.Point(28, 8)
        Me.RecDateDateEdit.Name = "RecDateDateEdit"
        Me.RecDateDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecDateDateEdit.Properties.Appearance.Options.UseFont = True
        Me.RecDateDateEdit.Properties.AutoHeight = False
        Me.RecDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecDateDateEdit.Size = New System.Drawing.Size(307, 30)
        Me.RecDateDateEdit.TabIndex = 3
        '
        'ReceiptDataBindingSource
        '
        Me.ReceiptDataBindingSource.DataMember = "ReceiptData"
        Me.ReceiptDataBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecNOSpinEdit
        '
        Me.RecNOSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecNOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecNO", True))
        Me.RecNOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecNOSpinEdit.Location = New System.Drawing.Point(618, 10)
        Me.RecNOSpinEdit.Name = "RecNOSpinEdit"
        Me.RecNOSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecNOSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecNOSpinEdit.Properties.AutoHeight = False
        Me.RecNOSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecNOSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecNOSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecNOSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecNOSpinEdit.Properties.ReadOnly = True
        Me.RecNOSpinEdit.Size = New System.Drawing.Size(192, 30)
        Me.RecNOSpinEdit.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl3.Controls.Add(Me.RecCustNoTextEdit)
        Me.PanelControl3.Controls.Add(Me.RecCustNameTextEdit)
        Me.PanelControl3.Controls.Add(RecCustNoLabel)
        Me.PanelControl3.Location = New System.Drawing.Point(0, 90)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(900, 45)
        Me.PanelControl3.TabIndex = 0
        '
        'RecCustNoTextEdit
        '
        Me.RecCustNoTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCustNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCustNo", True))
        Me.RecCustNoTextEdit.Location = New System.Drawing.Point(624, 9)
        Me.RecCustNoTextEdit.Name = "RecCustNoTextEdit"
        Me.RecCustNoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCustNoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCustNoTextEdit.Properties.AutoHeight = False
        Me.RecCustNoTextEdit.Size = New System.Drawing.Size(186, 30)
        Me.RecCustNoTextEdit.TabIndex = 5
        '
        'RecCustNameTextEdit
        '
        Me.RecCustNameTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCustNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCustName", True))
        Me.RecCustNameTextEdit.Location = New System.Drawing.Point(28, 9)
        Me.RecCustNameTextEdit.Name = "RecCustNameTextEdit"
        Me.RecCustNameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCustNameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCustNameTextEdit.Properties.AutoHeight = False
        Me.RecCustNameTextEdit.Size = New System.Drawing.Size(590, 30)
        Me.RecCustNameTextEdit.TabIndex = 7
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl4.Controls.Add(Me.AmountInNisText)
        Me.PanelControl4.Controls.Add(Label2)
        Me.PanelControl4.Controls.Add(Label3)
        Me.PanelControl4.Controls.Add(RecRateLabel)
        Me.PanelControl4.Controls.Add(Me.RecCurrTextEdit)
        Me.PanelControl4.Controls.Add(Me.RecRateSpinEdit)
        Me.PanelControl4.Location = New System.Drawing.Point(0, 135)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(900, 52)
        Me.PanelControl4.TabIndex = 1
        '
        'AmountInNisText
        '
        Me.AmountInNisText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmountInNisText.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmountInNisText.Location = New System.Drawing.Point(28, 11)
        Me.AmountInNisText.Name = "AmountInNisText"
        Me.AmountInNisText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountInNisText.Properties.Appearance.Options.UseFont = True
        Me.AmountInNisText.Properties.AutoHeight = False
        Me.AmountInNisText.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.AmountInNisText.Properties.Mask.BeepOnError = True
        Me.AmountInNisText.Properties.Mask.EditMask = "d"
        Me.AmountInNisText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.AmountInNisText.Size = New System.Drawing.Size(162, 30)
        Me.AmountInNisText.TabIndex = 26
        '
        'RecCurrTextEdit
        '
        Me.RecCurrTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCurrTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCurr", True))
        Me.RecCurrTextEdit.EditValue = "شيكل"
        Me.RecCurrTextEdit.Location = New System.Drawing.Point(622, 11)
        Me.RecCurrTextEdit.Name = "RecCurrTextEdit"
        Me.RecCurrTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCurrTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCurrTextEdit.Properties.AutoHeight = False
        Me.RecCurrTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecCurrTextEdit.Properties.Items.AddRange(New Object() {"شيكل", "دولار", "دينار", "يورو"})
        Me.RecCurrTextEdit.Size = New System.Drawing.Size(186, 30)
        Me.RecCurrTextEdit.TabIndex = 23
        '
        'RecRateSpinEdit
        '
        Me.RecRateSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecRateSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecRate", True))
        Me.RecRateSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecRateSpinEdit.Location = New System.Drawing.Point(341, 11)
        Me.RecRateSpinEdit.Name = "RecRateSpinEdit"
        Me.RecRateSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecRateSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecRateSpinEdit.Properties.AutoHeight = False
        Me.RecRateSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecRateSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecRateSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecRateSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecRateSpinEdit.Size = New System.Drawing.Size(162, 30)
        Me.RecRateSpinEdit.TabIndex = 25
        '
        'PanelControl9
        '
        Me.PanelControl9.AllowTouchScroll = True
        Me.PanelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl9.Controls.Add(Label1)
        Me.PanelControl9.Controls.Add(RecDeviceNameLabel)
        Me.PanelControl9.Controls.Add(RecOtherLabel)
        Me.PanelControl9.Controls.Add(RecTotalLabel)
        Me.PanelControl9.Controls.Add(Me.RecCashSpinEdit)
        Me.PanelControl9.Controls.Add(RecChequeLabel)
        Me.PanelControl9.Controls.Add(Me.RecChequeSpinEdit)
        Me.PanelControl9.Controls.Add(Me.RecTotalSpinEdit)
        Me.PanelControl9.Controls.Add(Me.RecOtherSpinEdit)
        Me.PanelControl9.Controls.Add(RecCashLabel)
        Me.PanelControl9.FireScrollEventOnMouseWheel = True
        Me.PanelControl9.Location = New System.Drawing.Point(0, 187)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(900, 103)
        Me.PanelControl9.TabIndex = 2
        '
        'RecCashSpinEdit
        '
        Me.RecCashSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCashSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCash", True))
        Me.RecCashSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecCashSpinEdit.Location = New System.Drawing.Point(696, 13)
        Me.RecCashSpinEdit.Name = "RecCashSpinEdit"
        Me.RecCashSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCashSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCashSpinEdit.Properties.AutoHeight = False
        Me.RecCashSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecCashSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecCashSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecCashSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecCashSpinEdit.Size = New System.Drawing.Size(150, 30)
        Me.RecCashSpinEdit.TabIndex = 9
        '
        'RecChequeSpinEdit
        '
        Me.RecChequeSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecChequeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCheque", True))
        Me.RecChequeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecChequeSpinEdit.Location = New System.Drawing.Point(483, 13)
        Me.RecChequeSpinEdit.Name = "RecChequeSpinEdit"
        Me.RecChequeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecChequeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecChequeSpinEdit.Properties.AutoHeight = False
        Me.RecChequeSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecChequeSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecChequeSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecChequeSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecChequeSpinEdit.Size = New System.Drawing.Size(150, 30)
        Me.RecChequeSpinEdit.TabIndex = 11
        '
        'RecTotalSpinEdit
        '
        Me.RecTotalSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecTotalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecTotal", True))
        Me.RecTotalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecTotalSpinEdit.Location = New System.Drawing.Point(26, 11)
        Me.RecTotalSpinEdit.Name = "RecTotalSpinEdit"
        Me.RecTotalSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecTotalSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecTotalSpinEdit.Properties.AutoHeight = False
        Me.RecTotalSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecTotalSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecTotalSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecTotalSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecTotalSpinEdit.Size = New System.Drawing.Size(150, 30)
        Me.RecTotalSpinEdit.TabIndex = 27
        '
        'RecOtherSpinEdit
        '
        Me.RecOtherSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecOtherSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecOther", True))
        Me.RecOtherSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecOtherSpinEdit.Location = New System.Drawing.Point(265, 13)
        Me.RecOtherSpinEdit.Name = "RecOtherSpinEdit"
        Me.RecOtherSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecOtherSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecOtherSpinEdit.Properties.AutoHeight = False
        Me.RecOtherSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecOtherSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecOtherSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecOtherSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecOtherSpinEdit.Size = New System.Drawing.Size(150, 30)
        Me.RecOtherSpinEdit.TabIndex = 13
        '
        'RecDeviceNameTextEdit
        '
        Me.RecDeviceNameTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecDeviceNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecDeviceName", True))
        Me.RecDeviceNameTextEdit.Enabled = False
        Me.RecDeviceNameTextEdit.Location = New System.Drawing.Point(178, 5)
        Me.RecDeviceNameTextEdit.Name = "RecDeviceNameTextEdit"
        Me.RecDeviceNameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecDeviceNameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecDeviceNameTextEdit.Properties.ReadOnly = True
        Me.RecDeviceNameTextEdit.Size = New System.Drawing.Size(213, 26)
        Me.RecDeviceNameTextEdit.TabIndex = 31
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.RecInputDateDateEdit)
        Me.PanelControl6.Controls.Add(Me.RecUserTextEdit)
        Me.PanelControl6.Controls.Add(Me.RecAuditSpinEdit)
        Me.PanelControl6.Controls.Add(Me.RecDeviceNameTextEdit)
        Me.PanelControl6.Controls.Add(Me.RecStatusSpinEdit)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl6.Location = New System.Drawing.Point(0, 734)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(933, 37)
        Me.PanelControl6.TabIndex = 5
        '
        'RecInputDateDateEdit
        '
        Me.RecInputDateDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecInputDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecInputDate", True))
        Me.RecInputDateDateEdit.EditValue = Nothing
        Me.RecInputDateDateEdit.Enabled = False
        Me.RecInputDateDateEdit.Location = New System.Drawing.Point(609, 5)
        Me.RecInputDateDateEdit.Name = "RecInputDateDateEdit"
        Me.RecInputDateDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecInputDateDateEdit.Properties.Appearance.Options.UseFont = True
        Me.RecInputDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecInputDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecInputDateDateEdit.Properties.ReadOnly = True
        Me.RecInputDateDateEdit.Size = New System.Drawing.Size(188, 26)
        Me.RecInputDateDateEdit.TabIndex = 19
        '
        'RecUserTextEdit
        '
        Me.RecUserTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecUserTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecUser", True))
        Me.RecUserTextEdit.Enabled = False
        Me.RecUserTextEdit.Location = New System.Drawing.Point(800, 5)
        Me.RecUserTextEdit.Name = "RecUserTextEdit"
        Me.RecUserTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecUserTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecUserTextEdit.Properties.ReadOnly = True
        Me.RecUserTextEdit.Size = New System.Drawing.Size(100, 26)
        Me.RecUserTextEdit.TabIndex = 17
        '
        'RecAuditSpinEdit
        '
        Me.RecAuditSpinEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecAuditSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecAudit", True))
        Me.RecAuditSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecAuditSpinEdit.Enabled = False
        Me.RecAuditSpinEdit.Location = New System.Drawing.Point(397, 5)
        Me.RecAuditSpinEdit.Name = "RecAuditSpinEdit"
        Me.RecAuditSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecAuditSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecAuditSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecAuditSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecAuditSpinEdit.Properties.ReadOnly = True
        Me.RecAuditSpinEdit.Size = New System.Drawing.Size(100, 26)
        Me.RecAuditSpinEdit.TabIndex = 29
        '
        'RecStatusSpinEdit
        '
        Me.RecStatusSpinEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecStatusSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecStatus", True))
        Me.RecStatusSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecStatusSpinEdit.Enabled = False
        Me.RecStatusSpinEdit.Location = New System.Drawing.Point(503, 5)
        Me.RecStatusSpinEdit.Name = "RecStatusSpinEdit"
        Me.RecStatusSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecStatusSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecStatusSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecStatusSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecStatusSpinEdit.Properties.ReadOnly = True
        Me.RecStatusSpinEdit.Size = New System.Drawing.Size(100, 26)
        Me.RecStatusSpinEdit.TabIndex = 21
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'ReceiptDataTableAdapter
        '
        Me.ReceiptDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChequeDataTableAdapter = Me.ChequeDataTableAdapter
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Me.ReceiptDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ChequeDataTableAdapter
        '
        Me.ChequeDataTableAdapter.ClearBeforeFill = True
        '
        'RecNoteTextEdit
        '
        Me.RecNoteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecNote", True))
        Me.RecNoteTextEdit.Location = New System.Drawing.Point(28, 5)
        Me.RecNoteTextEdit.Name = "RecNoteTextEdit"
        Me.RecNoteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecNoteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecNoteTextEdit.Size = New System.Drawing.Size(867, 67)
        Me.RecNoteTextEdit.TabIndex = 15
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.CountChequesLabel)
        Me.GroupControl1.Controls.Add(Me.SumChequesLabel)
        Me.GroupControl1.Controls.Add(Me.ChequeDataDataGridView)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 370)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(900, 359)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "تفاصيل الشيكات"
        '
        'CountChequesLabel
        '
        Me.CountChequesLabel.Location = New System.Drawing.Point(820, 338)
        Me.CountChequesLabel.Name = "CountChequesLabel"
        Me.CountChequesLabel.Size = New System.Drawing.Size(61, 13)
        Me.CountChequesLabel.TabIndex = 1
        Me.CountChequesLabel.Text = "عدد الشيكات"
        '
        'SumChequesLabel
        '
        Me.SumChequesLabel.Location = New System.Drawing.Point(28, 338)
        Me.SumChequesLabel.Name = "SumChequesLabel"
        Me.SumChequesLabel.Size = New System.Drawing.Size(75, 13)
        Me.SumChequesLabel.TabIndex = 1
        Me.SumChequesLabel.Text = "مجموع الشيكات"
        '
        'ChequeDataDataGridView
        '
        Me.ChequeDataDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ChequeDataDataGridView.AutoGenerateColumns = False
        Me.ChequeDataDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ChequeDataDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChequeDataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ChequeDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChequeDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ChequeDataDataGridView.DataSource = Me.ChequeDataBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ChequeDataDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ChequeDataDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChequeDataDataGridView.Location = New System.Drawing.Point(26, 20)
        Me.ChequeDataDataGridView.Name = "ChequeDataDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChequeDataDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ChequeDataDataGridView.Size = New System.Drawing.Size(869, 312)
        Me.ChequeDataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ChequeNO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم الشيك"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ChequeBank"
        Me.DataGridViewTextBoxColumn2.HeaderText = "البنك"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ChequeBranch"
        Me.DataGridViewTextBoxColumn3.HeaderText = "الفرع"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ChequeAccount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "الحساب البنكي"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ChequeAccDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "تاريخ الاستحقاق"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ChequeAmount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "قيمة الشيك"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ChequeReceiptNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "رقم سند القبض"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'ChequeDataBindingSource
        '
        Me.ChequeDataBindingSource.DataMember = "ChequeData"
        Me.ChequeDataBindingSource.DataSource = Me.CRMDataSet
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl5.Controls.Add(Me.RecNoteTextEdit)
        Me.PanelControl5.Location = New System.Drawing.Point(0, 287)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(900, 77)
        Me.PanelControl5.TabIndex = 3
        '
        'FinanceReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 771)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl6)
        Me.Controls.Add(Me.PanelControl9)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FinanceReceipt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "سند قبض"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.RecDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecNOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.RecCustNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecCustNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.AmountInNisText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecCurrTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecRateSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        CType(Me.RecCashSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecChequeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecTotalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecOtherSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecDeviceNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.RecInputDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecInputDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecAuditSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecStatusSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecNoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ChequeDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents ReceiptDataBindingSource As BindingSource
    Friend WithEvents ReceiptDataTableAdapter As CRMDataSetTableAdapters.ReceiptDataTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RecNOSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecCustNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecCustNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecUserTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecInputDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RecDeviceNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecCashSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecChequeSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecOtherSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecTotalSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AmountInNisText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecCurrTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RecRateSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecAuditSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecStatusSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChequeDataTableAdapter As CRMDataSetTableAdapters.ChequeDataTableAdapter
    Friend WithEvents ChequeDataBindingSource As BindingSource
    Friend WithEvents ChequeDataDataGridView As DataGridView
    Friend WithEvents RecNoteTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SumChequesLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CountChequesLabel As DevExpress.XtraEditors.LabelControl
End Class
