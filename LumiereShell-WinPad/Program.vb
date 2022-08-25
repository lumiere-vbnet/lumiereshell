NotInheritable Class Program
    Private Sub New()
    End Sub

    <STAThread>
    Friend Shared Sub Main()
        SetProcessDPIAware()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New lumiere()) '<-- Change to Form1 for example.
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SetProcessDPIAware() As Boolean
    End Function
End Class