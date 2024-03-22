Imports System.Data.OleDb
Public Class RegisterAdmin
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Dim cmd As New OleDbCommand
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Try
            connClass.OpenConnection()
            Dim sqlstring2 As String
            sqlstring2 = "INSERT INTO adminUser (usrLogin, userpass, fullName) VALUES (@usrLogin, @userpass, @fullName)"
            With cmd
                .Connection = connClass.conn
                .CommandText = sqlstring2
                .Parameters.AddWithValue("@usrLogin", userName.Text)
                .Parameters.AddWithValue("@userpass", password.Text)
                .Parameters.AddWithValue("@fullName", fullName.Text)
            End With

            Dim r As Integer

            r = cmd.ExecuteNonQuery()

            connClass.closeCOn()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class