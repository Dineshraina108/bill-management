Public Class DaywiseRep
    Dim query, menuname As String
    Public Shared fromdt, todate As String
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click

        Dim dt, dt1, dt2 As New DataTable
        dbcon()
        menuname = MasterPage.Menuname
        fromdt = dtfromdate.Value.Date
        todate = dttodate.Value.Date
        Dim dtdate As DataTable
        Dim dr As DataRow
        dtdate = GetTable()
        dr = dtdate.NewRow()
        dr("fromdate") = fromdt
        dr("todate") = todate
        dtdate.Rows.Add(dr)
        If menuname = "Daywise Company Details" Then
            RVdaywise.Visible = True
            Rvdaypro.Visible = False
            Rvdayinv.Visible = False
            Rvdaywisecomandinv.Visible = False
            RVdaywiseinvandpro.Visible = False
            RVdaycominvpro.Visible = False
            query = "SELECT COMID,COMNAME,COMADDR FROM BILLCOM_DETAILS WHERE CRDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID"
            dt = selquery(query)
            Try
                If dt.Rows.Count > 0 Then
                    With Me.RVdaywise.LocalReport
                        .DataSources.Clear()
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisedate", dtdate))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisecom", dt))
                    End With
                Else
                    MsgBox("NO RECORDS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        If menuname = "Daywise Invoice Details" Then
            RVdaywise.Visible = False
            Rvdayinv.Visible = True
            Rvdaypro.Visible = False
            Rvdaywisecomandinv.Visible = False
            RVdaywiseinvandpro.Visible = False
            RVdaycominvpro.Visible = False
            query = "SELECT * FROM BILLINVOICE_DETAILS WHERE INVDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt = selquery(query)
            Try
                If dt.Rows.Count > 0 Then
                    With Me.Rvdayinv.LocalReport
                        .DataSources.Clear()
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisedate", dtdate))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywiseinv", dt))
                    End With
                Else
                    MsgBox("NO RECORDS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        If menuname = "Daywise Product Details" Then
            RVdaywise.Visible = False
            Rvdayinv.Visible = False
            Rvdaypro.Visible = True
            Rvdaywisecomandinv.Visible = False
            RVdaywiseinvandpro.Visible = False
            RVdaycominvpro.Visible = False
            query = "Select * FROM BILLPRODUCT_DETAILS WHERE PRCRDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt = selquery(query)
            Try
                If dt.Rows.Count > 0 Then
                    With Me.Rvdaypro.LocalReport
                        .DataSources.Clear()
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisedate", dtdate))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisepro", dt))
                    End With
                Else
                    MsgBox("NO RECORDS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        If menuname = "Daywise Company and Invoice Details" Then
            RVdaywise.Visible = False
            Rvdayinv.Visible = False
            Rvdaypro.Visible = False
            Rvdaywisecomandinv.Visible = True
            RVdaywiseinvandpro.Visible = False
            RVdaycominvpro.Visible = False
            query = "SELECT COMID,COMNAME,COMADDR FROM BILLCOM_DETAILS WHERE CRDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID"
            dt = selquery(query)
            query = "SELECT * FROM BILLINVOICE_DETAILS WHERE INVDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt1 = selquery(query)
            Try
                If dt.Rows.Count > 0 Then
                    With Me.Rvdaywisecomandinv.LocalReport
                        .DataSources.Clear()
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dawisedate", dtdate))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisecom", dt))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywiseinv", dt1))
                    End With
                Else
                    MsgBox("NO RECORDS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        If menuname = "Daywise Invoice and Product Details" Then
            RVdaywise.Visible = False
            Rvdayinv.Visible = False
            Rvdaypro.Visible = False
            Rvdaywisecomandinv.Visible = False
            RVdaywiseinvandpro.Visible = True
            RVdaycominvpro.Visible = False
            query = "Select * FROM BILLPRODUCT_DETAILS WHERE PRCRDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt = selquery(query)
            query = "SELECT * FROM BILLINVOICE_DETAILS WHERE INVDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt1 = selquery(query)
            Try
                If dt.Rows.Count > 0 Then
                    With Me.RVdaywiseinvandpro.LocalReport
                        .DataSources.Clear()
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisedate", dtdate))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywiseinv", dt1))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisepro", dt))
                    End With
                Else
                    MsgBox("NO RECORDS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        If menuname = "Daywise Company and Invoice and Product Details" Then
            RVdaywise.Visible = False
            Rvdayinv.Visible = False
            Rvdaypro.Visible = False
            Rvdaywisecomandinv.Visible = False
            RVdaywiseinvandpro.Visible = False
            RVdaycominvpro.Visible = True
            query = "SELECT COMID,COMNAME,COMADDR FROM BILLCOM_DETAILS WHERE CRDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID"
            dt2 = selquery(query)
            query = "Select * FROM BILLPRODUCT_DETAILS WHERE PRCRDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt = selquery(query)
            query = "SELECT * FROM BILLINVOICE_DETAILS WHERE INVDATE BETWEEN '" & fromdt & "' AND '" & todate & "' ORDER BY COMID_FK"
            dt1 = selquery(query)
            Try
                If dt.Rows.Count > 0 Then
                    With Me.RVdaycominvpro.LocalReport
                        .DataSources.Clear()
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisedate", dtdate))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisecom", dt2))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywiseinv", dt1))
                        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Daywisepro", dt))
                    End With
                Else
                    MsgBox("NO RECORDS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        dbclose()
    End Sub
    Public Function GetTable()
        Dim tabl As New DataTable
        tabl.Columns.Add("fromdate", GetType(String))
        tabl.Columns.Add("todate", GetType(String))
        Return tabl
    End Function
    Public Function Dsdate() As List(Of Daywise)
        Dim lis As New List(Of Daywise)
        lis.Add(New Daywise With {
                       .fromdate = dtfromdate.Value.Date,
                       .todate = dttodate.Value.Date
                      })
        Return lis
    End Function
    Private Sub DaywiseRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fromdt = dtfromdate.Value.Date
        todate = dttodate.Value.Date
        RVdaywise.Visible = False
        Rvdaypro.Visible = False
        Rvdayinv.Visible = False
        Rvdaywisecomandinv.Visible = False
        RVdaywiseinvandpro.Visible = False
        RVdaycominvpro.Visible = False
        Me.RVdaywise.RefreshReport()
        Me.Rvdayinv.RefreshReport()
        Me.Rvdaypro.RefreshReport()
        Me.Rvdaywisecomandinv.RefreshReport()
        Me.RVdaywiseinvandpro.RefreshReport()
        Me.RVdaycominvpro.RefreshReport()
    End Sub

    Private Sub dtfromdate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtfromdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dttodate.Focus()
        End If
    End Sub

    Private Sub dttodate_KeyDown(sender As Object, e As KeyEventArgs) Handles dttodate.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsub.Focus()
        End If
    End Sub
End Class