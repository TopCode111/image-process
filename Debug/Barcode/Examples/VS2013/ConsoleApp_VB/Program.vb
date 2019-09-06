Imports System.IO
Imports Limilabs.Barcode

Module Module1
    Private Const _fileName As String = "barcode.png"

    Sub Main()
        ' Later we will set the resolution to 300 dpi (dots per inch)
        ' 36 PostScript points = 0.5 inches (1.27 cm)
        Dim barcode As BaseBarcode = BarcodeFactory.GetBarcode(Symbology.Code39Ext)

        barcode.Number = "1234567890"
        barcode.NarrowBarWidth = 12 ' 12 dots / 300 dpi = 0.04 inch (0.1 cm)
        barcode.ChecksumAdd = True
        barcode.ChecksumVisible = True

        barcode.Height = 600
        ' Barcode image after printing will be 2 inches high (600 dots / 300 dpi) including the text

        barcode.FontHeight = 0.25F
        ' font size will be 0.5 inch (1.27 cm) height (2 inch * 0.25) which is 36 PostScript points

        ' here we set the resolution
        barcode.Save(_fileName, ImageType.Png, 300, 300)

        Console.WriteLine("Barcode saved to: '{0}'", Path.GetFullPath(_fileName))
        Console.ReadKey(True)

    End Sub

End Module

