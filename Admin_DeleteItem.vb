Imports System.Data.OleDb
Public Class Admin_DeleteItem

    Private Sub btn_DeletingItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeletingItem.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim id, name, condition, cost As String

        id = txt_ID.Text
        name = txt_Equipments.Text
        condition = cmb_Condition.Text
        cost = txt_Cost.Text

        Using cmd2 As New OleDbCommand("DELETE FROM tbl_Electronics WHERE ID='" & id & "'", connection)
            If cmd2.ExecuteNonQuery Then
                MessageBox.Show("Account Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_ID.Clear()
                txt_Equipments.Clear()
                txt_Cost.Clear()
                cmb_Condition.ResetText()
                Me.Close()
                Exit Sub
            Else
                MessageBox.Show("Opps Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using
        connection.Close()

    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class