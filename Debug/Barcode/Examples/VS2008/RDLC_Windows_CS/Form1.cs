using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace RDLC_Windows_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ReportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(Assembly.GetExecutingAssembly().Evidence);
            this.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("Barcode, Version=2.0.0.20, Culture=neutral, PublicKeyToken=6dc438ab78a525b3");
            this.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            this.CustomerBindingSource.DataSource = new Customer();
            this.LineItemBindingSource.DataSource = new List<LineItem>();
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            this.ReportViewer1.RefreshReport();
        }
    };
}
