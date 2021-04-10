Public Class Report
    Dim query As String
    Dim menuname As String
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dsinvoice.BILLINVOICE_DETAILS' table. You can move, or remove it, as needed.
        'Me.BILLINVOICE_DETAILSTableAdapter.Fill(Me.Dsinvoice.BILLINVOICE_DETAILS)
        Dim dt As New DataTable
        Txtvalue.Text = BillForm.fread
        dbcon()
        query = "SELECT COMID,COMNAME FROM BILLCOM_DETAILS"
        dt = selquery(query)
        If dt.Rows.Count > 0 Then
            cmbcom.DataSource = dt
            cmbcom.DisplayMember = "COMNAME"
            cmbcom.ValueMember = "COMID"
        Else
            cmbcom.DataSource = dt
            cmbcom.DisplayMember = "COMNAME"
            cmbcom.ValueMember = "COMID"
        End If

        If MasterPage.Menuname = "Invoice Details" Then
            query = "SELECT * FROM BILLINVOICE_DETAILS ORDER BY COMID_FK"
            dt = selquery(query)
            With Me.RVinvinvdetails.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("reinvoice", dt))
            End With
        End If
        If MasterPage.Menuname = "Company Details" Then
            query = "SELECT COMID,CRDATE,COMNAME,COMADDR FROM BILLCOM_DETAILS ORDER BY COMID"
            dt = selquery(query)
            With Me.RVcom.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DScom", dt))
            End With
        End If
        If MasterPage.Menuname = "Product Details" Then
            query = "SELECT * FROM BILLPRODUCT_DETAILS ORDER BY COMID_FK"
            dt = selquery(query)
            With Me.Repproduct.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSpro", dt))
            End With
        End If
        Me.RVinvinvdetails.RefreshReport()
        Me.RVcom.RefreshReport()
        Me.Repcompro.RefreshReport()
        dbclose()
        Me.Repcominv.RefreshReport()
        Me.Repinvpro.RefreshReport()
        Me.Repproduct.RefreshReport()
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click
        Me.Close()
    End Sub

    Private Sub cmbcom_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcom.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVID,INVNO FROM BILLINVOICE_DETAILS WHERE COMID_FK= " & cmbcom.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available for this company")
                    cmbinv.DataSource = dt
                    cmbinv.DisplayMember = "INVID"
                    cmbinv.ValueMember = "INVID"
                    cmbinv.Focus()
                Else
                    cmbinv.DataSource = dt
                    cmbinv.DisplayMember = "INVID"
                    cmbinv.ValueMember = "INVID"
                    cmbinv.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                cmbinv.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub cmbinv_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbinv.KeyDown
        If e.KeyCode = Keys.Enter Then
            btninvconfirm.Focus()
        End If
    End Sub

    Private Sub btninvconfirm_Click(sender As Object, e As EventArgs) Handles btninvconfirm.Click
        reppanel.Visible = False

        Dim dt As New DataTable
        dbcon()
        If MasterPage.Menuname = "ComInvoice Details" Then
            Repcominv.Visible = True
            query = "SELECT COMID,COMNAME,COMADDR,INVID,INVNO,INVDATE,SERIAL,INVLOCATION,CHALANNO FROM BILLCOM_DETAILS,BILLINVOICE_DETAILS WHERE COMID_FK=COMID AND COMID=" & cmbcom.SelectedValue & " ORDER BY COMID"
            dt = selquery(query)
            With Me.Repcominv.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DScominv", dt))
            End With
        End If
        If MasterPage.Menuname = "ComProduct Details" Then
            Repcompro.Visible = True
            query = "SELECT ,PRID,PRNAME,PRQTY,PRRATE,PRAMOUNT FROM BILLCOM_DETAILS,BILLPRODUCT_DETAILS WHERE COMID_FK=COMID AND COMID=" & cmbcom.SelectedValue & " ORDER BY COMID"
            dt = selquery(query)
            With Me.Repcompro.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DScompro", dt))
            End With
        End If
        If MasterPage.Menuname = "InvProduct Details" Then
            Repinvpro.Visible = True
            query = "SELECT INVID,INVNO,INVDATE,PRID,PRNAME,PRQTY,PRRATE,PRAMOUNT FROM BILLINVOICE_DETAILS,BILLPRODUCT_DETAILS WHERE INVNO_FK=INVID AND INVID=" & cmbinv.SelectedValue & " ORDER BY INVID"
            dt = selquery(query)
            With Me.Repinvpro.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSinvpro", dt))
            End With
        End If
        dbclose()
    End Sub
End Class