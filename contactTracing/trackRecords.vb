Imports System.Data.OleDb
Public Class trackRecords
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        Try
            Dim dt As DataTable = New DataTable
            dt = connClass.selectFrom("SELECT * FROM People WHERE full_Name = '" & BunifuTextBox1.Text & "'")
            If dt.Rows.Count = 0 Then
                MsgBox("No record found!")
            Else
                Tracked.MdiParent = AdminForm
                Tracked.Dock = DockStyle.Fill
                Tracked.sqlString = "SELECT * FROM People WHERE full_Name = '" & BunifuTextBox1.Text & "'"
                Tracked.Show()
            End If
        Catch
        End Try
    End Sub
    Private Sub trackRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlString = "SELECT full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse, barCodenum FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub
End Class