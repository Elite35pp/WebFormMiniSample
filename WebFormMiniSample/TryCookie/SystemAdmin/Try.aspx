<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Try.aspx.cs" Inherits="TryCookie.SystemAdmin.Try" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="ltlMsg" runat="server" Text="Label"></asp:Label><br />
        <asp:Button ID="btnLogout" runat="server" Text="登出"   OnClick="btnLogout_Click" />
    </form>
</body>
</html>
