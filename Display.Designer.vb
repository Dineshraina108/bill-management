<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
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
        Dim GridViewBrowseColumn1 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn2 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn3 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn4 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim SortDescriptor2 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewBrowseColumn5 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn6 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn7 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn8 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn9 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn10 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn11 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim SortDescriptor3 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim SortDescriptor4 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewBrowseColumn12 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn13 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn14 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn15 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn16 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn17 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn18 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn19 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim SortDescriptor5 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim SortDescriptor6 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RGVcom = New Telerik.WinControls.UI.RadGridView()
        Me.RGVinv = New Telerik.WinControls.UI.RadGridView()
        Me.RGVpro = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RGVcom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVcom.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVinv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVinv.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVpro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVpro.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RGVcom
        '
        Me.RGVcom.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RGVcom.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVcom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVcom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVcom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVcom.Location = New System.Drawing.Point(23, 12)
        '
        '
        '
        Me.RGVcom.MasterTemplate.AllowAddNewRow = False
        Me.RGVcom.MasterTemplate.AllowColumnReorder = False
        GridViewBrowseColumn1.EnableExpressionEditor = False
        GridViewBrowseColumn1.FieldName = "COMID"
        GridViewBrowseColumn1.HeaderText = "COMPANY ID"
        GridViewBrowseColumn1.Name = "COMPANY ID"
        GridViewBrowseColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewBrowseColumn1.Width = 108
        GridViewBrowseColumn2.EnableExpressionEditor = False
        GridViewBrowseColumn2.FieldName = "CRDATE"
        GridViewBrowseColumn2.HeaderText = "CREATION DATE"
        GridViewBrowseColumn2.Name = "CREATION DATE"
        GridViewBrowseColumn2.Width = 124
        GridViewBrowseColumn3.EnableExpressionEditor = False
        GridViewBrowseColumn3.FieldName = "COMNAME"
        GridViewBrowseColumn3.HeaderText = "COMPANY NAME"
        GridViewBrowseColumn3.Name = "COMPANY NAME"
        GridViewBrowseColumn3.Width = 158
        GridViewBrowseColumn4.EnableExpressionEditor = False
        GridViewBrowseColumn4.FieldName = "COMADDR"
        GridViewBrowseColumn4.HeaderText = "COMPANY ADDRESS "
        GridViewBrowseColumn4.Name = "COMPANY ADDRESS"
        GridViewBrowseColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewBrowseColumn4.Width = 248
        Me.RGVcom.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn1, GridViewBrowseColumn2, GridViewBrowseColumn3, GridViewBrowseColumn4})
        SortDescriptor1.PropertyName = "COMPANY ID"
        SortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor2.PropertyName = "COMPANY ADDRESS"
        Me.RGVcom.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1, SortDescriptor2})
        Me.RGVcom.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVcom.Name = "RGVcom"
        Me.RGVcom.ReadOnly = True
        Me.RGVcom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVcom.Size = New System.Drawing.Size(662, 166)
        Me.RGVcom.TabIndex = 0
        '
        'RGVinv
        '
        Me.RGVinv.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RGVinv.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVinv.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVinv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVinv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVinv.Location = New System.Drawing.Point(23, 184)
        '
        '
        '
        Me.RGVinv.MasterTemplate.AllowAddNewRow = False
        Me.RGVinv.MasterTemplate.AllowColumnReorder = False
        GridViewBrowseColumn5.EnableExpressionEditor = False
        GridViewBrowseColumn5.FieldName = "COMID_FK"
        GridViewBrowseColumn5.HeaderText = "COM ID"
        GridViewBrowseColumn5.Name = "COM ID"
        GridViewBrowseColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewBrowseColumn5.Width = 66
        GridViewBrowseColumn6.EnableExpressionEditor = False
        GridViewBrowseColumn6.FieldName = "INVID"
        GridViewBrowseColumn6.HeaderText = "INV ID"
        GridViewBrowseColumn6.Name = "INVID"
        GridViewBrowseColumn6.Width = 80
        GridViewBrowseColumn7.EnableExpressionEditor = False
        GridViewBrowseColumn7.FieldName = "INVNO"
        GridViewBrowseColumn7.HeaderText = "INV NO"
        GridViewBrowseColumn7.Name = "INVNO"
        GridViewBrowseColumn7.Width = 72
        GridViewBrowseColumn8.EnableExpressionEditor = False
        GridViewBrowseColumn8.FieldName = "INVDATE"
        GridViewBrowseColumn8.HeaderText = "INV DATE"
        GridViewBrowseColumn8.Name = "INVDATE"
        GridViewBrowseColumn8.Width = 109
        GridViewBrowseColumn9.EnableExpressionEditor = False
        GridViewBrowseColumn9.FieldName = "SERIAL"
        GridViewBrowseColumn9.HeaderText = "SERIAL"
        GridViewBrowseColumn9.Name = "SERIAL"
        GridViewBrowseColumn9.Width = 56
        GridViewBrowseColumn10.EnableExpressionEditor = False
        GridViewBrowseColumn10.FieldName = "INVLOCATION"
        GridViewBrowseColumn10.HeaderText = "INV LOCATION"
        GridViewBrowseColumn10.Name = "INVLOCATION "
        GridViewBrowseColumn10.Width = 150
        GridViewBrowseColumn11.EnableExpressionEditor = False
        GridViewBrowseColumn11.FieldName = "CHALANNO"
        GridViewBrowseColumn11.HeaderText = "CHALAN NO"
        GridViewBrowseColumn11.Name = "CHALANNO "
        GridViewBrowseColumn11.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewBrowseColumn11.Width = 107
        Me.RGVinv.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn5, GridViewBrowseColumn6, GridViewBrowseColumn7, GridViewBrowseColumn8, GridViewBrowseColumn9, GridViewBrowseColumn10, GridViewBrowseColumn11})
        SortDescriptor3.PropertyName = "COM ID"
        SortDescriptor4.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor4.PropertyName = "CHALANNO "
        Me.RGVinv.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor3, SortDescriptor4})
        Me.RGVinv.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RGVinv.Name = "RGVinv"
        Me.RGVinv.ReadOnly = True
        Me.RGVinv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVinv.Size = New System.Drawing.Size(662, 164)
        Me.RGVinv.TabIndex = 1
        '
        'RGVpro
        '
        Me.RGVpro.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RGVpro.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVpro.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVpro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVpro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVpro.Location = New System.Drawing.Point(23, 354)
        '
        '
        '
        Me.RGVpro.MasterTemplate.AllowAddNewRow = False
        Me.RGVpro.MasterTemplate.AllowColumnReorder = False
        GridViewBrowseColumn12.EnableExpressionEditor = False
        GridViewBrowseColumn12.FieldName = "COMID_FK"
        GridViewBrowseColumn12.HeaderText = "COMID_FK"
        GridViewBrowseColumn12.Name = "COMID"
        GridViewBrowseColumn12.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewBrowseColumn12.Width = 65
        GridViewBrowseColumn13.EnableExpressionEditor = False
        GridViewBrowseColumn13.FieldName = "INVNO_FK"
        GridViewBrowseColumn13.HeaderText = "INVOICE NO"
        GridViewBrowseColumn13.Name = "INVNO_FK"
        GridViewBrowseColumn13.Width = 84
        GridViewBrowseColumn14.EnableExpressionEditor = False
        GridViewBrowseColumn14.FieldName = "PRID"
        GridViewBrowseColumn14.HeaderText = "PRODUCT ID"
        GridViewBrowseColumn14.Name = "PRID"
        GridViewBrowseColumn14.Width = 104
        GridViewBrowseColumn15.EnableExpressionEditor = False
        GridViewBrowseColumn15.FieldName = "PRCRDATE"
        GridViewBrowseColumn15.HeaderText = "PR CR DATE"
        GridViewBrowseColumn15.Name = "PRCRDATE "
        GridViewBrowseColumn15.Width = 91
        GridViewBrowseColumn16.EnableExpressionEditor = False
        GridViewBrowseColumn16.FieldName = "PRNAME "
        GridViewBrowseColumn16.HeaderText = "PR NAME"
        GridViewBrowseColumn16.Name = "PRNAME"
        GridViewBrowseColumn16.Width = 97
        GridViewBrowseColumn17.EnableExpressionEditor = False
        GridViewBrowseColumn17.FieldName = "PRQTY"
        GridViewBrowseColumn17.HeaderText = "PR QTY"
        GridViewBrowseColumn17.Name = "PRQTY"
        GridViewBrowseColumn17.Width = 54
        GridViewBrowseColumn18.EnableExpressionEditor = False
        GridViewBrowseColumn18.FieldName = "PRRATE"
        GridViewBrowseColumn18.HeaderText = "PR RATE"
        GridViewBrowseColumn18.Name = "PRRATE"
        GridViewBrowseColumn18.Width = 61
        GridViewBrowseColumn19.EnableExpressionEditor = False
        GridViewBrowseColumn19.FieldName = "PRAMOUNT"
        GridViewBrowseColumn19.HeaderText = "PR AMOUNT"
        GridViewBrowseColumn19.Name = "PRAMOUNT"
        GridViewBrowseColumn19.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewBrowseColumn19.Width = 87
        Me.RGVpro.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn12, GridViewBrowseColumn13, GridViewBrowseColumn14, GridViewBrowseColumn15, GridViewBrowseColumn16, GridViewBrowseColumn17, GridViewBrowseColumn18, GridViewBrowseColumn19})
        SortDescriptor5.PropertyName = "COMID"
        SortDescriptor6.PropertyName = "PRAMOUNT"
        Me.RGVpro.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor5, SortDescriptor6})
        Me.RGVpro.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RGVpro.Name = "RGVpro"
        Me.RGVpro.ReadOnly = True
        Me.RGVpro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVpro.Size = New System.Drawing.Size(662, 157)
        Me.RGVpro.TabIndex = 2
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(697, 514)
        Me.Controls.Add(Me.RGVpro)
        Me.Controls.Add(Me.RGVcom)
        Me.Controls.Add(Me.RGVinv)
        Me.Name = "Display"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display"
        CType(Me.RGVcom.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVcom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVinv.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVinv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVpro.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RGVcom As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RGVinv As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RGVpro As Telerik.WinControls.UI.RadGridView
End Class
