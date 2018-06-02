Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

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

        destination = CType(Val(destination), String)
        If Len(destination) = 9 Then destination = "972" & destination
        If Len(destination) = 12 Then destination = destination

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
    End Class

End Module