Imports System.Data.SqlClient

Public Class Fusuario
    Inherits FConexion
    Dim cmd As New SqlCommand


    Public Function validar_usuario(ByVal dts As Vusuario)
        Try
            FnConectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)


            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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
