Public Class activities
    Dim aboutmdi As New about
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub aboutbutton_Click(sender As Object, e As EventArgs) Handles aboutbutton.Click
        aboutmdi.MdiParent = Me.ParentForm
        aboutmdi.Show()
        Me.Hide()
    End Sub
End Class