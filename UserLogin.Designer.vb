<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogin
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
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.llblsignup = New System.Windows.Forms.LinkLabel()
        Me.lblslash = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsignin = New System.Windows.Forms.Button()
        Me.llblforgetpassword = New System.Windows.Forms.LinkLabel()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.loginpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginpanel
        '
        Me.loginpanel.BackColor = System.Drawing.Color.LightPink
        Me.loginpanel.BackgroundImage = Global.BILL_SYSTEM.My.Resources.Resources.images2
        Me.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginpanel.Controls.Add(Me.llblsignup)
        Me.loginpanel.Controls.Add(Me.lblslash)
        Me.loginpanel.Controls.Add(Me.btncancel)
        Me.loginpanel.Controls.Add(Me.btnsignin)
        Me.loginpanel.Controls.Add(Me.llblforgetpassword)
        Me.loginpanel.Controls.Add(Me.txtpass)
        Me.loginpanel.Controls.Add(Me.txtuser)
        Me.loginpanel.Controls.Add(Me.lblpassword)
        Me.loginpanel.Controls.Add(Me.lblusername)
        Me.loginpanel.Controls.Add(Me.lbllogin)
        Me.loginpanel.Location = New System.Drawing.Point(22, 14)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(391, 269)
        Me.loginpanel.TabIndex = 1
        '
        'llblsignup
        '
        Me.llblsignup.AutoSize = True
        Me.llblsignup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblsignup.Location = New System.Drawing.Point(299, 171)
        Me.llblsignup.Name = "llblsignup"
        Me.llblsignup.Size = New System.Drawing.Size(50, 19)
        Me.llblsignup.TabIndex = 9
        Me.llblsignup.TabStop = True
        Me.llblsignup.Text = "Signup"
        Me.llblsignup.Visible = False
        '
        'lblslash
        '
        Me.lblslash.AutoSize = True
        Me.lblslash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslash.Location = New System.Drawing.Point(280, 171)
        Me.lblslash.Name = "lblslash"
        Me.lblslash.Size = New System.Drawing.Size(13, 20)
        Me.lblslash.TabIndex = 8
        Me.lblslash.Text = "/"
        Me.lblslash.Visible = False
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(150, 212)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(84, 30)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsignin
        '
        Me.btnsignin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.Location = New System.Drawing.Point(43, 212)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(83, 30)
        Me.btnsignin.TabIndex = 6
        Me.btnsignin.Text = "SIGN IN"
        Me.btnsignin.UseVisualStyleBackColor = True
        '
        'llblforgetpassword
        '
        Me.llblforgetpassword.AutoSize = True
        Me.llblforgetpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblforgetpassword.Location = New System.Drawing.Point(161, 171)
        Me.llblforgetpassword.Name = "llblforgetpassword"
        Me.llblforgetpassword.Size = New System.Drawing.Size(113, 19)
        Me.llblforgetpassword.TabIndex = 5
        Me.llblforgetpassword.TabStop = True
        Me.llblforgetpassword.Text = "Forget Password"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(150, 123)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(100, 22)
        Me.txtpass.TabIndex = 4
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(150, 73)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 20)
        Me.txtuser.TabIndex = 3
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(26, 126)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(97, 19)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "PASSWORD"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(26, 72)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(100, 19)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "USERNAME"
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.Location = New System.Drawing.Point(106, 19)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(59, 23)
        Me.lbllogin.TabIndex = 0
        Me.lbllogin.Text = "LOGIN"
        '
        'UserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(448, 295)
        Me.Controls.Add(Me.loginpanel)
        Me.Name = "UserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserLogin"
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginpanel As Panel
    Friend WithEvents llblsignup As LinkLabel
    Friend WithEvents lblslash As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsignin As Button
    Friend WithEvents llblforgetpassword As LinkLabel
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lbllogin As Label
End Class
