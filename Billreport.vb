Public Class Billreport
    Dim query As String
    Private Sub Billreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt, billdt As New DataTable
        dbcon()
        dt = BillForm.pdt
        billdt = BillForm.billdt
        With Me.rvbill.LocalReport
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dspro", dt))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsbill", billdt))
        End With
        Me.rvbill.RefreshReport()
    End Sub
End Class