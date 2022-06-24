<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartingForm
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
        Me.btn_UsersPortal = New System.Windows.Forms.Button()
        Me.btn_AdminsPortal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_UsersPortal
        '
        Me.btn_UsersPortal.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_UsersPortal.FlatAppearance.BorderSize = 0
        Me.btn_UsersPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UsersPortal.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UsersPortal.ForeColor = System.Drawing.Color.White
        Me.btn_UsersPortal.Location = New System.Drawing.Point(131, 131)
        Me.btn_UsersPortal.Name = "btn_UsersPortal"
        Me.btn_UsersPortal.Size = New System.Drawing.Size(279, 73)
        Me.btn_UsersPortal.TabIndex = 0
        Me.btn_UsersPortal.Text = "Users/Students"
        Me.btn_UsersPortal.UseVisualStyleBackColor = False
        '
        'btn_AdminsPortal
        '
        Me.btn_AdminsPortal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_AdminsPortal.FlatAppearance.BorderSize = 0
        Me.btn_AdminsPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AdminsPortal.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AdminsPortal.ForeColor = System.Drawing.Color.White
        Me.btn_AdminsPortal.Location = New System.Drawing.Point(104, 267)
        Me.btn_AdminsPortal.Name = "btn_AdminsPortal"
        Me.btn_AdminsPortal.Size = New System.Drawing.Size(322, 73)
        Me.btn_AdminsPortal.TabIndex = 0
        Me.btn_AdminsPortal.Text = "Moderator And Admin"
        Me.btn_AdminsPortal.UseVisualStyleBackColor = False
        '
        'StartingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 454)
        Me.Controls.Add(Me.btn_AdminsPortal)
        Me.Controls.Add(Me.btn_UsersPortal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartingForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_UsersPortal As System.Windows.Forms.Button
    Friend WithEvents btn_AdminsPortal As System.Windows.Forms.Button
End Class
