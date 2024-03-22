Imports System.Data.OleDb
Public Class insertButton
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Dim cmd As New OleDbCommand
    Private Sub insertButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlString = "SELECT people_ID, full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub
    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        cmd.Connection = connClass.conn
        connClass.OpenConnection()

        Dim sqlString1 As String = "INSERT INTO People (full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse) VALUES (@full_name,@age,@gender,@contactNum,@Vaccination_Status,@Address,@Email_Address,@DepartmentCourse)"

        With cmd
            .Connection = connClass.conn
            .CommandText = sqlString1
            .Parameters.AddWithValue("@full_name", full_name.Text)
            .Parameters.AddWithValue("@age", age.Text)
            .Parameters.AddWithValue("@gender", gender.Text)
            .Parameters.AddWithValue("@contactNum", contactNum.Text)
            .Parameters.AddWithValue("@Vaccination_Status", Vaccstat.Text)
            .Parameters.AddWithValue("@Address", addr.Text)
            .Parameters.AddWithValue("@Email_Address", Eaddr.Text)
            .Parameters.AddWithValue("@DepartmentCourse", DeptCourse.Text)
        End With
        Dim r As Integer
        r = cmd.ExecuteNonQuery()
        connClass.closeCOn()
        sqlString = "SELECT people_ID, full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub
End Class