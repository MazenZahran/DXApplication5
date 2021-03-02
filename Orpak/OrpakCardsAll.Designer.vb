<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrpakCardsAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrpakCardsAll))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfleets_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfleets_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colplate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstring = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colissued_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collast_used = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdate_timestamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmonth_money = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmonth_volume = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmonth_visits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GridControl1.DataMember = "means"
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GridControl1.Size = New System.Drawing.Size(1502, 537)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcode, Me.colfleets_name, Me.colfleets_status, Me.coltype, Me.colstatus, Me.colname, Me.colplate, Me.colstring, Me.coldescription, Me.colissued_date, Me.collast_used, Me.colupdate_timestamp, Me.colmonth_money, Me.colmonth_volume, Me.colmonth_visits})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "plate", Me.colplate, "عدد البطاقات {0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "status", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AllowCellMerge = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colcode
        '
        Me.colcode.Caption = "رقم الزبون"
        Me.colcode.FieldName = "code"
        Me.colcode.Name = "colcode"
        Me.colcode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colcode.OptionsEditForm.StartNewRow = True
        Me.colcode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.colcode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "code", "عدد الزبائن {0}")})
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 0
        '
        'colfleets_name
        '
        Me.colfleets_name.Caption = "الزبون"
        Me.colfleets_name.FieldName = "fleets_name"
        Me.colfleets_name.Name = "colfleets_name"
        Me.colfleets_name.Visible = True
        Me.colfleets_name.VisibleIndex = 1
        '
        'colfleets_status
        '
        Me.colfleets_status.AppearanceCell.Options.UseImage = True
        Me.colfleets_status.Caption = "حالة الزبون"
        Me.colfleets_status.FieldName = "fleets_status"
        Me.colfleets_status.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
        Me.colfleets_status.Name = "colfleets_status"
        Me.colfleets_status.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colfleets_status.Visible = True
        Me.colfleets_status.VisibleIndex = 2
        '
        'coltype
        '
        Me.coltype.Caption = "نوع البطاقة"
        Me.coltype.FieldName = "type"
        Me.coltype.Name = "coltype"
        Me.coltype.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.coltype.Visible = True
        Me.coltype.VisibleIndex = 3
        '
        'colstatus
        '
        Me.colstatus.AppearanceCell.Options.UseImage = True
        Me.colstatus.AppearanceCell.Options.UseTextOptions = True
        Me.colstatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colstatus.Caption = "حالة البطاقة"
        Me.colstatus.FieldName = "status"
        Me.colstatus.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
        Me.colstatus.Name = "colstatus"
        Me.colstatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 4
        '
        'colname
        '
        Me.colname.Caption = "رقم البطاقة"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colname.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.colname.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "{0}")})
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 5
        '
        'colplate
        '
        Me.colplate.Caption = "المركبة"
        Me.colplate.FieldName = "plate"
        Me.colplate.Name = "colplate"
        Me.colplate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colplate.Visible = True
        Me.colplate.VisibleIndex = 6
        '
        'colstring
        '
        Me.colstring.Caption = "كود"
        Me.colstring.FieldName = "string"
        Me.colstring.Name = "colstring"
        Me.colstring.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[False]
        Me.colstring.Visible = True
        Me.colstring.VisibleIndex = 7
        '
        'coldescription
        '
        Me.coldescription.Caption = "السقف"
        Me.coldescription.FieldName = "description"
        Me.coldescription.Name = "coldescription"
        Me.coldescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.coldescription.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "description", "{0}")})
        Me.coldescription.Visible = True
        Me.coldescription.VisibleIndex = 8
        '
        'colissued_date
        '
        Me.colissued_date.Caption = "تاريخ الاصدار"
        Me.colissued_date.FieldName = "issued_date"
        Me.colissued_date.Name = "colissued_date"
        Me.colissued_date.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colissued_date.Visible = True
        Me.colissued_date.VisibleIndex = 9
        '
        'collast_used
        '
        Me.collast_used.Caption = "اخر استخدام"
        Me.collast_used.FieldName = "last_used"
        Me.collast_used.Name = "collast_used"
        Me.collast_used.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.collast_used.Visible = True
        Me.collast_used.VisibleIndex = 10
        '
        'colupdate_timestamp
        '
        Me.colupdate_timestamp.Caption = "اخر تعديل "
        Me.colupdate_timestamp.FieldName = "update_timestamp"
        Me.colupdate_timestamp.Name = "colupdate_timestamp"
        Me.colupdate_timestamp.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colupdate_timestamp.Visible = True
        Me.colupdate_timestamp.VisibleIndex = 11
        '
        'colmonth_money
        '
        Me.colmonth_money.Caption = "سحوبات الشهر شيكل"
        Me.colmonth_money.FieldName = "month_money"
        Me.colmonth_money.Name = "colmonth_money"
        Me.colmonth_money.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colmonth_money.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.GreaterOrEqual
        Me.colmonth_money.Visible = True
        Me.colmonth_money.VisibleIndex = 12
        '
        'colmonth_volume
        '
        Me.colmonth_volume.Caption = "سحوبات الشهر لتر"
        Me.colmonth_volume.FieldName = "month_volume"
        Me.colmonth_volume.Name = "colmonth_volume"
        Me.colmonth_volume.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colmonth_volume.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.GreaterOrEqual
        Me.colmonth_volume.Visible = True
        Me.colmonth_volume.VisibleIndex = 13
        '
        'colmonth_visits
        '
        Me.colmonth_visits.Caption = "زيارات الشهر"
        Me.colmonth_visits.FieldName = "month_visits"
        Me.colmonth_visits.Name = "colmonth_visits"
        Me.colmonth_visits.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colmonth_visits.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.GreaterOrEqual
        Me.colmonth_visits.Visible = True
        Me.colmonth_visits.VisibleIndex = 14
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelControl1.Size = New System.Drawing.Size(1506, 63)
        Me.PanelControl1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1429, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(72, 36)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "طباعة"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 63)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1506, 541)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(1348, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 34)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'OrpakCardsAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1506, 604)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "OrpakCardsAll"
        Me.Text = "تقرير كل البطاقات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colissued_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonth_money As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonth_volume As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonth_visits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colplate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfleets_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfleets_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdate_timestamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
