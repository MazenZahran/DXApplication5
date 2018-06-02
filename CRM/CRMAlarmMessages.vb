Public Class CRMAlarmMessages

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged

        If Me.ComboBoxEdit1.Text = "رسالة ايقاف" Then Me.MemoEdit1.Text = My.Settings.StopMessage
        If Me.ComboBoxEdit1.Text = "رسالة تحذير" Then Me.MemoEdit1.Text = My.Settings.AlertMessage

    End Sub

    Private Sub CRMAlarmMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ProgressBarControl1.Properties.Step = 1
        'ProgressBarControl1.Properties.PercentView = True
        'ProgressBarControl1.Properties.Maximum = My.Forms.CRMTasks.GridView1.RowCount - 1
        'ProgressBarControl1.Properties.Minimum = 0
        'LabelControl2.Text = "0"

    End Sub

    'Private Sub dsdsdsd

    '    'Dim child As Form = Nothing
    '    'For Each f As Form In Main.MdiChildren
    '    '    If TypeOf f Is CRMTasks Then
    '    '        child = f
    '    '        f.ActiveControl.Text = AccountID.ToString
    '    '        Exit For
    '    '    End If
    '    'Next f

    '    Try
    '        Dim AcNo, SentNo As Integer
    '        For AcNo = 0 To My.Forms.CRMTasks.GridView1.RowCount - 1

    '            Dim CusID As String = CType(My.Forms.CRMTasks.GridView1.GetRowCellValue(AcNo, "CustID"), String)

    '            Dim CustNo As String = GetAccData(CusID).sphone

    '            If CustNo <> "" Then
    '                ' FunSendSmS2(CustNo, MemoEdit1.Text)
    '                ProgressBarControl1.PerformStep()
    '                ProgressBarControl1.Update()
    '                System.Threading.Thread.Sleep(50)
    '                SentNo = SentNo + 1
    '                LabelControl2.Text = "تم ارسال " + CType(SentNo, String) + " " + "زبون"
    '                MsgBox(LabelControl2.Text)
    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try

    '    MsgBox("jj")
    'End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.ComboBoxEdit1.Text = "رسالة تحذير" Then My.Settings.AlertMessage = Me.MemoEdit1.Text : MsgBox("تم حفظ التعديلات")
        If Me.ComboBoxEdit1.Text = "رسالة ايقاف" Then My.Settings.StopMessage = Me.MemoEdit1.Text : MsgBox("تم حفظ التعديلات")
    End Sub

End Class