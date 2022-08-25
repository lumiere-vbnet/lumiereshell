Public Class settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lumiere.ToolStrip1.Dock = DockStyle.Top
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lumiere.ToolStrip1.Dock = DockStyle.Left
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lumiere.ToolStrip1.Dock = DockStyle.Bottom
    End Sub
End Class