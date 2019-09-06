<%@LANGUAGE="VBSCRIPT" CODEPAGE="1252"%>   
<% Option Explicit %>   

<html>
    <body>
        <form>
            <img src = "Barcode.asp?number=<%  Response.Write(Request.Querystring("number")) %>" />
            <br />
            <input type="text" id="number" name="number" value="<%  Response.Write(Request.Querystring("number")) %>" />
            <input type="submit" value="Render" />
        </form>
    <body>
</html>