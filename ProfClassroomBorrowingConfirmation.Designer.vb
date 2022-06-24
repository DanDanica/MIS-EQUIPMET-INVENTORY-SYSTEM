<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfClassroomBorrowingConfirmation
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
        Me.txtbox_ItemBorrow = New System.Windows.Forms.TextBox()
        Me.txtbox_Condition = New System.Windows.Forms.TextBox()
        Me.txtbox_StudentNumber = New System.Windows.Forms.TextBox()
        Me.txtbox_Availability = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_TermsAndAgreement = New System.Windows.Forms.CheckBox()
        Me.bt_ProceedBorrowing = New System.Windows.Forms.Button()
        Me.link_TermsAndAgreement = New System.Windows.Forms.LinkLabel()
        Me.txt_RoomNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_CancelBorrowing = New System.Windows.Forms.Button()
        Me.cmb_Class = New System.Windows.Forms.ComboBox()
        Me.cmb_Department = New System.Windows.Forms.ComboBox()
        Me.txtbox_ProfName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_ItemBorrow
        '
        Me.txtbox_ItemBorrow.Location = New System.Drawing.Point(23, 57)
        Me.txtbox_ItemBorrow.Name = "txtbox_ItemBorrow"
        Me.txtbox_ItemBorrow.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_ItemBorrow.TabIndex = 29
        Me.txtbox_ItemBorrow.Visible = False
        '
        'txtbox_Condition
        '
        Me.txtbox_Condition.Location = New System.Drawing.Point(84, 57)
        Me.txtbox_Condition.Name = "txtbox_Condition"
        Me.txtbox_Condition.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_Condition.TabIndex = 30
        Me.txtbox_Condition.Visible = False
        '
        'txtbox_StudentNumber
        '
        Me.txtbox_StudentNumber.Location = New System.Drawing.Point(152, 57)
        Me.txtbox_StudentNumber.Name = "txtbox_StudentNumber"
        Me.txtbox_StudentNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_StudentNumber.TabIndex = 31
        Me.txtbox_StudentNumber.Visible = False
        '
        'txtbox_Availability
        '
        Me.txtbox_Availability.Location = New System.Drawing.Point(207, 57)
        Me.txtbox_Availability.Name = "txtbox_Availability"
        Me.txtbox_Availability.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_Availability.TabIndex = 28
        Me.txtbox_Availability.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "I accept the"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 51)
        Me.Panel1.TabIndex = 20
        '
        'cb_TermsAndAgreement
        '
        Me.cb_TermsAndAgreement.AutoSize = True
        Me.cb_TermsAndAgreement.Location = New System.Drawing.Point(149, 445)
        Me.cb_TermsAndAgreement.Name = "cb_TermsAndAgreement"
        Me.cb_TermsAndAgreement.Size = New System.Drawing.Size(18, 17)
        Me.cb_TermsAndAgreement.TabIndex = 26
        Me.cb_TermsAndAgreement.UseVisualStyleBackColor = True
        '
        'bt_ProceedBorrowing
        '
        Me.bt_ProceedBorrowing.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.bt_ProceedBorrowing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_ProceedBorrowing.FlatAppearance.BorderSize = 0
        Me.bt_ProceedBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ProceedBorrowing.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ProceedBorrowing.ForeColor = System.Drawing.Color.White
        Me.bt_ProceedBorrowing.Location = New System.Drawing.Point(269, 487)
        Me.bt_ProceedBorrowing.Name = "bt_ProceedBorrowing"
        Me.bt_ProceedBorrowing.Size = New System.Drawing.Size(127, 48)
        Me.bt_ProceedBorrowing.TabIndex = 24
        Me.bt_ProceedBorrowing.Text = "Borrow"
        Me.bt_ProceedBorrowing.UseVisualStyleBackColor = False
        '
        'link_TermsAndAgreement
        '
        Me.link_TermsAndAgreement.AutoSize = True
        Me.link_TermsAndAgreement.Location = New System.Drawing.Point(258, 444)
        Me.link_TermsAndAgreement.Name = "link_TermsAndAgreement"
        Me.link_TermsAndAgreement.Size = New System.Drawing.Size(147, 17)
        Me.link_TermsAndAgreement.TabIndex = 25
        Me.link_TermsAndAgreement.TabStop = True
        Me.link_TermsAndAgreement.Text = "Terms And Conditions"
        '
        'txt_RoomNumber
        '
        Me.txt_RoomNumber.AutoSize = True
        Me.txt_RoomNumber.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RoomNumber.Location = New System.Drawing.Point(172, 122)
        Me.txt_RoomNumber.Name = "txt_RoomNumber"
        Me.txt_RoomNumber.Size = New System.Drawing.Size(160, 22)
        Me.txt_RoomNumber.TabIndex = 21
        Me.txt_RoomNumber.Text = "(Room selected)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "You are about to borrow"
        '
        'btn_CancelBorrowing
        '
        Me.btn_CancelBorrowing.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_CancelBorrowing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelBorrowing.FlatAppearance.BorderSize = 0
        Me.btn_CancelBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CancelBorrowing.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelBorrowing.ForeColor = System.Drawing.Color.White
        Me.btn_CancelBorrowing.Location = New System.Drawing.Point(96, 487)
        Me.btn_CancelBorrowing.Name = "btn_CancelBorrowing"
        Me.btn_CancelBorrowing.Size = New System.Drawing.Size(127, 48)
        Me.btn_CancelBorrowing.TabIndex = 23
        Me.btn_CancelBorrowing.Text = "Cancel"
        Me.btn_CancelBorrowing.UseVisualStyleBackColor = False
        '
        'cmb_Class
        '
        Me.cmb_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Class.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Class.FormattingEnabled = True
        Me.cmb_Class.Items.AddRange(New Object() {"1-A", "1-B", "1-C", "1-D", "2-A", "2-B", "2-C", "2-D", "3-A", "3-B", "3-C", "3-D", "4-A", "4-B", "4-C", "4-D"})
        Me.cmb_Class.Location = New System.Drawing.Point(176, 375)
        Me.cmb_Class.Name = "cmb_Class"
        Me.cmb_Class.Size = New System.Drawing.Size(156, 28)
        Me.cmb_Class.TabIndex = 37
        '
        'cmb_Department
        '
        Me.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Department.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Items.AddRange(New Object() {"BSCS", "BSIT", "BSEMC", "BSIS"})
        Me.cmb_Department.Location = New System.Drawing.Point(175, 318)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(156, 28)
        Me.cmb_Department.TabIndex = 38
        '
        'txtbox_ProfName
        '
        Me.txtbox_ProfName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_ProfName.Location = New System.Drawing.Point(175, 253)
        Me.txtbox_ProfName.Name = "txtbox_ProfName"
        Me.txtbox_ProfName.Size = New System.Drawing.Size(157, 26)
        Me.txtbox_ProfName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Program"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Name of Professor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 44)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Please provide the needed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       information below"
        '
        'ProfClassroomBorrowingConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 567)
        Me.Controls.Add(Me.cmb_Class)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.txtbox_ProfName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbox_ItemBorrow)
        Me.Controls.Add(Me.txtbox_Condition)
        Me.Controls.Add(Me.txtbox_StudentNumber)
        Me.Controls.Add(Me.txtbox_Availability)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cb_TermsAndAgreement)
        Me.Controls.Add(Me.bt_ProceedBorrowing)
        Me.Controls.Add(Me.link_TermsAndAgreement)
        Me.Controls.Add(Me.txt_RoomNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_CancelBorrowing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfClassroomBorrowingConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfClassroomBorrowingConfirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox_ItemBorrow As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_Condition As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_StudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_Availability As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_TermsAndAgreement As System.Windows.Forms.CheckBox
    Friend WithEvents bt_ProceedBorrowing As System.Windows.Forms.Button
    Friend WithEvents link_TermsAndAgreement As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_RoomNumber As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_CancelBorrowing As System.Windows.Forms.Button
    Friend WithEvents cmb_Class As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents txtbox_ProfName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
