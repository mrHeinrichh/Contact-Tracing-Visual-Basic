Imports System.Data.OleDb
Imports BarcodeLib
Public Class Registry
    Dim image_path As String
    Dim path As String
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim connClass As ConnectToDB = New ConnectToDB
    Dim cmd As New OleDb.OleDbCommand
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Try
            Dim barcode As Barcode = New Barcode()
            Dim foreColor As Color = Color.White
            Dim backColor As Color = Color.Transparent
            Dim image As Image = barcode.Encode(TYPE.UPCA, barCodetxt.Text, foreColor, backColor, CInt(picBcodes.Width * 0.8), CInt(picBcodes.Height * 0.8))
            picBcodes.Image = image
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If picBcodes.Image Is Nothing Then
            Return
        End If
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            picBcodes.Image.Save(saveFileDialog.FileName)
        End If
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles contour.Click
        saveRegInfo()
        healthCondiInfo()
        vaccineInfo()
        logIng()
        bago()
        newz()
        cmd.Parameters.Clear()
        If slotz.Text = "25" Then
            contour.Enabled = False
        End If
    End Sub
    Private Sub logIng()
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()
        photo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        'mstream.Close()
        connClass.OpenConnection()
        Dim cmd99 As New OleDbCommand
        Dim sqlString445 As String = "INSERT INTO StudentAppointment(usRnhame,pashwurd,barCodenum,photo) VALUES (@usRnhame, @pashwurd,@barCodenum,@photo)"
        With cmd99
            .Connection = connClass.conn
            .CommandText = sqlString445
            .Parameters.AddWithValue("@usRnhame", userName.Text)
            .Parameters.AddWithValue("@pashwurd", passWrd.Text)
            .Parameters.AddWithValue("@barCodenum", barCodetxt.Text)
            .Parameters.AddWithValue("@photo", arrImage)
        End With
        Dim h As Integer
        h = cmd99.ExecuteNonQuery()
        connClass.closeCOn()
    End Sub

    Private Sub saveRegInfo()
        'save bytes to database
        Dim arrImage1() As Byte
        Dim mstream1 As New System.IO.MemoryStream()
        photo.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage1 = mstream1.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream1.Length
        mstream1.Close()

        cmd.Connection = connClass.conn
        connClass.OpenConnection()
        Dim sqlString As String = "INSERT INTO People (full_name, age, gender, contactNum, Vaccination_Status, Address, Email_Address, DepartmentCourse, barCodenum, photo) VALUES (@full_name,@age,gender,@contactNum,@Vaccination_Status,@Address,@Email_Address,@DepartmentCourse,@barCodenum, @photo)"
        With cmd
            .Connection = connClass.conn
            .CommandText = sqlString
            .Parameters.AddWithValue("@full_name", full_name.Text)
            .Parameters.AddWithValue("@age", age.Text)
            .Parameters.AddWithValue("@gender", gender.Text)
            .Parameters.AddWithValue("@contactNum", contactNum.Text)
            .Parameters.AddWithValue("@Vaccination_Status", vacstats.Text)
            .Parameters.AddWithValue("@Address", Address.Text)
            .Parameters.AddWithValue("@Email_Address", Email_Address.Text)
            .Parameters.AddWithValue("@DepartmentCourse", deptCourse.Text)
            .Parameters.AddWithValue("@barCodenum", barCodetxt.Text)
            .Parameters.AddWithValue("@photo", arrImage1)
        End With
        Dim b As Integer
        b = cmd.ExecuteNonQuery()
        connClass.closeCOn()
    End Sub

    Private Sub healthCondiInfo()
        Dim cmd2 As New OleDbCommand
        connClass.OpenConnection()

        Dim sqlString1 As String = "INSERT INTO Health_Condition (fever,drycough,tiredness,sorethroat,barCodenum) VALUES (@fever,@drycough,@tiredness,@sorethroat,@barCodenum)"
        With cmd2
            .Connection = connClass.conn
            .CommandText = sqlString1
            .Parameters.AddWithValue("@fever", asn1.Text)
            .Parameters.AddWithValue("@drycough", ans2.Text)
            .Parameters.AddWithValue("@tiredness", ans3.Text)
            .Parameters.AddWithValue("@sorethroat", ans4.Text)
            .Parameters.AddWithValue("@barCodenum", barCodetxt.Text)
        End With
        Dim c As Integer
        c = cmd2.ExecuteNonQuery()
        connClass.closeCOn()
    End Sub
    Private Sub vaccineInfo()
        Dim cmd3 As New OleDbCommand
        connClass.OpenConnection()
        Dim sqlString3 As String = "INSERT INTO Vaccine (vaccineCategory,vaccineStatus,barCodenum) VALUES (@vaccineCat,@vaccineStat,@barCodenum)"
        With cmd3
            .Connection = connClass.conn
            .CommandText = sqlString3
            .Parameters.AddWithValue("@vaccineCat", vacCat.Text)
            .Parameters.AddWithValue("@vaccineStat", vacstats.Text)
            .Parameters.AddWithValue("@barCodenum", barCodetxt.Text)
        End With
        Dim a As Integer
        a = cmd3.ExecuteNonQuery()
        connClass.closeCOn()
    End Sub
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            path = OpenFileDialog1.FileName
            Dim destination = OpenFileDialog1.SafeFileName
            image_path = "D:\Photo\" & destination
            photo.ImageLocation = path
        End If
    End Sub
    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        photo.Image = Nothing
    End Sub
    Private Sub newz()
        cmd.Connection = connClass.conn
        connClass.OpenConnection()
        Dim user_cmd1 As New OleDbCommand
        Dim user_start1 As String
        Dim StudentAppointment1 As String
        user_start1 = "SELECT COUNT(*) FROM schedule WHERE dateofSched='" & Format(BunifuDatepicker1.Value, "yyyy/MM/dd").Trim().ToString() & "' GROUP BY dateofSched;"
        user_cmd1 = New OleDbCommand(user_start1, connClass.conn)
        slotz.Text = user_cmd1.ExecuteScalar()
        Console.WriteLine(user_cmd1.ExecuteScalar())
    End Sub
    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged
        newz()
        detourz.Text = Format(BunifuDatepicker1.Value, "yyyy/MM/dd")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        timeAppoint.Text = ComboBox1.Text
    End Sub

    Private Sub Registry_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Refresh.Click
        If slotz.Text = "25" Then
            contour.Enabled = False
        End If
    End Sub
    Private Sub bago()
        Dim cmd37 As New OleDbCommand
        connClass.OpenConnection()
        Dim sqlString333 As String = "INSERT INTO schedule (name,purpose,dateofSched,barCodenum,timeIn) VALUES (@name,@purpose,@dateofSched,@barCodenum,@timeIn)"
        With cmd37
            .Connection = connClass.conn
            .CommandText = sqlString333
            .Parameters.AddWithValue("@name", full_name.Text)
            .Parameters.AddWithValue("@purpose", purPose.Text)
            .Parameters.AddWithValue("@dateofSched", detourz.Text)
            .Parameters.AddWithValue("@barCodenum", barCodetxt.Text)
            .Parameters.AddWithValue("@timeIn", timeAppoint.Text)
        End With
        Dim a6 As Integer
        a6 = cmd37.ExecuteNonQuery()
        connClass.closeCOn()

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click

    End Sub
End Class