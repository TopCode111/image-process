<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNET20_CS._Default" %>
<%@ Register Assembly="Barcode" Namespace="Limilabs.Web" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Barcode.dll test page</title>
    <script type="text/javascript">
    <!--
    function printPage()
    {
	    window.print();
    }
    //-->
    </script>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <cc1:BarcodeControl ID="BarcodeControl1" runat="server" Symbology="Code39"></cc1:BarcodeControl>
        <br />
        <input type="button" value="Print" onclick="printPage();"/>

        <br />
        <br />
        <br />
        Please remember to add following code to the <strong>web.config</strong> file in your application in <strong>&lt;system.webServer&gt;</strong> section:
    <pre>
    &lt;httpHandlers&gt;
        &lt;add name="BarcodeHttpHandler" verb="*"
            path="Barcode.axd"
            type="Limilabs.Web.BarcodeHttpHandler, Barcode"
            resourceType="Unspecified" /&gt;
    &lt;/httpHandlers&gt;
    </pre>  
    
    </div>
    </form>
</body>

</html>
