Imports System.Data.OleDb

Public Class Admin_UpdatePayment

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Dim stud, itemb, DatePaid As String
        stud = txtbox_StudentNumber.Text
        itemb = txtbox_ItemBorrowed.Text
        DatePaid = lblDate.Text

        If txtbox_StudentNumber.Text = Nothing Or txtbox_ItemBorrowed.Text = Nothing Or txtbox_Amount.Text = Nothing Then

            MessageBox.Show("Fields must not left blank!")
        Else
            connection.Open()

            'Dim da7 As New OleDbCommand("UPDATE tbl_BorrowerHistory SET [Paid]='" & txtbox_Amount.Text & "',[Date]='" & lblDate.Text & "' WHERE [ItemBorrowed]='" & itemb & "'AND [Student_no]='" & stud & "'", connection)
            'da7.ExecuteNonQuery()

            Dim da7 As New OleDbCommand("UPDATE tbl_BorrowerHistory INNER JOIN tbl_Users ON tbl_BorrowerHistory.Student_no = tbl_Users.Student_no SET [Paid]='" & txtbox_Amount.Text & "',[Date]='" & lblDate.Text & "',[Penalty]='None" & "' WHERE [ItemBorrowed]='" & itemb & "'AND [tbl_BorrowerHistory.Student_no]='" & stud & "'", connection)
            da7.ExecuteNonQuery()
            MessageBox.Show("Payed Successfully!")

            connection.Close()
            Me.Close()
            '  Dim UpdateElectronics As New OleDbCommand(
            '  UpdateElectronics.ExecuteNonQuery()
        End If
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Admin_UpdatePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True ' NEW CODE TIMER OBJECT
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy") 'DATE FOR DATE PAID
    End Sub

    Private Sub txtbox_Amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_Amount.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub
End Class