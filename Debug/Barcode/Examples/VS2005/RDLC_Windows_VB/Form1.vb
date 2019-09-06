Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.ExecuteReportInCurrentAppDomain(Reflection.Assembly.GetExecutingAssembly().Evidence)
        Me.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("Barcode, Version=2.0.0.20, Culture=neutral, PublicKeyToken=6dc438ab78a525b3")
        Me.ReportViewer1.LocalReport.AddTrustedCodeModuleInCurrentAppDomain("System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")

        Me.CustomerBindingSource.DataSource = New Customer()
        Me.LineItemBindingSource.DataSource = New List(Of LineItem)()
    End Sub

    Private Sub viewReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewReportButton.Click
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
