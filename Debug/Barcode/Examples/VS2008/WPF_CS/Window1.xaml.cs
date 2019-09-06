using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace WPF_CS
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.barcode.Number = "Thank you";
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog d  = new PrintDialog();
            if (d.ShowDialog() == true)
            {
                FlowDocument document = CreateDocumentForPrinting();
                d.PrintDocument(((IDocumentPaginatorSource)document).DocumentPaginator, "Barcode in WPF");
            }
        }

        private FlowDocument CreateDocumentForPrinting()
        {
            Image image = GetImageFromBarcodeControl();
            BlockUIContainer container = new BlockUIContainer(image);
            FlowDocument doc = new FlowDocument(container);
            doc.PagePadding = new Thickness(100);
            return doc;
        }

        private Image GetImageFromBarcodeControl()
        {
            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream stream = new MemoryStream();
            barcode.Render().Save(stream, ImageFormat.Png);

            bitmapImage.BeginInit();
            bitmapImage.StreamSource = stream;
            bitmapImage.EndInit();

            Image element = new Image();
            element.Source = bitmapImage;
            return element;
        }
    }
}
