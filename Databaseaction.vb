Imports Oracle.DataAccess.Client
Imports System.IO
Imports System.Text

Module Databaseaction
    Dim query, title, Griddata As String
    Dim filename, path As String
    Dim le, le1, le2 As Long
    Public con As New OracleConnection
    Public Sub dbcon()
        con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        con.Open()
    End Sub
    Public Sub dbclose()
        con.Close()
    End Sub
    Public Sub insquery(ByRef query As String)
        Dim temp As Long = 0
        Try
            Using cmd As New OracleCommand(query, con)
                temp = cmd.ExecuteNonQuery()
            End Using
            If temp > 0 Then
                MsgBox("Insert successfully")
            Else
                MsgBox("values not inserted")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Sub updquery(ByRef query As String)
        Dim temp As Long = 0
        Try
            Using cmd As New OracleCommand(query, con)
                temp = cmd.ExecuteNonQuery()
            End Using
            If temp > 0 Then
                MsgBox("Updated successfully")
            Else
                MsgBox("values not update")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Sub delquery(ByRef query As String)
        Dim temp As Long = 0
        Try
            Using cmd As New OracleCommand(query, con)
                temp = cmd.ExecuteNonQuery()
            End Using
            If temp > 0 Then
                MsgBox("Deleted successfully")
            Else
                MsgBox("Row not Deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Function selquery(ByRef query As String)
        Dim dt As New DataTable
        Try
            Using cmd As New OracleCommand(query, con)
                Using ada As New OracleDataAdapter(cmd)
                    ada.Fill(dt)
                End Using
            End Using
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                MsgBox("THERE IS NO ROW IN TABLE")
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return dt
        End Try
    End Function
    Public Sub createfile(ByRef fpath As String, ByVal dt As DataTable, ByRef mname As String)
        path = fpath
        title = mname
        Try
            Dim fwrite As New System.IO.StreamWriter(path)
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(50) & "BILL MANAGEMENT SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(50) & "")
            le = Len(" " & Space(50) & "BILL MANAGEMENT SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(50) & "")
            le1 = Len("" & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(50) & "")
            For i As Integer = 0 To le
                fwrite.Write("-")
            Next
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(50) & " " & title & " " & Space(le1) & "")
            fwrite.WriteLine(" ")
            If mname = "Invoice Details" Then
                For Each cell As DataColumn In dt.Columns
                    Griddata += cell.ToString + vbTab & Space(5)
                Next
            Else
                For Each cell As DataColumn In dt.Columns
                    Griddata += cell.ToString + vbTab & Space(15)
                Next
            End If
            fwrite.WriteLine(Griddata & " " & Space(le1))
            le2 = Len("" & Space(10) & " " & Griddata & " " & Space(le1) & " ")
            For i As Integer = 0 To le
                fwrite.Write("-")
            Next
            Griddata = ""
            fwrite.WriteLine(" ")
            Griddata = PrintTable(dt, mname)
            fwrite.WriteLine(" " & Space(10) & " " & Griddata & " ")
            fwrite.WriteLine(" ")
            For i As Integer = 0 To le
                fwrite.Write("-")
            Next
            fwrite.Close()
        Catch ex As Exception
            MsgBox("File not create")
        End Try

    End Sub
    Public Function PrintTable(ByVal dt As DataTable, ByRef mname As String)
        Dim dtReader As DataTableReader = dt.CreateDataReader()
        Dim result As New StringBuilder
        If mname = "Invoice Details" Then
            While dtReader.Read()
                For i As Integer = 0 To dtReader.FieldCount - 1
                    If i = 0 Then
                        result.AppendFormat(Space(10) & "{1}" & Space(20) & " ",
                        dtReader.GetName(i).Trim(),
                        dtReader.GetValue(i).ToString().Trim())
                    Else
                        result.AppendFormat("{1}" & Space(20) & " ",
                        dtReader.GetName(i).Trim(),
                        dtReader.GetValue(i).ToString().Trim())
                    End If
                    'result.AppendLine()
                Next
                result.AppendLine(" ")
            End While
            dtReader.Close()
        Else
            While dtReader.Read()
                For i As Integer = 0 To dtReader.FieldCount - 1
                    If i = 0 Then
                        result.AppendFormat(Space(10) & "{1}" & Space(15) & " ",
                        dtReader.GetName(i).Trim(),
                        dtReader.GetValue(i).ToString().Trim())
                    Else
                        result.AppendFormat("{1}" & Space(20) & " ",
                        dtReader.GetName(i).Trim(),
                        dtReader.GetValue(i).ToString().Trim())
                    End If
                    'result.AppendLine()
                Next
                result.AppendLine(" ")
            End While
            dtReader.Close()
        End If
        Return result.ToString()
    End Function
End Module
