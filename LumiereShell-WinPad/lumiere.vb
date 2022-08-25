
Public Class lumiere
    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200
    Dim activitiesmdi = New activities
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripLabel1.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
                ctl.Dock = DockStyle.Fill
            End If
        Next ctl
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                c.BackColor = Me.BackColor
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next
        'find the mdiClient in the controls collection
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                'got the control, so cast it
                Dim mdiClientControl As MdiClient = DirectCast(ctl, MdiClient)
                'undock it
                mdiClientControl.Dock = DockStyle.None
                'resize it
                mdiClientControl.Bounds = Me.ClientRectangle
                mdiClientControl.Height += 20
                mdiClientControl.Width += 20
                'set the anchors
                mdiClientControl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top

                'bail out
                Exit For
            End If
        Next
    End Sub
    Dim clickcount = 0
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        activitiesmdi.MdiParent = Me
        If Not activitiesmdi.Visible Then
            activitiesmdi.Show()
        Else
            activitiesmdi.Hide()
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class
