<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaywiseRep
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
        Me.DsdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDayWise = New BILL_SYSTEM.DsDayWise()
        Me.DwCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DwInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DwProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaywisePanel = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.dttodate = New System.Windows.Forms.DateTimePicker()
        Me.dtfromdate = New System.Windows.Forms.DateTimePicker()
        Me.lbltodate = New System.Windows.Forms.Label()
        Me.lblfromdate = New System.Windows.Forms.Label()
        Me.lbldaywise = New System.Windows.Forms.Label()
        Me.RVdaywise = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Rvdayinv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Rvdaypro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Rvdaywisecomandinv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RVdaywiseinvandpro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RVdaycominvpro = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DsdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDayWise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DaywisePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsdateBindingSource
        '
        Me.DsdateBindingSource.DataMember = "Dsdate"
        Me.DsdateBindingSource.DataSource = Me.DsDayWise
        '
        'DsDayWise
        '
        Me.DsDayWise.DataSetName = "DsDayWise"
        Me.DsDayWise.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DwCompanyBindingSource
        '
        Me.DwCompanyBindingSource.DataMember = "DwCompany"
        Me.DwCompanyBindingSource.DataSource = Me.DsDayWise
        '
        'DwInvoiceBindingSource
        '
        Me.DwInvoiceBindingSource.DataMember = "DwInvoice"
        Me.DwInvoiceBindingSource.DataSource = Me.DsDayWise
        '
        'DwProductBindingSource
        '
        Me.DwProductBindingSource.DataMember = "DwProduct"
        Me.DwProductBindingSource.DataSource = Me.DsDayWise
        '
        'DaywisePanel
        '
        Me.DaywisePanel.Controls.Add(Me.btncancel)
        Me.DaywisePanel.Controls.Add(Me.btnsub)
        Me.DaywisePanel.Controls.Add(Me.dttodate)
        Me.DaywisePanel.Controls.Add(Me.dtfromdate)
        Me.DaywisePanel.Controls.Add(Me.lbltodate)
        Me.DaywisePanel.Controls.Add(Me.lblfromdate)
        Me.DaywisePanel.Location = New System.Drawing.Point(58, 38)
        Me.DaywisePanel.Name = "DaywisePanel"
        Me.DaywisePanel.Size = New System.Drawing.Size(243, 179)
        Me.DaywisePanel.TabIndex = 0
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
        Me.btnsub.Location = New System.Drawing.Point(26, 121)
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
        'lbltodate
        '
        Me.lbltodate.AutoSize = True
        Me.lbltodate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodate.Location = New System.Drawing.Point(21, 72)
        Me.lbltodate.Name = "lbltodate"
        Me.lbltodate.Size = New System.Drawing.Size(63, 19)
        Me.lbltodate.TabIndex = 7
        Me.lbltodate.Text = "To Date"
        '
        'lblfromdate
        '
        Me.lblfromdate.AutoSize = True
        Me.lblfromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfromdate.Location = New System.Drawing.Point(22, 32)
        Me.lblfromdate.Name = "lblfromdate"
        Me.lblfromdate.Size = New System.Drawing.Size(81, 19)
        Me.lblfromdate.TabIndex = 6
        Me.lblfromdate.Text = "From Date"
        '
        'lbldaywise
        '
        Me.lbldaywise.AutoSize = True
        Me.lbldaywise.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldaywise.Location = New System.Drawing.Point(22, 10)
        Me.lbldaywise.Name = "lbldaywise"
        Me.lbldaywise.Size = New System.Drawing.Size(221, 19)
        Me.lbldaywise.TabIndex = 1
        Me.lbldaywise.Text = "Please Select a Date for Report"
        '
        'RVdaywise
        '
        ReportDataSource1.Name = "Daywisedate"
        ReportDataSource1.Value = Me.DsdateBindingSource
        ReportDataSource2.Name = "Daywisecom"
        ReportDataSource2.Value = Me.DwCompanyBindingSource
        Me.RVdaywise.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVdaywise.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RVdaywise.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repdaywise.rdlc"
        Me.RVdaywise.Location = New System.Drawing.Point(341, 30)
        Me.RVdaywise.Name = "RVdaywise"
        Me.RVdaywise.Size = New System.Drawing.Size(717, 352)
        Me.RVdaywise.TabIndex = 2
        '
        'Rvdayinv
        '
        ReportDataSource3.Name = "Daywisedate"
        ReportDataSource3.Value = Me.DsdateBindingSource
        ReportDataSource4.Name = "Daywiseinv"
        ReportDataSource4.Value = Me.DwInvoiceBindingSource
        Me.Rvdayinv.LocalReport.DataSources.Add(ReportDataSource3)
        Me.Rvdayinv.LocalReport.DataSources.Add(ReportDataSource4)
        Me.Rvdayinv.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Dayrepinvoice.rdlc"
        Me.Rvdayinv.Location = New System.Drawing.Point(352, 51)
        Me.Rvdayinv.Name = "Rvdayinv"
        Me.Rvdayinv.Size = New System.Drawing.Size(733, 349)
        Me.Rvdayinv.TabIndex = 3
        '
        'Rvdaypro
        '
        ReportDataSource5.Name = "Daywisedate"
        ReportDataSource5.Value = Me.DsdateBindingSource
        ReportDataSource6.Name = "Daywisepro"
        ReportDataSource6.Value = Me.DwProductBindingSource
        Me.Rvdaypro.LocalReport.DataSources.Add(ReportDataSource5)
        Me.Rvdaypro.LocalReport.DataSources.Add(ReportDataSource6)
        Me.Rvdaypro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Daywiserepproduct.rdlc"
        Me.Rvdaypro.Location = New System.Drawing.Point(363, 70)
        Me.Rvdaypro.Name = "Rvdaypro"
        Me.Rvdaypro.Size = New System.Drawing.Size(771, 353)
        Me.Rvdaypro.TabIndex = 4
        '
        'Rvdaywisecomandinv
        '
        ReportDataSource7.Name = "Dawisedate"
        ReportDataSource7.Value = Me.DsdateBindingSource
        ReportDataSource8.Name = "Daywisecom"
        ReportDataSource8.Value = Me.DwCompanyBindingSource
        ReportDataSource9.Name = "Daywiseinv"
        ReportDataSource9.Value = Me.DwInvoiceBindingSource
        Me.Rvdaywisecomandinv.LocalReport.DataSources.Add(ReportDataSource7)
        Me.Rvdaywisecomandinv.LocalReport.DataSources.Add(ReportDataSource8)
        Me.Rvdaywisecomandinv.LocalReport.DataSources.Add(ReportDataSource9)
        Me.Rvdaywisecomandinv.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Daywisecomandinv.rdlc"
        Me.Rvdaywisecomandinv.Location = New System.Drawing.Point(374, 84)
        Me.Rvdaywisecomandinv.Name = "Rvdaywisecomandinv"
        Me.Rvdaywisecomandinv.Size = New System.Drawing.Size(787, 363)
        Me.Rvdaywisecomandinv.TabIndex = 5
        '
        'RVdaywiseinvandpro
        '
        ReportDataSource10.Name = "Daywisedate"
        ReportDataSource10.Value = Me.DsdateBindingSource
        ReportDataSource11.Name = "Daywiseinv"
        ReportDataSource11.Value = Me.DwInvoiceBindingSource
        ReportDataSource12.Name = "Daywisepro"
        ReportDataSource12.Value = Me.DwProductBindingSource
        Me.RVdaywiseinvandpro.LocalReport.DataSources.Add(ReportDataSource10)
        Me.RVdaywiseinvandpro.LocalReport.DataSources.Add(ReportDataSource11)
        Me.RVdaywiseinvandpro.LocalReport.DataSources.Add(ReportDataSource12)
        Me.RVdaywiseinvandpro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Daywiseinvandpro.rdlc"
        Me.RVdaywiseinvandpro.Location = New System.Drawing.Point(387, 97)
        Me.RVdaywiseinvandpro.Name = "RVdaywiseinvandpro"
        Me.RVdaywiseinvandpro.Size = New System.Drawing.Size(796, 371)
        Me.RVdaywiseinvandpro.TabIndex = 6
        '
        'RVdaycominvpro
        '
        ReportDataSource13.Name = "Daywisedate"
        ReportDataSource13.Value = Me.DsdateBindingSource
        ReportDataSource14.Name = "Daywisecom"
        ReportDataSource14.Value = Me.DwCompanyBindingSource
        ReportDataSource15.Name = "Daywiseinv"
        ReportDataSource15.Value = Me.DwInvoiceBindingSource
        ReportDataSource16.Name = "Daywisepro"
        ReportDataSource16.Value = Me.DwProductBindingSource
        Me.RVdaycominvpro.LocalReport.DataSources.Add(ReportDataSource13)
        Me.RVdaycominvpro.LocalReport.DataSources.Add(ReportDataSource14)
        Me.RVdaycominvpro.LocalReport.DataSources.Add(ReportDataSource15)
        Me.RVdaycominvpro.LocalReport.DataSources.Add(ReportDataSource16)
        Me.RVdaycominvpro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Daycominvprorep.rdlc"
        Me.RVdaycominvpro.Location = New System.Drawing.Point(400, 119)
        Me.RVdaycominvpro.Name = "RVdaycominvpro"
        Me.RVdaycominvpro.Size = New System.Drawing.Size(810, 376)
        Me.RVdaycominvpro.TabIndex = 7
        '
        'DaywiseRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1222, 505)
        Me.Controls.Add(Me.RVdaycominvpro)
        Me.Controls.Add(Me.RVdaywiseinvandpro)
        Me.Controls.Add(Me.Rvdaywisecomandinv)
        Me.Controls.Add(Me.Rvdaypro)
        Me.Controls.Add(Me.Rvdayinv)
        Me.Controls.Add(Me.RVdaywise)
        Me.Controls.Add(Me.lbldaywise)
        Me.Controls.Add(Me.DaywisePanel)
        Me.Name = "DaywiseRep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DaywiseRep"
        CType(Me.DsdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDayWise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DaywisePanel.ResumeLayout(False)
        Me.DaywisePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DaywisePanel As Panel
    Friend WithEvents lbldaywise As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents dttodate As DateTimePicker
    Friend WithEvents dtfromdate As DateTimePicker
    Friend WithEvents lbltodate As Label
    Friend WithEvents lblfromdate As Label
    Friend WithEvents RVdaywise As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsdateBindingSource As BindingSource
    Friend WithEvents DsDayWise As DsDayWise
    Friend WithEvents DwCompanyBindingSource As BindingSource
    Friend WithEvents Rvdayinv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DwInvoiceBindingSource As BindingSource
    Friend WithEvents Rvdaypro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DwProductBindingSource As BindingSource
    Friend WithEvents Rvdaywisecomandinv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RVdaywiseinvandpro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RVdaycominvpro As Microsoft.Reporting.WinForms.ReportViewer
End Class
