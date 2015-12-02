<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiwooWebSite.Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="DropTheBeatLabel"></asp:Label>
        <br /><br />
        <asp:TextBox runat="server" ID="TextInput"/>
        <asp:Button runat="server" ID="GreetButton" Text="Say Hello!" OnClick="GreetButton_Click" />
        <asp:DropDownList runat="server" ID="GreetList" AutoPostBack="true" OnSelectedIndexChanged="GreetList_SelectedIndexChanged">
            <asp:ListItem Value="No One!">No One</asp:ListItem>
            <asp:ListItem Value="World!">World</asp:ListItem>
            <asp:ListItem Value="Universe!">Universe</asp:ListItem>
            <asp:ListItem Value="Dude!">Dude</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
