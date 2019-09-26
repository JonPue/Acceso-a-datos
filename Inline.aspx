<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inline.aspx.cs" Inherits="ActividadWebForms1.Inline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <% string[] animales = new string[3] {"perro", "gato", "pajaro" };   %>

       <% foreach (string value in animales) { 
           %>
        <div>
            Holaaa animal: <% Response.Write(value); %><br />
        </div>
        <% }%>

    </form>
      <%Response.Write("Fin de pagina"); %>

</body>
</html>
