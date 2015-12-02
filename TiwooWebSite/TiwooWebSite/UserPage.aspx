<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="TiwooWebSite.UserPage" %>
<%@ Register TagPrefix="My" TagName="UserInfoBoxControl" Src="~/UserInfoBoxControl.ascx" %>
<%@ Reference Control="~/UserInfoBoxControl.ascx" %>
<%@ Register TagPrefix="My" TagName="EventUserControl" Src="~/EventUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <My:EventUserControl runat="server" ID="MyEventUserControl" OnPageTitleUpdated="MyEventUserControl_PageTitleUpdated"/>
        <br /><br />
        <My:UserInfoBoxControl runat="server" ID="MyUserInfoBoxControl" UserName="Harry Potter" UserAge="17" UserCountry="United Kingdom" />
    </div>
        <asp:PlaceHolder runat="server" ID="phUserInfoBox" />
    </form>
</body>
</html>
