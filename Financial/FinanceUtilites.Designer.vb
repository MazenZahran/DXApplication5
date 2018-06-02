<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceUtilites
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
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AccountKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SortGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.zip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PriceText = New DevExpress.XtraEditors.TextEdit()
        Me.SortNameText = New DevExpress.XtraEditors.TextEdit()
        Me.SortText = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PriceText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SortNameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SortText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1})
        Me.TabPane1.RegularSize = New System.Drawing.Size(986, 495)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(986, 495)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "تغيير سعر الغسيل لتصنيف"
        Me.TabNavigationPage1.Controls.Add(Me.PanelControl2)
        Me.TabNavigationPage1.Controls.Add(Me.PanelControl1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(966, 456)
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 59)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(966, 397)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(37, 18)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "تعديل سعر الغسيل"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(960, 391)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.AccountKey, Me.FullName, Me.SortGroup, Me.zip})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AccountKey
        '
        Me.AccountKey.AppearanceCell.Options.UseTextOptions = True
        Me.AccountKey.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccountKey.AppearanceHeader.Options.UseTextOptions = True
        Me.AccountKey.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccountKey.Caption = "رقم الحساب"
        Me.AccountKey.FieldName = "AccountKey"
        Me.AccountKey.Name = "AccountKey"
        Me.AccountKey.OptionsColumn.AllowEdit = False
        Me.AccountKey.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccountKey", "عدد الحسابات {0}")})
        Me.AccountKey.Visible = True
        Me.AccountKey.VisibleIndex = 0
        '
        'FullName
        '
        Me.FullName.AppearanceCell.Options.UseTextOptions = True
        Me.FullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FullName.AppearanceHeader.Options.UseTextOptions = True
        Me.FullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FullName.Caption = "اسم الحساب"
        Me.FullName.FieldName = "FullName"
        Me.FullName.Name = "FullName"
        Me.FullName.OptionsColumn.AllowEdit = False
        Me.FullName.Visible = True
        Me.FullName.VisibleIndex = 1
        '
        'SortGroup
        '
        Me.SortGroup.AppearanceCell.Options.UseTextOptions = True
        Me.SortGroup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SortGroup.AppearanceHeader.Options.UseTextOptions = True
        Me.SortGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SortGroup.Caption = "التصنيف"
        Me.SortGroup.FieldName = "SortGroup"
        Me.SortGroup.Name = "SortGroup"
        Me.SortGroup.OptionsColumn.AllowEdit = False
        Me.SortGroup.Visible = True
        Me.SortGroup.VisibleIndex = 2
        '
        'zip
        '
        Me.zip.AppearanceCell.Options.UseTextOptions = True
        Me.zip.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.zip.AppearanceHeader.Options.UseTextOptions = True
        Me.zip.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.zip.Caption = "سعر الغسلة"
        Me.zip.FieldName = "zip"
        Me.zip.Name = "zip"
        Me.zip.OptionsColumn.AllowEdit = False
        Me.zip.Visible = True
        Me.zip.VisibleIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.PriceText)
        Me.PanelControl1.Controls.Add(Me.SortNameText)
        Me.PanelControl1.Controls.Add(Me.SortText)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(966, 59)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl2.Location = New System.Drawing.Point(212, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "سعر الغسلة"
        '
        'PriceText
        '
        Me.PriceText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceText.Location = New System.Drawing.Point(143, 20)
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Properties.Mask.BeepOnError = True
        Me.PriceText.Properties.Mask.EditMask = "d"
        Me.PriceText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.PriceText.Size = New System.Drawing.Size(63, 20)
        Me.PriceText.TabIndex = 1
        '
        'SortNameText
        '
        Me.SortNameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SortNameText.Location = New System.Drawing.Point(313, 20)
        Me.SortNameText.Name = "SortNameText"
        Me.SortNameText.Properties.ReadOnly = True
        Me.SortNameText.Size = New System.Drawing.Size(348, 20)
        Me.SortNameText.TabIndex = 1
        '
        'SortText
        '
        Me.SortText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SortText.Location = New System.Drawing.Point(667, 20)
        Me.SortText.Name = "SortText"
        Me.SortText.Size = New System.Drawing.Size(209, 20)
        Me.SortText.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(894, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "التصنيف"
        '
        'FinanceUtilites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 495)
        Me.Controls.Add(Me.TabPane1)
        Me.Name = "FinanceUtilites"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ChangeCarWashPrice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PriceText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SortNameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SortText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SortNameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SortText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AccountKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SortGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents zip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PriceText As DevExpress.XtraEditors.TextEdit
End Class
