Imports System.Data.OleDb

Public Class AccessoriesAvailability

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
    End Sub

    Private Sub AccessoriesAvailability_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        ' MsgBox("Open")
        Dim da1 As New OleDbDataAdapter("SELECT ID, Equipments, Condition, Cost, Availability FROM tbl_Accessories", connection)
        Dim dTable As New DataTable
        da1.Fill(dTable)
        dgv_UserAccessories.DataSource = dTable.DefaultView
        connection.Close()
        Timer1.Enabled = True 'NEED THIS!!

    End Sub

    Private Sub btn_ProfBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ProfBorrow.Click
        Prof_BorrowingConfirmation.txtbox_StudentNumber.Text = dgv_UserAccessories.CurrentRow.Cells(0).Value.ToString
        Prof_BorrowingConfirmation.txtbox_ItemBorrow.Text = dgv_UserAccessories.CurrentRow.Cells(1).Value.ToString
        Prof_BorrowingConfirmation.txtbox_Condition.Text = dgv_UserAccessories.CurrentRow.Cells(2).Value.ToString
        Prof_BorrowingConfirmation.txtbox_Availability.Text = dgv_UserAccessories.CurrentRow.Cells(4).Value.ToString
        Prof_BorrowingConfirmation.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MM-dd-yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        StoreTime = lblTime.Text ' STORE DATE TO THIS GLOBAL VARIABLE
        StoreDate = lblDate.Text ' STORE TIME TO THIS GLOBAL VARIABLE
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
        ProfBorrowForm.Show()
    End Sub
End Class