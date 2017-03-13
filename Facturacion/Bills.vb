Imports Facturacion.ClientController
Imports Facturacion.Cliente
Imports Facturacion.Factura
Imports Facturacion.FacturaController
Public Class Bills
    Dim FacturaManager As New FacturaController
    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_data()
    End Sub

    Private Sub show_data()
        DataGridView1.DataSource = FacturaManager.show_billing

        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        Button3.Visible = True
        Button4.Visible = False
    End Sub

    Private Sub show_data2()
        DataGridView1.DataSource = FacturaManager.show_billing2

        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        Button4.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Label1.Text = DataGridView1.SelectedCells.Item(3).Value
        Label2.Text = DataGridView1.SelectedCells.Item(4).Value
        Label3.Text = DataGridView1.SelectedCells.Item(5).Value
        Dim o() As Byte = DataGridView1.SelectedCells.Item(6).Value
        Dim ms2 As New IO.MemoryStream(o)
        PictureBox1.Image = Image.FromStream(ms2)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If DataGridView1.Rows.Count = 0 Then
            Label1.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            PictureBox1.Image = My.Resources.No_picture
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Exit Sub
        Else
            Label1.Text = DataGridView1.SelectedCells.Item(3).Value
            Label2.Text = DataGridView1.SelectedCells.Item(4).Value
            Label3.Text = DataGridView1.SelectedCells.Item(5).Value
            Dim o() As Byte = DataGridView1.SelectedCells.Item(6).Value
            Dim ms2 As New IO.MemoryStream(o)
            PictureBox1.Image = Image.FromStream(ms2)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Seguro que desea anular esta factura?", "Anular Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                FacturaManager.state_bill(DataGridView1.SelectedCells.Item(0).Value)
                MessageBox.Show("Factura anulada", "Anular Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                show_data()
            Catch ex As Exception
                MessageBox.Show("No hay factura para anular", "Anular Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        show_data2()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        show_data()
    End Sub
End Class