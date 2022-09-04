Imports MySql.Data.MySqlClient

Public Class UpdateCategoryDialog
    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub UpdateCategoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currRow As Integer = CategoryForm.dbCategory.CurrentRow.Index
        Debug.Print(currRow.ToString)
        txtCategoryID.Text = CategoryForm.dbCategory(0, currRow).Value.ToString
        txtCategoryName.Text = CategoryForm.dbCategory(1, currRow).Value.ToString
        txtCategoryStatus.Text = CategoryForm.dbCategory(2, currRow).Value.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        loadtxt("SELECT CategoryName FROM tbl_category WHERE CategoryID = " & txtCategoryID.Text & "", CategoryForm.getCategoryName)
        loadtxt("SELECT CategoryID FROM tbl_category WHERE CategoryID = " & txtCategoryID.Text & "", CategoryForm.showNoAction)
        loadtxt("SELECT isActive FROM tbl_category WHERE CategoryID = " & txtCategoryID.Text & "", CategoryForm.getCategoryStatus)

        Using cn As New MySqlConnection(con)
            Dim SQLStatement As String = "Select Count(*) From tbl_category where CategoryName = '" & txtCategoryName.Text.ToString & "'"
            Using cmdV As New MySqlCommand(SQLStatement, cn)
                cn.Open()
                Dim rowCount As Integer = CInt(cmdV.ExecuteScalar())
                cn.Close()
                If rowCount > 0 And Not CategoryForm.getCategoryName = txtCategoryName.Text Then
                    MessageBox.Show("Category name already exists in the database.")
                    Exit Sub
                ElseIf categoryform.getCategoryName = txtCategoryName.Text And CategoryForm.showNoAction = txtCategoryID.Text And CategoryForm.getCategoryStatus = txtCategoryStatus.Text Then
                Else
                    Dim update As String
                    update = "UPDATE tbl_category SET 
                    CategoryName = '" & txtCategoryName.Text.ToString & "',
                    isActive = '" & txtCategoryStatus.Text.ToString & "' 
                    WHERE CategoryID = " & txtCategoryID.Text & ""
                    updates(update)
                    loaddb("Select * FROM tbl_category", CategoryForm.dbCategory)
                    MsgBox("Category has been updated.")
                End If
            End Using
        End Using
    End Sub
End Class