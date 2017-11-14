Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class FConexion
    Public enunciado As SqlCommand
    Public respuesta As SqlDataAdapter
    Protected cnn As SqlConnection

    Private Shared string_conexion As String = "Data Source=supernova;Initial Catalog=dbventas;Integrated Security=True"

    Public Function FnConectado()
        Try
            cnn = New SqlConnection("Data Source=supernova;Initial Catalog=dbventas;Integrated Security=True")
            cnn.Open()
            'MsgBox("Te conectaste a la BD")
            Return True
        Catch ex As Exception
            MsgBox("Error al conectarse" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function

    Public Function FnDesconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al conectarse" + vbCrLf + ex.Message)
            Return False
        End Try

    End Function

    Private Shared Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' La función ConsultaSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader())
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Shared Function GetProductos() As DataTable
        Dim strSQL As String = "SELECT idproducto,nombre FROM producto"
        Return Fconexion.ConsultaSQL(strSQL)
    End Function
End Class
