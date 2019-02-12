<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="Lab2.Options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text="<h3>Select a programming language:</h3>"></asp:Label>
        </div>
        <asp:RadioButton ID="radVSBasic" runat="server" Text="Visual Basic 2008" Checked="True" GroupName="radLang" OnCheckedChanged="rad_CheckedChanged" />
        <br />
        <asp:RadioButton ID="radVC" runat="server" Text="Visual C# 2008" GroupName="radLang" OnCheckedChanged="rad_CheckedChanged" />
        <br />
        <asp:RadioButton ID="radC" runat="server" Text="C" GroupName="radLang" OnCheckedChanged="rad_CheckedChanged" />
        <br />
        <asp:RadioButton ID="radCplus" runat="server" Text="C++" GroupName="radLang" OnCheckedChanged="rad_CheckedChanged" />
        <br />
        <asp:RadioButton ID="radJava" runat="server" Text="Java" GroupName="radLang" OnCheckedChanged="rad_CheckedChanged" />
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
    </form>
</body>
</html>
