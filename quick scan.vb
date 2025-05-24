Public Class quick_scan
    ' Set a variable to store the total time (in seconds) for the scan
    Private TotalScanTime As Integer = 90 ' 5 minutes = 300 seconds

    Private Sub quick_scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 507, Screen.PrimaryScreen.WorkingArea.Height - 209)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Initialize the progress bars
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = TotalScanTime
        ProgressBar1.Value = 0

        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = TotalScanTime
        ProgressBar2.Value = 0

        ' Set the Timer interval to update the progress every second
        Timer1.Interval = 100

        ' Start the Timer
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Check if the progress has reached the estimated time (5 minutes)
        If ProgressBar1.Value < TotalScanTime Then
            ProgressBar1.Increment(1)
            ProgressBar2.Increment(1)
        Else
            Timer1.Stop()
            MsgBox("Scan Completed Successfully!", MsgBoxStyle.Information, "Completed")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Initialize the progress bars
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = TotalScanTime
        ProgressBar1.Value = 0

        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = TotalScanTime
        ProgressBar2.Value = 0

        ' Set the Timer interval to update the progress every second
        Timer1.Interval = 100

        ' Start the Timer
        Timer1.Start()
    End Sub
End Class
