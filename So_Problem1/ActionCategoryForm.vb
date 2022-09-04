Public Class ActionCategoryForm
    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Close()

        Dim result As DialogResult

        result = MessageBox.Show("Are you sure, you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim strsucc As String = "Category Name"

            Try
                Dim id = CategoryForm.dbCategory(0, CategoryForm.dbCategory.CurrentRow.Index).Value.ToString

                delete("DELETE FROM tbl_category WHERE CategoryID = " & id & "", strsucc)

            Catch ex As Exception
                MsgBox("Category cannot be deleted. This item is referred to by another object.")

            End Try
            loaddb("Select * FROM tbl_category", CategoryForm.dbCategory)

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Close()
        UpdateCategoryDialog.Show()
    End Sub
End Class