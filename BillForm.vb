Imports Oracle.DataAccess.Client
Imports System.Text
Imports BILL_SYSTEM.billdsxsd
Public Class BillForm
    Dim query As String
    Dim grid As String = ""
    Dim billno As Integer = 0
    Public Shared pdt As New DataTable
    Public Shared billdt As DataTable
    Public Shared fread As String
    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        dbclose()
        Billproductpanel.Visible = True
        Billactbuttonpanel.Visible = True
        prpanel1.Visible = True
        Gridvalue()
        dbclose()
        BIllHomepanel.Update()

    End Sub
    Public Sub Gridvalue()
        Dim dt As New DataTable
        Dim amt As Integer = 0
        query = "SELECT PRID,PRNAME,PRQTY,PRRATE,PRAMOUNT FROM BILLPRODUCT_DETAILS WHERE INVNO_FK= " & CBinv.SelectedValue & ""
        dt = selquery(query)
        Try
            If dt.Rows.Count = 0 Then
                MsgBox("Product not  available ")
                RGVbill.DataSource = dt
            Else
                RGVbill.DataSource = dt
                For Each amtrow As DataRow In dt.Rows
                    amt = amt + amtrow.Item("PRAMOUNT")
                Next
                lblamt.Text = amt
                lblamoutinwords.Text = NumberToText(amt)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundreds " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousands " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Millions " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function
    Private Sub btnbill_Click(sender As Object, e As EventArgs) Handles btnbill.Click
        Dim bno As Integer = 0
        Billdetailspanel1.Visible = True
        prpanel1.Visible = False
        dbcon()
        txtbillno.Text = Getbill(bno)
        txtbilldate.Text = DateTime.Now.Date
        txtcomname.Text = CBcom.Text
        txtcomaddr.Text = GetAddr(CBcom.SelectedValue)
        Getinvdetails()
        dbclose()
        BIllHomepanel.Update()
        txtbillno.Focus()
    End Sub
    Public Function Getbill(ByRef billno As Integer)
        Dim dt As New DataTable
        query = "SELECT COUNT(*) FROM EBILL"
        dt = selquery(query)
        Try
            If dt.Rows(0)("COUNT(*)") > 0 Then
                billno = dt.Rows(0)("COUNT(*)") + 1
            Else
                billno = 1
            End If
        Catch ex As Exception
            MsgBox("RECORD NOT FOUND")
        End Try
        Return billno
    End Function
    Public Function GetAddr(ByRef id As Integer)
        Dim dt As New DataTable
        Dim addr As String
        query = "SELECT COMADDR FROM BILLCOM_DETAILS  WHERE COMID= " & id & ""
        dt = selquery(query)
        Try
            If dt.Rows(0)("COMADDR") = " " Then
                addr = " "
            Else
                addr = dt.Rows(0)("COMADDR").ToString
            End If
        Catch ex As Exception
            MsgBox("RECORD NOT FOUND")
            addr = " "
        End Try
        Return addr
    End Function
    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt, bt As New DataTable
        Dim bc As Integer
        dbcon()
        query = "SELECT COMID,COMNAME FROM BILLCOM_DETAILS"
        dt = selquery(query)
        Try
            If dt.Rows.Count = 0 Then
                MsgBox("No Company available in record")
                CBcom.DataSource = dt
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
            Else
                CBcom.DataSource = dt
                CBcom.DisplayMember = "COMNAME"
                CBcom.ValueMember = "COMID"
            End If
            query = "SELECT BILLNO FROM EBILL"
            bt = selquery(query)
            If bt.Rows.Count = 0 Then
                txtbillno.Text = 1
            Else
                bc = bt.Rows.Count
                txtbillno.Text = bt.Rows(bc - 1)("BILLNO") + 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
    End Sub
    Public Sub Getinvdetails()
        Dim dt As New DataTable
        query = "SELECT INVNO,INVDATE,SERIAL,INVLOCATION,CHALANNO FROM BILLINVOICE_DETAILS WHERE INVID= " & CBinv.SelectedValue & ""
        dt = selquery(query)
        Try
            If dt.Rows.Count > 0 Then
                txtinvno.Text = dt.Rows(0)("INVNO").ToString
                txtinvdate.Text = dt.Rows(0)("INVDATE").ToString
                txtserial.Text = dt.Rows(0)("SERIAL").ToString
                txtlocation.Text = dt.Rows(0)("INVLOCATION").ToString
                txtchano.Text = dt.Rows(0)("CHALANNO").ToString
            Else
                txtinvno.Text = ""
                txtinvdate.Text = ""
                txtserial.Text = ""
                txtlocation.Text = ""
                txtchano.Text = ""
            End If
        Catch ex As Exception
            MsgBox("RECORD NOT FOUND")
        End Try
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
                    CBinv.DataSource = dt
                    CBinv.DisplayMember = "INVNO"
                    CBinv.ValueMember = "INVID"
                    CBinv.Focus()
                Else
                    CBinv.DataSource = dt
                    CBinv.DisplayMember = "INVNO"
                    CBinv.ValueMember = "INVID"
                    CBinv.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                CBinv.Focus()
            End Try
        End If
        dbclose()
    End Sub

    Private Sub CBinv_KeyDown(sender As Object, e As KeyEventArgs) Handles CBinv.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnbill.Focus()
        End If
    End Sub

    Private Sub txtbillno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbillno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbilldate.Focus()
        End If
    End Sub

    Private Sub txtbilldate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbilldate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcomname.Focus()
        End If
    End Sub

    Private Sub txtcomname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcomaddr.Focus()
        End If
    End Sub

    Private Sub txtcomaddr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomaddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtinvno.Focus()
        End If
    End Sub

    Private Sub txtinvno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtinvdate.Focus()
        End If
    End Sub

    Private Sub txtinvdate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvdate.KeyDown
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
            txtchano.Focus()
        End If
    End Sub

    Private Sub txtchano_KeyDown(sender As Object, e As KeyEventArgs) Handles txtchano.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnproduct.Focus()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        formclear()
        BIllHomepanel.Update()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        formclear()
        Billselpanel.Visible = True
        Billdetailspanel1.Visible = False
        prpanel1.Visible = False
        BIllHomepanel.Update()
    End Sub
    Public Sub formclear()
        Dim dt As New DataTable
        txtbillno.Text = ""
        txtbilldate.Text = ""
        txtcomname.Text = ""
        txtcomaddr.Text = ""
        txtinvno.Text = ""
        txtinvdate.Text = ""
        txtserial.Text = ""
        txtlocation.Text = ""
        txtchano.Text = ""
        lblamoutinwords.Text = "amoutinwords"
        lblamt.Text = 0
        RGVbill.DataSource = dt
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim bino As Integer = 0
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim Bill_Details As DataTable = GetTable()
        billdt = GetTable()
        pdt = RGVbill.DataSource
        dbcon()
        query = "SELECT COUNT(*) FROM EBILL"
        dt = selquery(query)
        Try
            If dt.Rows(0)("COUNT(*)") < 0 Then
                bino = 1
            Else
                bino = dt.Rows(0)("COUNT(*)")
            End If
            query = "INSERT INTO EBILL VALUES(" & bino & ",'" & txtbilldate.Text & "')"
            insquery(query)
            dr = billdt.NewRow()
            dr("ID") = txtbillno.Text
            dr("BILLNO") = txtbillno.Text
            dr("BILLDATE") = txtbilldate.Text
            dr("COMNAME") = txtcomname.Text
            dr("COMADDR") = txtcomaddr.Text
            dr("INVNO") = txtinvno.Text
            dr("INVDATE") = txtinvdate.Text
            dr("SERIAL") = txtserial.Text
            dr("LOCATION") = txtlocation.Text
            dr("CHALANNO") = txtchano.Text
            dr("TOTALAMOUNT") = lblamt.Text
            dr("TOAMOUNTINWORDS") = lblamoutinwords.Text
            'Bill_Details.Rows.Add(dr)
            billdt.Rows.Add(dr)
            ' ds.Bill_Details.AddBill_DetailsRow(dr)
            ' ds.Bill_Details.ImportRow(dr)
            dbclose()
            Dim re As New Billreport
            re.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
        ' dsNew.Tables.Add(dt)
        'DataTable dt = ds.Tables["vendor"];
    End Sub
    Public Function GetTable()
        Dim tabl As New DataTable
        tabl.Columns.Add("ID", GetType(Integer))
        tabl.Columns.Add("BILLNO", GetType(Integer))
        tabl.Columns.Add("BILLDATE", GetType(String))
        tabl.Columns.Add("COMNAME", GetType(String))
        tabl.Columns.Add("COMADDR", GetType(String))
        tabl.Columns.Add("INVNO", GetType(Integer))
        tabl.Columns.Add("INVDATE", GetType(String))
        tabl.Columns.Add("SERIAL", GetType(Integer))
        tabl.Columns.Add("LOCATION", GetType(String))
        tabl.Columns.Add("CHALANNO", GetType(Integer))
        tabl.Columns.Add("TOTALAMOUNT", GetType(Integer))
        tabl.Columns.Add("TOAMOUNTINWORDS", GetType(String))
        Return tabl
    End Function
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim billname As String = "Bill" & txtbillno.Text & ""
        Dim dt As New DataTable
        Dim path As String
        path = "E:\DINESHKUMAR B\BILL MANAGEMENT SYSTEM\REPORT DATA\BILL\" & billname & ".txt"
        '  p = "E:\DINESHKUMAR B\Ebill\bill report\Bill.txt"
        dt = RGVbill.DataSource
        dbcon()
        Try
            If Chksave.Checked = True Then
                Dim fwrite As New System.IO.StreamWriter(path)
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(5) & " BILL NO :  " & txtbillno.Text & " " & Space(50) & "E-BILL SYSTEM " & Space(68) & "BILL DATE : " & txtbilldate.Text & "")
                fwrite.WriteLine(" " & Space(80) & "-----------------------------------")
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(5) & " COMPANY NAME : " & txtcomname.Text & " " & Space(Len(txtcomname.Text) + 50) & "INVO :  " & txtinvno.Text & "")
                fwrite.WriteLine(" " & Space(5) & " COMPANY ADDRESS : " & txtcomaddr.Text & " " & Space(Len(txtcomname.Text)) & " INVOICE DATE : " & txtinvdate.Text & "")
                fwrite.WriteLine(" " & Space(120) & " SERIAL : " & txtserial.Text & "")
                fwrite.WriteLine(" " & Space(120) & " LOCATION : " & txtlocation.Text & "")
                fwrite.WriteLine(" " & Space(120) & " CHALAN NO : " & txtchano.Text & "")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                fwrite.WriteLine(" ")
                ' fwrite.Close()
                'datatablewrite(dt, p)
                For Each cell As DataColumn In dt.Columns
                    grid += cell.ToString + vbTab & vbTab
                    'gridvalue += vbTab
                Next
                fwrite.WriteLine("" & Space(5) & " " & grid & "")
                grid = ""
                grid = PrintTable(dt)
                fwrite.WriteLine("" & Space(5) & " " & grid & "")
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(5) & " " & lblamoutinwords.Text & "" & Space(110) & " TOTAL AMOUNT : " & lblamt.Text & "")
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                fwrite.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dbclose()
        fread = My.Computer.FileSystem.ReadAllText(path)
        Dim re As New Repfile
        re.txtfile.Text = fread
        re.Show()
    End Sub
    Public Function PrintTable(ByVal dt As DataTable)
        Dim dtReader As DataTableReader = dt.CreateDataReader()
        Dim result As New StringBuilder
        While dtReader.Read()
            For i As Integer = 0 To dtReader.FieldCount - 1
                result.AppendFormat(Space(10) & "{1}" & Space(18) & "",
                dtReader.GetName(i).Trim(),
                dtReader.GetValue(i).ToString().Trim())
                'result.AppendLine()
            Next
            result.AppendLine(" ")
        End While
        dtReader.Close()
        Return result.ToString()
    End Function

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        dbcon()
        query = "DELETE FROM EBILL WHERE BILLNO=" & txtbillno.Text & ""
        delquery(query)
        formclear()
        BIllHomepanel.Update()
        dbclose()
    End Sub
End Class