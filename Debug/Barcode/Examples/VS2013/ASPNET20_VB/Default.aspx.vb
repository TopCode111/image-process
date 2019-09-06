Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BarcodeControl1.Number = "PAGE LOAD 123"
    End Sub


End Class