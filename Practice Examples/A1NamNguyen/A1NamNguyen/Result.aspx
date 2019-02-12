<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="A1NamNguyen.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1>Your Information</h1>
            <br />
        <asp:Label ID="lblFName" runat="server" Text="First Name: "></asp:Label>
            <br />
        <asp:Label ID="lblLName" runat="server" Text="Last Name: "></asp:Label>
            <br />
        <asp:Label ID="lblYoB" runat="server" Text="Year Of Birth: "></asp:Label>
            <br />
        <asp:Label ID="lblAge" runat="server" Text="Age: "></asp:Label>
            <br />
        <asp:Label ID="lblMaxHr" runat="server" Text="Your Maximum Heart Rates: "></asp:Label>
            <br />
        <asp:Label ID="lblHrRange" runat="server" Text="Your Target Heart Rates Range: "></asp:Label>
    </form>
</body>
</html>
