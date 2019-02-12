<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DoctorForm.aspx.cs" Inherits="Assignment1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Doctor Database:</h1>
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
        Specialization:<asp:TextBox ID="txtSpecial" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAdd" runat="server"  Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server"  Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server"  Text="Delete" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Data" />
        &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" Enabled="False" Visible="False">
        </asp:GridView>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
</asp:Content>
