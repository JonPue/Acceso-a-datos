<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CodeBehind.aspx.cs" Inherits="ActividadWebForms1.CodeBehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <!--El runat conecta con el servidor -->
    <form id="form1" runat="server">
        <div>
            Introducir Nombre:
            <!--Aqui metemos una caja de texto, un boton y un label para que muestre los resultados -->
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Introducir Apellido:
             <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            Introducir Edad:
             <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />

            <!--El boton le ponemos onclick y si le damos boton derecho ver codigo en el CodeBehind.aspx.cs nos saca el codigo del boton para poder darle algo para que lo haga -->
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"/>
            <br />
            Tu datos son:
            <asp:Label ID="lblResultado" runat="server" Text="Resultados"></asp:Label>
            <asp:Label ID="lblResultado2" runat="server" Text="Resultados"></asp:Label>
            <asp:Label ID="lblResultado3" runat="server" Text="Resultados"></asp:Label>

        </div>
        <br />
        <br />
        <br />
        <div>
                Introduce tu Usuario:
               <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                <br />
                Introduce tu Password:
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnResult" runat="server" Text="Sign in" OnClick="btnResult_Click"/>
                <br />

        </div>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             <asp:ListItem>HyperLink</asp:ListItem>
             <asp:ListItem>PasswordRecovery</asp:ListItem>
             <asp:ListItem>PlaceHolder</asp:ListItem>
             <asp:ListItem>LoginName</asp:ListItem>
             <asp:ListItem>Label</asp:ListItem>
        </asp:DropDownList>
        <div>
           Lo que has seleccionado es: <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <h1>Button Example: Show Hide</h1>
        <asp:Button ID="btnVisible" runat="server" Text="Text Button Visible" />
    
        <asp:Button ID="btnhidde" runat="server" Text="Hidde Bottom" OnClick="btnhidde_Click" />
        <asp:Button ID="btnShow" runat="server" Text="Show Button" OnClick="btnShow_Click" />
    </form>


</body>
</html>
