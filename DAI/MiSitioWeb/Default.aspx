<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 376px">
    <form id="form1" runat="server">
    <div style="height: 28px">
    
        <asp:Label ID="Label1" runat="server" Text="BIENVENIDO"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="ALTA USUARIO"></asp:Label>
        <div style="height: 33px">
            <asp:Label ID="Label3" runat="server" Text="CORREO"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div style="height: 33px">
            <asp:Label ID="Label4" runat="server" Text="CONTRASEÑA"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div style="height: 33px">
            <asp:Label ID="Label5" runat="server" Text="NOMBRE"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div style="height: 33px">
            <asp:Label ID="Label6" runat="server" Text="SEXO"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <div style="height: 33px">
            <asp:Label ID="Label7" runat="server" Text="EDAD"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Height="27px" Text="Alta" Width="414px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Regresar" Width="452px" OnClick="Button2_Click" />
        </div>
        

        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        

    </form>
    <p>
        &nbsp;</p>
</body>
</html>
