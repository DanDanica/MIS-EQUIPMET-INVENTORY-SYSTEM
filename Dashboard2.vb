Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Public Class Dashboard2

    Private Sub Dashboard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hideSubMenu()
        sPanelDash.Visible = False
        sPanelName.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = True

        Timer1.Enabled = True 'NEED THIS!!

        COUNTINGEquipments() 'DISPLAY SUB FUNCTION EQUIPMENTS
        COUNTINGAccessories() 'DISPLAY SUB FUNCTION ACCESSORIES
        COUNTINGCleaningMat() 'DISPLAY SUB FUNCTION CLEANINGMAT
        COUNTINGRoom() 'DISPLAY SUB FUNCTION ROOM
    End Sub
    'TIME
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MM-dd-yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        StoreTime = lblTime.Text ' STORE DATE TO THIS GLOBAL VARIABLE
        StoreDate = lblDate.Text ' STORE TIME TO THIS GLOBAL VARIABLE

    End Sub

    'COUNTING SUBS
    Sub COUNTINGEquipments()
        connection.Close()
        connection.Open()


        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Equipments]) FROM tbl_Electronics WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblElectronics.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE ELECTRONICS

        connection.Close()

    End Sub
    Sub COUNTINGCleaningMat()
        connection.Close()
        connection.Open()


        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Equipments]) FROM tbl_CleaningMaterials WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblCleaning.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE CLEANING MATERIALS

        connection.Close()

    End Sub
    Sub COUNTINGAccessories()
        connection.Close()
        connection.Open()
        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Equipments]) FROM tbl_Accessories WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblAccessories.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE ACCESSORIES

        connection.Close()

    End Sub
    Sub COUNTINGRoom()
        connection.Close()
        connection.Open()


        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Room]) FROM tbl_Classrooms WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblClassrooms.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE CLASSROOMS

        connection.Close()

    End Sub

    'SUB MENUS
    Private Sub hideSubMenu()
        panelUser.Visible = False
        panelDashboard.Visible = True
    End Sub
    Private Sub showSubUser()
        panelUser.Visible = True
        panelDashboard.Visible = False
    End Sub
    Private Sub showSubDash()
        panelUser.Visible = False
        panelDashboard.Visible = True
    End Sub

    'SLIDEBAR USER
    Private Sub btnForUser()
        showSubUser()

        sPanelDash.Visible = False
        sPanelName.Visible = True
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelName.Height = btn_User.Height
        sPanelName.Top = btn_User.Top
        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = True
    End Sub
    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User.Click

        showSubUser()

        sPanelDash.Visible = False
        sPanelName.Visible = False
        sPanelEdit.Visible = True
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelEdit.Height = btn_EditProfile.Height
        sPanelEdit.Top = btn_EditProfile.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = True

        txtEditStudNum.Text = StoreData
        txtEditUsername.Text = LoginForm.txt_Username.Text
        lblCurrentPassword.Text = LoginForm.txt_Password.Text
    End Sub

    'SLIDEBAR DASHBOARD
    Private Sub btn_Dashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dashboard.Click
        showSubDash()

        sPanelName.Visible = False
        sPanelDash.Visible = True
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelDash.Height = btn_Dashboard.Height
        sPanelDash.Top = btn_Dashboard.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = True
    End Sub

    'SLIDEBAR EDIT PROFILE
    Private Sub btn_EditProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditProfile.Click
        showSubUser()

        sPanelDash.Visible = False
        sPanelName.Visible = False
        sPanelEdit.Visible = True
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelEdit.Height = btn_EditProfile.Height
        sPanelEdit.Top = btn_EditProfile.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = True

        txtEditStudNum.Text = StoreData
        txtEditUsername.Text = LoginForm.txt_Username.Text
        lblCurrentPassword.Text = LoginForm.txt_Password.Text
    End Sub

    'SLIDEBAR LOGOUT
    Private Sub btn_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Logout.Click
        LogoutConfirmation.btn_Yes.Visible = False
        LogoutConfirmation.btn_super.Visible = False
        LogoutConfirmation.btn_Admin.Visible = False

        LogoutConfirmation.Show()
        showSubUser()

        sPanelDash.Visible = False
        sPanelName.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = True
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelLogout.Height = btn_Logout.Height
        sPanelLogout.Top = btn_Logout.Top
    End Sub

    'ELECTRONICS SLIDEBAR & MAIN CODE
    Private Sub CodesOfElectronics()
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_Electronics", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        dgv_UserElectronics.DataSource = dTable.DefaultView
        connection.Close()
        showSubDash()

        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = True
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelElectronics.Height = btn_Electronics.Height
        sPanelElectronics.Top = btn_Electronics.Top

        panel_Electronics.Visible = True
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
    End Sub
    Private Sub btn_Electronics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Electronics.Click
        CodesOfElectronics()
    End Sub
    'ELECTRONICS DASHBOARD BUTTON
    Private Sub btn_BorrowElec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowElec.Click
        CodesOfElectronics()
    End Sub

    'CLEANINGMATERIALS SLIDEBAR 7 MAIN CODE
    Private Sub CodesOfCleaning()
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_CleaningMaterials", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        dgv_UserCleaningMaterials.DataSource = dTable.DefaultView
        connection.Close()
        showSubDash()

        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = True
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelCleaning.Height = btn_CleaningMaterials.Height
        sPanelCleaning.Top = btn_CleaningMaterials.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = True
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
    End Sub
    Private Sub btn_CleaningMaterials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CleaningMaterials.Click
        
        CodesOfCleaning()
    End Sub
    'CLEANINGMATERIALS DASHBOARD BUTTON
    Private Sub btn_BorrowCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowCleaning.Click
        CodesOfCleaning()
    End Sub

    'CLASSROOM SLIDEBAR & MAIN CODE
    Private Sub CodesOfClassroom()
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Room, Condition, Availability FROM tbl_Classrooms", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        dgv_UserClassroom.DataSource = dTable.DefaultView
        connection.Close()
        showSubDash()

        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = True
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False

        sPanelClassrooms.Height = btn_Classroom.Height
        sPanelClassrooms.Top = btn_Classroom.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = True
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
    End Sub
    Private Sub btn_Classroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Classroom.Click, btn_BorrowClassroom.Click
        
        CodesOfClassroom()

    End Sub
    'CLASSROOM DASHBOARD BUTTON
    Private Sub btn_BorrowClassroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CodesOfClassroom()
    End Sub

    'ACCESSORIES SLIDEBAR & MAIN CODE
    Private Sub CodesOfAccessories()
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_Accessories", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        dgv_UserAccessories.DataSource = dTable.DefaultView
        connection.Close()
        showSubDash()

        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = True
        sPanelDash2.Visible = False

        sPanelAccessories.Height = btn_Accessories.Height
        sPanelAccessories.Top = btn_Accessories.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = True
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
    End Sub
    Private Sub btn_Accessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Accessories.Click
        
        CodesOfAccessories()
    End Sub
    'ACCESSORIES DASHBOARD BUTTON
    Private Sub btn_BorrowAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowAccessories.Click
        CodesOfAccessories()
    End Sub

    'BORROWING BUTTONS
    Private Sub btn_BorrowElectricItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowElectricItem.Click
        User_BorrowingConfirmationForm.txtbox_StudentNumber.Text = dgv_UserElectronics.CurrentRow.Cells(0).Value.ToString
        User_BorrowingConfirmationForm.txtbox_ItemBorrow.Text = dgv_UserElectronics.CurrentRow.Cells(1).Value.ToString
        User_BorrowingConfirmationForm.txtbox_Condition.Text = dgv_UserElectronics.CurrentRow.Cells(2).Value.ToString
        User_BorrowingConfirmationForm.txtbox_Availability.Text = dgv_UserElectronics.CurrentRow.Cells(4).Value.ToString
        User_BorrowingConfirmationForm.Show()
    End Sub

    Private Sub btn_BorrowCleaningItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowCleaningItem.Click
        User_BorrowingConfirmationForm.txtbox_StudentNumber.Text = dgv_UserCleaningMaterials.CurrentRow.Cells(0).Value.ToString
        User_BorrowingConfirmationForm.txtbox_ItemBorrow.Text = dgv_UserCleaningMaterials.CurrentRow.Cells(1).Value.ToString
        User_BorrowingConfirmationForm.txtbox_Condition.Text = dgv_UserCleaningMaterials.CurrentRow.Cells(2).Value.ToString
        User_BorrowingConfirmationForm.txtbox_Availability.Text = dgv_UserCleaningMaterials.CurrentRow.Cells(4).Value.ToString
        User_BorrowingConfirmationForm.Show()
    End Sub

    Private Sub btn_BorrowClassroomItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowClassroomItem.Click
        User_BorrowingClassroomConfirmation.txtbox_StudentNumber.Text = dgv_UserClassroom.CurrentRow.Cells(0).Value.ToString
        User_BorrowingClassroomConfirmation.txt_RoomNumber.Text = dgv_UserClassroom.CurrentRow.Cells(1).Value.ToString
        User_BorrowingClassroomConfirmation.txtbox_Condition.Text = dgv_UserClassroom.CurrentRow.Cells(2).Value.ToString
        'User_BorrowingClassroomConfirmation.txtbox_StatusDelete.Text = dgv_UserClassroom.CurrentRow.Cells(3).Value.ToString
        User_BorrowingClassroomConfirmation.txtbox_Availability.Text = dgv_UserClassroom.CurrentRow.Cells(3).Value.ToString
        User_BorrowingClassroomConfirmation.Show()
    End Sub

    Private Sub btn_BorrowingAccessoriesItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrowingAccessoriesItem.Click
        User_BorrowingConfirmationForm.txtbox_StudentNumber.Text = dgv_UserAccessories.CurrentRow.Cells(0).Value.ToString
        User_BorrowingConfirmationForm.txtbox_ItemBorrow.Text = dgv_UserAccessories.CurrentRow.Cells(1).Value.ToString
        User_BorrowingConfirmationForm.txtbox_Condition.Text = dgv_UserAccessories.CurrentRow.Cells(2).Value.ToString
        User_BorrowingConfirmationForm.txtbox_Availability.Text = dgv_UserAccessories.CurrentRow.Cells(4).Value.ToString
        User_BorrowingConfirmationForm.Show()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        connection.Open()
        If lblMatchP.Text = "Not Matched" Then

            MessageBox.Show("Old Password did not match")

        Else

            If txtEditUsername.Text = Nothing Or txtEditPassword.Text = Nothing Or txtNewPass.Text = Nothing Then
                MsgBox("Fields must not left blank!")
            Else



                Dim EditProfileUpdate As New OleDbCommand("UPDATE tbl_Users SET [Username]='" & txtEditUsername.Text & "', [Password]='" & txtNewPass.Text & "' WHERE [Student_no]='" & StoreData & "'", connection)
                EditProfileUpdate.ExecuteNonQuery()

                If EditProfileUpdate.ExecuteNonQuery() Then
                    MessageBox.Show("Account Updated!, Please log out your account to save changes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtEditUsername.Clear()
                    txtNewPass.Clear()

                    connection.Close()
                Else
                    MessageBox.Show("Opps Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                connection.Close()

            End If
            connection.Close()

        End If

        connection.Close()
    End Sub

    Private Sub txtEditPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEditPassword.TextChanged
        If txtEditPassword.Text = lblCurrentPassword.Text Then
            lblMatchP.Text = "Matched"
            lblMatchP.ForeColor = Color.Lime
        Else
            lblMatchP.Text = "Not Matched"
            lblMatchP.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtEditUsername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEditUsername.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtEditPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPass.KeyPress, txtEditPassword.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub
End Class
