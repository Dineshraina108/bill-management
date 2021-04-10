Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports Oracle.DataAccess.Client
Imports System.Text
Imports BILL_SYSTEM.DsinvoiceTableAdapters

Public Class MasterPage
    Dim query As String
    Public Shared Menuname As String
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MasterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.MdiParent = Me
        Home.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Me.Close()
        Application.Exit()
    End Sub

    Private Sub DaywiseProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseProductDetailsToolStripMenuItem.Click
        Menuname = "Daywise Product Details"
        DaywiseRep.MdiParent = Me
        DaywiseRep.Show()
    End Sub

    Private Sub DaywiseInvoiceAndProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseInvoiceAndProductDetailsToolStripMenuItem.Click
        Menuname = "Daywise Invoice and Product Details"
        DaywiseRep.MdiParent = Me
        DaywiseRep.Show()
    End Sub

    Private Sub DaywiseInvoiceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseInvoiceDetailsToolStripMenuItem.Click
        Menuname = "Daywise Invoice Details"
        DaywiseRep.MdiParent = Me
        DaywiseRep.Show()
    End Sub

    Private Sub DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseCompanyAndInvoiceAndProductDetailsToolStripMenuItem.Click
        Menuname = "Daywise Company and Invoice and Product Details"
        DaywiseRep.MdiParent = Me
        DaywiseRep.Show()
    End Sub

    Private Sub DaywiseCompanyAndInvoiceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseCompanyAndInvoiceDetailsToolStripMenuItem.Click
        Menuname = "Daywise Company and Invoice Details"
        DaywiseRep.MdiParent = Me
        DaywiseRep.Show()
    End Sub

    Private Sub DaywiseCompanyDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaywiseCompanyDetailsToolStripMenuItem1.Click
        Menuname = "Daywise Company Details"
        DaywiseRep.MdiParent = Me
        DaywiseRep.Show()
    End Sub

    Private Sub MonthlyProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyProductDetailsToolStripMenuItem.Click
        Menuname = "Monthly Product Details"
        MonthlyRep.MdiParent = Me
        MonthlyRep.Show()
    End Sub

    Private Sub MonthlyInvoiceAndProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyInvoiceAndProductDetailsToolStripMenuItem.Click
        Menuname = "Monthly Invoice and Product Details"
        MonthlyRep.MdiParent = Me
        MonthlyRep.Show()
    End Sub

    Private Sub MonthlyInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyInvoiceToolStripMenuItem.Click
        Menuname = "Monthly Invoice Details"
        MonthlyRep.MdiParent = Me
        MonthlyRep.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Menuname = "Monthly Company and Invoice and Product Details"
        MonthlyRep.MdiParent = Me
        MonthlyRep.Show()
    End Sub

    Private Sub DaywiseCompanyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseCompanyDetailsToolStripMenuItem.Click
        Menuname = "Monthly Company and Invoice Details"
        MonthlyRep.MdiParent = Me
        MonthlyRep.Show()
    End Sub

    Private Sub MonthlyCompanyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyCompanyDetailsToolStripMenuItem.Click
        Menuname = "Monthly Company Details"
        MonthlyRep.MdiParent = Me
        MonthlyRep.Show()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductDetailsToolStripMenuItem.Click
        Menuname = "Product Details"
        Report.MdiParent = Me
        Report.Txtvalue.Visible = False
        Report.RVinvinvdetails.Visible = False
        Report.RVcom.Visible = False
        Report.Repcompro.Visible = False
        Report.reppanel.Visible = False
        Report.Repcominv.Visible = False
        Report.Repinvpro.Visible = False
        Report.Repproduct.Visible = True
        Report.Width = Report.Txtvalue.Width
        Report.Height = Report.Txtvalue.Height
        Report.Repproduct.Width = Report.Txtvalue.Width
        Report.Repproduct.Height = Report.Txtvalue.Height
        Report.Repproduct.Location = Report.Txtvalue.Location
        Report.Show()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductDetailsToolStripMenuItem1.Click
        Menuname = "InvProduct Details"
        Report.MdiParent = Me
        Report.Txtvalue.Visible = False
        Report.RVinvinvdetails.Visible = False
        Report.RVcom.Visible = False
        Report.Repcompro.Visible = False
        Report.reppanel.Visible = True
        Report.Repcominv.Visible = False
        Report.Repinvpro.Visible = False
        Report.Repproduct.Visible = False
        Report.Width = Report.Txtvalue.Width
        Report.Height = Report.Txtvalue.Height
        Report.Repinvpro.Width = Report.Txtvalue.Width
        Report.Repinvpro.Height = Report.Txtvalue.Height
        Report.Repinvpro.Location = Report.Txtvalue.Location
        Report.Show()
    End Sub

    Private Sub InvoiceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceDetailsToolStripMenuItem.Click
        Menuname = "Invoice Details"
        Dim comname As String = "Invoice details"
        Dim dt As New DataTable
        Dim path As String
        Report.MdiParent = Me
        path = "E:\DINESHKUMAR B\BILL MANAGEMENT SYSTEM\REPORT DATA\INVOICE\INV DETAILS\" & comname & ".txt"
        query = "SELECT * FROM BILLINVOICE_DETAILS ORDER BY COMID_FK"
        dt = selquery(query)
        If dt.Rows.Count > 0 Then
            createfile(path, dt, Menuname)
            Report.MdiParent = Me
            Report.Txtvalue.Visible = False
            Report.RVinvinvdetails.Visible = True
            Report.RVcom.Visible = False
            Report.Repcompro.Visible = False
            Report.reppanel.Visible = False
            Report.Repcominv.Visible = False
            Report.Repinvpro.Visible = False
            Report.Repproduct.Visible = False
            Report.Width = Report.Txtvalue.Width + 40
            Report.Height = Report.Txtvalue.Height + 70
            Report.RVinvinvdetails.Width = Report.Txtvalue.Width
            Report.RVinvinvdetails.Height = Report.Txtvalue.Height
            Report.RVinvinvdetails.Location = Report.Txtvalue.Location
            Report.Show()
        Else
            MsgBox("No row found")
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Menuname = "ComProduct Details"
        Report.MdiParent = Me
        Report.Txtvalue.Visible = False
        Report.RVinvinvdetails.Visible = False
        Report.RVcom.Visible = False
        Report.Repcompro.Visible = False
        Report.lblInvid.Visible = False
        Report.cmbinv.Visible = False
        Report.reppanel.Visible = True
        Report.Repcominv.Visible = False
        Report.Repinvpro.Visible = False
        Report.Repproduct.Visible = False
        Report.Width = Report.Txtvalue.Width
        Report.Height = Report.Txtvalue.Height
        Report.Repcompro.Width = Report.Txtvalue.Width
        Report.Repcompro.Height = Report.Txtvalue.Height
        Report.Repcompro.Location = Report.Txtvalue.Location
        Report.Show()
    End Sub

    Private Sub InvoiceDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InvoiceDetailsToolStripMenuItem1.Click
        Menuname = "ComInvoice Details"
        Report.MdiParent = Me
        Report.Txtvalue.Visible = False
        Report.RVinvinvdetails.Visible = False
        Report.RVcom.Visible = False
        Report.Repcompro.Visible = False
        Report.lblInvid.Visible = False
        Report.cmbinv.Visible = False
        Report.reppanel.Visible = True
        Report.Repcominv.Visible = False
        Report.Repinvpro.Visible = False
        Report.Repproduct.Visible = False
        Report.Width = Report.Txtvalue.Width
        Report.Height = Report.Txtvalue.Height
        Report.Repcominv.Width = Report.Txtvalue.Width
        Report.Repcominv.Height = Report.Txtvalue.Height
        Report.Repcominv.Location = Report.Txtvalue.Location
        Report.Show()
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyDetailsToolStripMenuItem.Click
        Menuname = "Company Details"
        Dim comname As String = "Company details"
        Dim dt As New DataTable
        Dim path As String
        Report.MdiParent = Me
        path = "E:\DINESHKUMAR B\BILL MANAGEMENT SYSTEM\REPORT DATA\COMPANY\COM DETAILS\" & comname & ".txt"
        query = "SELECT * FROM BILLCOM_DETAILS ORDER BY COMID"
        dt = selquery(query)
        If dt.Rows.Count > 0 Then
            createfile(path, dt, Menuname)
        Else
            MsgBox(" NO RECORDS")
        End If
        'Dim fread As String
        ' fread = My.Computer.FileSystem.ReadAllText(path)
        '  Report.Txtvalue.Text = fread
        Report.Txtvalue.Visible = False
        Report.RVinvinvdetails.Visible = False
        Report.RVcom.Visible = True
        Report.Repcompro.Visible = False
        Report.reppanel.Visible = False
        Report.Repcominv.Visible = False
        Report.Repinvpro.Visible = False
        Report.Repproduct.Visible = False
        Report.Width = Report.Txtvalue.Width - 35
        Report.Height = Report.Txtvalue.Height + 25
        Report.RVcom.Width = Report.Txtvalue.Width - 60
        Report.RVcom.Height = Report.Txtvalue.Height - 30
        Report.RVcom.Location = Report.Txtvalue.Location
        Report.Show()
        'Dim childForm As BillForm = New BillForm()
        'childForm.Show()
    End Sub
    Private Sub CompanyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem1.Click
        Dim dt As New DataTable
        Menuname = "Company Details"
        query = "SELECT AROLE FROM BILLUREG WHERE USERNAME='" & Loginmenu.Text & "'"
        dt = selquery(query)
        Try
            If dt.Rows(0)("AROLE").ToString = "Y" Then
                Creation.MdiParent = Me
                Creation.lbltitle.Text = "Creation of Company"
                Creation.companel.Visible = True
                Creation.invpanel.Visible = False
                Creation.propanel.Visible = False
                Creation.Width = Creation.companel.Width
                Creation.Height = Creation.companel.Height
                Creation.companel.Location = New Point(Convert.ToInt32(Creation.ClientSize.Width / 2 - Creation.companel.Width / 2), Convert.ToInt32(Creation.ClientSize.Height / 2 - Creation.companel.Height / 2))
                Creation.Show()
            Else
                MsgBox("User Deneied")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub InvoiceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem1.Click
        Menuname = "Invoice"
        Creation.MdiParent = Me
        Creation.lbltitle.Text = "Creation of Invoice"
        Creation.companel.Visible = False
        Creation.invpanel.Visible = True
        Creation.propanel.Visible = False
        Creation.Width = Creation.companel.Width
        Creation.Height = Creation.companel.Height
        Creation.invpanel.Location = New Point(Convert.ToInt32(Creation.ClientSize.Width / 2 - Creation.companel.Width / 2), Convert.ToInt32(Creation.ClientSize.Height / 2 - Creation.companel.Height / 2))
        Creation.Show()
    End Sub

    Private Sub ProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem1.Click
        Menuname = "Product"
        Creation.MdiParent = Me
        Creation.lbltitle.Text = "Creation of Product"
        Creation.companel.Visible = False
        Creation.invpanel.Visible = False
        Creation.propanel.Visible = True
        Creation.Width = Creation.companel.Width
        Creation.Height = Creation.companel.Height
        Creation.propanel.Location = New Point(Convert.ToInt32(Creation.ClientSize.Width / 2 - Creation.companel.Width / 2), Convert.ToInt32(Creation.ClientSize.Height / 2 - Creation.companel.Height / 2))
        Creation.Show()
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CompanyDetailsToolStripMenuItem2.Click
        Dim dt As New DataTable
        Menuname = "Company Details"
        query = "SELECT AROLE FROM BILLUREG WHERE USERNAME='" & Loginmenu.Text & "'"
        dt = selquery(query)
        Try
            If dt.Rows(0)("AROLE").ToString = "Y" Then
                Edit.MdiParent = Me
                Edit.lbltitle.Text = "Update of Company"
                Edit.companel.Visible = True
                Edit.invpanel.Visible = False
                Edit.propanel.Visible = False
                Edit.Width = Edit.invpanel.Width
                Edit.Height = Edit.invpanel.Height
                Edit.companel.Location = New Point(Convert.ToInt32(Edit.ClientSize.Width / 2 - Edit.companel.Width / 2), Convert.ToInt32(Edit.ClientSize.Height / 2 - Edit.companel.Height / 2))
                Edit.Show()
            Else
                MsgBox("User Deneied")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub InvoiceDetailsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles InvoiceDetailsToolStripMenuItem3.Click
        Menuname = "Invoice"
        Edit.MdiParent = Me
        Edit.lbltitle.Text = "Update of Invoice"
        Edit.companel.Visible = False
        Edit.invpanel.Visible = True
        Edit.propanel.Visible = False
        Edit.Width = Edit.companel.Width
        Edit.Height = Edit.companel.Height
        Edit.invpanel.Location = New Point(Convert.ToInt32(Edit.ClientSize.Width / 2 - Edit.companel.Width / 2), Convert.ToInt32(Edit.ClientSize.Height / 2 - Edit.companel.Height / 2))
        Edit.Show()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ProductDetailsToolStripMenuItem3.Click
        Menuname = "Product"
        Edit.MdiParent = Me
        Edit.lbltitle.Text = "Update of Product"
        Edit.companel.Visible = False
        Edit.invpanel.Visible = False
        Edit.propanel.Visible = True
        Edit.Width = Edit.companel.Width
        Edit.Height = Edit.companel.Height
        Edit.propanel.Location = New Point(Convert.ToInt32(Edit.ClientSize.Width / 2 - Edit.companel.Width / 2), Convert.ToInt32(Edit.ClientSize.Height / 2 - Edit.companel.Height / 2))
        Edit.Show()
    End Sub

    Private Sub ExciseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExciseToolStripMenuItem.Click
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompanyDetailsToolStripMenuItem1.Click
        Dim dt, dt1 As New DataTable
        Menuname = "Company Details"
        dbcon()
        query = "SELECT AROLE FROM BILLUREG WHERE USERNAME='" & Loginmenu.Text & "'"
        dt = selquery(query)
        Try
            If dt.Rows(0)("AROLE").ToString = "Y" Then
                Display.MdiParent = Me
                Display.RGVcom.Visible = True
                Display.RGVinv.Visible = False
                Display.RGVpro.Visible = False
                Display.Width = Display.RGVcom.Width
                Display.Height = Display.RGVcom.Height
                Display.RGVcom.Location = New Point(Convert.ToInt32(Display.ClientSize.Width / 2 - Display.RGVcom.Width / 2), Convert.ToInt32(Display.ClientSize.Height / 2 - Display.RGVcom.Height / 2))
                query = "SELECT * FROM BILLCOM_DETAILS ORDER BY COMID"
                dt1 = selquery(query)
                Display.RGVcom.DataSource = dt1
                dbclose()
                Display.Show()
            Else
                MsgBox("User Deneied")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub InvoiceDetailsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InvoiceDetailsToolStripMenuItem2.Click
        Menuname = "Invoice Details"
        Dim dt As New DataTable
        dbcon()
        Display.MdiParent = Me
        Display.RGVcom.Visible = False
        Display.RGVinv.Visible = True
        Display.RGVpro.Visible = False
        Display.Width = Display.RGVcom.Width
        Display.Height = Display.RGVcom.Height
        Display.RGVinv.Location = New Point(Convert.ToInt32(Display.ClientSize.Width / 2 - Display.RGVcom.Width / 2), Convert.ToInt32(Display.ClientSize.Height / 2 - Display.RGVcom.Height / 2))
        query = "SELECT * FROM BILLINVOICE_DETAILS ORDER BY COMID_FK"
        dt = selquery(query)
        Display.RGVinv.DataSource = dt
        dbclose()
        Display.Show()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductDetailsToolStripMenuItem2.Click
        Menuname = "Product Details"
        Dim dt As New DataTable
        dbcon()
        Display.MdiParent = Me
        Display.RGVcom.Visible = False
        Display.RGVinv.Visible = False
        Display.RGVpro.Visible = True
        Display.Width = Display.RGVcom.Width
        Display.Height = Display.RGVcom.Height
        Display.RGVpro.Location = New Point(Convert.ToInt32(Display.ClientSize.Width / 2 - Display.RGVcom.Width / 2), Convert.ToInt32(Display.ClientSize.Height / 2 - Display.RGVcom.Height / 2))
        query = "SELECT * FROM BILLPRODUCT_DETAILS ORDER BY COMID_FK"
        dt = selquery(query)
        Display.RGVpro.DataSource = dt
        dbclose()
        Display.Show()
    End Sub

    Private Sub CompanyToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem2.Click
        Menuname = "Delete of Company"
        Delete.MdiParent = Me
        Delete.delpanel.Visible = False
        Delete.companel.Visible = True
        Delete.invpanel.Visible = False
        Delete.Width = Delete.delpanel.Width
        Delete.Height = Delete.delpanel.Height
        Delete.companel.Location = New Point(Convert.ToInt32(Delete.ClientSize.Width / 2 - Delete.delpanel.Width / 2), Convert.ToInt32(Delete.ClientSize.Height / 2 - Delete.delpanel.Height / 2))
        Delete.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem2.Click
        Menuname = "Delete of invoice"
        Delete.MdiParent = Me
        Delete.delpanel.Visible = False
        Delete.companel.Visible = False
        Delete.invpanel.Visible = True
        Delete.Width = Delete.delpanel.Width
        Delete.Height = Delete.delpanel.Height
        Delete.invpanel.Location = New Point(Convert.ToInt32(Delete.ClientSize.Width / 2 - Delete.delpanel.Width / 2), Convert.ToInt32(Delete.ClientSize.Height / 2 - Delete.delpanel.Height / 2))
        Delete.Show()
    End Sub

    Private Sub ProductToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem2.Click
        Menuname = "Delete of product"
        Delete.MdiParent = Me
        Delete.delpanel.Visible = True
        Delete.companel.Visible = False
        Delete.invpanel.Visible = False
        Delete.Width = Delete.delpanel.Width
        Delete.Height = Delete.delpanel.Height
        Delete.delpanel.Location = New Point(Convert.ToInt32(Delete.ClientSize.Width / 2 - Delete.delpanel.Width / 2), Convert.ToInt32(Delete.ClientSize.Height / 2 - Delete.delpanel.Height / 2))
        Delete.Show()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        Imageprocess.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.MdiParent = Me
        Home.Show()
    End Sub

    Private Sub OTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OTPToolStripMenuItem.Click
        OTPGEN.Show()
    End Sub
End Class
