Imports System.Data.OleDb

Public Class Form1
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\Documents\mawaza\Database11.mdb"
    Dim connection As OleDbConnection = New OleDbConnection(conString)


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click


        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text


        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both Username And Password")
            Exit Sub
        End If

        Try

            connection.Open()


            Dim query As String = "Select COUNT(*) FROM Users WHERE Username = @Username And Password = @Password"
            Dim cmd As OleDbCommand = New OleDbCommand(query, connection)


            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)


            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login Successful!")

            Else
                MessageBox.Show("Invalid Username Or Password!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            connection.Close()
        End Try


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        RegisterPage.Show()
    End Sub




End Class
