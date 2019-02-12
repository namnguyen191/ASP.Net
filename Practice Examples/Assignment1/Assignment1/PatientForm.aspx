<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PatientForm.aspx.cs" Inherits="Assignment1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Patient Database</h1>
    <p>
        Id:<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnLoad" runat="server" OnClick="btnLoad_Click" Text="Load Data" />
        </p>
        <p>
            Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p>
            Address:<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            Postal Code:<asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
        </p>
        <p>
            Age:<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        </p>
        <p>
            Gender:<asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Data" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" Visible="False">
            </asp:GridView>
        </p>
</asp:Content>
