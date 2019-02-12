<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        User Name:
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Text="Not logged in"></asp:Label>
        </p>
    </form>
</body>
</html>
