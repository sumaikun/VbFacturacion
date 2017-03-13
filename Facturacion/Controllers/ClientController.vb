Imports System.Data.SqlClient
Imports Facturacion.Cliente
Public Class ClientController
    Dim sqlconnect As New SqlConnection(My.Settings.conexion)
    Dim command As SqlCommand
    Dim show_Costumers As DataTable

    Public Function create_costumer(ByVal data As Cliente)
        Try
            sqlconnect.Open()
            command = New SqlCommand("register_costumer", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@idCostumer", data.Id)
                .AddWithValue("@nameCostumer", data.nombre)
                .AddWithValue("@phoneCostumer", data.telefono)
                .AddWithValue("@mailCostumer", data.correo)
                .AddWithValue("@codeCostumer", data.cedula)
                .AddWithValue("@ImageCostumer", data.Foto)
                .AddWithValue("@barCodeCostumer", data.Codigobarras)
                .AddWithValue("@databar", data.databar)
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

    Public Function edit_costumer(ByVal data As Cliente)
        Try
            sqlconnect.Open()
            command = New SqlCommand("update_costumer", sqlconnect)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@idCostumer", data.Id)
                .AddWithValue("@nameCostumer", data.nombre)
                .AddWithValue("@phoneCostumer", data.telefono)
                .AddWithValue("@mailCostumer", data.correo)
                .AddWithValue("@codeCostumer", data.cedula)
                .AddWithValue("@ImageCostumer", data.Foto)

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

    Public Function delete_costumer(ByVal id As Int32)
        Try
            sqlconnect.Open()
            command = New SqlCommand("delete_costumer", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@idCostumer", id)
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

    Public Function id_generator()
        Console.WriteLine("llegue al controlador")
        Try
            sqlconnect.Open()
            Dim query = "SELECT max(id) FROM Clientes"
            Dim cmd As New SqlCommand(query, sqlconnect)
            Dim id As Int32
            If cmd.ExecuteScalar() Is DBNull.Value Then
                Console.Write("nulo")
                id = 1
            Else
                Console.Write("no nulo")
                id = Convert.ToInt32(cmd.ExecuteScalar()) + 1
            End If
            Console.WriteLine("valor final id" + id.ToString)
            Return id
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            sqlconnect.Close()
        End Try
    End Function
    Public Function search_code(ByVal code As String, ByVal databar As String)
        Try
            sqlconnect.Open()

            Dim query = "SELECT TOP 1 * FROM Clientes where cedula = '" + code + "' or databar ='" + databar + "'"
            Console.Write(query)
            Dim cmd As New SqlCommand(query, sqlconnect)
            If cmd.ExecuteNonQuery() Then
                Dim cliente As New Cliente
                Dim da As New SqlDataAdapter(cmd)
                Dim dataSet As DataSet = New DataSet()
                da.Fill(dataSet)
                cliente.Id = Integer.Parse(dataSet.Tables(0).Rows(0)(0).ToString())
                cliente.nombre = dataSet.Tables(0).Rows(0)(1).ToString()
                cliente.telefono = dataSet.Tables(0).Rows(0)(2).ToString()
                cliente.correo = dataSet.Tables(0).Rows(0)(3).ToString()
                cliente.cedula = dataSet.Tables(0).Rows(0)(4).ToString()
                cliente.Foto = dataSet.Tables(0).Rows(0)(5)
                cliente.Codigobarras = dataSet.Tables(0).Rows(0)(6)
                Return cliente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("No existen los datos ingresados en el sistema", "Generar Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return "Invalido"
        Finally
            sqlconnect.Close()
        End Try
    End Function
    Public Function show_costumer() As DataTable
        Try
            sqlconnect.Open()
            command = New SqlCommand("show_costumer", sqlconnect)

            If command.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(command)
                show_Costumers = New DataTable
                da.Fill(show_Costumers)

                Return show_Costumers
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
