Public Class Form1
    Private line As New List(Of Point)

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'start the line:
        'line = New List(Of Point)
        'line.Add(e.Location)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        'add points to the line and Invalidate the form to trigger repainting:
        'line.Add(e.Location)
        'ListBox1.Items.Add(e.Location)
        'Me.Invalidate()
        'End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'use DrawLines to connect up all the points in the line:
        ' If line.Count > 1 Then
        'e.Graphics.DrawLines(Pens.Black, line.ToArray)
        'End If
    End Sub



    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        'start the line:
        line = New List(Of Point)
        line.Add(e.Location)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'add points to the line and Invalidate the form to trigger repainting:
            line.Add(e.Location)
            ListBox1.Items.Add(e.Location)
            Me.Invalidate()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If line.Count > 1 Then
            e.Graphics.DrawLines(Pens.Black, line.ToArray)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawLines(Pens.Red, line.ToArray)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class