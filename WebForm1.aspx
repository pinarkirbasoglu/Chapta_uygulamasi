<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Chapta.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="res1" runat="server" Height="50px" Width="50px" />
        <asp:Image ID="res2" runat="server" Height="50px" style="margin-right: 4px; margin-top: 0px" Width="50px" />
        <asp:Image ID="res3" runat="server" Height="50px" Width="50px" />
        <asp:Image ID="res4" runat="server" Height="50px" Width="50px" />
        <asp:Image ID="res5" runat="server" Height="50px" Width="50px" />
        <asp:Image ID="res6" runat="server" Height="50px" Width="50px" />
        <div>
            <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Doğrula" />
        </p>
    </form>
</body>
</html>
