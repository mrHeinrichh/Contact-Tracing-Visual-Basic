Imports System.Data.OleDb
Public Class editUpdatebtn
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub editUpdatebtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlString = "SELECT full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse, barCodenum FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView2.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        sqlString = "UPDATE People Set full_name = '" & full_name.Text & "', age = '" & Val(age.Text) & "', gender = '" & gender.Text & "', contactNum = '" & contactNum.Text & "', Vaccination_Status = '" & Vaccstat.Text & "', Address = '" & addr.Text & "', Email_Address = '" & Eaddr.Text & "', DepartmentCourse = '" & DeptCourse.Text & "' WHERE people_id =" & customID.Text & ""
        connClass.updateFrom(sqlString)
        GunaDataGridView2.DataSource = mydatarecords
        sqlString = "SELECT people_ID, full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView2.DataSource = mydatarecords
    End Sub
End Class