<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeWebForm.aspx.cs" Inherits="Practice.PracticeWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="rad1" runat="server" AutoPostBack="True" GroupName="rad" OnCheckedChanged="rad_CheckedChanged" Text="Cat" />
            <br />
            <asp:RadioButton ID="rad2" runat="server" AutoPostBack="True" GroupName="rad" OnCheckedChanged="rad_CheckedChanged" Text="Dog" />
            <br />
            <asp:RadioButton ID="rad3" runat="server" AutoPostBack="True" GroupName="rad" OnCheckedChanged="rad_CheckedChanged" Text="Cow" />
        </div>
        <p>
            <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
