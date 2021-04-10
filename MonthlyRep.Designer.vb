<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyRep
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource13 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource14 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource15 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource16 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.DaywisePanel = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.dttodate = New System.Windows.Forms.DateTimePicker()
        Me.dtfromdate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndmonth = New System.Windows.Forms.Label()
        Me.lblstmonth = New System.Windows.Forms.Label()
        Me.Monrepcom = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsDayWise = New BILL_SYSTEM.DsDayWise()
        Me.DsdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DwCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Moncominv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DwInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Moncominvpro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DwProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Moninv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Moninvpro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Monpro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DaywisePanel.SuspendLayout()
        CType(Me.DsDayWise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(-7, 21)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(233, 19)
        Me.lblMonth.TabIndex = 3
        Me.lblMonth.Text = "Please Select a Month for Report"
        '
        'DaywisePanel
        '
        Me.DaywisePanel.Controls.Add(Me.btncancel)
        Me.DaywisePanel.Controls.Add(Me.btnsub)
        Me.DaywisePanel.Controls.Add(Me.dttodate)
        Me.DaywisePanel.Controls.Add(Me.dtfromdate)
        Me.DaywisePanel.Controls.Add(Me.lblEndmonth)
        Me.DaywisePanel.Controls.Add(Me.lblstmonth)
        Me.DaywisePanel.Location = New System.Drawing.Point(48, 54)
        Me.DaywisePanel.Name = "DaywisePanel"
        Me.DaywisePanel.Size = New System.Drawing.Size(243, 179)
        Me.DaywisePanel.TabIndex = 2
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(123, 120)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(85, 28)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(26, 120)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(85, 28)
        Me.btnsub.TabIndex = 10
        Me.btnsub.Text = "SUBMIT"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'dttodate
        '
        Me.dttodate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttodate.Location = New System.Drawing.Point(122, 72)
        Me.dttodate.Name = "dttodate"
        Me.dttodate.Size = New System.Drawing.Size(84, 22)
        Me.dttodate.TabIndex = 9
        '
        'dtfromdate
        '
        Me.dtfromdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromdate.Location = New System.Drawing.Point(123, 30)
        Me.dtfromdate.Name = "dtfromdate"
        Me.dtfromdate.Size = New System.Drawing.Size(84, 22)
        Me.dtfromdate.TabIndex = 8
        '
        'lblEndmonth
        '
        Me.lblEndmonth.AutoSize = True
        Me.lblEndmonth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndmonth.Location = New System.Drawing.Point(21, 73)
        Me.lblEndmonth.Name = "lblEndmonth"
        Me.lblEndmonth.Size = New System.Drawing.Size(84, 19)
        Me.lblEndmonth.TabIndex = 7
        Me.lblEndmonth.Text = "End Month"
        '
        'lblstmonth
        '
        Me.lblstmonth.AutoSize = True
        Me.lblstmonth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstmonth.Location = New System.Drawing.Point(22, 32)
        Me.lblstmonth.Name = "lblstmonth"
        Me.lblstmonth.Size = New System.Drawing.Size(91, 19)
        Me.lblstmonth.TabIndex = 6
        Me.lblstmonth.Text = "Start Month"
        '
        'Monrepcom
        '
        ReportDataSource1.Name = "DSmon"
        ReportDataSource1.Value = Me.DsdateBindingSource
        ReportDataSource2.Name = "Dsmoncom"
        ReportDataSource2.Value = Me.DwCompanyBindingSource
        Me.Monrepcom.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Monrepcom.LocalReport.DataSources.Add(ReportDataSource2)
        Me.Monrepcom.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Monvomrep.rdlc"
        Me.Monrepcom.Location = New System.Drawing.Point(322, 48)
        Me.Monrepcom.Name = "Monrepcom"
        Me.Monrepcom.Size = New System.Drawing.Size(731, 416)
        Me.Monrepcom.TabIndex = 4
        '
        'DsDayWise
        '
        Me.DsDayWise.DataSetName = "DsDayWise"
        Me.DsDayWise.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsdateBindingSource
        '
        Me.DsdateBindingSource.DataMember = "Dsdate"
        Me.DsdateBindingSource.DataSource = Me.DsDayWise
        '
        'DwCompanyBindingSource
        '
        Me.DwCompanyBindingSource.DataMember = "DwCompany"
        Me.DwCompanyBindingSource.DataSource = Me.DsDayWise
        '
        'Moncominv
        '
        ReportDataSource3.Name = "DSmon"
        ReportDataSource3.Value = Me.DsdateBindingSource
        ReportDataSource4.Name = "Dsmoninv"
        ReportDataSource4.Value = Me.DwInvoiceBindingSource
        ReportDataSource5.Name = "DSmoncom"
        ReportDataSource5.Value = Me.DwCompanyBindingSource
        Me.Moncominv.LocalReport.DataSources.Add(ReportDataSource3)
        Me.Moncominv.LocalReport.DataSources.Add(ReportDataSource4)
        Me.Moncominv.LocalReport.DataSources.Add(ReportDataSource5)
        Me.Moncominv.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Moncominv.rdlc"
        Me.Moncominv.Location = New System.Drawing.Point(336, 80)
        Me.Moncominv.Name = "Moncominv"
        Me.Moncominv.Size = New System.Drawing.Size(697, 375)
        Me.Moncominv.TabIndex = 5
        '
        'DwInvoiceBindingSource
        '
        Me.DwInvoiceBindingSource.DataMember = "DwInvoice"
        Me.DwInvoiceBindingSource.DataSource = Me.DsDayWise
        '
        'Moncominvpro
        '
        ReportDataSource6.Name = "DSmon"
        ReportDataSource6.Value = Me.DsdateBindingSource
        ReportDataSource7.Name = "DSmoncom"
        ReportDataSource7.Value = Me.DwCompanyBindingSource
        ReportDataSource8.Name = "Dsmoninv"
        ReportDataSource8.Value = Me.DwInvoiceBindingSource
        ReportDataSource9.Name = "DSmonpro"
        ReportDataSource9.Value = Me.DwProductBindingSource
        Me.Moncominvpro.LocalReport.DataSources.Add(ReportDataSource6)
        Me.Moncominvpro.LocalReport.DataSources.Add(ReportDataSource7)
        Me.Moncominvpro.LocalReport.DataSources.Add(ReportDataSource8)
        Me.Moncominvpro.LocalReport.DataSources.Add(ReportDataSource9)
        Me.Moncominvpro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Moncominvpro.rdlc"
        Me.Moncominvpro.Location = New System.Drawing.Point(349, 112)
        Me.Moncominvpro.Name = "Moncominvpro"
        Me.Moncominvpro.Size = New System.Drawing.Size(670, 329)
        Me.Moncominvpro.TabIndex = 6
        '
        'DwProductBindingSource
        '
        Me.DwProductBindingSource.DataMember = "DwProduct"
        Me.DwProductBindingSource.DataSource = Me.DsDayWise
        '
        'Moninv
        '
        ReportDataSource10.Name = "DSmon"
        ReportDataSource10.Value = Me.DsdateBindingSource
        ReportDataSource11.Name = "Dsmoninv"
        ReportDataSource11.Value = Me.DwInvoiceBindingSource
        Me.Moninv.LocalReport.DataSources.Add(ReportDataSource10)
        Me.Moninv.LocalReport.DataSources.Add(ReportDataSource11)
        Me.Moninv.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Moninvreprdlc.rdlc"
        Me.Moninv.Location = New System.Drawing.Point(363, 144)
        Me.Moninv.Name = "Moninv"
        Me.Moninv.Size = New System.Drawing.Size(642, 283)
        Me.Moninv.TabIndex = 7
        '
        'Moninvpro
        '
        ReportDataSource12.Name = "DSmon"
        ReportDataSource12.Value = Me.DsdateBindingSource
        ReportDataSource13.Name = "Dsmoninv"
        ReportDataSource13.Value = Me.DwInvoiceBindingSource
        ReportDataSource14.Name = "DSmonpro"
        ReportDataSource14.Value = Me.DwProductBindingSource
        Me.Moninvpro.LocalReport.DataSources.Add(ReportDataSource12)
        Me.Moninvpro.LocalReport.DataSources.Add(ReportDataSource13)
        Me.Moninvpro.LocalReport.DataSources.Add(ReportDataSource14)
        Me.Moninvpro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Moninvpro.rdlc"
        Me.Moninvpro.Location = New System.Drawing.Point(377, 174)
        Me.Moninvpro.Name = "Moninvpro"
        Me.Moninvpro.Size = New System.Drawing.Size(616, 246)
        Me.Moninvpro.TabIndex = 8
        '
        'Monpro
        '
        ReportDataSource15.Name = "DSmon"
        ReportDataSource15.Value = Me.DsdateBindingSource
        ReportDataSource16.Name = "DSmonpro"
        ReportDataSource16.Value = Me.DwProductBindingSource
        Me.Monpro.LocalReport.DataSources.Add(ReportDataSource15)
        Me.Monpro.LocalReport.DataSources.Add(ReportDataSource16)
        Me.Monpro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Monprorep.rdlc"
        Me.Monpro.Location = New System.Drawing.Point(389, 206)
        Me.Monpro.Name = "Monpro"
        Me.Monpro.Size = New System.Drawing.Size(590, 205)
        Me.Monpro.TabIndex = 9
        '
        'MonthlyRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1060, 477)
        Me.Controls.Add(Me.Monpro)
        Me.Controls.Add(Me.Moninvpro)
        Me.Controls.Add(Me.Moninv)
        Me.Controls.Add(Me.Moncominvpro)
        Me.Controls.Add(Me.Moncominv)
        Me.Controls.Add(Me.Monrepcom)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.DaywisePanel)
        Me.Name = "MonthlyRep"
        Me.Text = "MonthlyRep"
        Me.DaywisePanel.ResumeLayout(False)
        Me.DaywisePanel.PerformLayout()
        CType(Me.DsDayWise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMonth As Label
    Friend WithEvents DaywisePanel As Panel
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents dttodate As DateTimePicker
    Friend WithEvents dtfromdate As DateTimePicker
    Friend WithEvents lblEndmonth As Label
    Friend WithEvents lblstmonth As Label
    Friend WithEvents Monrepcom As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsdateBindingSource As BindingSource
    Friend WithEvents DsDayWise As DsDayWise
    Friend WithEvents DwCompanyBindingSource As BindingSource
    Friend WithEvents Moncominv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DwInvoiceBindingSource As BindingSource
    Friend WithEvents Moncominvpro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DwProductBindingSource As BindingSource
    Friend WithEvents Moninv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Moninvpro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Monpro As Microsoft.Reporting.WinForms.ReportViewer
End Class
