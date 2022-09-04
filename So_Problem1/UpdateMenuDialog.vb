Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class UpdateMenuDialog
    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
        ActionMenuForm.Close()
    End Sub

    Private Sub UpdateMenuDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcb("SELECT CategoryName FROM tbl_category", cbxCategory)

        Dim currRow As Integer = MenuForm.dbMenu.CurrentRow.Index
        Debug.Print(currRow.ToString)
        txtMenuID.Text = MenuForm.dbMenu(0, currRow).Value.ToString
        txtMenuName.Text = MenuForm.dbMenu(1, currRow).Value.ToString
        txtMenuDescription.Text = MenuForm.dbMenu(2, currRow).Value.ToString
        txtMenuPrice.Text = MenuForm.dbMenu(3, currRow).Value.ToString
        cbxCategory.SelectedIndex = MenuForm.dbMenu(4, currRow).Value
        txtMenuStatus.Text = MenuForm.dbMenu(5, currRow).Value.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        loadtxt("SELECT MenuName FROM tbl_menu WHERE MenuID = " & txtMenuID.Text & "", MenuForm.getMenuName)
        loadtxt("SELECT MenuDescription FROM tbl_menu WHERE MenuID = " & txtMenuID.Text & "", MenuForm.getMenuDescription)
        loadtxt("SELECT MenuPrice FROM tbl_menu WHERE MenuID = " & txtMenuID.Text & "", MenuForm.getMenuPrice)
        loadtxt("SELECT MenuID FROM tbl_menu WHERE MenuID = " & txtMenuID.Text & "", MenuForm.showNoAction)
        loadtxt("SELECT isActive FROM tbl_menu WHERE MenuID = " & txtMenuID.Text & "", MenuForm.getMenuStatus)

        Using cn As New MySqlConnection(con)
            Dim SQLStatement As String = "Select Count(*) From tbl_menu where MenuName = '" & txtMenuName.Text.ToString & "'"
            Using cmdV As New MySqlCommand(SQLStatement, cn)
                cn.Open()
                Dim rowCount As Integer = CInt(cmdV.ExecuteScalar())
                cn.Close()
                If rowCount > 0 And Not MenuForm.getMenuName = txtMenuName.Text Then
                    MessageBox.Show("Menu already exists in the database.")
                    Exit Sub
                ElseIf MenuForm.getMenuName = txtMenuName.Text And MenuForm.getMenuDescription = txtMenuDescription.Text And MenuForm.getMenuPrice = txtMenuPrice.Text And MenuForm.showNoAction = txtMenuID.Text And MenuForm.getMenuStatus = txtMenuStatus.Text Then
                Else
                    Dim updatedata As String
                    updatedata = "UPDATE tbl_menu SET 
                    MenuName = '" & txtMenuName.Text.ToString & "',
                    MenuDescription = '" & txtMenuDescription.Text.ToString & "',
                    MenuPrice = '" & txtMenuPrice.Text.ToString & "',
                    CategoryID = " & cbxCategory.SelectedIndex + 1 & ",
                    isActive = '" & txtMenuStatus.Text.ToString & "' 
                    WHERE MenuID = " & txtMenuID.Text & ""
                    updates(updatedata)
                    loaddb("Select * FROM tbl_menu", MenuForm.dbMenu)
                    MsgBox("Menu has been updated")
                    txtMenuID.Text = ""
                    txtMenuName.Text = ""
                    txtMenuDescription.Text = ""
                    txtMenuPrice.Text = ""
                    cbxCategory.Text = ""
                End If
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        ActionMenuForm.Close()
    End Sub
End Class