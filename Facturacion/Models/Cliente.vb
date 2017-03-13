Public Class Cliente
    Private _id As Integer
    Private _nombre As String
    Private _telefono As String
    Private _correo As String
    Private _cedula As String
    Private _foto As Byte()
    Private _codigobarras As Byte()
    Private _databar As String

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Foto As Byte()
        Get
            Return _foto
        End Get
        Set(value As Byte())
            _foto = value
        End Set
    End Property

    Public Property Codigobarras As Byte()
        Get
            Return _codigobarras
        End Get
        Set(value As Byte())
            _codigobarras = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property databar As String
        Get
            Return _databar
        End Get
        Set(value As String)
            _databar = value
        End Set
    End Property
End Class
