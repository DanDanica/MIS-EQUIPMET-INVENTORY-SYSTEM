<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_AddItemCleaningMaterials
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
        Me.btn_AddingItem = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.cmb_Details = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_Condition
        '
        Me.cmb_Condition.Enabled = False
        Me.cmb_Condition.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Condition.FormattingEnabled = True
        Me.cmb_Condition.Items.AddRange(New Object() {"Good", "Damage"})
        Me.cmb_Condition.Location = New System.Drawing.Point(194, 251)
        Me.cmb_Condition.Name = "cmb_Condition"
        Me.cmb_Condition.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Condition.TabIndex = 19
        Me.cmb_Condition.Text = "Good"
        '
        'btn_AddingItem
        '
        Me.btn_AddingItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_AddingItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddingItem.FlatAppearance.BorderSize = 0
        Me.btn_AddingItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddingItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddingItem.ForeColor = System.Drawing.Color.White
        Me.btn_AddingItem.Location = New System.Drawing.Point(335, 589)
        Me.btn_AddingItem.Name = "btn_AddingItem"
        Me.btn_AddingItem.Size = New System.Drawing.Size(126, 49)
        Me.btn_AddingItem.TabIndex = 17
        Me.btn_AddingItem.Text = "Add Item"
        Me.btn_AddingItem.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(164, 589)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(110, 49)
        Me.btn_Cancel.TabIndex = 18
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 59)
        Me.Panel1.TabIndex = 16
        '
        'txt_Availability
        '
        Me.txt_Availability.Enabled = False
        Me.txt_Availability.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Availability.Location = New System.Drawing.Point(194, 460)
        Me.txt_Availability.Name = "txt_Availability"
        Me.txt_Availability.Size = New System.Drawing.Size(244, 28)
        Me.txt_Availability.TabIndex = 13
        Me.txt_Availability.Text = "Available"
        '
        'txt_StatusDelete
        '
        Me.txt_StatusDelete.Enabled = False
        Me.txt_StatusDelete.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StatusDelete.Location = New System.Drawing.Point(194, 392)
        Me.txt_StatusDelete.Name = "txt_StatusDelete"
        Me.txt_StatusDelete.Size = New System.Drawing.Size(244, 28)
        Me.txt_StatusDelete.TabIndex = 14
        Me.txt_StatusDelete.Text = "Active"
        '
        'txt_Cost
        '
        Me.txt_Cost.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cost.Location = New System.Drawing.Point(194, 319)
        Me.txt_Cost.Name = "txt_Cost"
        Me.txt_Cost.Size = New System.Drawing.Size(244, 28)
        Me.txt_Cost.TabIndex = 2
        '
        'txt_Equipments
        '
        Me.txt_Equipments.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Equipments.Location = New System.Drawing.Point(194, 183)
        Me.txt_Equipments.Name = "txt_Equipments"
        Me.txt_Equipments.Size = New System.Drawing.Size(244, 28)
        Me.txt_Equipments.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 34)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Availability"
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(194, 105)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(244, 28)
        Me.txt_ID.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 34)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Condition"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'cmb_Details
        '
        Me.cmb_Details.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Details.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Details.FormattingEnabled = True
        Me.cmb_Details.Items.AddRange(New Object() {"Bought", "Donated"})
        Me.cmb_Details.Location = New System.Drawing.Point(194, 538)
        Me.cmb_Details.Name = "cmb_Details"
        Me.cmb_Details.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Details.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 34)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Item Details"
        '
        'Admin_AddItemCleaningMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 662)
        Me.Controls.Add(Me.cmb_Details)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_Condition)
        Me.Controls.Add(Me.btn_AddingItem)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.Panel1)
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
        Me.Name = "Admin_AddItemCleaningMaterials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_AddItemCleaningMaterials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Condition As System.Windows.Forms.ComboBox
    Friend WithEvents btn_AddingItem As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents cmb_Details As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
