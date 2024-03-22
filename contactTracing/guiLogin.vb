Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class guiLogin
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim dx As String = ""
    Dim sqlx As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim cmd As New OleDbCommand("select count(*) from adminUser where usrLogin=? and userpass=?", connClass.conn)
        cmd.Connection = connClass.conn
        connClass.OpenConnection()
        If BunifuTextBox1.Text = Nothing Or BunifuTextBox2.Text = Nothing Then

        Else
            Try
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = BunifuTextBox1.Text
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = BunifuTextBox2.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                If (count > 0) Then

                    AdminForm.Show()
                    Me.Close()
                Else
                End If
            Catch ex As Exception
            End Try
        End If
        Dim cmd1 As New OleDbCommand("select count(*) from StudentAppointment where usRnhame=? and pashwurd=?", connClass.conn)
        cmd1.Connection = connClass.conn
        connClass.OpenConnection()
        If BunifuTextBox1.Text = Nothing Or BunifuTextBox2.Text = Nothing Then

        Else
            Try
                cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = BunifuTextBox1.Text
                cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = BunifuTextBox2.Text
                Dim count1 = Convert.ToInt32(cmd1.ExecuteScalar())
                If (count1 > 0) Then
                    MsgBox("Log In Succeed", MsgBoxStyle.Information)
                    UserForm.sqlString = "SELECT photo FROM StudentAppointment WHERE usRnhame = '" & BunifuTextBox1.Text & "'"
                    UserForm.sqlString1 = "SELECT barCodenum FROM StudentAppointment WHERE usRnhame = '" & BunifuTextBox1.Text & "'"

                    UserForm.Show()
                    Me.Close()
                Else

                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registry.Show()
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        scanAbarcode.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        RegisterAdmin.Show()
    End Sub
End Class