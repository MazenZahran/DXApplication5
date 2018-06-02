<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PassTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelLastDate = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.UserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserTextEdit
        '
        Me.UserTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserTextEdit.EditValue = ""
        Me.UserTextEdit.Location = New System.Drawing.Point(157, 253)
        Me.UserTextEdit.Name = "UserTextEdit"
        Me.UserTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.UserTextEdit.Properties.Appearance.Image = CType(resources.GetObject("UserTextEdit.Properties.Appearance.Image"), System.Drawing.Image)
        Me.UserTextEdit.Properties.Appearance.Options.UseFont = True
        Me.UserTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.UserTextEdit.Properties.Appearance.Options.UseImage = True
        Me.UserTextEdit.Properties.AutoHeight = False
        Me.UserTextEdit.Size = New System.Drawing.Size(289, 45)
        Me.UserTextEdit.TabIndex = 2
        '
        'PassTextEdit
        '
        Me.PassTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PassTextEdit.EditValue = ""
        Me.PassTextEdit.Location = New System.Drawing.Point(157, 307)
        Me.PassTextEdit.Name = "PassTextEdit"
        Me.PassTextEdit.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PassTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.PassTextEdit.Properties.Appearance.Image = CType(resources.GetObject("PassTextEdit.Properties.Appearance.Image"), System.Drawing.Image)
        Me.PassTextEdit.Properties.Appearance.Options.UseFont = True
        Me.PassTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.PassTextEdit.Properties.Appearance.Options.UseImage = True
        Me.PassTextEdit.Properties.AppearanceFocused.Image = CType(resources.GetObject("PassTextEdit.Properties.AppearanceFocused.Image"), System.Drawing.Image)
        Me.PassTextEdit.Properties.AppearanceFocused.Options.UseImage = True
        Me.PassTextEdit.Properties.AutoHeight = False
        Me.PassTextEdit.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.PassTextEdit.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PassTextEdit.Properties.UseSystemPasswordChar = True
        Me.PassTextEdit.Size = New System.Drawing.Size(289, 45)
        Me.PassTextEdit.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Gray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelControl1.Size = New System.Drawing.Size(700, 538)
        Me.PanelControl1.TabIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl2.Controls.Add(Me.LabelLastDate)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.PictureBox1)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.UserTextEdit)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.PassTextEdit)
        Me.PanelControl2.Location = New System.Drawing.Point(38, 25)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(621, 501)
        Me.PanelControl2.TabIndex = 3
        '
        'LabelLastDate
        '
        Me.LabelLastDate.Appearance.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelLastDate.Appearance.Options.UseForeColor = True
        Me.LabelLastDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelLastDate.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelLastDate.Location = New System.Drawing.Point(29, 374)
        Me.LabelLastDate.Name = "LabelLastDate"
        Me.LabelLastDate.Size = New System.Drawing.Size(548, 33)
        Me.LabelLastDate.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(45, 431)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(182, 36)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "خروج"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(157, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Appearance.Options.UseBorderColor = True
        Me.LabelControl2.Appearance.Options.UseImage = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.LabelControl2.Location = New System.Drawing.Point(452, 304)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 48)
        Me.LabelControl2.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.Options.UseBorderColor = True
        Me.LabelControl1.Appearance.Options.UseImage = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(452, 258)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 40)
        Me.LabelControl1.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Traditional Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(29, 358)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(549, 10)
        Me.LabelControl3.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 538)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PassTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelLastDate As DevExpress.XtraEditors.LabelControl
End Class
