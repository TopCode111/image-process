using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Limilabs.Barcode;
using System.IO;

namespace CrystalReports_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create a DataSet from the XML file
            string filePath = "..\\..\\Employees.xml";
            DataSet ds = new DataSet();
            ds.ReadXml(filePath);

            //Create and add barcode column
            DataColumn dc = new DataColumn("BarcodeImage", typeof(byte[]));
            ds.Tables[0].Columns.Add(dc);

            //We'll use Code 128 Barcode Symbology
            BaseBarcode b = BarcodeFactory.GetBarcode(Symbology.Code128);

            b.NarrowBarWidth = 3;
            b.Height = 300;
            b.FontHeight = 0.3F;
            //Now, generate and fill barcode images
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //We'll encode the ID column
                b.Number = (string)dr["ID"];

                //Create bitmap and save it to BarcodeImage column
                MemoryStream ms = new MemoryStream();
                b.Save(ms, ImageType.Png, 300, 300);
                dr["BarcodeImage"] = ms.GetBuffer();
            }

            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = report; 
        }
    };
}
