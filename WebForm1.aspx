<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDownListt.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">Manazanas</asp:ListItem>
            <asp:ListItem Value="2">Platanos</asp:ListItem>
            <asp:ListItem Value="3">Kiwi</asp:ListItem>
            <asp:ListItem Value="4">Mango</asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="btnSubmit" runat="server" Text="submit" />


        <asp:DropDownList ID="DropDownList2" runat="server">

        </asp:DropDownList>


        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>


    </form>
</body>
</html>
