Imports Facturacion.UserController
Public Class LoginForm1

    Dim Usermanagement As New UserController

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim existence = Usermanagement.login(UsernameTextBox.Text, PasswordTextBox.Text)
        If existence = "Exits" Then
            Management.Show()
            Me.Close()
        Else
            MessageBox.Show("No existen los datos ingresados en el sistema", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
