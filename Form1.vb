
Public Class Form1

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close1.Visible = True
        Close1.BringToFront()
    End Sub

    Private Sub btnFull_Check_Click(sender As Object, e As EventArgs) Handles btnFull_Check.Click
        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Full_check1.BringToFront()
            btnFull_Check.BackColor = Color.White
            btnFull_Check.ForeColor = Color.Black
            btnVirusScan.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Full_check1.BringToFront()
                btnFull_Check.BackColor = Color.Black
                btnFull_Check.ForeColor = Color.White
                btnVirusScan.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Full_check1.BringToFront()
                    btnFull_Check.BackColor = Color.Red
                    btnFull_Check.ForeColor = Color.White
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If
    End Sub

    Private Sub btnVirusScan_Click(sender As Object, e As EventArgs) Handles btnVirusScan.Click


        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Scan1.BringToFront()
            btnVirusScan.BackColor = Color.White
            btnVirusScan.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Scan1.BringToFront()
                btnVirusScan.BackColor = Color.Black
                btnVirusScan.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Scan1.BringToFront()
                    btnVirusScan.BackColor = Color.Red
                    btnVirusScan.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If

    End Sub

    Private Sub btnSpeedUp_Click(sender As Object, e As EventArgs) Handles btnSpeedUp.Click



        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Speedup1.BringToFront()
            btnSpeedUp.BackColor = Color.White
            btnSpeedUp.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnVirusScan.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Speedup1.BringToFront()
                btnSpeedUp.BackColor = Color.Black
                btnSpeedUp.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnVirusScan.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Speedup1.BringToFront()
                    btnSpeedUp.BackColor = Color.Red
                    btnSpeedUp.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If


    End Sub

    Private Sub btnCleanUp_Click(sender As Object, e As EventArgs) Handles btnCleanUp.Click





        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Cleanup1.BringToFront()
            btnCleanUp.BackColor = Color.White
            btnCleanUp.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnVirusScan.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnToolBox.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Cleanup1.BringToFront()
                btnCleanUp.BackColor = Color.Black
                btnCleanUp.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnVirusScan.BackColor = Color.DarkBlue
                btnToolBox.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Cleanup1.BringToFront()
                    btnCleanUp.BackColor = Color.Red
                    btnCleanUp.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnToolBox.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                End If
            End If
        End If



    End Sub

    Private Sub btnToolBox_Click(sender As Object, e As EventArgs) Handles btnToolBox.Click
    


        If Settings1.cmbThemes.Text = "Dark Theme" Then

            Settings1.BringToFront()

            btnToolBox.BackColor = Color.White
            btnToolBox.ForeColor = Color.Black
            btnFull_Check.BackColor = Color.DarkBlue
            btnVirusScan.BackColor = Color.DarkBlue
            btnSpeedUp.BackColor = Color.DarkBlue
            btnCleanUp.BackColor = Color.DarkBlue
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then

                Settings1.BringToFront()
                btnToolBox.BackColor = Color.Black
                btnToolBox.ForeColor = Color.White
                btnFull_Check.BackColor = Color.DarkBlue
                btnVirusScan.BackColor = Color.DarkBlue
                btnCleanUp.BackColor = Color.DarkBlue
                btnSpeedUp.BackColor = Color.DarkBlue
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then

                    Settings1.BringToFront()

                    btnToolBox.BackColor = Color.Red
                    btnToolBox.ForeColor = Color.White
                    btnFull_Check.BackColor = Color.DarkBlue
                    btnVirusScan.BackColor = Color.DarkBlue
                    btnSpeedUp.BackColor = Color.DarkBlue
                    btnCleanUp.BackColor = Color.DarkBlue
                End If
            End If
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Settings1.cmbThemes.Text = "Default Theme"
        Full_check1.computerName.Text = My.Computer.Name
        Full_check1.ComputerVersion.Text = My.Computer.Info.OSFullName
        Full_check1.OSPlatform.Text = My.Computer.Info.OSPlatform
        Full_check1.userName.Text = SystemInformation.UserName
    End Sub

    Private Sub btnQuickScan_Click(sender As Object, e As EventArgs) Handles btnQuickScan.Click
        Me.Hide()
        quick_scan.Show()

    End Sub

    Private Sub btnTimer_Tick(sender As Object, e As EventArgs) Handles btnTimer.Tick

        


    End Sub

    Private Sub Close1_Load(sender As Object, e As EventArgs) Handles Close1.Load

    End Sub
End Class
