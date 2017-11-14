Imports System.Data.SqlClient

Public Class FPresupuesto
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function insertar(ByVal dts As Vpresupuesto) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_presupuesto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@nom_cliente", dts.gnom_cliente)
            cmd.Parameters.AddWithValue("@ape_cliente", dts.gape_cliente)
            cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
            cmd.Parameters.AddWithValue("@total", dts.gtotal)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()
        End Try
    End Function
End Class
