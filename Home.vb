Public Class Home
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Dim bf As BillForm = New BillForm()
        bf.Billselpanel.Visible = True
        bf.Billdetailspanel1.Visible = False
        bf.prpanel1.Visible = False
        bf.BIllHomepanel.Update()
        Me.Close()
        bf.Show()
    End Sub
End Class
