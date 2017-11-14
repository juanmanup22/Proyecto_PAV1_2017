Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class _acceso_datos
    Enum tipo_conexion
        simple
        transaccion
    End Enum

    Enum resultado_transaccion
        _ok
        _error
    End Enum
    Dim configuracion_conexion As tipo_conexion = tipo_conexion.simple
    Dim control_transaccion As resultado_transaccion = resultado_transaccion._ok



    Dim cadena As String = ""

    Dim conexion As New SqlConnection
    Dim cmd As New SqlCommand

    Dim transaccion As SqlTransaction

    Dim nombre_tabla As String = ""

    Public Property _cadena As String
        Get
            Return Me.cadena
        End Get
        Set(value As String)
            Me.cadena = value
        End Set
    End Property

    Public Property _nombre_tabla As String
        Get
            Return Me.nombre_tabla
        End Get
        Set(value As String)
            Me.nombre_tabla = value
        End Set
    End Property

    Public Sub iniciar_conexion_con_transaccion()
        Me.configuracion_conexion = tipo_conexion.transaccion
        Me.control_transaccion = resultado_transaccion._ok
    End Sub

    Public Sub cerrar_conexion_con_transaccion()
        If configuracion_conexion = tipo_conexion.transaccion Then
            If control_transaccion = resultado_transaccion._ok Then
                Me.transaccion.Commit()
                MsgBox("Presupuesto Guardado con Éxito!")
            Else
                Me.transaccion.Rollback()
                MsgBox("No se ha podido guardar el presupuesto")
            End If
            Me.configuracion_conexion = tipo_conexion.simple
            Me.desconectar()
        End If
    End Sub

    Private Sub conectar()
        If conexion.State.ToString() <> "Open" Then
            Me.conexion.ConnectionString = Me.cadena
            Me.conexion.Open()
            Me.cmd.Connection = conexion
            Me.cmd.CommandType = CommandType.Text

            'si el tipo de conexion es de transaccion, se configuran los objetos de transaccion
            If configuracion_conexion = tipo_conexion.transaccion Then
                Me.transaccion = conexion.BeginTransaction
                cmd.Transaction = transaccion
                control_transaccion = resultado_transaccion._ok
            End If
        End If
    End Sub

    Private Sub desconectar()
        If configuracion_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
    End Sub

    Public Function _ejectuar_sql(ByVal sql As String) As DataTable
        Me.conectar()
        If sql.Trim.ToUpper.IndexOf("SELECT") = 0 Then
            cmd.CommandText = sql
            Dim tabla As New DataTable

            Try
                tabla.Load(cmd.ExecuteReader)
            Catch ex As Exception
                control_transaccion = resultado_transaccion._error
                MessageBox.Show("Error SQL:" & ex.Message)
            End Try

            Me.desconectar()
            Return tabla
        Else
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                control_transaccion = resultado_transaccion._error
                MessageBox.Show("Error SQL:" & ex.Message)
            End Try

            Me.desconectar()
            Return New DataTable
        End If
    End Function

    Public Sub _insertar(ByVal datos As String)
        Dim estructura As DataTable = Me.consulto_estructura

        Dim pares() As String
        pares = datos.Split(";")

        Dim c As Integer = 0

        Dim est_col As String = ""
        Dim est_dat As String = ""


        For c = 0 To pares.Length - 1
            Dim columnas() As String
            columnas = pares(c).Split("=")

            Dim tipodato As String = ""
            Dim d As Integer = 0
            Dim encontre As Boolean = False

            For d = 0 To estructura.Columns.Count - 1

                If columnas(0).ToUpper.Trim = estructura.Columns(d).ColumnName.ToUpper.Trim Then
                    encontre = True
                    tipodato = estructura.Columns(0).DataType.Name

                End If

            Next

            If encontre = True Then
                est_col &= IIf(est_col = "", "", ", ") & columnas(0).Trim
                est_dat &= IIf(est_dat = "", "", ", ") & Me.formatear(columnas(1).Trim, tipodato)
            End If
        Next

        Dim txt_insert As String = ""
        txt_insert = "INSERT INTO " & Me.nombre_tabla & "( " _
                & est_col & ") VALUES (" & est_dat & ")"

        Me._ejectuar_sql(txt_insert)
    End Sub

    Private Function formatear(ByVal dato As String, ByVal tipoDato As String) As String
        Select Case tipoDato
            Case "String", "Date"
                Return "'" & dato & "'"
            Case Else
                Return dato
        End Select
    End Function

    Private Function consulto_estructura() As DataTable
        Return Me._ejectuar_sql("SELECT TOP 1 * FROM " & Me.nombre_tabla)
    End Function
End Class
