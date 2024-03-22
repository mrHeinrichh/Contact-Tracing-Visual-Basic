Imports System.Data.OleDb
Public Class manageRecrd
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        editUpdatebtn.MdiParent = AdminForm
        editUpdatebtn.Dock = DockStyle.Fill
        editUpdatebtn.Show()
    End Sub
    Private Sub manageRecrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Refresh.Click
        sqlString = "SELECT full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse, barCodenum FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        GunaDataGridView1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        deleteButton.MdiParent = AdminForm
        deleteButton.Dock = DockStyle.Fill
        deleteButton.Show()
    End Sub

    Private Sub BunifuButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        insertButton.MdiParent = AdminForm
        insertButton.Dock = DockStyle.Fill
        insertButton.Show()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim dt As New DataTable
        With dt
            .Columns.Add("full_name")
            .Columns.Add("age")
            .Columns.Add("gender")
            .Columns.Add("contactNum")
            .Columns.Add("Vaccination_Status")
            .Columns.Add("Address")
            .Columns.Add("Email_Address")
            .Columns.Add("DepartmentCourse")
            .Columns.Add("barCodenum")
        End With
        For Each dr As DataGridViewRow In Me.GunaDataGridView1.Rows
            dt.Rows.Add(dr.Cells("full_name").Value, dr.Cells("age").Value, dr.Cells("gender").Value, dr.Cells("contactNum").Value, dr.Cells("Vaccination_Status").Value, dr.Cells("Address").Value, dr.Cells("DepartmentCourse").Value, dr.Cells("barCodenum").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport2
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub
End Class