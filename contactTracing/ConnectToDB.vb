Imports System.Data.OleDb
Public Class ConnectToDB
    Public conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dset As DataSet
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim sqlString As String = ""
    Dim qrCodeString As String = ""
    Public dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cresenz\OneDrive - Technological University of the Philippines\Desktop\CP3 Final Project\Contact-Tracing1.accdb"
    'open connection
    Public Sub OpenConnection()
        Try
            conn = New OleDbConnection(dbcon)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub
    'select function
    Public Function selectFrom(sqlString As String) As DataTable
        'Initialized variables
        cmd = New OleDb.OleDbCommand
        da = New OleDb.OleDbDataAdapter
        dt = New DataTable

        OpenConnection()
        With cmd
            .Connection = conn
            .CommandText = sqlString
        End With

        da.SelectCommand = cmd
        da.Fill(dt)
        closeCOn()
        'return datatble
        Return dt
    End Function
    'insert function
    Public Sub insertTo(sqlString As String)
        OpenConnection()
        Dim sqlCommand As New OleDbCommand(sqlString, conn)
        sqlCommand.ExecuteNonQuery()
        closeCOn()
    End Sub
    'delete function
    Public Sub deleteFrom(sqlString As String)
        OpenConnection()
        Dim sqlCommand As New OleDbCommand(sqlString, conn)
        sqlCommand.ExecuteNonQuery()
        closeCOn()
    End Sub
    'update function
    Public Sub updateFrom(sqlString As String)
        OpenConnection()
        Dim sqlCommand As New OleDbCommand(sqlString, conn)
        sqlCommand.ExecuteNonQuery()
        closeCOn()
    End Sub
    'close connection
    Public Sub closeCOn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        Else

        End If
    End Sub
End Class
