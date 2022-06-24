Imports System.Data.OleDb

Public Class Notice

    Private Sub Notice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SearchData("") ' SUB FUNCTION SEARCHING DATA AND SHOWING DATAGRIDVIEW PENALIZED
        connection.Close()
        connection.Open()

        Dim LoadPenalty As New OleDbDataAdapter("Select [tbl_BorrowerHistory.Student_no],[Course],[Year],[Section],[Penalty],[ItemBorrowed],[Condition] FROM tbl_Users INNER JOIN tbl_BorrowerHistory ON tbl_Users.Student_no = tbl_BorrowerHistory.Student_no WHERE Penalty Like '%Damage%' AND Condition Like '%Damage%'", connection)
        ' QUERY FOR LOAD PENALTY, INNER JOIN WITH TBL BORROWER HISTORY AND USERS THAT WAS PENALIZED 
        ' NOTED THAT NEED TO CHANGE THE stud_no of borrower history to Student_no (INNER JOIN REQUIRED)
        ' WHERE CLAUSE ACCOUNT SHOULD HAVE PENALTY COLUMN(tbl_users) AND THE CONDITION COLUMN(tbl_borrowerHistory) MUST BE DAMAGE TO AVOID DUPLICATION OF PENALTIES WITH THE SAME STUDENT NUMBER
        'ONLY STUDENT NUMBER CAN BE SEARCH
        Dim dataTable As New DataTable
        LoadPenalty.Fill(dataTable)
        dgv_Penalty.DataSource = dataTable

        dgv_Penalty.Columns(0).HeaderText = "Student Number" ' DATA GRID VIEW COLUMN (0) CHANGE TO STUDENT NUMBER

        connection.Close()
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        SearchData(txtbox_Search.Text) ' TEXTBOX FOR STUDENT NUMBER TO SEARCH 
    End Sub
    Public Sub SearchData(ByVal valueToSearch As String)

        connection.Close()
        connection.Open()

        Dim LoadPenalty As New OleDbDataAdapter("Select [tbl_BorrowerHistory.Student_no],[Course],[Year],[Section],[Penalty],[ItemBorrowed] FROM tbl_Users INNER JOIN tbl_BorrowerHistory ON tbl_Users.Student_no = tbl_BorrowerHistory.Student_no WHERE Penalty Like '%Damage%' and tbl_BorrowerHistory.Student_no LIKE '%" & valueToSearch & "%'", connection)
        ' QUERY FOR LOAD PENALTY, INNER JOIN WITH TBL BORROWER HISTORY AND USERS THAT WAS PENALIZED 
        ' NOTED THAT NEED TO CHANGE THE stud_no of borrower history to Student_no (INNER JOIN REQUIRED)
        ' WHERE CLAUSE ACCOUNT SHOULD HAVE PENALTY COLUMN(tbl_users) AND THE CONDITION COLUMN(tbl_borrowerHistory) MUST BE DAMAGE TO AVOID DUPLICATION OF PENALTIES WITH THE SAME STUDENT NUMBER
        'ONLY STUDENT NUMBER CAN BE SEARCH
        Dim dataTable As New DataTable
        LoadPenalty.Fill(dataTable)
        dgv_Penalty.DataSource = dataTable

        dgv_Penalty.Columns(0).HeaderText = "Student Number" ' DATA GRID VIEW COLUMN (0) CHANGE TO STUDENT NUMBER

        connection.Close()
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Close()
        LetterNotice.Show()

    End Sub

    Private Sub btn_Back1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back1.Click
        Me.Close()
    End Sub

    Private Sub txtbox_Search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_Search.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub
End Class