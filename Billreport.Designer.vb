<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billreport
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
        Me.BILLPRODUCT_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduct = New BILL_SYSTEM.DsProduct()
        Me.rvbill = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BILLPRODUCT_DETAILSTableAdapter = New BILL_SYSTEM.DsProductTableAdapters.BILLPRODUCT_DETAILSTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.billdsxsd = New BILL_SYSTEM.billdsxsd()
        Me.Bill_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BILLPRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billdsxsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bill_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BILLPRODUCT_DETAILSBindingSource
        '
        Me.BILLPRODUCT_DETAILSBindingSource.DataMember = "BILLPRODUCT_DETAILS"
        Me.BILLPRODUCT_DETAILSBindingSource.DataSource = Me.DsProduct
        '
        'DsProduct
        '
        Me.DsProduct.DataSetName = "DsProduct"
        Me.DsProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvbill
        '
        ReportDataSource1.Name = "Dspro"
        ReportDataSource1.Value = Me.BILLPRODUCT_DETAILSBindingSource
        ReportDataSource2.Name = "Dsbill"
        ReportDataSource2.Value = Me.Bill_DetailsBindingSource
        Me.rvbill.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvbill.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvbill.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Billrep.rdlc"
        Me.rvbill.Location = New System.Drawing.Point(14, 13)
        Me.rvbill.Name = "rvbill"
        Me.rvbill.Size = New System.Drawing.Size(767, 433)
        Me.rvbill.TabIndex = 0
        '
        'BILLPRODUCT_DETAILSTableAdapter
        '
        Me.BILLPRODUCT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource3.Name = "Dspro"
        ReportDataSource3.Value = Nothing
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "BILL_SYSTEM.Billrep.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(993, 423)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(767, 433)
        Me.ReportViewer2.TabIndex = 0
        '
        'billdsxsd
        '
        Me.billdsxsd.DataSetName = "billdsxsd"
        Me.billdsxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bill_DetailsBindingSource
        '
        Me.Bill_DetailsBindingSource.DataMember = "Bill_Details"
        Me.Bill_DetailsBindingSource.DataSource = Me.billdsxsd
        '
        'Billreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 458)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.rvbill)
        Me.IsMdiContainer = True
        Me.Name = "Billreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billreport"
        CType(Me.BILLPRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billdsxsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bill_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvbill As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BILLPRODUCT_DETAILSBindingSource As BindingSource
    Friend WithEvents DsProduct As DsProduct
    Friend WithEvents BILLPRODUCT_DETAILSTableAdapter As DsProductTableAdapters.BILLPRODUCT_DETAILSTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Bill_DetailsBindingSource As BindingSource
    Friend WithEvents billdsxsd As billdsxsd
End Class
