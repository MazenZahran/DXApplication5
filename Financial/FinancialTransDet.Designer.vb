<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancialTransDet
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
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialTransDet))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTransDebID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransCredID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDebName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCredName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsuF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRef2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "JurnalTrans"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(956, 261)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "WizcountConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "TransDebID"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""742"" />"
        Table1.Name = "JurnalTrans"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "TransCredID"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "DebName"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "CredName"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "BatchNo"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Description"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "ValueDate"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "DueDate"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "suF"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "Ref2"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
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
        SelectQuery1.FilterString = "[JurnalTrans.Ref2] = ?Parameter1 And [JurnalTrans.ValueDate] = ?Parameter2"
        SelectQuery1.GroupFilterString = ""
        SelectQuery1.Name = "JurnalTrans"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(Integer)
        QueryParameter1.ValueInfo = "0"
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(Date)
        QueryParameter2.ValueInfo = "1753-01-01"
        SelectQuery1.Parameters.Add(QueryParameter1)
        SelectQuery1.Parameters.Add(QueryParameter2)
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransDebID, Me.colTransCredID, Me.colDebName, Me.colCredName, Me.colBatchNo, Me.colDescription, Me.colValueDate, Me.colDueDate, Me.colsuF, Me.colRef2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colTransDebID
        '
        Me.colTransDebID.Caption = "مدين"
        Me.colTransDebID.FieldName = "TransDebID"
        Me.colTransDebID.Name = "colTransDebID"
        Me.colTransDebID.Visible = True
        Me.colTransDebID.VisibleIndex = 0
        Me.colTransDebID.Width = 91
        '
        'colTransCredID
        '
        Me.colTransCredID.Caption = "دائن"
        Me.colTransCredID.FieldName = "TransCredID"
        Me.colTransCredID.Name = "colTransCredID"
        Me.colTransCredID.Visible = True
        Me.colTransCredID.VisibleIndex = 1
        Me.colTransCredID.Width = 91
        '
        'colDebName
        '
        Me.colDebName.Caption = "الحساب المدين"
        Me.colDebName.FieldName = "DebName"
        Me.colDebName.Name = "colDebName"
        Me.colDebName.Visible = True
        Me.colDebName.VisibleIndex = 2
        Me.colDebName.Width = 91
        '
        'colCredName
        '
        Me.colCredName.Caption = "الحساب الدائن"
        Me.colCredName.FieldName = "CredName"
        Me.colCredName.Name = "colCredName"
        Me.colCredName.Visible = True
        Me.colCredName.VisibleIndex = 3
        Me.colCredName.Width = 91
        '
        'colBatchNo
        '
        Me.colBatchNo.Caption = "الدفتر"
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 4
        Me.colBatchNo.Width = 91
        '
        'colDescription
        '
        Me.colDescription.Caption = "البيان"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        Me.colDescription.Width = 150
        '
        'colValueDate
        '
        Me.colValueDate.Caption = "تاريخ الحركة"
        Me.colValueDate.FieldName = "ValueDate"
        Me.colValueDate.Name = "colValueDate"
        Me.colValueDate.Visible = True
        Me.colValueDate.VisibleIndex = 6
        Me.colValueDate.Width = 76
        '
        'colDueDate
        '
        Me.colDueDate.Caption = "تاريخ الاستحقاق"
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 7
        Me.colDueDate.Width = 76
        '
        'colsuF
        '
        Me.colsuF.Caption = "المبلغ"
        Me.colsuF.FieldName = "suF"
        Me.colsuF.Name = "colsuF"
        Me.colsuF.Visible = True
        Me.colsuF.VisibleIndex = 8
        Me.colsuF.Width = 76
        '
        'colRef2
        '
        Me.colRef2.Caption = "مرجع2"
        Me.colRef2.FieldName = "Ref2"
        Me.colRef2.Name = "colRef2"
        Me.colRef2.Visible = True
        Me.colRef2.VisibleIndex = 9
        Me.colRef2.Width = 77
        '
        'FinancialTransDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 261)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FinancialTransDet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تفاصيل حركة"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTransDebID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransCredID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsuF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRef2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
