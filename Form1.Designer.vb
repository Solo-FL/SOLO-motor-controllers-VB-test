<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmbComPort = New ComboBox()
        btnConnect = New Button()
        btnScan = New Button()
        cmbBaudRate = New ComboBox()
        Label1 = New Label()
        txtCurrentLimit = New TextBox()
        btnSetCurrentLimit = New Button()
        btnReadCurrentLimit = New Button()
        btnReadCommandMode = New Button()
        btnSetCommandMode = New Button()
        txtCommandMode = New TextBox()
        Label2 = New Label()
        btnReadTorqueReferenceIq = New Button()
        btnTorqueReferenceIq = New Button()
        txtTorqueReferenceIq = New TextBox()
        Label3 = New Label()
        btnReadSpeedReference = New Button()
        btnSetSpeedReference = New Button()
        txtSpeedReference = New TextBox()
        Label4 = New Label()
        btnReadPositionReference = New Button()
        btnSetPositionReference = New Button()
        txtPositionReference = New TextBox()
        Label5 = New Label()
        grbSettings = New GroupBox()
        Label6 = New Label()
        lblErrorCode = New Label()
        grbSettings.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbComPort
        ' 
        cmbComPort.DropDownStyle = ComboBoxStyle.DropDownList
        cmbComPort.FormattingEnabled = True
        cmbComPort.Location = New Point(141, 41)
        cmbComPort.Name = "cmbComPort"
        cmbComPort.Size = New Size(100, 23)
        cmbComPort.TabIndex = 2
        ' 
        ' btnConnect
        ' 
        btnConnect.Location = New Point(366, 40)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(89, 23)
        btnConnect.TabIndex = 1
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' btnScan
        ' 
        btnScan.Location = New Point(89, 41)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(46, 23)
        btnScan.TabIndex = 3
        btnScan.Text = "Scan"
        btnScan.UseVisualStyleBackColor = True
        ' 
        ' cmbBaudRate
        ' 
        cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBaudRate.FormattingEnabled = True
        cmbBaudRate.Items.AddRange(New Object() {"115200", "937500"})
        cmbBaudRate.Location = New Point(247, 41)
        cmbBaudRate.Name = "cmbBaudRate"
        cmbBaudRate.Size = New Size(97, 23)
        cmbBaudRate.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 4
        Label1.Text = "Current Limit:"
        ' 
        ' txtCurrentLimit
        ' 
        txtCurrentLimit.Location = New Point(166, 25)
        txtCurrentLimit.Name = "txtCurrentLimit"
        txtCurrentLimit.Size = New Size(50, 23)
        txtCurrentLimit.TabIndex = 5
        ' 
        ' btnSetCurrentLimit
        ' 
        btnSetCurrentLimit.Location = New Point(238, 28)
        btnSetCurrentLimit.Name = "btnSetCurrentLimit"
        btnSetCurrentLimit.Size = New Size(40, 23)
        btnSetCurrentLimit.TabIndex = 6
        btnSetCurrentLimit.Text = "Set"
        btnSetCurrentLimit.UseVisualStyleBackColor = True
        ' 
        ' btnReadCurrentLimit
        ' 
        btnReadCurrentLimit.Location = New Point(284, 28)
        btnReadCurrentLimit.Name = "btnReadCurrentLimit"
        btnReadCurrentLimit.Size = New Size(42, 23)
        btnReadCurrentLimit.TabIndex = 7
        btnReadCurrentLimit.Text = "Read"
        btnReadCurrentLimit.UseVisualStyleBackColor = True
        ' 
        ' btnReadCommandMode
        ' 
        btnReadCommandMode.Location = New Point(284, 76)
        btnReadCommandMode.Name = "btnReadCommandMode"
        btnReadCommandMode.Size = New Size(42, 23)
        btnReadCommandMode.TabIndex = 11
        btnReadCommandMode.Text = "Read"
        btnReadCommandMode.UseVisualStyleBackColor = True
        ' 
        ' btnSetCommandMode
        ' 
        btnSetCommandMode.Location = New Point(238, 76)
        btnSetCommandMode.Name = "btnSetCommandMode"
        btnSetCommandMode.Size = New Size(40, 23)
        btnSetCommandMode.TabIndex = 10
        btnSetCommandMode.Text = "Set"
        btnSetCommandMode.UseVisualStyleBackColor = True
        ' 
        ' txtCommandMode
        ' 
        txtCommandMode.Location = New Point(166, 73)
        txtCommandMode.Name = "txtCommandMode"
        txtCommandMode.Size = New Size(50, 23)
        txtCommandMode.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 8
        Label2.Text = "Command Mode:"
        ' 
        ' btnReadTorqueReferenceIq
        ' 
        btnReadTorqueReferenceIq.Location = New Point(284, 127)
        btnReadTorqueReferenceIq.Name = "btnReadTorqueReferenceIq"
        btnReadTorqueReferenceIq.Size = New Size(42, 23)
        btnReadTorqueReferenceIq.TabIndex = 15
        btnReadTorqueReferenceIq.Text = "Read"
        btnReadTorqueReferenceIq.UseVisualStyleBackColor = True
        ' 
        ' btnTorqueReferenceIq
        ' 
        btnTorqueReferenceIq.Location = New Point(238, 127)
        btnTorqueReferenceIq.Name = "btnTorqueReferenceIq"
        btnTorqueReferenceIq.Size = New Size(40, 23)
        btnTorqueReferenceIq.TabIndex = 14
        btnTorqueReferenceIq.Text = "Set"
        btnTorqueReferenceIq.UseVisualStyleBackColor = True
        ' 
        ' txtTorqueReferenceIq
        ' 
        txtTorqueReferenceIq.Location = New Point(166, 124)
        txtTorqueReferenceIq.Name = "txtTorqueReferenceIq"
        txtTorqueReferenceIq.Size = New Size(50, 23)
        txtTorqueReferenceIq.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 15)
        Label3.TabIndex = 12
        Label3.Text = "Torque Reference Iq:"
        ' 
        ' btnReadSpeedReference
        ' 
        btnReadSpeedReference.Location = New Point(284, 175)
        btnReadSpeedReference.Name = "btnReadSpeedReference"
        btnReadSpeedReference.Size = New Size(42, 23)
        btnReadSpeedReference.TabIndex = 19
        btnReadSpeedReference.Text = "Read"
        btnReadSpeedReference.UseVisualStyleBackColor = True
        ' 
        ' btnSetSpeedReference
        ' 
        btnSetSpeedReference.Location = New Point(238, 175)
        btnSetSpeedReference.Name = "btnSetSpeedReference"
        btnSetSpeedReference.Size = New Size(40, 23)
        btnSetSpeedReference.TabIndex = 18
        btnSetSpeedReference.Text = "Set"
        btnSetSpeedReference.UseVisualStyleBackColor = True
        ' 
        ' txtSpeedReference
        ' 
        txtSpeedReference.Location = New Point(166, 172)
        txtSpeedReference.Name = "txtSpeedReference"
        txtSpeedReference.Size = New Size(50, 23)
        txtSpeedReference.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 16
        Label4.Text = "Speed Reference:"
        ' 
        ' btnReadPositionReference
        ' 
        btnReadPositionReference.Location = New Point(284, 223)
        btnReadPositionReference.Name = "btnReadPositionReference"
        btnReadPositionReference.Size = New Size(42, 23)
        btnReadPositionReference.TabIndex = 23
        btnReadPositionReference.Text = "Read"
        btnReadPositionReference.UseVisualStyleBackColor = True
        ' 
        ' btnSetPositionReference
        ' 
        btnSetPositionReference.Location = New Point(238, 223)
        btnSetPositionReference.Name = "btnSetPositionReference"
        btnSetPositionReference.Size = New Size(40, 23)
        btnSetPositionReference.TabIndex = 22
        btnSetPositionReference.Text = "Set"
        btnSetPositionReference.UseVisualStyleBackColor = True
        ' 
        ' txtPositionReference
        ' 
        txtPositionReference.Location = New Point(166, 220)
        txtPositionReference.Name = "txtPositionReference"
        txtPositionReference.Size = New Size(50, 23)
        txtPositionReference.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 15)
        Label5.TabIndex = 20
        Label5.Text = "Position Reference:"
        ' 
        ' grbSettings
        ' 
        grbSettings.Controls.Add(btnReadPositionReference)
        grbSettings.Controls.Add(Label1)
        grbSettings.Controls.Add(btnSetPositionReference)
        grbSettings.Controls.Add(txtCurrentLimit)
        grbSettings.Controls.Add(txtPositionReference)
        grbSettings.Controls.Add(btnSetCurrentLimit)
        grbSettings.Controls.Add(Label5)
        grbSettings.Controls.Add(btnReadCurrentLimit)
        grbSettings.Controls.Add(btnReadSpeedReference)
        grbSettings.Controls.Add(Label2)
        grbSettings.Controls.Add(btnSetSpeedReference)
        grbSettings.Controls.Add(txtCommandMode)
        grbSettings.Controls.Add(txtSpeedReference)
        grbSettings.Controls.Add(btnSetCommandMode)
        grbSettings.Controls.Add(Label4)
        grbSettings.Controls.Add(btnReadCommandMode)
        grbSettings.Controls.Add(btnReadTorqueReferenceIq)
        grbSettings.Controls.Add(Label3)
        grbSettings.Controls.Add(btnTorqueReferenceIq)
        grbSettings.Controls.Add(txtTorqueReferenceIq)
        grbSettings.Location = New Point(43, 94)
        grbSettings.Name = "grbSettings"
        grbSettings.Size = New Size(412, 256)
        grbSettings.TabIndex = 24
        grbSettings.TabStop = False
        grbSettings.Text = "Settings"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(366, 426)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 24
        Label6.Text = "Error Code:"
        ' 
        ' lblErrorCode
        ' 
        lblErrorCode.AutoSize = True
        lblErrorCode.Location = New Point(438, 426)
        lblErrorCode.Name = "lblErrorCode"
        lblErrorCode.Size = New Size(10, 15)
        lblErrorCode.TabIndex = 25
        lblErrorCode.Text = "."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 450)
        Controls.Add(lblErrorCode)
        Controls.Add(Label6)
        Controls.Add(cmbBaudRate)
        Controls.Add(btnScan)
        Controls.Add(cmbComPort)
        Controls.Add(btnConnect)
        Controls.Add(grbSettings)
        Name = "Form1"
        Text = "Solo DLL Tester"
        grbSettings.ResumeLayout(False)
        grbSettings.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnConnect As Button
    Friend WithEvents cmbComPort As ComboBox
    Friend WithEvents btnScan As Button
    Friend WithEvents cmbBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentLimit As TextBox
    Friend WithEvents btnSetCurrentLimit As Button
    Friend WithEvents btnReadCurrentLimit As Button
    Friend WithEvents btnReadCommandMode As Button
    Friend WithEvents btnSetCommandMode As Button
    Friend WithEvents txtCommandMode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReadTorqueReferenceIq As Button
    Friend WithEvents btnTorqueReferenceIq As Button
    Friend WithEvents txtTorqueReferenceIq As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReadSpeedReference As Button
    Friend WithEvents btnSetSpeedReference As Button
    Friend WithEvents txtSpeedReference As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReadPositionReference As Button
    Friend WithEvents btnSetPositionReference As Button
    Friend WithEvents txtPositionReference As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grbSettings As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblErrorCode As Label

End Class
