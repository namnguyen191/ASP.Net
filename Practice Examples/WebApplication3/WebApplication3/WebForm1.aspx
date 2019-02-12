<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button1">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" onmouseover="this.value='Click here!'" onmouseout="this.value='Submit'" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server">Submit</asp:LinkButton>
        </p>
        <p>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="75px" ImageUrl="~/Images/buton-sinyal-lambasi-pako-salter-142694883346969.jpeg" OnClick="ImageButton1_Click" OnClientClick="return confirm(&quot;I'm happy&quot;)" Width="86px" />
        </p>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="radLan" Text="Visual Basic" />
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="radLan" Text="C#" />
        </p>
        <p>
            <asp:RadioButton ID="radOtherLan" runat="server" GroupName="radLan" Text="Other Language" />
        </p>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Please Specify: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </asp:Panel>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
        <asp:Panel ID="Panel2" runat="server" Height="221px" ScrollBars="Auto" Width="556px">
            <asp:BulletedList ID="BulletedList1" runat="server" Height="214px" Width="399px">
            </asp:BulletedList>
        </asp:Panel>
        <p class="auto-style1">
            <asp:HyperLink ID="HyperLink1" runat="server" ImageHeight="50px" ImageUrl="~/Images/buton-sinyal-lambasi-pako-salter-142694883346969.jpeg" NavigateUrl="http://www.google.com" Target="_new">Take me to google</asp:HyperLink>
        </p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
    </form>
</body>
</html>
