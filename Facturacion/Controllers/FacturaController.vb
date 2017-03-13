Imports System.Data.SqlClient
Imports Facturacion.Factura

Public Class FacturaController
    Dim sqlconnect As New SqlConnection(My.Settings.conexion)
    Dim command As SqlCommand
    Dim show_Bills As DataTable

    Public Function id_generator()

        Try
            sqlconnect.Open()
            Dim query = "SELECT max(id) FROM Facturas"
            Dim cmd As New SqlCommand(query, sqlconnect)
            Dim id As Int32
            If cmd.ExecuteScalar() Is DBNull.Value Then
                Console.Write("nulo")
                id = 1
            Else
                Console.Write("no nulo")
                id = Convert.ToInt32(cmd.ExecuteScalar()) + 1
            End If
            Console.WriteLine("valor final id factura" + id.ToString)
            Return id
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            sqlconnect.Close()
        End Try
    End Function

    Public Function create_Factura(ByVal data As Factura)
        Try
            sqlconnect.Open()
            command = New SqlCommand("register_bill", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@idbill", data.Id)
                .AddWithValue("@idCostumer", data.Userid)
                .AddWithValue("@date", data.Fecha)
                .AddWithValue("@value", data.Valor)
            End With

            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            sqlconnect.Close()
        End Try
    End Function

    Public Function show_billing() As DataTable
        Try
            sqlconnect.Open()
            command = New SqlCommand("show_billing", sqlconnect)

            If command.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(command)
                show_Bills = New DataTable
                da.Fill(show_Bills)

                Return show_Bills
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            sqlconnect.Close()
        End Try

    End Function

    Public Function state_bill(ByVal data As Integer)
        Try
            sqlconnect.Open()
            command = New SqlCommand("state_bill", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@idbill", data)
            End With

            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            sqlconnect.Close()
        End Try
    End Function

    Public Function show_billing2() As DataTable
        Try
            sqlconnect.Open()
            command = New SqlCommand("show_billing2", sqlconnect)

            If command.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(command)
                show_Bills = New DataTable
                da.Fill(show_Bills)

                Return show_Bills
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            sqlconnect.Close()
        End Try

    End Function

End Class
