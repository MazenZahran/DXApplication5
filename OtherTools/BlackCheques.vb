Imports System.Data.SqlClient
Public Class BlackCheques



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)


    End Sub


    Private Function DoesUserHavePermission() As Boolean
        Try
            Dim clientPermission As SqlClientPermission = New SqlClientPermission(Security.Permissions.PermissionState.Unrestricted)
            ' this will throw an error if the user does not have the permissions
            clientPermission.Demand()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Sub GetNames()
        If Not DoesUserHavePermission() Then
            Return
        End If

        '  lbNames.Items.Clear()

        ' You must stop the dependency before starting a new one.
        ' You must start the dependency when creating a new one.
        SqlDependency.Stop(CheuqesString)
        SqlDependency.Start(CheuqesString)

        Using cn As SqlConnection = New SqlConnection(CheuqesString)

            Using cmd As SqlCommand = cn.CreateCommand()

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT IB_BANK_ID,IB_BRANCH_ID,CHECK_NO,ACCOUNT_NO FROM [ClearingSystem].[dbo].[BlackChecks] where RUN_DATE='" & Format(Today, "dd/MM/yyyy") & "'"

                cmd.Notification = Nothing

                ' creates a new dependency for the SqlCommand
                Dim dep As SqlDependency = New SqlDependency(cmd)
                ' creates an event handler for the notification of data changes in the database
                AddHandler dep.OnChange, AddressOf dep_onchange

                cn.Open()

                Using dr As SqlDataReader = cmd.ExecuteReader()

                    '   While dr.Read()

                    '  lbNames.Items.Add(dr.GetString(0) & " " & dr.GetString(1))
                    Dim DataTable = New DataTable()
                    DataTable.Load(dr)

                    GridControl1.DataSource = DataTable
                    TextEdit1.EditValue = GridView1.RowCount
                    ' End While

                End Using

            End Using

        End Using
    End Sub

    Private Sub dep_onchange(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlNotificationEventArgs)

        ' this event is run asynchronously so you will need to invoke to run on the UI thread(if required)
        If Me.InvokeRequired Then
            GridControl1.BeginInvoke(New MethodInvoker(AddressOf GetNames))
        Else
            GetNames()
        End If

        ' this will remove the event handler since the dependency is only for a single notification
        Dim dep As SqlDependency = DirectCast(sender, SqlDependency)
        RemoveHandler dep.OnChange, AddressOf dep_onchange

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        SqlDependency.Stop(CheuqesString)

    End Sub

    Private Sub BlackCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetNames()

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        My.Computer.Audio.Play(My.Resources.rejectedcheq,
       AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class