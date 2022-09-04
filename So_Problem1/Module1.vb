Imports MySql.Data.MySqlClient
Module Module1
    Public con As String = "server=localhost;user id=root;Persist Security Info=True;database=db_restaurant_so;Convert Zero Datetime=True"

    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection(con)
    End Function

    Public strcon As MySqlConnection = strstrconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public rd As MySqlDataReader

    Public Sub loaddb(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
        da.Dispose()
    End Sub

    Public Sub loadcb(ByVal sql As String, ByVal DTG As ComboBox)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DTG.DataSource = dt
                DTG.DisplayMember = "CategoryName"
                DTG.ValueMember = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
        da.Dispose()
    End Sub

    Public Sub loadtxt(ByVal sql As String, ByRef strg As String)
        Try
            strcon.Open()
            cmd.CommandText = sql
            cmd.Connection = strcon
            rd = cmd.ExecuteReader

            If rd.Read Then
                strg = rd.GetString(0)
            End If
            rd.Close()
            strcon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub

    Public Sub delete(ByVal sql As String, ByVal strsucc As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                MsgBox(strsucc + " has been deleted.")
            End With
        Catch ex As Exception
            MsgBox("Cannot be deleted. This item is referred to by another object.")
        End Try
        strcon.Close()
    End Sub
End Module
