<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_UpdatePayment
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
        Me.components = New System.ComponentModel.Container()
        Me.txtbox_StudentNumber = New System.Windows.Forms.TextBox()
        Me.txtbox_ItemBorrowed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.txtbox_Amount = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_StudentNumber
        '
        Me.txtbox_StudentNumber.Enabled = False
        Me.txtbox_StudentNumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_StudentNumber.Location = New System.Drawing.Point(141, 191)
        Me.txtbox_StudentNumber.Name = "txtbox_StudentNumber"
        Me.txtbox_StudentNumber.Size = New System.Drawing.Size(229, 32)
        Me.txtbox_StudentNumber.TabIndex = 0
        '
        'txtbox_ItemBorrowed
        '
        Me.txtbox_ItemBorrowed.Enabled = False
        Me.txtbox_ItemBorrowed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_ItemBorrowed.Location = New System.Drawing.Point(141, 269)
        Me.txtbox_ItemBorrowed.Name = "txtbox_ItemBorrowed"
        Me.txtbox_ItemBorrowed.Size = New System.Drawing.Size(229, 32)
        Me.txtbox_ItemBorrowed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Borrowed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount of Payment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 66)
        Me.Panel1.TabIndex = 3
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(43, 441)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(177, 55)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Update.FlatAppearance.BorderSize = 0
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Location = New System.Drawing.Point(252, 441)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(177, 55)
        Me.btn_Update.TabIndex = 4
        Me.btn_Update.Text = "Pay"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'txtbox_Amount
        '
        Me.txtbox_Amount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Amount.Location = New System.Drawing.Point(141, 346)
        Me.txtbox_Amount.Name = "txtbox_Amount"
        Me.txtbox_Amount.Size = New System.Drawing.Size(229, 32)
        Me.txtbox_Amount.TabIndex = 1
        '
        'Timer1
        '
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(297, 82)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(59, 23)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        Me.lblDate.Visible = False
        '
        'Admin_UpdatePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 538)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_Amount)
        Me.Controls.Add(Me.txtbox_ItemBorrowed)
        Me.Controls.Add(Me.txtbox_StudentNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_UpdatePayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_UpdatePayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox_StudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_ItemBorrowed As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents txtbox_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDate As System.Windows.Forms.Label
End Class
