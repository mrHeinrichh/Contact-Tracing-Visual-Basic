Imports System.Data.OleDb
Public Class btnReports
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlString = "SELECT * FROM adminUser"
        mydatarecords = connClass.selectFrom(sqlString)
        DataGridView1.DataSource = mydatarecords
        Dim dt As New DataTable
        With dt
            .Columns.Add("admin_ID")
            .Columns.Add("usrLogin")
            .Columns.Add("userpass")
            .Columns.Add("fullName")
        End With
        For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dr.Cells("admin_ID").Value, dr.Cells("usrLogin").Value, dr.Cells("userpass").Value, dr.Cells("fullName").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport3
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlString = "SELECT * FROM Health_Condition"
        mydatarecords = connClass.selectFrom(sqlString)
        DataGridView1.DataSource = mydatarecords
        Dim dt As New DataTable
        With dt
            .Columns.Add("health_ID")
            .Columns.Add("fever")
            .Columns.Add("drycough")
            .Columns.Add("tiredness")
            .Columns.Add("sorethroat")
            .Columns.Add("barCodenum")
        End With
        For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dr.Cells("health_ID").Value, dr.Cells("fever").Value, dr.Cells("drycough").Value, dr.Cells("tiredness").Value, dr.Cells("sorethroat").Value, dr.Cells("barCodenum").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport4
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sqlString = "SELECT * FROM People"
        mydatarecords = connClass.selectFrom(sqlString)
        DataGridView1.DataSource = mydatarecords
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
        For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dr.Cells("full_name").Value, dr.Cells("age").Value, dr.Cells("gender").Value, dr.Cells("contactNum").Value, dr.Cells("Vaccination_Status").Value, dr.Cells("Address").Value, dr.Cells("DepartmentCourse").Value, dr.Cells("barCodenum").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport2
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sqlString = "SELECT * FROM schedule"
        mydatarecords = connClass.selectFrom(sqlString)
        DataGridView1.DataSource = mydatarecords

        Dim dt As New DataTable
        With dt
            .Columns.Add("schedule_ID")
            .Columns.Add("name")
            .Columns.Add("purpose")
            .Columns.Add("dateofSched")
            .Columns.Add("barCodenum")
            .Columns.Add("timeIn")

        End With
        For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dr.Cells("schedule_ID").Value, dr.Cells("name").Value, dr.Cells("purpose").Value, dr.Cells("dateofSched").Value, dr.Cells("barCodenum").Value, dr.Cells("timeIn").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport5
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sqlString = "SELECT * FROM StudentAppointment"
        mydatarecords = connClass.selectFrom(sqlString)
        DataGridView1.DataSource = mydatarecords
        Dim dt As New DataTable
        With dt
            .Columns.Add("student_ID")
            .Columns.Add("usRnhame")
            .Columns.Add("pashwurd")
            .Columns.Add("barCodenum")

        End With
        For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dr.Cells("student_ID").Value, dr.Cells("usRnhame").Value, dr.Cells("pashwurd").Value, dr.Cells("barCodenum").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport6
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sqlString = "SELECT * FROM Vaccine"
        mydatarecords = connClass.selectFrom(sqlString)
        DataGridView1.DataSource = mydatarecords
        Dim dt As New DataTable
        With dt
            .Columns.Add("vaccine_ID")
            .Columns.Add("vaccineCategory")
            .Columns.Add("vaccineStatus")
            .Columns.Add("barCodenum")

        End With
        For Each dr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dr.Cells("vaccine_ID").Value, dr.Cells("vaccineCategory").Value, dr.Cells("vaccineStatus").Value, dr.Cells("barCodenum").Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport7
        rptDoc.SetDataSource(dt)

        Form1.CrystalReportViewer1.ReportSource = rptDoc
        Form1.ShowDialog()
        Form1.Dispose()
    End Sub
End Class