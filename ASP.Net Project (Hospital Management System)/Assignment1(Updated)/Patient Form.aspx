<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="Patient Form.aspx.cs" Inherits="Assignment1_Updated_.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="viewallgv" runat="server">
    </asp:GridView>
    <table class="auto-style1">
        <tr>
            <td>Message:</td>
            <td>
    <asp:Label ID="patientlbl" runat="server"></asp:Label>
   
    
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
        <tr>
            <td>Doctor&#39;s Id:</td>
            <td><asp:TextBox ID="doctoridtxt" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="viewallbtn" runat="server" OnClick="viewallbtn_Click" Text="View All" />
    <asp:Button ID="updatebtn" runat="server" OnClick="updatebtn_Click" Text="Update" />
    <asp:Button ID="searchbtn" runat="server" Text="Search" Height="36px" OnClick="searchbtn_Click" />
    <br />
    </asp:Content>
