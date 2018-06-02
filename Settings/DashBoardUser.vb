Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Xml

Public Class DashBoardUser
    Dim cn As New SqlConnection(CRMString)
    Dim cmd As New SqlCommand
    Dim a As New OpenFileDialog

    Private Sub DashBoardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPic()
        Me.ComputerUserText.Text = Environ("username")
        Me.CopmuterNameText.Text = Environ("computername")
        Me.SystemDetails.Text = Environment.OSVersion.ToString()
        Me.SystemTypeText.Text = Environ("PROCESSOR_ARCHITECTURE")
        GetCurrExchange()
    End Sub

    Private Sub GetPic()

        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT employeesdata.Name as name,job_name,station,start_of_job,LisenceDate,Mobile_no1,Mobile_no2,Phone_no,Email,FaceBook,picture,Birthday,UserLastlogIn  " &
                                      " FROM    employeesdata,users" &
                                      " where employeesdata.EmpID=users.userid and  empid= '" & My.Settings.UserName & "'"
            sql.CRMRunQuery(SQLString)
            LabelControl1.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("name"), String)
            LabelControl2.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("job_name"), String)
            LabelControl4.Text = "تاريخ بداية العمل : " & " " & CType(sql.SQLDS.Tables(0).Rows(i).Item("start_of_job"), String)
            LabelControl6.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("station"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("LisenceDate").ToString <> "" Then LabelControl7.Text = "  تاريخ انتهاء الرخصة : " & " " & CType(sql.SQLDS.Tables(0).Rows(i).Item("LisenceDate"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("Mobile_no1").ToString <> "" Then TextEdit7.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Mobile_no1"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("Mobile_no2").ToString <> "" Then TextEdit6.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Mobile_no2"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("Phone_no").ToString <> "" Then TextEdit5.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Phone_no"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("Email").ToString <> "" Then TextEdit8.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Email"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("LisenceDate").ToString <> "" Then TextEdit9.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("LisenceDate"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("FaceBook").ToString <> "" Then TextEdit9.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("FaceBook"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("LisenceDate").ToString <> "" Then DateEdit1.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("LisenceDate"), String)
            If sql.SQLDS.Tables(0).Rows(i).Item("Birthday").ToString <> "" Then DateTimePicker1.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Birthday"), String) : GetAge()
            If sql.SQLDS.Tables(0).Rows(i).Item("start_of_job").ToString <> "" Then DateTimePicker2.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("start_of_job"), String) : GetWorksAge()

            If sql.SQLDS.Tables(0).Rows(i).Item("picture").ToString <> "" Then
                Dim bytes As [Byte]() = CType(sql.SQLDS.Tables(0).Rows(i).Item("picture"), Byte())
                Dim ms As New MemoryStream(bytes)
                PictureEdit1.Image = Image.FromStream(ms)
            End If

            '  CurrentAgeText.Text = CType(GetCurrentAge(DateTimePicker1.Value), String)
        Catch ex As Exception
            '     PictureEdit1.Image = Nothing

            Exit Sub
        End Try
    End Sub

    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cn.Open()
        If Not PictureEdit1.Image Is Nothing Then
            Dim m As New IO.MemoryStream
            PictureEdit1.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim b() As Byte = m.ToArray()
            SavePhoto(b)
            MsgBox("تم حفظ الصورة")

        End If

        cn.Close()
    End Sub

    Private Sub SavePhoto(ByVal bytPhoto As Byte())

        Dim mmm As String = "UPDATE EmployeesData " &
                    "SET Picture = @photo " &
                    "WHERE EmpID = " & My.Settings.UserName

        Using cmd As New SqlClient.SqlCommand(mmm, cn)

            cmd.Parameters.Add("@photo", SqlDbType.Image, bytPhoto.Length).Value = bytPhoto

            Try
                cmd.ExecuteNonQuery()
            Catch SqlExceptionErr As SqlException
                MessageBox.Show(SqlExceptionErr.Message)
            End Try
        End Using
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        a.Title = "Select your Image."
        a.InitialDirectory = "C:\"
        a.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
        a.RestoreDirectory = False

        If a.ShowDialog() = DialogResult.OK Then
            PictureEdit1.Image = Image.FromFile(a.FileName)
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Dim sql As New SQLControl
        Dim SQLString As String = " update EmployeesData      " &
                                      " set  Mobile_no1= '" & TextEdit7.Text & "'," &
                                      "  Mobile_no2= '" & TextEdit6.Text & "'," &
                                      "  Phone_no= '" & TextEdit5.Text & "'," &
                                      "  Email= '" & TextEdit8.Text & "'," &
                                      "  FaceBook= '" & TextEdit9.Text & "'" &
                                      " where EmpID = '" & My.Settings.UserName & "' "
        sql.CRMRunQuery(SQLString)
        MsgBox("تم التعديل بنجاح")

    End Sub

    Private Sub GetAge()
        Dim dob As DateTime
        dob = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, DateTimePicker1.Value.Day)
        Dim tday As TimeSpan = DateTime.Now.Subtract(dob)
        Dim years As Integer, months As Integer, days As Integer
        months = 12 * (DateTime.Now.Year - dob.Year) + (DateTime.Now.Month - dob.Month)

        If DateTime.Now.Day < dob.Day Then
            months -= 1
            days = DateTime.DaysInMonth(dob.Year, dob.Month) - dob.Day + DateTime.Now.Day
        Else
            days = DateTime.Now.Day - dob.Day
        End If
        years = CInt(Math.Floor(months / 12))
        months -= years * 12
        Me.CurrentAgeText.Text = "عمرك الان " & years & " سنة, " & months & " شهر  " & days & " يوم"
    End Sub

    Private Sub GetWorksAge()
        Dim dob As DateTime
        dob = New DateTime(DateTimePicker2.Value.Year, DateTimePicker2.Value.Month, DateTimePicker2.Value.Day)
        Dim tday As TimeSpan = DateTime.Now.Subtract(dob)
        Dim years As Integer, months As Integer, days As Integer
        months = 12 * (DateTime.Now.Year - dob.Year) + (DateTime.Now.Month - dob.Month)

        If DateTime.Now.Day < dob.Day Then
            months -= 1
            days = DateTime.DaysInMonth(dob.Year, dob.Month) - dob.Day + DateTime.Now.Day
        Else
            days = DateTime.Now.Day - dob.Day
        End If
        years = CInt(Math.Floor(months / 12))
        months -= years * 12
        Me.CurrentWorkAgeText.Text = "عمرك الوظيفي " & years & " سنة, " & months & " شهر  " & days & " يوم"
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        UpdatePassword()

    End Sub

    Private Sub UpdatePassword()
        Try
            If NewPassword2Text.Text <> NewPasswordText.Text Then
                MsgBox("كلمات المرور لا تتطابق ")
                Exit Sub
            ElseIf NewPassword2Text.Text = NewPasswordText.Text Then
                Dim sql As New SQLControl
                Dim SQLString As String = " update users      " &
                                      " set  UserPassword= '" & NewPassword2Text.Text & "'" &
                                      " where UserID = '" & My.Settings.UserName & "' "
                sql.CRMRunQuery(SQLString)
                MsgBox("تم التعديل بنجاح")
                SimpleButton3.Enabled = False
                NewPasswordText.Text = ""
                NewPassword2Text.Text = ""
                OldPasswordText.Text = ""
            End If
        Catch ex As Exception
            '     PictureEdit1.Image = Nothing

            Exit Sub
        End Try
    End Sub

    Private Sub GetOldPassord()
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " select UserPassword    " &
                                      " FROM  users" &
                                      " where UserID = '" & My.Settings.UserName & "'"
            sql.CRMRunQuery(SQLString)
            Dim pass As String = (sql.SQLDS.Tables(0).Rows(i).Item("UserPassword").ToString())

            If OldPasswordText.Text <> pass Then MsgBox("كلمة المرور خطا") : OldPasswordText.BackColor = Color.Red : SimpleButton3.Enabled = False : Exit Sub
            If OldPasswordText.Text = pass And NewPassword2Text.Text = NewPasswordText.Text And NewPassword2Text.Text <> "" Then OldPasswordText.BackColor = DefaultBackColor : SimpleButton3.Enabled = True
        Catch ex As Exception
            '     PictureEdit1.Image = Nothing

            Exit Sub
        End Try
    End Sub

    Private Sub NewPassword2Text_EditValueChanged(sender As Object, e As EventArgs) Handles NewPassword2Text.EditValueChanged

    End Sub

    Private Sub NewPassword2Text_Leave(sender As Object, e As EventArgs) Handles NewPassword2Text.Leave

    End Sub

    Private Sub OldPasswordText_Leave(sender As Object, e As EventArgs) Handles OldPasswordText.Leave
        GetOldPassord()
    End Sub

    Private Sub OldPasswordText_EditValueChanged(sender As Object, e As EventArgs) Handles OldPasswordText.EditValueChanged

    End Sub

    Private Sub ChekFace()

    End Sub

    Private Sub PictureEdit2_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        On Error Resume Next
        Dim idfacebook As String
        SimpleButton4.Enabled = True
        idfacebook = WebBrowser1.Document.GetElementById("code").InnerText
        Dim urlIM As String = "http://graph.facebook.com/" & idfacebook & "/picture?type=square"
        PictureBox1.Load(urlIM)
    End Sub

    Private Sub TextEdit9_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit9.EditValueChanged

    End Sub

    Private Sub TextEdit9_Leave(sender As Object, e As EventArgs) Handles TextEdit9.Leave
        '    ChekFace()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim urlfacebok As String = "https://www.facebook.com/" & TextEdit9.Text
        If TextEdit9.Text = "" Then
            MsgBox("الرجاء كتابة اسم المستخدم")
        Else
            WebBrowser1.Document.GetElementById("input_url").SetAttribute("value", urlfacebok)
            System.Threading.Thread.Sleep(1000)
            WebBrowser1.Document.GetElementById("facebook_lookup_botton").InvokeMember("click")
        End If

    End Sub




    Sub GetCurrExchange()

        Try
            Dim xmlFile As XmlReader
            xmlFile = XmlReader.Create("http://www.boi.org.il/currency.xml", New XmlReaderSettings())
            Dim ds As New DataSet
            ds.ReadXml(xmlFile)
            GridControl2.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        GetCurrExchange()
    End Sub
End Class