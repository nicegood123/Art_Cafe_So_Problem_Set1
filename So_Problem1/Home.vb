Public Class Home
    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        End
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Me.Hide()
        CategoryForm.Show()
    End Sub
End Class