<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tracked
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tracked))
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.barCodenum = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contactNum = New System.Windows.Forms.Label()
        Me.EmailAdd = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(355, 39)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(175, 175)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 0
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'barCodenum
        '
        Me.barCodenum.AutoSize = True
        Me.barCodenum.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barCodenum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.barCodenum.Location = New System.Drawing.Point(32, 81)
        Me.barCodenum.Name = "barCodenum"
        Me.barCodenum.Size = New System.Drawing.Size(237, 29)
        Me.barCodenum.TabIndex = 10
        Me.barCodenum.Text = "0984123098301923"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.age.Location = New System.Drawing.Point(32, 160)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(191, 29)
        Me.age.TabIndex = 8
        Me.age.Text = "(username age)"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gender.Location = New System.Drawing.Point(32, 119)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(233, 29)
        Me.gender.TabIndex = 6
        Me.gender.Text = "(username Gender)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(32, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "(username full name)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(337, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'contactNum
        '
        Me.contactNum.AutoSize = True
        Me.contactNum.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.contactNum.Location = New System.Drawing.Point(596, 39)
        Me.contactNum.Name = "contactNum"
        Me.contactNum.Size = New System.Drawing.Size(260, 29)
        Me.contactNum.TabIndex = 4
        Me.contactNum.Text = "(username full name)"
        '
        'EmailAdd
        '
        Me.EmailAdd.AutoSize = True
        Me.EmailAdd.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmailAdd.Location = New System.Drawing.Point(596, 81)
        Me.EmailAdd.Name = "EmailAdd"
        Me.EmailAdd.Size = New System.Drawing.Size(277, 29)
        Me.EmailAdd.TabIndex = 10
        Me.EmailAdd.Text = "(username ID Number)"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Address.Location = New System.Drawing.Point(597, 119)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(277, 29)
        Me.Address.TabIndex = 12
        Me.Address.Text = "(username ID Number)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 450)
        Me.Panel1.TabIndex = 108
        '
        'Tracked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.barCodenum)
        Me.Controls.Add(Me.EmailAdd)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.contactNum)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tracked"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tracked"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents barCodenum As Label
    Friend WithEvents age As Label
    Friend WithEvents gender As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents contactNum As Label
    Friend WithEvents EmailAdd As Label
    Friend WithEvents Address As Label
    Friend WithEvents Panel1 As Panel
End Class
