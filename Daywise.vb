Public Class Daywise
    Public fromdate, todate As String
    Public Property Getfrdate() As String
        Get
            Return fromdate
        End Get
        Set(ByVal Value As String)
            fromdate = Value
        End Set
    End Property
    Public Property Gettodate() As String
        Get
            Return todate
        End Get
        Set(ByVal Value As String)
            todate = Value
        End Set
    End Property
End Class
