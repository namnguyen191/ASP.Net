<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="CookieCalculator.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:Image ID="Image1" runat="server" Height="290px" ImageUrl="~/Images/a48e575c-d047-4ba5-89b0-1c8977511564.png" Width="474px" />
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CalculatorSettup.aspx">Let&#39;s do it again!</asp:HyperLink>
        </p>
    </form>
</body>
</html>
