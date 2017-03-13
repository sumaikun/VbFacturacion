Imports Facturacion.Cliente
Imports Facturacion.ClientController
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class Costumers
    Dim CAMERA As VideoCaptureDevice
    Dim cliente As New Cliente
    Dim clientManager As New ClientController
    Dim bmp As Bitmap
    Private Sub Costumers_load(sender As Object, E As EventArgs) Handles MyBase.Load
        hide_form()
        Show_data()
    End Sub
    Private Sub Show_data()
        DataGridView1.DataSource = clientManager.show_costumer()
        DataGridView1.Visible = True
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(0).Visible = False
        PictureBox1.Image = My.Resources.No_picture
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        btnCostumerDelete.Visible = True
        btnCostumerDelete.Visible = True
        hide_form()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If IsDBNull(DataGridView1.SelectedCells.Item(5).Value) Then
            PictureBox1.Image = My.Resources.No_picture
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            Dim i() As Byte = DataGridView1.SelectedCells.Item(5).Value
            Dim ms As New IO.MemoryStream(i)
            PictureBox1.Image = Image.FromStream(ms)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Dim o() As Byte = DataGridView1.SelectedCells.Item(6).Value
        Dim ms2 As New IO.MemoryStream(o)
        PictureBox2.Image = Image.FromStream(ms2)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    Private Sub hide_form()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        btn_Cancelar.Visible = False
        btn_cambiar.Visible = True
        PictureBox2.Visible = True

        pic_button.Visible = False
        photo_button.Visible = False
    End Sub

    Private Sub show_form()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True

        btn_Cancelar.Visible = True
        btn_cambiar.Visible = False
        btnCostumerDelete.Visible = True

        PictureBox2.Visible = False

        pic_button.Visible = True
        photo_button.Visible = True
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Show_data()
    End Sub

    Private Sub btnCostumerDelete_Click(sender As Object, e As EventArgs) Handles btnCostumerDelete.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Eliminando Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            clientManager.delete_costumer(TextBox5.Text)
            MessageBox.Show("Cliente eliminado", "Eliminando Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Show_data()
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_cambiar.Click
        TextBox1.Text = DataGridView1.SelectedCells.Item(1).Value
        TextBox2.Text = DataGridView1.SelectedCells.Item(2).Value
        TextBox3.Text = DataGridView1.SelectedCells.Item(3).Value
        TextBox4.Text = DataGridView1.SelectedCells.Item(4).Value
        TextBox5.Text = DataGridView1.SelectedCells.Item(0).Value

        DataGridView1.Visible = False
        show_form()

    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If DataGridView1.Rows.Count = 1 Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            Exit Sub
        Else
            TextBox1.Text = DataGridView1.SelectedCells.Item(1).Value
            TextBox2.Text = DataGridView1.SelectedCells.Item(2).Value
            TextBox3.Text = DataGridView1.SelectedCells.Item(3).Value
            TextBox4.Text = DataGridView1.SelectedCells.Item(4).Value
            TextBox5.Text = DataGridView1.SelectedCells.Item(0).Value

            Dim i() As Byte = DataGridView1.SelectedCells.Item(5).Value
            Dim ms As New IO.MemoryStream(i)
            PictureBox1.Image = Image.FromStream(ms)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Dim o() As Byte = DataGridView1.SelectedCells.Item(6).Value
            Dim ms2 As New IO.MemoryStream(o)
            PictureBox2.Image = Image.FromStream(ms2)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
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
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub photo_button_Click(sender As Object, e As EventArgs) Handles photo_button.Click
        CAMERA.Stop()
    End Sub

    Private Sub btnCostumerEdit_Click(sender As Object, e As EventArgs) Handles btnCostumerEdit.Click
        If Me.ValidateChildren = True And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            cliente.Id = TextBox5.Text
            cliente.nombre = TextBox1.Text
            cliente.telefono = TextBox2.Text
            cliente.correo = TextBox3.Text
            cliente.cedula = TextBox4.Text
            Dim image1 As New IO.MemoryStream()
            Dim image2 As New IO.MemoryStream()

            PictureBox1.Image.Save(image1, System.Drawing.Imaging.ImageFormat.Jpeg)
            cliente.Foto = image1.GetBuffer


            If clientManager.edit_costumer(cliente) Then
                MessageBox.Show("Cliente Editado correctamente", "Modificando Cliente")
                Show_data()
            End If
        Else
            MessageBox.Show("Debe rellenar todos los campos", "Modificando Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class