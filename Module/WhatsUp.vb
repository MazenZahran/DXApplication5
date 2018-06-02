Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization

Public Class WaMessageSender

    ''' TODO: Replace the following with your gateway instance ID, Forever Green client ID and secret below:
    Private Const INSTANCE_ID As String = "YOUR_INSTANCE_ID_HERE"

    Private Const CLIENT_ID As String = "YOUR_CLIENT_ID_HERE"
    Private Const CLIENT_SECRET As String = "YOUR_CLIENT_SECRET_HERE"

    Private Const GROUP_API_URL As String = "http://api.whatsmate.net/v3/whatsapp/group/text/message/" + INSTANCE_ID

    Public Function sendGroupMessage(ByVal groupAdmin As String, ByVal groupName As String, ByVal message As String) As Boolean
        Dim success As Boolean = True
        Dim webClient As New WebClient()

        Try
            Dim payloadObj As New GroupPayload(groupAdmin, groupName, message)
            Dim serializer As New JavaScriptSerializer()
            Dim postData As String = serializer.Serialize(payloadObj)

            webClient.Headers("content-type") = "application/json"
            webClient.Headers("X-WM-CLIENT-ID") = CLIENT_ID
            webClient.Headers("X-WM-CLIENT-SECRET") = CLIENT_SECRET

            webClient.Encoding = Encoding.UTF8
            Dim response As String = webClient.UploadString(GROUP_API_URL, postData)
            Console.WriteLine(response)
        Catch webEx As WebException
            Dim res As HttpWebResponse = DirectCast(webEx.Response, HttpWebResponse)
            Dim stream As Stream = res.GetResponseStream()
            Dim reader As New StreamReader(stream)
            Dim body As String = reader.ReadToEnd()

            Console.WriteLine(res.StatusCode)
            Console.WriteLine(body)
            success = False
        End Try

        Return success
    End Function

    Private Class GroupPayload
        Public group_admin As String
        Public group_name As String
        Public message As String

        Sub New(ByVal groupAdmin As String, ByVal groupName As String, ByVal msg As String)
            group_admin = groupAdmin
            group_name = groupName
            message = msg
        End Sub

    End Class

End Class

Module Module1

    Sub Main()
        Dim waSender As New WaMessageSender()
        Dim groupAdmin As String = "12025550108" ''' TODO: Specify the WhatsApp number of the group creator, including the country code
        Dim groupName As String = "Happy Club"  ''' TODO: Specify the name of the group
        Dim message As String = "Guys, let's party tonight!"  ''' TODO: Specify the content of your message

        waSender.sendGroupMessage(groupAdmin, groupName, message)
        Console.WriteLine("Press Enter to exit")
        Console.ReadLine()
    End Sub

End Module