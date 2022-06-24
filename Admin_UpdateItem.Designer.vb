<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_UpdateItem
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Equipments = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_Cost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_UpdatingItem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Condition = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_StatusDelete = New System.Windows.Forms.ComboBox()
        Me.cmb_Availability = New System.Windows.Forms.ComboBox()
        Me.panel_ElectronicsUpdate = New System.Windows.Forms.Panel()
        Me.cmb_ElectronicsDetails = New System.Windows.Forms.ComboBox()
        Me.lblDateElectronics = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_ElectronicsUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 59)
        Me.Panel1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 34)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Availability"
        '
        'txt_Equipments
        '
        Me.txt_Equipments.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Equipments.Location = New System.Drawing.Point(179, 114)
        Me.txt_Equipments.Name = "txt_Equipments"
        Me.txt_Equipments.Size = New System.Drawing.Size(244, 28)
        Me.txt_Equipments.TabIndex = 1
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(179, 21)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(244, 28)
        Me.txt_ID.TabIndex = 11
        Me.txt_ID.Visible = False
        '
        'txt_Cost
        '
        Me.txt_Cost.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cost.Location = New System.Drawing.Point(179, 250)
        Me.txt_Cost.Name = "txt_Cost"
        Me.txt_Cost.Size = New System.Drawing.Size(244, 28)
        Me.txt_Cost.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cost"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(136, 541)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(110, 49)
        Me.btn_Cancel.TabIndex = 18
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 34)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Condition"
        '
        'btn_UpdatingItem
        '
        Me.btn_UpdatingItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_UpdatingItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpdatingItem.FlatAppearance.BorderSize = 0
        Me.btn_UpdatingItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UpdatingItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdatingItem.ForeColor = System.Drawing.Color.White
        Me.btn_UpdatingItem.Location = New System.Drawing.Point(294, 541)
        Me.btn_UpdatingItem.Name = "btn_UpdatingItem"
        Me.btn_UpdatingItem.Size = New System.Drawing.Size(170, 49)
        Me.btn_UpdatingItem.TabIndex = 17
        Me.btn_UpdatingItem.Text = "Update Item"
        Me.btn_UpdatingItem.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Item Name"
        '
        'cmb_Condition
        '
        Me.cmb_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Condition.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Condition.FormattingEnabled = True
        Me.cmb_Condition.Items.AddRange(New Object() {"Good", "Broken"})
        Me.cmb_Condition.Location = New System.Drawing.Point(179, 182)
        Me.cmb_Condition.Name = "cmb_Condition"
        Me.cmb_Condition.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Condition.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, -16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        Me.Label1.Visible = False
        '
        'cmb_StatusDelete
        '
        Me.cmb_StatusDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_StatusDelete.Enabled = False
        Me.cmb_StatusDelete.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_StatusDelete.FormattingEnabled = True
        Me.cmb_StatusDelete.Items.AddRange(New Object() {"Active", "Deleted"})
        Me.cmb_StatusDelete.Location = New System.Drawing.Point(179, 323)
        Me.cmb_StatusDelete.Name = "cmb_StatusDelete"
        Me.cmb_StatusDelete.Size = New System.Drawing.Size(244, 29)
        Me.cmb_StatusDelete.TabIndex = 19
        '
        'cmb_Availability
        '
        Me.cmb_Availability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Availability.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Availability.FormattingEnabled = True
        Me.cmb_Availability.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmb_Availability.Location = New System.Drawing.Point(179, 390)
        Me.cmb_Availability.Name = "cmb_Availability"
        Me.cmb_Availability.Size = New System.Drawing.Size(244, 29)
        Me.cmb_Availability.TabIndex = 19
        '
        'panel_ElectronicsUpdate
        '
        Me.panel_ElectronicsUpdate.Controls.Add(Me.cmb_ElectronicsDetails)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.cmb_Availability)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.cmb_StatusDelete)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.lblDateElectronics)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label1)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.cmb_Condition)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label2)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.btn_UpdatingItem)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label3)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.btn_Cancel)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label4)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label5)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.txt_Cost)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.txt_ID)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label7)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.txt_Equipments)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label8)
        Me.panel_ElectronicsUpdate.Controls.Add(Me.Label6)
        Me.panel_ElectronicsUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_ElectronicsUpdate.Location = New System.Drawing.Point(0, 59)
        Me.panel_ElectronicsUpdate.Name = "panel_ElectronicsUpdate"
        Me.panel_ElectronicsUpdate.Size = New System.Drawing.Size(587, 639)
        Me.panel_ElectronicsUpdate.TabIndex = 20
        '
        'cmb_ElectronicsDetails
        '
        Me.cmb_ElectronicsDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ElectronicsDetails.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ElectronicsDetails.FormattingEnabled = True
        Me.cmb_ElectronicsDetails.Items.AddRange(New Object() {"Bought", "Donated"})
        Me.cmb_ElectronicsDetails.Location = New System.Drawing.Point(179, 465)
        Me.cmb_ElectronicsDetails.Name = "cmb_ElectronicsDetails"
        Me.cmb_ElectronicsDetails.Size = New System.Drawing.Size(244, 29)
        Me.cmb_ElectronicsDetails.TabIndex = 19
        '
        'lblDateElectronics
        '
        Me.lblDateElectronics.AutoSize = True
        Me.lblDateElectronics.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateElectronics.Location = New System.Drawing.Point(503, 43)
        Me.lblDateElectronics.Name = "lblDateElectronics"
        Me.lblDateElectronics.Size = New System.Drawing.Size(50, 34)
        Me.lblDateElectronics.TabIndex = 8
        Me.lblDateElectronics.Text = "date"
        Me.lblDateElectronics.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 34)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Availability"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 34)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Item Details"
        '
        'Timer1
        '
        '
        'Admin_UpdateItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 698)
        Me.Controls.Add(Me.panel_ElectronicsUpdate)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_UpdateItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_UpdateItem"
        Me.panel_ElectronicsUpdate.ResumeLayout(False)
        Me.panel_ElectronicsUpdate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Equipments As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_UpdatingItem As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Condition As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_StatusDelete As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Availability As System.Windows.Forms.ComboBox
    Friend WithEvents panel_ElectronicsUpdate As System.Windows.Forms.Panel
    Friend WithEvents cmb_ElectronicsDetails As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDateElectronics As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
