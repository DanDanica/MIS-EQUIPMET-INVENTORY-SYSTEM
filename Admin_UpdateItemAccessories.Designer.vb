<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_UpdateItemAccessories
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
        Me.cmb_Availability = New System.Windows.Forms.ComboBox()
        Me.cmb_StatusDelete = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_Condition = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_UpdatingItem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Cost = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_Equipments = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_Details = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_Availability
        '
        Me.cmb_Availability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Availability.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Availability.FormattingEnabled = True
        Me.cmb_Availability.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmb_Availability.Location = New System.Drawing.Point(178, 459)
        Me.cmb_Availability.Name = "cmb_Availability"
        Me.cmb_Availability.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Availability.TabIndex = 32
        '
        'cmb_StatusDelete
        '
        Me.cmb_StatusDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_StatusDelete.Enabled = False
        Me.cmb_StatusDelete.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_StatusDelete.FormattingEnabled = True
        Me.cmb_StatusDelete.Items.AddRange(New Object() {"Active", "Deleted"})
        Me.cmb_StatusDelete.Location = New System.Drawing.Point(178, 392)
        Me.cmb_StatusDelete.Name = "cmb_StatusDelete"
        Me.cmb_StatusDelete.Size = New System.Drawing.Size(244, 29)
        Me.cmb_StatusDelete.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID"
        Me.Label1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 59)
        Me.Panel1.TabIndex = 29
        '
        'cmb_Condition
        '
        Me.cmb_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Condition.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Condition.FormattingEnabled = True
        Me.cmb_Condition.Items.AddRange(New Object() {"Good", "Damage"})
        Me.cmb_Condition.Location = New System.Drawing.Point(178, 251)
        Me.cmb_Condition.Name = "cmb_Condition"
        Me.cmb_Condition.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Condition.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 34)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Item Name"
        '
        'btn_UpdatingItem
        '
        Me.btn_UpdatingItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_UpdatingItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpdatingItem.FlatAppearance.BorderSize = 0
        Me.btn_UpdatingItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UpdatingItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdatingItem.ForeColor = System.Drawing.Color.White
        Me.btn_UpdatingItem.Location = New System.Drawing.Point(290, 596)
        Me.btn_UpdatingItem.Name = "btn_UpdatingItem"
        Me.btn_UpdatingItem.Size = New System.Drawing.Size(170, 49)
        Me.btn_UpdatingItem.TabIndex = 30
        Me.btn_UpdatingItem.Text = "Update Item"
        Me.btn_UpdatingItem.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 34)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Condition"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(132, 596)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(110, 49)
        Me.btn_Cancel.TabIndex = 31
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 34)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 34)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Status Delete"
        '
        'txt_Cost
        '
        Me.txt_Cost.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cost.Location = New System.Drawing.Point(178, 319)
        Me.txt_Cost.Name = "txt_Cost"
        Me.txt_Cost.Size = New System.Drawing.Size(244, 28)
        Me.txt_Cost.TabIndex = 2
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(178, 86)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(244, 28)
        Me.txt_ID.TabIndex = 26
        Me.txt_ID.Visible = False
        '
        'txt_Equipments
        '
        Me.txt_Equipments.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Equipments.Location = New System.Drawing.Point(178, 183)
        Me.txt_Equipments.Name = "txt_Equipments"
        Me.txt_Equipments.Size = New System.Drawing.Size(244, 28)
        Me.txt_Equipments.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(172, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 34)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Availability"
        '
        'cmb_Details
        '
        Me.cmb_Details.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Details.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Details.FormattingEnabled = True
        Me.cmb_Details.Items.AddRange(New Object() {"Bought", "Donated"})
        Me.cmb_Details.Location = New System.Drawing.Point(178, 528)
        Me.cmb_Details.Name = "cmb_Details"
        Me.cmb_Details.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Details.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 491)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 34)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Item Details"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(494, 80)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 34)
        Me.lblDate.TabIndex = 37
        Me.lblDate.Text = "date"
        Me.lblDate.Visible = False
        '
        'Admin_UpdateItemAccessories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 698)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmb_Details)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_Availability)
        Me.Controls.Add(Me.cmb_StatusDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_Condition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_UpdatingItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Cost)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.txt_Equipments)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_UpdateItemAccessories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_UpdateItemAccessories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Availability As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_StatusDelete As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_Condition As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_UpdatingItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Cost As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_Equipments As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Details As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
End Class
