<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_SignUp = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_SignUpSuper = New System.Windows.Forms.Button()
        Me.btn_CancelSuper = New System.Windows.Forms.Button()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_TermsAndAgreement = New System.Windows.Forms.CheckBox()
        Me.link_TermsAndAgreement = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 83)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(201, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 34)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sign Up"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(143, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 68)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "           " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please fill the required Information"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtStudentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentNumber.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumber.Location = New System.Drawing.Point(133, 203)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(221, 29)
        Me.txtStudentNumber.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(133, 435)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(221, 29)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Course, Year and Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Number"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(133, 349)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(221, 29)
        Me.txtUsername.TabIndex = 5
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Items.AddRange(New Object() {"BSCS", "BSIT", "BSEMC", "BSIS"})
        Me.cmbCourse.Location = New System.Drawing.Point(117, 277)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(94, 32)
        Me.cmbCourse.TabIndex = 2
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbYear.Location = New System.Drawing.Point(223, 277)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(72, 32)
        Me.cmbYear.TabIndex = 3
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbSection.Location = New System.Drawing.Point(309, 277)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(65, 32)
        Me.cmbSection.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password"
        '
        'btn_SignUp
        '
        Me.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_SignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SignUp.FlatAppearance.BorderSize = 0
        Me.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SignUp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignUp.ForeColor = System.Drawing.Color.White
        Me.btn_SignUp.Location = New System.Drawing.Point(281, 521)
        Me.btn_SignUp.Name = "btn_SignUp"
        Me.btn_SignUp.Size = New System.Drawing.Size(118, 55)
        Me.btn_SignUp.TabIndex = 9
        Me.btn_SignUp.Text = "Sign Up"
        Me.btn_SignUp.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(116, 521)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(118, 55)
        Me.btn_Cancel.TabIndex = 8
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(70, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 68)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "           " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         "
        '
        'btn_SignUpSuper
        '
        Me.btn_SignUpSuper.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_SignUpSuper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SignUpSuper.FlatAppearance.BorderSize = 0
        Me.btn_SignUpSuper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SignUpSuper.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignUpSuper.ForeColor = System.Drawing.Color.White
        Me.btn_SignUpSuper.Location = New System.Drawing.Point(296, 521)
        Me.btn_SignUpSuper.Name = "btn_SignUpSuper"
        Me.btn_SignUpSuper.Size = New System.Drawing.Size(118, 55)
        Me.btn_SignUpSuper.TabIndex = 9
        Me.btn_SignUpSuper.Text = "Sign Up"
        Me.btn_SignUpSuper.UseVisualStyleBackColor = False
        '
        'btn_CancelSuper
        '
        Me.btn_CancelSuper.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_CancelSuper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelSuper.FlatAppearance.BorderSize = 0
        Me.btn_CancelSuper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CancelSuper.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelSuper.ForeColor = System.Drawing.Color.White
        Me.btn_CancelSuper.Location = New System.Drawing.Point(84, 521)
        Me.btn_CancelSuper.Name = "btn_CancelSuper"
        Me.btn_CancelSuper.Size = New System.Drawing.Size(118, 55)
        Me.btn_CancelSuper.TabIndex = 8
        Me.btn_CancelSuper.Text = "Cancel"
        Me.btn_CancelSuper.UseVisualStyleBackColor = False
        '
        'btn_Show
        '
        Me.btn_Show.BackColor = System.Drawing.Color.Transparent
        Me.btn_Show.BackgroundImage = CType(resources.GetObject("btn_Show.BackgroundImage"), System.Drawing.Image)
        Me.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Show.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_Show.FlatAppearance.BorderSize = 0
        Me.btn_Show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Show.Location = New System.Drawing.Point(375, 435)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(39, 28)
        Me.btn_Show.TabIndex = 11
        Me.btn_Show.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Show.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(142, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "I accept the"
        '
        'cb_TermsAndAgreement
        '
        Me.cb_TermsAndAgreement.AutoSize = True
        Me.cb_TermsAndAgreement.Location = New System.Drawing.Point(118, 484)
        Me.cb_TermsAndAgreement.Name = "cb_TermsAndAgreement"
        Me.cb_TermsAndAgreement.Size = New System.Drawing.Size(18, 17)
        Me.cb_TermsAndAgreement.TabIndex = 13
        Me.cb_TermsAndAgreement.UseVisualStyleBackColor = True
        '
        'link_TermsAndAgreement
        '
        Me.link_TermsAndAgreement.AutoSize = True
        Me.link_TermsAndAgreement.Location = New System.Drawing.Point(227, 483)
        Me.link_TermsAndAgreement.Name = "link_TermsAndAgreement"
        Me.link_TermsAndAgreement.Size = New System.Drawing.Size(147, 17)
        Me.link_TermsAndAgreement.TabIndex = 12
        Me.link_TermsAndAgreement.TabStop = True
        Me.link_TermsAndAgreement.Text = "Terms And Conditions"
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cb_TermsAndAgreement)
        Me.Controls.Add(Me.link_TermsAndAgreement)
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_CancelSuper)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_SignUpSuper)
        Me.Controls.Add(Me.btn_SignUp)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtStudentNumber)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_SignUp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_SignUpSuper As System.Windows.Forms.Button
    Friend WithEvents btn_CancelSuper As System.Windows.Forms.Button
    Friend WithEvents btn_Show As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cb_TermsAndAgreement As System.Windows.Forms.CheckBox
    Friend WithEvents link_TermsAndAgreement As System.Windows.Forms.LinkLabel
End Class
