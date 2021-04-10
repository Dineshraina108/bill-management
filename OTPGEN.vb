Imports System.IO.Ports
Imports System.IO
Imports BILL_SYSTEM.SMSCOMMS
Public Class OTPGEN
    Dim letters, sletters, numbers, character, msgtext As String

    Private Sub btnsms_Click(sender As Object, e As EventArgs) Handles btnsms.Click
        'Dim SMSEngine = New SMSCOMMS("COM1")
        'SMSEngine.Open()
        'SMSEngine.SendSMS("txtmobno.Text", msgtext)
        'SMSEngine.Close()
        Dim seport As New System.IO.Ports.SerialPort()
        If seport.IsOpen Then
            seport.Close()
        End If

        seport.PortName = "COM1"
        seport.BaudRate = 9600
        seport.Parity = Parity.None
        seport.StopBits = StopBits.One
        seport.DataBits = 8
        seport.Handshake = Handshake.RequestToSend
        seport.DtrEnable = True
        seport.RtsEnable = True
        seport.NewLine = vbCrLf
        Try
            seport.Open()

        Catch ex As Exception
            MsgBox("sms not send")
        End Try
        If seport.IsOpen Then
            With seport
                .Write("AT" & vbCrLf)
                .Write("AT+CMGF=1" & vbCrLf)
                Threading.Thread.Sleep(10)
                .Write("AT+CMGS=" & Chr(34) & msgtext & Chr(34) & vbCrLf)
                .Write(txtmobno.Text & Chr(26))
                Threading.Thread.Sleep(10)
            End With
            MsgBox("Message sent")
            seport.Close()

        Else
            MsgBox("PORT NOT AVAILABLE")
        End If
    End Sub

    Private Sub btnotp_Click(sender As Object, e As EventArgs) Handles btnotp.Click
        letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        sletters = "abcdefghijklmnopqrstuvwxyz"
        numbers = "1234567890"
        character = numbers
        If Rblet.Checked = True Then
            character += Convert.ToString(letters & sletters)
        End If
        Dim length As Integer = Integer.Parse(Cmbotp.SelectedItem.ToString)
        Dim otp As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim charact As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, character.Length)
                charact = character.ToCharArray()(index).ToString()
            Loop While otp.IndexOf(charact) <> -1
            otp += charact
        Next
        lblotp.Text = otp
        msgtext = "YOUR OTP IS " + otp
    End Sub

    Private Sub Cmbotp_KeyDown(sender As Object, e As KeyEventArgs) Handles Cmbotp.KeyDown
        If e.KeyCode = Keys.Enter Then
            Rblet.Focus()
        End If
    End Sub


End Class
