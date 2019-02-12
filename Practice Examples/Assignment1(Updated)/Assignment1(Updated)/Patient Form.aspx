<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="Patient Form.aspx.cs" Inherits="Assignment1_Updated_.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2">
    <h1><asp:Label ID="patientlbl" runat="server"></asp:Label></h1>
   
    
            </td>
        </tr>
        <tr>
            <td>First Name:</td>
            <td><asp:TextBox ID="firstnametxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td><asp:TextBox ID="lastnametxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address:</td>
            <td><asp:TextBox ID="addresstxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Postal Code:</td>
            <td><asp:TextBox ID="postalcodetxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
    <asp:Button ID="updatebtn" runat="server" OnClick="updatebtn_Click" Text="Update Your Info" />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <br />
    <asp:Button ID="viewallbtn" runat="server" OnClick="viewallbtn_Click" Text="View All Visit History" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="searchbtn" runat="server" Text="Search a visit history" Height="36px" OnClick="searchbtn_Click" />
    Doctor&#39;s Id:
    <asp:TextBox ID="txtDocId" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblHistoryMessage" runat="server"></asp:Label>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    </asp:Content>
