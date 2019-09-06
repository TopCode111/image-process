Imports System.IO
Imports Limilabs.Barcode
Imports Gizmox.WebGUI.Common.Interfaces

Public Class BarcodeHandler
    Implements IGatewayHandler

    Private _number As String

    Public Sub New(ByVal number As String)
        _number = number
    End Sub

    Public Sub ProcessGatewayRequest(ByVal objContext As IContext, ByVal objComponent As IRegisteredComponent) Implements IGatewayHandler.ProcessGatewayRequest
        Dim b As BaseBarcode
        b = BarcodeFactory.GetBarcode(Symbology.EAN128)
        b.Number = _number
        WriteBarcodeImageToStream(b)
    End Sub

    Private Sub WriteBarcodeImageToStream(ByVal b As BaseBarcode)
        HttpContext.Current.Response.ContentType = "image/png"
        Dim ms As New MemoryStream
        b.Save(ms, ImageType.Png)
        WriteMemoryStream(ms)
    End Sub


    Private Sub WriteMemoryStream(ByVal ms As Stream)
        ms.Position = 0
        Dim buffer(1024) As Byte
        Dim read As Integer
        Do
            read = ms.Read(buffer, 0, 1024)
            If read = 0 Then
                Return
            End If
            HttpContext.Current.Response.OutputStream.Write(buffer, 0, read)
        Loop
    End Sub

End Class