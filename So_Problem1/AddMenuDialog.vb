Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddMenuDialog
    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMenuName.Text = "" Or txtMenuDescription.Text = "" Or txtMenuPrice.Text = "" Or cbxCategory.Text = "" Then
            MsgBox("All fields are required. Please ensure all fields are completed.")
            txtMenuID.Text = ""
            txtMenuName.Text = ""
            txtMenuDescription.Text = ""
            txtMenuPrice.Text = ""
            cbxCategory.Text = ""
        Else
            Using cn As New MySqlConnection(con)
                Dim SQLStatement As String = "Select Count(*) From tbl_menu where MenuName = '" & txtMenuName.Text.ToString & "'"
                Using cmdV As New MySqlCommand(SQLStatement, cn)
                    cn.Open()
                    Dim rowCount As Integer = CInt(cmdV.ExecuteScalar())
                    cn.Close()
                    If rowCount > 0 Then
                        MessageBox.Show("Menu name already exists in the database.")
                        txtMenuID.Text = ""
                        txtMenuName.Text = ""
                        txtMenuDescription.Text = ""
                        txtMenuPrice.Text = ""
                        cbxCategory.Text = ""
                        Exit Sub
                    Else
                        Dim insertdata As String
                        insertdata = "INSERT INTO tbl_menu(MenuName,MenuDescription,MenuPrice,CategoryID,IsActive) VALUES (
                        '" & txtMenuName.Text.ToString & "',
                        '" & txtMenuDescription.Text.ToString & "',
                        " & txtMenuPrice.Text.ToString & ",
                        " & cbxCategory.SelectedIndex + 1 & ",
                        '" & txtMenuStatus.Text.ToString & "')"
                        create(insertdata)
                        loaddb("Select * FROM tbl_menu", MenuForm.dbMenu)
                        MsgBox("New menu has been added.")
                        txtMenuID.Text = ""
                        txtMenuName.Text = ""
                        txtMenuDescription.Text = ""
                        txtMenuPrice.Text = ""
                        cbxCategory.Text = ""
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub AddMenuDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcb("SELECT CategoryName FROM tbl_category", cbxCategory)
    End Sub

    Private Sub txtMenuPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMenuPrice.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class