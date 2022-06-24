<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoriesAvailability
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel_Accessories = New System.Windows.Forms.Panel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.dgv_UserAccessories = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btn_ProfBorrow = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_Accessories.SuspendLayout()
        CType(Me.dgv_UserAccessories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_Accessories
        '
        Me.panel_Accessories.Controls.Add(Me.btn_Cancel)
        Me.panel_Accessories.Controls.Add(Me.btn_Back)
        Me.panel_Accessories.Controls.Add(Me.lblTime)
        Me.panel_Accessories.Controls.Add(Me.dgv_UserAccessories)
        Me.panel_Accessories.Controls.Add(Me.btn_ProfBorrow)
        Me.panel_Accessories.Controls.Add(Me.lblDate)
        Me.panel_Accessories.Controls.Add(Me.Label5)
        Me.panel_Accessories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Accessories.Location = New System.Drawing.Point(0, 0)
        Me.panel_Accessories.Name = "panel_Accessories"
        Me.panel_Accessories.Size = New System.Drawing.Size(1004, 646)
        Me.panel_Accessories.TabIndex = 14
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(105, 570)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(135, 45)
        Me.btn_Back.TabIndex = 9
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'dgv_UserAccessories
        '
        Me.dgv_UserAccessories.AllowUserToAddRows = False
        Me.dgv_UserAccessories.AllowUserToResizeColumns = False
        Me.dgv_UserAccessories.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dgv_UserAccessories.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_UserAccessories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_UserAccessories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_UserAccessories.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserAccessories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_UserAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_UserAccessories.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_UserAccessories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_UserAccessories.Location = New System.Drawing.Point(105, 162)
        Me.dgv_UserAccessories.Name = "dgv_UserAccessories"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserAccessories.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_UserAccessories.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_UserAccessories.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_UserAccessories.RowTemplate.Height = 24
        Me.dgv_UserAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_UserAccessories.Size = New System.Drawing.Size(785, 383)
        Me.dgv_UserAccessories.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(355, 59)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ACCESSORIES"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(331, 563)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(148, 59)
        Me.btn_Cancel.TabIndex = 21
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(870, 83)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(51, 17)
        Me.lblTime.TabIndex = 20
        Me.lblTime.Text = "Label1"
        Me.lblTime.Visible = False
        '
        'btn_ProfBorrow
        '
        Me.btn_ProfBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ProfBorrow.FlatAppearance.BorderSize = 0
        Me.btn_ProfBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ProfBorrow.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfBorrow.ForeColor = System.Drawing.Color.White
        Me.btn_ProfBorrow.Location = New System.Drawing.Point(542, 563)
        Me.btn_ProfBorrow.Name = "btn_ProfBorrow"
        Me.btn_ProfBorrow.Size = New System.Drawing.Size(147, 59)
        Me.btn_ProfBorrow.TabIndex = 18
        Me.btn_ProfBorrow.Text = "Prof Borrow"
        Me.btn_ProfBorrow.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(870, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 17)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Label1"
        Me.lblDate.Visible = False
        '
        'Timer1
        '
        '
        'AccessoriesAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 646)
        Me.Controls.Add(Me.panel_Accessories)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccessoriesAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccessoriesAvailability"
        Me.panel_Accessories.ResumeLayout(False)
        Me.panel_Accessories.PerformLayout()
        CType(Me.dgv_UserAccessories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Accessories As System.Windows.Forms.Panel
    Friend WithEvents dgv_UserAccessories As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btn_ProfBorrow As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
