using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
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
            PermissionSet permissions = new PermissionSet(PermissionState.Unrestricted);
            this.ReportViewer1.LocalReport.SetBasePermissionsForSandboxAppDomain(permissions);
            this.CustomerBindingSource.DataSource = new Customer();
            this.LineItemBindingSource.DataSource = new List<LineItem>();
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            this.ReportViewer1.RefreshReport();
        }
    };
}
