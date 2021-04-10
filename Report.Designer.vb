<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.BILLINVOICE_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsinvoice = New BILL_SYSTEM.Dsinvoice()
        Me.BILLCOM_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DScom = New BILL_SYSTEM.DScom()
        Me.Txtvalue = New System.Windows.Forms.TextBox()
        Me.RVinvinvdetails = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BILLINVOICE_DETAILSTableAdapter = New BILL_SYSTEM.DsinvoiceTableAdapters.BILLINVOICE_DETAILSTableAdapter()
        Me.RVcom = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BILLCOM_DETAILSTableAdapter = New BILL_SYSTEM.DScomTableAdapters.BILLCOM_DETAILSTableAdapter()
        Me.reppanel = New System.Windows.Forms.Panel()
        Me.btninvcancel = New System.Windows.Forms.Button()
        Me.btninvconfirm = New System.Windows.Forms.Button()
        Me.lblInvid = New System.Windows.Forms.Label()
        Me.cmbinv = New System.Windows.Forms.ComboBox()
        Me.cmbcom = New System.Windows.Forms.ComboBox()
        Me.lblinvcom = New System.Windows.Forms.Label()
        Me.Repcompro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Repcominv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RepcominvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsreportxsd = New BILL_SYSTEM.Dsreportxsd()
        Me.RepcomproBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Repinvpro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RepinvproBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Repproduct = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsProduct = New BILL_SYSTEM.DsProduct()
        Me.BILLPRODUCT_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BILLPRODUCT_DETAILSTableAdapter = New BILL_SYSTEM.DsProductTableAdapters.BILLPRODUCT_DETAILSTableAdapter()
        CType(Me.BILLINVOICE_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsinvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BILLCOM_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DScom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.reppanel.SuspendLayout()
        CType(Me.RepcominvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsreportxsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepcomproBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepinvproBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BILLPRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BILLINVOICE_DETAILSBindingSource
        '
        Me.BILLINVOICE_DETAILSBindingSource.DataMember = "BILLINVOICE_DETAILS"
        Me.BILLINVOICE_DETAILSBindingSource.DataSource = Me.Dsinvoice
        '
        'Dsinvoice
        '
        Me.Dsinvoice.DataSetName = "Dsinvoice"
        Me.Dsinvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BILLCOM_DETAILSBindingSource
        '
        Me.BILLCOM_DETAILSBindingSource.DataMember = "BILLCOM_DETAILS"
        Me.BILLCOM_DETAILSBindingSource.DataSource = Me.DScom
        '
        'DScom
        '
        Me.DScom.DataSetName = "DScom"
        Me.DScom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txtvalue
        '
        Me.Txtvalue.Location = New System.Drawing.Point(16, 3)
        Me.Txtvalue.Multiline = True
        Me.Txtvalue.Name = "Txtvalue"
        Me.Txtvalue.Size = New System.Drawing.Size(815, 449)
        Me.Txtvalue.TabIndex = 0
        '
        'RVinvinvdetails
        '
        ReportDataSource1.Name = "reinvoice"
        ReportDataSource1.Value = Me.BILLINVOICE_DETAILSBindingSource
        Me.RVinvinvdetails.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVinvinvdetails.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repinvoice.rdlc"
        Me.RVinvinvdetails.Location = New System.Drawing.Point(335, 25)
        Me.RVinvinvdetails.Name = "RVinvinvdetails"
        Me.RVinvinvdetails.Size = New System.Drawing.Size(759, 407)
        Me.RVinvinvdetails.TabIndex = 1
        '
        'BILLINVOICE_DETAILSTableAdapter
        '
        Me.BILLINVOICE_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'RVcom
        '
        ReportDataSource2.Name = "DScom"
        ReportDataSource2.Value = Me.BILLCOM_DETAILSBindingSource
        Me.RVcom.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RVcom.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repcomdetails.rdlc"
        Me.RVcom.Location = New System.Drawing.Point(359, 53)
        Me.RVcom.Name = "RVcom"
        Me.RVcom.Size = New System.Drawing.Size(725, 364)
        Me.RVcom.TabIndex = 2
        '
        'BILLCOM_DETAILSTableAdapter
        '
        Me.BILLCOM_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'reppanel
        '
        Me.reppanel.Controls.Add(Me.btninvcancel)
        Me.reppanel.Controls.Add(Me.btninvconfirm)
        Me.reppanel.Controls.Add(Me.lblInvid)
        Me.reppanel.Controls.Add(Me.cmbinv)
        Me.reppanel.Controls.Add(Me.cmbcom)
        Me.reppanel.Controls.Add(Me.Txtvalue)
        Me.reppanel.Controls.Add(Me.lblinvcom)
        Me.reppanel.Location = New System.Drawing.Point(12, 12)
        Me.reppanel.Name = "reppanel"
        Me.reppanel.Size = New System.Drawing.Size(267, 191)
        Me.reppanel.TabIndex = 3
        '
        'btninvcancel
        '
        Me.btninvcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcancel.Location = New System.Drawing.Point(143, 121)
        Me.btninvcancel.Name = "btninvcancel"
        Me.btninvcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvcancel.TabIndex = 56
        Me.btninvcancel.Text = "Cancel"
        Me.btninvcancel.UseVisualStyleBackColor = True
        '
        'btninvconfirm
        '
        Me.btninvconfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvconfirm.Location = New System.Drawing.Point(30, 121)
        Me.btninvconfirm.Name = "btninvconfirm"
        Me.btninvconfirm.Size = New System.Drawing.Size(75, 25)
        Me.btninvconfirm.TabIndex = 55
        Me.btninvconfirm.Text = "Submit"
        Me.btninvconfirm.UseVisualStyleBackColor = True
        '
        'lblInvid
        '
        Me.lblInvid.AutoSize = True
        Me.lblInvid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvid.Location = New System.Drawing.Point(12, 72)
        Me.lblInvid.Name = "lblInvid"
        Me.lblInvid.Size = New System.Drawing.Size(76, 19)
        Me.lblInvid.TabIndex = 54
        Me.lblInvid.Text = "Invoice Id"
        '
        'cmbinv
        '
        Me.cmbinv.FormattingEnabled = True
        Me.cmbinv.Location = New System.Drawing.Point(110, 72)
        Me.cmbinv.Name = "cmbinv"
        Me.cmbinv.Size = New System.Drawing.Size(137, 21)
        Me.cmbinv.TabIndex = 53
        '
        'cmbcom
        '
        Me.cmbcom.FormattingEnabled = True
        Me.cmbcom.Location = New System.Drawing.Point(110, 24)
        Me.cmbcom.Name = "cmbcom"
        Me.cmbcom.Size = New System.Drawing.Size(137, 21)
        Me.cmbcom.TabIndex = 52
        '
        'lblinvcom
        '
        Me.lblinvcom.AutoSize = True
        Me.lblinvcom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvcom.Location = New System.Drawing.Point(12, 23)
        Me.lblinvcom.Name = "lblinvcom"
        Me.lblinvcom.Size = New System.Drawing.Size(72, 19)
        Me.lblinvcom.TabIndex = 51
        Me.lblinvcom.Text = "Company"
        '
        'Repcompro
        '
        ReportDataSource3.Name = "DScompro"
        ReportDataSource3.Value = Me.RepcomproBindingSource
        Me.Repcompro.LocalReport.DataSources.Add(ReportDataSource3)
        Me.Repcompro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repcompro.rdlc"
        Me.Repcompro.Location = New System.Drawing.Point(369, 85)
        Me.Repcompro.Name = "Repcompro"
        Me.Repcompro.Size = New System.Drawing.Size(701, 322)
        Me.Repcompro.TabIndex = 4
        '
        'Repcominv
        '
        ReportDataSource4.Name = "DScominv"
        ReportDataSource4.Value = Me.RepcominvBindingSource
        Me.Repcominv.LocalReport.DataSources.Add(ReportDataSource4)
        Me.Repcominv.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repcominv.rdlc"
        Me.Repcominv.Location = New System.Drawing.Point(380, 119)
        Me.Repcominv.Name = "Repcominv"
        Me.Repcominv.Size = New System.Drawing.Size(677, 275)
        Me.Repcominv.TabIndex = 5
        '
        'RepcominvBindingSource
        '
        Me.RepcominvBindingSource.DataMember = "Repcominv"
        Me.RepcominvBindingSource.DataSource = Me.Dsreportxsd
        '
        'Dsreportxsd
        '
        Me.Dsreportxsd.DataSetName = "Dsreportxsd"
        Me.Dsreportxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepcomproBindingSource
        '
        Me.RepcomproBindingSource.DataMember = "Repcompro"
        Me.RepcomproBindingSource.DataSource = Me.Dsreportxsd
        '
        'Repinvpro
        '
        ReportDataSource5.Name = "DSinvpro"
        ReportDataSource5.Value = Me.RepinvproBindingSource
        Me.Repinvpro.LocalReport.DataSources.Add(ReportDataSource5)
        Me.Repinvpro.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repinvpro.rdlc"
        Me.Repinvpro.Location = New System.Drawing.Point(396, 154)
        Me.Repinvpro.Name = "Repinvpro"
        Me.Repinvpro.Size = New System.Drawing.Size(645, 231)
        Me.Repinvpro.TabIndex = 6
        '
        'RepinvproBindingSource
        '
        Me.RepinvproBindingSource.DataMember = "Repinvpro"
        Me.RepinvproBindingSource.DataSource = Me.Dsreportxsd
        '
        'Repproduct
        '
        ReportDataSource6.Name = "DSpro"
        ReportDataSource6.Value = Me.BILLPRODUCT_DETAILSBindingSource
        Me.Repproduct.LocalReport.DataSources.Add(ReportDataSource6)
        Me.Repproduct.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Repproduct.rdlc"
        Me.Repproduct.Location = New System.Drawing.Point(413, 185)
        Me.Repproduct.Name = "Repproduct"
        Me.Repproduct.Size = New System.Drawing.Size(601, 188)
        Me.Repproduct.TabIndex = 7
        '
        'DsProduct
        '
        Me.DsProduct.DataSetName = "DsProduct"
        Me.DsProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BILLPRODUCT_DETAILSBindingSource
        '
        Me.BILLPRODUCT_DETAILSBindingSource.DataMember = "BILLPRODUCT_DETAILS"
        Me.BILLPRODUCT_DETAILSBindingSource.DataSource = Me.DsProduct
        '
        'BILLPRODUCT_DETAILSTableAdapter
        '
        Me.BILLPRODUCT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 489)
        Me.Controls.Add(Me.Repproduct)
        Me.Controls.Add(Me.Repinvpro)
        Me.Controls.Add(Me.Repcominv)
        Me.Controls.Add(Me.Repcompro)
        Me.Controls.Add(Me.reppanel)
        Me.Controls.Add(Me.RVcom)
        Me.Controls.Add(Me.RVinvinvdetails)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.BILLINVOICE_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsinvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BILLCOM_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DScom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.reppanel.ResumeLayout(False)
        Me.reppanel.PerformLayout()
        CType(Me.RepcominvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsreportxsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepcomproBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepinvproBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BILLPRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txtvalue As TextBox
    Friend WithEvents BILLINVOICE_DETAILSBindingSource As BindingSource
    Friend WithEvents Dsinvoice As Dsinvoice
    Friend WithEvents BILLINVOICE_DETAILSTableAdapter As DsinvoiceTableAdapters.BILLINVOICE_DETAILSTableAdapter
    Friend WithEvents RVinvinvdetails As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RVcom As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BILLCOM_DETAILSBindingSource As BindingSource
    Friend WithEvents DScom As DScom
    Friend WithEvents BILLCOM_DETAILSTableAdapter As DScomTableAdapters.BILLCOM_DETAILSTableAdapter
    Friend WithEvents reppanel As Panel
    Friend WithEvents btninvcancel As Button
    Friend WithEvents btninvconfirm As Button
    Friend WithEvents lblInvid As Label
    Friend WithEvents cmbinv As ComboBox
    Friend WithEvents cmbcom As ComboBox
    Friend WithEvents lblinvcom As Label
    Friend WithEvents Repcompro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Repcominv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RepcominvBindingSource As BindingSource
    Friend WithEvents Dsreportxsd As Dsreportxsd
    Friend WithEvents RepcomproBindingSource As BindingSource
    Friend WithEvents Repinvpro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RepinvproBindingSource As BindingSource
    Friend WithEvents Repproduct As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BILLPRODUCT_DETAILSBindingSource As BindingSource
    Friend WithEvents DsProduct As DsProduct
    Friend WithEvents BILLPRODUCT_DETAILSTableAdapter As DsProductTableAdapters.BILLPRODUCT_DETAILSTableAdapter
End Class
