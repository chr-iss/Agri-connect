Imports System.Data.OleDb




Public Class RegisterPage


    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\Documents\mawaza\Database11.mdb"
    Dim connection As OleDbConnection = New OleDbConnection(conString)


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtName.Text.Trim = "" Then
            MsgBox("Please enter your name")
            txtName.Focus()
            Exit Sub
        End If

        If isAlpha(txtName.Text) = False Then
            MsgBox("name should be alphabetic only")
            txtName.Focus()
            Exit Sub
        End If

        If txtEmail.Text.Trim = "" Then
            MsgBox("Please enter your email address")
            txtEmail.Focus()
            Exit Sub
        End If

        If txtCellphone.Text.Trim = "" Then
            MsgBox("Please enter your cell number")
            txtCellphone.Focus()
            Exit Sub
        End If

        If txtCellphone.Text.Length <> 10 Then
            MsgBox("Cell number should have 10 digits")
            txtCellphone.Focus()
            Exit Sub
        End If

        If txtCellphone.Text.StartsWith(0) = False Then
            MsgBox("Cell number should start with 0")
            txtCellphone.Focus()
            Exit Sub
        End If

        If txtAddress1.Text.Trim = "" Then
            MsgBox("Please enter your address")
            txtAddress1.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim = "" Then
            MsgBox("Please enter a password")
            txtPassword.Focus()
            Exit Sub
        End If

        If txtConfirm.Text.Trim = "" Then
            MsgBox("Please confirm password")
            txtConfirm.Focus()
            Exit Sub
        End If

        If txtConfirm.Text <> txtPassword.Text Then
            MsgBox("Passwords do not match")
            txtConfirm.Focus()
            Exit Sub
        End If





        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim cellphone As String = txtCellphone.Text

        If String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(cellphone) Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        Try

            connection.Open()


            Dim query As String = "INSERT INTO Users (Name, Email, Password, CellPhone) VALUES (@Name, @Email, @Password, @CellPhone)"
            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)


            cmd.Parameters.AddWithValue("@Name", name)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Password", password)
            cmd.Parameters.AddWithValue("@CellPhone", cellphone)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Registration Successful!")


            txtName.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
            txtCellphone.Clear()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            connection.Close()
        End Try



        Me.Hide()
        Form1.Show()


    End Sub

    Public Function isAlpha(textbox As String) As Boolean
        For i = 0 To textbox.Length - 1
            Select Case textbox.Substring(i, 1)
                Case "a" To "z", "A" To "Z", " "
                Case Else
                    Return False
            End Select
        Next
        Return True
    End Function

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class