Public Class frmClickSpeedTest
    Dim intClicks As Integer
    Dim X As Integer
    Private Sub cmdClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClick.Click
        intClicks += 1
        lblClicks.Text = intClicks
        lblClicks.Visible = True
        lblClicksLabel.Visible = True
        lblTimer.Visible = True
        lblTimerLabel.Visible = True
        If intClicks >= 1 Then
            tmrMain.Enabled = True
        End If
    End Sub
    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        X += 1
        lblTimer.Text = X
        If X = 10 Then
            lblClicksPerSecond.Visible = True
            lblClicksPerSecondLabel.Visible = True
            cmdClick.Enabled = False
            cmdClick.Text = intClicks
            lblClicksPerSecond.Text = intClicks / 10
            tmrMain.Enabled = False
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        lblClicks.Visible = False
        lblClicksLabel.Visible = False
        lblTimer.Visible = False
        lblTimerLabel.Visible = False
        lblClicksPerSecond.Visible = False
        lblClicksPerSecondLabel.Visible = False
        cmdClick.Enabled = True
        intClicks = 0
        X = 0
        cmdClick.Text = "CLICK ME!!!!"
    End Sub
End Class
