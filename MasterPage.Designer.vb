<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterPage))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyDetailsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetailsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDetailsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetailsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDetailsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Loginmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyCompanyDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseCompanyDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseCompanyDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseCompanyAndInvoiceDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyInvoiceAndProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseInvoiceDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseInvoiceAndProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExciseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Pink
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ReportsToolStripMenuItem, Me.ExciseToolStripMenuItem, Me.ImageToolStripMenuItem, Me.OTPToolStripMenuItem, Me.Loginmenu})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Name = "MenuStrip"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        resources.ApplyResources(Me.HomeToolStripMenuItem, "HomeToolStripMenuItem")
        '
        'FileMenu
        '
        Me.FileMenu.BackColor = System.Drawing.Color.Pink
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        resources.ApplyResources(Me.FileMenu, "FileMenu")
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem1, Me.InvoiceToolStripMenuItem1, Me.ProductToolStripMenuItem1})
        resources.ApplyResources(Me.NewToolStripMenuItem, "NewToolStripMenuItem")
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        '
        'CompanyToolStripMenuItem1
        '
        Me.CompanyToolStripMenuItem1.BackColor = System.Drawing.Color.LightSalmon
        Me.CompanyToolStripMenuItem1.Name = "CompanyToolStripMenuItem1"
        resources.ApplyResources(Me.CompanyToolStripMenuItem1, "CompanyToolStripMenuItem1")
        '
        'InvoiceToolStripMenuItem1
        '
        Me.InvoiceToolStripMenuItem1.BackColor = System.Drawing.Color.LightSalmon
        Me.InvoiceToolStripMenuItem1.Name = "InvoiceToolStripMenuItem1"
        resources.ApplyResources(Me.InvoiceToolStripMenuItem1, "InvoiceToolStripMenuItem1")
        '
        'ProductToolStripMenuItem1
        '
        Me.ProductToolStripMenuItem1.BackColor = System.Drawing.Color.LightSalmon
        Me.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1"
        resources.ApplyResources(Me.ProductToolStripMenuItem1, "ProductToolStripMenuItem1")
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyDetailsToolStripMenuItem2, Me.InvoiceDetailsToolStripMenuItem3, Me.ProductDetailsToolStripMenuItem3})
        Me.EditMenu.Name = "EditMenu"
        resources.ApplyResources(Me.EditMenu, "EditMenu")
        '
        'CompanyDetailsToolStripMenuItem2
        '
        Me.CompanyDetailsToolStripMenuItem2.BackColor = System.Drawing.Color.LightSalmon
        Me.CompanyDetailsToolStripMenuItem2.Name = "CompanyDetailsToolStripMenuItem2"
        resources.ApplyResources(Me.CompanyDetailsToolStripMenuItem2, "CompanyDetailsToolStripMenuItem2")
        '
        'InvoiceDetailsToolStripMenuItem3
        '
        Me.InvoiceDetailsToolStripMenuItem3.BackColor = System.Drawing.Color.LightSalmon
        Me.InvoiceDetailsToolStripMenuItem3.Name = "InvoiceDetailsToolStripMenuItem3"
        resources.ApplyResources(Me.InvoiceDetailsToolStripMenuItem3, "InvoiceDetailsToolStripMenuItem3")
        '
        'ProductDetailsToolStripMenuItem3
        '
        Me.ProductDetailsToolStripMenuItem3.BackColor = System.Drawing.Color.LightSalmon
        Me.ProductDetailsToolStripMenuItem3.Name = "ProductDetailsToolStripMenuItem3"
        resources.ApplyResources(Me.ProductDetailsToolStripMenuItem3, "ProductDetailsToolStripMenuItem3")
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyDetailsToolStripMenuItem1, Me.InvoiceDetailsToolStripMenuItem2, Me.ProductDetailsToolStripMenuItem2})
        Me.ViewMenu.Name = "ViewMenu"
        resources.ApplyResources(Me.ViewMenu, "ViewMenu")
        '
        'CompanyDetailsToolStripMenuItem1
        '
        Me.CompanyDetailsToolStripMenuItem1.BackColor = System.Drawing.Color.LightSalmon
        Me.CompanyDetailsToolStripMenuItem1.Name = "CompanyDetailsToolStripMenuItem1"
        resources.ApplyResources(Me.CompanyDetailsToolStripMenuItem1, "CompanyDetailsToolStripMenuItem1")
        '
        'InvoiceDetailsToolStripMenuItem2
        '
        Me.InvoiceDetailsToolStripMenuItem2.BackColor = System.Drawing.Color.LightSalmon
        Me.InvoiceDetailsToolStripMenuItem2.Name = "InvoiceDetailsToolStripMenuItem2"
        resources.ApplyResources(Me.InvoiceDetailsToolStripMenuItem2, "InvoiceDetailsToolStripMenuItem2")
        '
        'ProductDetailsToolStripMenuItem2
        '
        Me.ProductDetailsToolStripMenuItem2.BackColor = System.Drawing.Color.LightSalmon
        Me.ProductDetailsToolStripMenuItem2.Name = "ProductDetailsToolStripMenuItem2"
        resources.ApplyResources(Me.ProductDetailsToolStripMenuItem2, "ProductDetailsToolStripMenuItem2")
        '
        'Loginmenu
        '
        Me.Loginmenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Loginmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.Loginmenu.Margin = New System.Windows.Forms.Padding(0, 0, 70, 0)
        Me.Loginmenu.Name = "Loginmenu"
        resources.ApplyResources(Me.Loginmenu, "Loginmenu")
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        resources.ApplyResources(Me.LogoutToolStripMenuItem, "LogoutToolStripMenuItem")
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.ProductToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        resources.ApplyResources(Me.ReportsToolStripMenuItem, "ReportsToolStripMenuItem")
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon
        Me.CompanyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyDetailsToolStripMenuItem, Me.InvoiceDetailsToolStripMenuItem1, Me.ToolStripMenuItem2, Me.MonthlyCompanyDetailsToolStripMenuItem, Me.DaywiseCompanyDetailsToolStripMenuItem, Me.ToolStripMenuItem1, Me.DaywiseCompanyDetailsToolStripMenuItem1, Me.DaywiseCompanyAndInvoiceDetailsToolStripMenuItem, Me.DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem})
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        resources.ApplyResources(Me.CompanyToolStripMenuItem, "CompanyToolStripMenuItem")
        '
        'CompanyDetailsToolStripMenuItem
        '
        Me.CompanyDetailsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.CompanyDetailsToolStripMenuItem.Name = "CompanyDetailsToolStripMenuItem"
        resources.ApplyResources(Me.CompanyDetailsToolStripMenuItem, "CompanyDetailsToolStripMenuItem")
        '
        'InvoiceDetailsToolStripMenuItem1
        '
        Me.InvoiceDetailsToolStripMenuItem1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.InvoiceDetailsToolStripMenuItem1.Name = "InvoiceDetailsToolStripMenuItem1"
        resources.ApplyResources(Me.InvoiceDetailsToolStripMenuItem1, "InvoiceDetailsToolStripMenuItem1")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'MonthlyCompanyDetailsToolStripMenuItem
        '
        Me.MonthlyCompanyDetailsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MonthlyCompanyDetailsToolStripMenuItem.Name = "MonthlyCompanyDetailsToolStripMenuItem"
        resources.ApplyResources(Me.MonthlyCompanyDetailsToolStripMenuItem, "MonthlyCompanyDetailsToolStripMenuItem")
        '
        'DaywiseCompanyDetailsToolStripMenuItem
        '
        Me.DaywiseCompanyDetailsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.DaywiseCompanyDetailsToolStripMenuItem.Name = "DaywiseCompanyDetailsToolStripMenuItem"
        resources.ApplyResources(Me.DaywiseCompanyDetailsToolStripMenuItem, "DaywiseCompanyDetailsToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'DaywiseCompanyDetailsToolStripMenuItem1
        '
        Me.DaywiseCompanyDetailsToolStripMenuItem1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.DaywiseCompanyDetailsToolStripMenuItem1.Name = "DaywiseCompanyDetailsToolStripMenuItem1"
        resources.ApplyResources(Me.DaywiseCompanyDetailsToolStripMenuItem1, "DaywiseCompanyDetailsToolStripMenuItem1")
        '
        'DaywiseCompanyAndInvoiceDetailsToolStripMenuItem
        '
        Me.DaywiseCompanyAndInvoiceDetailsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.DaywiseCompanyAndInvoiceDetailsToolStripMenuItem.Name = "DaywiseCompanyAndInvoiceDetailsToolStripMenuItem"
        resources.ApplyResources(Me.DaywiseCompanyAndInvoiceDetailsToolStripMenuItem, "DaywiseCompanyAndInvoiceDetailsToolStripMenuItem")
        '
        'DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem
        '
        Me.DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem.Name = "DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem"
        resources.ApplyResources(Me.DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem, "DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem")
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon
        Me.InvoiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceDetailsToolStripMenuItem, Me.ProductDetailsToolStripMenuItem1, Me.MonthlyInvoiceToolStripMenuItem, Me.MonthlyInvoiceAndProductDetailsToolStripMenuItem, Me.DaywiseInvoiceDetailsToolStripMenuItem, Me.DaywiseInvoiceAndProductDetailsToolStripMenuItem})
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        resources.ApplyResources(Me.InvoiceToolStripMenuItem, "InvoiceToolStripMenuItem")
        '
        'InvoiceDetailsToolStripMenuItem
        '
        Me.InvoiceDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.InvoiceDetailsToolStripMenuItem.Name = "InvoiceDetailsToolStripMenuItem"
        resources.ApplyResources(Me.InvoiceDetailsToolStripMenuItem, "InvoiceDetailsToolStripMenuItem")
        '
        'ProductDetailsToolStripMenuItem1
        '
        Me.ProductDetailsToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ProductDetailsToolStripMenuItem1.Name = "ProductDetailsToolStripMenuItem1"
        resources.ApplyResources(Me.ProductDetailsToolStripMenuItem1, "ProductDetailsToolStripMenuItem1")
        '
        'MonthlyInvoiceToolStripMenuItem
        '
        Me.MonthlyInvoiceToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MonthlyInvoiceToolStripMenuItem.Name = "MonthlyInvoiceToolStripMenuItem"
        resources.ApplyResources(Me.MonthlyInvoiceToolStripMenuItem, "MonthlyInvoiceToolStripMenuItem")
        '
        'MonthlyInvoiceAndProductDetailsToolStripMenuItem
        '
        Me.MonthlyInvoiceAndProductDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MonthlyInvoiceAndProductDetailsToolStripMenuItem.Name = "MonthlyInvoiceAndProductDetailsToolStripMenuItem"
        resources.ApplyResources(Me.MonthlyInvoiceAndProductDetailsToolStripMenuItem, "MonthlyInvoiceAndProductDetailsToolStripMenuItem")
        '
        'DaywiseInvoiceDetailsToolStripMenuItem
        '
        Me.DaywiseInvoiceDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DaywiseInvoiceDetailsToolStripMenuItem.Name = "DaywiseInvoiceDetailsToolStripMenuItem"
        resources.ApplyResources(Me.DaywiseInvoiceDetailsToolStripMenuItem, "DaywiseInvoiceDetailsToolStripMenuItem")
        '
        'DaywiseInvoiceAndProductDetailsToolStripMenuItem
        '
        Me.DaywiseInvoiceAndProductDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DaywiseInvoiceAndProductDetailsToolStripMenuItem.Name = "DaywiseInvoiceAndProductDetailsToolStripMenuItem"
        resources.ApplyResources(Me.DaywiseInvoiceAndProductDetailsToolStripMenuItem, "DaywiseInvoiceAndProductDetailsToolStripMenuItem")
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductDetailsToolStripMenuItem, Me.MonthlyProductDetailsToolStripMenuItem, Me.DaywiseProductDetailsToolStripMenuItem})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        resources.ApplyResources(Me.ProductToolStripMenuItem, "ProductToolStripMenuItem")
        '
        'ProductDetailsToolStripMenuItem
        '
        Me.ProductDetailsToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue
        Me.ProductDetailsToolStripMenuItem.Name = "ProductDetailsToolStripMenuItem"
        resources.ApplyResources(Me.ProductDetailsToolStripMenuItem, "ProductDetailsToolStripMenuItem")
        '
        'MonthlyProductDetailsToolStripMenuItem
        '
        Me.MonthlyProductDetailsToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue
        Me.MonthlyProductDetailsToolStripMenuItem.Name = "MonthlyProductDetailsToolStripMenuItem"
        resources.ApplyResources(Me.MonthlyProductDetailsToolStripMenuItem, "MonthlyProductDetailsToolStripMenuItem")
        '
        'DaywiseProductDetailsToolStripMenuItem
        '
        Me.DaywiseProductDetailsToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue
        Me.DaywiseProductDetailsToolStripMenuItem.Name = "DaywiseProductDetailsToolStripMenuItem"
        resources.ApplyResources(Me.DaywiseProductDetailsToolStripMenuItem, "DaywiseProductDetailsToolStripMenuItem")
        '
        'ExciseToolStripMenuItem
        '
        Me.ExciseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem2, Me.InvoiceToolStripMenuItem2, Me.ProductToolStripMenuItem2})
        Me.ExciseToolStripMenuItem.Name = "ExciseToolStripMenuItem"
        resources.ApplyResources(Me.ExciseToolStripMenuItem, "ExciseToolStripMenuItem")
        '
        'CompanyToolStripMenuItem2
        '
        Me.CompanyToolStripMenuItem2.BackColor = System.Drawing.Color.Red
        Me.CompanyToolStripMenuItem2.Name = "CompanyToolStripMenuItem2"
        resources.ApplyResources(Me.CompanyToolStripMenuItem2, "CompanyToolStripMenuItem2")
        '
        'InvoiceToolStripMenuItem2
        '
        Me.InvoiceToolStripMenuItem2.BackColor = System.Drawing.Color.Red
        Me.InvoiceToolStripMenuItem2.Name = "InvoiceToolStripMenuItem2"
        resources.ApplyResources(Me.InvoiceToolStripMenuItem2, "InvoiceToolStripMenuItem2")
        '
        'ProductToolStripMenuItem2
        '
        Me.ProductToolStripMenuItem2.BackColor = System.Drawing.Color.Red
        Me.ProductToolStripMenuItem2.Name = "ProductToolStripMenuItem2"
        resources.ApplyResources(Me.ProductToolStripMenuItem2, "ProductToolStripMenuItem2")
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        resources.ApplyResources(Me.ImageToolStripMenuItem, "ImageToolStripMenuItem")
        '
        'OTPToolStripMenuItem
        '
        Me.OTPToolStripMenuItem.Name = "OTPToolStripMenuItem"
        resources.ApplyResources(Me.OTPToolStripMenuItem, "OTPToolStripMenuItem")
        '
        'MasterPage
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MasterPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Loginmenu As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaywiseProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductDetailsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MonthlyInvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyInvoiceAndProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaywiseInvoiceDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaywiseInvoiceAndProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyDetailsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceDetailsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductDetailsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CompanyDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceDetailsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MonthlyCompanyDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaywiseCompanyDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CompanyDetailsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InvoiceDetailsToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ProductDetailsToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DaywiseCompanyDetailsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DaywiseCompanyAndInvoiceDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExciseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OTPToolStripMenuItem As ToolStripMenuItem
End Class
