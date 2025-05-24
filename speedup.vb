Imports System.IO

Public Class speedup
    ' Set a variable to store the total time (in seconds) for the quick scan
    Private QuickScanTime As Integer = 90 ' 2 minutes = 120 seconds

    Private WithEvents Timer1 As Timer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Perform the action to delete cache data when Button1 is clicked
        Try
            ' Specify the directory path where the cache data is located
            Dim cacheFolderPath As String = "C:\Users\adity\OneDrive\Desktop\Cache"

            ' Check if the cache folder exists
            If Directory.Exists(cacheFolderPath) Then
                ' Delete all files and subdirectories within the cache folder
                Directory.Delete(cacheFolderPath, True)

                ' Display a message to indicate success
                MsgBox("Cache data deleted successfully.", MsgBoxStyle.Information, "Cache Cleanup")
            Else
                MsgBox("Cache folder does not exist.", MsgBoxStyle.Information, "Cache Cleanup")
            End If
        Catch ex As Exception
            ' Handle any exceptions that may occur during cache data deletion
            MsgBox("An error occurred while deleting cache data: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

        ' Perform the action to run a Quick Scan
        ' Initialize the progress bar for the quick scan
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = QuickScanTime
        ProgressBar1.Value = 0

        ' Set the Timer interval to update the progress every second
        Timer1 = New Timer()
        Timer1.Interval = 90

        ' Start the Timer for the quick scan
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Handle Button2 click action (you can add the desired functionality here)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Check if the quick scan progress has reached the specified time
        If ProgressBar1.Value < QuickScanTime Then
            ProgressBar1.Increment(1)
        Else
            Timer1.Stop()
            MsgBox("Quick Scan Completed Successfully!", MsgBoxStyle.Information, "Quick Scan Completed")
        End If
    End Sub
End Class
