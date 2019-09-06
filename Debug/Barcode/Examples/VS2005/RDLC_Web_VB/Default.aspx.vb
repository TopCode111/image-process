
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Required code
        Me.ReportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(Reflection.Assembly.GetExecutingAssembly().Evidence)
        Me.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("Barcode, Version=2.0.0.20, Culture=neutral, PublicKeyToken=6dc438ab78a525b3")
        Me.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")

        ' Data load
        Dim dataSet As New DataSet1()
        dataSet.ReadXml(Server.MapPath("~/App_Data/Products.xml"))

        Dim dataSource As New Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_Products", dataSet.Products)
        Me.ReportViewer1.LocalReport.DataSources.Add(dataSource)
        Me.ReportViewer1.LocalReport.Refresh()
    End Sub

End Class
