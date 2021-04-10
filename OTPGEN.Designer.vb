<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTPGEN
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
        Me.Cmbotp = New System.Windows.Forms.ComboBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Lblcharlen = New System.Windows.Forms.Label()
        Me.lblotptype = New System.Windows.Forms.Label()
        Me.Rblet = New System.Windows.Forms.RadioButton()
        Me.Rbnumbers = New System.Windows.Forms.RadioButton()
        Me.btnotp = New System.Windows.Forms.Button()
        Me.lalurotp = New System.Windows.Forms.Label()
        Me.lblotp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmobno = New System.Windows.Forms.TextBox()
        Me.btnsms = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cmbotp
        '
        Me.Cmbotp.FormattingEnabled = True
        Me.Cmbotp.Items.AddRange(New Object() {"4", "5", "6"})
        Me.Cmbotp.Location = New System.Drawing.Point(206, 54)
        Me.Cmbotp.Name = "Cmbotp"
        Me.Cmbotp.Size = New System.Drawing.Size(130, 21)
        Me.Cmbotp.TabIndex = 1
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(133, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(131, 23)
        Me.lbltitle.TabIndex = 2
        Me.lbltitle.Text = "GENERATE OTP"
        '
        'Lblcharlen
        '
        Me.Lblcharlen.AutoSize = True
        Me.Lblcharlen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcharlen.Location = New System.Drawing.Point(11, 55)
        Me.Lblcharlen.Name = "Lblcharlen"
        Me.Lblcharlen.Size = New System.Drawing.Size(163, 20)
        Me.Lblcharlen.TabIndex = 3
        Me.Lblcharlen.Text = "Characters for OTP"
        '
        'lblotptype
        '
        Me.lblotptype.AutoSize = True
        Me.lblotptype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblotptype.Location = New System.Drawing.Point(12, 98)
        Me.lblotptype.Name = "lblotptype"
        Me.lblotptype.Size = New System.Drawing.Size(112, 20)
        Me.lblotptype.TabIndex = 4
        Me.lblotptype.Text = "Type of  OTP"
        '
        'Rblet
        '
        Me.Rblet.AutoSize = True
        Me.Rblet.Location = New System.Drawing.Point(207, 101)
        Me.Rblet.Name = "Rblet"
        Me.Rblet.Size = New System.Drawing.Size(57, 17)
        Me.Rblet.TabIndex = 5
        Me.Rblet.TabStop = True
        Me.Rblet.Text = "Letters"
        Me.Rblet.UseVisualStyleBackColor = True
        '
        'Rbnumbers
        '
        Me.Rbnumbers.AutoSize = True
        Me.Rbnumbers.Location = New System.Drawing.Point(270, 101)
        Me.Rbnumbers.Name = "Rbnumbers"
        Me.Rbnumbers.Size = New System.Drawing.Size(67, 17)
        Me.Rbnumbers.TabIndex = 6
        Me.Rbnumbers.TabStop = True
        Me.Rbnumbers.Text = "Numbers"
        Me.Rbnumbers.UseVisualStyleBackColor = True
        '
        'btnotp
        '
        Me.btnotp.BackColor = System.Drawing.Color.MistyRose
        Me.btnotp.Location = New System.Drawing.Point(149, 144)
        Me.btnotp.Name = "btnotp"
        Me.btnotp.Size = New System.Drawing.Size(75, 23)
        Me.btnotp.TabIndex = 7
        Me.btnotp.Text = "OTP"
        Me.btnotp.UseVisualStyleBackColor = False
        '
        'lalurotp
        '
        Me.lalurotp.AutoSize = True
        Me.lalurotp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lalurotp.Location = New System.Drawing.Point(75, 201)
        Me.lalurotp.Name = "lalurotp"
        Me.lalurotp.Size = New System.Drawing.Size(92, 19)
        Me.lalurotp.TabIndex = 8
        Me.lalurotp.Text = "Your OTP IS"
        '
        'lblotp
        '
        Me.lblotp.AutoSize = True
        Me.lblotp.BackColor = System.Drawing.Color.White
        Me.lblotp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblotp.Location = New System.Drawing.Point(223, 201)
        Me.lblotp.Name = "lblotp"
        Me.lblotp.Size = New System.Drawing.Size(30, 19)
        Me.lblotp.TabIndex = 9
        Me.lblotp.Text = "otp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter mobile number"
        '
        'txtmobno
        '
        Me.txtmobno.Location = New System.Drawing.Point(207, 253)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(130, 20)
        Me.txtmobno.TabIndex = 11
        '
        'btnsms
        '
        Me.btnsms.BackColor = System.Drawing.Color.MistyRose
        Me.btnsms.Location = New System.Drawing.Point(149, 296)
        Me.btnsms.Name = "btnsms"
        Me.btnsms.Size = New System.Drawing.Size(75, 23)
        Me.btnsms.TabIndex = 12
        Me.btnsms.Text = "Send sms"
        Me.btnsms.UseVisualStyleBackColor = False
        '
        'OTPGEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(354, 338)
        Me.Controls.Add(Me.btnsms)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblotp)
        Me.Controls.Add(Me.lalurotp)
        Me.Controls.Add(Me.btnotp)
        Me.Controls.Add(Me.Rbnumbers)
        Me.Controls.Add(Me.Rblet)
        Me.Controls.Add(Me.lblotptype)
        Me.Controls.Add(Me.Lblcharlen)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Cmbotp)
        Me.Name = "OTPGEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTPGEN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmbotp As ComboBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents Lblcharlen As Label
    Friend WithEvents lblotptype As Label
    Friend WithEvents Rblet As RadioButton
    Friend WithEvents Rbnumbers As RadioButton
    Friend WithEvents btnotp As Button
    Friend WithEvents lalurotp As Label
    Friend WithEvents lblotp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmobno As TextBox
    Friend WithEvents btnsms As Button
End Class
