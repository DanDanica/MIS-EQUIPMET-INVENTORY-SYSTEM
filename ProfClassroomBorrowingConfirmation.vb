Imports System.Data.OleDb

Public Class ProfClassroomBorrowingConfirmation

    Private Sub bt_ProceedBorrowing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ProceedBorrowing.Click
        Dim roomNumber, equipmentID, availability, condition, storeDataUser, StoreDataDATE, StoreDataTIME, itemBorrow, profName, department, classyear, AdminStudNum As String
        StoreDataDATE = StoreDate 'GLOBAL VARIABLE FOR DATE
        StoreDataTIME = StoreTime  'GLOBAL VARIABLE FOR TIME
        storeDataUser = StoreData  'GLOBAL VARIABLE FOR STUDENTNUMBER OF USER LOGIN IN THE SYSTEM

        AdminStudNum = StoreAdminStudNum
        profName = txtbox_ProfName.Text
        department = cmb_Department.Text
        classyear = cmb_Class.Text
        itemBorrow = txt_RoomNumber.Text
        equipmentID = txtbox_StudentNumber.Text
        roomNumber = txt_RoomNumber.Text
        availability = txtbox_Availability.Text
        condition = txtbox_Condition.Text
        'EnterRoom = txt_EnterRoomNumber.Text
        'equipmentID = txtbox_StudentNumber.Text
        'roomNumber = txtbox_RoomNumber.Text
        'availability = txtbox_Availability.Text

        'If String.IsNullOrEmpty(EnterRoom) Then 'WHEN ROOM NUMBER IS EMPTY

        '    MessageBox.Show("Please Enter Room Number")

        'Else
        If cb_TermsAndAgreement.CheckState = CheckState.Checked Then ' IF CHBOX IS CHECKED

            If availability = "Available" Then ' ONLY AVAILABLE TABLE IS ALLOWED TO BORROW

                connection.Open()
                'INSERT DATA TO HISTORYBORROWER
                Dim borrower As New OleDbCommand("INSERT INTO tbl_ProfBorrower([Professor], [Department],[ClassYear],[ItemBorrowed],[Condition],[Date],[Time],[AdminAccount]) VALUES('" & profName & "','" & department & "','" & classyear & "','" & roomNumber & "','" & condition & "','" & StoreDataDATE & "','" & StoreDataTIME & "','" & AdminStudNum & "')", connection)
                borrower.ExecuteNonQuery()
                ' UPDATE TABLE OF SELECTED ITEM TO UNAVAILABLE
                Dim UpdateClassroom As New OleDbCommand("UPDATE tbl_Classrooms SET [Availability] ='" & "Unavailable'" & " WHERE [ID] ='" & equipmentID & "'", connection)
                UpdateClassroom.ExecuteNonQuery()
                MessageBox.Show("Borrowing Succesful")
                Me.Close()
                connection.Close()
            Else

                MessageBox.Show("Item Unavailable")
                Me.Close()
            End If
        Else
            MessageBox.Show("Please Check the Terms and Agreement before borrowing")

        End If
    End Sub
End Class