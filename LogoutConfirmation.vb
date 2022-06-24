Public Class LogoutConfirmation

    Private Sub btn_Yes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Yes.Click
        AdminLoginForm.txt_Username.Text = ""
        AdminLoginForm.txt_Password.Text = ""
        Me.Close()
        AdminDashboard.Close()
        AdminLoginForm.Show()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
        Dashboard2.btn_EditProfile.PerformClick()
        Dashboard2.Show()
    End Sub

    Private Sub btn_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User.Click
        LoginForm.txt_Username.Text = ""
        LoginForm.txt_Password.Text = ""
        Me.Close()
        Dashboard2.Close()

    End Sub

    Private Sub btn_super_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_super.Click
        Me.Close()
        SuperAdmin_Dashboard.btn_Dashboard.PerformClick()
        SuperAdmin_Dashboard.Show()
    End Sub

    Private Sub btn_Admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Admin.Click
        Me.Close()
        AdminDashboard.btn_EditProfile.PerformClick()
        AdminDashboard.Show()
    End Sub
End Class