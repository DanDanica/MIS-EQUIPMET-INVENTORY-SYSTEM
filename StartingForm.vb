Public Class StartingForm

    Private Sub btn_UsersPortal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UsersPortal.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_AdminsPortal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AdminsPortal.Click
        AdminLoginForm.Show()
        Me.Hide()

    End Sub
End Class