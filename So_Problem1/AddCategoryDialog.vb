Imports MySql.Data.MySqlClient

Public Class AddCategoryDialog
    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCategoryName.Text = "" Or txtCategoryStatus.Text = "" Then
            MsgBox("All fields are required. Please ensure all fields are completed.")
            txtCategoryID.Text = ""
            txtCategoryName.Text = ""
        Else
            Using cn As New MySqlConnection(con)
                Dim SQLStatement As String = "Select Count(*) From tbl_category where CategoryName = '" & txtCategoryName.Text.ToString & "'"
                Using cmdV As New MySqlCommand(SQLStatement, cn)
                    cn.Open()
                    Dim rowCount As Integer = CInt(cmdV.ExecuteScalar())
                    cn.Close()
                    If rowCount > 0 Then
                        MessageBox.Show("Category name already exists in the database.")
                        txtCategoryID.Text = ""
                        txtCategoryName.Text = ""
                        Exit Sub
                    Else
                        Dim insert As String
                        insert = "INSERT INTO tbl_category(CategoryName,isActive) VALUES (
                        '" & txtCategoryName.Text.ToString & "',
                        '" & txtCategoryStatus.Text.ToString & "')"
                        create(insert)
                        loaddb("Select * FROM tbl_category", CategoryForm.dbCategory)
                        MsgBox("New menu category has been added.")
                        txtCategoryID.Text = ""
                        txtCategoryName.Text = ""
                    End If
                End Using
            End Using
        End If
    End Sub
End Class