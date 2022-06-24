<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prof_BorrowingConfirmation
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_TermsAndAgreement = New System.Windows.Forms.CheckBox()
        Me.link_TermsAndAgreement = New System.Windows.Forms.LinkLabel()
        Me.txtbox_Availability = New System.Windows.Forms.TextBox()
        Me.txtbox_Condition = New System.Windows.Forms.TextBox()
        Me.txtbox_RoomNumber = New System.Windows.Forms.TextBox()
        Me.txtbox_StudentNumber = New System.Windows.Forms.TextBox()
        Me.txt_EnterRoomNumber = New System.Windows.Forms.TextBox()
        Me.btn_CancelBorrowing = New System.Windows.Forms.Button()
        Me.btn_ProceedBorrowing = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_ProfName = New System.Windows.Forms.TextBox()
        Me.cmb_Department = New System.Windows.Forms.ComboBox()
        Me.cmb_Class = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbox_ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtbox_ItemBorrow
        '
        Me.txtbox_ItemBorrow.Location = New System.Drawing.Point(90, 69)
        Me.txtbox_ItemBorrow.Name = "txtbox_ItemBorrow"
        Me.txtbox_ItemBorrow.Size = New System.Drawing.Size(54, 22)
        Me.txtbox_ItemBorrow.TabIndex = 20
        Me.txtbox_ItemBorrow.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "I accept the"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 51)
        Me.Panel1.TabIndex = 18
        '
        'cb_TermsAndAgreement
        '
        Me.cb_TermsAndAgreement.AutoSize = True
        Me.cb_TermsAndAgreement.Location = New System.Drawing.Point(102, 402)
        Me.cb_TermsAndAgreement.Name = "cb_TermsAndAgreement"
        Me.cb_TermsAndAgreement.Size = New System.Drawing.Size(18, 17)
        Me.cb_TermsAndAgreement.TabIndex = 17
        Me.cb_TermsAndAgreement.UseVisualStyleBackColor = True
        '
        'link_TermsAndAgreement
        '
        Me.link_TermsAndAgreement.AutoSize = True
        Me.link_TermsAndAgreement.Location = New System.Drawing.Point(211, 401)
        Me.link_TermsAndAgreement.Name = "link_TermsAndAgreement"
        Me.link_TermsAndAgreement.Size = New System.Drawing.Size(147, 17)
        Me.link_TermsAndAgreement.TabIndex = 16
        Me.link_TermsAndAgreement.TabStop = True
        Me.link_TermsAndAgreement.Text = "Terms And Conditions"
        '
        'txtbox_Availability
        '
        Me.txtbox_Availability.Location = New System.Drawing.Point(335, 69)
        Me.txtbox_Availability.Name = "txtbox_Availability"
        Me.txtbox_Availability.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_Availability.TabIndex = 15
        Me.txtbox_Availability.Visible = False
        '
        'txtbox_Condition
        '
        Me.txtbox_Condition.Location = New System.Drawing.Point(271, 69)
        Me.txtbox_Condition.Name = "txtbox_Condition"
        Me.txtbox_Condition.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_Condition.TabIndex = 14
        Me.txtbox_Condition.Visible = False
        '
        'txtbox_RoomNumber
        '
        Me.txtbox_RoomNumber.Location = New System.Drawing.Point(219, 69)
        Me.txtbox_RoomNumber.Name = "txtbox_RoomNumber"
        Me.txtbox_RoomNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_RoomNumber.TabIndex = 11
        Me.txtbox_RoomNumber.Visible = False
        '
        'txtbox_StudentNumber
        '
        Me.txtbox_StudentNumber.Location = New System.Drawing.Point(167, 69)
        Me.txtbox_StudentNumber.Name = "txtbox_StudentNumber"
        Me.txtbox_StudentNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtbox_StudentNumber.TabIndex = 12
        Me.txtbox_StudentNumber.Visible = False
        '
        'txt_EnterRoomNumber
        '
        Me.txt_EnterRoomNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EnterRoomNumber.Location = New System.Drawing.Point(179, 391)
        Me.txt_EnterRoomNumber.Name = "txt_EnterRoomNumber"
        Me.txt_EnterRoomNumber.Size = New System.Drawing.Size(157, 26)
        Me.txt_EnterRoomNumber.TabIndex = 13
        Me.txt_EnterRoomNumber.Visible = False
        '
        'btn_CancelBorrowing
        '
        Me.btn_CancelBorrowing.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_CancelBorrowing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelBorrowing.FlatAppearance.BorderSize = 0
        Me.btn_CancelBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CancelBorrowing.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelBorrowing.ForeColor = System.Drawing.Color.White
        Me.btn_CancelBorrowing.Location = New System.Drawing.Point(84, 441)
        Me.btn_CancelBorrowing.Name = "btn_CancelBorrowing"
        Me.btn_CancelBorrowing.Size = New System.Drawing.Size(127, 48)
        Me.btn_CancelBorrowing.TabIndex = 9
        Me.btn_CancelBorrowing.Text = "Cancel"
        Me.btn_CancelBorrowing.UseVisualStyleBackColor = False
        '
        'btn_ProceedBorrowing
        '
        Me.btn_ProceedBorrowing.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ProceedBorrowing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ProceedBorrowing.FlatAppearance.BorderSize = 0
        Me.btn_ProceedBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ProceedBorrowing.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProceedBorrowing.ForeColor = System.Drawing.Color.White
        Me.btn_ProceedBorrowing.Location = New System.Drawing.Point(257, 441)
        Me.btn_ProceedBorrowing.Name = "btn_ProceedBorrowing"
        Me.btn_ProceedBorrowing.Size = New System.Drawing.Size(127, 48)
        Me.btn_ProceedBorrowing.TabIndex = 10
        Me.btn_ProceedBorrowing.Text = "Borrow"
        Me.btn_ProceedBorrowing.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Please provide the needed information below"
        '
        'txtbox_ProfName
        '
        Me.txtbox_ProfName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_ProfName.Location = New System.Drawing.Point(179, 184)
        Me.txtbox_ProfName.Name = "txtbox_ProfName"
        Me.txtbox_ProfName.Size = New System.Drawing.Size(157, 26)
        Me.txtbox_ProfName.TabIndex = 21
        '
        'cmb_Department
        '
        Me.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Department.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Items.AddRange(New Object() {"BSCS", "BSIT", "BSEMC", "BSIS"})
        Me.cmb_Department.Location = New System.Drawing.Point(179, 249)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(156, 28)
        Me.cmb_Department.TabIndex = 22
        '
        'cmb_Class
        '
        Me.cmb_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Class.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Class.FormattingEnabled = True
        Me.cmb_Class.Items.AddRange(New Object() {"1-A", "1-B", "1-C", "1-D", "2-A", "2-B", "2-C", "2-D", "3-A", "3-B", "3-C", "3-D", "4-A", "4-B", "4-C", "4-D"})
        Me.cmb_Class.Location = New System.Drawing.Point(180, 306)
        Me.cmb_Class.Name = "cmb_Class"
        Me.cmb_Class.Size = New System.Drawing.Size(156, 28)
        Me.cmb_Class.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name of Professor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Program"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Class"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(330, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Room (Where the item will be used)"
        Me.Label6.Visible = False
        '
        'txtbox_ID
        '
        Me.txtbox_ID.Location = New System.Drawing.Point(397, 69)
        Me.txtbox_ID.Name = "txtbox_ID"
        Me.txtbox_ID.Size = New System.Drawing.Size(40, 22)
        Me.txtbox_ID.TabIndex = 23
        Me.txtbox_ID.Visible = False
        '
        'Prof_BorrowingConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 544)
        Me.Controls.Add(Me.txtbox_ID)
        Me.Controls.Add(Me.cmb_Class)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.txtbox_ProfName)
        Me.Controls.Add(Me.txtbox_ItemBorrow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cb_TermsAndAgreement)
        Me.Controls.Add(Me.link_TermsAndAgreement)
        Me.Controls.Add(Me.txtbox_Availability)
        Me.Controls.Add(Me.txtbox_Condition)
        Me.Controls.Add(Me.txtbox_RoomNumber)
        Me.Controls.Add(Me.txtbox_StudentNumber)
        Me.Controls.Add(Me.txt_EnterRoomNumber)
        Me.Controls.Add(Me.btn_CancelBorrowing)
        Me.Controls.Add(Me.btn_ProceedBorrowing)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prof_BorrowingConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prof_BorrowingConfirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox_ItemBorrow As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_TermsAndAgreement As System.Windows.Forms.CheckBox
    Friend WithEvents link_TermsAndAgreement As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbox_Availability As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_Condition As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_RoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_StudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_EnterRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents btn_CancelBorrowing As System.Windows.Forms.Button
    Friend WithEvents btn_ProceedBorrowing As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_ProfName As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Class As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbox_ID As System.Windows.Forms.TextBox
End Class
