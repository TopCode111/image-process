using System;
using System.Drawing;
using System.Windows.Forms;

using Limilabs.Barcode;

namespace WindowsForms_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseBarcode b = BarcodeFactory.GetBarcode(Symbology.I2of5);
            b.Number = "123456789";
            b.ChecksumAdd = true;
            b.Rotation = RotationType.Degrees90;
            pictureBox1.Image = b.Render();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Pixel;

            BaseBarcode b = BarcodeFactory.GetBarcode(Symbology.I2of5);
            b.Number = "123456789";
            b.ChecksumAdd = true;
            b.Rotation = RotationType.Degrees90;

            b.Height = CentimetersToPixels(2.5, e.Graphics.DpiY);           // 2.5 cm
            b.NarrowBarWidth = CentimetersToPixels(0.05, e.Graphics.DpiX);  // 0.05 cm = 0.5 mm
            
            b.Render(e.Graphics, 
                CentimetersToPixels(1.0, e.Graphics.DpiX), 
                CentimetersToPixels(1.0, e.Graphics.DpiY));
        }

        private static int InchesToPixels(double inches, double dpi)
        {
            return (int)(dpi * inches);
        }

        private static int CentimetersToPixels(double centimeters, double dpi)
        {
            return (int)(dpi * CentimetersToInches(centimeters));
        }

        private static double CentimetersToInches(double d)
        {
            return d / 2.54;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDialog1.Document.Print();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }
    };
}