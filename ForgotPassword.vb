Imports System.Data.OleDb

Public Class ForgotPassword
    Dim con As New OleDbConnection

    Function updatepass(email As String, password As String) As Boolean
        Dim returnv As Boolean
        Dim cmd As OleDbCommand
        Dim sql As String
        Try
            sql = "update registration where  password='" + password + "' email='" + email + "' "
            cmd = New OleDbCommand(sql, con)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            returnv = True
            cmd.Connection.Close()
        Catch ex As Exception
            returnv = False
        End Try
        Return returnv
    End Function


    Function getcon() As Boolean
        Dim returnv As Boolean
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\Documents\mawaza\Database11.mdb"
            returnv = True
        Catch ex As Exception
            returnv = False
        End Try
        Return returnv
    End Function




    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtEmail.Text.Trim = "" Then
            MsgBox("Please enter your email")
            txtEmail.Focus()
            Exit Sub
        End If

        If txtNewPass.Text.Trim = "" Then
            MsgBox("Please enter your new password")
            txtNewPass.Focus()
            Exit Sub
        End If

        If txtConfirm.Text.Trim = "" Then
            MsgBox("Please confirm password")
            txtConfirm.Focus()
            Exit Sub
        End If

        If txtConfirm.Text <> txtNewPass.Text Then
            MsgBox("Passwords do not match")
            txtConfirm.Focus()
            Exit Sub
        End If




        If getcon() = True Then
            If updatepass(txtEmail.Text, txtNewPass.Text) = True Then
                Me.Hide()
                Form1.Show()
            Else
                MsgBox("invalid")
            End If
        Else
            MsgBox("database closed")

        End If



    End Sub


End Class