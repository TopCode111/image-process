Imports Microsoft.Reporting.WebForms
Imports System.Security
Imports System.Security.Permissions

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = False Then
            ' Required code
            Dim permissions As New PermissionSet(PermissionState.Unrestricted)
            Me.ReportViewer1.LocalReport.SetBasePermissionsForSandboxAppDomain(permissions)

            ' Data load
            Dim dataSet As New DataSet1()
            dataSet.ReadXml(Server.MapPath("~/App_Data/Products.xml"))

            Dim dataSource As ReportDataSource = New ReportDataSource("DataSet1_Products", CType(dataSet.Products, DataTable))
            Me.ReportViewer1.LocalReport.DataSources.Add(dataSource)
            Me.ReportViewer1.LocalReport.Refresh()
        End If

    End Sub

End Class
