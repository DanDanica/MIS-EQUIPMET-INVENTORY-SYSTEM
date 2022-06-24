Imports System.Data.OleDb

Public Class Signup

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btn_SignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SignUp.Click
        Try
            Dim user, pass, student_no, course, year, section As String ' variables
            Dim cmd As New OleDbCommand ' command 
            Dim verify As OleDbDataReader ' database reader
            user = txtUsername.Text    ' variable for username
            pass = txtPassword.Text ' variable for pass
            student_no = txtStudentNumber.Text ' variable for student number
            course = cmbCourse.Text ' variable for combo box course
            year = cmbYear.Text ' variable for year
            section = cmbSection.Text ' variable for section

            connection.Open() ' connection open 1

            cmd.Connection = connection ' command connection
            cmd.CommandType = CommandType.Text ' command type to text
            cmd.CommandText = "SELECT * FROM tbl_Users WHERE [Student_no]='" & student_no & "' OR [Username]='" & user & "' " ' command text to query
            verify = cmd.ExecuteReader ' execute the query+


            If Not Char.IsNumber(txtStudentNumber.Text) Then

                MsgBox("Enter Number Only in Student Number", MsgBoxStyle.Information)

            Else
                If cb_TermsAndAgreement.CheckState = CheckState.Checked Then ' IF CHBOX IS CHECKED
                    If verify.HasRows Then ' check if the database has the same student number or username

                        MsgBox("Details must not be Duplicate", MsgBoxStyle.Critical)

                        connection.Close() ' close the connection for connection open 1 (if)

                    Else
                        connection.Close() ' close the connection for connection open 1 (else)
                        connection.Open() ' open 2 connection

                        Dim Signingup As New OleDbCommand("INSERT INTO tbl_Users ([Username],[Password],[Student_no],[Course],[Year],[Section],[Penalty],[StatusDelete]) VALUES('" & user & "','" & pass & "','" & student_no & "','" & course & "','" & year & "','" & section & "','None" & "','Active')", connection) ' query for inserting account if valid

                        If (txtStudentNumber.Text = Nothing Or txtPassword.Text = Nothing Or txtUsername.Text = Nothing Or course = Nothing Or year = Nothing Or section = Nothing) Then ' check if all details are filled
                            MsgBox("Please Enter Credentials", MsgBoxStyle.Exclamation)

                        Else
                            Signingup.ExecuteNonQuery() ' execute the query for creating account
                            MessageBox.Show("ACCOUNT CREATED")
                            txtUsername.Clear()
                            txtPassword.Clear()
                            cmbCourse.ResetText()
                            cmbSection.ResetText()
                            cmbYear.ResetText()
                            Me.Hide() ' hide the sign up after account created
                            connection.Close() ' close the connection for open 2

                            LoginForm.Show() ' show loginform

                        End If
                        connection.Close()


                    End If
                    connection.Close()
                Else
                    MessageBox.Show("Please Check the Terms and Agreement before borrowing")

                End If

            End If
            connection.Close()

        Catch ex As Exception ' error handler
            MsgBox("XXXXXX")
        End Try
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
        LoginForm.Show()

    End Sub

    Private Sub txtStudentNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentNumber.KeyPress
        If txtStudentNumber.Text.Length > 8 Then
            MsgBox("Student Number Maximum is 9") ' limited number in student number
            txtStudentNumber.Clear()

        End If

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True ' not allowed to type letter and special char

        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub btn_SignUpSuper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SignUpSuper.Click
        Try
            Dim user, pass, student_no, course, year, section As String ' variables
            Dim cmd As New OleDbCommand ' command 
            Dim verify As OleDbDataReader ' database reader
            user = txtUsername.Text    ' variable for username
            pass = txtPassword.Text ' variable for pass
            student_no = txtStudentNumber.Text ' variable for student number
            course = cmbCourse.Text ' variable for combo box course
            year = cmbYear.Text ' variable for year
            section = cmbSection.Text ' variable for section

            connection.Open() ' connection open 1

            cmd.Connection = connection ' command connection
            cmd.CommandType = CommandType.Text ' command type to text
            cmd.CommandText = "SELECT * FROM tbl_Users WHERE [Student_no]='" & student_no & "' OR [Username]='" & user & "' " ' command text to query
            verify = cmd.ExecuteReader ' execute the query+


            If Not Char.IsNumber(txtStudentNumber.Text) Then

                MsgBox("Enter Number Only in Student Number", MsgBoxStyle.Information)

            Else
                If cb_TermsAndAgreement.CheckState = CheckState.Checked Then ' IF CHBOX IS CHECKED

                    If verify.HasRows Then ' check if the database has the same student number or username

                        MsgBox("Details must not be Duplicate", MsgBoxStyle.Critical)

                        connection.Close() ' close the connection for connection open 1 (if)

                    Else
                        connection.Close() ' close the connection for connection open 1 (else)
                        connection.Open() ' open 2 connection

                        Dim Signingup As New OleDbCommand("INSERT INTO tbl_Users ([Username],[Password],[Student_no],[Course],[Year],[Section],[Penalty],[StatusDelete]) VALUES('" & user & "','" & pass & "','" & student_no & "','" & course & "','" & year & "','" & section & "','None" & "','Active')", connection) ' query for inserting account if valid

                        If (txtStudentNumber.Text = Nothing Or txtPassword.Text = Nothing Or txtUsername.Text = Nothing Or course = Nothing Or year = Nothing Or section = Nothing) Then ' check if all details are filled
                            MsgBox("Please Enter Credentials", MsgBoxStyle.Exclamation)

                        Else
                            Signingup.ExecuteNonQuery() ' execute the query for creating account
                            MessageBox.Show("ACCOUNT CREATED")
                            txtUsername.Clear()
                            txtPassword.Clear()
                            cmbCourse.ResetText()
                            cmbSection.ResetText()
                            cmbYear.ResetText()
                            Me.Hide() ' hide the sign up after account created
                            connection.Close() ' close the connection for open 2

                            SuperAdmin_Dashboard.Show() ' show loginform

                        End If
                        connection.Close()


                    End If
                    connection.Close()
                Else
                    MessageBox.Show("Please Check the Terms and Agreement before borrowing")

                End If

            End If
            connection.Close()

        Catch ex As Exception ' error handler
            MsgBox("XXXXXX")
        End Try
    End Sub

    Private Sub btn_CancelSuper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelSuper.Click
        Me.Close()
        SuperAdmin_Dashboard.Show()

    End Sub

    'Private Sub cbx_ShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cbx_ShowPass.Checked = True Then
    '        txtPassword.UseSystemPasswordChar = True
    '    Else
    '        txtPassword.UseSystemPasswordChar = False
    '    End If
    'End Sub

    Private Sub btn_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub link_TermsAndAgreement_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_TermsAndAgreement.LinkClicked
        TermsAndAgreementForm.Show()

    End Sub
End Class