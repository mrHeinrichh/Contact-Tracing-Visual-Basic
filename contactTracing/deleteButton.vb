Imports System.Data.OleDb
Public Class deleteButton
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Dim cmd As New OleDbCommand
    Private Sub deleteButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlString = "SELECT people_ID, full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse, barCodenum FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        cmd.Connection = connClass.conn
        connClass.OpenConnection()
        Dim sqlString1 As String = "DELETE FROM People WHERE people_ID = @ID"

        With cmd
            .Connection = connClass.conn
            .CommandText = sqlString1
            .Parameters.AddWithValue("@ID", custom_ID.Text)
        End With
        Dim r As Integer
        r = cmd.ExecuteNonQuery()
        connClass.closeCOn()
        sqlString = "SELECT people_ID, full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub

End Class