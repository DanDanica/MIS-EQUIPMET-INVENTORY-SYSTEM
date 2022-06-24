<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_DeleteItem
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
        Me.cmb_Condition = New System.Windows.Forms.ComboBox()
        Me.btn_DeletingItem = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_Availability = New System.Windows.Forms.TextBox()
        Me.txt_StatusDelete = New System.Windows.Forms.TextBox()
        Me.txt_Cost = New System.Windows.Forms.TextBox()
        Me.txt_Equipments = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_Condition
        '
        Me.cmb_Condition.Enabled = False
        Me.cmb_Condition.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Condition.FormattingEnabled = True
        Me.cmb_Condition.Items.AddRange(New Object() {"Broken"})
        Me.cmb_Condition.Location = New System.Drawing.Point(24, 169)
        Me.cmb_Condition.Name = "cmb_Condition"
        Me.cmb_Condition.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Condition.TabIndex = 18
        Me.cmb_Condition.Text = "Good"
        Me.cmb_Condition.Visible = False
        '
        'btn_DeletingItem
        '
        Me.btn_DeletingItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_DeletingItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DeletingItem.FlatAppearance.BorderSize = 0
        Me.btn_DeletingItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeletingItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeletingItem.ForeColor = System.Drawing.Color.White
        Me.btn_DeletingItem.Location = New System.Drawing.Point(315, 297)
        Me.btn_DeletingItem.Name = "btn_DeletingItem"
        Me.btn_DeletingItem.Size = New System.Drawing.Size(119, 49)
        Me.btn_DeletingItem.TabIndex = 16
        Me.btn_DeletingItem.Text = "Yes"
        Me.btn_DeletingItem.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(144, 297)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(110, 49)
        Me.btn_Cancel.TabIndex = 17
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'txt_Availability
        '
        Me.txt_Availability.Enabled = False
        Me.txt_Availability.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Availability.Location = New System.Drawing.Point(315, 252)
        Me.txt_Availability.Name = "txt_Availability"
        Me.txt_Availability.Size = New System.Drawing.Size(244, 28)
        Me.txt_Availability.TabIndex = 13
        Me.txt_Availability.Text = "Available"
        Me.txt_Availability.Visible = False
        '
        'txt_StatusDelete
        '
        Me.txt_StatusDelete.Enabled = False
        Me.txt_StatusDelete.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StatusDelete.Location = New System.Drawing.Point(24, 252)
        Me.txt_StatusDelete.Name = "txt_StatusDelete"
        Me.txt_StatusDelete.Size = New System.Drawing.Size(244, 28)
        Me.txt_StatusDelete.TabIndex = 12
        Me.txt_StatusDelete.Text = "Active"
        Me.txt_StatusDelete.Visible = False
        '
        'txt_Cost
        '
        Me.txt_Cost.Enabled = False
        Me.txt_Cost.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cost.Location = New System.Drawing.Point(315, 170)
        Me.txt_Cost.Name = "txt_Cost"
        Me.txt_Cost.Size = New System.Drawing.Size(244, 28)
        Me.txt_Cost.TabIndex = 15
        Me.txt_Cost.Visible = False
        '
        'txt_Equipments
        '
        Me.txt_Equipments.Enabled = False
        Me.txt_Equipments.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Equipments.Location = New System.Drawing.Point(315, 96)
        Me.txt_Equipments.Name = "txt_Equipments"
        Me.txt_Equipments.Size = New System.Drawing.Size(244, 28)
        Me.txt_Equipments.TabIndex = 14
        Me.txt_Equipments.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(309, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 34)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Availability"
        Me.Label6.Visible = False
        '
        'txt_ID
        '
        Me.txt_ID.Enabled = False
        Me.txt_ID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(24, 96)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(244, 28)
        Me.txt_ID.TabIndex = 11
        Me.txt_ID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status Delete"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(309, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cost"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 34)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Condition"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Item Name"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        Me.Label1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 59)
        Me.Panel1.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(431, 40)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Are you sure you want to delete this item?"
        '
        'Admin_DeleteItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 367)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_Condition)
        Me.Controls.Add(Me.btn_DeletingItem)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.txt_Availability)
        Me.Controls.Add(Me.txt_StatusDelete)
        Me.Controls.Add(Me.txt_Cost)
        Me.Controls.Add(Me.txt_Equipments)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_DeleteItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_DeleteItem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Condition As System.Windows.Forms.ComboBox
    Friend WithEvents btn_DeletingItem As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents txt_Availability As System.Windows.Forms.TextBox
    Friend WithEvents txt_StatusDelete As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cost As System.Windows.Forms.TextBox
    Friend WithEvents txt_Equipments As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
