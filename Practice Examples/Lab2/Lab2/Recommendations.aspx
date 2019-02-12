<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recommendations.aspx.cs" Inherits="Lab2.Recommendations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text="<h1>Recommendations</h1>"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server" Height="154px" Width="615px">
                <asp:ListItem Enabled="False">Visual Basic Book</asp:ListItem>
                <asp:ListItem Enabled="False">Visual C# Book</asp:ListItem>
                <asp:ListItem Enabled="False">C Book</asp:ListItem>
                <asp:ListItem Enabled="False">C++ Book</asp:ListItem>
                <asp:ListItem Enabled="False">Java Book</asp:ListItem>
            </asp:ListBox>
        </div>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Options.aspx">Click here to choose another language</asp:HyperLink>
    </form>
</body>
</html>
