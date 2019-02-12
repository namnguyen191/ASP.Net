<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product Page.aspx.cs" Inherits="Lab3.Product_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
        }
        .auto-style2 {
            width: 442px;
        }
        .auto-style3 {
            margin-left: 120px;
        }
        .auto-style4 {
            width: 442px;
            height: 31px;
        }
        .auto-style5 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Product Id:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" Width="245px" TextMode="Number"></asp:TextBox>
                        <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="Load" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Product Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="244px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Product Price:</td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Product Quantity</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" Text="Status: "></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
