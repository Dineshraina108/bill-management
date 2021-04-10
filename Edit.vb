Public Class Edit
    Dim query As String
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt, dt1 As New DataTable
        dbcon()
        query = "SELECT COMID FROM BILLCOM_DETAILS"
        dt = selquery(query)
        Try
            If dt.Rows.Count = 0 Then
                MsgBox("No Company available in record")
                Cbcompany.DataSource = dt
                Cbcompany.DisplayMember = "COMID"
                Cbcompany.ValueMember = "COMID"
            Else
                Cbcompany.DataSource = dt
                Cbcompany.DisplayMember = "COMID"
                Cbcompany.ValueMember = "COMID"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        query = "SELECT COMID,COMNAME FROM BILLCOM_DETAILS"
        dt1 = selquery(query)
        Try
            If dt1.Rows.Count = 0 Then
                MsgBox("No Company available in record")
                CBcom.DataSource = dt1
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
                CBprocom.DataSource = dt1
                CBprocom.DisplayMember = "COMNAME"
                CBprocom.ValueMember = "COMID"
            Else
                CBcom.DataSource = dt1
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
                CBprocom.DataSource = dt1
                CBprocom.DisplayMember = "COMNAME"
                CBprocom.ValueMember = "COMID"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click
        Me.Close()
    End Sub

    Private Sub btnprocancel_Click(sender As Object, e As EventArgs) Handles btnprocancel.Click
        Me.Close()
    End Sub

    Private Sub Cbcompany_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbcompany.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT COMNAME,COMADDR FROM BILLCOM_DETAILS  WHERE COMID= " & Cbcompany.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No company for this id")
                Else
                    txtcomname.Text = dt.Rows(0)("COMNAME").ToString
                    txtaddr.Text = dt.Rows(0)("COMADDR").ToString
                    txtcomname.Focus()
                End If
            Catch ex As Exception
                txtcomname.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub txtaddr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            btncomup.Focus()
        End If
    End Sub

    Private Sub CBcom_KeyDown(sender As Object, e As KeyEventArgs) Handles CBcom.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVID FROM BILLINVOICE_DETAILS WHERE COMID_FK= " & CBcom.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available for this company")
                    CBinvoice.DataSource = dt
                    CBinvoice.DisplayMember = "INVID"
                    CBinvoice.ValueMember = "INVID"
                    CBinvoice.Focus()
                Else
                    CBinvoice.DataSource = dt
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

    Private Sub CBprocom_KeyDown(sender As Object, e As KeyEventArgs) Handles CBprocom.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVID,INVNO FROM BILLINVOICE_DETAILS WHERE COMID_FK= " & CBprocom.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available for this company")
                    CBproinv.DataSource = dt
                    CBproinv.DisplayMember = "INVNO"
                    CBproinv.ValueMember = "INVID"
                    CBproinv.Focus()
                Else
                    CBproinv.DataSource = dt
                    CBproinv.DisplayMember = "INVNO"
                    CBproinv.ValueMember = "INVID"
                    CBproinv.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                CBproinv.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub CBinvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles CBinvoice.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVNO,INVDATE,SERIAL,INVLOCATION,CHALANNO FROM BILLINVOICE_DETAILS WHERE INVID= " & CBinvoice.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available ")
                Else
                    txtinvno.Text = dt.Rows(0)("INVNO").ToString
                    dtpinvdate.Text = dt.Rows(0)("INVDATE").ToString
                    txtserial.Text = dt.Rows(0)("SERIAL").ToString
                    txtlocation.Text = dt.Rows(0)("INVLOCATION").ToString
                    txtchalanno.Text = dt.Rows(0)("CHALANNO").ToString
                    txtinvno.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        dbclose()
    End Sub

    Private Sub dtpinvdate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpinvdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserial.Focus()
        End If
    End Sub

    Private Sub txtserial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserial.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtlocation.Focus()
        End If
    End Sub

    Private Sub txtlocation_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlocation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtchalanno.Focus()
        End If
    End Sub

    Private Sub txtchalanno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtchalanno.KeyDown
        If e.KeyCode = Keys.Enter Then
            btninvup.Focus()
        End If
    End Sub

    Private Sub txtcomname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtaddr.Focus()
        End If
    End Sub

    Private Sub txtinvno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvno.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpinvdate.Focus()
        End If
    End Sub

    Private Sub CBproinv_KeyDown(sender As Object, e As KeyEventArgs) Handles CBproinv.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVNO_FK,PRID FROM BILLPRODUCT_DETAILS WHERE INVNO_FK= " & CBproinv.SelectedValue & ""
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

    Private Sub cbprid_KeyDown(sender As Object, e As KeyEventArgs) Handles cbprid.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT PRNAME,PRQTY,PRRATE,PRAMOUNT FROM BILLPRODUCT_DETAILS WHERE PRID= " & cbprid.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("Product not  available ")
                Else
                    txtinvdes.Text = dt.Rows(0)("PRNAME").ToString
                    txtqty.Text = dt.Rows(0)("PRQTY").ToString
                    txtrate.Text = dt.Rows(0)("PRRATE").ToString
                    txtamt.Text = dt.Rows(0)("PRAMOUNT").ToString
                    txtinvdes.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        dbclose()
    End Sub

    Private Sub txtinvdes_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvdes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqty.Focus()
        End If
    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrate.Focus()
        End If
    End Sub

    Private Sub txtrate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqty.Text = 0 Then
                txtqty.Text = 1
            End If
            If txtrate.Text = 0 Then
                txtrate.Text = 1
            End If
            txtamt.Text = txtqty.Text * txtrate.Text
            btnproup.Focus()
        End If
    End Sub

    Private Sub btnproup_Click(sender As Object, e As EventArgs) Handles btnproup.Click
        dbcon()
        query = "UPDATE BILLPRODUCT_DETAILS SET PRNAME='" & txtinvdes.Text & "',PRQTY=" & txtqty.Text & ",PRRATE=" & txtrate.Text & ",PRAMOUNT=" & txtamt.Text & " WHERE PRID= " & cbprid.SelectedValue & ""
        updquery(query)
        Me.Close()
        dbclose()
    End Sub

    Private Sub btninvup_Click(sender As Object, e As EventArgs) Handles btninvup.Click
        dbcon()
        query = "UPDATE BILLINVOICE_DETAILS SET INVNO=" & txtinvno.Text & ",INVDATE=to_date('" & dtpinvdate.Value.Date & "','dd/MM/yyyy'),SERIAL=" & txtserial.Text & ",INVLOCATION= '" & txtlocation.Text & "',CHALANNO=" & txtchalanno.Text & " WHERE INVID= " & CBinvoice.SelectedValue & ""
        updquery(query)
        Me.Close()
        dbclose()
    End Sub

    Private Sub btncomup_Click(sender As Object, e As EventArgs) Handles btncomup.Click
        dbcon()
        query = "UPDATE BILLCOM_DETAILS SET COMNAME='" & txtcomname.Text & "',COMADDR='" & txtaddr.Text & "'WHERE COMID=" & Cbcompany.SelectedValue & ""
        updquery(query)
        Me.Close()
        dbclose()
    End Sub
End Class