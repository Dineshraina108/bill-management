<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delete
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
        Me.delpanel = New System.Windows.Forms.Panel()
        Me.lblpro = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.cbprid = New System.Windows.Forms.ComboBox()
        Me.lblpid = New System.Windows.Forms.Label()
        Me.lblinno = New System.Windows.Forms.Label()
        Me.CBinvoice = New System.Windows.Forms.ComboBox()
        Me.CBcom = New System.Windows.Forms.ComboBox()
        Me.lblcomname = New System.Windows.Forms.Label()
        Me.companel = New System.Windows.Forms.Panel()
        Me.btncomcancel = New System.Windows.Forms.Button()
        Me.btncomconfirm = New System.Windows.Forms.Button()
        Me.lbldeltitle = New System.Windows.Forms.Label()
        Me.cmbcom = New System.Windows.Forms.ComboBox()
        Me.lblcompany = New System.Windows.Forms.Label()
        Me.invpanel = New System.Windows.Forms.Panel()
        Me.btninvcancel = New System.Windows.Forms.Button()
        Me.btninvconfirm = New System.Windows.Forms.Button()
        Me.lblInvid = New System.Windows.Forms.Label()
        Me.cmbinvinvid = New System.Windows.Forms.ComboBox()
        Me.cmbinvcom = New System.Windows.Forms.ComboBox()
        Me.lblinvcom = New System.Windows.Forms.Label()
        Me.lblinv = New System.Windows.Forms.Label()
        Me.delpanel.SuspendLayout()
        Me.companel.SuspendLayout()
        Me.invpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'delpanel
        '
        Me.delpanel.Controls.Add(Me.lblpro)
        Me.delpanel.Controls.Add(Me.btncancel)
        Me.delpanel.Controls.Add(Me.btndel)
        Me.delpanel.Controls.Add(Me.cbprid)
        Me.delpanel.Controls.Add(Me.lblpid)
        Me.delpanel.Controls.Add(Me.lblinno)
        Me.delpanel.Controls.Add(Me.CBinvoice)
        Me.delpanel.Controls.Add(Me.CBcom)
        Me.delpanel.Controls.Add(Me.lblcomname)
        Me.delpanel.Location = New System.Drawing.Point(29, 35)
        Me.delpanel.Name = "delpanel"
        Me.delpanel.Size = New System.Drawing.Size(297, 268)
        Me.delpanel.TabIndex = 0
        '
        'lblpro
        '
        Me.lblpro.AutoSize = True
        Me.lblpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpro.Location = New System.Drawing.Point(49, 19)
        Me.lblpro.Name = "lblpro"
        Me.lblpro.Size = New System.Drawing.Size(149, 20)
        Me.lblpro.TabIndex = 49
        Me.lblpro.Text = "Excise of Product"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(149, 213)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 48
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(36, 213)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 25)
        Me.btndel.TabIndex = 47
        Me.btndel.Text = "Confirm"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'cbprid
        '
        Me.cbprid.FormattingEnabled = True
        Me.cbprid.Location = New System.Drawing.Point(127, 165)
        Me.cbprid.Name = "cbprid"
        Me.cbprid.Size = New System.Drawing.Size(137, 21)
        Me.cbprid.TabIndex = 46
        '
        'lblpid
        '
        Me.lblpid.AutoSize = True
        Me.lblpid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpid.Location = New System.Drawing.Point(13, 167)
        Me.lblpid.Name = "lblpid"
        Me.lblpid.Size = New System.Drawing.Size(78, 19)
        Me.lblpid.TabIndex = 45
        Me.lblpid.Text = "Product Id"
        '
        'lblinno
        '
        Me.lblinno.AutoSize = True
        Me.lblinno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinno.Location = New System.Drawing.Point(13, 112)
        Me.lblinno.Name = "lblinno"
        Me.lblinno.Size = New System.Drawing.Size(76, 19)
        Me.lblinno.TabIndex = 44
        Me.lblinno.Text = "Invoice Id"
        '
        'CBinvoice
        '
        Me.CBinvoice.FormattingEnabled = True
        Me.CBinvoice.Location = New System.Drawing.Point(127, 110)
        Me.CBinvoice.Name = "CBinvoice"
        Me.CBinvoice.Size = New System.Drawing.Size(137, 21)
        Me.CBinvoice.TabIndex = 43
        '
        'CBcom
        '
        Me.CBcom.FormattingEnabled = True
        Me.CBcom.Location = New System.Drawing.Point(127, 56)
        Me.CBcom.Name = "CBcom"
        Me.CBcom.Size = New System.Drawing.Size(137, 21)
        Me.CBcom.TabIndex = 31
        '
        'lblcomname
        '
        Me.lblcomname.AutoSize = True
        Me.lblcomname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomname.Location = New System.Drawing.Point(13, 58)
        Me.lblcomname.Name = "lblcomname"
        Me.lblcomname.Size = New System.Drawing.Size(72, 19)
        Me.lblcomname.TabIndex = 30
        Me.lblcomname.Text = "Company"
        '
        'companel
        '
        Me.companel.Controls.Add(Me.btncomcancel)
        Me.companel.Controls.Add(Me.btncomconfirm)
        Me.companel.Controls.Add(Me.lbldeltitle)
        Me.companel.Controls.Add(Me.cmbcom)
        Me.companel.Controls.Add(Me.lblcompany)
        Me.companel.Location = New System.Drawing.Point(332, 35)
        Me.companel.Name = "companel"
        Me.companel.Size = New System.Drawing.Size(300, 176)
        Me.companel.TabIndex = 1
        '
        'btncomcancel
        '
        Me.btncomcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomcancel.Location = New System.Drawing.Point(161, 115)
        Me.btncomcancel.Name = "btncomcancel"
        Me.btncomcancel.Size = New System.Drawing.Size(75, 25)
        Me.btncomcancel.TabIndex = 50
        Me.btncomcancel.Text = "Cancel"
        Me.btncomcancel.UseVisualStyleBackColor = True
        '
        'btncomconfirm
        '
        Me.btncomconfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomconfirm.Location = New System.Drawing.Point(48, 115)
        Me.btncomconfirm.Name = "btncomconfirm"
        Me.btncomconfirm.Size = New System.Drawing.Size(75, 25)
        Me.btncomconfirm.TabIndex = 49
        Me.btncomconfirm.Text = "Confirm"
        Me.btncomconfirm.UseVisualStyleBackColor = True
        '
        'lbldeltitle
        '
        Me.lbldeltitle.AutoSize = True
        Me.lbldeltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeltitle.Location = New System.Drawing.Point(74, 25)
        Me.lbldeltitle.Name = "lbldeltitle"
        Me.lbldeltitle.Size = New System.Drawing.Size(161, 20)
        Me.lbldeltitle.TabIndex = 34
        Me.lbldeltitle.Text = "Excise of Company"
        '
        'cmbcom
        '
        Me.cmbcom.FormattingEnabled = True
        Me.cmbcom.Location = New System.Drawing.Point(146, 65)
        Me.cmbcom.Name = "cmbcom"
        Me.cmbcom.Size = New System.Drawing.Size(137, 21)
        Me.cmbcom.TabIndex = 33
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.Location = New System.Drawing.Point(32, 67)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(72, 19)
        Me.lblcompany.TabIndex = 32
        Me.lblcompany.Text = "Company"
        '
        'invpanel
        '
        Me.invpanel.Controls.Add(Me.btninvcancel)
        Me.invpanel.Controls.Add(Me.btninvconfirm)
        Me.invpanel.Controls.Add(Me.lblInvid)
        Me.invpanel.Controls.Add(Me.cmbinvinvid)
        Me.invpanel.Controls.Add(Me.cmbinvcom)
        Me.invpanel.Controls.Add(Me.lblinvcom)
        Me.invpanel.Controls.Add(Me.lblinv)
        Me.invpanel.Location = New System.Drawing.Point(664, 85)
        Me.invpanel.Name = "invpanel"
        Me.invpanel.Size = New System.Drawing.Size(296, 218)
        Me.invpanel.TabIndex = 2
        '
        'btninvcancel
        '
        Me.btninvcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcancel.Location = New System.Drawing.Point(154, 163)
        Me.btninvcancel.Name = "btninvcancel"
        Me.btninvcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvcancel.TabIndex = 50
        Me.btninvcancel.Text = "Cancel"
        Me.btninvcancel.UseVisualStyleBackColor = True
        '
        'btninvconfirm
        '
        Me.btninvconfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvconfirm.Location = New System.Drawing.Point(41, 163)
        Me.btninvconfirm.Name = "btninvconfirm"
        Me.btninvconfirm.Size = New System.Drawing.Size(75, 25)
        Me.btninvconfirm.TabIndex = 49
        Me.btninvconfirm.Text = "Confirm"
        Me.btninvconfirm.UseVisualStyleBackColor = True
        '
        'lblInvid
        '
        Me.lblInvid.AutoSize = True
        Me.lblInvid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvid.Location = New System.Drawing.Point(23, 114)
        Me.lblInvid.Name = "lblInvid"
        Me.lblInvid.Size = New System.Drawing.Size(76, 19)
        Me.lblInvid.TabIndex = 46
        Me.lblInvid.Text = "Invoice Id"
        '
        'cmbinvinvid
        '
        Me.cmbinvinvid.FormattingEnabled = True
        Me.cmbinvinvid.Location = New System.Drawing.Point(143, 115)
        Me.cmbinvinvid.Name = "cmbinvinvid"
        Me.cmbinvinvid.Size = New System.Drawing.Size(137, 21)
        Me.cmbinvinvid.TabIndex = 45
        '
        'cmbinvcom
        '
        Me.cmbinvcom.FormattingEnabled = True
        Me.cmbinvcom.Location = New System.Drawing.Point(143, 63)
        Me.cmbinvcom.Name = "cmbinvcom"
        Me.cmbinvcom.Size = New System.Drawing.Size(137, 21)
        Me.cmbinvcom.TabIndex = 37
        '
        'lblinvcom
        '
        Me.lblinvcom.AutoSize = True
        Me.lblinvcom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvcom.Location = New System.Drawing.Point(23, 65)
        Me.lblinvcom.Name = "lblinvcom"
        Me.lblinvcom.Size = New System.Drawing.Size(72, 19)
        Me.lblinvcom.TabIndex = 36
        Me.lblinvcom.Text = "Company"
        '
        'lblinv
        '
        Me.lblinv.AutoSize = True
        Me.lblinv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinv.Location = New System.Drawing.Point(64, 19)
        Me.lblinv.Name = "lblinv"
        Me.lblinv.Size = New System.Drawing.Size(144, 20)
        Me.lblinv.TabIndex = 35
        Me.lblinv.Text = "Excise of Invoice"
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(972, 423)
        Me.Controls.Add(Me.invpanel)
        Me.Controls.Add(Me.companel)
        Me.Controls.Add(Me.delpanel)
        Me.Name = "Delete"
        Me.Text = "Delete"
        Me.delpanel.ResumeLayout(False)
        Me.delpanel.PerformLayout()
        Me.companel.ResumeLayout(False)
        Me.companel.PerformLayout()
        Me.invpanel.ResumeLayout(False)
        Me.invpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents delpanel As Panel
    Friend WithEvents CBcom As ComboBox
    Friend WithEvents lblcomname As Label
    Friend WithEvents lblinno As Label
    Friend WithEvents CBinvoice As ComboBox
    Friend WithEvents cbprid As ComboBox
    Friend WithEvents lblpid As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btndel As Button
    Friend WithEvents companel As Panel
    Friend WithEvents btncomcancel As Button
    Friend WithEvents btncomconfirm As Button
    Friend WithEvents lbldeltitle As Label
    Friend WithEvents cmbcom As ComboBox
    Friend WithEvents lblcompany As Label
    Friend WithEvents lblpro As Label
    Friend WithEvents invpanel As Panel
    Friend WithEvents btninvcancel As Button
    Friend WithEvents btninvconfirm As Button
    Friend WithEvents lblInvid As Label
    Friend WithEvents cmbinvinvid As ComboBox
    Friend WithEvents cmbinvcom As ComboBox
    Friend WithEvents lblinvcom As Label
    Friend WithEvents lblinv As Label
End Class
