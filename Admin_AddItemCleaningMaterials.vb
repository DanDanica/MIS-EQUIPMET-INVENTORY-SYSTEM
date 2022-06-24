Imports System.Data.OleDb

Public Class Admin_AddItemCleaningMaterials

    Private Sub btn_AddingItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddingItem.Click
        connection.Close()
        connection.Open()
        If txt_Equipments.Text = Nothing Or txt_ID.Text = Nothing Or cmb_Details.Text = Nothing Or txt_Cost.Text = Nothing Then
            MsgBox("FILL ALL DETAILS", MsgBoxStyle.Information)
        Else
            'Using pkID As New OleDbCommand("Select Count([ID]) from tbl_CleaningMaterials", connection)
            '    Dim countA As Integer
            '    countA = pkID.ExecuteScalar().ToString
            '    txt_ID.Text = countA + 1
            'End Using
            'Using cmd As New OleDbCommand("Select Count(*) from tbl_CleaningMaterials where [ID] = @ID or [Equipments] = @Equipments", connection)
            '    cmd.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = txt_ID.Text.Trim
            '    cmd.Parameters.AddWithValue("@Equipments", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
            '    Dim count = Convert.ToInt32(cmd.ExecuteScalar)
            '    If count > 0 Then
            '        MessageBox.Show("Oops!, the data is already taken", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            'End Using

            Using cmd As New OleDbCommand("Select Count(*) from tbl_CleaningMaterials where [ID] = @ID or [Equipments] = @Equipments", connection)
                cmd.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = txt_ID.Text.Trim
                cmd.Parameters.AddWithValue("@Equipments", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
                Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                If count > 0 Then
                    MessageBox.Show("Oops!, the data is already inputted", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            Using create As New OleDbCommand("insert into tbl_CleaningMaterials([ID],[Equipments],[Condition],[Cost],[StatusDelete], [Availability],[EquipmentDetails]) Values(@ID,@Equipments,@Condition,@Cost, @StatusDelete, @Availability,@EquipmentDetails)", connection)
                create.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = txt_ID.Text.Trim
                create.Parameters.AddWithValue("@Equipments", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
                create.Parameters.AddWithValue("@Condition", OleDbType.VarChar).Value = cmb_Condition.Text.Trim()
                create.Parameters.AddWithValue("@Cost", OleDbType.VarChar).Value = txt_Cost.Text.Trim()
                create.Parameters.AddWithValue("@StatusDelete", OleDbType.VarChar).Value = txt_StatusDelete.Text.Trim()
                create.Parameters.AddWithValue("@Availability", OleDbType.VarChar).Value = txt_Availability.Text.Trim()
                create.Parameters.AddWithValue("@EquipmentDetails", OleDbType.VarChar).Value = cmb_Details.Text.Trim()

                If create.ExecuteNonQuery Then
                    MessageBox.Show("Account Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_ID.Clear()
                    txt_Equipments.Clear()
                    txt_Cost.Clear()
                    cmb_Condition.ResetText()
                    Me.Close()

                    Exit Sub

                Else
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            connection.Close()
        End If
        connection.Close()
    End Sub

    Private Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    'CANCEL BUTTON
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()

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

    Private Sub txt_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True

        End If
    End Sub
End Class