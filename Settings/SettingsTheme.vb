Public Class SettingsTheme

    Private Sub ChangeTheme(ThemeName As String)
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = False
        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = True
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = ThemeName 'For Example!
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        ChangeTheme(ActiveControl.Text)
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        ChangeTheme(ActiveControl.Text)
    End Sub
End Class