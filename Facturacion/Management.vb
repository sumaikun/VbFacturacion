Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports System.Drawing.Printing
Imports Facturacion.Code128Content
Imports Facturacion.Code128Rendering
Imports Facturacion.Printproperties
Imports Facturacion.ClientController
Imports Facturacion.Cliente
Imports Facturacion.FacturaController

Public Class Management
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim cliente As New Cliente
    Dim clientManager As New ClientController
    Dim Factura As New Factura
    Dim FacturaManager As New FacturaController

    Private Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hide_UserInterface()
        hide_ReceiptInterface()
        hidepsform()
        textdatabar.Visible = False
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        show_UserInterface()
        hide_ReceiptInterface()
    End Sub

    Private Sub pic_button_Click(sender As Object, e As EventArgs) Handles pic_button.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()
            photo_button.Enabled = True
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Userimage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub photo_button_Click(sender As Object, e As EventArgs) Handles photo_button.Click
        CAMERA.Stop()
    End Sub

    Private Sub ButtongenerateBarcode_Click(sender As Object, e As EventArgs) Handles ButtongenerateBarcode.Click
        Dim numberCode As String
        Dim n As Integer
        Dim rn As New Random
        numberCode = ""
        For index As Integer = 1 To 12
            n = rn.Next(0, 10)
            numberCode = numberCode + n.ToString
        Next
        Debug.WriteLine(numberCode)
        textdatabar.Text = numberCode
        pic_Codebar.Image = Code128Rendering.MakeBarcodeImage(numberCode, 1, True)

    End Sub

    Private Sub GenerarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarFacturaToolStripMenuItem.Click
        hide_UserInterface()
        show_ReceiptInterface()
        hidepsform()
    End Sub

    Private Sub show_UserInterface()
        Userimage.Visible = True
        Userimage.Image = My.Resources.No_picture
        Userimage.SizeMode = PictureBoxSizeMode.StretchImage

        LabelUsername.Visible = True
        LabelUserphone.Visible = True
        LabelUsermail.Visible = True
        LabelUserCode.Visible = True

        TextBoxUsername.Visible = True
        TextBoxUserphone.Visible = True
        TextBoxUsermail.Visible = True
        TextBoxUsercode.Visible = True
        ButtonSaveuser.Visible = True

        pic_button.Visible = True
        photo_button.Visible = True
        photo_button.Enabled = False

        ' sensorcode
        Labelbarcodename.Visible = True
        pic_Codebar.Visible = True
        ButtonCleanUser.Visible = True
        ButtongenerateBarcode.Visible = True
    End Sub

    Private Sub hide_UserInterface()
        Userimage.Visible = False
        LabelUsername.Visible = False
        LabelUserphone.Visible = False
        LabelUsermail.Visible = False
        LabelUserCode.Visible = False

        TextBoxUsername.Visible = False
        TextBoxUserphone.Visible = False
        TextBoxUsermail.Visible = False
        TextBoxUsercode.Visible = False

        ButtonSaveuser.Visible = False
        pic_button.Visible = False
        photo_button.Visible = False

        ' sensorcode
        Labelbarcodename.Visible = False
        pic_Codebar.Visible = False
        ButtonCleanUser.Visible = False
        ButtongenerateBarcode.Visible = False
    End Sub

    Private Sub show_ReceiptInterface()
        ' receipt
        LabelGenerateReceipt.Visible = True
        LabelbyCodeBar.Visible = True
        LabelByUserName.Visible = True
        CodeSearch.Visible = True
        TextBoxByCodeBar.Visible = True
        ButtonGenerateReceipt.Visible = True
        Labelvalor.Visible = True
        TextValor.Visible = True
    End Sub

    Private Sub hide_ReceiptInterface()
        ' receipt
        LabelGenerateReceipt.Visible = False
        LabelbyCodeBar.Visible = False
        LabelByUserName.Visible = False
        CodeSearch.Visible = False
        TextBoxByCodeBar.Visible = False
        ButtonGenerateReceipt.Visible = False
        Labelvalor.Visible = False
        TextValor.Visible = False
    End Sub

    Private Sub ButtonGenerateReceipt_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReceipt.Click
        If Me.ValidateChildren = True And CodeSearch.Text <> "" Or TextBoxByCodeBar.Text <> "" And TextValor.Text <> "" Then
            If IsNumeric(TextValor.Text) Then
                Console.WriteLine("imprime")
                Dim cliente = clientManager.search_code(CodeSearch.Text, TextBoxByCodeBar.Text)
                Factura.Id = FacturaManager.id_generator()
                Factura.Valor = TextValor.Text
                Factura.Userid = cliente.Id
                Factura.Fecha = Date.Today

                If cliente IsNot "Invalido" Then
                    Dim printing As New Printproperties()
                    printing.execute(cliente, Factura) 'Generar impresión'
                End If
            Else
                MessageBox.Show("El campo valor debe tener un numero valido", "Generar Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe rellenar alguno de los campos", "Generar Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonCleanUser_Click(sender As Object, e As EventArgs) Handles ButtonCleanUser.Click
        clean_costumer_data()

    End Sub
    Private Sub ButtonSaveuser_Click(sender As Object, e As EventArgs) Handles ButtonSaveuser.Click
        If Me.ValidateChildren = True And TextBoxUsername.Text <> "" And TextBoxUserphone.Text <> "" And TextBoxUsermail.Text <> "" And TextBoxUsercode.Text <> "" Then
            If pic_Codebar.Image IsNot Nothing Then

                Try
                    cliente.Id = clientManager.id_generator()
                    cliente.nombre = TextBoxUsername.Text
                    cliente.telefono = TextBoxUserphone.Text
                    cliente.correo = TextBoxUsermail.Text
                    cliente.cedula = TextBoxUsercode.Text

                    Dim image1 As New IO.MemoryStream()
                    Dim image2 As New IO.MemoryStream()

                    Userimage.Image.Save(image1, System.Drawing.Imaging.ImageFormat.Jpeg)
                    cliente.Foto = image1.GetBuffer
                    pic_Codebar.Image.Save(image2, System.Drawing.Imaging.ImageFormat.Jpeg)
                    cliente.Codigobarras = image2.GetBuffer
                    cliente.databar = textdatabar.Text
                    If clientManager.create_costumer(cliente) Then
                        MessageBox.Show("Cliente Guardado correctamente", "Guardando Cliente")
                        clean_costumer_data()
                    End If


                    Console.WriteLine("terminé")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Debe Generar codigo de barras", "Guardando Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe rellenar todos los campos", "Guardando Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub clean_costumer_data()
        Userimage.Visible = True
        Userimage.Image = My.Resources.No_picture
        Userimage.SizeMode = PictureBoxSizeMode.StretchImage

        TextBoxUsername.Clear()
        TextBoxUserphone.Clear()
        TextBoxUsermail.Clear()
        TextBoxUsercode.Clear()

        ' sensorcode
        pic_Codebar.Image = Nothing
    End Sub

    Private Sub hidepsform()
        textpas1.Visible = False
        textpas2.Visible = False
        labelps1.Visible = False
        labelps2.Visible = False
        btnps.Visible = False
    End Sub

    Private Sub showpsform()
        textpas1.Visible = True
        textpas2.Visible = True
        labelps1.Visible = True
        labelps2.Visible = True
        btnps.Visible = True
    End Sub

    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click
        Costumers.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        showpsform()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub VerFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFacturasToolStripMenuItem.Click
        Bills.Show()
    End Sub
End Class
