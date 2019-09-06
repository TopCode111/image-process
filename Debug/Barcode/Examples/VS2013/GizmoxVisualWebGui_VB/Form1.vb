Imports Gizmox.WebGUI.Common.Gateways
Imports Gizmox.WebGUI.Common.Interfaces

Public Class Form1
    Implements IGatewayControl

    Public Function GetGatewayHandler(ByVal objContext As IContext, ByVal strAction As String) As IGatewayHandler Implements IGatewayControl.GetGatewayHandler
        Select Case strAction
            Case "Barcode"
                Return New BarcodeHandler(Me._txtNumber.Text)
        End Select
        Return Nothing
    End Function

    Private Sub _btnRender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnRender.Click
        Dim reference As New GatewayReference(Me, "Barcode")
        Me.HtmlBox1.Url = reference.ToString()
        Me.HtmlBox1.Update()
    End Sub

End Class