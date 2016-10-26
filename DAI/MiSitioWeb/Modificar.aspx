<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modificar.aspx.cs" Inherits="Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Modificar<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        User<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        Correo:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Contraseña:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Regresar" />
    
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
