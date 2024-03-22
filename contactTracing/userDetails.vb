Imports System.Data.OleDb
Imports BarcodeLib

Public Class userDetails
    Dim dt As DataTable = New DataTable
    Dim dx As DataTable = New DataTable
    Dim dr As DataTable = New DataTable
    Public sqlString As String = ""
    Public sqlstr1 As String = ""
    Public sqlstr2 As String = ""
    Public sched1 As String = ""
    Dim qrCodeString As String = ""
    'instantiate ConnectToDB Class
    Dim cmd As New OleDb.OleDbCommand
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub userDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sched1 = "SELECT name, purpose, dateofSched FROM schedule WHERE barCodenum = '" & UserForm.Label1.Text & "'"
        sqlstr2 = "SELECT full_name, age, gender,contactNum,Address,Email_Address,DepartmentCourse FROM People WHERE barCodenum = '" & UserForm.Label1.Text & "'"
        Try
            connClass.OpenConnection()
            dx = connClass.selectFrom(sqlstr2)
            full_name.Text = dx.Rows(0).Item("full_name").ToString()
            age.Text = dx.Rows(0).Item("age").ToString()
            gender.Text = dx.Rows(0).Item("gender").ToString()
            contactNum.Text = dx.Rows(0).Item("contactNum").ToString()
            addr.Text = dx.Rows(0).Item("Address").ToString()
            eaddr.Text = dx.Rows(0).Item("Email_Address").ToString()
            deptC.Text = dx.Rows(0).Item("DepartmentCourse").ToString()
        Catch ex As Exception
        End Try
        Try
            connClass.OpenConnection()
            dr = connClass.selectFrom(sched1)
        Catch ex As Exception
        End Try
        connClass.closeCOn()
    End Sub
End Class