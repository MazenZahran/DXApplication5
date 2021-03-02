Imports System.Drawing.Imaging
Imports System.IO

Public Class FinancePaymentSign
    Private PointX As Single = 0
    Private PointY As Single = 0
    Private LastX As Single = 0
    Private LastY As Single = 0
    Private Sub FinancePaymentSign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub panel1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            PointX = e.X
            PointY = e.Y
            panel1_Paint(Me, Nothing)
        End If
    End Sub

    Private Sub panel1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown
        LastX = e.X
        LastY = e.Y
    End Sub

    Private Sub panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim g As Graphics = Panel1.CreateGraphics()
        g.DrawLine(Pens.Black, PointX, PointY, LastX, LastY)
        g.Save()
        LastX = PointX
        LastY = PointY
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Dim ms As MemoryStream = New MemoryStream()
        'Dim bmp As Bitmap = New Bitmap(Panel1.Width, Panel1.Height)
        'Panel1.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, Panel1.Width, Panel1.Height))
        'bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Dim Pic_arr As Byte() = New Byte(ms.Length - 1) {}
        'ms.Position = 0
        'ms.Read(Pic_arr, 0, Pic_arr.Length)
        'PictureBox1.Image = System.Drawing.Image.FromStream(ms)
        'ms.Close()
        SendKeys.Send("%{PRTSC}")
        '  SendKeys.Send("%{PRTSC}")
        Dim Screenshot As Image = Clipboard.GetImage()
        '  Screenshot.Save("e:\ScreenShot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        My.Forms.FinancePayment.PictureEdit1.Image = Screenshot

        SendKeys.Send("%{PRTSC}")
        '  SendKeys.Send("%{PRTSC}")
        Dim Screenshot2 As Image = Clipboard.GetImage()
        '  Screenshot.Save("e:\ScreenShot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        My.Forms.FinancePayment.PictureEdit1.Image = Screenshot2

        'Dim bm As New Bitmap(Width, Height)
        'DrawToBitmap(bm, New Rectangle(0, 0, Width, Height))
        'Dim name As String = InputBox("Name it:")
        'bm.Save("E:\vvv.png", System.Drawing.Imaging.ImageFormat.Png)


    End Sub
End Class