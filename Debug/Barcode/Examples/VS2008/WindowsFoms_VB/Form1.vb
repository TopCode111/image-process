Imports Limilabs.Barcode

Public Class Form1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles button1.Click
        Dim b As BaseBarcode
        b = BarcodeFactory.GetBarcode(Symbology.I2of5)

        b.Number = "123456789"
        b.ChecksumAdd = True
        b.Rotation = RotationType.Degrees90
        pictureBox1.Image = b.Render()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, ByVal e As Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        e.Graphics.PageUnit = GraphicsUnit.Pixel

        Dim b As BaseBarcode = BarcodeFactory.GetBarcode(Symbology.I2of5)
        b.Number = "123456789"
        b.ChecksumAdd = True
        b.Rotation = RotationType.Degrees90

        b.Height = CentimetersToPixels(2.5, e.Graphics.DpiY)
        ' 2.5 cm
        b.NarrowBarWidth = CentimetersToPixels(0.05, e.Graphics.DpiX)
        ' 0.05 cm = 0.5 mm
        b.Render(e.Graphics, CentimetersToPixels(1.0, e.Graphics.DpiX), CentimetersToPixels(1.0, e.Graphics.DpiY))
    End Sub

    Private Shared Function InchesToPixels(ByVal inches As Double, ByVal dpi As Double) As Integer
        Return CInt(dpi * inches)
    End Function

    Private Shared Function CentimetersToPixels(ByVal centimeters As Double, ByVal dpi As Double) As Integer
        Return CInt(dpi * CentimetersToInches(centimeters))
    End Function

    Private Shared Function CentimetersToInches(ByVal d As Double) As Double
        Return d / 2.54
    End Function

    Private Sub printToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles printToolStripMenuItem.Click
        If printDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            printDialog1.Document.Print()
        End If
    End Sub

    Private Sub printPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles printPreviewToolStripMenuItem.Click
        printPreviewDialog1.ShowDialog()
    End Sub
End Class
