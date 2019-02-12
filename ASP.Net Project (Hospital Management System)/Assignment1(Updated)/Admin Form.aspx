<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="Admin Form.aspx.cs" Inherits="Assignment1_Updated_.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            height: 31px;
        }
        .auto-style11 {
            width: 1425px;
        }
        .auto-style17 {
            width: 356px;
        }
        .auto-style19 {
            height: 31px;
            width: 356px;
        }
        .auto-style20 {
            width: 208px;
        }
        .auto-style21 {
            width: 208px;
            height: 31px;
        }
        .auto-style22 {
            width: 296px;
        }
        .auto-style23 {
            width: 296px;
            height: 31px;
        }
        .auto-style25 {
            width: 118px;
            height: 31px;
        }
        .auto-style26 {
            width: 118px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Control Pannel:</h1>
    <table style="text-align:left;" class="auto-style11">
        <tr>
            <td colspan="2">Doctor</td>
            <td colspan="2">Patient</td>
        </tr>
        <tr>
            <td class="auto-style26">Id:</td>
            <td class="auto-style22">
                <asp:TextBox ID="txtId" runat="server" Width="206px"></asp:TextBox>
                <asp:Button ID="btnLoad" runat="server" Text="Load" Width="79px" OnClick="btnLoad_Click" />
            </td>
            <td class="auto-style20">Id:</td>
            <td class="auto-style17">
                <asp:TextBox ID="txtIdPatient" runat="server" Width="206px"></asp:TextBox>
                <asp:Button ID="btnLoadPatient" runat="server" Text="Load" Width="79px" OnClick="btnLoadPatient_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style26">First Name:</td>
            <td class="auto-style22">
                <asp:TextBox ID="txtFName" runat="server" Width="207px"></asp:TextBox>
            </td>
            <td class="auto-style20">First Name:</td>
            <td class="auto-style17">
                <asp:TextBox ID="txtFNamePatient" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">Last Name:</td>
            <td class="auto-style22">
                <asp:TextBox ID="txtLName" runat="server" Width="203px"></asp:TextBox>
            </td>
            <td class="auto-style20">Last Name:</td>
            <td class="auto-style17">
                <asp:TextBox ID="txtLNamePatient" runat="server" Width="203px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">Address</td>
            <td class="auto-style23">
                <asp:TextBox ID="txtAddress" runat="server" Width="202px"></asp:TextBox>
            </td>
            <td class="auto-style21">Address:</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtAddressPatient" runat="server" Width="202px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">Postal Code</td>
            <td class="auto-style23">
                <asp:TextBox ID="txtPostal" runat="server" Width="201px"></asp:TextBox>
            </td>
            <td class="auto-style21">Postal Code:</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtPostalPatient" runat="server" Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                &nbsp;
                &nbsp;
                <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                &nbsp;
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                &nbsp;
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
            <td class="auto-style21">Assigned Doctor&#39;s Id:</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtAssignedDoctor" runat="server" Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                &nbsp;</td>
            <td class="auto-style5" colspan="2">
                <asp:Button ID="btnInsertPatient" runat="server" Text="Insert" OnClick="btnInsertPatient_Click" />
                &nbsp;
                <asp:Button ID="btnUpdatePatient" runat="server" Text="Update" OnClick="btnUpdatePatient_Click" />
                &nbsp;
                <asp:Button ID="btnDeletePatient" runat="server" Text="Delete" OnClick="btnDeletePatient_Click" />
                <asp:Label ID="lblMessagePatient" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        
</asp:Content>
