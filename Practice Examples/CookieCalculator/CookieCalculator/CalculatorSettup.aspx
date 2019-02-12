<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorSettup.aspx.cs" Inherits="CookieCalculator.CalculatorSettup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 86px;
        }
        .auto-style2 {
            margin-left: 60px;
        }
        .auto-style3 {
            margin-left: 85px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Image ID="Image1" runat="server" Height="394px" ImageUrl="~/Images/a48e575c-d047-4ba5-89b0-1c8977511564.png" Width="440px" />
            <asp:Label ID="Label1" runat="server" Height="150px" Text="My Calculator"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblCalculatorName" runat="server" Text="Name your calculator: "></asp:Label>
            <asp:TextBox ID="txtCalculatorName" runat="server" Width="484px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblFirstNumber" runat="server" Text="First Number: "></asp:Label>
            <asp:TextBox ID="txtFirstNumber" runat="server" CssClass="auto-style1" Width="482px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSecondNumber" runat="server" Text="Second Number: "></asp:Label>
            <asp:TextBox ID="txtSecondNumber" runat="server" CssClass="auto-style2" Width="478px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblMathMethod" runat="server" Text="Math Method: "></asp:Label>
            <asp:DropDownList ID="lstMathMethods" runat="server" CssClass="auto-style3" Width="131px">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
