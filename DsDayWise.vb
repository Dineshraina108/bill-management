﻿Partial Class DsDayWise
    Partial Public Class DsdateDataTable
        Private Sub DsdateDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TODATEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
