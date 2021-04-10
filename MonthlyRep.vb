Public Class MonthlyRep
    Dim menuname As String
    Dim stmon, tomon As String
    Dim QUERY As String
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub MonthlyRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datformat()
        menuname = MasterPage.Menuname
        Monrepcom.Visible = False
        Moncominv.Visible = False
        Moncominvpro.Visible = False
        Moninv.Visible = False
        Moninvpro.Visible = False
        Monpro.Visible = False
        Me.Monrepcom.RefreshReport()
        Me.Moncominv.RefreshReport()
        Me.Moncominvpro.RefreshReport()
        Me.Moninv.RefreshReport()
        Me.Moninvpro.RefreshReport()
        Me.Monpro.RefreshReport()
    End Sub
    Public Sub Datformat()
        dtfromdate.Format = DateTimePickerFormat.Custom
        dtfromdate.CustomFormat = "MM"
        dttodate.Format = DateTimePickerFormat.Custom
        dttodate.CustomFormat = "MM"
    End Sub

    Private Sub dtfromdate_Enter(sender As Object, e As EventArgs) Handles dtfromdate.Enter
        dttodate.Focus()
    End Sub

    Private Sub dttodate_Enter(sender As Object, e As EventArgs) Handles dttodate.Enter
        btnsub.Focus()
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim dt, dt1, dt2 As New DataTable
        Dim dtdate As DataTable
        Dim dr As DataRow
        stmon = NumberToText(dtfromdate.Text)
        tomon = NumberToText(dttodate.Text)
        dtdate = GetTable()
        dr = dtdate.NewRow()
        dr("fromdate") = stmon
        dr("todate") = tomon
        dtdate.Rows.Add(dr)
        If menuname = "Monthly Company Details" Then
            Monrepcom.Visible = True
            Try
                QUERY = "SELECT COMID,COMNAME,COMADDR FROM BILLCOM_DETAILS WHERE extract(month from to_date(CRDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID"
                dt = selquery(QUERY)
                With Me.Monrepcom.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmon", dtdate))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsmoncom", dt))
                End With
            Catch ex As Exception
                MsgBox("iVALID MONTH")
            End Try
        End If
        If menuname = "Monthly Company and Invoice Details" Then
            Moncominv.Visible = True
            Moncominv.Width = Monrepcom.Width
            Moncominv.Height = Monrepcom.Height
            Moncominv.Location = Monrepcom.Location
            Try
                QUERY = "SELECT COMID,COMNAME,COMADDR FROM BILLCOM_DETAILS WHERE extract(month from to_date(CRDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID"
                dt = selquery(QUERY)
                QUERY = "SELECT * FROM BILLINVOICE_DETAILS WHERE extract(month from to_date(INVDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt1 = selquery(QUERY)
                With Me.Moncominv.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmon", dtdate))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmoncom", dt))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsmoninv", dt1))
                End With
            Catch ex As Exception
                MsgBox("iVALID MONTH")
            End Try
        End If
        If menuname = "Monthly Company and Invoice and Product Details" Then
            Moncominvpro.Visible = True
            Moncominvpro.Width = Monrepcom.Width
            Moncominvpro.Height = Monrepcom.Height
            Moncominvpro.Location = Monrepcom.Location
            Try
                QUERY = "SELECT COMID,COMNAME,COMADDR FROM BILLCOM_DETAILS WHERE extract(month from to_date(CRDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID"
                dt = selquery(QUERY)
                QUERY = "SELECT * FROM BILLINVOICE_DETAILS WHERE extract(month from to_date(INVDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt1 = selquery(QUERY)
                QUERY = "Select * FROM BILLPRODUCT_DETAILS WHERE extract(month from to_date(PRCRDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt2 = selquery(QUERY)
                With Me.Moncominvpro.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmon", dtdate))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmoncom", dt))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsmoninv", dt1))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmonpro", dt2))
                End With
            Catch ex As Exception
                MsgBox("iVALID MONTH")
            End Try
        End If
        If menuname = "Monthly Invoice Details" Then
            Moninv.Visible = True
            Moninv.Width = Monrepcom.Width
            Moninv.Height = Monrepcom.Height
            Moninv.Location = Monrepcom.Location
            Try
                QUERY = "SELECT * FROM BILLINVOICE_DETAILS WHERE extract(month from to_date(INVDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt1 = selquery(QUERY)
                With Me.Moninv.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmon", dtdate))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsmoninv", dt1))
                End With
            Catch ex As Exception
                MsgBox("iVALID MONTH")
            End Try
        End If
        If menuname = "Monthly Invoice and Product Details" Then
            Moninvpro.Visible = True
            Moninvpro.Width = Monrepcom.Width
            Moninvpro.Height = Monrepcom.Height
            Moninvpro.Location = Monrepcom.Location
            Try
                QUERY = "SELECT * FROM BILLINVOICE_DETAILS WHERE extract(month from to_date(INVDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt1 = selquery(QUERY)
                QUERY = "Select * FROM BILLPRODUCT_DETAILS WHERE extract(month from to_date(PRCRDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt2 = selquery(QUERY)
                With Me.Moninvpro.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmon", dtdate))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsmoninv", dt1))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmonpro", dt2))
                End With
            Catch ex As Exception
                MsgBox("iVALID MONTH")
            End Try
        End If
        If menuname = "Monthly Product Details" Then
            Monpro.Visible = True
            Monpro.Width = Monrepcom.Width
            Monpro.Height = Monrepcom.Height
            Monpro.Location = Monrepcom.Location
            Try
                QUERY = "Select * FROM BILLPRODUCT_DETAILS WHERE extract(month from to_date(PRCRDATE,'dd-MM-yyyy')) ='" & dtfromdate.Text & "' ORDER BY COMID_FK"
                dt2 = selquery(QUERY)
                With Me.Monpro.LocalReport
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmon", dtdate))
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DSmonpro", dt2))
                End With
            Catch ex As Exception
                MsgBox("iVALID MONTH")
            End Try
        End If
    End Sub
    Public Function GetTable()
        Dim tabl As New DataTable
        tabl.Columns.Add("fromdate", GetType(String))
        tabl.Columns.Add("todate", GetType(String))
        Return tabl
    End Function
    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""
            Case 1
                Return "JANUARY "
            Case 2
                Return "FEBRUARY"
            Case 3
                Return "MARCH "
            Case 4
                Return "APRIL"
            Case 5
                Return "MAY"
            Case 6
                Return "JUNE"
            Case 7
                Return "JULY"
            Case 8
                Return "AUGUST"
            Case 9
                Return "SEPTEMBER"
            Case 10
                Return "OCTOBER"
            Case 11
                Return "NOVEMBER"
            Case 12
                Return "DECEMBER"
            Case Else
                Return ""
        End Select
    End Function
End Class