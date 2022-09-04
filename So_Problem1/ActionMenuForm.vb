Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ActionMenuForm

    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateMenuDialog.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Close()

        Dim result As DialogResult

        result = MessageBox.Show("Are you sure, you want to delete this menu?", "Confirm Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim strsucc As String = "Menu"
            Try
                Dim id = MenuForm.dbMenu(0, MenuForm.dbMenu.CurrentRow.Index).Value.ToString

                delete("DELETE FROM tbl_menu WHERE MenuID = " & id & "", strsucc)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            loaddb("Select * FROM tbl_menu", MenuForm.dbMenu)
        End If
    End Sub

End Class