<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.uppl = New System.Windows.Forms.Panel()
        Me.propanel = New System.Windows.Forms.Panel()
        Me.cbprid = New System.Windows.Forms.ComboBox()
        Me.lblpid = New System.Windows.Forms.Label()
        Me.lblinno = New System.Windows.Forms.Label()
        Me.CBproinv = New System.Windows.Forms.ComboBox()
        Me.CBprocom = New System.Windows.Forms.ComboBox()
        Me.lblconame = New System.Windows.Forms.Label()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.lblamt = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.lblrate = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.txtinvdes = New System.Windows.Forms.TextBox()
        Me.lblprname = New System.Windows.Forms.Label()
        Me.btnprocancel = New System.Windows.Forms.Button()
        Me.btnproup = New System.Windows.Forms.Button()
        Me.companel = New System.Windows.Forms.Panel()
        Me.txtcomname = New System.Windows.Forms.TextBox()
        Me.lblcocomname = New System.Windows.Forms.Label()
        Me.Cbcompany = New System.Windows.Forms.ComboBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btncomup = New System.Windows.Forms.Button()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.lbladdr = New System.Windows.Forms.Label()
        Me.lblcompsny = New System.Windows.Forms.Label()
        Me.invpanel = New System.Windows.Forms.Panel()
        Me.txtinvno = New System.Windows.Forms.TextBox()
        Me.lblIninvno = New System.Windows.Forms.Label()
        Me.CBinvoice = New System.Windows.Forms.ComboBox()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.CBcom = New System.Windows.Forms.ComboBox()
        Me.lblcomname = New System.Windows.Forms.Label()
        Me.btninvcancel = New System.Windows.Forms.Button()
        Me.btninvup = New System.Windows.Forms.Button()
        Me.txtchalanno = New System.Windows.Forms.TextBox()
        Me.lblchalan = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.lblserial = New System.Windows.Forms.Label()
        Me.dtpinvdate = New System.Windows.Forms.DateTimePicker()
        Me.lblinvdate = New System.Windows.Forms.Label()
        Me.uppl.SuspendLayout()
        Me.propanel.SuspendLayout()
        Me.companel.SuspendLayout()
        Me.invpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(70, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(47, 19)
        Me.lbltitle.TabIndex = 2
        Me.lbltitle.Text = "crcip"
        '
        'uppl
        '
        Me.uppl.Controls.Add(Me.propanel)
        Me.uppl.Controls.Add(Me.companel)
        Me.uppl.Controls.Add(Me.invpanel)
        Me.uppl.Location = New System.Drawing.Point(14, 37)
        Me.uppl.Name = "uppl"
        Me.uppl.Size = New System.Drawing.Size(1050, 405)
        Me.uppl.TabIndex = 3
        '
        'propanel
        '
        Me.propanel.AutoSize = True
        Me.propanel.Controls.Add(Me.cbprid)
        Me.propanel.Controls.Add(Me.lblpid)
        Me.propanel.Controls.Add(Me.lblinno)
        Me.propanel.Controls.Add(Me.CBproinv)
        Me.propanel.Controls.Add(Me.CBprocom)
        Me.propanel.Controls.Add(Me.lblconame)
        Me.propanel.Controls.Add(Me.txtamt)
        Me.propanel.Controls.Add(Me.lblamt)
        Me.propanel.Controls.Add(Me.txtrate)
        Me.propanel.Controls.Add(Me.lblrate)
        Me.propanel.Controls.Add(Me.txtqty)
        Me.propanel.Controls.Add(Me.lblqty)
        Me.propanel.Controls.Add(Me.txtinvdes)
        Me.propanel.Controls.Add(Me.lblprname)
        Me.propanel.Controls.Add(Me.btnprocancel)
        Me.propanel.Controls.Add(Me.btnproup)
        Me.propanel.Location = New System.Drawing.Point(709, 16)
        Me.propanel.Name = "propanel"
        Me.propanel.Size = New System.Drawing.Size(308, 360)
        Me.propanel.TabIndex = 5
        Me.propanel.Visible = False
        '
        'cbprid
        '
        Me.cbprid.FormattingEnabled = True
        Me.cbprid.Location = New System.Drawing.Point(108, 102)
        Me.cbprid.Name = "cbprid"
        Me.cbprid.Size = New System.Drawing.Size(119, 21)
        Me.cbprid.TabIndex = 44
        '
        'lblpid
        '
        Me.lblpid.AutoSize = True
        Me.lblpid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpid.Location = New System.Drawing.Point(15, 102)
        Me.lblpid.Name = "lblpid"
        Me.lblpid.Size = New System.Drawing.Size(50, 19)
        Me.lblpid.TabIndex = 43
        Me.lblpid.Text = "Pro Id"
        '
        'lblinno
        '
        Me.lblinno.AutoSize = True
        Me.lblinno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinno.Location = New System.Drawing.Point(15, 69)
        Me.lblinno.Name = "lblinno"
        Me.lblinno.Size = New System.Drawing.Size(82, 19)
        Me.lblinno.TabIndex = 42
        Me.lblinno.Text = "Invoice No"
        '
        'CBproinv
        '
        Me.CBproinv.FormattingEnabled = True
        Me.CBproinv.Location = New System.Drawing.Point(108, 67)
        Me.CBproinv.Name = "CBproinv"
        Me.CBproinv.Size = New System.Drawing.Size(119, 21)
        Me.CBproinv.TabIndex = 41
        '
        'CBprocom
        '
        Me.CBprocom.FormattingEnabled = True
        Me.CBprocom.Location = New System.Drawing.Point(108, 28)
        Me.CBprocom.Name = "CBprocom"
        Me.CBprocom.Size = New System.Drawing.Size(137, 21)
        Me.CBprocom.TabIndex = 39
        '
        'lblconame
        '
        Me.lblconame.AutoSize = True
        Me.lblconame.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconame.Location = New System.Drawing.Point(14, 30)
        Me.lblconame.Name = "lblconame"
        Me.lblconame.Size = New System.Drawing.Size(72, 19)
        Me.lblconame.TabIndex = 38
        Me.lblconame.Text = "Company"
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(109, 262)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.ReadOnly = True
        Me.txtamt.Size = New System.Drawing.Size(120, 25)
        Me.txtamt.TabIndex = 37
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(15, 264)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(61, 19)
        Me.lblamt.TabIndex = 36
        Me.lblamt.Text = "Amount"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(109, 218)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(120, 25)
        Me.txtrate.TabIndex = 35
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(15, 220)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(42, 19)
        Me.lblrate.TabIndex = 34
        Me.lblrate.Text = "Rate"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(108, 178)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(120, 25)
        Me.txtqty.TabIndex = 33
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(14, 180)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(67, 19)
        Me.lblqty.TabIndex = 32
        Me.lblqty.Text = "Quantity"
        '
        'txtinvdes
        '
        Me.txtinvdes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvdes.Location = New System.Drawing.Point(108, 136)
        Me.txtinvdes.Name = "txtinvdes"
        Me.txtinvdes.Size = New System.Drawing.Size(120, 25)
        Me.txtinvdes.TabIndex = 31
        '
        'lblprname
        '
        Me.lblprname.AutoSize = True
        Me.lblprname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprname.Location = New System.Drawing.Point(14, 138)
        Me.lblprname.Name = "lblprname"
        Me.lblprname.Size = New System.Drawing.Size(76, 19)
        Me.lblprname.TabIndex = 30
        Me.lblprname.Text = "Pro Name"
        '
        'btnprocancel
        '
        Me.btnprocancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocancel.Location = New System.Drawing.Point(127, 297)
        Me.btnprocancel.Name = "btnprocancel"
        Me.btnprocancel.Size = New System.Drawing.Size(75, 25)
        Me.btnprocancel.TabIndex = 29
        Me.btnprocancel.Text = "Cancel"
        Me.btnprocancel.UseVisualStyleBackColor = True
        '
        'btnproup
        '
        Me.btnproup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproup.Location = New System.Drawing.Point(29, 298)
        Me.btnproup.Name = "btnproup"
        Me.btnproup.Size = New System.Drawing.Size(75, 25)
        Me.btnproup.TabIndex = 28
        Me.btnproup.Text = "Update"
        Me.btnproup.UseVisualStyleBackColor = True
        '
        'companel
        '
        Me.companel.AutoSize = True
        Me.companel.Controls.Add(Me.txtcomname)
        Me.companel.Controls.Add(Me.lblcocomname)
        Me.companel.Controls.Add(Me.Cbcompany)
        Me.companel.Controls.Add(Me.btncancel)
        Me.companel.Controls.Add(Me.btncomup)
        Me.companel.Controls.Add(Me.txtaddr)
        Me.companel.Controls.Add(Me.lbladdr)
        Me.companel.Controls.Add(Me.lblcompsny)
        Me.companel.Location = New System.Drawing.Point(17, 16)
        Me.companel.Name = "companel"
        Me.companel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.companel.Size = New System.Drawing.Size(306, 372)
        Me.companel.TabIndex = 3
        Me.companel.Visible = False
        '
        'txtcomname
        '
        Me.txtcomname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomname.Location = New System.Drawing.Point(107, 91)
        Me.txtcomname.Name = "txtcomname"
        Me.txtcomname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcomname.Size = New System.Drawing.Size(137, 25)
        Me.txtcomname.TabIndex = 32
        '
        'lblcocomname
        '
        Me.lblcocomname.AutoSize = True
        Me.lblcocomname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcocomname.Location = New System.Drawing.Point(13, 91)
        Me.lblcocomname.Name = "lblcocomname"
        Me.lblcocomname.Size = New System.Drawing.Size(72, 19)
        Me.lblcocomname.TabIndex = 31
        Me.lblcocomname.Text = "Company"
        '
        'Cbcompany
        '
        Me.Cbcompany.FormattingEnabled = True
        Me.Cbcompany.Location = New System.Drawing.Point(107, 46)
        Me.Cbcompany.Name = "Cbcompany"
        Me.Cbcompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbcompany.Size = New System.Drawing.Size(137, 21)
        Me.Cbcompany.TabIndex = 30
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(132, 241)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btncomup
        '
        Me.btncomup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomup.Location = New System.Drawing.Point(24, 241)
        Me.btncomup.Name = "btncomup"
        Me.btncomup.Size = New System.Drawing.Size(75, 25)
        Me.btncomup.TabIndex = 17
        Me.btncomup.Text = "Update"
        Me.btncomup.UseVisualStyleBackColor = True
        '
        'txtaddr
        '
        Me.txtaddr.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddr.Location = New System.Drawing.Point(107, 150)
        Me.txtaddr.Multiline = True
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtaddr.Size = New System.Drawing.Size(137, 60)
        Me.txtaddr.TabIndex = 7
        '
        'lbladdr
        '
        Me.lbladdr.AutoSize = True
        Me.lbladdr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.Location = New System.Drawing.Point(13, 150)
        Me.lbladdr.Name = "lbladdr"
        Me.lbladdr.Size = New System.Drawing.Size(64, 19)
        Me.lbladdr.TabIndex = 5
        Me.lbladdr.Text = "Address"
        '
        'lblcompsny
        '
        Me.lblcompsny.AutoSize = True
        Me.lblcompsny.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompsny.Location = New System.Drawing.Point(13, 45)
        Me.lblcompsny.Name = "lblcompsny"
        Me.lblcompsny.Size = New System.Drawing.Size(58, 19)
        Me.lblcompsny.TabIndex = 4
        Me.lblcompsny.Text = "Com Id"
        '
        'invpanel
        '
        Me.invpanel.AutoSize = True
        Me.invpanel.Controls.Add(Me.txtinvno)
        Me.invpanel.Controls.Add(Me.lblIninvno)
        Me.invpanel.Controls.Add(Me.CBinvoice)
        Me.invpanel.Controls.Add(Me.lblinvno)
        Me.invpanel.Controls.Add(Me.CBcom)
        Me.invpanel.Controls.Add(Me.lblcomname)
        Me.invpanel.Controls.Add(Me.btninvcancel)
        Me.invpanel.Controls.Add(Me.btninvup)
        Me.invpanel.Controls.Add(Me.txtchalanno)
        Me.invpanel.Controls.Add(Me.lblchalan)
        Me.invpanel.Controls.Add(Me.txtlocation)
        Me.invpanel.Controls.Add(Me.lbllocation)
        Me.invpanel.Controls.Add(Me.txtserial)
        Me.invpanel.Controls.Add(Me.lblserial)
        Me.invpanel.Controls.Add(Me.dtpinvdate)
        Me.invpanel.Controls.Add(Me.lblinvdate)
        Me.invpanel.Location = New System.Drawing.Point(352, 17)
        Me.invpanel.Name = "invpanel"
        Me.invpanel.Size = New System.Drawing.Size(325, 359)
        Me.invpanel.TabIndex = 2
        Me.invpanel.Visible = False
        '
        'txtinvno
        '
        Me.txtinvno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvno.Location = New System.Drawing.Point(140, 90)
        Me.txtinvno.Name = "txtinvno"
        Me.txtinvno.Size = New System.Drawing.Size(137, 22)
        Me.txtinvno.TabIndex = 46
        '
        'lblIninvno
        '
        Me.lblIninvno.AutoSize = True
        Me.lblIninvno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIninvno.Location = New System.Drawing.Point(15, 96)
        Me.lblIninvno.Name = "lblIninvno"
        Me.lblIninvno.Size = New System.Drawing.Size(55, 19)
        Me.lblIninvno.TabIndex = 45
        Me.lblIninvno.Text = "Inv No"
        '
        'CBinvoice
        '
        Me.CBinvoice.FormattingEnabled = True
        Me.CBinvoice.Location = New System.Drawing.Point(140, 58)
        Me.CBinvoice.Name = "CBinvoice"
        Me.CBinvoice.Size = New System.Drawing.Size(119, 21)
        Me.CBinvoice.TabIndex = 44
        '
        'lblinvno
        '
        Me.lblinvno.AutoSize = True
        Me.lblinvno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.Location = New System.Drawing.Point(15, 57)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(76, 19)
        Me.lblinvno.TabIndex = 43
        Me.lblinvno.Text = "Invoice Id"
        '
        'CBcom
        '
        Me.CBcom.FormattingEnabled = True
        Me.CBcom.Location = New System.Drawing.Point(138, 24)
        Me.CBcom.Name = "CBcom"
        Me.CBcom.Size = New System.Drawing.Size(137, 21)
        Me.CBcom.TabIndex = 29
        '
        'lblcomname
        '
        Me.lblcomname.AutoSize = True
        Me.lblcomname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomname.Location = New System.Drawing.Point(13, 27)
        Me.lblcomname.Name = "lblcomname"
        Me.lblcomname.Size = New System.Drawing.Size(72, 19)
        Me.lblcomname.TabIndex = 28
        Me.lblcomname.Text = "Company"
        '
        'btninvcancel
        '
        Me.btninvcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcancel.Location = New System.Drawing.Point(148, 285)
        Me.btninvcancel.Name = "btninvcancel"
        Me.btninvcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvcancel.TabIndex = 27
        Me.btninvcancel.Text = "Cancel"
        Me.btninvcancel.UseVisualStyleBackColor = True
        '
        'btninvup
        '
        Me.btninvup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvup.Location = New System.Drawing.Point(50, 286)
        Me.btninvup.Name = "btninvup"
        Me.btninvup.Size = New System.Drawing.Size(75, 25)
        Me.btninvup.TabIndex = 26
        Me.btninvup.Text = "Update"
        Me.btninvup.UseVisualStyleBackColor = True
        '
        'txtchalanno
        '
        Me.txtchalanno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchalanno.Location = New System.Drawing.Point(138, 246)
        Me.txtchalanno.Name = "txtchalanno"
        Me.txtchalanno.Size = New System.Drawing.Size(120, 25)
        Me.txtchalanno.TabIndex = 23
        '
        'lblchalan
        '
        Me.lblchalan.AutoSize = True
        Me.lblchalan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchalan.Location = New System.Drawing.Point(13, 247)
        Me.lblchalan.Name = "lblchalan"
        Me.lblchalan.Size = New System.Drawing.Size(84, 19)
        Me.lblchalan.TabIndex = 22
        Me.lblchalan.Text = "Chalan  No"
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(139, 205)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(120, 25)
        Me.txtlocation.TabIndex = 21
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocation.Location = New System.Drawing.Point(13, 205)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(67, 19)
        Me.lbllocation.TabIndex = 20
        Me.lbllocation.Text = "Location"
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(139, 168)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(120, 25)
        Me.txtserial.TabIndex = 19
        '
        'lblserial
        '
        Me.lblserial.AutoSize = True
        Me.lblserial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserial.Location = New System.Drawing.Point(13, 168)
        Me.lblserial.Name = "lblserial"
        Me.lblserial.Size = New System.Drawing.Size(48, 19)
        Me.lblserial.TabIndex = 18
        Me.lblserial.Text = "Serial"
        '
        'dtpinvdate
        '
        Me.dtpinvdate.CalendarFont = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinvdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinvdate.Location = New System.Drawing.Point(140, 134)
        Me.dtpinvdate.Name = "dtpinvdate"
        Me.dtpinvdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpinvdate.TabIndex = 15
        '
        'lblinvdate
        '
        Me.lblinvdate.AutoSize = True
        Me.lblinvdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvdate.Location = New System.Drawing.Point(13, 136)
        Me.lblinvdate.Name = "lblinvdate"
        Me.lblinvdate.Size = New System.Drawing.Size(95, 19)
        Me.lblinvdate.TabIndex = 14
        Me.lblinvdate.Text = "Invoice Date"
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1080, 449)
        Me.Controls.Add(Me.uppl)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.uppl.ResumeLayout(False)
        Me.uppl.PerformLayout()
        Me.propanel.ResumeLayout(False)
        Me.propanel.PerformLayout()
        Me.companel.ResumeLayout(False)
        Me.companel.PerformLayout()
        Me.invpanel.ResumeLayout(False)
        Me.invpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents uppl As Panel
    Friend WithEvents invpanel As Panel
    Friend WithEvents CBcom As ComboBox
    Friend WithEvents lblcomname As Label
    Friend WithEvents btninvcancel As Button
    Friend WithEvents btninvup As Button
    Friend WithEvents txtchalanno As TextBox
    Friend WithEvents lblchalan As Label
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents lbllocation As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents lblserial As Label
    Friend WithEvents dtpinvdate As DateTimePicker
    Friend WithEvents lblinvdate As Label
    Friend WithEvents propanel As Panel
    Friend WithEvents cbprid As ComboBox
    Friend WithEvents lblpid As Label
    Friend WithEvents lblinno As Label
    Friend WithEvents CBproinv As ComboBox
    Friend WithEvents CBprocom As ComboBox
    Friend WithEvents lblconame As Label
    Friend WithEvents txtamt As TextBox
    Public WithEvents lblamt As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents lblrate As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblqty As Label
    Friend WithEvents txtinvdes As TextBox
    Friend WithEvents lblprname As Label
    Friend WithEvents btnprocancel As Button
    Friend WithEvents btnproup As Button
    Friend WithEvents companel As Panel
    Friend WithEvents Cbcompany As ComboBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btncomup As Button
    Friend WithEvents txtaddr As TextBox
    Friend WithEvents lbladdr As Label
    Friend WithEvents lblcompsny As Label
    Friend WithEvents txtcomname As TextBox
    Friend WithEvents lblcocomname As Label
    Friend WithEvents txtinvno As TextBox
    Friend WithEvents lblIninvno As Label
    Friend WithEvents CBinvoice As ComboBox
    Friend WithEvents lblinvno As Label
End Class
