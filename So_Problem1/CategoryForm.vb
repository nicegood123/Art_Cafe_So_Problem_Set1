Imports MySql.Data.MySqlClient

Public Class CategoryForm

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Public myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Public getCategoryName As String = ""
    Public showNoAction As String = ""
    Public getCategoryStatus As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddb("SELECT * FROM tbl_category", dbCategory)
    End Sub

    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub bttnClose_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loaddb("SELECT * FROM tbl_category where CategoryName like '%" & txtSearch.Text & "%'", dbCategory)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub bttnClose_Click_1(sender As Object, e As EventArgs) Handles bttnClose.Click
        End
    End Sub

    Private Sub dbCategory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dbCategory.CellDoubleClick
        ActionCategoryForm.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddCategoryDialog.ShowDialog()
    End Sub
End Class