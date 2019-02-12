<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="Assignment1_Updated_.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Username:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="txtName" ErrorMessage="User name cannot be left empty!" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        Password:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="txtPass" ErrorMessage="Password cannot be left empty!" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
</asp:Content>
