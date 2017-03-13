Public Class Factura
    Private _id As Integer
    Private _userid As Integer
    Private _fecha As String
    Private _valor As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Userid As Integer
        Get
            Return _userid
        End Get
        Set(value As Integer)
            _userid = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Valor As Integer
        Get
            Return _valor
        End Get
        Set(value As Integer)
            _valor = value
        End Set
    End Property
End Class
