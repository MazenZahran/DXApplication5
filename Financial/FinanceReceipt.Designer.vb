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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim RecRateLabel As System.Windows.Forms.Label
        Dim RecDateLabel As System.Windows.Forms.Label
        Dim RecNOLabel As System.Windows.Forms.Label
        Dim RecCustNoLabel As System.Windows.Forms.Label
        Dim RecOtherLabel As System.Windows.Forms.Label
        Dim RecTotalLabel As System.Windows.Forms.Label
        Dim RecChequeLabel As System.Windows.Forms.Label
        Dim RecCashLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceReceipt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Sorting2 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
        Me.RecTotalSpinEdit = New System.Windows.Forms.TextBox()
        Me.ReceiptDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.RecOtherSpinEdit = New System.Windows.Forms.TextBox()
        Me.RecChequeSpinEdit = New System.Windows.Forms.TextBox()
        Me.RecCashSpinEdit = New System.Windows.Forms.TextBox()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.RecRateSpinEdit = New System.Windows.Forms.TextBox()
        Me.smallcurrencylabel = New DevExpress.XtraEditors.LabelControl()
        Me.AmountInNisText = New DevExpress.XtraEditors.TextEdit()
        Me.RecCurrTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.RecNoteTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColAccrualDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColToUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTaskType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTaskMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTaskID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.SumChequesLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CountChequesLabel = New DevExpress.XtraEditors.LabelControl()
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
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.RecOwnerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecInputDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RecUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecAuditSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecDeviceNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecStatusSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RecDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RecNOSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.RecCustNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RecCustNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditTo = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditFrom = New DevExpress.XtraEditors.DateEdit()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCheqNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuFDlr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrencyDlr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankAccNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton16 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.NavigationPage5 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource2 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCustNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCustName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecOther = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecInputDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecCurr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecAudit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecDeviceName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecOwner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.ChequeDataTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ChequeDataTableAdapter()
        Me.ReceiptDataTableAdapter = New DXApplication5.CRMDataSetTableAdapters.ReceiptDataTableAdapter()
        Me.TableAdapterManager = New DXApplication5.CRMDataSetTableAdapters.TableAdapterManager()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        RecRateLabel = New System.Windows.Forms.Label()
        RecDateLabel = New System.Windows.Forms.Label()
        RecNOLabel = New System.Windows.Forms.Label()
        RecCustNoLabel = New System.Windows.Forms.Label()
        RecOtherLabel = New System.Windows.Forms.Label()
        RecTotalLabel = New System.Windows.Forms.Label()
        RecChequeLabel = New System.Windows.Forms.Label()
        RecCashLabel = New System.Windows.Forms.Label()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.ReceiptDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountInNisText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecCurrTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.RecNoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.RecOwnerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecInputDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecInputDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecAuditSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecDeviceNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecStatusSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.RecDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecNOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.RecCustNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecCustNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage3.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage4.SuspendLayout()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage5.SuspendLayout()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl13.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(963, 22)
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
        Label3.Location = New System.Drawing.Point(177, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 19)
        Label3.TabIndex = 24
        Label3.Text = "المبلغ مقيم:"
        '
        'RecRateLabel
        '
        RecRateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecRateLabel.AutoSize = True
        RecRateLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecRateLabel.Location = New System.Drawing.Point(538, 16)
        RecRateLabel.Name = "RecRateLabel"
        RecRateLabel.Size = New System.Drawing.Size(83, 19)
        RecRateLabel.TabIndex = 24
        RecRateLabel.Text = "سعر الصرف:"
        '
        'RecDateLabel
        '
        RecDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecDateLabel.AutoSize = True
        RecDateLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecDateLabel.Location = New System.Drawing.Point(309, 15)
        RecDateLabel.Name = "RecDateLabel"
        RecDateLabel.Size = New System.Drawing.Size(79, 19)
        RecDateLabel.TabIndex = 2
        RecDateLabel.Text = "تاريخ السند:"
        '
        'RecNOLabel
        '
        RecNOLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecNOLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecNOLabel.Location = New System.Drawing.Point(946, 16)
        RecNOLabel.Name = "RecNOLabel"
        RecNOLabel.Size = New System.Drawing.Size(74, 22)
        RecNOLabel.TabIndex = 0
        RecNOLabel.Text = "رقم السند:"
        '
        'RecCustNoLabel
        '
        RecCustNoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RecCustNoLabel.AutoSize = True
        RecCustNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecCustNoLabel.Location = New System.Drawing.Point(955, 14)
        RecCustNoLabel.Name = "RecCustNoLabel"
        RecCustNoLabel.Size = New System.Drawing.Size(57, 19)
        RecCustNoLabel.TabIndex = 4
        RecCustNoLabel.Text = "الحساب:"
        '
        'RecOtherLabel
        '
        RecOtherLabel.AutoSize = True
        RecOtherLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecOtherLabel.Location = New System.Drawing.Point(434, 54)
        RecOtherLabel.Name = "RecOtherLabel"
        RecOtherLabel.Size = New System.Drawing.Size(46, 19)
        RecOtherLabel.TabIndex = 106
        RecOtherLabel.Text = "أخرى:"
        '
        'RecTotalLabel
        '
        RecTotalLabel.AutoSize = True
        RecTotalLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecTotalLabel.Location = New System.Drawing.Point(163, 54)
        RecTotalLabel.Name = "RecTotalLabel"
        RecTotalLabel.Size = New System.Drawing.Size(63, 19)
        RecTotalLabel.TabIndex = 107
        RecTotalLabel.Text = "المجموع:"
        '
        'RecChequeLabel
        '
        RecChequeLabel.AutoSize = True
        RecChequeLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecChequeLabel.Location = New System.Drawing.Point(690, 54)
        RecChequeLabel.Name = "RecChequeLabel"
        RecChequeLabel.Size = New System.Drawing.Size(51, 19)
        RecChequeLabel.TabIndex = 105
        RecChequeLabel.Text = "شيكات:"
        '
        'RecCashLabel
        '
        RecCashLabel.AutoSize = True
        RecCashLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecCashLabel.Location = New System.Drawing.Point(972, 54)
        RecCashLabel.Name = "RecCashLabel"
        RecCashLabel.Size = New System.Drawing.Size(36, 19)
        RecCashLabel.TabIndex = 104
        RecCashLabel.Text = "نقدا:"
        '
        'NavigationPane1
        '
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage3)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage4)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage5)
        Me.NavigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPane1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3, Me.NavigationPage4, Me.NavigationPage5})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(1184, 711)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage1
        Me.NavigationPane1.Size = New System.Drawing.Size(1184, 711)
        Me.NavigationPane1.TabIndex = 0
        Me.NavigationPane1.Text = "الرئيسية"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "الرئيسية"
        Me.NavigationPage1.Controls.Add(Me.DashboardViewer1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1043, 651)
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.DashboardSource = GetType(DXApplication5.Win_Dashboards.Dashboard1)
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(1043, 651)
        Me.DashboardViewer1.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "سند قبض"
        Me.NavigationPage2.Controls.Add(Me.PanelControl4)
        Me.NavigationPage2.Controls.Add(Me.PanelControl5)
        Me.NavigationPage2.Controls.Add(Me.GroupControl1)
        Me.NavigationPage2.Controls.Add(Me.PanelControl6)
        Me.NavigationPage2.Controls.Add(Me.PanelControl1)
        Me.NavigationPage2.Controls.Add(Me.PanelControl2)
        Me.NavigationPage2.Controls.Add(Me.PanelControl3)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1043, 651)
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.SimpleButton15)
        Me.PanelControl4.Controls.Add(Me.RecTotalSpinEdit)
        Me.PanelControl4.Controls.Add(Me.RecOtherSpinEdit)
        Me.PanelControl4.Controls.Add(Me.RecChequeSpinEdit)
        Me.PanelControl4.Controls.Add(Me.RecCashSpinEdit)
        Me.PanelControl4.Controls.Add(Me.TextEdit1)
        Me.PanelControl4.Controls.Add(RecOtherLabel)
        Me.PanelControl4.Controls.Add(RecTotalLabel)
        Me.PanelControl4.Controls.Add(RecChequeLabel)
        Me.PanelControl4.Controls.Add(RecCashLabel)
        Me.PanelControl4.Controls.Add(Me.RecRateSpinEdit)
        Me.PanelControl4.Controls.Add(Me.smallcurrencylabel)
        Me.PanelControl4.Controls.Add(Me.AmountInNisText)
        Me.PanelControl4.Controls.Add(Label2)
        Me.PanelControl4.Controls.Add(Label3)
        Me.PanelControl4.Controls.Add(RecRateLabel)
        Me.PanelControl4.Controls.Add(Me.RecCurrTextEdit)
        Me.PanelControl4.Location = New System.Drawing.Point(8, 156)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1034, 117)
        Me.PanelControl4.TabIndex = 102
        '
        'SimpleButton15
        '
        Me.SimpleButton15.ImageOptions.Image = CType(resources.GetObject("SimpleButton15.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton15.Location = New System.Drawing.Point(350, 13)
        Me.SimpleButton15.Name = "SimpleButton15"
        Me.SimpleButton15.Size = New System.Drawing.Size(24, 27)
        Me.SimpleButton15.TabIndex = 113
        '
        'RecTotalSpinEdit
        '
        Me.RecTotalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptDataBindingSource, "RecTotal", True))
        Me.RecTotalSpinEdit.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.RecTotalSpinEdit.Location = New System.Drawing.Point(7, 51)
        Me.RecTotalSpinEdit.Name = "RecTotalSpinEdit"
        Me.RecTotalSpinEdit.ReadOnly = True
        Me.RecTotalSpinEdit.Size = New System.Drawing.Size(150, 27)
        Me.RecTotalSpinEdit.TabIndex = 112
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
        'RecOtherSpinEdit
        '
        Me.RecOtherSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptDataBindingSource, "RecOther", True))
        Me.RecOtherSpinEdit.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.RecOtherSpinEdit.Location = New System.Drawing.Point(288, 51)
        Me.RecOtherSpinEdit.Name = "RecOtherSpinEdit"
        Me.RecOtherSpinEdit.Size = New System.Drawing.Size(140, 27)
        Me.RecOtherSpinEdit.TabIndex = 111
        '
        'RecChequeSpinEdit
        '
        Me.RecChequeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptDataBindingSource, "RecCheque", True))
        Me.RecChequeSpinEdit.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.RecChequeSpinEdit.Location = New System.Drawing.Point(538, 51)
        Me.RecChequeSpinEdit.Name = "RecChequeSpinEdit"
        Me.RecChequeSpinEdit.Size = New System.Drawing.Size(146, 27)
        Me.RecChequeSpinEdit.TabIndex = 110
        '
        'RecCashSpinEdit
        '
        Me.RecCashSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptDataBindingSource, "RecCash", True))
        Me.RecCashSpinEdit.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.RecCashSpinEdit.Location = New System.Drawing.Point(826, 51)
        Me.RecCashSpinEdit.Name = "RecCashSpinEdit"
        Me.RecCashSpinEdit.Size = New System.Drawing.Size(140, 27)
        Me.RecCashSpinEdit.TabIndex = 109
        '
        'TextEdit1
        '
        Me.TextEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(2, 88)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.AutoHeight = False
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(1030, 27)
        Me.TextEdit1.TabIndex = 108
        '
        'RecRateSpinEdit
        '
        Me.RecRateSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptDataBindingSource, "RecRate", True))
        Me.RecRateSpinEdit.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.RecRateSpinEdit.Location = New System.Drawing.Point(375, 13)
        Me.RecRateSpinEdit.Name = "RecRateSpinEdit"
        Me.RecRateSpinEdit.Size = New System.Drawing.Size(157, 27)
        Me.RecRateSpinEdit.TabIndex = 103
        '
        'smallcurrencylabel
        '
        Me.smallcurrencylabel.Location = New System.Drawing.Point(992, 5)
        Me.smallcurrencylabel.Name = "smallcurrencylabel"
        Me.smallcurrencylabel.Size = New System.Drawing.Size(24, 13)
        Me.smallcurrencylabel.TabIndex = 102
        Me.smallcurrencylabel.Text = "اغورة"
        Me.smallcurrencylabel.Visible = False
        '
        'AmountInNisText
        '
        Me.AmountInNisText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmountInNisText.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmountInNisText.Location = New System.Drawing.Point(7, 11)
        Me.AmountInNisText.Name = "AmountInNisText"
        Me.AmountInNisText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountInNisText.Properties.Appearance.Options.UseFont = True
        Me.AmountInNisText.Properties.AutoHeight = False
        Me.AmountInNisText.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.AmountInNisText.Properties.Mask.BeepOnError = True
        Me.AmountInNisText.Properties.Mask.EditMask = "c2"
        Me.AmountInNisText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.AmountInNisText.Properties.ReadOnly = True
        Me.AmountInNisText.Size = New System.Drawing.Size(162, 30)
        Me.AmountInNisText.TabIndex = 4
        '
        'RecCurrTextEdit
        '
        Me.RecCurrTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCurrTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCurr", True))
        Me.RecCurrTextEdit.EditValue = "شيكل"
        Me.RecCurrTextEdit.Location = New System.Drawing.Point(756, 11)
        Me.RecCurrTextEdit.Name = "RecCurrTextEdit"
        Me.RecCurrTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCurrTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCurrTextEdit.Properties.AutoHeight = False
        Me.RecCurrTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecCurrTextEdit.Properties.Items.AddRange(New Object() {"شيكل", "دولار", "دينار", "يورو"})
        Me.RecCurrTextEdit.Size = New System.Drawing.Size(186, 30)
        Me.RecCurrTextEdit.TabIndex = 2
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Controls.Add(Me.RecNoteTextEdit)
        Me.PanelControl5.Location = New System.Drawing.Point(8, 277)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1032, 69)
        Me.PanelControl5.TabIndex = 104
        '
        'RecNoteTextEdit
        '
        Me.RecNoteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecNote", True))
        Me.RecNoteTextEdit.Location = New System.Drawing.Point(7, 5)
        Me.RecNoteTextEdit.Name = "RecNoteTextEdit"
        Me.RecNoteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecNoteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecNoteTextEdit.Size = New System.Drawing.Size(1018, 56)
        Me.RecNoteTextEdit.TabIndex = 9
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.GridControl4)
        Me.GroupControl1.Controls.Add(Me.SumChequesLabel)
        Me.GroupControl1.Controls.Add(Me.CountChequesLabel)
        Me.GroupControl1.Controls.Add(Me.ChequeDataDataGridView)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 364)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1015, 244)
        Me.GroupControl1.TabIndex = 105
        Me.GroupControl1.Text = "تفاصيل الشيكات"
        '
        'GridControl4
        '
        Me.GridControl4.Location = New System.Drawing.Point(7, 163)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl4.Size = New System.Drawing.Size(1000, 76)
        Me.GridControl4.TabIndex = 11
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColAccrualDate, Me.ColCustomerName, Me.ColToUser, Me.ColTaskType, Me.ColAmount, Me.ColTaskMonth, Me.ColNote, Me.ColTaskID, Me.ColState})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'ColAccrualDate
        '
        Me.ColAccrualDate.Caption = "تاريخ المهمة"
        Me.ColAccrualDate.CustomizationCaption = "تاريخ المهمة"
        Me.ColAccrualDate.FieldName = "AccrualDate"
        Me.ColAccrualDate.Name = "ColAccrualDate"
        Me.ColAccrualDate.Visible = True
        Me.ColAccrualDate.VisibleIndex = 1
        Me.ColAccrualDate.Width = 110
        '
        'ColCustomerName
        '
        Me.ColCustomerName.Caption = "الزبون"
        Me.ColCustomerName.FieldName = "CustomerName"
        Me.ColCustomerName.Name = "ColCustomerName"
        Me.ColCustomerName.Visible = True
        Me.ColCustomerName.VisibleIndex = 2
        Me.ColCustomerName.Width = 208
        '
        'ColToUser
        '
        Me.ColToUser.Caption = "المستخدم"
        Me.ColToUser.FieldName = "ToUser"
        Me.ColToUser.Name = "ColToUser"
        Me.ColToUser.Visible = True
        Me.ColToUser.VisibleIndex = 3
        Me.ColToUser.Width = 76
        '
        'ColTaskType
        '
        Me.ColTaskType.Caption = "نوع المهمة"
        Me.ColTaskType.FieldName = "TaskType"
        Me.ColTaskType.Name = "ColTaskType"
        Me.ColTaskType.Visible = True
        Me.ColTaskType.VisibleIndex = 4
        Me.ColTaskType.Width = 76
        '
        'ColAmount
        '
        Me.ColAmount.Caption = "المبلغ"
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 5
        Me.ColAmount.Width = 76
        '
        'ColTaskMonth
        '
        Me.ColTaskMonth.Caption = "الشهر"
        Me.ColTaskMonth.FieldName = "TaskMonth"
        Me.ColTaskMonth.Name = "ColTaskMonth"
        Me.ColTaskMonth.Visible = True
        Me.ColTaskMonth.VisibleIndex = 6
        Me.ColTaskMonth.Width = 76
        '
        'ColNote
        '
        Me.ColNote.Caption = "ملاحظات"
        Me.ColNote.FieldName = "Note"
        Me.ColNote.Name = "ColNote"
        Me.ColNote.Visible = True
        Me.ColNote.VisibleIndex = 7
        Me.ColNote.Width = 195
        '
        'ColTaskID
        '
        Me.ColTaskID.Caption = "رقم المهمة"
        Me.ColTaskID.CustomizationCaption = "رقم المهمة"
        Me.ColTaskID.FieldName = "TaskID"
        Me.ColTaskID.Name = "ColTaskID"
        Me.ColTaskID.Visible = True
        Me.ColTaskID.VisibleIndex = 0
        Me.ColTaskID.Width = 50
        '
        'ColState
        '
        Me.ColState.Caption = "اغلاق"
        Me.ColState.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ColState.FieldName = "State"
        Me.ColState.Name = "ColState"
        Me.ColState.Visible = True
        Me.ColState.VisibleIndex = 8
        Me.ColState.Width = 115
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "اغلاق"
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "1"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "0"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'SumChequesLabel
        '
        Me.SumChequesLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SumChequesLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SumChequesLabel.Location = New System.Drawing.Point(80, 0)
        Me.SumChequesLabel.Name = "SumChequesLabel"
        Me.SumChequesLabel.Size = New System.Drawing.Size(89, 17)
        Me.SumChequesLabel.TabIndex = 2
        Me.SumChequesLabel.Text = "مجموع الشيكات"
        Me.SumChequesLabel.Visible = False
        '
        'CountChequesLabel
        '
        Me.CountChequesLabel.Location = New System.Drawing.Point(2, 2)
        Me.CountChequesLabel.Name = "CountChequesLabel"
        Me.CountChequesLabel.Size = New System.Drawing.Size(61, 13)
        Me.CountChequesLabel.TabIndex = 1
        Me.CountChequesLabel.Text = "عدد الشيكات"
        Me.CountChequesLabel.Visible = False
        '
        'ChequeDataDataGridView
        '
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
        Me.ChequeDataDataGridView.Location = New System.Drawing.Point(7, 23)
        Me.ChequeDataDataGridView.Name = "ChequeDataDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChequeDataDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ChequeDataDataGridView.Size = New System.Drawing.Size(1003, 134)
        Me.ChequeDataDataGridView.TabIndex = 10
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
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.RecOwnerTextEdit)
        Me.PanelControl6.Controls.Add(Me.RecInputDateDateEdit)
        Me.PanelControl6.Controls.Add(Me.RecUserTextEdit)
        Me.PanelControl6.Controls.Add(Me.RecAuditSpinEdit)
        Me.PanelControl6.Controls.Add(Me.RecDeviceNameTextEdit)
        Me.PanelControl6.Controls.Add(Me.RecStatusSpinEdit)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl6.Location = New System.Drawing.Point(0, 614)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1043, 37)
        Me.PanelControl6.TabIndex = 106
        '
        'RecOwnerTextEdit
        '
        Me.RecOwnerTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecOwnerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecOwner", True))
        Me.RecOwnerTextEdit.Location = New System.Drawing.Point(355, 5)
        Me.RecOwnerTextEdit.Name = "RecOwnerTextEdit"
        Me.RecOwnerTextEdit.Properties.AutoHeight = False
        Me.RecOwnerTextEdit.Properties.ReadOnly = True
        Me.RecOwnerTextEdit.Size = New System.Drawing.Size(100, 26)
        Me.RecOwnerTextEdit.TabIndex = 32
        '
        'RecInputDateDateEdit
        '
        Me.RecInputDateDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecInputDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecInputDate", True))
        Me.RecInputDateDateEdit.EditValue = Nothing
        Me.RecInputDateDateEdit.Enabled = False
        Me.RecInputDateDateEdit.Location = New System.Drawing.Point(1114, 5)
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
        Me.RecUserTextEdit.Location = New System.Drawing.Point(1305, 5)
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
        Me.RecAuditSpinEdit.Location = New System.Drawing.Point(750, 5)
        Me.RecAuditSpinEdit.Name = "RecAuditSpinEdit"
        Me.RecAuditSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecAuditSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecAuditSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecAuditSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecAuditSpinEdit.Properties.ReadOnly = True
        Me.RecAuditSpinEdit.Size = New System.Drawing.Size(130, 26)
        Me.RecAuditSpinEdit.TabIndex = 29
        '
        'RecDeviceNameTextEdit
        '
        Me.RecDeviceNameTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecDeviceNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecDeviceName", True))
        Me.RecDeviceNameTextEdit.Enabled = False
        Me.RecDeviceNameTextEdit.Location = New System.Drawing.Point(460, 5)
        Me.RecDeviceNameTextEdit.Name = "RecDeviceNameTextEdit"
        Me.RecDeviceNameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecDeviceNameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecDeviceNameTextEdit.Properties.ReadOnly = True
        Me.RecDeviceNameTextEdit.Size = New System.Drawing.Size(285, 26)
        Me.RecDeviceNameTextEdit.TabIndex = 31
        '
        'RecStatusSpinEdit
        '
        Me.RecStatusSpinEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecStatusSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecStatus", True))
        Me.RecStatusSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RecStatusSpinEdit.Enabled = False
        Me.RecStatusSpinEdit.Location = New System.Drawing.Point(886, 5)
        Me.RecStatusSpinEdit.Name = "RecStatusSpinEdit"
        Me.RecStatusSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecStatusSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecStatusSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecStatusSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecStatusSpinEdit.Properties.ReadOnly = True
        Me.RecStatusSpinEdit.Size = New System.Drawing.Size(144, 26)
        Me.RecStatusSpinEdit.TabIndex = 21
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.SimpleButton9)
        Me.PanelControl1.Controls.Add(Me.SimpleButton7)
        Me.PanelControl1.Controls.Add(Me.SimpleButton6)
        Me.PanelControl1.Controls.Add(Me.SimpleButton5)
        Me.PanelControl1.Controls.Add(Me.SimpleButton8)
        Me.PanelControl1.Controls.Add(Me.SimpleButton4)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 7)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1032, 43)
        Me.PanelControl1.TabIndex = 0
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(-1, 18)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "اظهار الرصيد والشيكات الاجلة عند طباعة السند"
        Me.CheckEdit1.Size = New System.Drawing.Size(248, 19)
        Me.CheckEdit1.TabIndex = 3
        '
        'SimpleButton9
        '
        Me.SimpleButton9.ImageOptions.Image = CType(resources.GetObject("SimpleButton9.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(288, 5)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(81, 36)
        Me.SimpleButton9.TabIndex = 2
        Me.SimpleButton9.Text = "تعديل السند"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(375, 5)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(118, 36)
        Me.SimpleButton7.TabIndex = 1
        Me.SimpleButton7.Text = "معاينة الطباعة"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(754, 5)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(43, 36)
        Me.SimpleButton6.TabIndex = 0
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(665, 5)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(43, 36)
        Me.SimpleButton5.TabIndex = 0
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.Appearance.Image = CType(resources.GetObject("SimpleButton8.Appearance.Image"), System.Drawing.Image)
        Me.SimpleButton8.Appearance.Options.UseImage = True
        Me.SimpleButton8.ImageOptions.Image = CType(resources.GetObject("SimpleButton8.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(499, 5)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(116, 36)
        Me.SimpleButton8.TabIndex = 0
        Me.SimpleButton8.Text = "طباعة"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(621, 5)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(43, 36)
        Me.SimpleButton4.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(710, 5)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(43, 36)
        Me.SimpleButton3.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(803, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(109, 36)
        Me.SimpleButton2.TabIndex = 0
        Me.SimpleButton2.Text = "جديد"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(916, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 39)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "حفظ"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(RecDateLabel)
        Me.PanelControl2.Controls.Add(RecNOLabel)
        Me.PanelControl2.Controls.Add(Me.RecDateDateEdit)
        Me.PanelControl2.Controls.Add(Me.RecNOSpinEdit)
        Me.PanelControl2.Location = New System.Drawing.Point(8, 54)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1032, 47)
        Me.PanelControl2.TabIndex = 1
        '
        'RecDateDateEdit
        '
        Me.RecDateDateEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecDate", True))
        Me.RecDateDateEdit.EditValue = Nothing
        Me.RecDateDateEdit.Location = New System.Drawing.Point(5, 8)
        Me.RecDateDateEdit.Name = "RecDateDateEdit"
        Me.RecDateDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecDateDateEdit.Properties.Appearance.Options.UseFont = True
        Me.RecDateDateEdit.Properties.AutoHeight = False
        Me.RecDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecDateDateEdit.Size = New System.Drawing.Size(300, 30)
        Me.RecDateDateEdit.TabIndex = 3
        '
        'RecNOSpinEdit
        '
        Me.RecNOSpinEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecNOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecNO", True))
        Me.RecNOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RecNOSpinEdit.Location = New System.Drawing.Point(750, 10)
        Me.RecNOSpinEdit.Name = "RecNOSpinEdit"
        Me.RecNOSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecNOSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.RecNOSpinEdit.Properties.AutoHeight = False
        Me.RecNOSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RecNOSpinEdit.Properties.Mask.BeepOnError = True
        Me.RecNOSpinEdit.Properties.Mask.EditMask = "d"
        Me.RecNOSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RecNOSpinEdit.Size = New System.Drawing.Size(192, 30)
        Me.RecNOSpinEdit.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.RecCustNoTextEdit)
        Me.PanelControl3.Controls.Add(Me.RecCustNameTextEdit)
        Me.PanelControl3.Controls.Add(RecCustNoLabel)
        Me.PanelControl3.Location = New System.Drawing.Point(8, 107)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1032, 45)
        Me.PanelControl3.TabIndex = 2
        '
        'RecCustNoTextEdit
        '
        Me.RecCustNoTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCustNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCustNo", True))
        Me.RecCustNoTextEdit.Location = New System.Drawing.Point(756, 11)
        Me.RecCustNoTextEdit.Name = "RecCustNoTextEdit"
        Me.RecCustNoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCustNoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCustNoTextEdit.Properties.AutoHeight = False
        Me.RecCustNoTextEdit.Size = New System.Drawing.Size(186, 30)
        Me.RecCustNoTextEdit.TabIndex = 0
        '
        'RecCustNameTextEdit
        '
        Me.RecCustNameTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecCustNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiptDataBindingSource, "RecCustName", True))
        Me.RecCustNameTextEdit.Location = New System.Drawing.Point(7, 11)
        Me.RecCustNameTextEdit.Name = "RecCustNameTextEdit"
        Me.RecCustNameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecCustNameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RecCustNameTextEdit.Properties.AutoHeight = False
        Me.RecCustNameTextEdit.Size = New System.Drawing.Size(743, 30)
        Me.RecCustNameTextEdit.TabIndex = 1
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "كشف حساب الزبون"
        Me.NavigationPage3.Controls.Add(Me.PanelControl8)
        Me.NavigationPage3.Controls.Add(Me.PanelControl7)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(1043, 651)
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.GridControl1)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl8.Location = New System.Drawing.Point(0, 40)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(1043, 611)
        Me.PanelControl8.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1039, 607)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.TextEdit2)
        Me.PanelControl7.Controls.Add(Me.SimpleButton11)
        Me.PanelControl7.Controls.Add(Me.SimpleButton10)
        Me.PanelControl7.Controls.Add(Me.DateEditTo)
        Me.PanelControl7.Controls.Add(Me.DateEditFrom)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(1043, 40)
        Me.PanelControl7.TabIndex = 0
        '
        'TextEdit2
        '
        Me.TextEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit2.Location = New System.Drawing.Point(27, 7)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.AutoHeight = False
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(489, 27)
        Me.TextEdit2.TabIndex = 4
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton11.ImageOptions.Image = CType(resources.GetObject("SimpleButton11.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton11.Location = New System.Drawing.Point(527, 6)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(86, 30)
        Me.SimpleButton11.TabIndex = 3
        Me.SimpleButton11.Text = "طباعة"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton10.ImageOptions.Image = CType(resources.GetObject("SimpleButton10.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton10.Location = New System.Drawing.Point(619, 6)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(86, 30)
        Me.SimpleButton10.TabIndex = 2
        Me.SimpleButton10.Text = "تحدبث"
        '
        'DateEditTo
        '
        Me.DateEditTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEditTo.EditValue = Nothing
        Me.DateEditTo.Location = New System.Drawing.Point(715, 6)
        Me.DateEditTo.Name = "DateEditTo"
        Me.DateEditTo.Properties.AutoHeight = False
        Me.DateEditTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Size = New System.Drawing.Size(159, 30)
        Me.DateEditTo.TabIndex = 1
        '
        'DateEditFrom
        '
        Me.DateEditFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEditFrom.EditValue = Nothing
        Me.DateEditFrom.Location = New System.Drawing.Point(880, 6)
        Me.DateEditFrom.Name = "DateEditFrom"
        Me.DateEditFrom.Properties.AutoHeight = False
        Me.DateEditFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Size = New System.Drawing.Size(159, 30)
        Me.DateEditFrom.TabIndex = 0
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Caption = "شيكات الزبون"
        Me.NavigationPage4.Controls.Add(Me.PanelControl11)
        Me.NavigationPage4.Controls.Add(Me.PanelControl10)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(1043, 651)
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.GridControl2)
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl11.Location = New System.Drawing.Point(0, 40)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(1043, 611)
        Me.PanelControl11.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Cheqs"
        Me.GridControl2.DataSource = Me.SqlDataSource1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1039, 607)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "WizCountString_ALHUDA_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "CheqNumber"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""571"" />"
        Table1.Name = "Cheqs"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "BankNumber"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "Branch"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "ValueDate"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "SuF"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Currency"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Details"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "SuFDlr"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "CurrencyDlr"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "BankAccNum"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "AccKey"
        ColumnExpression11.Table = Table1
        Column11.Expression = ColumnExpression11
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.Columns.Add(Column10)
        SelectQuery1.Columns.Add(Column11)
        SelectQuery1.FilterString = "[Cheqs.AccKey] = ?Parameter1 And [Cheqs.ValueDate] Between(?Parameter2, ?Paramete" &
    "r3)"
        SelectQuery1.GroupFilterString = ""
        SelectQuery1.Name = "Cheqs"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(Short)
        QueryParameter1.ValueInfo = "1031"
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(Date)
        QueryParameter2.ValueInfo = "1753-01-01"
        QueryParameter3.Name = "Parameter3"
        QueryParameter3.Type = GetType(Date)
        QueryParameter3.ValueInfo = "2099-01-01"
        SelectQuery1.Parameters.Add(QueryParameter1)
        SelectQuery1.Parameters.Add(QueryParameter2)
        SelectQuery1.Parameters.Add(QueryParameter3)
        Sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
        ColumnExpression12.ColumnName = "ValueDate"
        ColumnExpression12.Table = Table1
        Sorting1.Expression = ColumnExpression12
        SelectQuery1.Sorting.Add(Sorting1)
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCheqNumber, Me.colBankNumber, Me.colBranch, Me.colValueDate, Me.colSuF, Me.colCurrency, Me.colDetails, Me.colSuFDlr, Me.colCurrencyDlr, Me.colBankAccNum, Me.colAccKey})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCheqNumber
        '
        Me.colCheqNumber.FieldName = "CheqNumber"
        Me.colCheqNumber.Name = "colCheqNumber"
        Me.colCheqNumber.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CheqNumber", "{0}")})
        Me.colCheqNumber.Visible = True
        Me.colCheqNumber.VisibleIndex = 0
        '
        'colBankNumber
        '
        Me.colBankNumber.FieldName = "BankNumber"
        Me.colBankNumber.Name = "colBankNumber"
        Me.colBankNumber.Visible = True
        Me.colBankNumber.VisibleIndex = 1
        '
        'colBranch
        '
        Me.colBranch.FieldName = "Branch"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.Visible = True
        Me.colBranch.VisibleIndex = 2
        '
        'colValueDate
        '
        Me.colValueDate.FieldName = "ValueDate"
        Me.colValueDate.Name = "colValueDate"
        Me.colValueDate.Visible = True
        Me.colValueDate.VisibleIndex = 3
        '
        'colSuF
        '
        Me.colSuF.FieldName = "SuF"
        Me.colSuF.Name = "colSuF"
        Me.colSuF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SuF", "{0}")})
        Me.colSuF.Visible = True
        Me.colSuF.VisibleIndex = 4
        '
        'colCurrency
        '
        Me.colCurrency.FieldName = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.Visible = True
        Me.colCurrency.VisibleIndex = 5
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 6
        '
        'colSuFDlr
        '
        Me.colSuFDlr.FieldName = "SuFDlr"
        Me.colSuFDlr.Name = "colSuFDlr"
        Me.colSuFDlr.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SuFDlr", "{0}")})
        Me.colSuFDlr.Visible = True
        Me.colSuFDlr.VisibleIndex = 7
        '
        'colCurrencyDlr
        '
        Me.colCurrencyDlr.FieldName = "CurrencyDlr"
        Me.colCurrencyDlr.Name = "colCurrencyDlr"
        Me.colCurrencyDlr.Visible = True
        Me.colCurrencyDlr.VisibleIndex = 8
        '
        'colBankAccNum
        '
        Me.colBankAccNum.FieldName = "BankAccNum"
        Me.colBankAccNum.Name = "colBankAccNum"
        Me.colBankAccNum.Visible = True
        Me.colBankAccNum.VisibleIndex = 9
        '
        'colAccKey
        '
        Me.colAccKey.FieldName = "AccKey"
        Me.colAccKey.Name = "colAccKey"
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.SimpleButton16)
        Me.PanelControl10.Controls.Add(Me.TextEdit3)
        Me.PanelControl10.Controls.Add(Me.SimpleButton13)
        Me.PanelControl10.Controls.Add(Me.DateEdit1)
        Me.PanelControl10.Controls.Add(Me.DateEdit2)
        Me.PanelControl10.Controls.Add(Me.SimpleButton12)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl10.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(1043, 40)
        Me.PanelControl10.TabIndex = 1
        '
        'SimpleButton16
        '
        Me.SimpleButton16.ImageOptions.Image = CType(resources.GetObject("SimpleButton16.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton16.Location = New System.Drawing.Point(6, 4)
        Me.SimpleButton16.Name = "SimpleButton16"
        Me.SimpleButton16.Size = New System.Drawing.Size(45, 32)
        Me.SimpleButton16.TabIndex = 8
        '
        'TextEdit3
        '
        Me.TextEdit3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit3.Location = New System.Drawing.Point(88, 7)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.AutoHeight = False
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(436, 27)
        Me.TextEdit3.TabIndex = 7
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton13.ImageOptions.Image = CType(resources.GetObject("SimpleButton13.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton13.Location = New System.Drawing.Point(530, 5)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(86, 30)
        Me.SimpleButton13.TabIndex = 6
        Me.SimpleButton13.Text = "غير مستحق"
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(879, 5)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AutoHeight = False
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(159, 30)
        Me.DateEdit1.TabIndex = 5
        '
        'DateEdit2
        '
        Me.DateEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(714, 4)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.AutoHeight = False
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(159, 30)
        Me.DateEdit2.TabIndex = 4
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton12.ImageOptions.Image = CType(resources.GetObject("SimpleButton12.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton12.Location = New System.Drawing.Point(622, 6)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(86, 30)
        Me.SimpleButton12.TabIndex = 3
        Me.SimpleButton12.Text = "تحدبث"
        '
        'NavigationPage5
        '
        Me.NavigationPage5.Caption = "استعلام سندات القبض"
        Me.NavigationPage5.Controls.Add(Me.PanelControl13)
        Me.NavigationPage5.Controls.Add(Me.PanelControl12)
        Me.NavigationPage5.Name = "NavigationPage5"
        Me.NavigationPage5.Size = New System.Drawing.Size(1043, 651)
        '
        'PanelControl13
        '
        Me.PanelControl13.Controls.Add(Me.GridControl3)
        Me.PanelControl13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl13.Location = New System.Drawing.Point(0, 45)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(1043, 606)
        Me.PanelControl13.TabIndex = 1
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "ReceiptData"
        Me.GridControl3.DataSource = Me.SqlDataSource2
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1039, 602)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionName = "CRMConnectionString"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        ColumnExpression13.ColumnName = "RecNO"
        Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""381"" />"
        Table2.Name = "ReceiptData"
        ColumnExpression13.Table = Table2
        Column12.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "RecDate"
        ColumnExpression14.Table = Table2
        Column13.Expression = ColumnExpression14
        ColumnExpression15.ColumnName = "RecCustNo"
        ColumnExpression15.Table = Table2
        Column14.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "RecCustName"
        ColumnExpression16.Table = Table2
        Column15.Expression = ColumnExpression16
        ColumnExpression17.ColumnName = "RecCash"
        ColumnExpression17.Table = Table2
        Column16.Expression = ColumnExpression17
        ColumnExpression18.ColumnName = "RecCheque"
        ColumnExpression18.Table = Table2
        Column17.Expression = ColumnExpression18
        ColumnExpression19.ColumnName = "RecOther"
        ColumnExpression19.Table = Table2
        Column18.Expression = ColumnExpression19
        ColumnExpression20.ColumnName = "RecNote"
        ColumnExpression20.Table = Table2
        Column19.Expression = ColumnExpression20
        ColumnExpression21.ColumnName = "RecUser"
        ColumnExpression21.Table = Table2
        Column20.Expression = ColumnExpression21
        ColumnExpression22.ColumnName = "RecInputDate"
        ColumnExpression22.Table = Table2
        Column21.Expression = ColumnExpression22
        ColumnExpression23.ColumnName = "RecStatus"
        ColumnExpression23.Table = Table2
        Column22.Expression = ColumnExpression23
        ColumnExpression24.ColumnName = "RecCurr"
        ColumnExpression24.Table = Table2
        Column23.Expression = ColumnExpression24
        ColumnExpression25.ColumnName = "RecRate"
        ColumnExpression25.Table = Table2
        Column24.Expression = ColumnExpression25
        ColumnExpression26.ColumnName = "RecTotal"
        ColumnExpression26.Table = Table2
        Column25.Expression = ColumnExpression26
        ColumnExpression27.ColumnName = "RecAudit"
        ColumnExpression27.Table = Table2
        Column26.Expression = ColumnExpression27
        ColumnExpression28.ColumnName = "RecDeviceName"
        ColumnExpression28.Table = Table2
        Column27.Expression = ColumnExpression28
        ColumnExpression29.ColumnName = "RecOwner"
        ColumnExpression29.Table = Table2
        Column28.Expression = ColumnExpression29
        SelectQuery2.Columns.Add(Column12)
        SelectQuery2.Columns.Add(Column13)
        SelectQuery2.Columns.Add(Column14)
        SelectQuery2.Columns.Add(Column15)
        SelectQuery2.Columns.Add(Column16)
        SelectQuery2.Columns.Add(Column17)
        SelectQuery2.Columns.Add(Column18)
        SelectQuery2.Columns.Add(Column19)
        SelectQuery2.Columns.Add(Column20)
        SelectQuery2.Columns.Add(Column21)
        SelectQuery2.Columns.Add(Column22)
        SelectQuery2.Columns.Add(Column23)
        SelectQuery2.Columns.Add(Column24)
        SelectQuery2.Columns.Add(Column25)
        SelectQuery2.Columns.Add(Column26)
        SelectQuery2.Columns.Add(Column27)
        SelectQuery2.Columns.Add(Column28)
        SelectQuery2.Name = "ReceiptData"
        RelationColumnInfo1.NestedKeyColumn = "ChequeReceiptNo"
        RelationColumnInfo1.ParentKeyColumn = "RecNO"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Table3.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""210"" />"
        Table3.Name = "ChequeData"
        Join1.Nested = Table3
        Join1.Parent = Table2
        Join1.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
        SelectQuery2.Relations.Add(Join1)
        Sorting2.Direction = System.ComponentModel.ListSortDirection.Descending
        ColumnExpression30.ColumnName = "RecNO"
        ColumnExpression30.Table = Table2
        Sorting2.Expression = ColumnExpression30
        SelectQuery2.Sorting.Add(Sorting2)
        SelectQuery2.Tables.Add(Table2)
        SelectQuery2.Tables.Add(Table3)
        Me.SqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
        Me.SqlDataSource2.ResultSchemaSerializable = resources.GetString("SqlDataSource2.ResultSchemaSerializable")
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecNO, Me.colRecDate, Me.colRecCustNo, Me.colRecCustName, Me.colRecCash, Me.colRecCheque, Me.colRecOther, Me.colRecNote, Me.colRecUser, Me.colRecInputDate, Me.colRecStatus, Me.colRecCurr, Me.colRecRate, Me.colRecTotal, Me.colRecAudit, Me.colRecDeviceName, Me.colRecOwner})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        '
        'colRecNO
        '
        Me.colRecNO.FieldName = "RecNO"
        Me.colRecNO.Name = "colRecNO"
        Me.colRecNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecNO", "عدد {0}")})
        Me.colRecNO.Visible = True
        Me.colRecNO.VisibleIndex = 0
        '
        'colRecDate
        '
        Me.colRecDate.FieldName = "RecDate"
        Me.colRecDate.Name = "colRecDate"
        Me.colRecDate.Visible = True
        Me.colRecDate.VisibleIndex = 1
        '
        'colRecCustNo
        '
        Me.colRecCustNo.FieldName = "RecCustNo"
        Me.colRecCustNo.Name = "colRecCustNo"
        Me.colRecCustNo.Visible = True
        Me.colRecCustNo.VisibleIndex = 2
        '
        'colRecCustName
        '
        Me.colRecCustName.FieldName = "RecCustName"
        Me.colRecCustName.Name = "colRecCustName"
        Me.colRecCustName.Visible = True
        Me.colRecCustName.VisibleIndex = 3
        '
        'colRecCash
        '
        Me.colRecCash.FieldName = "RecCash"
        Me.colRecCash.Name = "colRecCash"
        Me.colRecCash.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecCash", "{0}")})
        Me.colRecCash.Visible = True
        Me.colRecCash.VisibleIndex = 4
        '
        'colRecCheque
        '
        Me.colRecCheque.FieldName = "RecCheque"
        Me.colRecCheque.Name = "colRecCheque"
        Me.colRecCheque.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecCheque", "{0}")})
        Me.colRecCheque.Visible = True
        Me.colRecCheque.VisibleIndex = 5
        '
        'colRecOther
        '
        Me.colRecOther.FieldName = "RecOther"
        Me.colRecOther.Name = "colRecOther"
        Me.colRecOther.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecOther", "{0}")})
        Me.colRecOther.Visible = True
        Me.colRecOther.VisibleIndex = 6
        '
        'colRecNote
        '
        Me.colRecNote.FieldName = "RecNote"
        Me.colRecNote.Name = "colRecNote"
        Me.colRecNote.Visible = True
        Me.colRecNote.VisibleIndex = 7
        '
        'colRecUser
        '
        Me.colRecUser.FieldName = "RecUser"
        Me.colRecUser.Name = "colRecUser"
        Me.colRecUser.Visible = True
        Me.colRecUser.VisibleIndex = 8
        '
        'colRecInputDate
        '
        Me.colRecInputDate.FieldName = "RecInputDate"
        Me.colRecInputDate.Name = "colRecInputDate"
        Me.colRecInputDate.Visible = True
        Me.colRecInputDate.VisibleIndex = 9
        '
        'colRecStatus
        '
        Me.colRecStatus.FieldName = "RecStatus"
        Me.colRecStatus.Name = "colRecStatus"
        Me.colRecStatus.Visible = True
        Me.colRecStatus.VisibleIndex = 10
        '
        'colRecCurr
        '
        Me.colRecCurr.FieldName = "RecCurr"
        Me.colRecCurr.Name = "colRecCurr"
        Me.colRecCurr.Visible = True
        Me.colRecCurr.VisibleIndex = 11
        '
        'colRecRate
        '
        Me.colRecRate.FieldName = "RecRate"
        Me.colRecRate.Name = "colRecRate"
        Me.colRecRate.Visible = True
        Me.colRecRate.VisibleIndex = 12
        '
        'colRecTotal
        '
        Me.colRecTotal.FieldName = "RecTotal"
        Me.colRecTotal.Name = "colRecTotal"
        Me.colRecTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecTotal", "{0}")})
        Me.colRecTotal.Visible = True
        Me.colRecTotal.VisibleIndex = 13
        '
        'colRecAudit
        '
        Me.colRecAudit.FieldName = "RecAudit"
        Me.colRecAudit.Name = "colRecAudit"
        Me.colRecAudit.Visible = True
        Me.colRecAudit.VisibleIndex = 14
        '
        'colRecDeviceName
        '
        Me.colRecDeviceName.FieldName = "RecDeviceName"
        Me.colRecDeviceName.Name = "colRecDeviceName"
        Me.colRecDeviceName.Visible = True
        Me.colRecDeviceName.VisibleIndex = 15
        '
        'colRecOwner
        '
        Me.colRecOwner.FieldName = "RecOwner"
        Me.colRecOwner.Name = "colRecOwner"
        Me.colRecOwner.Visible = True
        Me.colRecOwner.VisibleIndex = 16
        '
        'PanelControl12
        '
        Me.PanelControl12.Controls.Add(Me.SimpleButton14)
        Me.PanelControl12.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl12.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(1043, 45)
        Me.PanelControl12.TabIndex = 0
        '
        'SimpleButton14
        '
        Me.SimpleButton14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton14.ImageOptions.Image = CType(resources.GetObject("SimpleButton14.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton14.Location = New System.Drawing.Point(933, 6)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(104, 34)
        Me.SimpleButton14.TabIndex = 0
        Me.SimpleButton14.Text = "نحديث"
        '
        'ChequeDataTableAdapter
        '
        Me.ChequeDataTableAdapter.ClearBeforeFill = True
        '
        'ReceiptDataTableAdapter
        '
        Me.ReceiptDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsAddDataTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarsMarkaTableAdapter = Nothing
        Me.TableAdapterManager.CarsModelTableAdapter = Nothing
        Me.TableAdapterManager.CarsNotesTableAdapter = Nothing
        Me.TableAdapterManager.CarsSort2TableAdapter = Nothing
        Me.TableAdapterManager.CarsSortTableAdapter = Nothing
        Me.TableAdapterManager.carsTableAdapter = Nothing
        Me.TableAdapterManager.ChequeDataTableAdapter = Me.ChequeDataTableAdapter
        Me.TableAdapterManager.CRMTasksTableAdapter = Nothing
        Me.TableAdapterManager.DevelopNotesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesDataTableAdapter = Nothing
        Me.TableAdapterManager.FinancialChequesBackTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptDataTableAdapter = Me.ReceiptDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = DXApplication5.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersLogInLogsTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'FinanceReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Name = "FinanceReceipt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "سند قبض"
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.ReceiptDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountInNisText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecCurrTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.RecNoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.RecOwnerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecInputDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecInputDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecAuditSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecDeviceNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecStatusSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.RecDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecNOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.RecCustNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecCustNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage3.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage4.ResumeLayout(False)
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage5.ResumeLayout(False)
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl13.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents smallcurrencylabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AmountInNisText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecCurrTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ReceiptDataBindingSource As BindingSource
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RecNoteTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CountChequesLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChequeDataDataGridView As DataGridView
    Friend WithEvents ChequeDataBindingSource As BindingSource
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RecInputDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RecUserTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecAuditSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecDeviceNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecStatusSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RecDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RecNOSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RecCustNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecCustNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChequeDataTableAdapter As CRMDataSetTableAdapters.ChequeDataTableAdapter
    Friend WithEvents ReceiptDataTableAdapter As CRMDataSetTableAdapters.ReceiptDataTableAdapter
    Friend WithEvents TableAdapterManager As CRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SumChequesLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEditTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents colCheqNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuFDlr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyDlr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavigationPage5 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataSource2 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colRecOwner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecOwnerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RecRateSpinEdit As TextBox
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RecTotalSpinEdit As TextBox
    Friend WithEvents RecOtherSpinEdit As TextBox
    Friend WithEvents RecChequeSpinEdit As TextBox
    Friend WithEvents RecCashSpinEdit As TextBox
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ColAccrualDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCustomerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColToUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTaskType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTaskMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTaskID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
