<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdmin_AddNewUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_ProceedAdding = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxStudentNumberAdmin = New System.Windows.Forms.TextBox()
        Me.txtbxUsernameAdmin = New System.Windows.Forms.TextBox()
        Me.txtbxPasswordAdmin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 61)
        Me.Panel1.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(64, 454)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(143, 49)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_ProceedAdding
        '
        Me.btn_ProceedAdding.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ProceedAdding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ProceedAdding.FlatAppearance.BorderSize = 0
        Me.btn_ProceedAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ProceedAdding.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProceedAdding.ForeColor = System.Drawing.Color.White
        Me.btn_ProceedAdding.Location = New System.Drawing.Point(299, 454)
        Me.btn_ProceedAdding.Name = "btn_ProceedAdding"
        Me.btn_ProceedAdding.Size = New System.Drawing.Size(157, 49)
        Me.btn_ProceedAdding.TabIndex = 1
        Me.btn_ProceedAdding.Text = "Add New User"
        Me.btn_ProceedAdding.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'txtbxStudentNumberAdmin
        '
        Me.txtbxStudentNumberAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxStudentNumberAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStudentNumberAdmin.Location = New System.Drawing.Point(174, 194)
        Me.txtbxStudentNumberAdmin.Name = "txtbxStudentNumberAdmin"
        Me.txtbxStudentNumberAdmin.Size = New System.Drawing.Size(205, 25)
        Me.txtbxStudentNumberAdmin.TabIndex = 1
        '
        'txtbxUsernameAdmin
        '
        Me.txtbxUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxUsernameAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUsernameAdmin.Location = New System.Drawing.Point(174, 275)
        Me.txtbxUsernameAdmin.Name = "txtbxUsernameAdmin"
        Me.txtbxUsernameAdmin.Size = New System.Drawing.Size(205, 25)
        Me.txtbxUsernameAdmin.TabIndex = 2
        '
        'txtbxPasswordAdmin
        '
        Me.txtbxPasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxPasswordAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPasswordAdmin.Location = New System.Drawing.Point(174, 352)
        Me.txtbxPasswordAdmin.Name = "txtbxPasswordAdmin"
        Me.txtbxPasswordAdmin.Size = New System.Drawing.Size(205, 25)
        Me.txtbxPasswordAdmin.TabIndex = 3
        '
        'SuperAdmin_AddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 556)
        Me.Controls.Add(Me.txtbxPasswordAdmin)
        Me.Controls.Add(Me.txtbxUsernameAdmin)
        Me.Controls.Add(Me.txtbxStudentNumberAdmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ProceedAdding)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuperAdmin_AddNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperAdmin_AddNewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_ProceedAdding As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbxStudentNumberAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtbxUsernameAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtbxPasswordAdmin As System.Windows.Forms.TextBox
End Class
