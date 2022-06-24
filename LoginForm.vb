Imports System.Data.OleDb

Public Class LoginForm
    'Dim connection As New OleDbConnection(My.Settings.LoginConnectionString)

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Username.Text = ""
        txt_Password.Text = ""
        pnlElectronics.BackColor = Color.FromArgb(60, 0, 0, 0)
        pnlCleaning.BackColor = Color.FromArgb(60, 0, 0, 0)
        pnlClassrooms.BackColor = Color.FromArgb(60, 0, 0, 0)
        pnlAccessories.BackColor = Color.FromArgb(60, 0, 0, 0)

        COUNTINGEquipments() 'DISPLAY SUB FUNCTION EQUIPMENTS
        COUNTINGAccessories() 'DISPLAY SUB FUNCTION ACCESSORIES
        COUNTINGCleaningMat() 'DISPLAY SUB FUNCTION CLEANINGMAT
        COUNTINGRoom() 'DISPLAY SUB FUNCTION ROOM
    End Sub

    'COUNTING OF AVAILABLE ITEMS
    Sub COUNTINGEquipments()

        connection.Open()


        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Equipments]) FROM tbl_Electronics WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblElectronics.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE ELECTRONICS

        connection.Close()

    End Sub
    Sub COUNTINGCleaningMat()

        connection.Open()


        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Equipments]) FROM tbl_CleaningMaterials WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblCleaningMat.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE CLEANING MATERIALS

        connection.Close()

    End Sub
    Sub COUNTINGAccessories()
        connection.Open()
        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Equipments]) FROM tbl_Accessories WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblAccessories.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE ACCESSORIES

        connection.Close()

    End Sub
    Sub COUNTINGRoom()

        connection.Open()


        Dim countA As Integer
        Dim countavailable As New OleDbCommand("SELECT COUNT([Room]) FROM tbl_Classrooms WHERE [Availability] ='Available' ", connection)
        countA = countavailable.ExecuteScalar().ToString
        lblClassroom.Text = countA ' LABEL TO DISPLAY THE NUMBER OF AVAILABLE CLASSROOMS

        connection.Close()

    End Sub

    'LOGIN 
    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        Dim studnum As String

        If (txt_Username.Text = Nothing Or txt_Password.Text = Nothing) Then
            MsgBox("Please Enter Credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM tbl_Users WHERE Username=@Username AND Password=@Password AND [Penalty] Like '%None%' AND [StatusDelete]='Active'", connection)
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txt_Username.Text.Trim
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txt_Password.Text.Trim
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            
            'MessageBox.Show(studnum)
            If (count > 0) Then
                Dim login1 As New OleDbCommand("SELECT [Student_no] FROM tbl_Users WHERE [Username]='" & txt_Username.Text & "'", connection) 'QUERY
                Dim myreader As OleDbDataReader  'READ THE VALUE INSIDE THE TABLE
                login1.ExecuteNonQuery()
                myreader = login1.ExecuteReader   'EXECUTE THE QUERY
                myreader.Read()             'EXECUTE THE READER TO READ THE VALUE 
                studnum = myreader("Student_no").ToString      ' GET THE SPECIFIC STUDENT NUMBER OF USER WHO LOG IN
                StoreData = studnum 'Store data in the Global variable

                Dashboard2.Show()
                Me.Hide()
            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
            End If
        End If
        connection.Close()

    End Sub
    'SIGNUPFORM
    Private Sub here_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles here.Click
        Signup.btn_SignUpSuper.Visible = False
        Signup.btn_CancelSuper.Visible = False
        Signup.Show()
        Me.Hide()
    End Sub
    Private Sub Username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Username.TextChanged
        Dashboard2.btn_User.Text = DirectCast(sender, TextBox).Text
        Dashboard2.lbl_Username.Text = DirectCast(sender, TextBox).Text
        'AdminDashboard.btn_User.Text = DirectCast(sender, TextBox).Text
        'AdminDashboard.lbl_Username.Text = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub btn_Notice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Notice.Click
        LetterNotice.Show() 'SHOW LETTER NOTICE FORM
        Me.Hide()  ' HIDE LOG IN FORM
    End Sub

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

    Private Sub pnlCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlCleaning.Click
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_CleaningMaterials", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        CleaningMaterialsAvailability.dgv_UserCleaningMaterials.DataSource = dTable.DefaultView
        CleaningMaterialsAvailability.btn_ProfBorrow.Visible = False
        CleaningMaterialsAvailability.btn_Cancel.Visible = False
        CleaningMaterialsAvailability.Show()
        connection.Close()
    End Sub

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

    Private Sub pnlElectronics_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlElectronics.MouseHover
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

    Private Sub pnlElectronics_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlElectronics.MouseLeave
        ElectronicsAvailability.Close()
    End Sub


    Private Sub pnlClassrooms_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlClassrooms.MouseHover
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

    Private Sub pnlClassrooms_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlClassrooms.MouseLeave
        ClassroomsAvailability.Close()
    End Sub


End Class
