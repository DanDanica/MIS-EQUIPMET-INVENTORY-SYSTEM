Imports System.Data.OleDb

Public Class SuperAdmin_AddNewUser

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_ProceedAdding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ProceedAdding.Click
        Try
            connection.Open()
            Dim admin_studnum, admin_user, admin_pass As String
            admin_studnum = txtbxStudentNumberAdmin.Text
            admin_user = txtbxUsernameAdmin.Text
            admin_pass = txtbxPasswordAdmin.Text
            Dim cmd As New OleDbCommand ' command 

            Dim verify As OleDbDataReader ' database reader
            cmd.Connection = connection ' command connection
            cmd.CommandType = CommandType.Text ' command type to text
            cmd.CommandText = "SELECT * FROM tbl_Admin WHERE [ID]='" & admin_studnum & "' OR [Username]='" & admin_user & "' " ' command text to query
            verify = cmd.ExecuteReader ' execute the query+

            If verify.HasRows Then ' check if the database has the same student number or username

                MsgBox("Details must not be Duplicate", MsgBoxStyle.Critical)

            Else
                If admin_studnum = Nothing Or admin_user = Nothing Or admin_pass = Nothing Then


                    MsgBox("Fill All Details", MsgBoxStyle.Information)

                Else
                    connection.Close()

                    If Not Char.IsNumber(admin_studnum) Then ' CHECK IF STUD NUM IS NUMBER

                        MsgBox("Enter Number Only in Student Number", MsgBoxStyle.Information)
                        connection.Close()

                    Else
                        connection.Close()
                        connection.Open()

                        Dim CreateAdmin As New OleDbCommand("INSERT INTO tbl_Admin ([ID],[Username],[Password],[StatusDelete]) VALUES('" & admin_studnum & "','" & admin_user & "','" & admin_pass & "'," & "'Active')", connection)
                        'QUERY FOR ADDING ADMIN


                        CreateAdmin.ExecuteNonQuery()
                        MessageBox.Show("ACCOUNT CREATED!")


                        connection.Close()
                        Me.Close()
                        SuperAdmin_Dashboard.Show()
                    End If
                    connection.Close()
                End If
                connection.Close()

            End If
            connection.Close()


        Catch ex As Exception ' error handler
            MsgBox("Fill all Details")
        End Try

    End Sub

    Private Sub txtbxStudentNumberAdmin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbxStudentNumberAdmin.KeyPress
        If txtbxStudentNumberAdmin.Text.Length > 8 Then
            MsgBox("Student Number Maximum is 9") ' limited number in student number
            txtbxStudentNumberAdmin.Clear()

        End If

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True ' not allowed to type letter and special char

        End If
    End Sub

    Private Sub txtbxUsernameAdmin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbxUsernameAdmin.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbxPasswordAdmin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbxPasswordAdmin.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub
End Class