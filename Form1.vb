Imports SoloMotorControllers
Imports System.Configuration
Imports System.IO
Imports System.IO.Ports
Public Class Form1

    Dim mySolo As SOLOMotorControllersSerial

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            mySolo = New SOLOMotorControllersSerial(cmbComPort.Text,
                                                0,
                                                ISOLOMotorControllers.UartBaudrate.rate115200,
                                                200,
                                                3,
                                                False)
            If mySolo.Connect() > 0 Then
                Return
            End If
            Threading.Thread.Sleep(50)
            If mySolo.CommunicationIsWorking() = 0 Then
                btnConnect.Text = "Connected!!!"
                btnConnect.BackColor = Color.Green
                grbSettings.Enabled = True
            End If
        Else
            mySolo.Disconnect()
            btnConnect.Text = "Connect"
            btnConnect.BackColor = Color.White
            grbSettings.Enabled = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
        grbSettings.Enabled = False
    End Sub

    Private Sub GetSerialPortNames()
        Dim ports() As String
        ports = SerialPort.GetPortNames()
        cmbComPort.Items.Clear()
        ' Show all available COM ports.
        For Each sp As String In ports
            cmbComPort.Items.Add(sp)
        Next
        If cmbComPort.Items.Count > 0 Then
            cmbComPort.SelectedIndex = 0
        End If

        cmbBaudRate.SelectedIndex = 0
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        GetSerialPortNames()
    End Sub

    Private Sub btnSetCurrentLimit_Click(sender As Object, e As EventArgs) Handles btnSetCurrentLimit.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        If txtCurrentLimit.Text = "" Then
            Return
        End If
        mySolo.SetCurrentLimit(Single.Parse(txtCurrentLimit.Text))
    End Sub

    Private Sub btnSetCommandMode_Click(sender As Object, e As EventArgs) Handles btnSetCommandMode.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        Dim mode As ISOLOMotorControllers.CommandMode
        If txtCommandMode.Text = "" Then
            Return
        End If
        mode = Long.Parse(txtCommandMode.Text)
        mySolo.SetCommandMode(mode)
    End Sub

    Private Sub btnSetTorqueReferenceIq_Click(sender As Object, e As EventArgs)
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        If txtTorqueReferenceIq.Text = "" Then
            Return
        End If
        mySolo.SetTorqueReferenceIq(Single.Parse(txtTorqueReferenceIq.Text))
    End Sub

    Private Sub btnSetSpeedReference_Click(sender As Object, e As EventArgs) Handles btnSetSpeedReference.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        If txtSpeedReference.Text = "" Then
            Return
        End If
        mySolo.SetSpeedReference(Single.Parse(txtSpeedReference.Text))
    End Sub

    Private Sub btnSetPositionReference_Click(sender As Object, e As EventArgs) Handles btnSetPositionReference.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        If txtPositionReference.Text = "" Then
            Return
        End If
        mySolo.SetPositionReference(Single.Parse(txtPositionReference.Text))
    End Sub

    Private Sub btnReadCurrentLimit_Click(sender As Object, e As EventArgs) Handles btnReadCurrentLimit.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        Dim value As Single
        txtCurrentLimit.Text = ""
        [error] = mySolo.GetCurrentLimit(value)
        If [error] = 0 Then
            txtCurrentLimit.Text = value.ToString()
        End If
        lblErrorCode.Text = [error].ToString
    End Sub

    Private Sub btnReadCommandMode_Click(sender As Object, e As EventArgs) Handles btnReadCommandMode.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        Dim value As Long
        txtCommandMode.Text = ""
        [error] = mySolo.GetCommandMode(value)
        If Not [error] Then
            txtCommandMode.Text = value.ToString()
        End If
        lblErrorCode.Text = [error].ToString
    End Sub

    Private Sub btnReadTorqueReferenceIq_Click(sender As Object, e As EventArgs) Handles btnReadTorqueReferenceIq.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        Dim value As Single
        txtTorqueReferenceIq.Text = ""
        [error] = mySolo.GetTorqueReferenceIq(value)
        If [error] = 0 Then
            txtTorqueReferenceIq.Text = value.ToString()
        End If
        lblErrorCode.Text = [error].ToString
    End Sub

    Private Sub btnReadSpeedReference_Click(sender As Object, e As EventArgs) Handles btnReadSpeedReference.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        Dim value As Single
        txtSpeedReference.Text = ""
        [error] = mySolo.GetSpeedReference(value)
        If [error] = 0 Then
            txtSpeedReference.Text = value.ToString()
        End If
        lblErrorCode.Text = [error].ToString
    End Sub

    Private Sub btnReadPositionReference_Click(sender As Object, e As EventArgs) Handles btnReadPositionReference.Click
        Dim [error] As ISOLOMotorControllers.SoloErrorCode
        Dim value As Single
        txtPositionReference.Text = ""
        [error] = mySolo.GetPositionReference(value)
        If [error] = 0 Then
            txtPositionReference.Text = value.ToString
        End If
        lblErrorCode.Text = [error].ToString
    End Sub

End Class
