﻿

Public Class Vclientes2
    Dim idcliente As Integer
    Dim nombres, apellidos, direccion, num_direccion, telefono, dni As String


    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property


    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gnumdireccion
        Get
            Return num_direccion
        End Get
        Set(ByVal value)
            num_direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gdni
        Get
            Return dni

        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal direccion As String, ByVal num_direccion As String, ByVal telefono As String, ByVal dni As String)
        gidcliente = idcliente
        gnombres = nombres
        gapellidos = apellidos
        gdireccion = direccion
        gnumdireccion = num_direccion
        gtelefono = telefono
        gdni = dni
    End Sub
End Class
