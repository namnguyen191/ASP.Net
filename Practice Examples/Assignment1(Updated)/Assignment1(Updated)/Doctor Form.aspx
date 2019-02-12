<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="Doctor Form.aspx.cs" Inherits="Assignment1_Updated_.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 229px;
        }
        .auto-style5 {
            width: 49%;
        }
        .auto-style7 {
            width: 229px;
            height: 31px;
        }
        .auto-style10 {
            width: 828px;
        }
        .auto-style11 {
            width: 828px;
            height: 31px;
        }
        .auto-style12 {
            width: 409px;
        }
        .auto-style13 {
            width: 409px;
            height: 31px;
        }
        .auto-style14 {
            width: 386px;
        }
        .auto-style15 {
            width: 386px;
            height: 31px;
        }
        .auto-style16 {
            width: 316px;
        }
        .auto-style17 {
            width: 476px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><asp:Label ID="lblWelcome" runat="server"></asp:Label></h1>
    <table class="auto-style5">
        <tr>
            <td colspan="2">Your Info</td>
            <td colspan="2">Edit Visit History</td>
        </tr>
        <tr>
            <td class="auto-style14">First Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
&nbsp;</td>
            <td class="auto-style12">Id:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtVisitId" runat="server"></asp:TextBox>
                <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="Load" />
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Last Name:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style13">Date</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtVisitDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Address:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">Start Time</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtVisitStartTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Postal Code:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtPostal" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">End Time</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtVisitEndTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Info" />
            </td>
            <td class="auto-style12">Patient&#39;s Id:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtPatientId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
&nbsp;<asp:Button ID="btnModifiy" runat="server" OnClick="btnModifiy_Click" Text="Modify" />
&nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            </td>
        </tr>
    </table>
    Discharge Patient with Id:<asp:TextBox ID="txtDischargePatientId" runat="server"></asp:TextBox>
    <asp:Button ID="btnDischarge" runat="server" OnClick="btnDischarge_Click" Text="Confirm" />
    <br />
    <asp:Button ID="btnViewAll" runat="server" OnClick="btnViewAll_Click" Text="View all your visit history" />
&nbsp;Or
    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search By" />
    Date:
    <asp:TextBox ID="txtSearchDate" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" ImageUrl="~/Pictures/calendar.png" OnClick="ImageButton1_Click" Width="21px" />
    Patient&#39;s Id:<asp:TextBox ID="txtSearchPatientId" runat="server"></asp:TextBox>
    <table class="auto-style1">
        <tr>
            <td class="auto-style16">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
            <td class="auto-style17">
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
            </td>
        </tr>
    </table>
</asp:Content>
