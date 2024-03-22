Public Class Logoutmsg
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles lgu.Click
        Me.Hide()
        AdminForm.Hide()
        guiLogin.Show()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
End Class