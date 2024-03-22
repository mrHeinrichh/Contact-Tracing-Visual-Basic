Imports System.Data.OleDb
Imports BarcodeLib
Imports System.IO

Public Class UserForm
    Dim dt As DataTable = New DataTable
    Dim dx As DataTable = New DataTable
    Public sqlString As String = ""
    Public sqlString1 As String = ""
    Dim qrCodeString As String = ""
    'instantiate ConnectToDB Class
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub LOGINstudentAPPOINTMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim arrImage() As Byte
            connClass.OpenConnection()
            dt = connClass.selectFrom(sqlString)
            dx = connClass.selectFrom(sqlString1)
            arrImage = dt.Rows(0).Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            BunifuPictureBox1.Image = Image.FromStream(mstream)
            Label1.Text = dx.Rows(0).Item("barCodenum").ToString()
            userDetails.MdiParent = Me
            userDetails.Dock = DockStyle.Fill
            userDetails.Show()
        Catch ex As Exception

        End Try
        connClass.closeCOn()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
        userDetails.MdiParent = Me
        userDetails.Dock = DockStyle.Fill
        userDetails.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        userDetails.MdiParent = Me
        userDetails.Dock = DockStyle.Fill
        userDetails.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        USEReditacc.MdiParent = Me
        USEReditacc.Dock = DockStyle.Fill
        USEReditacc.StringPass = Label1.Text
        USEReditacc.Show()
    End Sub
End Class