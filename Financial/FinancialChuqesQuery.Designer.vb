<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancialChuqesQuery
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
        Dim SelectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column29 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression31 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column30 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression32 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column31 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression33 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column32 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression34 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column33 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting3 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialChuqesQuery))
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIB_BANK_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIB_BRANCH_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSORT_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCHECK_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACCOUNT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRUN_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRUN_USER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFrontImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRearimage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBANK_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavigationPane1
        '
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage3)
        Me.NavigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPane1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(1148, 647)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage2
        Me.NavigationPane1.Size = New System.Drawing.Size(1148, 647)
        Me.NavigationPane1.TabIndex = 0
        Me.NavigationPane1.Text = "NavigationPane1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "الرئيسية"
        Me.NavigationPage1.Controls.Add(Me.DashboardViewer1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1046, 587)
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.DashboardSource = "DXApplication5.Win_Dashboards.ChequesImages"
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(1046, 587)
        Me.DashboardViewer1.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "بيانات الشيكات"
        Me.NavigationPage2.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1052, 586)
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Checks"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Location = New System.Drawing.Point(12, 38)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1028, 536)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ChequesConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression25.ColumnName = "ID"
        Table5.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""723"" />"
        Table5.Name = "Checks"
        ColumnExpression25.Table = Table5
        Column23.Expression = ColumnExpression25
        ColumnExpression26.ColumnName = "IB_BANK_ID"
        ColumnExpression26.Table = Table5
        Column24.Expression = ColumnExpression26
        ColumnExpression27.ColumnName = "IB_BRANCH_ID"
        ColumnExpression27.Table = Table5
        Column25.Expression = ColumnExpression27
        ColumnExpression28.ColumnName = "SORT_ID"
        ColumnExpression28.Table = Table5
        Column26.Expression = ColumnExpression28
        ColumnExpression29.ColumnName = "CHECK_NO"
        ColumnExpression29.Table = Table5
        Column27.Expression = ColumnExpression29
        ColumnExpression30.ColumnName = "ACCOUNT_NO"
        ColumnExpression30.Table = Table5
        Column28.Expression = ColumnExpression30
        ColumnExpression31.ColumnName = "RUN_DATE"
        ColumnExpression31.Table = Table5
        Column29.Expression = ColumnExpression31
        ColumnExpression32.ColumnName = "RUN_USER"
        ColumnExpression32.Table = Table5
        Column30.Expression = ColumnExpression32
        ColumnExpression33.ColumnName = "FrontImage"
        ColumnExpression33.Table = Table5
        Column31.Expression = ColumnExpression33
        ColumnExpression34.ColumnName = "Rearimage"
        ColumnExpression34.Table = Table5
        Column32.Expression = ColumnExpression34
        ColumnExpression35.ColumnName = "BANK_NAME"
        Table6.MetaSerializable = "<Meta X=""260"" Y=""70"" Width=""125"" Height=""115"" />"
        Table6.Name = "BANKS"
        ColumnExpression35.Table = Table6
        Column33.Expression = ColumnExpression35
        SelectQuery3.Columns.Add(Column23)
        SelectQuery3.Columns.Add(Column24)
        SelectQuery3.Columns.Add(Column25)
        SelectQuery3.Columns.Add(Column26)
        SelectQuery3.Columns.Add(Column27)
        SelectQuery3.Columns.Add(Column28)
        SelectQuery3.Columns.Add(Column29)
        SelectQuery3.Columns.Add(Column30)
        SelectQuery3.Columns.Add(Column31)
        SelectQuery3.Columns.Add(Column32)
        SelectQuery3.Columns.Add(Column33)
        SelectQuery3.Name = "Checks"
        RelationColumnInfo3.NestedKeyColumn = "BANK_ID"
        RelationColumnInfo3.ParentKeyColumn = "IB_BANK_ID"
        Join3.KeyColumns.Add(RelationColumnInfo3)
        Join3.Nested = Table6
        Join3.Parent = Table5
        Join3.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
        SelectQuery3.Relations.Add(Join3)
        ColumnExpression36.ColumnName = "ID"
        ColumnExpression36.Table = Table5
        Sorting3.Expression = ColumnExpression36
        SelectQuery3.Sorting.Add(Sorting3)
        SelectQuery3.Tables.Add(Table5)
        SelectQuery3.Tables.Add(Table6)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery3})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIB_BANK_ID, Me.colIB_BRANCH_ID, Me.colSORT_ID, Me.colCHECK_NO, Me.colACCOUNT_NO, Me.colRUN_DATE, Me.colRUN_USER, Me.colFrontImage, Me.colRearimage, Me.colBANK_NAME})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIB_BANK_ID
        '
        Me.colIB_BANK_ID.Caption = "رقم البنك"
        Me.colIB_BANK_ID.FieldName = "IB_BANK_ID"
        Me.colIB_BANK_ID.Name = "colIB_BANK_ID"
        Me.colIB_BANK_ID.Visible = True
        Me.colIB_BANK_ID.VisibleIndex = 3
        '
        'colIB_BRANCH_ID
        '
        Me.colIB_BRANCH_ID.Caption = "رقم الفرع"
        Me.colIB_BRANCH_ID.FieldName = "IB_BRANCH_ID"
        Me.colIB_BRANCH_ID.Name = "colIB_BRANCH_ID"
        Me.colIB_BRANCH_ID.Visible = True
        Me.colIB_BRANCH_ID.VisibleIndex = 4
        '
        'colSORT_ID
        '
        Me.colSORT_ID.Caption = "Sort"
        Me.colSORT_ID.FieldName = "SORT_ID"
        Me.colSORT_ID.Name = "colSORT_ID"
        Me.colSORT_ID.Visible = True
        Me.colSORT_ID.VisibleIndex = 5
        '
        'colCHECK_NO
        '
        Me.colCHECK_NO.Caption = "رقم الشيك"
        Me.colCHECK_NO.FieldName = "CHECK_NO"
        Me.colCHECK_NO.Name = "colCHECK_NO"
        Me.colCHECK_NO.Visible = True
        Me.colCHECK_NO.VisibleIndex = 1
        '
        'colACCOUNT_NO
        '
        Me.colACCOUNT_NO.Caption = "رقم الحساب"
        Me.colACCOUNT_NO.FieldName = "ACCOUNT_NO"
        Me.colACCOUNT_NO.Name = "colACCOUNT_NO"
        Me.colACCOUNT_NO.Visible = True
        Me.colACCOUNT_NO.VisibleIndex = 6
        '
        'colRUN_DATE
        '
        Me.colRUN_DATE.Caption = "تاريخ الادخال"
        Me.colRUN_DATE.FieldName = "RUN_DATE"
        Me.colRUN_DATE.Name = "colRUN_DATE"
        Me.colRUN_DATE.Visible = True
        Me.colRUN_DATE.VisibleIndex = 7
        '
        'colRUN_USER
        '
        Me.colRUN_USER.Caption = "المستخدم"
        Me.colRUN_USER.FieldName = "RUN_USER"
        Me.colRUN_USER.Name = "colRUN_USER"
        Me.colRUN_USER.Visible = True
        Me.colRUN_USER.VisibleIndex = 8
        '
        'colFrontImage
        '
        Me.colFrontImage.Caption = "صورة الشيك"
        Me.colFrontImage.FieldName = "FrontImage"
        Me.colFrontImage.Name = "colFrontImage"
        '
        'colRearimage
        '
        Me.colRearimage.Caption = "صورة الشيك خلفي"
        Me.colRearimage.FieldName = "Rearimage"
        Me.colRearimage.Name = "colRearimage"
        '
        'colBANK_NAME
        '
        Me.colBANK_NAME.Caption = "اسم البنك"
        Me.colBANK_NAME.FieldName = "BANK_NAME"
        Me.colBANK_NAME.Name = "colBANK_NAME"
        Me.colBANK_NAME.Visible = True
        Me.colBANK_NAME.VisibleIndex = 2
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "صور الشيكات"
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(1148, 647)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1052, 586)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1052, 586)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1032, 540)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(637, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(187, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(625, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(828, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(212, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(816, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(216, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(447, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(186, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton3
        Me.LayoutControlItem4.Location = New System.Drawing.Point(435, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(190, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(432, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'FinancialChuqesQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 647)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Name = "FinancialChuqesQuery"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "دفعات الشيكات"
        CType(Me.NavigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIB_BANK_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIB_BRANCH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSORT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCHECK_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACCOUNT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRUN_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRUN_USER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFrontImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRearimage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBANK_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
