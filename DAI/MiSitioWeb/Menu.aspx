<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 128px;
        }
    </style>
</head>
<body style="height: 455px">
    <form id="lb_noticias" runat="server">
        <div style="height: 36px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <div style="height: 16px">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <asp:Button ID="bt_alta" runat="server" OnClick="Button1_Click" Text="Alta" />
        <asp:Button ID="bt_baja" runat="server" OnClick="bt_baja_Click" Text="Baja" />
        <asp:Button ID="Button3" runat="server" Text="Modificar" OnClick="Button3_Click" />
        <div style="height: 320px">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
