Public Class Delete
    Dim query As String
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        dbcon()
        If CBcom.SelectedValue > 0 Then
            If CBinvoice.SelectedValue > 0 Then
                If cbprid.SelectedValue > 0 Then
                    query = "DELETE FROM BILLPRODUCT_DETAILS WHERE PRID= " & cbprid.SelectedValue & ""
                    delquery(query)
                    Me.Close()
                Else
                    MsgBox(" PRODUCT NOT AVAILABLE")
                    cbprid.Focus()
                End If
            Else
                MsgBox(" INVOICE NOT AVAILABLE")
                CBinvoice.Focus()
            End If
        Else
            MsgBox(" COMPANY NOT AVAILABLE")
            CBcom.Focus()
        End If
        dbclose()
    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dbcon()
        query = "SELECT COMID,COMNAME FROM BILLCOM_DETAILS"
        dt = selquery(query)
        Try
            If dt.Rows.Count = 0 Then
                MsgBox("No Company available in record")
                CBcom.DataSource = dt
                cmbcom.DataSource = dt
                cmbinvcom.DataSource = dt
                Dim Irow As DataRow = dt.NewRow()
                Irow(0) = 0
                dt.Rows.InsertAt(Irow, 0)
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
                cmbcom.DisplayMember = "COMNAME"
                cmbcom.ValueMember = "COMID"
                cmbinvcom.DisplayMember = "COMNAME"
                cmbinvcom.ValueMember = "COMID"
            Else
                CBcom.DataSource = dt
                cmbcom.DataSource = dt
                cmbinvcom.DataSource = dt
                Dim Irow As DataRow = dt.NewRow()
                Irow(0) = 0
                dt.Rows.InsertAt(Irow, 0)
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
                cmbcom.DisplayMember = "COMNAME"
                cmbcom.ValueMember = "COMID"
                cmbinvcom.DisplayMember = "COMNAME"
                cmbinvcom.ValueMember = "COMID"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
    End Sub

    Private Sub CBcom_KeyDown(sender As Object, e As KeyEventArgs) Handles CBcom.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVID,INVNO FROM BILLINVOICE_DETAILS WHERE COMID_FK= " & CBcom.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available for this company")
                    CBinvoice.DataSource = dt
                    Dim Irow As DataRow = dt.NewRow()
                    Irow(0) = 0
                    dt.Rows.InsertAt(Irow, 0)
                    CBinvoice.DisplayMember = "INVID"
                    CBinvoice.ValueMember = "INVID"
                    CBinvoice.Focus()
                Else
                    CBinvoice.DataSource = dt
                    Dim Irow As DataRow = dt.NewRow()
                    Irow(0) = 0
                    dt.Rows.InsertAt(Irow, 0)
                    CBinvoice.DisplayMember = "INVID"
                    CBinvoice.ValueMember = "INVID"
                    CBinvoice.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                CBinvoice.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub cbprid_KeyDown(sender As Object, e As KeyEventArgs) Handles cbprid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btndel.Focus()
        End If
    End Sub

    Private Sub CBinvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles CBinvoice.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVNO_FK,PRID FROM BILLPRODUCT_DETAILS WHERE INVNO_FK= " & CBinvoice.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("Product not  available ")
                    cbprid.DataSource = dt
                    cbprid.DisplayMember = "PRID"
                    cbprid.ValueMember = "INVNO_FK"
                    cbprid.Focus()
                Else
                    cbprid.DataSource = dt
                    cbprid.DisplayMember = "PRID"
                    cbprid.ValueMember = "INVNO_FK"
                    cbprid.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        dbclose()
    End Sub

    Private Sub btncomcancel_Click(sender As Object, e As EventArgs) Handles btncomcancel.Click
        Me.Close()
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click
        Me.Close()
    End Sub

    Private Sub cmbinvcom_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbinvcom.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVID,INVNO FROM BILLINVOICE_DETAILS WHERE COMID_FK= " & CBcom.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available for this company")
                    cmbinvinvid.DataSource = dt
                    Dim Irow As DataRow = dt.NewRow()
                    Irow(0) = 0
                    dt.Rows.InsertAt(Irow, 0)
                    cmbinvinvid.DisplayMember = "INVID"
                    cmbinvinvid.ValueMember = "INVID"
                    cmbinvinvid.Focus()
                Else
                    cmbinvinvid.DataSource = dt
                    Dim Irow As DataRow = dt.NewRow()
                    Irow(0) = 0
                    dt.Rows.InsertAt(Irow, 0)
                    cmbinvinvid.DisplayMember = "INVID"
                    cmbinvinvid.ValueMember = "INVID"
                    cmbinvinvid.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                cmbinvinvid.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub cmbcom_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcom.KeyDown
        If e.KeyCode = Keys.Enter Then
            btncomconfirm.Focus()
        End If
    End Sub

    Private Sub cmbinvinvid_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbinvinvid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btninvconfirm.Focus()
        End If
    End Sub

    Private Sub btncomconfirm_Click(sender As Object, e As EventArgs) Handles btncomconfirm.Click
        dbcon()
        If cmbcom.SelectedValue > 0 Then
            query = "DELETE FROM BILLCOM_DETAILS WHERE COMID=" & cmbcom.SelectedValue & ""
            delquery(query)
            query = "DELETE FROM BILLINVOICE_DETAILS WHERE COMID_FK=" & cmbcom.SelectedValue & ""
            delquery(query)
            query = "DELETE FROM BILLPRODUCT_DETAILS WHERE COMID_FK=" & cmbcom.SelectedValue & ""
            delquery(query)
            Me.Close()
        Else
            MsgBox(" COMPANY NOT AVAILABLE")
            cmbcom.Focus()
        End If
        dbclose()
    End Sub

    Private Sub btninvconfirm_Click(sender As Object, e As EventArgs) Handles btninvconfirm.Click
        dbcon()
        If cmbinvcom.SelectedValue > 0 Then
            If cmbinvinvid.SelectedValue > 0 Then
                query = "DELETE FROM BILLPRODUCT_DETAILS WHERE COMID_FK=" & cmbinvcom.SelectedValue & "AND INVNO_FK=" & cmbinvinvid.SelectedValue & ""
                delquery(query)
                query = "DELETE FROM BILLINVOICE_DETAILS WHERE COMID_FK=" & cmbinvcom.SelectedValue & "AND INVID=" & cmbinvinvid.SelectedValue & ""
                delquery(query)
                Me.Close()
            Else
                MsgBox("INVOICE NOT AVAILABLE")
                cmbinvinvid.Focus()
            End If
        Else
            MsgBox(" COMPANY NOT AVAILABLE")
            cmbinvcom.Focus()
        End If
        dbclose()
    End Sub
End Class