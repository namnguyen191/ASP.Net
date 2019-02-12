<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInfo" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" PostBackUrl="~/WebForm2.aspx" Text="Button" />
        </div>
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
