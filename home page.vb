Public Class home_page
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click

        MsgBox("Are you sure you want to log out")

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnHire_Click(sender As Object, e As EventArgs) Handles btnHire.Click
        Me.Hide()
        hirePage.Show()
    End Sub

    Private Sub btnEducation_Click(sender As Object, e As EventArgs) Handles btnEducation.Click
        Me.Hide()
        education.Show()
    End Sub

    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnMarketing.Click
        Me.Hide()
        marketing.Show()
    End Sub

    Private Sub btnWhyUs_Click(sender As Object, e As EventArgs) Handles btnWhyUs.Click
        Me.Hide()
        FAQ.Show()
    End Sub
End Class