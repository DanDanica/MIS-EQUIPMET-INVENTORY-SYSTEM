Imports System.Data.OleDb

Public Class Admin_AddItemClassrooms

    Private Sub btn_AddingItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddingItem.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If txt_Equipments.Text = Nothing Or txt_ID.Text = Nothing Then
            MsgBox("FILL ALL DETAILS", MsgBoxStyle.Information)
        Else

            'Using pkID As New OleDbCommand("Select Count([ID]) from tbl_Classrooms", connection)
            '    Dim countA As Integer
            '    countA = pkID.ExecuteScalar().ToString
            '    txt_ID.Text = countA + 1
            'End Using
            'Using cmd As New OleDbCommand("Select Count(*) from tbl_Classrooms where [ID] = @ID or [Room] = @Room", connection)
            '    cmd.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = txt_ID.Text.Trim
            '    cmd.Parameters.AddWithValue("@Room", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
            '    Dim count = Convert.ToInt32(cmd.ExecuteScalar)
            '    If count > 0 Then
            '        MessageBox.Show("opps, the data is already inputted", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If

            'End Using
            Using cmd As New OleDbCommand("Select Count(*) from tbl_Classrooms where [ID] = @ID or [Room] = @Room", connection)
                cmd.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = txt_ID.Text.Trim
                cmd.Parameters.AddWithValue("@Room", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
                Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                If count > 0 Then
                    MessageBox.Show("Oops!, the data is already inputted", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using




            Using create As New OleDbCommand("insert into tbl_Classrooms([ID],[Room],[Condition], [StatusDelete],[Availability]) Values(@ID,@Room,@Condition,@StatusDelete,@Availability)", connection)
                create.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = txt_ID.Text.Trim
                create.Parameters.AddWithValue("@Room", OleDbType.VarChar).Value = txt_Equipments.Text.Trim
                create.Parameters.AddWithValue("@Condition", OleDbType.VarChar).Value = cmb_Condition.Text.Trim
                create.Parameters.AddWithValue("@StatusDelete", OleDbType.VarChar).Value = txt_StatusDelete.Text.Trim
                create.Parameters.AddWithValue("@Availability", OleDbType.VarChar).Value = txt_Availability.Text.Trim

                If create.ExecuteNonQuery Then
                    MessageBox.Show("Account Created!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_ID.Clear()
                    txt_Equipments.Clear()
                    cmb_Condition.ResetText()
                    txt_StatusDelete.Clear()
                    txt_Availability.Clear()

                    Me.Close()
                    Exit Sub


                Else
                    MessageBox.Show("Opps Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            connection.Close()

        End If
        connection.Close()
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

    Private Sub txt_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True

        End If
    End Sub
End Class