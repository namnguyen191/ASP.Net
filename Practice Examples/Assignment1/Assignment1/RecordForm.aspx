<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecordForm.aspx.cs" Inherits="Assignment1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Record Database</h1>
    <p>
        Case Id:<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnLoad" runat="server" Text="Load Data" OnClick="btnLoad_Click" />
        </p>
        <p>
            Patient Id:<asp:TextBox ID="txtPId" runat="server"></asp:TextBox>
        </p>
        <p>
            Health Condition:<asp:TextBox ID="txtHealth" runat="server"></asp:TextBox>
        </p>
        <p>
            Assigned Doctor&#39;s Id:<asp:TextBox ID="txtDId" runat="server"></asp:TextBox>
        </p>
        <p>
            Status:<asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnView" runat="server" Text="View Data" OnClick="btnView_Click" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" Enabled="False" Visible="False">
            </asp:GridView>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
</asp:Content>
