
Imports Oracle.DataAccess.Client
Public Class UserLogin
    Dim query As String
    Private Sub llblsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblsignup.LinkClicked

        Dim ur As New USERREG
        ur.txtuname.Focus()
        ur.Show()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        Dim usdt, dt As New DataTable
        Dim mp As New MasterPage
        dbcon()
        query = "SELECT * FROM BILLUREG WHERE USERNAME='" & txtuser.Text & "' AND PASSWORD='" & txtpass.Text & "'"
        usdt = selquery(query)
        Try
            If usdt.Rows.Count > 0 Then
                mp.Loginmenu.Text = txtuser.Text
                query = "SELECT AROLE FROM BILLUREG WHERE USERNAME='" & txtuser.Text & "'"
                dt = selquery(query)
                Try
                    If dt.Rows(0)("AROLE").ToString = "Y" Then
                        mp.Show()
                        Me.Hide()
                    Else
                        mp.CompanyToolStripMenuItem1.Visible = False
                        mp.CompanyDetailsToolStripMenuItem2.Visible = False
                        mp.CompanyDetailsToolStripMenuItem1.Visible = False
                        mp.CompanyToolStripMenuItem.Visible = False
                        mp.CompanyToolStripMenuItem2.Visible = False
                        MsgBox("User can not access company")
                        mp.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try

            Else
                MsgBox("INVALID USERNAME OR PASSWORD")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        dbclose()
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()
        dbclose()
    End Sub

    Private Sub llblforgetpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblforgetpassword.LinkClicked
        Dim ur As New USERREG
        ur.txtuname.Focus()
        ur.txtemail.Visible = False
        ur.lblemal.Visible = False
        ur.txtmobno.Visible = False
        ur.lablmobno.Visible = False
        ur.lblup.Visible = False
        ur.RDS.Visible = False
        ur.RDN.Visible = False
        ur.btnreg.Text = "RESET"
        ur.usregpanel.Update()
        ur.Show()
    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        Dim dt As New DataTable
        If e.KeyCode = Keys.Enter Then
            query = "SELECT AROLE FROM BILLUREG WHERE USERNAME='" & txtuser.Text & "'"
            dt = selquery(query)
            Try
                If dt.Rows(0)("AROLE").ToString = "Y" Then
                    llblsignup.Visible = True
                    lblslash.Visible = True
                    txtpass.Focus()
                Else
                    MsgBox("User can not access companys")
                    llblsignup.Visible = False
                    lblslash.Visible = False
                    txtpass.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsignin.Focus()
        End If
    End Sub
End Class