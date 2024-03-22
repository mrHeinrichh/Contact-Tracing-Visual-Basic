Imports System.Data.OleDb
Public Class USEReditacc
    Dim cmd As New OleDbCommand
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Public Property StringPass As String
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click

        cmd.Connection = connClass.conn
        connClass.OpenConnection()
        Dim sqlString1 As String = "DELETE FROM schedule WHERE barCodenum = @ID"

        With cmd
            .Connection = connClass.conn
            .CommandText = sqlString1
            .Parameters.AddWithValue("@ID", UserForm.Label1.Text)
        End With
        Dim r As Integer
        r = cmd.ExecuteNonQuery()
        mydatarecords = connClass.selectFrom("SELECT * FROM schedule WHERE barCodenum ='" & UserForm.Label1.Text & "'")
        If (mydatarecords.Rows.Count > 0) Then
            DataGridView1.DataSource = mydatarecords
            connClass.closeCOn()
        End If
    End Sub

    Private Sub USEReditacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bcode.Text = StringPass
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM schedule WHERE barCodenum ='" & bcode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                DataGridView1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub
End Class