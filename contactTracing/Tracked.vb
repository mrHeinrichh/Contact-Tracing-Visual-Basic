Imports System.Data.OleDb
Imports BarcodeLib

Public Class Tracked
    Dim dt As DataTable = New DataTable
    Public sqlString As String = ""
    Dim qrCodeString As String = ""
    'instantiate ConnectToDB Class
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub Tracked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim arrImage() As Byte
            connClass.OpenConnection()
            dt = connClass.selectFrom(sqlString)
            'get data from datatablt and set it to textbox fields
            Label1.Text = dt.Rows(0).Item("full_name").ToString()
            age.Text = dt.Rows(0).Item("age").ToString()
            gender.Text = dt.Rows(0).Item("gender").ToString()
            contactNum.Text = dt.Rows(0).Item("contactNum").ToString()
            'vacStat.Text = dt.Rows(0).Item("Vaccination_Status").ToString()
            Address.Text = dt.Rows(0).Item("Address").ToString()
            EmailAdd.Text = dt.Rows(0).Item("Email_Address").ToString()
            barCodenum.Text = dt.Rows(0).Item("barCodenum").ToString()
            'set qrstring to barcode from database
            qrCodeString = dt.Rows(0).Item("barCodenum").ToString()
            arrImage = dt.Rows(0).Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            BunifuPictureBox1.Image = Image.FromStream(mstream)
            'convert qrstringcode to actual barcode image
            Dim barcode As Barcode = New Barcode()
            Dim foreColor As Color = Color.White
            Dim backColor As Color = Color.Transparent
            Dim image2 As Image = barcode.Encode(TYPE.UPCA, qrCodeString, foreColor, backColor, CInt(PictureBox1.Width * 0.8), CInt(PictureBox1.Height * 0.8))
            PictureBox1.Image = image2
        Catch ex As Exception
        End Try
        'close connection required for every session to database
        connClass.closeCOn()
    End Sub
End Class