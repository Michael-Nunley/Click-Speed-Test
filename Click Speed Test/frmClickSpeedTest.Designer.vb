<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClickSpeedTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblClicksLabel = New System.Windows.Forms.Label()
        Me.lblClicks = New System.Windows.Forms.Label()
        Me.lblClicksPerSecondLabel = New System.Windows.Forms.Label()
        Me.lblClicksPerSecond = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblTimerLabel = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdClick
        '
        Me.cmdClick.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClick.Location = New System.Drawing.Point(12, 72)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(260, 178)
        Me.cmdClick.TabIndex = 0
        Me.cmdClick.Text = "CLICK ME!!!!"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 1000
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(240, 13)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "You have 10 seconds to click as fast as you can."
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(12, 297)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(260, 35)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblClicksLabel
        '
        Me.lblClicksLabel.AutoSize = True
        Me.lblClicksLabel.Location = New System.Drawing.Point(56, 32)
        Me.lblClicksLabel.Name = "lblClicksLabel"
        Me.lblClicksLabel.Size = New System.Drawing.Size(35, 13)
        Me.lblClicksLabel.TabIndex = 3
        Me.lblClicksLabel.Text = "Clicks"
        Me.lblClicksLabel.Visible = False
        '
        'lblClicks
        '
        Me.lblClicks.AutoSize = True
        Me.lblClicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblClicks.Location = New System.Drawing.Point(9, 32)
        Me.lblClicks.Name = "lblClicks"
        Me.lblClicks.Size = New System.Drawing.Size(49, 13)
        Me.lblClicks.TabIndex = 4
        Me.lblClicks.Text = "[Clicks]"
        Me.lblClicks.Visible = False
        '
        'lblClicksPerSecondLabel
        '
        Me.lblClicksPerSecondLabel.AutoSize = True
        Me.lblClicksPerSecondLabel.Location = New System.Drawing.Point(125, 32)
        Me.lblClicksPerSecondLabel.Name = "lblClicksPerSecondLabel"
        Me.lblClicksPerSecondLabel.Size = New System.Drawing.Size(94, 13)
        Me.lblClicksPerSecondLabel.TabIndex = 5
        Me.lblClicksPerSecondLabel.Text = "Clicks Per Second"
        Me.lblClicksPerSecondLabel.Visible = False
        '
        'lblClicksPerSecond
        '
        Me.lblClicksPerSecond.AutoSize = True
        Me.lblClicksPerSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicksPerSecond.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClicksPerSecond.Location = New System.Drawing.Point(225, 32)
        Me.lblClicksPerSecond.Name = "lblClicksPerSecond"
        Me.lblClicksPerSecond.Size = New System.Drawing.Size(39, 13)
        Me.lblClicksPerSecond.TabIndex = 6
        Me.lblClicksPerSecond.Text = "[CPS]"
        Me.lblClicksPerSecond.Visible = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Blue
        Me.lblTimer.Location = New System.Drawing.Point(225, 56)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(14, 13)
        Me.lblTimer.TabIndex = 7
        Me.lblTimer.Text = "0"
        Me.lblTimer.Visible = False
        '
        'lblTimerLabel
        '
        Me.lblTimerLabel.AutoSize = True
        Me.lblTimerLabel.Location = New System.Drawing.Point(186, 56)
        Me.lblTimerLabel.Name = "lblTimerLabel"
        Me.lblTimerLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblTimerLabel.TabIndex = 8
        Me.lblTimerLabel.Text = "Timer:"
        Me.lblTimerLabel.Visible = False
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(12, 256)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(260, 35)
        Me.cmdReset.TabIndex = 9
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'frmClickSpeedTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 342)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.lblTimerLabel)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblClicksPerSecond)
        Me.Controls.Add(Me.lblClicksPerSecondLabel)
        Me.Controls.Add(Me.lblClicks)
        Me.Controls.Add(Me.lblClicksLabel)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.cmdClick)
        Me.Name = "frmClickSpeedTest"
        Me.Text = "Click! Click! Click! Click! Click! "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClick As System.Windows.Forms.Button
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblClicksLabel As System.Windows.Forms.Label
    Friend WithEvents lblClicks As System.Windows.Forms.Label
    Friend WithEvents lblClicksPerSecondLabel As System.Windows.Forms.Label
    Friend WithEvents lblClicksPerSecond As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblTimerLabel As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button

End Class
