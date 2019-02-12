<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccountPage.aspx.cs" Inherits="AccountCreatingTest.CreateAccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            Confirm Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create Your Account" />
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLinkReturn" runat="server" NavigateUrl="~/LoginPage.aspx">Return To Login Page</asp:HyperLink>
        </div>
    </form>
</body>
</html>
