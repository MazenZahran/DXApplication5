<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancialVISA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialVISA))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOCID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARDNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARDTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVOUCHERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXPDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURRCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMOUNTFC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURRRATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDETAILS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACCOUNTKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNAME_AR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUSERNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextVoucher = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditVisaTo = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditVisaFrom = New DevExpress.XtraEditors.DateEdit()
        Me.TextDocID = New DevExpress.XtraEditors.TextEdit()
        Me.TextAmount = New DevExpress.XtraEditors.TextEdit()
        Me.TextTransText = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColVOUCHERNO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAMOUNTFC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACCOUNTKEY2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEXPDATE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colcountof = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextVoucher.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DateEditVisaTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditVisaTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditVisaFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditVisaFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDocID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextTransText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "CREDITS"
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(655, 356)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colDOCID, Me.colSTATUS, Me.colCARDNUM, Me.colCARDTYPE, Me.colVOUCHERNO, Me.colEXPDATE, Me.colCURRCODE, Me.colAMOUNT, Me.colAMOUNTFC, Me.colCURRRATE, Me.colDETAILS, Me.colUSERID, Me.colACCOUNTKEY, Me.ColNAME_AR, Me.ColUSERNAME})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.Caption = "#"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "عدد {0}")})
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colDOCID
        '
        Me.colDOCID.Caption = "رقم السند"
        Me.colDOCID.FieldName = "DOCID"
        Me.colDOCID.Name = "colDOCID"
        Me.colDOCID.Visible = True
        Me.colDOCID.VisibleIndex = 1
        '
        'colSTATUS
        '
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        '
        'colCARDNUM
        '
        Me.colCARDNUM.FieldName = "CARDNUM"
        Me.colCARDNUM.Name = "colCARDNUM"
        Me.colCARDNUM.Visible = True
        Me.colCARDNUM.VisibleIndex = 2
        '
        'colCARDTYPE
        '
        Me.colCARDTYPE.FieldName = "CARDTYPE"
        Me.colCARDTYPE.Name = "colCARDTYPE"
        '
        'colVOUCHERNO
        '
        Me.colVOUCHERNO.Caption = "رقم الوصل"
        Me.colVOUCHERNO.FieldName = "VOUCHERNO"
        Me.colVOUCHERNO.Name = "colVOUCHERNO"
        Me.colVOUCHERNO.Visible = True
        Me.colVOUCHERNO.VisibleIndex = 3
        '
        'colEXPDATE
        '
        Me.colEXPDATE.Caption = "التاريخ"
        Me.colEXPDATE.FieldName = "EXPDATE"
        Me.colEXPDATE.Name = "colEXPDATE"
        Me.colEXPDATE.Visible = True
        Me.colEXPDATE.VisibleIndex = 4
        '
        'colCURRCODE
        '
        Me.colCURRCODE.Caption = "العملة"
        Me.colCURRCODE.FieldName = "CURRCODE"
        Me.colCURRCODE.Name = "colCURRCODE"
        Me.colCURRCODE.Visible = True
        Me.colCURRCODE.VisibleIndex = 6
        '
        'colAMOUNT
        '
        Me.colAMOUNT.Caption = "المبلغ بالشيكل"
        Me.colAMOUNT.FieldName = "AMOUNT"
        Me.colAMOUNT.Name = "colAMOUNT"
        Me.colAMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMOUNT", "{0:n0}")})
        Me.colAMOUNT.Visible = True
        Me.colAMOUNT.VisibleIndex = 8
        '
        'colAMOUNTFC
        '
        Me.colAMOUNTFC.Caption = "المبلغ"
        Me.colAMOUNTFC.FieldName = "AMOUNTFC"
        Me.colAMOUNTFC.Name = "colAMOUNTFC"
        Me.colAMOUNTFC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMOUNTFC", "{0:n0}")})
        Me.colAMOUNTFC.Visible = True
        Me.colAMOUNTFC.VisibleIndex = 5
        '
        'colCURRRATE
        '
        Me.colCURRRATE.Caption = "سعر الصرف"
        Me.colCURRRATE.FieldName = "CURRRATE"
        Me.colCURRRATE.Name = "colCURRRATE"
        Me.colCURRRATE.Visible = True
        Me.colCURRRATE.VisibleIndex = 7
        '
        'colDETAILS
        '
        Me.colDETAILS.Caption = "التفاصيل"
        Me.colDETAILS.FieldName = "DETAILS"
        Me.colDETAILS.Name = "colDETAILS"
        Me.colDETAILS.Visible = True
        Me.colDETAILS.VisibleIndex = 9
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "المستخدم"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        '
        'colACCOUNTKEY
        '
        Me.colACCOUNTKEY.Caption = "الحساب"
        Me.colACCOUNTKEY.FieldName = "ACCOUNTKEY"
        Me.colACCOUNTKEY.Name = "colACCOUNTKEY"
        Me.colACCOUNTKEY.Visible = True
        Me.colACCOUNTKEY.VisibleIndex = 10
        '
        'ColNAME_AR
        '
        Me.ColNAME_AR.Caption = "المحطة"
        Me.ColNAME_AR.FieldName = "NAME_AR"
        Me.ColNAME_AR.Name = "ColNAME_AR"
        Me.ColNAME_AR.Visible = True
        Me.ColNAME_AR.VisibleIndex = 11
        '
        'ColUSERNAME
        '
        Me.ColUSERNAME.Caption = "المستخدم"
        Me.ColUSERNAME.FieldName = "USERNAME"
        Me.ColUSERNAME.Name = "ColUSERNAME"
        Me.ColUSERNAME.Visible = True
        Me.ColUSERNAME.VisibleIndex = 12
        '
        'TextVoucher
        '
        Me.TextVoucher.Location = New System.Drawing.Point(671, 12)
        Me.TextVoucher.Name = "TextVoucher"
        Me.TextVoucher.Size = New System.Drawing.Size(134, 20)
        Me.TextVoucher.StyleController = Me.LayoutControl1
        Me.TextVoucher.TabIndex = 4
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.DateEditVisaTo)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.DateEditVisaFrom)
        Me.LayoutControl1.Controls.Add(Me.TextDocID)
        Me.LayoutControl1.Controls.Add(Me.TextAmount)
        Me.LayoutControl1.Controls.Add(Me.TextTransText)
        Me.LayoutControl1.Controls.Add(Me.TextVoucher)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(870, 380)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(671, 346)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(187, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "طباعة"
        '
        'DateEditVisaTo
        '
        Me.DateEditVisaTo.EditValue = Nothing
        Me.DateEditVisaTo.Location = New System.Drawing.Point(671, 132)
        Me.DateEditVisaTo.Name = "DateEditVisaTo"
        Me.DateEditVisaTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditVisaTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditVisaTo.Size = New System.Drawing.Size(141, 20)
        Me.DateEditVisaTo.StyleController = Me.LayoutControl1
        Me.DateEditVisaTo.TabIndex = 10
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(671, 320)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(187, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "تحديث"
        '
        'DateEditVisaFrom
        '
        Me.DateEditVisaFrom.EditValue = Nothing
        Me.DateEditVisaFrom.Location = New System.Drawing.Point(671, 108)
        Me.DateEditVisaFrom.Name = "DateEditVisaFrom"
        Me.DateEditVisaFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditVisaFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditVisaFrom.Size = New System.Drawing.Size(144, 20)
        Me.DateEditVisaFrom.StyleController = Me.LayoutControl1
        Me.DateEditVisaFrom.TabIndex = 8
        '
        'TextDocID
        '
        Me.TextDocID.Location = New System.Drawing.Point(671, 84)
        Me.TextDocID.Name = "TextDocID"
        Me.TextDocID.Size = New System.Drawing.Size(97, 20)
        Me.TextDocID.StyleController = Me.LayoutControl1
        Me.TextDocID.TabIndex = 7
        '
        'TextAmount
        '
        Me.TextAmount.Location = New System.Drawing.Point(671, 60)
        Me.TextAmount.Name = "TextAmount"
        Me.TextAmount.Size = New System.Drawing.Size(155, 20)
        Me.TextAmount.StyleController = Me.LayoutControl1
        Me.TextAmount.TabIndex = 6
        '
        'TextTransText
        '
        Me.TextTransText.Location = New System.Drawing.Point(671, 36)
        Me.TextTransText.Name = "TextTransText"
        Me.TextTransText.Size = New System.Drawing.Size(133, 20)
        Me.TextTransText.StyleController = Me.LayoutControl1
        Me.TextTransText.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(870, 380)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(659, 360)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextVoucher
        Me.LayoutControlItem2.Location = New System.Drawing.Point(659, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem2.Text = "رقم الوصل"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(659, 144)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(191, 164)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextTransText
        Me.LayoutControlItem3.Location = New System.Drawing.Point(659, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem3.Text = "رقم الحركة"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TextAmount
        Me.LayoutControlItem4.Location = New System.Drawing.Point(659, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem4.Text = "المبلغ"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(27, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TextDocID
        Me.LayoutControlItem5.Location = New System.Drawing.Point(659, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem5.Text = "رقم كشف الموظف"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(85, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DateEditVisaFrom
        Me.LayoutControlItem6.Location = New System.Drawing.Point(659, 96)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem6.Text = "من تاريخ"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(659, 308)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DateEditVisaTo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(659, 120)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem8.Text = "الى تاريخ"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SimpleButton3
        Me.LayoutControlItem13.Location = New System.Drawing.Point(659, 334)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem13.Text = "طباعة"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'NavigationPane1
        '
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPane1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(930, 441)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage1
        Me.NavigationPane1.Size = New System.Drawing.Size(930, 441)
        Me.NavigationPane1.TabIndex = 2
        Me.NavigationPane1.Text = "NavigationPane1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "استعلام الفيزا"
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.Image = CType(resources.GetObject("NavigationPage1.Image"), System.Drawing.Image)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(870, 380)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "كشف بالحركات المكررة"
        Me.NavigationPage2.Controls.Add(Me.LayoutControl2)
        Me.NavigationPage2.Image = CType(resources.GetObject("NavigationPage2.Image"), System.Drawing.Image)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(870, 380)
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl2.Controls.Add(Me.DateEdit2)
        Me.LayoutControl2.Controls.Add(Me.DateEdit1)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.GridControl2)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(870, 380)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(691, 346)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(167, 22)
        Me.SimpleButton4.StyleController = Me.LayoutControl2
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "طباعة"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(691, 36)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(167, 20)
        Me.DateEdit2.StyleController = Me.LayoutControl2
        Me.DateEdit2.TabIndex = 6
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(691, 12)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(167, 20)
        Me.DateEdit1.StyleController = Me.LayoutControl2
        Me.DateEdit1.TabIndex = 5
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(691, 320)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(167, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "تحديث"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(12, 12)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(675, 356)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColVOUCHERNO2, Me.ColAMOUNTFC2, Me.ColACCOUNTKEY2, Me.ColEXPDATE2, Me.Colcountof, Me.GridColumn1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'ColVOUCHERNO2
        '
        Me.ColVOUCHERNO2.Caption = "رقم الوصل"
        Me.ColVOUCHERNO2.FieldName = "VOUCHERNO"
        Me.ColVOUCHERNO2.Name = "ColVOUCHERNO2"
        Me.ColVOUCHERNO2.Visible = True
        Me.ColVOUCHERNO2.VisibleIndex = 0
        '
        'ColAMOUNTFC2
        '
        Me.ColAMOUNTFC2.Caption = "المبلغ"
        Me.ColAMOUNTFC2.FieldName = "AMOUNTFC"
        Me.ColAMOUNTFC2.Name = "ColAMOUNTFC2"
        Me.ColAMOUNTFC2.Visible = True
        Me.ColAMOUNTFC2.VisibleIndex = 1
        '
        'ColACCOUNTKEY2
        '
        Me.ColACCOUNTKEY2.Caption = "رقم الحساب"
        Me.ColACCOUNTKEY2.FieldName = "ACCOUNTKEY"
        Me.ColACCOUNTKEY2.Name = "ColACCOUNTKEY2"
        Me.ColACCOUNTKEY2.Visible = True
        Me.ColACCOUNTKEY2.VisibleIndex = 2
        '
        'ColEXPDATE2
        '
        Me.ColEXPDATE2.Caption = "تاريخ الفيزا"
        Me.ColEXPDATE2.FieldName = "EXPDATE"
        Me.ColEXPDATE2.Name = "ColEXPDATE2"
        Me.ColEXPDATE2.Visible = True
        Me.ColEXPDATE2.VisibleIndex = 3
        '
        'Colcountof
        '
        Me.Colcountof.Caption = "عدد"
        Me.Colcountof.FieldName = "countof"
        Me.Colcountof.Name = "Colcountof"
        Me.Colcountof.Visible = True
        Me.Colcountof.VisibleIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.EmptySpaceItem2, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem10, Me.LayoutControlItem14})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(870, 380)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.GridControl2
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(679, 360)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(679, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(171, 260)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.DateEdit1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(679, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.DateEdit2
        Me.LayoutControlItem12.Location = New System.Drawing.Point(679, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton2
        Me.LayoutControlItem10.Location = New System.Drawing.Point(679, 308)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(171, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SimpleButton4
        Me.LayoutControlItem14.Location = New System.Drawing.Point(679, 334)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(171, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "رقم الحركة"
        Me.GridColumn1.FieldName = "DETAILS"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'FinancialVISA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 441)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Name = "FinancialVISA"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "استعلام الفيزا"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextVoucher.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DateEditVisaTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditVisaTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditVisaFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditVisaFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDocID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextTransText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOCID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARDNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARDTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVOUCHERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURRCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMOUNTFC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURRRATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDETAILS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACCOUNTKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextVoucher As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DateEditVisaTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEditVisaFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextDocID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextTransText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColNAME_AR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUSERNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVOUCHERNO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAMOUNTFC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColACCOUNTKEY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEXPDATE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colcountof As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
