Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class BUTTONREPORTS
    Public conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dset As DataSet
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim sqlString As String = ""
    Dim qrCodeString As String = ""
    Public dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cresenz\OneDrive - Technological University of the Philippines\Documents\Contact Tracing.accdb"

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()

    End Sub

    Private Sub BUTTONREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cresenz\OneDrive - Technological University of the Philippines\Documents\Contact Tracing.accdb"
        conn.Open()
        MsgBox("Connected!")
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim crystal As New ReportDocument
        crystal.Load("D:\Download Shits\Cp3 Final Project Contact Tracing Database System\Cp3 Final Project Contact Tracing Database System\contactTracing\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()
    End Sub
End Class