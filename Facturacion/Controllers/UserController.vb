Imports System.Data.SqlClient
Public Class UserController
    Dim sqlconnect As New SqlConnection(My.Settings.conexion)
    Dim command As SqlCommand

    Public Function login(ByVal name As String, pass As String)
        Try
            sqlconnect.Open()

            Dim query = "SELECT  * FROM Usuarios where username = '" + name + "' and userpass = '" + pass + "'"
            Console.Write(query)
            Dim cmd As New SqlCommand(query, sqlconnect)
            If cmd.ExecuteScalar() Is Nothing Then
                Console.Write("No existe")
                Return "Noexists"
            Else
                'Return "Invalido"
                Console.Write("existe")
                Return "Exits"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            sqlconnect.Close()
        End Try
    End Function
End Class
