<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.here = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_Notice = New System.Windows.Forms.Button()
        Me.pnlAccessories = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAccessories = New System.Windows.Forms.Label()
        Me.pnlClassrooms = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClassroom = New System.Windows.Forms.Label()
        Me.pnlCleaning = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCleaningMat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlElectronics = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblElectronics = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccessories.SuspendLayout()
        Me.pnlClassrooms.SuspendLayout()
        Me.pnlCleaning.SuspendLayout()
        Me.pnlElectronics.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.MISEquipmentInventory.My.Resources.Resources.backs
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_Notice)
        Me.Panel1.Controls.Add(Me.pnlAccessories)
        Me.Panel1.Controls.Add(Me.pnlClassrooms)
        Me.Panel1.Controls.Add(Me.pnlCleaning)
        Me.Panel1.Controls.Add(Me.pnlElectronics)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-12, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1279, 751)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(1018, 281)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 235)
        Me.Panel3.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Login)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.here)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_Password)
        Me.Panel2.Controls.Add(Me.txt_Username)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(1022, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 568)
        Me.Panel2.TabIndex = 9
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Login.FlatAppearance.BorderSize = 2
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.White
        Me.Login.Location = New System.Drawing.Point(112, 419)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(104, 46)
        Me.Login.TabIndex = 3
        Me.Login.Text = "Log in"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(19, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(15, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(69, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'here
        '
        Me.here.AutoSize = True
        Me.here.BackColor = System.Drawing.Color.Transparent
        Me.here.Cursor = System.Windows.Forms.Cursors.Hand
        Me.here.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.here.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.here.Location = New System.Drawing.Point(220, 371)
        Me.here.Name = "here"
        Me.here.Size = New System.Drawing.Size(47, 29)
        Me.here.TabIndex = 4
        Me.here.Text = "here."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(32, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Create an account? Click"
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.ForeColor = System.Drawing.Color.White
        Me.txt_Password.Location = New System.Drawing.Point(62, 312)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(193, 23)
        Me.txt_Password.TabIndex = 2
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Username.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.ForeColor = System.Drawing.Color.White
        Me.txt_Username.Location = New System.Drawing.Point(62, 232)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(193, 23)
        Me.txt_Username.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(58, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "____________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(58, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(210, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "____________________"
        '
        'btn_Notice
        '
        Me.btn_Notice.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_Notice.FlatAppearance.BorderSize = 0
        Me.btn_Notice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Notice.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Notice.ForeColor = System.Drawing.Color.White
        Me.btn_Notice.Location = New System.Drawing.Point(55, 110)
        Me.btn_Notice.Name = "btn_Notice"
        Me.btn_Notice.Size = New System.Drawing.Size(184, 46)
        Me.btn_Notice.TabIndex = 8
        Me.btn_Notice.Text = "Notice"
        Me.btn_Notice.UseVisualStyleBackColor = False
        '
        'pnlAccessories
        '
        Me.pnlAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlAccessories.Controls.Add(Me.Label12)
        Me.pnlAccessories.Controls.Add(Me.Label7)
        Me.pnlAccessories.Controls.Add(Me.lblAccessories)
        Me.pnlAccessories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAccessories.Location = New System.Drawing.Point(530, 424)
        Me.pnlAccessories.Name = "pnlAccessories"
        Me.pnlAccessories.Size = New System.Drawing.Size(470, 233)
        Me.pnlAccessories.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(95, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(264, 170)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     " & _
            "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                            "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(136, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Available:"
        '
        'lblAccessories
        '
        Me.lblAccessories.AutoSize = True
        Me.lblAccessories.BackColor = System.Drawing.Color.Transparent
        Me.lblAccessories.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessories.ForeColor = System.Drawing.Color.White
        Me.lblAccessories.Location = New System.Drawing.Point(259, 194)
        Me.lblAccessories.Name = "lblAccessories"
        Me.lblAccessories.Size = New System.Drawing.Size(65, 23)
        Me.lblAccessories.TabIndex = 0
        Me.lblAccessories.Text = "Label"
        '
        'pnlClassrooms
        '
        Me.pnlClassrooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlClassrooms.Controls.Add(Me.Label11)
        Me.pnlClassrooms.Controls.Add(Me.Label8)
        Me.pnlClassrooms.Controls.Add(Me.lblClassroom)
        Me.pnlClassrooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlClassrooms.Location = New System.Drawing.Point(74, 424)
        Me.pnlClassrooms.Name = "pnlClassrooms"
        Me.pnlClassrooms.Size = New System.Drawing.Size(440, 233)
        Me.pnlClassrooms.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(117, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 170)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     " & _
            "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                            "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(150, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Available:"
        '
        'lblClassroom
        '
        Me.lblClassroom.AutoSize = True
        Me.lblClassroom.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroom.ForeColor = System.Drawing.Color.White
        Me.lblClassroom.Location = New System.Drawing.Point(274, 194)
        Me.lblClassroom.Name = "lblClassroom"
        Me.lblClassroom.Size = New System.Drawing.Size(65, 23)
        Me.lblClassroom.TabIndex = 0
        Me.lblClassroom.Text = "Label"
        '
        'pnlCleaning
        '
        Me.pnlCleaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlCleaning.Controls.Add(Me.Label6)
        Me.pnlCleaning.Controls.Add(Me.lblCleaningMat)
        Me.pnlCleaning.Controls.Add(Me.Label10)
        Me.pnlCleaning.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCleaning.Location = New System.Drawing.Point(530, 171)
        Me.pnlCleaning.Name = "pnlCleaning"
        Me.pnlCleaning.Size = New System.Drawing.Size(470, 233)
        Me.pnlCleaning.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(136, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Available:"
        '
        'lblCleaningMat
        '
        Me.lblCleaningMat.AutoSize = True
        Me.lblCleaningMat.BackColor = System.Drawing.Color.Transparent
        Me.lblCleaningMat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCleaningMat.ForeColor = System.Drawing.Color.White
        Me.lblCleaningMat.Location = New System.Drawing.Point(259, 194)
        Me.lblCleaningMat.Name = "lblCleaningMat"
        Me.lblCleaningMat.Size = New System.Drawing.Size(65, 23)
        Me.lblCleaningMat.TabIndex = 0
        Me.lblCleaningMat.Text = "Label"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(95, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 187)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     " & _
            "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlElectronics
        '
        Me.pnlElectronics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlElectronics.Controls.Add(Me.Label15)
        Me.pnlElectronics.Controls.Add(Me.Label5)
        Me.pnlElectronics.Controls.Add(Me.lblElectronics)
        Me.pnlElectronics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlElectronics.Location = New System.Drawing.Point(74, 171)
        Me.pnlElectronics.Name = "pnlElectronics"
        Me.pnlElectronics.Size = New System.Drawing.Size(440, 233)
        Me.pnlElectronics.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(130, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(220, 153)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "                                                     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(150, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Available:"
        '
        'lblElectronics
        '
        Me.lblElectronics.AutoSize = True
        Me.lblElectronics.BackColor = System.Drawing.Color.Transparent
        Me.lblElectronics.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectronics.ForeColor = System.Drawing.Color.White
        Me.lblElectronics.Location = New System.Drawing.Point(274, 194)
        Me.lblElectronics.Name = "lblElectronics"
        Me.lblElectronics.Size = New System.Drawing.Size(65, 23)
        Me.lblElectronics.TabIndex = 0
        Me.lblElectronics.Text = "Label"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(420, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 47)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "EQUIPMENTS"
        '
        'btn_Show
        '
        Me.btn_Show.BackColor = System.Drawing.Color.Transparent
        Me.btn_Show.BackgroundImage = CType(resources.GetObject("btn_Show.BackgroundImage"), System.Drawing.Image)
        Me.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Show.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_Show.FlatAppearance.BorderSize = 0
        Me.btn_Show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Show.Location = New System.Drawing.Point(1284, 422)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(39, 28)
        Me.btn_Show.TabIndex = 12
        Me.btn_Show.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Show.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1340, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccessories.ResumeLayout(False)
        Me.pnlAccessories.PerformLayout()
        Me.pnlClassrooms.ResumeLayout(False)
        Me.pnlClassrooms.PerformLayout()
        Me.pnlCleaning.ResumeLayout(False)
        Me.pnlCleaning.PerformLayout()
        Me.pnlElectronics.ResumeLayout(False)
        Me.pnlElectronics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents here As System.Windows.Forms.Label
    Friend WithEvents pnlAccessories As System.Windows.Forms.Panel
    Friend WithEvents pnlClassrooms As System.Windows.Forms.Panel
    Friend WithEvents pnlCleaning As System.Windows.Forms.Panel
    Friend WithEvents pnlElectronics As System.Windows.Forms.Panel
    Friend WithEvents lblAccessories As System.Windows.Forms.Label
    Friend WithEvents lblClassroom As System.Windows.Forms.Label
    Friend WithEvents lblCleaningMat As System.Windows.Forms.Label
    Friend WithEvents lblElectronics As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Notice As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_Show As System.Windows.Forms.Button

End Class
