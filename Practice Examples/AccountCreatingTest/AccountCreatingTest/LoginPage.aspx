<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="AccountCreatingTest.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Password:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server"  Text="Login" />
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLinkCreateAccount" runat="server" NavigateUrl="~/CreateAccountPage.aspx">Create An Account</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
