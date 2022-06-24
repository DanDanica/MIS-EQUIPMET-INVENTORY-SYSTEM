Imports System.Data.OleDb

Public Class ProfBorrowForm
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

    Private Sub dash_Electronics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dash_Electronics.Click
        ElectronicsAvailability.btn_Back.Visible = False
        ElectronicsAvailability.Show()
        Me.Close()
    End Sub

    Private Sub dash_Cleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dash_Cleaning.Click
        CleaningMaterialsAvailability.btn_Back.Visible = False
        CleaningMaterialsAvailability.Show()
        Me.Close()
    End Sub

    Private Sub dash_Classroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dash_Classroom.Click
        ClassroomsAvailability.btn_Back.Visible = False
        ClassroomsAvailability.Show()
        Me.Close()
    End Sub

    Private Sub dash_Accessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dash_Accessories.Click
        AccessoriesAvailability.btn_Back.Visible = False
        AccessoriesAvailability.Show()
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
        AdminDashboard.Show()

    End Sub

    Private Sub ProfBorrowForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        COUNTINGEquipments() 'DISPLAY SUB FUNCTION EQUIPMENTS
        COUNTINGAccessories() 'DISPLAY SUB FUNCTION ACCESSORIES
        COUNTINGCleaningMat() 'DISPLAY SUB FUNCTION CLEANINGMAT
        COUNTINGRoom() 'DISPLAY SUB FUNCTION ROOM
    End Sub
End Class