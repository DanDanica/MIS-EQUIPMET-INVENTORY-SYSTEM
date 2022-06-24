Imports System.Data.OleDb

Public Class AdminLoginForm

    Private Sub AdminLoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Username.Text = ""
        txt_Password.Text = ""
        pnlElectronics.BackColor = Color.FromArgb(100, 0, 0, 0)
        pnlCleaning.BackColor = Color.FromArgb(100, 0, 0, 0)
        pnlClassrooms.BackColor = Color.FromArgb(100, 0, 0, 0)
        pnlAccessories.BackColor = Color.FromArgb(100, 0, 0, 0)

        COUNTINGEquipments() 'DISPLAY SUB FUNCTION EQUIPMENTS
        COUNTINGAccessories() 'DISPLAY SUB FUNCTION ACCESSORIES
        COUNTINGCleaningMat() 'DISPLAY SUB FUNCTION CLEANINGMAT
        COUNTINGRoom() 'DISPLAY SUB FUNCTION ROOM
    End Sub

    'COUNTING ITEMS FOR AVAILABILITY
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
        lblCleaningMat.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE CLEANING MATERIALS

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
        lblClassroom.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE CLASSROOMS

        connection.Close()
    End Sub

    'LOGGING IN OF ACCOUNT
    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        Dim Adminstudnum

        If (txt_Username.Text = Nothing Or txt_Password.Text = Nothing) Then
            MsgBox("Please Enter Credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM tbl_Admin WHERE Username=@Username AND Password=@Password AND [StatusDelete]='Active'", connection)
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txt_Username.Text.Trim
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txt_Password.Text.Trim
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())


            If (count > 0) Then

                'NEW CODE!!
                Dim login1 As New OleDbCommand("SELECT [ID] FROM tbl_Admin WHERE [Username]='" & txt_Username.Text & "'", connection) 'QUERY
                Dim myreader As OleDbDataReader  'READ THE VALUE INSIDE THE TABLE
                myreader = login1.ExecuteReader   'EXECUTE THE QUERY
                myreader.Read()             'EXECUTE THE READER TO READ THE VALUE 
                Adminstudnum = myreader("ID") ' GET THE SPECIFIC STUDENT NUMBER OF ADMIN WHO LOG IN
                StoreAdminStudNum = Adminstudnum 'Store data in the Global variable
                'MessageBox.Show(StoreAdminStudNum)

                AdminDashboard.Show()
                Me.Hide()
            ElseIf (txt_Username.Text = "Danica" And txt_Password.Text = "Danica") Then
                SuperAdmin_Dashboard.Show()
                Me.Hide()

            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
            End If
        End If

        connection.Close()
    End Sub
    'DIRECT CASTING OF USERNAME TO DISPLAY
    Private Sub Username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Username.TextChanged
        'Dashboard2.btn_User.Text = DirectCast(sender, TextBox).Text
        'Dashboard2.lbl_Username.Text = DirectCast(sender, TextBox).Text
        AdminDashboard.btn_User.Text = DirectCast(sender, TextBox).Text
        AdminDashboard.lbl_Username.Text = DirectCast(sender, TextBox).Text
        SuperAdmin_Dashboard.btn_User.Text = DirectCast(sender, TextBox).Text
        SuperAdmin_Dashboard.lbl_Username.Text = DirectCast(sender, TextBox).Text
    End Sub
    'BUTTON FOR AVAILABLE ELECTRONIC ITEMS
    Private Sub pnlElectronics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlElectronics.Click
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_Electronics", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        ElectronicsAvailability.dgv_UserElectronics.DataSource = dTable.DefaultView
        ElectronicsAvailability.btn_ProfBorrow.Visible = False
        ElectronicsAvailability.btn_Cancel.Visible = False
        ElectronicsAvailability.Show()
        connection.Close()
    End Sub
    'BUTTON FOR AVAILABLE CLEANING MATERIALS
    Private Sub pnlCleaning_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlCleaning.Click
        connection.Open()
        ' MsgBox("Open")
        'Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_CleaningMaterials", connection)
        'Dim dTable As New DataTable
        Dim da2 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_CleaningMaterials", connection)
        Dim d2Table As New DataTable
        da2.Fill(d2Table)
        CleaningMaterialsAvailability.dgv_UserCleaningMaterials.DataSource = d2Table.DefaultView
        CleaningMaterialsAvailability.btn_ProfBorrow.Visible = False
        CleaningMaterialsAvailability.btn_Cancel.Visible = False
        CleaningMaterialsAvailability.Show()
        connection.Close()

        'connection.Open()
        '' MsgBox("Open")

        'da2.Fill(d2Table)
        'CleaningMaterialsAvailability.dgv_UserCleaningMaterials.DataSource = d2Table.DefaultView
        'connection.Close()

    End Sub
    'BUTTON FOR AVAILABLE CLASSROOMS
    Private Sub pnlClassrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlClassrooms.Click
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Room, Condition, Availability FROM tbl_Classrooms", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        ClassroomsAvailability.dgv_UserClassroom.DataSource = dTable.DefaultView
        ClassroomsAvailability.btn_ProfBorrow.Visible = False
        ClassroomsAvailability.btn_Cancel.Visible = False
        ClassroomsAvailability.Show()
        connection.Close()
    End Sub
    'BUTTON FOR AVAILABLE ACCESSORIES
    Private Sub pnlAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlAccessories.Click
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_Accessories", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        AccessoriesAvailability.dgv_UserAccessories.DataSource = dTable.DefaultView
        AccessoriesAvailability.btn_ProfBorrow.Visible = False
        AccessoriesAvailability.btn_Cancel.Visible = False
        AccessoriesAvailability.Show()
        connection.Close()
    End Sub

    Private Sub btn_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show.Click
        If txt_Password.UseSystemPasswordChar = True Then
            txt_Password.UseSystemPasswordChar = False
        Else
            txt_Password.UseSystemPasswordChar = True
        End If
    End Sub
End Class