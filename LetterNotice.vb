Public Class LetterNotice

    Private Sub LetterNotice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_ListOfBannedStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ListOfBannedStudents.Click
        Notice.btn_Back1.Visible = False
        Notice.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class