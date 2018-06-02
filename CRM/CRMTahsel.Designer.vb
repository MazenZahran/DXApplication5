<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMTahsel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRMTahsel))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.OwnUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerNameText = New DevExpress.XtraEditors.TextEdit()
        Me.TaskIDText = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.OwnUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerNameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskIDText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(293, 307)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(89, 41)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "اغلاق"
        '
        'OwnUserTextEdit
        '
        Me.OwnUserTextEdit.Location = New System.Drawing.Point(12, 354)
        Me.OwnUserTextEdit.Name = "OwnUserTextEdit"
        Me.OwnUserTextEdit.Size = New System.Drawing.Size(370, 20)
        Me.OwnUserTextEdit.TabIndex = 14
        Me.OwnUserTextEdit.Visible = False
        '
        'CustomerNameText
        '
        Me.CustomerNameText.Location = New System.Drawing.Point(112, 7)
        Me.CustomerNameText.Name = "CustomerNameText"
        Me.CustomerNameText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameText.Properties.Appearance.Options.UseFont = True
        Me.CustomerNameText.Properties.AutoHeight = False
        Me.CustomerNameText.Properties.ReadOnly = True
        Me.CustomerNameText.Size = New System.Drawing.Size(270, 41)
        Me.CustomerNameText.TabIndex = 12
        '
        'TaskIDText
        '
        Me.TaskIDText.Location = New System.Drawing.Point(12, 7)
        Me.TaskIDText.Name = "TaskIDText"
        Me.TaskIDText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskIDText.Properties.Appearance.Options.UseFont = True
        Me.TaskIDText.Properties.AutoHeight = False
        Me.TaskIDText.Properties.ReadOnly = True
        Me.TaskIDText.Size = New System.Drawing.Size(94, 41)
        Me.TaskIDText.TabIndex = 13
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 307)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(277, 41)
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "موافق"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(12, 262)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "الرقم"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "اسم المستخدم")})
        Me.LookUpEdit1.Properties.DisplayMember = "UserName"
        Me.LookUpEdit1.Properties.NullText = "اختر المستخدم"
        Me.LookUpEdit1.Properties.ValueMember = "UserID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(370, 28)
        Me.LookUpEdit1.TabIndex = 10
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(12, 52)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.AutoHeight = False
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(370, 40)
        Me.DateEdit1.TabIndex = 9
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(12, 98)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(370, 158)
        Me.TextEdit1.TabIndex = 8
        '
        'CRMTahsel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 389)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.OwnUserTextEdit)
        Me.Controls.Add(Me.CustomerNameText)
        Me.Controls.Add(Me.TaskIDText)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "CRMTahsel"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "CRMTahsel"
        CType(Me.OwnUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerNameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskIDText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OwnUserTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerNameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TaskIDText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.MemoEdit
End Class
