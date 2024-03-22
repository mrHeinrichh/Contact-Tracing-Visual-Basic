Imports System.Data.OleDb
Public Class logHistoryAppointment
    Dim mydatarecords As DataTable = New DataTable
    Dim sqlString As String = ""
    Dim connClass As ConnectToDB = New ConnectToDB
    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs)
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM LogofTransac WHERE barCodenum ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub logHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlString = "SELECT * FROM LogofTransac"
        mydatarecords = connClass.selectFrom(sqlString)
        Dgrid1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
        sqlString = "SELECT * FROM StudentAppointment"
        mydatarecords = connClass.selectFrom(sqlString)
        Dgrid1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs)
        sqlString = "SELECT * FROM LogofTransac"
        mydatarecords = connClass.selectFrom(sqlString)
        Dgrid1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs)
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE Building ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs)
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE DateIn ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs)
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE TimeIn ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs)
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE purpose ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged
        Try
            bCode.Text = Format(BunifuDatepicker1.Value, "yyyy/MM/dd")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        sqlString = "SELECT * FROM StudentAppointment"
        mydatarecords = connClass.selectFrom(sqlString)
        Dgrid1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton12_Click(sender As Object, e As EventArgs) Handles BunifuButton12.Click
        sqlString = "SELECT * FROM LogofTransac"
        mydatarecords = connClass.selectFrom(sqlString)
        Dgrid1.DataSource = mydatarecords
    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles BunifuButton9.Click
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE Building ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton10_Click(sender As Object, e As EventArgs) Handles BunifuButton10.Click
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM LogofTransac WHERE barCodenum ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton11_Click(sender As Object, e As EventArgs) Handles BunifuButton11.Click
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE DateIn ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton13_Click(sender As Object, e As EventArgs) Handles BunifuButton13.Click
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE TimeIn ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub

    Private Sub BunifuButton14_Click(sender As Object, e As EventArgs) Handles BunifuButton14.Click
        Try
            mydatarecords = connClass.selectFrom("SELECT * FROM StudentAppointment WHERE purpose ='" & bCode.Text & "'")
            If (mydatarecords.Rows.Count > 0) Then
                Dgrid1.DataSource = mydatarecords
            Else
                MessageBox.Show("Not Found!")
            End If
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
    End Sub
End Class