<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>


<body style="height: 346px">
    <p>
        Mi Primer Sitio WEB
    </p>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 47px" Width="152px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 24px" Width="150px"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
