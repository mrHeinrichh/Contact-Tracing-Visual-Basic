Imports System.Data.OleDb
Public Class editAccount
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub editAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlString = "SELECT * FROM adminUser"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        sqlString = "UPDATE adminUser Set usrLogin = '" & userName.Text & "', userpass = '" & pasword.Text & "', fullName = '" & fullName.Text & "'"
        connClass.updateFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
        sqlString = "SELECT * FROM adminUser"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub
End Class