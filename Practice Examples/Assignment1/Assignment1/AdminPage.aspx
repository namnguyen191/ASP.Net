<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Assignment1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server" >
        <h1>Admin Please Log in to continue</h1>
    <p>
        User:<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </p>
        <p>
            <asp:Label ID="lblError" runat="server" Enabled="False" ForeColor="Red" Text="Invalid User Name or Password!" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server" Text="Login Succesfully! Please select the option you want to work on" Enabled="False" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnDoctor" runat="server" Text="Doctor" Enabled="False" PostBackUrl="~/DoctorForm.aspx" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPatient" runat="server" Text="Patient" Enabled="False" PostBackUrl="~/PatientForm.aspx" Visible="False" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRecord" runat="server" Text="Record" Enabled="False" Visible="False" PostBackUrl="~/RecordForm.aspx" />
    </p>
</asp:Content>
