Imports System.Data.SqlClient
Imports System.IO

Public Class Login
    Private Sub UserTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles UserTextEdit.EditValueChanged
        GetPic()
    End Sub
    Private Sub GetPic()
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT employeesdata.Name as name,picture,UserLastlogIn  " &
                                      " FROM    employeesdata,users" &
                                      " where employeesdata.EmpID=users.userid and  empid= '" & Me.UserTextEdit.Text & "'"
            sql.CRMRunQuery(SQLString)
            Dim LastDate As String
            LastDate = CType(sql.SQLDS.Tables(0).Rows(i).Item("UserLastlogIn"), String)
            LabelLastDate.Text = " اهلا " + CType(sql.SQLDS.Tables(0).Rows(i).Item("name"), String) + " اخر تسجيل دخول كان في  " + " " + LastDate

            If sql.SQLDS.Tables(0).Rows(i).Item("picture").ToString <> "" Then
                Dim bytes As [Byte]() = CType(sql.SQLDS.Tables(0).Rows(i).Item("picture"), Byte())
                Dim ms As New MemoryStream(bytes)
                PictureBox1.Image = Image.FromStream(ms)
            End If
            Me.PassTextEdit.Select()
        Catch ex As Exception
            PictureBox1.Image = Nothing
            LabelLastDate.Text = ""
            Exit Sub
        End Try
    End Sub

    Private Sub Password()
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT UserPassword   " &
                                      " FROM  users" &
                                      " where users.userid = '" & Me.UserTextEdit.Text & "'"
            sql.CRMRunQuery(SQLString)
            Dim PassWord As String
            PassWord = CType(sql.SQLDS.Tables(0).Rows(i).Item("UserPassword"), String)

            If Me.PassTextEdit.Text = PassWord Then
                UpdateLastDate()
                InsertLogs()
                My.Settings.DeviceName = Environ("computername")
                My.Settings.UserName = Me.UserTextEdit.Text
                My.Forms.Main.EnableRibbon()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateLastDate()
        Dim sql As New SQLControl
        Dim SQLString As String = " Update Users " &
                                      " Set userdevice= '" & Environ("computername") & " ' , UserLastlogIn= CONVERT(DATETIME, '" & Format(Now(), "yyyy-MM-dd hh:mm:ss") & " ', 102)" &
                                      " where users.userid = '" & Me.UserTextEdit.Text & "'"
        sql.CRMRunQuery(SQLString)
    End Sub

    Private Sub InsertLogs()
        Dim sql As New SQLControl
        Dim SQLString2 As String = " insert into UserslogInLogs (userid,lastdate,devicename) values ( "
        SQLString2 = SQLString2 + "'" & Me.UserTextEdit.Text & "', "
        SQLString2 = SQLString2 + " CONVERT(DATETIME, '" & Format(Now(), "yyyy-MM-dd hh:mm:ss") & " ', 102)" & ", "
        SQLString2 = SQLString2 + "'" & Environ("computername") & "'"
        SQLString2 = SQLString2 + ")"
        sql.CRMRunQuery(SQLString2)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Application.Exit()
    End Sub

    Private Sub PassTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PassTextEdit.EditValueChanged
        Password()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT userid   " &
                                      " FROM  users" &
                                      " where userdevice = '" & Environ("computername") & "'"
            sql.CRMRunQuery(SQLString)
            Me.UserTextEdit.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("userid"), String)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Password()
    End Sub
End Class