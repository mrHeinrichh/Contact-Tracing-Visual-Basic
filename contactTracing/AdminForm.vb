Public Class AdminForm
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Home.MdiParent = Me
        Home.Dock = DockStyle.Fill
        Home.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.MdiParent = Me
        Home.Dock = DockStyle.Fill
        Home.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        manageRecrd.MdiParent = Me
        manageRecrd.Dock = DockStyle.Fill
        manageRecrd.Show()
        Panel1.Top = Button4.Top
        manageRecrd.BringToFront()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Logoutmsg.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        trackRecords.MdiParent = Me
        trackRecords.Dock = DockStyle.Fill
        trackRecords.Show()
        Panel1.Top = Button3.Top
        trackRecords.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.MdiParent = Me
        Home.Dock = DockStyle.Fill
        Panel1.Top = Button1.Top
        Home.Show()
        Home.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editAccount.MdiParent = Me
        editAccount.Dock = DockStyle.Fill
        editAccount.Show()
        Panel1.Top = Button2.Top
        editAccount.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        logHistoryAppointment.MdiParent = Me
        logHistoryAppointment.Dock = DockStyle.Fill
        logHistoryAppointment.Show()
        Panel1.Top = Button5.Top
        logHistoryAppointment.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        btnReports.MdiParent = Me
        btnReports.Dock = DockStyle.Fill
        btnReports.Show()
        Panel1.Top = Button7.Top
        btnReports.BringToFront()
    End Sub
End Class