Imports System.IO
Imports System.Net.Sockets

Public Class Form3
    Dim Client As TcpClient
    Dim RX As StreamReader
    Dim TX As StreamWriter
    Dim dice As Integer
    Dim Random As Random
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicBox_Axe.Hide()
        PicBox_Gun.Hide()
        PicBox_Machete.Hide()
        PicBox_spear.Hide()
        PicBox_sword.Hide()
        PictBox_chako.Hide()

        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Try
            '   REM IP, Port
            '  REM If port is in a textbox, use: integer.parse(textbox1.text)  instead of the port number vvv
            '10.0.0.12
            Client = New TcpClient("127.0.0.1", 4305)
            If Client.GetStream.CanRead = True Then
                RX = New StreamReader(Client.GetStream)
                TX = New StreamWriter(Client.GetStream)
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Connected)
            End If
        Catch ex As Exception
            RichTextBox1.Text += "Failed to connect, E: " + ex.Message + vbNewLine

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Client.Close()
            RichTextBox1.Text += "Connection Ended" + vbNewLine
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim textbox1 As New TextBox
            Random = New Random
            ProgressBar1.Increment(5)

            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                If dice = 1 Then
                    If ProgressBar2.Value <= 5 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")

                    Else
                        textbox1.Text = "Oppoonent used a Sword!!!  Damage -5"
                        PicBox_sword.Visible = True
                        Timer3.Interval = 1000
                        Timer3.Start()
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        ProgressBar2.Value = ProgressBar2.Value - 5

                    End If
                End If
                If dice = 2 Then
                    If ProgressBar2.Value <= 15 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent Punch You!!!  Damage -15"
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        ProgressBar2.Value = ProgressBar2.Value - 10

                    End If
                End If
                If dice = 3 Then
                    If ProgressBar2.Value <= 25 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent used an Axe!!!  Damage -25"
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        ProgressBar2.Value = ProgressBar2.Value - 15


                    End If
                End If
                If dice = 4 Then
                    If ProgressBar2.Value <= 35 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else textbox1.Text = "Opponent used a Sword!!!  Damage -35"
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        ProgressBar2.Value = ProgressBar2.Value - 20

                    End If
                End If
                If dice = 5 Then
                    If ProgressBar2.Value <= 25 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent used Machine Gun!!!  Damage -45"
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        ProgressBar2.Value = ProgressBar2.Value - 25

                    End If
                End If
                If dice = 6 Then
                    If ProgressBar2.Value <= 55 Then
                        ProgressBar2.Value = ProgressBar2.Value = 0
                        MsgBox("You win!")
                    Else
                        textbox1.Text = "Opponent Spear!!!!  Damage -55"
                        PicBox_spear.Visible = True
                        Timer2.Interval = 1000
                        Timer2.Start()
                        SendToServer(textbox1.Text)
                        textbox1.Clear()
                        ProgressBar2.Value = ProgressBar2.Value - 30

                    End If
                End If
                ProgressBar1.Value = 0
            Else

                dice = Random.Next(1, 6)
                Select Case (dice)
                    Case 1 : randompic.Image = My.Resources.SwordR
                    Case 2 : randompic.Image = My.Resources.RAXE
                    Case 3 : randompic.Image = My.Resources.RGUN
                    Case 4 : randompic.Image = My.Resources.RMachete
                    Case 5 : randompic.Image = My.Resources.RNunchucks
                    Case 6 : randompic.Image = My.Resources.RSpear
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Connected()
        REM Has connected to server and now listening for data from the server
        If RX.BaseStream.CanRead = True Then
            Try
                While RX.BaseStream.CanRead = True
                    Dim RawData As String = RX.ReadLine
                    If RawData.ToUpper = "/MSG" Then
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf MSG1, "Hello World.")
                    Else
                        RichTextBox1.Text += "Player2>>" + RawData + vbNewLine
                        ' PictureBox1.Hide()
                    End If
                End While
            Catch ex As Exception
                Client.Close()
                ' RichTextBox1.Text += "Disconnected" + vbNewLine
            End Try
        End If
        Return True
    End Function

    Private Sub Btn_dice_Click(sender As Object, e As EventArgs) Handles Btn_dice.Click
        Timer1.Start()
        ' If TextBox1.Text.Length > 0 Then
        'SendToServer(TextBox1.Text)
        'TextBox1.Clear()
        'End If
    End Sub
    Function MSG1(ByVal Data As String)
        REM Creates a messageBox for new threads to stop freezing
        MsgBox(Data)
        Return True
    End Function
    Function SendToServer(ByVal Data As String)
        REM Send a message to the server
        Try
            TX.WriteLine(Data)
            TX.Flush()
        Catch ex As Exception

        End Try
        Return True
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PicBox_spear.Visible = False
        Timer2.Interval = 1000
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PicBox_sword.Visible = False
        Timer3.Interval = 1000
        Timer3.Stop()
    End Sub
End Class