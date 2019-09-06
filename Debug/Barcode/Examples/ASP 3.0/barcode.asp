<%@LANGUAGE="VBSCRIPT" CODEPAGE="1252"%>   
<% Option Explicit %>   
<%   
    Dim bf   
    Dim b   
       
    set bf = Server.CreateObject("Limilabs.Barcode.BarcodeFactory")
 
    set b = bf.CreateBarcode(4)           ' Code39 Check documentation for other sybologies (Symbology enum)
    b.FontStyle = 1                       ' Bold (FontStyleType enum)
    b.ChecksumVisible = 1
    b.ChecksumAdd = 1
    'b.CustomText = "custom text"
    b.Number = Request.Querystring("number")
    b.Rotation = 0			 ' 0 degrees (RotationType enum)
    Response.BinaryWrite(b.Render(3))    ' gif (ImageType enum)
%>