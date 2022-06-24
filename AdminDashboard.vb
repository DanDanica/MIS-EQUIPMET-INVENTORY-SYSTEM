Imports System.Data.OleDb

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MISInventoryDatabaseDataSet.tbl_CleaningMaterials' table. You can move, or remove it, as needed.
        'Me.Tbl_CleaningMaterialsTableAdapter.Fill(Me.MISInventoryDatabaseDataSet.tbl_CleaningMaterials)
        'TODO: This line of code loads data into the 'MISInventoryDatabaseDataSet.tbl_Electronics' table. You can move, or remove it, as needed.
        'Me.Tbl_ElectronicsTableAdapter.Fill(Me.MISInventoryDatabaseDataSet.tbl_Electronics)

        COUNTINGEquipments() 'DISPLAY SUB FUNCTION EQUIPMENTS
        COUNTINGAccessories() 'DISPLAY SUB FUNCTION ACCESSORIES
        COUNTINGCleaningMat() 'DISPLAY SUB FUNCTION CLEANINGMAT
        COUNTINGRoom() 'DISPLAY SUB FUNCTION ROOM

        showSubDash()
        sPanelDash.Visible = False
        sPanelName.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = True
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False
        
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
        panelDashboard.Visible = False
    End Sub
    Private Sub showSubUser()
        panelUser.Visible = True
        panelDashboard.Visible = False
    End Sub
    Private Sub showSubDash()
        panelUser.Visible = False
        panelDashboard.Visible = True
        Panel_HistoryM.Visible = False
    End Sub
    Private Sub showSubHistory()
        Panel_HistoryM.Visible = True
        panelUser.Visible = False
        panelDashboard.Visible = False
    End Sub

    'SLIDEBAR USER
    Private Sub CodesOfUser()
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelName.Height = btn_User.Height
        sPanelName.Top = btn_User.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = True
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False

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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelEdit.Height = btn_EditProfile.Height
        sPanelEdit.Top = btn_EditProfile.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = True
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False

        txtEditStudNum.Text = StoreAdminStudNum
        txtEditUsername.Text = AdminLoginForm.txt_Username.Text
        lblCurrentPassword.Text = AdminLoginForm.txt_Password.Text

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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelDash.Height = btn_Dashboard.Height
        sPanelDash.Top = btn_Dashboard.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = True
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelEdit.Height = btn_EditProfile.Height
        sPanelEdit.Top = btn_EditProfile.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = True
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False

        txtEditStudNum.Text = StoreAdminStudNum
        txtEditUsername.Text = AdminLoginForm.txt_Username.Text
        lblCurrentPassword.Text = AdminLoginForm.txt_Password.Text
    End Sub

    'SLIDEBAR LOGOUT
    Private Sub btn_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Logout.Click
        LogoutConfirmation.btn_User.Visible = False
        LogoutConfirmation.btn_super.Visible = False
        LogoutConfirmation.btn_Cancel.Visible = False
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelLogout.Height = btn_Logout.Height
        sPanelLogout.Top = btn_Logout.Top
    End Sub

    'ELECTRONICS SLIDEBAR & MAIN CODE
    Private Sub CodesOfElectronics()
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelElectronics.Height = btn_Electronics.Height
        sPanelElectronics.Top = btn_Electronics.Top

        panel_Electronics.Visible = True
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False
        
    End Sub
    Private Sub btn_Electronics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Electronics.Click, btn_BorrowElec.Click
        Dim da1 As New OleDbDataAdapter("select * from tbl_Electronics ORDER BY (ID) ", connection)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        dgvElectronics.DataSource = dt1
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da2 As New OleDbDataAdapter("SELECT ID, EquipmentDetails, Equipments, Condition, Cost, StatusDelete, Availability FROM tbl_Electronics", connection)
        Dim dTable As New DataTable
        da2.Fill(dTable)
        dgvElectronics.DataSource = dTable.DefaultView
        CodesOfElectronics()
        connection.Close()
    End Sub
    'ELECTRONICS DASHBOARD BUTTON
    Private Sub btn_BorrowElec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CodesOfElectronics()
    End Sub

    'CLEANINGMATERIALS SLIDEBAR & MAIN CODE
    Private Sub CodesOfCleaning()
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelCleaning.Height = btn_CleaningMaterials.Height
        sPanelCleaning.Top = btn_CleaningMaterials.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = True
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False
    End Sub
    Private Sub btn_CleaningMaterials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CleaningMaterials.Click, btn_BorrowCleaning.Click
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da2 As New OleDbDataAdapter("SELECT ID, EquipmentDetails, Equipments, Condition, Cost, StatusDelete, Availability FROM tbl_CleaningMaterials", connection)
        Dim d2Table As New DataTable
        da2.Fill(d2Table)
        dgvCleaningMaterials.DataSource = d2Table.DefaultView
        connection.Close()
        CodesOfCleaning()
    End Sub
    'CLEANINGMATERIALS DASHBOARD BUTTON
    Private Sub btn_BorrowCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CodesOfCleaning()
    End Sub

    'CLASSROOM SLIDEBAR & MAIN CODE
    Private Sub CodesOfClassroom()
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelClassrooms.Height = btn_Classroom.Height
        sPanelClassrooms.Top = btn_Classroom.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = True
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False
    End Sub
    Private Sub btn_Classroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Classroom.Click, btn_BorrowClassroom.Click
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da3 As New OleDbDataAdapter("SELECT ID, Room, Condition, StatusDelete, Availability FROM tbl_Classrooms", connection)
        Dim d2Table As New DataTable
        da3.Fill(d2Table)
        dgvClassroom.DataSource = d2Table.DefaultView
        connection.Close()
        CodesOfClassroom()

    End Sub
    'CLASSROOM DASHBOARD BUTTON
    Private Sub btn_BorrowClassroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CodesOfClassroom()
    End Sub

    'ACCESSORIES SLIDEBAR & MAIN CODE
    Private Sub CodesOfAccessories()
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
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanelAccessories.Height = btn_Accessories.Height
        sPanelAccessories.Top = btn_Accessories.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = True
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False

    End Sub
    Private Sub btn_Accessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Accessories.Click, btn_BorrowAccessories.Click
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da4 As New OleDbDataAdapter("SELECT ID, EquipmentDetails, Equipments, Condition, Cost, StatusDelete, Availability FROM tbl_Accessories", connection)
        Dim d2Table As New DataTable
        da4.Fill(d2Table)
        dgvAccessories.DataSource = d2Table.DefaultView
        connection.Close()
        CodesOfAccessories()
    End Sub
    'ACCESSORIES DASHBOARD BUTTON
    Private Sub btn_BorrowAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CodesOfAccessories()
    End Sub

    'HISTORY SIDEBAR & MAIN CODE
    Private Sub CodesOfHistory()
        showSubHistory()
        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = True
        sPanel_HistoryProf.Visible = False

        sPanel_HistoryBorrowers.Height = btn_History2.Height
        sPanel_HistoryBorrowers.Top = btn_History2.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = True
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = False
    End Sub
    Private Sub btn_History_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_History.Click
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da5 As New OleDbDataAdapter("SELECT Student_no, Room, Time, Date, ItemBorrowed, StatusReturn, Condition FROM tbl_BorrowerHistory", connection)
        Dim d5Table As New DataTable
        da5.Fill(d5Table)
        dgvHistory.DataSource = d5Table.DefaultView
        connection.Close()
        CodesOfHistory()
    End Sub
    Private Sub btn_History2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_History2.Click
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da5 As New OleDbDataAdapter("SELECT Student_no, Room, Time, Date, ItemBorrowed, StatusReturn, Condition FROM tbl_BorrowerHistory", connection)
        Dim d5Table As New DataTable
        da5.Fill(d5Table)
        dgvHistory.DataSource = d5Table.DefaultView
        connection.Close()
        CodesOfHistory()
    End Sub
    'HISTORY PROF BORROW HISTORY MAIN CODE AND SIDE PANEL
    Private Sub CodesOfProfHistory()
        showSubHistory()

        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = False
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = True

        sPanel_HistoryProf.Height = btn_ProfBorrowHistory.Height
        sPanel_HistoryProf.Top = btn_ProfBorrowHistory.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = True
        panel_HistoryPayment.Visible = False
    End Sub
    'HISTORY OF PROF BORROW
    Private Sub btn_ProfBorrowHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ProfBorrowHistory.Click
        CodesOfProfHistory()
        connection.Open()
        ' MsgBox("Open")
        Dim da7 As New OleDbDataAdapter("SELECT Professor, Department, ClassYear, ItemBorrowed, Condition, Date, Time, AdminAccount FROM tbl_ProfBorrower", connection)
        Dim d7Table As New DataTable
        da7.Fill(d7Table)
        dgv_ProfHistory.DataSource = d7Table.DefaultView
        connection.Close()
    End Sub
    'HISTORY PAYMENT
    Private Sub CodesOfHistoryPayment()
        showSubHistory()

        sPanelName.Visible = False
        sPanelDash.Visible = False
        sPanelEdit.Visible = False
        sPanelLogout.Visible = False
        sPanelElectronics.Visible = False
        sPanelCleaning.Visible = False
        sPanelClassrooms.Visible = False
        sPanelAccessories.Visible = False
        sPanelDash2.Visible = False
        sPanelHistory.Visible = False
        sPanel_HisotryPayment.Visible = True
        sPanel_HistoryBorrowers.Visible = False
        sPanel_HistoryProf.Visible = False

        sPanel_HisotryPayment.Height = btn_HistoryPayment.Height
        sPanel_HisotryPayment.Top = btn_HistoryPayment.Top

        panel_Electronics.Visible = False
        panel_Dash.Visible = False
        panel_CleaningMaterials.Visible = False
        panel_Classroom.Visible = False
        panel_Accessories.Visible = False
        panel_UserProfile.Visible = False
        panel_EditProfile.Visible = False
        panel_History.Visible = False
        panel_ProfHistory.Visible = False
        panel_HistoryPayment.Visible = True
    End Sub
    Private Sub btn_HistoryPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HistoryPayment.Click
        CodesOfHistoryPayment()
        connection.Open()
        Dim query As String
        'query = "SELECT [tbl_BorrowerHistory.Student_no],[Course],[Year],[Section],[Penalty],[ItemBorrowed],[Condition],[Month Paid] FROM tbl_Users, tbl_BorrowerHistory, tbl_HistoryPayment WHERE tbl_Users.Student_no = tbl_BorrowerHistory.Student_no AND tbl_BorrowerHistory.Student_no = tbl_HistoryPayment.Student_no AND Condition='Damage'"

        query = "SELECT [tbl_BorrowerHistory.Student_no],[Course],[Year],[Section],[Penalty],[ItemBorrowed],[Condition],[Paid],[Date] FROM tbl_Users INNER JOIN tbl_BorrowerHistory ON tbl_Users.Student_no = tbl_BorrowerHistory.Student_no WHERE Penalty Like '%Damage%' OR Condition Like '%Damage%'"

        '  Dim da6 As New OleDbDataAdapter("Select [tbl_BorrowerHistory.Student_no],[Course],[Year],[Section],[Penalty],[ItemBorrowed],[Condition],[Month Paid] FROM tbl_Users INNER JOIN tbl_BorrowerHistory RIGHT JOIN tbl_HistoryPayment " _
        '& " ON tbl_Users.Student_no = tbl_BorrowerHistory.Student_no ON tbl_BorrowerHistory.Student_no = tbl_HistoryPayment.Student_no WHERE Penalty Like '%Damage%' and Condition='Damage'", connection)
        Dim da6 As New OleDbDataAdapter(query, connection)
        Dim d6Table As New DataTable
        da6.Fill(d6Table)
        dgv_HistoryPayment.DataSource = d6Table.DefaultView
        dgv_HistoryPayment.Columns(0).HeaderText = "Student Number"
        dgv_HistoryPayment.Columns(5).HeaderText = "Borrowed Item"
        connection.Close()
    End Sub

    'BUTTON ADD ITEM ELECTRONICS
    Private Sub btn_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddItem.Click
        Admin_AddItem.Show()
    End Sub
    'ELECTRONICS BUTTON UPDATE ITEM
    Private Sub btn_UpdateItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdateItem.Click
        Admin_UpdateItem.txt_ID.Text = dgvElectronics.CurrentRow.Cells(0).Value.ToString
        Admin_UpdateItem.cmb_ElectronicsDetails.Text = dgvElectronics.CurrentRow.Cells(1).Value.ToString
        Admin_UpdateItem.txt_Equipments.Text = dgvElectronics.CurrentRow.Cells(2).Value.ToString
        Admin_UpdateItem.cmb_Condition.Text = dgvElectronics.CurrentRow.Cells(3).Value.ToString
        Admin_UpdateItem.txt_Cost.Text = dgvElectronics.CurrentRow.Cells(4).Value.ToString
        Admin_UpdateItem.cmb_StatusDelete.Text = dgvElectronics.CurrentRow.Cells(5).Value.ToString
        Admin_UpdateItem.cmb_Availability.Text = dgvElectronics.CurrentRow.Cells(6).Value.ToString
        Admin_UpdateItem.lblDateElectronics.Text = StoreAdminDate 'ADMIN DATE TO UPDATE ITEM ELECTRONICS
        Admin_UpdateItem.Show()
    End Sub
    'ELECTRONICS TABLE BUTTON REFRESH
    Private Sub btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh.Click
        Dim da1 As New OleDbDataAdapter("select * from tbl_Electronics ORDER BY (ID) ", connection)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        dgvElectronics.DataSource = dt1
    End Sub
    'ELECTRONICS ITEM BUTTON DELETE 
    Private Sub btn_DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteItem.Click
        Admin_DeleteItem.txt_ID.Text = dgvElectronics.CurrentRow.Cells(0).Value.ToString
        Admin_DeleteItem.txt_Equipments.Text = dgvElectronics.CurrentRow.Cells(1).Value.ToString
        Admin_DeleteItem.cmb_Condition.Text = dgvElectronics.CurrentRow.Cells(2).Value.ToString
        Admin_DeleteItem.txt_Cost.Text = dgvElectronics.CurrentRow.Cells(3).Value.ToString
        Admin_DeleteItem.txt_StatusDelete.Text = dgvElectronics.CurrentRow.Cells(4).Value.ToString
        Admin_DeleteItem.txt_Availability.Text = dgvElectronics.CurrentRow.Cells(5).Value.ToString
        Admin_DeleteItem.Show()

    End Sub

    'CLEANING MATERIALS BUTTON ADD ITEM
    Private Sub btn_AddItemCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddItemCleaning.Click
        Admin_AddItemCleaningMaterials.Show()
    End Sub
    'CLEANING MATERIALS BUTTON UPDATE ITEM
    Private Sub btn_UpdateItemCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdateItemCleaning.Click
        Admin_UpdateItemCleaning.txt_ID.Text = dgvCleaningMaterials.CurrentRow.Cells(0).Value.ToString
        Admin_UpdateItemCleaning.cmb_Details.Text = dgvCleaningMaterials.CurrentRow.Cells(1).Value.ToString
        Admin_UpdateItemCleaning.txt_Equipments.Text = dgvCleaningMaterials.CurrentRow.Cells(2).Value.ToString
        Admin_UpdateItemCleaning.cmb_Condition.Text = dgvCleaningMaterials.CurrentRow.Cells(3).Value.ToString
        Admin_UpdateItemCleaning.txt_Cost.Text = dgvCleaningMaterials.CurrentRow.Cells(4).Value.ToString
        Admin_UpdateItemCleaning.cmb_StatusDelete.Text = dgvCleaningMaterials.CurrentRow.Cells(5).Value.ToString
        Admin_UpdateItemCleaning.cmb_Availability.Text = dgvCleaningMaterials.CurrentRow.Cells(6).Value.ToString
        Admin_UpdateItemCleaning.lblDate.Text = StoreAdminDate 'ADMIN DATE TO UPDATE ITEM CLEANING
        Admin_UpdateItemCleaning.Show()
    End Sub
    'CLEANING DELETE BUTTON
    Private Sub btn_DeleteItemCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteItemCleaning.Click
        Admin_DeleteItemCleaning.txt_ID.Text = dgvCleaningMaterials.CurrentRow.Cells(0).Value.ToString
        Admin_DeleteItemCleaning.txt_Equipments.Text = dgvCleaningMaterials.CurrentRow.Cells(1).Value.ToString
        Admin_DeleteItemCleaning.cmb_Condition.Text = dgvCleaningMaterials.CurrentRow.Cells(2).Value.ToString
        Admin_DeleteItemCleaning.txt_Cost.Text = dgvCleaningMaterials.CurrentRow.Cells(3).Value.ToString
        Admin_DeleteItemCleaning.txt_StatusDelete.Text = dgvCleaningMaterials.CurrentRow.Cells(4).Value.ToString
        Admin_DeleteItemCleaning.txt_Availability.Text = dgvCleaningMaterials.CurrentRow.Cells(5).Value.ToString
        Admin_DeleteItemCleaning.Show()
    End Sub
    'CLEANING REFRESH BUTTON
    Private Sub btn_RefreshCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RefreshCleaning.Click
        Dim da2 As New OleDbDataAdapter("select * from tbl_CleaningMaterials ORDER BY (ID) ", connection)
        Dim d2Table As New DataTable
        da2.Fill(d2Table)
        dgvCleaningMaterials.DataSource = d2Table
    End Sub

    'CLASSROOMS ADD ITEM
    Private Sub btn_AddItemClassrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddItemClassrooms.Click
        Admin_AddItemClassrooms.Show()
    End Sub
    'CLASSROOMS UPDATE ITEM BUTTON
    Private Sub btn_UpdateItemClassrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdateItemClassrooms.Click
        Admin_UpdateItemClassrooms.txt_ID.Text = dgvClassroom.CurrentRow.Cells(0).Value.ToString
        Admin_UpdateItemClassrooms.txt_Equipments.Text = dgvClassroom.CurrentRow.Cells(1).Value.ToString
        Admin_UpdateItemClassrooms.cmb_Condition.Text = dgvClassroom.CurrentRow.Cells(2).Value.ToString
        'Admin_UpdateItemClassrooms.txt_Room.Text = dgvClassroom.CurrentRow.Cells(3).Value.ToString
        Admin_UpdateItemClassrooms.cmb_StatusDelete.Text = dgvClassroom.CurrentRow.Cells(3).Value.ToString
        Admin_UpdateItemClassrooms.cmb_Availability.Text = dgvClassroom.CurrentRow.Cells(4).Value.ToString
        Admin_UpdateItemClassrooms.lblDate.Text = StoreAdminDate 'ADMIN DATE TO UPDATE ITEM CLASSROOMS
        Admin_UpdateItemClassrooms.Show()
    End Sub
    'CLASSROOMS DELETE BUTTON
    Private Sub btn_DeleteItemClassrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteItemClassrooms.Click
        Admin_DeleteItemClassrooms.txt_ID.Text = dgvClassroom.CurrentRow.Cells(0).Value.ToString
        Admin_DeleteItemClassrooms.txt_Equipments.Text = dgvClassroom.CurrentRow.Cells(1).Value.ToString
        Admin_DeleteItemClassrooms.cmb_Condition.Text = dgvClassroom.CurrentRow.Cells(2).Value.ToString
        'Admin_DeleteItemClassrooms.txt_Cost.Text = dgvClassroom.CurrentRow.Cells(3).Value.ToString
        Admin_DeleteItemClassrooms.txt_StatusDelete.Text = dgvClassroom.CurrentRow.Cells(3).Value.ToString
        Admin_DeleteItemClassrooms.txt_Availability.Text = dgvClassroom.CurrentRow.Cells(4).Value.ToString
        Admin_DeleteItemClassrooms.Show()
    End Sub
    'CLASSROOMS REFRESH BUTTON
    Private Sub btn_RefreshClassrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RefreshClassrooms.Click
        Dim da3 As New OleDbDataAdapter("select * from tbl_Classrooms ORDER BY (ID) ", connection)
        Dim d2Table As New DataTable
        da3.Fill(d2Table)
        dgvClassroom.DataSource = d2Table.DefaultView
    End Sub

    'ACCESSORIES ADD ITEM
    Private Sub btn_AddItemAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddItemAccessories.Click
        Admin_AddItemAccessories.Show()
    End Sub
    'ACCESSORIES UPDATE ITEM
    Private Sub btn_UpdateItemAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdateItemAccessories.Click
        Admin_UpdateItemAccessories.txt_ID.Text = dgvAccessories.CurrentRow.Cells(0).Value.ToString
        Admin_UpdateItemAccessories.cmb_Details.Text = dgvAccessories.CurrentRow.Cells(1).Value.ToString
        Admin_UpdateItemAccessories.txt_Equipments.Text = dgvAccessories.CurrentRow.Cells(2).Value.ToString
        Admin_UpdateItemAccessories.cmb_Condition.Text = dgvAccessories.CurrentRow.Cells(3).Value.ToString
        Admin_UpdateItemAccessories.txt_Cost.Text = dgvAccessories.CurrentRow.Cells(4).Value.ToString
        Admin_UpdateItemAccessories.cmb_StatusDelete.Text = dgvAccessories.CurrentRow.Cells(5).Value.ToString
        Admin_UpdateItemAccessories.cmb_Availability.Text = dgvAccessories.CurrentRow.Cells(6).Value.ToString
        Admin_UpdateItemAccessories.lblDate.Text = StoreAdminDate 'ADMIN DATE TO UPDATE ITEM ACCESSORIES

        Admin_UpdateItemAccessories.Show()
    End Sub
    'ACCESSORIES DELETE ITEM BUTTON
    Private Sub btn_DeleteItemAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteItemAccessories.Click
        Admin_DeleteItemAccessories.txt_ID.Text = dgvAccessories.CurrentRow.Cells(0).Value.ToString
        Admin_DeleteItemAccessories.txt_Equipments.Text = dgvAccessories.CurrentRow.Cells(1).Value.ToString
        Admin_DeleteItemAccessories.cmb_Condition.Text = dgvAccessories.CurrentRow.Cells(2).Value.ToString
        Admin_DeleteItemAccessories.txt_Cost.Text = dgvAccessories.CurrentRow.Cells(3).Value.ToString
        Admin_DeleteItemAccessories.txt_StatusDelete.Text = dgvAccessories.CurrentRow.Cells(4).Value.ToString
        Admin_DeleteItemAccessories.txt_Availability.Text = dgvAccessories.CurrentRow.Cells(5).Value.ToString
        Admin_DeleteItemAccessories.Show()
    End Sub
    'ACCESSORIES REFRESH BUTTON
    Private Sub btn_RefreshAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RefreshAccessories.Click
        Dim da4 As New OleDbDataAdapter("select * from tbl_Accessories ORDER BY (ID) ", connection)
        Dim d2Table As New DataTable
        da4.Fill(d2Table)
        dgvAccessories.DataSource = d2Table.DefaultView
    End Sub

    Private Sub btn_UpdatePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UpdatePayment.Click
        Admin_UpdatePayment.txtbox_StudentNumber.Text = dgv_HistoryPayment.CurrentRow.Cells(0).Value.ToString()
        Admin_UpdatePayment.txtbox_ItemBorrowed.Text = dgv_HistoryPayment.CurrentRow.Cells(5).Value.ToString
        Admin_UpdatePayment.Show()
    End Sub

    Private Sub btn_ProfBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ProfBorrow.Click
        'ElectronicsAvailability.btn_Back.Visible = False
        'ElectronicsAvailability.Show()
        ProfBorrowForm.Show()
        Me.Close()

    End Sub

    Private Sub btn_BannedList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BannedList.Click
        Notice.btn_Back.Visible = False
        Notice.Show()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        connection.Open()
        If lblMatchP.Text = "Not Matched" Then

            MessageBox.Show("Old Password did not match")

        Else

            If txtEditUsername.Text = Nothing Or txtEditPassword.Text = Nothing Or txtNewPass.Text = Nothing Then
                MsgBox("Fields must not leftblank!")
            Else




                Dim EditProfileUpdate As New OleDbCommand("UPDATE tbl_Admin SET [Username]='" & txtEditUsername.Text & "', [Password]='" & txtNewPass.Text & "' WHERE [ID]='" & StoreAdminStudNum & "'", connection)
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

    Private Sub txtEditUsername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEditUsername.KeyPress, txtEditPassword.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub btn_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show.Click
        If txtNewPass.UseSystemPasswordChar = True Then
            txtNewPass.UseSystemPasswordChar = False
        Else
            txtNewPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtNewPass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPass.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True

        End If
    End Sub
End Class