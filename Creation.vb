Imports Oracle.DataAccess.Client
Public Class Creation
    Dim query As String
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click
        Me.Close()
    End Sub

    Private Sub btnprocancel_Click(sender As Object, e As EventArgs) Handles btnprocancel.Click
        Me.Close()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim coname, coaddr, crdt As String
        Dim cid As Integer = 0
        Dim dt As New DataTable
        coname = txtcomname.Text
        coaddr = txtaddr.Text
        crdt = DateTime.Now.Date
        dbcon()
        query = "SELECT COUNT(COMID) FROM BILLCOM_DETAILS"
        dt = selquery(query)
        Try
            If dt.Rows(0)("COUNT(COMID)") = 0 Then
                cid = 1
            Else
                cid = dt.Rows(0)("COUNT(COMID)") + 1
            End If
            query = "INSERT INTO BILLCOM_DETAILS VALUES(" & cid & ",'" & coname & "','" & coaddr & "','" & crdt & "')"
            insquery(query)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
    End Sub

    Private Sub Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dbcon()
        query = "SELECT COMID,COMNAME FROM BILLCOM_DETAILS"
        dt = selquery(query)
        Try
            If dt.Rows.Count = 0 Then
                MsgBox("No Company available in record")
                CBcom.DataSource = dt
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
                cbprocomvo.DataSource = dt
                cbprocomvo.DisplayMember = "COMNAME"
                cbprocomvo.ValueMember = "COMID"
            Else
                CBcom.DataSource = dt
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
                cbprocomvo.DataSource = dt
                cbprocomvo.DisplayMember = "COMNAME"
                cbprocomvo.ValueMember = "COMID"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dbclose()
    End Sub

    Private Sub btninvcreate_Click(sender As Object, e As EventArgs) Handles btninvcreate.Click
        Dim idt As New DataTable
        Dim invid As Integer = 0
        dbcon()
        Try
            query = "SELECT COUNT(INVID) FROM BILLINVOICE_DETAILS"
            idt = selquery(query)
            If idt.Rows(0)("COUNT(INVID)") = 0 Then
                invid = 1
            Else
                invid = idt.Rows(0)("COUNT(INVID)") + 1
            End If
            query = "INSERT INTO BILLINVOICE_DETAILS VALUES(" & CBcom.SelectedValue & "," & invid & "," & txtinvno.Text & ",to_date('" & dtpinvdate.Value.Date & "','dd/MM/yyyy')," & txtserial.Text & ",'" & txtlocation.Text & "'," & txtchalanno.Text & ")"
            insquery(query)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
    End Sub

    Private Sub txtcomname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtaddr.Focus()
        End If
    End Sub

    Private Sub CBcom_KeyDown(sender As Object, e As KeyEventArgs) Handles CBcom.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtinvno.Focus()
        End If
    End Sub

    Private Sub txtaddr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            btncreate.Focus()
        End If
    End Sub

    Private Sub txtinvno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvno.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpinvdate.Focus()
        End If
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
            btninvcreate.Focus()
        End If
    End Sub

    Private Sub cbprocomvo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbprocomvo.KeyDown
        Dim dt As New DataTable
        dbcon()
        If e.KeyCode = Keys.Enter Then
            query = "SELECT INVID,INVNO FROM BILLINVOICE_DETAILS WHERE COMID_FK= " & CBcom.SelectedValue & ""
            dt = selquery(query)
            Try
                If dt.Rows.Count = 0 Then
                    MsgBox("No Invoice available for this company")
                    cmbproinv.DataSource = dt
                    cmbproinv.DisplayMember = "INVNO"
                    cmbproinv.ValueMember = "INVID"
                    cmbproinv.Focus()
                Else
                    cmbproinv.DataSource = dt
                    cmbproinv.DisplayMember = "INVNO"
                    cmbproinv.ValueMember = "INVID"
                    cmbproinv.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                cmbproinv.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub cmbproinv_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbproinv.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtinvdes.Focus()
        End If
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
            btnprocreate.Focus()
        End If
    End Sub

    Private Sub btnprocreate_Click(sender As Object, e As EventArgs) Handles btnprocreate.Click
        Dim idt As New DataTable
        Dim crdate As String
        Dim Prid As Integer = 0
        dbcon()
        Try
            query = "SELECT COUNT(PRID) FROM BILLPRODUCT_DETAILS"
            crdate = DateTime.Now.Date
            idt = selquery(query)
            If idt.Rows(0)("COUNT(PRID)") = 0 Then
                Prid = 1
            Else
                Prid = idt.Rows(0)("COUNT(PRID)") + 1
            End If
            query = "INSERT INTO BILLPRODUCT_DETAILS VALUES(" & cbprocomvo.SelectedValue & "," & cmbproinv.SelectedValue & "," & Prid & ",to_date('" & crdate & "','dd/MM/yyyy'),'" & txtinvdes.Text & "'," & txtqty.Text & "," & txtrate.Text & "," & txtamt.Text & ")"
            insquery(query)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
    End Sub
End Class