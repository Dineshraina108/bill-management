<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillForm))
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.BIllHomepanel = New System.Windows.Forms.Panel()
        Me.prpanel1 = New System.Windows.Forms.Panel()
        Me.Billactbuttonpanel = New System.Windows.Forms.Panel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Chksave = New System.Windows.Forms.CheckBox()
        Me.Billproductpanel = New System.Windows.Forms.Panel()
        Me.lblamt = New System.Windows.Forms.Label()
        Me.lbltotalamout = New System.Windows.Forms.Label()
        Me.lblamoutinwords = New System.Windows.Forms.Label()
        Me.RGVbill = New Telerik.WinControls.UI.RadGridView()
        Me.Billdetailspanel1 = New System.Windows.Forms.Panel()
        Me.txtbilldate = New System.Windows.Forms.TextBox()
        Me.lblbilldate = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.lblBillno = New System.Windows.Forms.Label()
        Me.btnproduct = New System.Windows.Forms.Button()
        Me.txtchano = New System.Windows.Forms.TextBox()
        Me.lblchno = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.lblloc = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.lblserial = New System.Windows.Forms.Label()
        Me.txtinvdate = New System.Windows.Forms.TextBox()
        Me.lblinvdate = New System.Windows.Forms.Label()
        Me.txtinvno = New System.Windows.Forms.TextBox()
        Me.lblInvoiceno = New System.Windows.Forms.Label()
        Me.txtcomaddr = New System.Windows.Forms.TextBox()
        Me.lblcomaddr = New System.Windows.Forms.Label()
        Me.txtcomname = New System.Windows.Forms.TextBox()
        Me.lblcom = New System.Windows.Forms.Label()
        Me.Billselpanel = New System.Windows.Forms.Panel()
        Me.btnbill = New System.Windows.Forms.Button()
        Me.CBinv = New System.Windows.Forms.ComboBox()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.CBcom = New System.Windows.Forms.ComboBox()
        Me.lblcomname = New System.Windows.Forms.Label()
        Me.BIllHomepanel.SuspendLayout()
        Me.prpanel1.SuspendLayout()
        Me.Billactbuttonpanel.SuspendLayout()
        Me.Billproductpanel.SuspendLayout()
        CType(Me.RGVbill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVbill.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Billdetailspanel1.SuspendLayout()
        Me.Billselpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BIllHomepanel
        '
        Me.BIllHomepanel.Controls.Add(Me.prpanel1)
        Me.BIllHomepanel.Controls.Add(Me.Billdetailspanel1)
        Me.BIllHomepanel.Controls.Add(Me.Billselpanel)
        resources.ApplyResources(Me.BIllHomepanel, "BIllHomepanel")
        Me.BIllHomepanel.Name = "BIllHomepanel"
        '
        'prpanel1
        '
        Me.prpanel1.Controls.Add(Me.Billactbuttonpanel)
        Me.prpanel1.Controls.Add(Me.Billproductpanel)
        resources.ApplyResources(Me.prpanel1, "prpanel1")
        Me.prpanel1.Name = "prpanel1"
        '
        'Billactbuttonpanel
        '
        Me.Billactbuttonpanel.Controls.Add(Me.btnclear)
        Me.Billactbuttonpanel.Controls.Add(Me.btndel)
        Me.Billactbuttonpanel.Controls.Add(Me.btnPrint)
        Me.Billactbuttonpanel.Controls.Add(Me.btnsave)
        Me.Billactbuttonpanel.Controls.Add(Me.btnNew)
        Me.Billactbuttonpanel.Controls.Add(Me.Chksave)
        resources.ApplyResources(Me.Billactbuttonpanel, "Billactbuttonpanel")
        Me.Billactbuttonpanel.Name = "Billactbuttonpanel"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnclear, "btnclear")
        Me.btnclear.Name = "btnclear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btndel, "btndel")
        Me.btndel.Name = "btndel"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnPrint, "btnPrint")
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnsave, "btnsave")
        Me.btnsave.Name = "btnsave"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnNew, "btnNew")
        Me.btnNew.Name = "btnNew"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Chksave
        '
        resources.ApplyResources(Me.Chksave, "Chksave")
        Me.Chksave.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Chksave.Name = "Chksave"
        Me.Chksave.UseVisualStyleBackColor = False
        '
        'Billproductpanel
        '
        Me.Billproductpanel.Controls.Add(Me.lblamt)
        Me.Billproductpanel.Controls.Add(Me.lbltotalamout)
        Me.Billproductpanel.Controls.Add(Me.lblamoutinwords)
        Me.Billproductpanel.Controls.Add(Me.RGVbill)
        resources.ApplyResources(Me.Billproductpanel, "Billproductpanel")
        Me.Billproductpanel.Name = "Billproductpanel"
        '
        'lblamt
        '
        resources.ApplyResources(Me.lblamt, "lblamt")
        Me.lblamt.Name = "lblamt"
        '
        'lbltotalamout
        '
        resources.ApplyResources(Me.lbltotalamout, "lbltotalamout")
        Me.lbltotalamout.Name = "lbltotalamout"
        '
        'lblamoutinwords
        '
        resources.ApplyResources(Me.lblamoutinwords, "lblamoutinwords")
        Me.lblamoutinwords.Name = "lblamoutinwords"
        '
        'RGVbill
        '
        Me.RGVbill.BackColor = System.Drawing.Color.PapayaWhip
        Me.RGVbill.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.RGVbill, "RGVbill")
        Me.RGVbill.ForeColor = System.Drawing.SystemColors.ControlText
        '
        '
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "PRID"
        resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
        GridViewTextBoxColumn1.Name = "PRODUCT ID"
        GridViewTextBoxColumn1.Width = 82
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "PRNAME"
        resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
        GridViewTextBoxColumn2.Name = "PRODUCT NAME"
        GridViewTextBoxColumn2.Width = 196
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "PRQTY"
        resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
        GridViewTextBoxColumn3.Name = "QUANTITY"
        GridViewTextBoxColumn3.Width = 99
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "PRRATE"
        resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
        GridViewTextBoxColumn4.Name = "RATE"
        GridViewTextBoxColumn4.Width = 93
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "PRAMOUNT"
        resources.ApplyResources(GridViewTextBoxColumn5, "GridViewTextBoxColumn5")
        GridViewTextBoxColumn5.Name = "AMOUNT"
        GridViewTextBoxColumn5.Width = 119
        Me.RGVbill.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.RGVbill.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVbill.Name = "RGVbill"
        '
        'Billdetailspanel1
        '
        Me.Billdetailspanel1.Controls.Add(Me.txtbilldate)
        Me.Billdetailspanel1.Controls.Add(Me.lblbilldate)
        Me.Billdetailspanel1.Controls.Add(Me.txtbillno)
        Me.Billdetailspanel1.Controls.Add(Me.lblBillno)
        Me.Billdetailspanel1.Controls.Add(Me.btnproduct)
        Me.Billdetailspanel1.Controls.Add(Me.txtchano)
        Me.Billdetailspanel1.Controls.Add(Me.lblchno)
        Me.Billdetailspanel1.Controls.Add(Me.txtlocation)
        Me.Billdetailspanel1.Controls.Add(Me.lblloc)
        Me.Billdetailspanel1.Controls.Add(Me.txtserial)
        Me.Billdetailspanel1.Controls.Add(Me.lblserial)
        Me.Billdetailspanel1.Controls.Add(Me.txtinvdate)
        Me.Billdetailspanel1.Controls.Add(Me.lblinvdate)
        Me.Billdetailspanel1.Controls.Add(Me.txtinvno)
        Me.Billdetailspanel1.Controls.Add(Me.lblInvoiceno)
        Me.Billdetailspanel1.Controls.Add(Me.txtcomaddr)
        Me.Billdetailspanel1.Controls.Add(Me.lblcomaddr)
        Me.Billdetailspanel1.Controls.Add(Me.txtcomname)
        Me.Billdetailspanel1.Controls.Add(Me.lblcom)
        resources.ApplyResources(Me.Billdetailspanel1, "Billdetailspanel1")
        Me.Billdetailspanel1.Name = "Billdetailspanel1"
        '
        'txtbilldate
        '
        resources.ApplyResources(Me.txtbilldate, "txtbilldate")
        Me.txtbilldate.Name = "txtbilldate"
        '
        'lblbilldate
        '
        resources.ApplyResources(Me.lblbilldate, "lblbilldate")
        Me.lblbilldate.Name = "lblbilldate"
        '
        'txtbillno
        '
        resources.ApplyResources(Me.txtbillno, "txtbillno")
        Me.txtbillno.Name = "txtbillno"
        '
        'lblBillno
        '
        resources.ApplyResources(Me.lblBillno, "lblBillno")
        Me.lblBillno.Name = "lblBillno"
        '
        'btnproduct
        '
        Me.btnproduct.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnproduct, "btnproduct")
        Me.btnproduct.Name = "btnproduct"
        Me.btnproduct.UseVisualStyleBackColor = False
        '
        'txtchano
        '
        resources.ApplyResources(Me.txtchano, "txtchano")
        Me.txtchano.Name = "txtchano"
        '
        'lblchno
        '
        resources.ApplyResources(Me.lblchno, "lblchno")
        Me.lblchno.Name = "lblchno"
        '
        'txtlocation
        '
        resources.ApplyResources(Me.txtlocation, "txtlocation")
        Me.txtlocation.Name = "txtlocation"
        '
        'lblloc
        '
        resources.ApplyResources(Me.lblloc, "lblloc")
        Me.lblloc.Name = "lblloc"
        '
        'txtserial
        '
        resources.ApplyResources(Me.txtserial, "txtserial")
        Me.txtserial.Name = "txtserial"
        '
        'lblserial
        '
        resources.ApplyResources(Me.lblserial, "lblserial")
        Me.lblserial.Name = "lblserial"
        '
        'txtinvdate
        '
        resources.ApplyResources(Me.txtinvdate, "txtinvdate")
        Me.txtinvdate.Name = "txtinvdate"
        '
        'lblinvdate
        '
        resources.ApplyResources(Me.lblinvdate, "lblinvdate")
        Me.lblinvdate.Name = "lblinvdate"
        '
        'txtinvno
        '
        resources.ApplyResources(Me.txtinvno, "txtinvno")
        Me.txtinvno.Name = "txtinvno"
        '
        'lblInvoiceno
        '
        resources.ApplyResources(Me.lblInvoiceno, "lblInvoiceno")
        Me.lblInvoiceno.Name = "lblInvoiceno"
        '
        'txtcomaddr
        '
        resources.ApplyResources(Me.txtcomaddr, "txtcomaddr")
        Me.txtcomaddr.Name = "txtcomaddr"
        '
        'lblcomaddr
        '
        resources.ApplyResources(Me.lblcomaddr, "lblcomaddr")
        Me.lblcomaddr.Name = "lblcomaddr"
        '
        'txtcomname
        '
        resources.ApplyResources(Me.txtcomname, "txtcomname")
        Me.txtcomname.Name = "txtcomname"
        '
        'lblcom
        '
        resources.ApplyResources(Me.lblcom, "lblcom")
        Me.lblcom.Name = "lblcom"
        '
        'Billselpanel
        '
        Me.Billselpanel.Controls.Add(Me.btnbill)
        Me.Billselpanel.Controls.Add(Me.CBinv)
        Me.Billselpanel.Controls.Add(Me.lblinvno)
        Me.Billselpanel.Controls.Add(Me.CBcom)
        Me.Billselpanel.Controls.Add(Me.lblcomname)
        resources.ApplyResources(Me.Billselpanel, "Billselpanel")
        Me.Billselpanel.Name = "Billselpanel"
        '
        'btnbill
        '
        Me.btnbill.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnbill, "btnbill")
        Me.btnbill.Name = "btnbill"
        Me.btnbill.UseVisualStyleBackColor = False
        '
        'CBinv
        '
        Me.CBinv.FormattingEnabled = True
        resources.ApplyResources(Me.CBinv, "CBinv")
        Me.CBinv.Name = "CBinv"
        '
        'lblinvno
        '
        resources.ApplyResources(Me.lblinvno, "lblinvno")
        Me.lblinvno.Name = "lblinvno"
        '
        'CBcom
        '
        Me.CBcom.FormattingEnabled = True
        resources.ApplyResources(Me.CBcom, "CBcom")
        Me.CBcom.Name = "CBcom"
        '
        'lblcomname
        '
        resources.ApplyResources(Me.lblcomname, "lblcomname")
        Me.lblcomname.Name = "lblcomname"
        '
        'BillForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.Controls.Add(Me.BIllHomepanel)
        Me.IsMdiContainer = True
        Me.Name = "BillForm"
        Me.BIllHomepanel.ResumeLayout(False)
        Me.prpanel1.ResumeLayout(False)
        Me.Billactbuttonpanel.ResumeLayout(False)
        Me.Billactbuttonpanel.PerformLayout()
        Me.Billproductpanel.ResumeLayout(False)
        Me.Billproductpanel.PerformLayout()
        CType(Me.RGVbill.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Billdetailspanel1.ResumeLayout(False)
        Me.Billdetailspanel1.PerformLayout()
        Me.Billselpanel.ResumeLayout(False)
        Me.Billselpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BIllHomepanel As Panel
    Friend WithEvents Billdetailspanel1 As Panel
    Friend WithEvents txtbilldate As TextBox
    Friend WithEvents lblbilldate As Label
    Friend WithEvents txtbillno As TextBox
    Friend WithEvents lblBillno As Label
    Friend WithEvents btnproduct As Button
    Friend WithEvents txtchano As TextBox
    Friend WithEvents lblchno As Label
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents lblloc As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents lblserial As Label
    Friend WithEvents txtinvdate As TextBox
    Friend WithEvents lblinvdate As Label
    Friend WithEvents txtinvno As TextBox
    Friend WithEvents lblInvoiceno As Label
    Friend WithEvents txtcomaddr As TextBox
    Friend WithEvents lblcomaddr As Label
    Friend WithEvents txtcomname As TextBox
    Friend WithEvents lblcom As Label
    Friend WithEvents Billselpanel As Panel
    Friend WithEvents btnbill As Button
    Friend WithEvents CBinv As ComboBox
    Friend WithEvents lblinvno As Label
    Friend WithEvents CBcom As ComboBox
    Friend WithEvents lblcomname As Label
    Friend WithEvents prpanel1 As Panel
    Friend WithEvents Billactbuttonpanel As Panel
    Friend WithEvents btnclear As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Chksave As CheckBox
    Friend WithEvents Billproductpanel As Panel
    Friend WithEvents lblamt As Label
    Friend WithEvents lbltotalamout As Label
    Friend WithEvents lblamoutinwords As Label
    Friend WithEvents RGVbill As Telerik.WinControls.UI.RadGridView
End Class
