Imports System.IO
Imports System.Drawing.Imaging

Class Window1

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Me.barcode.Number = "Thank you"
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim d As New PrintDialog
        If d.ShowDialog() = True Then
            Dim document As FlowDocument
            document = CreateDocumentForPrinting()
            d.PrintDocument(CType(document, IDocumentPaginatorSource).DocumentPaginator, "Barcode in WPF")
        End If

    End Sub

    Private Function CreateDocumentForPrinting() As FlowDocument
        Dim image As Image = GetImageFromBarcodeControl()
        Dim container As New BlockUIContainer(image)
        Dim doc As New FlowDocument(container)
        doc.PagePadding = New Thickness(100)
        CreateDocumentForPrinting = doc
    End Function

    Private Function GetImageFromBarcodeControl() As Image
        Dim bitmapImage As New BitmapImage()
        Dim stream As New MemoryStream()
        barcode.Render().Save(stream, ImageFormat.Png)

        bitmapImage.BeginInit()
        bitmapImage.StreamSource = stream
        bitmapImage.EndInit()

        Dim element As New Image()
        element.Source = bitmapImage

        GetImageFromBarcodeControl = element
    End Function
End Class
