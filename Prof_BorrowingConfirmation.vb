Imports System.Data.OleDb

Public Class Prof_BorrowingConfirmation

    Private Sub btn_ProceedBorrowing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ProceedBorrowing.Click
        
        Dim avail, classyear, prof, departm, condition, item, equipID, StoreDATE1, StoreTime1, AdminStudNum As String

        StoreDATE1 = StoreDate 'GLOBAL VARIABLE FOR DATE
        StoreTime1 = StoreTime  'GLOBAL VARIABLE FOR TIME
        prof = txtbox_ProfName.Text
        classyear = cmb_Class.Text
        departm = cmb_Department.Text
        item = txtbox_ItemBorrow.Text
        condition = txtbox_Condition.Text
        avail = txtbox_Availability.Text
        equipID = txtbox_StudentNumber.Text
        AdminStudNum = StoreAdminStudNum

        If prof = Nothing Or classyear = Nothing Or departm = Nothing Then 'WHEN TEXTBOX IS EMPTY 

            MessageBox.Show("Please Complete the Details")

        Else

            If cb_TermsAndAgreement.CheckState = CheckState.Checked Then

                If avail = "Available" Then

                    connection.Open()
                    'INSERT DATA TO HISTORYPROF
                    Dim borrower As New OleDbCommand("INSERT INTO tbl_ProfBorrower([Professor], [Department], [ClassYear],[ItemBorrowed],[Condition],[Date],[Time],[AdminAccount])" & _
                                                     "VALUES('" & prof & "','" & departm & "','" & classyear & "','" & item & "','" & condition & "','" & StoreDATE1 & "','" & StoreTime1 & "','" & AdminStudNum & "')", connection)
                    borrower.ExecuteNonQuery()
                    ' UPDATE TABLE OF SELECTED ITEM TO UNAVAILABLE
                    Dim UpdateElectronics As New OleDbCommand("UPDATE tbl_Electronics SET [Availability]='" & "Unavailable" & "' WHERE [ID]='" & equipID & "'", connection)
                    UpdateElectronics.ExecuteNonQuery()
                    Dim UpdateCleaning As New OleDbCommand("UPDATE tbl_CleaningMaterials SET [Availability]='" & "Unavailable" & "' WHERE [ID]='" & equipID & "'", connection)
                    UpdateCleaning.ExecuteNonQuery()
                    Dim UpdateAccessories As New OleDbCommand("UPDATE tbl_Accessories SET [Availability]='" & "Unavailable" & "' WHERE [ID]='" & equipID & "'", connection)
                    UpdateAccessories.ExecuteNonQuery()
                    MessageBox.Show("Borrowing Succesful")
                    connection.Close()
                    Me.Close()


                Else

                    MessageBox.Show("Item Unavailable")

                End If

            Else
                MessageBox.Show("Please Check the Terms and Agreement before borrowing")

            End If

        End If
    End Sub

    Private Sub btn_CancelBorrowing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelBorrowing.Click
        Me.Close()

    End Sub

    Private Sub link_TermsAndAgreement_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_TermsAndAgreement.LinkClicked
        TermsAndAgreementForm.Show()
    End Sub

    Private Sub txtbox_ProfName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_ProfName.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub
End Class