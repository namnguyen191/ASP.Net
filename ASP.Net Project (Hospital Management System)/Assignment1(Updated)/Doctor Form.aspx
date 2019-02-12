<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="Doctor Form.aspx.cs" Inherits="Assignment1_Updated_.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 31px;
        }
        .auto-style4 {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>Message:</td>
            <td>
                <asp:Label ID="doctormessagelbl" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>First Name:</td>
            <td>
                <asp:TextBox ID="firstnametxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Last Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="lastnametxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Address:</td>
            <td class="auto-style3">
                <asp:TextBox ID="addresstxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Postal Code:</td>
            <td>
                <asp:TextBox ID="postalcodetxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Patient&#39;s Id:</td>
            <td>
                <asp:TextBox ID="patientidtxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">StartTime:</td>
            <td class="auto-style4">
                <asp:TextBox ID="starttimetxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>End Time:</td>
            <td>
                <asp:TextBox ID="endtimetxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Status:</td>
            <td>
                <asp:TextBox ID="patientstatustxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="updatebtn" runat="server" OnClick="updatebtn_Click" Text="UpdateDoctorInfo" />
                <asp:Button ID="addbtn" runat="server" OnClick="addbtn_Click" Text="Add" />
                <asp:Button ID="deletebtn" runat="server" OnClick="deletebtn_Click" Text="Delete" />
                <asp:Button ID="modifybtn" runat="server" OnClick="modifybtn_Click" Text="Modify" />
                <asp:Button ID="updatepatientstatusbtn" runat="server" OnClick="updatepatientstatusbtn_Click" Text="UpdatePatientStatus" />
                <asp:Button ID="searchhistorytxt" runat="server" OnClick="searchhistorytxt_Click" Text="Search History" />
                <asp:GridView ID="GridView" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
