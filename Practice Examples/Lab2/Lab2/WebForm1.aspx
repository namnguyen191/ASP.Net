<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Welcome to cookies! You selected "></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Options.aspx">Click here to choose another language</asp:HyperLink>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Recommendations.aspx">Click here to get book recommendations</asp:HyperLink>
        </p>
    </form>
</body>
</html>
