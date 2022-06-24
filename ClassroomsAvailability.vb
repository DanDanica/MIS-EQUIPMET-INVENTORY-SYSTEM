Imports System.Data.OleDb

Public Class ClassroomsAvailability

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
        ProfBorrowForm.Show()
    End Sub

    Private Sub ClassroomsAvailability_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Room, Condition, Availability FROM tbl_Classrooms", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        dgv_UserClassroom.DataSource = dTable.DefaultView
        connection.Close()
        Timer1.Enabled = True 'NEED THIS!!
    End Sub

    Private Sub btn_ProfBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ProfBorrow.Click
        ProfClassroomBorrowingConfirmation.txtbox_StudentNumber.Text = dgv_UserClassroom.CurrentRow.Cells(0).Value.ToString
        ProfClassroomBorrowingConfirmation.txt_RoomNumber.Text = dgv_UserClassroom.CurrentRow.Cells(1).Value.ToString
        ProfClassroomBorrowingConfirmation.txtbox_Condition.Text = dgv_UserClassroom.CurrentRow.Cells(2).Value.ToString
        ProfClassroomBorrowingConfirmation.txtbox_Availability.Text = dgv_UserClassroom.CurrentRow.Cells(3).Value.ToString
        ProfClassroomBorrowingConfirmation.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MM-dd-yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        StoreTime = lblTime.Text ' STORE DATE TO THIS GLOBAL VARIABLE
        StoreDate = lblDate.Text ' STORE TIME TO THIS GLOBAL VARIABLE
    End Sub

End Class