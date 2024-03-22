Imports System.Data.OleDb
Imports BarcodeLib
Imports USB_Barcode_Scanner
Public Class scanAbarcode
    Dim dt As DataTable = New DataTable
    Public sqlString As String = ""
    Dim qrCodeString As String = ""
    'instantiate ConnectToDB Class
    Dim connClass As ConnectToDB = New ConnectToDB
    WithEvents barcodeScanner As BarcodeScanner

    Private Sub scanAbarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barcodeScanner = New BarcodeScanner(barCodetxt)
    End Sub

    Private Sub barcodeScanner_BarcodeScanned(sender As Object, e As BarcodeScannerEventArgs) Handles barcodeScanner.BarcodeScanned
        barCodetxt.Text = e.Barcode
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Try
            Dim barcode As Barcode = New Barcode()
            Dim foreColor As Color = Color.White
            Dim backColor As Color = Color.Transparent
            Dim image As Image = barcode.Encode(TYPE.UPCA, barCodetxt.Text, foreColor, backColor, CInt(picBcodes.Width * 0.8), CInt(picBcodes.Height * 0.8))
            picBcodes.Image = image
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateIn.Text = DateTimePicker1.Text
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim cmd As New OleDb.OleDbCommand
        connClass.OpenConnection()
        Dim sqlString As String = "INSERT INTO LogofTransac(Date_In,Time_In,Building,barCodenum) VALUES (@Date_In,@Time_In,@Building,@barCodenum)"
        cmd.CommandText = sqlString
        cmd.Connection = connClass.conn
        cmd.Parameters.AddWithValue("@Date_In", DateIn.Text)
        cmd.Parameters.AddWithValue("@Time_In", TimeIn.Text)
        cmd.Parameters.AddWithValue("@Building", buildings.Text)
        cmd.Parameters.AddWithValue("@barCodenum", barCodetxt.Text)
        Dim r As Integer
        r = cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        connClass.closeCOn()
    End Sub
End Class