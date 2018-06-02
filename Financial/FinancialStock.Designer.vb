<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinancialStock
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditFrom = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditTo = New DevExpress.XtraEditors.DateEdit()
        Me.FromWhereHouse = New DevExpress.XtraEditors.TextEdit()
        Me.ToWhereHouse = New DevExpress.XtraEditors.TextEdit()
        Me.FromStock = New DevExpress.XtraEditors.TextEdit()
        Me.ToStock = New DevExpress.XtraEditors.TextEdit()
        Me.Accfrom = New DevExpress.XtraEditors.TextEdit()
        Me.AccTo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromWhereHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToWhereHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.AccTo)
        Me.PanelControl1.Controls.Add(Me.Accfrom)
        Me.PanelControl1.Controls.Add(Me.ToStock)
        Me.PanelControl1.Controls.Add(Me.FromStock)
        Me.PanelControl1.Controls.Add(Me.ToWhereHouse)
        Me.PanelControl1.Controls.Add(Me.FromWhereHouse)
        Me.PanelControl1.Controls.Add(Me.DateEditTo)
        Me.PanelControl1.Controls.Add(Me.DateEditFrom)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1101, 70)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 70)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1101, 446)
        Me.PanelControl2.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1097, 442)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 24)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(115, 42)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'DateEditFrom
        '
        Me.DateEditFrom.EditValue = Nothing
        Me.DateEditFrom.Location = New System.Drawing.Point(851, 8)
        Me.DateEditFrom.Name = "DateEditFrom"
        Me.DateEditFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditFrom.Size = New System.Drawing.Size(208, 20)
        Me.DateEditFrom.TabIndex = 1
        '
        'DateEditTo
        '
        Me.DateEditTo.EditValue = Nothing
        Me.DateEditTo.Location = New System.Drawing.Point(851, 34)
        Me.DateEditTo.Name = "DateEditTo"
        Me.DateEditTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTo.Size = New System.Drawing.Size(208, 20)
        Me.DateEditTo.TabIndex = 1
        '
        'FromWhereHouse
        '
        Me.FromWhereHouse.Location = New System.Drawing.Point(680, 5)
        Me.FromWhereHouse.Name = "FromWhereHouse"
        Me.FromWhereHouse.Size = New System.Drawing.Size(125, 20)
        Me.FromWhereHouse.TabIndex = 2
        '
        'ToWhereHouse
        '
        Me.ToWhereHouse.Location = New System.Drawing.Point(680, 31)
        Me.ToWhereHouse.Name = "ToWhereHouse"
        Me.ToWhereHouse.Size = New System.Drawing.Size(125, 20)
        Me.ToWhereHouse.TabIndex = 2
        '
        'FromStock
        '
        Me.FromStock.Location = New System.Drawing.Point(529, 5)
        Me.FromStock.Name = "FromStock"
        Me.FromStock.Size = New System.Drawing.Size(125, 20)
        Me.FromStock.TabIndex = 2
        '
        'ToStock
        '
        Me.ToStock.Location = New System.Drawing.Point(529, 31)
        Me.ToStock.Name = "ToStock"
        Me.ToStock.Size = New System.Drawing.Size(125, 20)
        Me.ToStock.TabIndex = 2
        '
        'Accfrom
        '
        Me.Accfrom.Location = New System.Drawing.Point(382, 5)
        Me.Accfrom.Name = "Accfrom"
        Me.Accfrom.Size = New System.Drawing.Size(125, 20)
        Me.Accfrom.TabIndex = 2
        '
        'AccTo
        '
        Me.AccTo.Location = New System.Drawing.Point(382, 31)
        Me.AccTo.Name = "AccTo"
        Me.AccTo.Size = New System.Drawing.Size(125, 20)
        Me.AccTo.TabIndex = 2
        '
        'FinancialStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 516)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FinancialStock"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "FinancialStock"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromWhereHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToWhereHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DateEditTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ToWhereHouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FromWhereHouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FromStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Accfrom As DevExpress.XtraEditors.TextEdit
End Class
