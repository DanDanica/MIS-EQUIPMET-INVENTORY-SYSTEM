<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElectronicsAvailability
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
        Me.panel_Electronics = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btn_ProfBorrow = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.dgv_UserElectronics = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_Electronics.SuspendLayout()
        CType(Me.dgv_UserElectronics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_Electronics
        '
        Me.panel_Electronics.Controls.Add(Me.btn_Cancel)
        Me.panel_Electronics.Controls.Add(Me.lblTime)
        Me.panel_Electronics.Controls.Add(Me.lblDate)
        Me.panel_Electronics.Controls.Add(Me.btn_ProfBorrow)
        Me.panel_Electronics.Controls.Add(Me.btn_Back)
        Me.panel_Electronics.Controls.Add(Me.dgv_UserElectronics)
        Me.panel_Electronics.Controls.Add(Me.Label2)
        Me.panel_Electronics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Electronics.Location = New System.Drawing.Point(0, 0)
        Me.panel_Electronics.Name = "panel_Electronics"
        Me.panel_Electronics.Size = New System.Drawing.Size(1004, 646)
        Me.panel_Electronics.TabIndex = 11
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(309, 547)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(148, 59)
        Me.btn_Cancel.TabIndex = 17
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(848, 67)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(51, 17)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Label1"
        Me.lblTime.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(848, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 17)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Label1"
        Me.lblDate.Visible = False
        '
        'btn_ProfBorrow
        '
        Me.btn_ProfBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ProfBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ProfBorrow.FlatAppearance.BorderSize = 0
        Me.btn_ProfBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ProfBorrow.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ProfBorrow.ForeColor = System.Drawing.Color.White
        Me.btn_ProfBorrow.Location = New System.Drawing.Point(520, 547)
        Me.btn_ProfBorrow.Name = "btn_ProfBorrow"
        Me.btn_ProfBorrow.Size = New System.Drawing.Size(147, 59)
        Me.btn_ProfBorrow.TabIndex = 6
        Me.btn_ProfBorrow.Text = "Prof Borrow"
        Me.btn_ProfBorrow.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(68, 554)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(135, 45)
        Me.btn_Back.TabIndex = 5
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'dgv_UserElectronics
        '
        Me.dgv_UserElectronics.AllowUserToAddRows = False
        Me.dgv_UserElectronics.AllowUserToDeleteRows = False
        Me.dgv_UserElectronics.AllowUserToResizeColumns = False
        Me.dgv_UserElectronics.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dgv_UserElectronics.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_UserElectronics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_UserElectronics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_UserElectronics.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserElectronics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_UserElectronics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_UserElectronics.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_UserElectronics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_UserElectronics.Location = New System.Drawing.Point(68, 164)
        Me.dgv_UserElectronics.Name = "dgv_UserElectronics"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserElectronics.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_UserElectronics.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_UserElectronics.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_UserElectronics.RowTemplate.Height = 24
        Me.dgv_UserElectronics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_UserElectronics.Size = New System.Drawing.Size(867, 351)
        Me.dgv_UserElectronics.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 59)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ELECTRONIC ITEMS"
        '
        'Timer1
        '
        '
        'ElectronicsAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 646)
        Me.Controls.Add(Me.panel_Electronics)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ElectronicsAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ElectronicsAvailability"
        Me.panel_Electronics.ResumeLayout(False)
        Me.panel_Electronics.PerformLayout()
        CType(Me.dgv_UserElectronics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_Electronics As System.Windows.Forms.Panel
    Friend WithEvents dgv_UserElectronics As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_ProfBorrow As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
End Class
