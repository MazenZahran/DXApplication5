Public Class CRMEditTaskDate

    Private Sub CRMEditTaskDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.CRMDataSet.Users)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If CType(DateEdit1.EditValue, String) = "" Then MsgBox("التاريخ فارغ") : Exit Sub

            Dim AccrualDate As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")
            Dim ToUser As String = CStr(LookUpEdit1.EditValue)
            Dim result As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد تأجيل المهمة", "تأكيد", MessageBoxButtons.YesNo)

            If result = System.Windows.Forms.DialogResult.Yes Then


                Dim SQLUpdateDate As String = "Update [CRM].[dbo].[CRMTasks]  set [Importance]='2' ,  [AccrualDate] = '" & AccrualDate & "' ,  [ToUser]= '" & ToUser & "', [Note]= '" & Me.TextEdit1.Text & "'" &
                "  where [TaskID]= " & TaskIDText.Text

                Dim SQLInserJob As String = "INSERT INTO [CRM].[dbo].[CRMTasksJobs]
                                                           ([AccountID]
                                                           ,[AccountName]
                                                           ,[Employee]
                                                           ,[JobDate]
                                                           ,[JobDetails])
                                                     VALUES
                                                           ('" & CustomerCodeText.Text & "'
                                                           ,'" & CustomerNameText.Text & "'
                                                           , '" & My.Settings.UserName & "'
                                                           , '" & AccrualDate & "'
                                                           , '" & TextEdit1.Text & "')  "

                Dim sql2 As New SQLControl
                sql2.CRMRunQuery(SQLUpdateDate)
                Dim sql3 As New SQLControl
                sql3.CRMRunQuery(SQLInserJob)
                Me.Close()
                '   DevExpress.XtraEditors.XtraMessageBox.Show("تم", "تأكيد", MessageBoxButtons.OK)
                My.Forms.CRMTasks.LoadData(OwnUserTextEdit.Text, My.Forms.CRMTasks.TaskMonthText.Text, My.Forms.CRMTasks.TaskStatusText.Text, My.Forms.CRMTasks.TaskTypeCombo.Text)
                My.Forms.CRMTasks.CreatTableSummery()

            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("خطا: لا يمكن تنفيذ الأمر")
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If CType(DateEdit1.EditValue, String) = "" Then MsgBox("التاريخ فارغ") : Exit Sub

            Dim AccrualDate As String = CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd"))
            Dim ToUser As String = CStr(LookUpEdit1.EditValue)
            Dim result As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد تأجيل المهمة", "تأكيد", MessageBoxButtons.YesNo)

            If result = System.Windows.Forms.DialogResult.Yes Then

                Dim sql2 As New SQLControl
                Dim SQLUpdateDate As String = "Update [CRM].[dbo].[CRMTasks]  set [AccrualDate] = '" & AccrualDate & "' ,  [ToUser]= '" & ToUser & "', [Note]= '" & Me.TextEdit1.Text & "'" & ", [NoteStatus]= 'مغلقة'" &
                                              " where [TaskID]= " & TaskIDText.Text

                sql2.CRMRunQuery(SQLUpdateDate)
                Me.Close()
                '   DevExpress.XtraEditors.XtraMessageBox.Show("تم", "تأكيد", MessageBoxButtons.OK)
                My.Forms.CRMTasks.LoadData(OwnUserTextEdit.Text, My.Forms.CRMTasks.TaskMonthText.Text, My.Forms.CRMTasks.TaskStatusText.Text, My.Forms.CRMTasks.TaskTypeCombo.Text)
                My.Forms.CRMTasks.CreatTableSummery()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("خطا: لا يمكن تنفيذ الأمر")
        End Try
    End Sub

    'Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
    '    Try
    '        If CType(DateEdit1.EditValue, String) = "" Then MsgBox("التاريخ فارغ") : Exit Sub

    '        Dim AccrualDate As String = CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd"))
    '        Dim ToUser As String = CStr(LookUpEdit1.EditValue)
    '        Dim result As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد تأجيل المهمة", "تأكيد", MessageBoxButtons.YesNo)

    '        If result = System.Windows.Forms.DialogResult.Yes Then

    '            Dim sql2 As New SQLControl
    '            Dim SQLUpdateDate As String = "Update [CRM].[dbo].[CRMTasks]  set [AccrualDate] = '" & AccrualDate & "' ,  [ToUser]= '" & ToUser & "', [Note]= '" & Me.TextEdit1.Text & "'" & ", [NoteStatus]= 'مغلقة'" &
    '                                          " where [TaskID]= " & TaskIDText.Text

    '            sql2.CRMRunQuery(SQLUpdateDate)
    '            Me.Close()
    '            '   DevExpress.XtraEditors.XtraMessageBox.Show("تم", "تأكيد", MessageBoxButtons.OK)
    '            My.Forms.CRMTasks.LoadData(OwnUserTextEdit.Text, My.Forms.CRMTasks.TaskMonthText.Text, My.Forms.CRMTasks.TaskStatusText.Text, My.Forms.CRMTasks.TaskTypeCombo.Text)
    '            My.Forms.CRMTasks.CreatTableSummery()
    '        Else
    '            Exit Sub
    '        End If
    '    Catch ex As Exception
    '        MsgBox("خطا: لا يمكن تنفيذ الأمر")
    '    End Try
    'End Sub

End Class