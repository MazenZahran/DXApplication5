<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMEditTaskDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRMEditTaskDate))
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMDataSet = New DXApplication5.CRMDataSet()
        Me.UsersTableAdapter = New DXApplication5.CRMDataSetTableAdapters.UsersTableAdapter()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TaskIDText = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerNameText = New DevExpress.XtraEditors.TextEdit()
        Me.OwnUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.CustomerCodeText = New DevExpress.XtraEditors.TextEdit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskIDText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerNameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerCodeText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(57, 56)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.AutoHeight = False
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(418, 40)
        Me.DateEdit1.TabIndex = 2
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(57, 102)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(418, 158)
        Me.TextEdit1.TabIndex = 1
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(57, 266)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "الرقم"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "اسم المستخدم")})
        Me.LookUpEdit1.Properties.DataSource = Me.UsersBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "UserName"
        Me.LookUpEdit1.Properties.NullText = "اختر المستخدم"
        Me.LookUpEdit1.Properties.ValueMember = "UserID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(418, 28)
        Me.LookUpEdit1.TabIndex = 3
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.CRMDataSet
        '
        'CRMDataSet
        '
        Me.CRMDataSet.DataSetName = "CRMDataSet"
        Me.CRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(57, 311)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(325, 41)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "موافق"
        '
        'TaskIDText
        '
        Me.TaskIDText.Location = New System.Drawing.Point(12, 12)
        Me.TaskIDText.Name = "TaskIDText"
        Me.TaskIDText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskIDText.Properties.Appearance.Options.UseFont = True
        Me.TaskIDText.Properties.AutoHeight = False
        Me.TaskIDText.Properties.ReadOnly = True
        Me.TaskIDText.Size = New System.Drawing.Size(43, 41)
        Me.TaskIDText.TabIndex = 5
        Me.TaskIDText.Visible = False
        '
        'CustomerNameText
        '
        Me.CustomerNameText.Location = New System.Drawing.Point(205, 11)
        Me.CustomerNameText.Name = "CustomerNameText"
        Me.CustomerNameText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameText.Properties.Appearance.Options.UseFont = True
        Me.CustomerNameText.Properties.AutoHeight = False
        Me.CustomerNameText.Properties.ReadOnly = True
        Me.CustomerNameText.Size = New System.Drawing.Size(270, 41)
        Me.CustomerNameText.TabIndex = 5
        '
        'OwnUserTextEdit
        '
        Me.OwnUserTextEdit.Location = New System.Drawing.Point(57, 358)
        Me.OwnUserTextEdit.Name = "OwnUserTextEdit"
        Me.OwnUserTextEdit.Size = New System.Drawing.Size(418, 20)
        Me.OwnUserTextEdit.TabIndex = 6
        Me.OwnUserTextEdit.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(386, 311)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(89, 41)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "اغلاق"
        '
        'CustomerCodeText
        '
        Me.CustomerCodeText.Location = New System.Drawing.Point(57, 12)
        Me.CustomerCodeText.Name = "CustomerCodeText"
        Me.CustomerCodeText.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerCodeText.Properties.Appearance.Options.UseFont = True
        Me.CustomerCodeText.Properties.AutoHeight = False
        Me.CustomerCodeText.Properties.ReadOnly = True
        Me.CustomerCodeText.Size = New System.Drawing.Size(142, 41)
        Me.CustomerCodeText.TabIndex = 8
        '
        'CRMEditTaskDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 389)
        Me.Controls.Add(Me.CustomerCodeText)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.OwnUserTextEdit)
        Me.Controls.Add(Me.CustomerNameText)
        Me.Controls.Add(Me.TaskIDText)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "CRMEditTaskDate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تأجيل / تحويل الموعد"
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskIDText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerNameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerCodeText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CRMDataSet As CRMDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As CRMDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TaskIDText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerNameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OwnUserTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CustomerCodeText As DevExpress.XtraEditors.TextEdit
End Class
