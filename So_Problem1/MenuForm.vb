Imports MySql.Data.MySqlClient

Public Class MenuForm

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Public getMenuName As String = ""
    Public getMenuDescription As String = ""
    Public getMenuPrice As String = ""
    Public showNoAction As String = ""
    Public getMenuStatus As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddb("SELECT * FROM tbl_menu", dbMenu)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loaddb("SELECT * FROM tbl_menu where MenuName like '%" & txtSearch.Text & "%'", dbMenu)
    End Sub

    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        End
    End Sub

    Private Sub dbMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dbMenu.CellDoubleClick
        ActionMenuForm.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Me.Hide()
        CategoryForm.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMenuDialog.ShowDialog()
    End Sub
End Class
