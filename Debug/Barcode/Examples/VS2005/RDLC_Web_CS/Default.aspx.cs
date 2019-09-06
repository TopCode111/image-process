using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Microsoft.Reporting.WebForms;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Required code
        this.ReportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
        this.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("Barcode, Version=2.0.0.20, Culture=neutral, PublicKeyToken=6dc438ab78a525b3");
        this.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");

        // Data load
        DataSet1 dataSet = new DataSet1();
        dataSet.ReadXml(Server.MapPath("~/App_Data/Products.xml"));
        
        ReportDataSource dataSource = new ReportDataSource("DataSet1_Products", dataSet.Products);
        this.ReportViewer1.LocalReport.DataSources.Add(dataSource);
        this.ReportViewer1.LocalReport.Refresh();
    }
};
