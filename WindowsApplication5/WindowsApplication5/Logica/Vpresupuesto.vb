Public Class Vpresupuesto
    Dim idpresupuesto, idcliente As Integer
    Dim fecha As Date
    Dim nom_cliente, ape_cliente As String
    Dim total As Double

    Public Property gidpresupuesto
        Get
            Return idpresupuesto

        End Get
        Set(ByVal value)
            idpresupuesto = value
        End Set
    End Property

    Public Property gidcliente
        Get
            Return idcliente

        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property

    Public Property gnom_cliente
        Get
            Return nom_cliente

        End Get
        Set(ByVal value)
            nom_cliente = value
        End Set
    End Property

    Public Property gape_cliente
        Get
            Return ape_cliente
        End Get
        Set(ByVal value)
            ape_cliente = value
        End Set
    End Property

    Public Property gtotal
        Get
            Return total
        End Get
        Set(ByVal value)
            total = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpresupuesto As Integer, ByVal idcliente As Integer, ByVal fecha As Date, ByVal nom_cliente As String, ByVal ape_cliente As String, ByVal total As Double)
        gidpresupuesto = idpresupuesto
        gidcliente = idcliente
        gfecha = fecha
        gnom_cliente = nom_cliente
        gape_cliente = ape_cliente
        gtotal = total
    End Sub
End Class
