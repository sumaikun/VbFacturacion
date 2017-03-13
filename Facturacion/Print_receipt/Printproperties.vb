Imports System.Drawing.Printing
Imports Facturacion.Cliente
Imports Facturacion.Factura
Imports Facturacion.FacturaController
Public Class Printproperties
    Dim TextToPrint As String = ""
    Dim PrintDocument1 As New PrintDocument()
    Dim PrintPreviewDialog1 As New PrintPreviewDialog
    Dim cliente As New Cliente
    Dim Factura As New Factura
    Dim FacturaManager As New FacturaController


    Public Sub PrintHeader()

        TextToPrint = ""

        'send Business Name
        Dim StringToPrint As String = "SYNERGYM"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= Environment.NewLine & spcLen1 & StringToPrint & Environment.NewLine

        StringToPrint = "Centro de"
        LineLen = StringToPrint.Length
        Dim spcLen0 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen0 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "Acondicionamiento Deportivo"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        StringToPrint = "Nit. 79.593.679-1"
        LineLen = StringToPrint.Length
        Dim spcLenx As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLenx & StringToPrint & Environment.NewLine

        StringToPrint = "Regimen simplificado"
        LineLen = StringToPrint.Length
        Dim spcLeny As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLenx & StringToPrint & Environment.NewLine

        ' send city, state, zip
        StringToPrint = "Av suba Cr.111#114-12 piso 3-4"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

        ' send phone number
        StringToPrint = "688-67-47"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        StringToPrint = "No." + Factura.Id.ToString
        LineLen = StringToPrint.Length
        Dim spcLenn As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLenn & StringToPrint & Environment.NewLine

        StringToPrint = "Fecha." + Factura.Fecha.ToString
        LineLen = StringToPrint.Length
        Dim spcLennX As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLennX & StringToPrint & Environment.NewLine


    End Sub

    Public Sub ItemsToBePrinted()


        Dim StringToPrint As String = cliente.nombre.Substring(0, 25)
        Dim StringToPrint2 As String = cliente.cedula
        Dim StringToPrint3 As String = cliente.telefono
        Dim StringToPrint4 As String = Factura.Valor

        TextToPrint &= Environment.NewLine & Environment.NewLine
        TextToPrint &= Environment.NewLine & Environment.NewLine
        TextToPrint &= Environment.NewLine & Environment.NewLine
        TextToPrint &= Environment.NewLine & Environment.NewLine
        TextToPrint &= Environment.NewLine & Environment.NewLine
        TextToPrint &= " Descripción" & Environment.NewLine & Environment.NewLine
        TextToPrint &= "  nombre:" & StringToPrint & Environment.NewLine
        TextToPrint &= "  cc:" & StringToPrint2 & Environment.NewLine
        TextToPrint &= "  telefono:" & StringToPrint3 & Environment.NewLine
        TextToPrint &= "  $" & StringToPrint4
    End Sub

    Public Sub printFooter()


        Dim StringToPrint As String = "No es letra de cambio"
        Dim LineLen As String = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((30 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen5 & StringToPrint & Environment.NewLine
        Dim StringToPrint2 As String = "--------------------------------------------------------"
        TextToPrint &= Environment.NewLine & StringToPrint2 & Environment.NewLine




    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As PrintPageEventArgs)
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With
        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer

        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(cliente.Foto)
        Dim newImage As Image = System.Drawing.Image.FromStream(ms)
        e.Graphics.DrawImage(newImage, 80, 155, 150, 150)

        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)
        Dim ms2 As System.IO.MemoryStream = New System.IO.MemoryStream(cliente.Codigobarras)
        Dim barcode As Image = System.Drawing.Image.FromStream(ms2)
        w = barcode.Width
        h = barcode.Height
        e.Graphics.DrawImage(barcode, 70, 450, w, h)

        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If



    End Sub





    Public Sub execute(ByVal data As Cliente, ByVal fact As Factura)
        cliente = data
        Factura = fact
        PrintDocument1.PrinterSettings.PrinterName = "EPSON TM-T20II Receipt"
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
            'AddHandler PrintDocument1.EndPrint, AddressOf PrintDocument1_BeginPrint
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            If FacturaManager.create_Factura(Factura) Then
                MessageBox.Show("Se ha generado factura con el cons." + Factura.Id.ToString, "Generando Factura")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
