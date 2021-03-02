Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports DevExpress.XtraReports.UI

Structure AccountData
    Dim FullNamee As String
    Dim Addresss As String
    Dim City As String
    Dim Zip As String
    Dim Country As String
    Dim PHONE As String
    Dim Fax As String
    Dim Filter As String
    Dim sphone As String
    Dim email As String
    Dim Details As String
    Dim costcode As String
    Dim SortGroup As String
End Structure

Module MyFunctions
    Dim cn As New SqlConnection(OrbakString)
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim i As Integer
    Dim SQlText As String
    Dim sql As New SQLControl

    Public Sub Mmemory()

    End Sub

    Function GetAccData(AccID As String) As AccountData
        Dim cn As New SqlConnection(OrbakString)
        Dim DataArray As AccountData

        Dim SqlString As String = " select [AccountKey],[FullName] ,[SortGroup],[Address],[City],[Zip],[Country],[Phone],[Fax],[filter],[sphone],[email]," _
                                & " [details],[costcode] FROM [ALHUDA].[dbo].[Accounts] where   [AccountKey] = '" & AccID & "'"

        sql.WizCountRunQuery(SqlString)

        With DataArray
            For Each i As Object In sql.SQLDS.Tables(0).Rows
#Disable Warning BC42017 ' Late bound resolution
                DataArray.FullNamee = (i.item("FullName").ToString)
                DataArray.SortGroup = (i.item("SortGroup").ToString)
                DataArray.Addresss = (i.item("Address").ToString)
                DataArray.City = (i.item("City").ToString)
                DataArray.Zip = (i.item("Zip").ToString)
                DataArray.Country = (i.item("Country").ToString)
                DataArray.PHONE = (i.item("PHONE").ToString)
                DataArray.Fax = (i.item("Fax").ToString)
                DataArray.Filter = (i.item("Filter").ToString)
                DataArray.sphone = (i.item("sphone").ToString)
                DataArray.email = (i.item("email").ToString)
                DataArray.Details = (i.item("Details").ToString)
                DataArray.costcode = (i.item("costcode").ToString)
#Enable Warning BC42017 ' Late bound resolution
            Next
        End With

#Disable Warning BC42109 ' Variable is used before it has been assigned a value
        GetAccData = DataArray
#Enable Warning BC42109 ' Variable is used before it has been assigned a value

    End Function

    Function FunSendSmS2(destination As String, sms As String) As String
        If CInt(GetSMSBalance()) = 0 Then MsgBox("لا يوجد رصيد") : Return "لا يوجد رصيد" : Exit Function
        destination = CType(Val(destination), String)

        Select Case Len(destination)
            Case 9
                destination = "972" & destination
            Case 12
                destination = destination
            Case Else
                Return "خطا بالرقم"
        End Select

        Dim strUrl As String = "http://sms.zone.ps/API/SendSMS.aspx?id=771b1fe76febcab8618c7356d6e884f7&sender=Alhuda&to= " & destination & "&msg=" & sms & ""

        Dim request As WebRequest = HttpWebRequest.Create(strUrl)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        Dim s As Stream = DirectCast(response.GetResponseStream(), Stream)
        Dim readStream As New StreamReader(s)
        Dim dataString As String = readStream.ReadToEnd()
        Dim Result As String = dataString.ToString
        response.Close()
        s.Close()
        readStream.Close()
        Return Result
    End Function

    Function NoToTxt(ByVal TheNo As Double, ByVal MyCur As String, ByVal MySubCur As String) As String
        Dim MyArry1(0 To 9) As String
        Dim MyArry2(0 To 9) As String
        Dim MyArry3(0 To 9) As String
        Dim MyNo As String = ""
        Dim GetNo As String = ""
        Dim RdNo As String = ""
        Dim My100 As String = ""
        Dim My10 As String = ""
        Dim My1 As String = ""
        Dim My11 As String = ""
        Dim My12 As String = ""
        Dim GetTxt As String = ""
        Dim Mybillion As String = ""
        Dim MyMillion As String = ""
        Dim MyThou As String = ""
        Dim MyHun As String = ""
        Dim MyFraction As String = ""
        Dim MyAnd As String = ""
        Dim i As Integer
        Dim ReMark As String = ""

        If TheNo > 999999999999.99 Then

        End If

        If TheNo = 0 Then
            NoToTxt = "صفر"
            Exit Function
        End If

        MyAnd = " و"
        MyArry1(0) = ""
        MyArry1(1) = "مائة"
        MyArry1(2) = "مائتان"
        MyArry1(3) = "ثلاثمائة"
        MyArry1(4) = "أربعمائة"
        MyArry1(5) = "خمسمائة"
        MyArry1(6) = "ستمائة"
        MyArry1(7) = "سبعمائة"
        MyArry1(8) = "ثمانمائة"
        MyArry1(9) = "تسعمائة"

        MyArry2(0) = ""
        MyArry2(1) = " عشر"
        MyArry2(2) = "عشرون"
        MyArry2(3) = "ثلاثون"
        MyArry2(4) = "أربعون"
        MyArry2(5) = "خمسون"
        MyArry2(6) = "ستون"
        MyArry2(7) = "سبعون"
        MyArry2(8) = "ثمانون"
        MyArry2(9) = "تسعون"

        MyArry3(0) = ""
        MyArry3(1) = "واحد"
        MyArry3(2) = "اثنان"
        MyArry3(3) = "ثلاثة"
        MyArry3(4) = "أربعة"
        MyArry3(5) = "خمسة"
        MyArry3(6) = "ستة"
        MyArry3(7) = "سبعة"
        MyArry3(8) = "ثمانية"
        MyArry3(9) = "تسعة"
        '======================
        GetNo = Format(TheNo, "000000000000.00")

        i = 0
        Do While i < 15

            If i < 12 Then
                MyNo = Mid$(GetNo, i + 1, 3)
            Else
                MyNo = "0" + Mid$(GetNo, i + 2, 2)
            End If

            If CInt((Mid$(MyNo, 1, 3))) > 0 Then

                RdNo = Mid$(MyNo, 1, 1)
                My100 = MyArry1(CInt(RdNo))
                RdNo = Mid$(MyNo, 3, 1)
                My1 = MyArry3(CInt(RdNo))
                RdNo = Mid$(MyNo, 2, 1)
                My10 = MyArry2(CInt(RdNo))

                If CInt(Mid$(MyNo, 2, 2)) = 11 Then My11 = "إحدى عشر"
                If CInt(Mid$(MyNo, 2, 2)) = 12 Then My12 = "إثنى عشر"
                If CInt(Mid$(MyNo, 2, 2)) = 10 Then My10 = "عشرة"

                If (CInt((Mid$(MyNo, 1, 1))) > 0) And (CInt((Mid$(MyNo, 2, 2))) > 0) Then My100 = My100 + MyAnd
                If (CInt((Mid$(MyNo, 3, 1))) > 0) And (CInt((Mid$(MyNo, 2, 1))) > 1) Then My1 = My1 + MyAnd

                GetTxt = My100 + My1 + My10

                If (CInt((Mid$(MyNo, 3, 1))) = 1) And (CInt((Mid$(MyNo, 2, 1))) = 1) Then
                    GetTxt = My100 + My11
                    If (CInt((Mid$(MyNo, 1, 1))) = 0) Then GetTxt = My11
                End If

                If (CInt((Mid$(MyNo, 3, 1))) = 2) And (CInt((Mid$(MyNo, 2, 1))) = 1) Then
                    GetTxt = My100 + My12
                    If (CInt((Mid$(MyNo, 1, 1))) = 0) Then GetTxt = My12
                End If

                If (i = 0) And (GetTxt <> "") Then
                    If (CInt((Mid$(MyNo, 1, 3))) > 10) Then
                        Mybillion = GetTxt + " مليار"
                    Else
                        Mybillion = GetTxt + " مليارات"
                        If (CInt((Mid$(MyNo, 1, 3))) = 2) Then Mybillion = " مليار"
                        If (CInt((Mid$(MyNo, 1, 3))) = 2) Then Mybillion = " ملياران"
                    End If
                End If

                If (i = 3) And (GetTxt <> "") Then

                    If (CInt((Mid$(MyNo, 1, 3))) > 10) Then
                        MyMillion = GetTxt + " مليون"
                    Else
                        MyMillion = GetTxt + " ملايين"
                        If (CInt((Mid$(MyNo, 1, 3))) = 1) Then MyMillion = " مليون"
                        If (CInt((Mid$(MyNo, 1, 3))) = 2) Then MyMillion = " مليونان"
                    End If
                End If

                If (i = 6) And (GetTxt <> "") Then
                    If (CInt((Mid$(MyNo, 1, 3))) > 10) Then
                        MyThou = GetTxt + " ألف"
                    Else
                        MyThou = GetTxt + " آلاف"
                        If (CInt((Mid$(MyNo, 3, 1))) = 1) Then MyThou = " ألف"
                        If (CInt((Mid$(MyNo, 3, 1))) = 2) Then MyThou = " ألفان"
                    End If
                End If

                If (i = 9) And (GetTxt <> "") Then MyHun = GetTxt
                If (i = 12) And (GetTxt <> "") Then MyFraction = GetTxt
            End If

            i = i + 3
        Loop

        If (Mybillion <> "") Then
            If (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then Mybillion = Mybillion + MyAnd
        End If

        If (MyMillion <> "") Then
            If (MyThou <> "") Or (MyHun <> "") Then MyMillion = MyMillion + MyAnd
        End If

        If (MyThou <> "") Then
            If (MyHun <> "") Then MyThou = MyThou + MyAnd
        End If

        If MyFraction <> "" Then
            If (Mybillion <> "") Or (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then
                NoToTxt = ReMark + Mybillion + MyMillion + MyThou + MyHun + " " + MyCur + MyAnd + MyFraction + " " + MySubCur
            Else
                NoToTxt = ReMark + MyFraction + " " + MySubCur
            End If
        Else
            NoToTxt = ReMark + Mybillion + MyMillion + MyThou + MyHun + " " + MyCur
        End If
    End Function

    Public Class GlobalVariables
        Public Shared UserNameString As String
        Public Shared UserIDString As String
        Public Shared UserIDInteger As Integer
        Public Shared AccountSelection As String
        Public Shared UserIDWallet As Integer
        Public Shared FilteredCars As String
    End Class


    Public Sub AddEvents(EventsType As String, EventsDetails As String, EventsName As String, EventsToUser As String, EventsOwner As String, EventStatus As String)

        Try
            Dim sql As New SQLControl
            Dim InsertSql As String


            InsertSql = " Insert into CRMEnents (EventsType,EventsDetails,EventsName,EventsToUser,EventsOwner,EventStatus,EventDate) values 
                                                              ('" & EventsType & "','" & EventsDetails & "','" & EventsName & "','" & EventsToUser & "','" & EventsOwner & "','" & EventStatus & "',GETDATE() 
                                                              )"

            sql.CRMRunQuery(InsertSql)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


    'Public Sub SendSMS(Mobile As String, MessageTXT As String)
    '    Dim url As String = "http://sms.zone.ps/API/SendSMS.aspx?id=771b1fe76febcab8618c7356d6e884f7&sender=Alhuda&to= 970" & Mobile & "&msg=" & MessageTXT & ""
    '    Dim request As HttpWebRequest
    '    Dim response As HttpWebResponse = Nothing
    '    request = DirectCast(WebRequest.Create(url), HttpWebRequest)
    '    response = DirectCast(request.GetResponse(), HttpWebResponse)
    '    ' MessageBox.Show("Response: " & response.StatusDescription)
    'End Sub

    Public Function GetSMSBalance() As String
        Try
            Dim request As WebRequest = WebRequest.Create("http://sms.zone.ps/API/GetCredit.aspx?id=771b1fe76febcab8618c7356d6e884f7")
            request.Credentials = CredentialCache.DefaultCredentials
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine((CType(response, HttpWebResponse)).StatusDescription)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Console.WriteLine(responseFromServer)
            Return responseFromServer
            reader.Close()
            response.Close()
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Public Function GetDebitBalance(Acc As String, YYear As Integer, MMonth As Integer) As Decimal
        Dim SqlStr As String = "SELECT  Cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance     
                                From    [ALHUDA].[dbo].RPHSTRANSRETRIV
                                WHERE   JMDEBITCREDIT=1 and    DATEPART(month, JVALUEDATE)=" & MMonth & " and DATEPART(year, JVALUEDATE)= " & YYear & " and ( JMACCOUNTKEY = '" & Acc & "'
                                        AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND 
                                        ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3"
        Dim DebitBalance As Decimal = 0
        Try
            Dim Sql As New SQLControl
            Sql.WizCountRunQuery(SqlStr)
            DebitBalance = CDec(Sql.SQLDS.Tables(0).Rows(0).Item("DebitBalance"))
            Return DebitBalance
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function GetAccountBalance(Acc As String, YYear As Integer, MMonth As Integer) As Decimal

        Dim DD As Integer = DateTime.DaysInMonth(YYear, MMonth)

        Dim DDate As DateTime = CDate(YYear & "-" & MMonth & "-" & DD)

        Dim DebitBalance As Decimal = 0

        Try
            Dim SqlStr As String = "SELECT  Cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance     
                                From    [ALHUDA].[dbo].RPHSTRANSRETRIV
                                WHERE   JMDEBITCREDIT=1 and     JVALUEDATE <= '" & Format(DDate, "yyyy-MM-dd") & "' and ( JMACCOUNTKEY = '" & Acc & "'
                                        AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND 
                                        ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3"
            Dim Sql As New SQLControl
            Sql.WizCountRunQuery(SqlStr)
            DebitBalance = CDec(Sql.SQLDS.Tables(0).Rows(0).Item("DebitBalance"))
        Catch ex As Exception
            MsgBox(ex.ToString)
            DebitBalance = 0
        End Try

        Dim CreditBalance As Decimal
        Try
            Dim sql As New SQLControl
            Dim SqlStr As String = " SELECT  Cast(  sum( JMSUF ) as decimal(10,2)) As CreditBalance     
                                From    [ALHUDA].[dbo].RPHSTRANSRETRIV
                                WHERE   JMDEBITCREDIT=0 and    JVALUEDATE <= '" & Format(DDate, "yyyy-MM-dd") & "' and ( JMACCOUNTKEY = '" & Acc & "'
                                        AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND 
                                        ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "
            sql.WizCountRunQuery(SqlStr)
            CreditBalance = CDec(sql.SQLDS.Tables(0).Rows(0).Item("CreditBalance").ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
            CreditBalance = 0
        End Try

        Return DebitBalance - CreditBalance

    End Function


    Public Function GetSreenAccess(Form As String, USERID As String) As Boolean

        Dim Access As Boolean = False
        Try

            Dim SqlStr As String = " select [ID] from [UsersAccess] 
                                 where USERID = '" & USERID & "' and [ScreenName] ='" & Form & "'"
            Dim Sql As New SQLControl
            Sql.CRMRunQuery(SqlStr)
            If Sql.SQLDS.Tables(0).Rows.Count > 0 Then
                Access = True
            Else
                Access = False
            End If
        Catch ex As Exception
            Access = False
        End Try


        Try
            Dim SqlSt2 As String = " select UserType from [Users]
                                 where [UserID]  = '" & USERID & "'"
            Dim Sql2 As New SQLControl
            Sql2.CRMRunQuery(SqlSt2)
            If Sql2.SQLDS.Tables(0).Rows(0).Item("UserType").ToString = "Admin" Then
                Access = True
            End If

        Catch ex As Exception

        End Try

        Return Access

    End Function

    Public Sub InsertLog(ReportName As String, ReportNotes As String)
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            Dim UserID As String = GlobalVariables.UserIDString
            Dim UserName As String = GlobalVariables.UserNameString
            Dim ReportDateTime As String = CStr(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            SqlString = " INSERT INTO [CRM].[dbo].[LogReports]
           ([UserID]
           ,[UserName]
           ,[ReportName]
           ,[ReportNotes]
           ,[ReportDateTime])
     VALUES
           ('" & UserID & "' ,
           '" & UserName & "' ,
            '" & ReportName & "' ,
            '" & ReportNotes & "' ,
            '" & ReportDateTime & "')"

            Sql.CRMRunQuery(SqlString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function GetItemBalanceWallet(ItemID As String, DateFrom As String, DateTo As String, WhareHouse As String) As Decimal

        If String.IsNullOrEmpty(ItemID) Or String.IsNullOrEmpty(WhareHouse) Then Return 0

        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = "Select  SUM(SMSUPPLYQUANTITY*(1-2*DSALESDOC)) as ItemBalance 
                         FROM      [ALHUDA].[dbo].TEMPDYNJOINQUERY_WIZCOUNT
                         Where SMITEMKEY= '" & ItemID & "' and SMWAREHOUSE='" & WhareHouse & "'"
            If DateFrom <> "" Then SqlString += " ('2050-01-01' >= SMBASEDATE) AND ('2000-12-31' <= SMBASEDATE) "
            sql.WizCountRunQuery(SqlString)
            Return CDec(sql.SQLDS.Tables(0).Rows(0).Item("ItemBalance"))
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0
        End Try

    End Function

    Public Sub PrintVoucher(IsOrigional As Boolean, DocID As Integer, Preview As Boolean, _Currency As String)
        Dim Report As New AlhudaVoucher

        With Report
            .Parameters("DocID").Value = DocID
            Select Case _Currency
                Case "NIS"
                    .XrLabelAmountByWords.Text = NoToTxt(GetVoucherAmount(DocID), "شيكل", "اغورة")
                    .XrLabel33.Text = "شيكل"
                Case "USD"
                    .XrLabelAmountByWords.Text = NoToTxt(GetVoucherAmount(DocID), "دولار", "سنت")
                    .XrLabel33.Text = "دولار"
                Case "JD"
                    .XrLabelAmountByWords.Text = NoToTxt(GetVoucherAmount(DocID), "دينار", "فلس")
                    .XrLabel33.Text = "دينار"
                Case "EUR"
                    .XrLabelAmountByWords.Text = NoToTxt(GetVoucherAmount(DocID), "يورو", "سنت")
                    .XrLabel33.Text = "يورو"
            End Select
            .XrLabelTax.Text = "صفر"
            'Select Case _ZeroTax
            '    Case True
            '        .XrLabelTax.Text = "صفر"
            '    Case False
            '        .XrLabel33.Text = "شامل"
            'End Select

            If IsOrigional = True Then
                .DocOriginal.Text = "أصلية"
                '.XrPictureBoxCopy.Visible = False
                '.XrPictureStamp.Visible = False
            Else
                '.XrPictureBoxCopy.Visible = True
                .DocOriginal.Text = "نسخة"
                '.XrPictureStamp.Visible = True
            End If
            If DocID < 9999 Then .XrLabelB.Visible = True
            .CreateDocument()
            .PrintingSystem.ShowMarginsWarning = False
            If Preview = True Then
                .ShowPreview
            Else
                .XrLabelTax.Text = "صفر"
                .Print()

            End If
        End With

    End Sub

    Public Sub ValidateVouvhers()

    End Sub

    Public Sub EmailVoucher(IsOrigional As Boolean, DocID As Integer, Email As String)

        If ValidateEmail(Email) = False Then
            Exit Sub
        End If

        Try
            Dim Report As New AlhudaVoucher
            With Report
                .Parameters("DocID").Value = DocID
                .XrLabelAmountByWords.Text = NoToTxt(GetVoucherAmount(DocID), "شيكل", "اغورة")
                If DocID < 9999 Then .XrLabelB.Visible = True
                If IsOrigional = True Then
                    .DocOriginal.Text = "أصلية"
                    '.XrPictureBoxCopy.Visible = False
                Else
                    '.XrPictureStamp.Visible = True
                    .DocOriginal.Text = "نسخة"
                End If
                .CreateDocument()
                .PrintingSystem.ShowMarginsWarning = False
            End With

            Dim mem As MemoryStream = New MemoryStream()
            Report.ExportToPdf(mem)
            Report.ExportToPdf("exportedFile.pdf")
            mem.Seek(0, System.IO.SeekOrigin.Begin)
            Dim att As Attachment = New Attachment(mem, "AlhudaVoucher.pdf", "application/pdf")
            Dim mail As MailMessage = New MailMessage()
            mail.Subject = " فاتورة المحروقات   "
            mail.IsBodyHtml = True
            mail.Body = "<h1 dir=RTL style='text-align:right;background:#FFFAFA;border:none;padding:0cm'><span style='color:black'>
                             <a href=http://www.alhuda.ps/mazen/docs.pdf >خصم مصدر<b>،
                             </b>رخصة مهن<b>، </b>اسعار الهيئة<b>، </b>الحساب البنكي، برائة ذمة</a></span></h1>"
            mail.Attachments.Add(att)
            mail.From = New MailAddress("aaalhuda@gmail.com", "Alhuda Fuels Company")
            mail.To.Add(Email)
            Dim smtp As New SmtpClient
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.UseDefaultCredentials = False
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Credentials = New NetworkCredential("aaalhuda@gmail.com", "1031342aA")
            smtp.Send(mail)
            mem.Close()
            mem.Flush()
        Catch ex As Exception
            MsgBox("خطا بالارسال" & DocID)
        End Try

    End Sub

    Public Sub EmailDataTrans(Email As String, Report As XtraReport, EmailSubject As String)

        If ValidateEmail(Email) = False Then
            Exit Sub
        End If

        Dim mem As MemoryStream = New MemoryStream()
        Report.ExportToPdf(mem)
        Report.ExportToPdf("exportedFile.pdf")
        mem.Seek(0, System.IO.SeekOrigin.Begin)
        Dim att As Attachment = New Attachment(mem, "FuelTrans.pdf", "application/pdf")
        Dim mail As MailMessage = New MailMessage()
        mail.Subject = EmailSubject
        mail.IsBodyHtml = True
        mail.Body = "<h1 dir=RTL style='text-align:right;background:#FFFAFA;border:none;padding:0cm'><span style='color:black'>
                             <a href=http://www.alhuda.ps/mazen/docs.pdf >خصم مصدر<b>،
                             </b>رخصة مهن<b>، </b>اسعار الهيئة<b>، </b>الحساب البنكي، برائة ذمة</a></span></h1>"
        mail.Attachments.Add(att)
        mail.From = New MailAddress("aaalhuda@gmail.com", "Alhuda Fuels Company")
        mail.To.Add(Email)
        Dim smtp As New SmtpClient
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.UseDefaultCredentials = False
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.Credentials = New NetworkCredential("aaalhuda@gmail.com", "1031342aA")
        Try
            smtp.Send(mail)
            mem.Close()
            mem.Flush()
        Catch ex As Exception
            ' MsgBox(ex.ToString & "خطا بارسال ايميل" & " فاتورة رقم: ")
        End Try
    End Sub


    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


    Public Sub PrintDataTrans(Mmonth As String, Yyear As String, CustID As String, Action As String, withbalance As Boolean)
        With OrpakCustDataTrans
            .CheckFromForm.Checked = True
            .FleetCode.EditValue = CustID
            .TextEditMonth.Text = Mmonth
            .TextEditYear.Text = Yyear
            .RadioGroup1.EditValue = Action
            If withbalance = True Then
                .CheckEditShowBalance.Checked = True
            Else
                .CheckEditShowBalance.Checked = False
            End If
            .ShowDialog()
        End With
    End Sub

    Public Function GetRandomString() As String
        Try
            Dim sql As New SQLControl
            sql.CRMRunQuery("Select NEWID() As RandomCode")
            Return sql.SQLDS.Tables(0).Rows(0).Item("RandomCode").ToString
        Catch ex As Exception
            Return ""
        End Try

    End Function


    Public Sub IssueVoucherFromData(Voucherdate As String, AccountID As String, CustName As String,
                             CustSort As String, CustArea As String, CustAddress As String,
                             Amount As String, VoucherCode As String, Notes As String,
                             VoucherMonth As Integer, VoucherYear As Integer, VoucherType As String)




        Dim TempVoucherCode As String = ""
        Dim _WriteUser As String = CStr(GlobalVariables.UserNameString)
        Dim _VouchDate As String = Format(CDate(Voucherdate), "yyyy-MM-dd")
        Dim _VoucherMonth As Integer = CInt(Format(CDate(Voucherdate), "MM"))
        Dim _VoucherYear As Integer = CInt(Format(CDate(Voucherdate), "yyyy"))

        Dim query As String = String.Empty
        query = "INSERT INTO VouchersHeader ([VouchNo] ,[VouchDate],[CustID],[CustName],[CustSort], 
                                             [CustArea], [CustAddress], [WriteUser], [Amount], [Currency],
                                             [AmountNIS], [VoucherCode], [Notes],[VoucherMonth],[VoucherYear],VoucherType,InputDateTime)
                             VALUES ( @VoucherNo  ,@VouchDate,@CustID,@CustName,@CustSort, 
                                      @CustArea,@CustAddress,@WriteUser,@Amount,@Currency,@AmountNIS,@VoucherCode,@Notes,@VoucherMonth,@VoucherYear,@VoucherType,GETDATE())"
        Using conn As New SqlConnection(CRMString)
            conn.Open()

            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@VoucherNo", SetVoucherNo(_VoucherMonth, _VoucherYear))
                    .Parameters.AddWithValue("@VouchDate", _VouchDate)
                    .Parameters.AddWithValue("@CustID", AccountID)
                    .Parameters.AddWithValue("@CustName", CustName)
                    .Parameters.AddWithValue("@CustSort", CustSort)
                    .Parameters.AddWithValue("@CustArea", CustArea)
                    .Parameters.AddWithValue("@CustAddress", CustAddress)
                    .Parameters.AddWithValue("@WriteUser", _WriteUser)
                    .Parameters.AddWithValue("@Amount", CDec(Amount))
                    .Parameters.AddWithValue("@Currency", "NIS")
                    .Parameters.AddWithValue("@AmountNIS", CDec(Amount))
                    .Parameters.AddWithValue("@VoucherCode", VoucherCode)
                    .Parameters.AddWithValue("@Notes", Notes)
                    .Parameters.AddWithValue("@VoucherMonth", VoucherMonth)
                    .Parameters.AddWithValue("@VoucherYear", VoucherYear)
                    .Parameters.AddWithValue("@VoucherType", VoucherType)
                    comm.ExecuteNonQuery()
                End With
            End Using

            'Try
            '    Dim SqlString As String
            '    Dim Sql As New SQLControl
            '    SqlString = " select VouchNo from VouchersHeader where VoucherCode='" & VoucherCode & "' "
            '    Sql.CRMRunQuery(SqlString)
            '    VoucherNo = CInt(Sql.SQLDS.Tables(0).Rows(0).Item("VouchNo").ToString)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try

            Dim VoucherNo As Integer = 0
            VoucherNo = GetVoucherNoFromCode(VoucherCode)


            Dim Sql2 As New SQLControl
            Dim SqlInsertDetials As String
            SqlInsertDetials = "    insert into [CRM].[dbo].VouchersDetails (VoucherCode,VouchNo,SotckName,Quantity,Price,Amount )
                                                select VoucherCode,VouchNo,ProductName,Quantity,price,Amount from 
                                                        (select [FleetCode],[TransMonth],[TransYear],ProductName,SUM([Quantity]) as Quantity,
                                                         case when SUM([Quantity])=0 then 0 else SUM(totalsale)/SUM([Quantity]) end as price, SUM(totalsale) as Amount 
                                                        FROM [CRM].[dbo].[DATA]
                                                        where [FleetCode]='" & AccountID & "' and [TransMonth]='" & VoucherMonth & "'"
            If VoucherType = "Stock" Then
                SqlInsertDetials += " and stationName ='Stock' "
            ElseIf VoucherType <> "Stock" Then
                SqlInsertDetials += " and stationName <> 'Stock' "
            End If

            SqlInsertDetials += "      group by ProductName,[FleetCode],[TransMonth],[TransYear]) AA
                                                left Join 
                                                    (Select CustID,[VoucherMonth],VoucherYear,VoucherCode,VouchNo
                                                     FROM [CRM].[dbo].[VouchersHeader] where VouchNo='" & VoucherNo & "' and CustID='" & AccountID & "' and [VoucherMonth]='" & VoucherMonth & "'  ) BB
                                                on AA.FleetCode=BB.CustID "
            Sql2.CRMRunQuery(SqlInsertDetials)

            PrintVoucher(True, CInt(VoucherNo), False, "NIS")


        End Using
    End Sub

    Public Function GetVoucherNoFromCode(VoucherCode As String) As Integer
        Try
            Dim SqlString As String
            Dim Sql As New SQLControl
            SqlString = " select VouchNo from VouchersHeader where VoucherCode='" & VoucherCode & "' "
            Sql.CRMRunQuery(SqlString)
            Return CInt(Sql.SQLDS.Tables(0).Rows(0).Item("VouchNo"))
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function IssueVoucherFromOut(Voucherdate As String, AccountID As String, CustName As String,
                             CustSort As String, CustArea As String, CustAddress As String,
                             Amount As Decimal, VoucherCode As String, Notes As String,
                             VoucherMonth As Integer, VoucherYear As Integer, VoucherType As String, Currency As String, StockDetails As DataTable) As String
        Dim _Value As String
        If CDate(Voucherdate) < CDate("2020-03-01") Then
            MsgBox("لا يمكن اصدار الفاتورة: تاريخ خطا")
            _Value = "False"
        End If

        If CDate(Voucherdate) > Today Then
            MsgBox("لا يمكن اصدار الفاتورة: تاريخ خطا")
            _Value = "False"
        End If

        If StockDetails.Rows.Count = 0 Then
            MsgBox("Error: No data in DataTable")
            _Value = "False"
        End If

        If _Value <> "False" Then
            Dim TempVoucherCode As String = ""
            Dim _WriteUser As String = CStr(GlobalVariables.UserNameString)
            Dim _VouchDate As String = Format(CDate(Voucherdate), "yyyy-MM-dd")
            Dim VoucherNo As Integer = 0



            Dim query As String = String.Empty
            query = "INSERT INTO VouchersHeader ([VouchNo] ,[VouchDate],[CustID],[CustName],[CustSort], 
                                             [CustArea], [CustAddress], [WriteUser], [Amount], [Currency],
                                             [AmountNIS], [VoucherCode], [Notes],[VoucherMonth],[VoucherYear],VoucherType,InputDateTime)
                             VALUES ( @VoucherNo ,@VouchDate,@CustID,@CustName,@CustSort, 
                                      @CustArea,@CustAddress,@WriteUser,@Amount,@Currency,@AmountNIS,@VoucherCode,@Notes,@VoucherMonth,@VoucherYear,@VoucherType,GETDATE())"
            Using conn As New SqlConnection(CRMString)
                conn.Open()

                Using comm As New SqlCommand()
                    With comm
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@VoucherNo", SetVoucherNo(VoucherMonth, VoucherYear))
                        .Parameters.AddWithValue("@VouchDate", _VouchDate)
                        .Parameters.AddWithValue("@CustID", AccountID)
                        .Parameters.AddWithValue("@CustName", CustName)
                        .Parameters.AddWithValue("@CustSort", CustSort)
                        .Parameters.AddWithValue("@CustArea", CustArea)
                        .Parameters.AddWithValue("@CustAddress", CustAddress)
                        .Parameters.AddWithValue("@WriteUser", _WriteUser)
                        .Parameters.AddWithValue("@Amount", CDec(Amount))
                        .Parameters.AddWithValue("@Currency", Currency)
                        .Parameters.AddWithValue("@AmountNIS", CDec(Amount))
                        .Parameters.AddWithValue("@VoucherCode", VoucherCode)
                        .Parameters.AddWithValue("@Notes", Notes)
                        .Parameters.AddWithValue("@VoucherMonth", VoucherMonth)
                        .Parameters.AddWithValue("@VoucherYear", VoucherYear)
                        .Parameters.AddWithValue("@VoucherType", VoucherType)
                        comm.ExecuteNonQuery()
                    End With
                End Using

                VoucherNo = GetVoucherNoFromCode(VoucherCode)

                For Each row As DataRow In StockDetails.Rows
                    If Not String.IsNullOrEmpty(row("SotckName").ToString) Or row("SotckName").ToString <> "" Then
                        Dim Sql2 As New SQLControl
                        Dim SqlInsertDetials As String
                        SqlInsertDetials = " insert into [CRM].[dbo].VouchersDetails 
                                     (VoucherCode,VouchNo,SotckName,Quantity,Price,Amount,StockID ) Values (
                                      '" & VoucherCode & "', 
                                      '" & VoucherNo & "', 
                                      '" & row("SotckName").ToString & "', 
                                      '" & row("Quantity").ToString & "', 
                                      '" & row("Price").ToString & "', 
                                      '" & row("Amount").ToString & "', 
                                      '0' )"
                        Sql2.CRMRunQuery(SqlInsertDetials)
                    End If

                Next row

                PrintVoucher(True, CInt(VoucherNo), False, Currency)
            End Using
            _Value = CStr(VoucherNo)
        End If

        Return _Value
    End Function

    Public Function SetVoucherNo(_month As Integer, _year As Integer) As Integer
        Dim _VoucherNo As Integer

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select MAX([VouchNo])+1 As VouchNo 
                      From [CRM].[dbo].[VouchersHeader] 
                      where VoucherMonth =" & _month & " and VoucherYear =" & _year
            Sql.CRMRunQuery(SqlString)
            _VoucherNo = CInt(Sql.SQLDS.Tables(0).Rows(0).Item("VouchNo"))
        Catch ex As Exception
            _VoucherNo = CInt(Right(CStr(_year), 2) & _month.ToString("00") & 1.ToString("00000"))
        End Try

        Return _VoucherNo
    End Function
    Public Function GetTotalVoucherForMnthByCustomer(_Month As Integer, _Year As Integer, _CustID As String) As Decimal
        Try
            Dim _TotalVoucher As Decimal = 0
            Dim Sql As New SQLControl
            Dim SqlString As String = "    select SUM(amount) as TotalVoucher
                                        FROM [CRM].[dbo].[VouchersHeader] 
                                        Where CustID ='" & _CustID & "' and [VoucherCancelledNotes] is  null and VoucherMonth= " & _Month & " and VoucherYear=" & _Year
            Sql.CRMRunQuery(SqlString)
            Return CDec(Sql.SQLDS.Tables(0).Rows(0).Item("TotalVoucher").ToString)
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function GetVoucherAmount(VoucherNo As Integer) As Decimal

        Dim _Amount As Decimal
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select Amount from [CRM].[dbo].[VouchersHeader] where VouchNo= " & VoucherNo
            Sql.CRMRunQuery(SqlString)
            _Amount = CDec(Sql.SQLDS.Tables(0).Rows(0).Item("Amount"))
        Catch ex As Exception
            _Amount = 0
            MsgBox(ex.ToString)
        End Try
        Return _Amount
    End Function

    Public Function ProductNameCase() As String
        Return "CASE WHEN product_name = 'Unleaded regular' THEN N'بنزين95' WHEN product_name = 'Unleaded Super' THEN N'بنزين98' WHEN product_name = 'Car Washe' THEN N'غسيل' WHEN product_name = 'BigCar Wash' THEN N'غسيل' WHEN product_name = 'Diesel' THEN N'سولار'  else product_name  END AS SotckName"
    End Function

    Public Function IssueToStations(RowID As Integer, TransType As Integer) As String
        Dim St(14) As Integer
        St(0) = 1001
        St(1) = 1002
        St(2) = 1003
        St(3) = 1004
        St(4) = 1005
        St(5) = 1006
        St(6) = 1007
        St(7) = 1008
        St(8) = 1009
        St(9) = 1011
        St(10) = 1012
        St(11) = 1014
        St(12) = 1015
        St(13) = 1016
        St(14) = 1017

        For i = 0 To 14
            Dim TrasID As Integer
            TrasID = GetIndexID()
            If TrasID = 0 Then Return "faild" : Exit Function

            Dim sql As New SQLControl
            Dim SqlString As String = " insert into [station_queue] ( id,station_id,type,record_id,value,timestamp )
                                                Values          ( " & TrasID & ",'" & St(i) & "'," & TransType & "," & RowID & ",'', GETDATE() ) "
            sql.RunQuery(SqlString)
            ' Return "Success"
        Next

        Return "Success"
    End Function

    Private Function GetIndexID() As Integer
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = "  Update [AlhudaIndex] Set ID = ID + 1,UpdateTime=GETDATE() "
            Sql.RunQuery(SqlString)

            Dim Sql2 As New SQLControl
            Dim SqlString2 As String = "  select ID from [AlhudaIndex] "
            Sql2.RunQuery(SqlString2)
            Return CInt(Sql2.SQLDS.Tables(0).Rows(0).Item("id").ToString)

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function GetItemPrice(StockID As String, _Date As String) As Decimal

        '
        '  Dim _ItemPrice As Decimal = 0

        If IsDate(_Date) = False Then
            Return 0
            Exit Function
        End If

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = " SELECT       [PRICE]
                                    FROM [WALLET].[dbo].[PRICELIST]
                                    where ('" & _Date & "' between DATEFROM and DATETO) and ITEMKEY='" & StockID & "' "
            Sql.WalletRunQuery(SqlString)
            Return CDec(Sql.SQLDS.Tables(0).Rows(0).Item("PRICE"))
        Catch ex As Exception
            Return 0
            Exit Function
        End Try

        '  Return _ItemPrice
    End Function

    Public Function StopCard(CardID As Integer, ActiveOrStop As Integer) As Boolean
        Dim _Result As Boolean
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Update Means set [status] = " & ActiveOrStop & " where [id] = " & CardID
            Sql.RunQuery(SqlString)
            If IssueToStations(CardID, 17) = "Success" Then
                _Result = True
            Else
                _Result = False
            End If
        Catch ex As Exception
            _Result = False
        End Try
        Return _Result
    End Function
    Public Function StopFleet(FleetID As Integer, ActiveOrStop As Integer) As Boolean
        Dim _Result As Boolean

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = "Select ID from Fleets Where ID=" & FleetID
            Sql.RunQuery(SqlString)
            Dim _ID As Integer = CInt(Sql.SQLDS.Tables(0).Rows(0).Item("ID"))
        Catch ex As Exception
            Return False
            Exit Function
        End Try

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Update Fleets set [status] = " & ActiveOrStop & " where [id] = " & FleetID

            Sql.RunQuery(SqlString)
            If IssueToStations(FleetID, 12) = "Success" Then
                _Result = True
            Else
                _Result = False
            End If
        Catch ex As Exception
            _Result = False
        End Try
        Return _Result
    End Function

    'Public Function GetEmpDataToAccounting(CardID As Integer) As (CardNo As String, CardID As Integer, Plate As String,
    'GroupRule As Integer, CardCode As String, CardStatus As String)
    '    Dim _CardNo As String = "0"
    '    Dim _CardID As Integer = 0
    '    Dim _Plate As Integer = 0
    '    Dim _GroupRule As Integer = 0
    '    Dim _CardCode As String = "0"
    '    Dim _CardStatus As String = ""


    '    Try
    '        Dim sql As New SQLControl
    '        Dim SqlString As String
    '        SqlString = "   Select [name],[string],[id],[status],[rule]
    '         from [TrueTime].[dbo].[EmployeesData]  where SalaryAccountNo = " & CardID
    '        sql.RunQuery(SqlString)


    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefID"))) Then _RefID = sql.SQLDS.Tables(0).Rows(0).Item("RefID")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefName"))) Then _RefName = sql.SQLDS.Tables(0).Rows(0).Item("RefName")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefNo"))) Then _RefNo = sql.SQLDS.Tables(0).Rows(0).Item("RefNo")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefType"))) Then _RefType = sql.SQLDS.Tables(0).Rows(0).Item("RefType")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefMobile"))) Then _RefMobile = sql.SQLDS.Tables(0).Rows(0).Item("RefMobile")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefPhone"))) Then _RefPhone = sql.SQLDS.Tables(0).Rows(0).Item("RefPhone")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefAccID"))) Then _RefAccID = sql.SQLDS.Tables(0).Rows(0).Item("RefAccID")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("RefTypeName"))) Then _RefTypeName = sql.SQLDS.Tables(0).Rows(0).Item("RefTypeName")
    '        '    If Not (IsDBNull(sql.SQLDS.Tables(0).Rows(0).Item("Currency"))) Then _currency_id = sql.SQLDS.Tables(0).Rows(0).Item("Currency")
    '    Catch ex As Exception

    '    End Try


    '    'Return (_RefID, _RefName, _RefNo, _RefType, _RefMobile, _RefPhone, _RefAccID, _RefTypeName, _currency_id)
    'End Function


    Public Function GetAcountStatment(AccountNo As Integer, SearchType As String, _DateFrom As String, _DateTo As String) As DataTable
        Dim JouranlTable As New DataTable
        Return JouranlTable


        'Dim SqlString As String
        'Dim JouranlTable As New DataTable

        'SqlString = "select       J.[DocID]      ,[DocDate]      ,D.Name as DocName , DocName as DocNameValue ,[DocStatus]      ,c.CostName      ,[DebitAcc]
        '                      ,[CredAcc]      ,[AccountCurr]      ,[DocCurrency]      ,[DocAmount]      ,[ExchangePrice]      ,[BaseCurrAmount]
        '                      , Case when CredAcc =0 then   [BaseAmount] else 0  end as DebitBaseAmount
        '                   , Case when DebitAcc =0 then   [BaseAmount] else 0 end as CredBaseAmount
        '                      , J.DocSort      ,[Referance]      ,[DocManualNo]	  ,A.AccName	  ,AA.AccName	  ,E.EmployeeName ,J.DocNotes
        '                      , 0  as  Balance
        '                   from Journal J
        '                   left join FinancialAccounts A on A.AccNo = J.CredAcc
        '                   left join FinancialAccounts AA on AA.AccNo = J.DebitAcc
        '                   left join  [TrueTime].[dbo].[EmployeesData] E on E.EmployeeID=J.Referance
        '                   left join DocNames D on D.id = J.DocName 
        '                   left join DocSorts S on S.SortID = J.DocSort
        '                   left join CostCenter C on C.CostID = J.DocCostCenter where DocStatus > 0 and (DocDate between '" & Format(CDate(_DateFrom), "yyyy-MM-dd") & "' and '" & Format(CDate(_DateTo), "yyyy-MM-dd") & "')"


        'Select Case SearchType
        '    Case "Ref"
        '        SqlString += " and  Referance = " & AccountNo
        '    Case "Acc"
        '        SqlString += " and (   DebitAcc = " & AccountNo & " OR CredAcc= " & AccountNo & ")"
        'End Select

        'SqlString += " order by DocDate,DocID"

        'Dim sql As New SQLControl
        'sql.SqlTrueAccountingRunQuery(SqlString)
        'JouranlTable = sql.SQLDS.Tables(0)

        'Dim BegBalce As Decimal = 0
        'Dim R As DataRow = JouranlTable.NewRow
        'BegBalce = GetBegBalance(AccountNo, SearchType, _DateFrom, _DateTo)
        'If BegBalce > 0 Then R("DebitBaseAmount") = BegBalce
        'If BegBalce < 0 Then R("CredBaseAmount") = Math.Abs(BegBalce)
        'R("DocDate") = CDate(_DateFrom).AddDays(-1)
        'R("DocNotes") = "  رصيد مدور"
        'JouranlTable.Rows.Add(R)

        'JouranlTable.DefaultView.Sort = "DocDate ASC"
        'JouranlTable = JouranlTable.DefaultView.ToTable()


        'For i As Integer = 0 To JouranlTable.Rows.Count - 1
        '    Dim row As DataRow = JouranlTable.Rows(i)
        '    Dim credit As Decimal = 0, debit As Decimal = 0, previousBalance As Decimal = 0
        '    Decimal.TryParse(row("CredBaseAmount").ToString(), credit)
        '    Decimal.TryParse(row("DebitBaseAmount").ToString(), debit)
        '    If i > 0 Then Decimal.TryParse(JouranlTable.Rows(i - 1)("Balance").ToString(), previousBalance)
        '    row("Balance") = If(i = 0, debit - credit, previousBalance - credit + debit)
        'Next






        'GridControl1.DataSource = JouranlTable

    End Function

    Public Function UpdateTrans(TransID As Integer, Description As String) As Boolean
        Dim _Rows As Integer = 0
        Dim _Result As Boolean

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = "Select Description From JurnalTrans  Where TransID=" & TransID
            Sql.WizCountRunQuery(SqlString)
            _Rows = Sql.SQLDS.Tables(0).Rows.Count
            _Result = True
        Catch ex As Exception
            _Result = False
        End Try

        If _Rows = 1 And _Result <> False Then
            Try
                Dim Sql As New SQLControl
                Dim SqlString As String
                SqlString = "Update JurnalTrans Set Description='" & Description & "' Where TransID=" & TransID
                Sql.WizCountRunQuery(SqlString)
            Catch ex As Exception
                _Result = False
            End Try
        Else
            _Result = False
        End If

        Return _Result

    End Function
    Public Function GetTransIDData(TransID As Integer) As String
        Dim _Description As String
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = "Select Description From JurnalTrans  Where TransID=" & TransID
            Sql.WizCountRunQuery(SqlString)
            _Description = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("Description"))

        Catch ex As Exception
            _Description = ""
        End Try
        Return _Description
    End Function

    Public Function GetBegBalance(Acc As String, FromDate As DateTime) As Decimal
        Dim _BegBalance As Decimal
        Dim _FromDate As String = Format(FromDate, "yyyy-MM-dd")

        If String.IsNullOrEmpty(Acc) Or String.IsNullOrEmpty(_FromDate) Then
            _BegBalance = 0
        Else
            Try
                Dim Sql As New SQLControl
                Dim SqlString As String
                SqlString = "select D.JMACCOUNTKEY, isnull(Debit-Credit,0) as Balance from 
                                (SELECT  JMACCOUNTKEY, cast(  sum( JMSUF ) as decimal(10,2)) as Debit    
                                from RPHSTRANSRETRIV
                                WHERE   JMDEBITCREDIT=1 and (JMACCOUNTKEY = '" & Acc & "'  AND ('" & _FromDate & "' > JVALUEDATE)) group by JMACCOUNTKEY
                                ) D
                                left join 
                                (SELECT   JMACCOUNTKEY, cast(sum( JMSUF ) as decimal(10,2))  as Credit 
                                from RPHSTRANSRETRIV
                                WHERE   JMDEBITCREDIT=0 and ( JMACCOUNTKEY = '" & Acc & "'  AND ('" & _FromDate & "' > JVALUEDATE) ) group by JMACCOUNTKEY
                                ) C
                                on D.JMACCOUNTKEY=C.JMACCOUNTKEY"
                Sql.WizCountRunQuery(SqlString)
                _BegBalance = CDec(Sql.SQLDS.Tables(0).Rows(0).Item("Balance"))
            Catch ex As Exception
                _BegBalance = 0
            End Try
            Return _BegBalance
        End If

        Return _BegBalance

    End Function

    Public Function GetAccounts() As DataTable

        Dim _Accounts As New DataTable
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select  AccountKey,FullName,SortGroup from Accounts "
            Sql.WizCountRunQuery(SqlString)
            _Accounts = Sql.SQLDS.Tables(0)
        Catch ex As Exception
            Return _Accounts
        End Try
        Return _Accounts

    End Function

    Public Function IssueVoucherAuthentication() As Boolean
        Dim _Authintication As Boolean
        Try
            Dim Sql As New SQLControl
            Sql.CRMRunQuery("Select SettingValue from [dbo].[SettingsApp] Where [SettingName]='IssueVouchersAuth'")
            _Authintication = CBool(Sql.SQLDS.Tables(0).Rows(0).Item("SettingValue"))
        Catch ex As Exception
            _Authintication = False
        End Try
        Return _Authintication
    End Function


End Module