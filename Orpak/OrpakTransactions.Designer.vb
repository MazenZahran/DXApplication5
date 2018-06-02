<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrpakTransactions
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
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Join4 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakTransactions))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colshift_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltimestamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpump = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduct_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colppv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colquantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmean_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproduct_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstn_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "transactions"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1200, 491)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "HO_DATAConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression15.ColumnName = "shift_id"
        Table4.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""1426"" />"
        Table4.Name = "transactions"
        ColumnExpression15.Table = Table4
        Column15.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "timestamp"
        ColumnExpression16.Table = Table4
        Column16.Expression = ColumnExpression16
        ColumnExpression17.ColumnName = "id"
        ColumnExpression17.Table = Table4
        Column17.Expression = ColumnExpression17
        ColumnExpression18.ColumnName = "type"
        ColumnExpression18.Table = Table4
        Column18.Expression = ColumnExpression18
        ColumnExpression19.ColumnName = "pump"
        ColumnExpression19.Table = Table4
        Column19.Expression = ColumnExpression19
        ColumnExpression20.ColumnName = "product_code"
        ColumnExpression20.Table = Table4
        Column20.Expression = ColumnExpression20
        ColumnExpression21.ColumnName = "sale"
        ColumnExpression21.Table = Table4
        Column21.Expression = ColumnExpression21
        ColumnExpression22.ColumnName = "ppv"
        ColumnExpression22.Table = Table4
        Column22.Expression = ColumnExpression22
        ColumnExpression23.ColumnName = "quantity"
        ColumnExpression23.Table = Table4
        Column23.Expression = ColumnExpression23
        ColumnExpression24.ColumnName = "mean_name"
        ColumnExpression24.Table = Table4
        Column24.Expression = ColumnExpression24
        ColumnExpression25.ColumnName = "product_name"
        ColumnExpression25.Table = Table4
        Column25.Expression = ColumnExpression25
        ColumnExpression26.ColumnName = "code"
        Table5.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""1046"" />"
        Table5.Name = "fleets"
        ColumnExpression26.Table = Table5
        Column26.Expression = ColumnExpression26
        ColumnExpression27.ColumnName = "name"
        ColumnExpression27.Table = Table5
        Column27.Expression = ColumnExpression27
        ColumnExpression28.ColumnName = "stn_name"
        Table6.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""875"" />"
        Table6.Name = "stations"
        ColumnExpression28.Table = Table6
        Column28.Expression = ColumnExpression28
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
        SelectQuery2.FilterString = "[transactions.date] Between(?Parameter2, ?Parameter3)"
        SelectQuery2.GroupFilterString = ""
        SelectQuery2.Name = "transactions"
        QueryParameter3.Name = "Parameter2"
        QueryParameter3.Type = GetType(Date)
        QueryParameter3.ValueInfo = "1753-01-01"
        QueryParameter4.Name = "Parameter3"
        QueryParameter4.Type = GetType(Date)
        QueryParameter4.ValueInfo = "1753-01-01"
        SelectQuery2.Parameters.Add(QueryParameter3)
        SelectQuery2.Parameters.Add(QueryParameter4)
        RelationColumnInfo3.NestedKeyColumn = "id"
        RelationColumnInfo3.ParentKeyColumn = "fleet_id"
        Join3.KeyColumns.Add(RelationColumnInfo3)
        Join3.Nested = Table5
        Join3.Parent = Table4
        RelationColumnInfo4.NestedKeyColumn = "stn_id"
        RelationColumnInfo4.ParentKeyColumn = "stn_id"
        Join4.KeyColumns.Add(RelationColumnInfo4)
        Join4.Nested = Table6
        Join4.Parent = Table4
        SelectQuery2.Relations.Add(Join3)
        SelectQuery2.Relations.Add(Join4)
        SelectQuery2.Tables.Add(Table4)
        SelectQuery2.Tables.Add(Table5)
        SelectQuery2.Tables.Add(Table6)
        SelectQuery2.Top = 100000
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colshift_id, Me.coltimestamp, Me.colid, Me.coltype, Me.colpump, Me.colproduct_code, Me.colsale, Me.colppv, Me.colquantity, Me.colmean_name, Me.colproduct_name, Me.colcode, Me.colname, Me.colstn_name})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colshift_id
        '
        Me.colshift_id.FieldName = "shift_id"
        Me.colshift_id.GroupFormat.FormatString = "yyyy/MM/dd HH:mm"
        Me.colshift_id.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colshift_id.Name = "colshift_id"
        Me.colshift_id.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "shift_id", "عدد {0}")})
        Me.colshift_id.Visible = True
        Me.colshift_id.VisibleIndex = 0
        '
        'coltimestamp
        '
        Me.coltimestamp.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm"
        Me.coltimestamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coltimestamp.FieldName = "timestamp"
        Me.coltimestamp.Name = "coltimestamp"
        Me.coltimestamp.Visible = True
        Me.coltimestamp.VisibleIndex = 1
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 2
        '
        'coltype
        '
        Me.coltype.FieldName = "type"
        Me.coltype.Name = "coltype"
        Me.coltype.Visible = True
        Me.coltype.VisibleIndex = 3
        '
        'colpump
        '
        Me.colpump.FieldName = "pump"
        Me.colpump.Name = "colpump"
        Me.colpump.Visible = True
        Me.colpump.VisibleIndex = 4
        '
        'colproduct_code
        '
        Me.colproduct_code.FieldName = "product_code"
        Me.colproduct_code.Name = "colproduct_code"
        Me.colproduct_code.Visible = True
        Me.colproduct_code.VisibleIndex = 5
        '
        'colsale
        '
        Me.colsale.FieldName = "sale"
        Me.colsale.Name = "colsale"
        Me.colsale.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sale", "SUM={0:0.##}")})
        Me.colsale.Visible = True
        Me.colsale.VisibleIndex = 6
        '
        'colppv
        '
        Me.colppv.FieldName = "ppv"
        Me.colppv.Name = "colppv"
        Me.colppv.Visible = True
        Me.colppv.VisibleIndex = 7
        '
        'colquantity
        '
        Me.colquantity.FieldName = "quantity"
        Me.colquantity.Name = "colquantity"
        Me.colquantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity", "SUM={0:0.##}")})
        Me.colquantity.Visible = True
        Me.colquantity.VisibleIndex = 8
        '
        'colmean_name
        '
        Me.colmean_name.FieldName = "mean_name"
        Me.colmean_name.Name = "colmean_name"
        Me.colmean_name.Visible = True
        Me.colmean_name.VisibleIndex = 9
        '
        'colproduct_name
        '
        Me.colproduct_name.FieldName = "product_name"
        Me.colproduct_name.Name = "colproduct_name"
        Me.colproduct_name.Visible = True
        Me.colproduct_name.VisibleIndex = 10
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 11
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 12
        '
        'colstn_name
        '
        Me.colstn_name.FieldName = "stn_name"
        Me.colstn_name.Name = "colstn_name"
        Me.colstn_name.Visible = True
        Me.colstn_name.VisibleIndex = 13
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.DateTimePicker2)
        Me.PanelControl1.Controls.Add(Me.DateTimePicker1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1204, 59)
        Me.PanelControl1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 20)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(42, 33)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.Location = New System.Drawing.Point(985, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(207, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(985, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(207, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 59)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1204, 495)
        Me.PanelControl2.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(60, 20)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(54, 34)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "طباعة"
        '
        'OrpakTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 554)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "OrpakTransactions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "حركات اورباك"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colshift_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltimestamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpump As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduct_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colppv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colquantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmean_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduct_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstn_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
