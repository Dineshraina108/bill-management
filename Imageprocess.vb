Imports System.Data.OracleClient
Imports System.IO
Imports System.IO.File
Imports System.IO.FileAccess
Imports System.IO.Stream
Imports Oracle.DataAccess.Client
Public Class Imageprocess
    Dim FileName As String
    Dim query As String
    Dim id As Integer = 0
    Private Sub Imageprocess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()
        Dim dt As New DataTable()
        Dim imgfile As New OpenFileDialog
        imgfile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        imgfile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif)"
        If (imgfile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            FileName = imgfile.FileName
            ' TODO: Add code here to open the file.
        End If
        query = "SELECT COUNT(*) FROM BILLIMAGE"
        dt = selquery(query)
        Try
            If dt.Rows(0)("COUNT(*)") > 0 Then
                id = dt.Rows(0)("COUNT(*)") + 1
            Else
                id = 1
            End If
            If Len(FileName) > 0 Then
                Dim fls As FileStream
                fls = New FileStream(FileName, FileMode.Open, FileAccess.Read)
                Dim fsize As Long = fls.Length
                Dim blob(fsize) As Byte
                fls.Read(blob, 0, System.Convert.ToInt32(fls.Length))
                fls.Close()
                query = "INSERT INTO BILLIMAGE VALUES(" & id & ",'" & FileName & "'," & " : blobParameter)"
                Dim blobParameter As New Oracle.DataAccess.Client.OracleParameter
                blobParameter.OracleDbType = OracleDbType.Blob
                blobParameter.ParameterName = "BlobParameter"
                blobParameter.Value = blob
                'insquery(query)
                Dim temp As Long = 0
                Using cmd As New Oracle.DataAccess.Client.OracleCommand(query, con)
                    cmd.Parameters.Add(blobParameter)
                    temp = cmd.ExecuteNonQuery()
                End Using
                If temp > 0 Then
                    MsgBox("Insert successfully")
                Else
                    MsgBox("values Not inserted")
                End If
            End If
        Catch ex As Exception
            MsgBox("no records available")
        End Try
        '  query = "insert into emp(id,name,photo) values(" + txtid.Text + "," + "'" + txtname.Text + "'," + " :BlobParameter )"
        dbclose()
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim dt As New DataTable()
        dbcon()
        query = "SELECT IMAGEID,IMAGENAME FROM BILLIMAGE WHERE IMAGEID = " & id & ""
                Try
                    dt = selquery(query)
                    If dt.Rows.Count > 0 Then
                        FileName = dt.Rows(0)("IMAGENAME").ToString
                        Imagebox.Image = New Bitmap(FileName)
                    End If
                Catch ex As Exception
                    MsgBox("no image available")
                End Try
                dbclose()
    End Sub
End Class