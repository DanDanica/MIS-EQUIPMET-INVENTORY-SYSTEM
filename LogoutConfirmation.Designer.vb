<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoutConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogoutConfirmation))
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Yes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_User = New System.Windows.Forms.Button()
        Me.btn_super = New System.Windows.Forms.Button()
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(100, 283)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(141, 50)
        Me.btn_Cancel.TabIndex = 0
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Yes
        '
        Me.btn_Yes.BackColor = System.Drawing.Color.Red
        Me.btn_Yes.FlatAppearance.BorderSize = 0
        Me.btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Yes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Yes.ForeColor = System.Drawing.Color.White
        Me.btn_Yes.Location = New System.Drawing.Point(302, 283)
        Me.btn_Yes.Name = "btn_Yes"
        Me.btn_Yes.Size = New System.Drawing.Size(141, 50)
        Me.btn_Yes.TabIndex = 0
        Me.btn_Yes.Text = "Yes"
        Me.btn_Yes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Are you sure yout want to Log out?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 54)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(183, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 119)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & _
            " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                          "
        '
        'btn_User
        '
        Me.btn_User.BackColor = System.Drawing.Color.Red
        Me.btn_User.FlatAppearance.BorderSize = 0
        Me.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_User.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_User.ForeColor = System.Drawing.Color.White
        Me.btn_User.Location = New System.Drawing.Point(282, 283)
        Me.btn_User.Name = "btn_User"
        Me.btn_User.Size = New System.Drawing.Size(141, 50)
        Me.btn_User.TabIndex = 5
        Me.btn_User.Text = "Yes"
        Me.btn_User.UseVisualStyleBackColor = False
        '
        'btn_super
        '
        Me.btn_super.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_super.FlatAppearance.BorderSize = 0
        Me.btn_super.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_super.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_super.ForeColor = System.Drawing.Color.White
        Me.btn_super.Location = New System.Drawing.Point(66, 283)
        Me.btn_super.Name = "btn_super"
        Me.btn_super.Size = New System.Drawing.Size(141, 50)
        Me.btn_super.TabIndex = 6
        Me.btn_super.Text = "Cancel"
        Me.btn_super.UseVisualStyleBackColor = False
        '
        'btn_Admin
        '
        Me.btn_Admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Admin.FlatAppearance.BorderSize = 0
        Me.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Admin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Admin.ForeColor = System.Drawing.Color.White
        Me.btn_Admin.Location = New System.Drawing.Point(88, 283)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(141, 50)
        Me.btn_Admin.TabIndex = 6
        Me.btn_Admin.Text = "Cancel"
        Me.btn_Admin.UseVisualStyleBackColor = False
        '
        'LogoutConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 379)
        Me.Controls.Add(Me.btn_Admin)
        Me.Controls.Add(Me.btn_super)
        Me.Controls.Add(Me.btn_User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Yes)
        Me.Controls.Add(Me.btn_Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogoutConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogoutConfirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Yes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_User As System.Windows.Forms.Button
    Friend WithEvents btn_super As System.Windows.Forms.Button
    Friend WithEvents btn_Admin As System.Windows.Forms.Button
End Class
