Imports System.Data.OleDb

Public Class Admin_UpdateItem

    'UPDATING AN ITEM IN ELECTRONICS
    Private Sub btn_UpdatingItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdatingItem.Click
        panel_ElectronicsUpdate.Visible = True
        connection.Close()
        connection.Open()
        'If con.State = ConnectionState.Closed Then
        'End If

        'Using cmd As New OleDbCommand("Select Count(*) from tbl_Electronics where [Equipments] = @Equipments", connection)
        '    cmd.Parameters.AddWithValue("@Equipments", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
        '    Dim count = Convert.ToInt32(cmd.ExecuteScalar)
        '    If count > 0 Then
        '        MessageBox.Show("opps, the name has already taken ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If

        'End Using

        Dim id, name, condition, cost, statusDelete, availability, details, dates As String

        id = txt_ID.Text
        name = txt_Equipments.Text
        condition = cmb_Condition.Text
        cost = txt_Cost.Text
        statusDelete = cmb_StatusDelete.Text
        availability = cmb_Availability.Text
        details = cmb_ElectronicsDetails.Text
        dates = lblDateElectronics.Text

        Using cmd1 As New OleDbCommand("UPDATE tbl_Electronics SET EquipmentDetails='" & details & "',Equipments='" & name & "',Condition='" & condition & "',Cost='" & cost & "',StatusDelete='" & statusDelete & "', Availability='" & availability & "' WHERE  ID='" & id & "'", connection)
            If cmd1.ExecuteNonQuery Then
                MessageBox.Show("Item Updated!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_ID.Clear()
                txt_Equipments.Clear()
                cmb_Condition.ResetText()
                txt_Cost.Clear()
                cmb_ElectronicsDetails.ResetText()
                If availability = "Available" Or condition = "Damage" Then

                    Dim cmd2 As New OleDbCommand("UPDATE tbl_BorrowerHistory SET StatusReturn='" & dates & "' WHERE  ItemBorrowed='" & name & "'", connection) 'STATUS RETURN IN TBL BORROWER HISTORY NEW CODE\\\\\
                    cmd2.ExecuteNonQuery()
                Else
                    Me.Close()
                    Exit Sub
                    MessageBox.Show("Opps Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using

        connection.Close()
        btn_Cancel.PerformClick()


    End Sub

    'CANCEL BUTTON
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Admin_UpdateItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True 'NEED THIS!!
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateElectronics.Text = Date.Now.ToString("MM-dd-yyyy")

        StoreDate = lblDateElectronics.Text() ' STORE TIME TO THIS GLOBAL VARIABLE
    End Sub

    Private Sub txt_Equipments_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Equipments.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txt_Cost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cost.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub
End Class