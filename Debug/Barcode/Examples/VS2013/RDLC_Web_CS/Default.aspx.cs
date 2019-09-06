using System;
using System.Data;
using System.Security;
using System.Security.Permissions;
using Microsoft.Reporting.WebForms;

namespace RDLC_Web_CS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                // Required code
                PermissionSet permissions = new PermissionSet(PermissionState.Unrestricted);
                this.ReportViewer1.LocalReport.SetBasePermissionsForSandboxAppDomain(permissions);

                // Data load
                DataSet1 dataSet = new DataSet1();
                dataSet.ReadXml(Server.MapPath("~/App_Data/Products.xml"));

                ReportDataSource dataSource = new ReportDataSource("DataSet1_Products", (DataTable) dataSet.Products);
                this.ReportViewer1.LocalReport.DataSources.Add(dataSource);
                this.ReportViewer1.LocalReport.Refresh();
            }
        }
    };
}
