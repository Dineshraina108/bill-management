Partial Class billdsxsd
    Partial Public Class Bill_DetailsDataTable
        Private Sub Bill_DetailsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
