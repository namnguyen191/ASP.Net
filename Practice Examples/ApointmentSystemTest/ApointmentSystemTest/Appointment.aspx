<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="ApointmentSystemTest.Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAppointment" runat="server" Text="Make an appointment" />
            <br />
            Date:<asp:TextBox ID="txtDate" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            From:<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; To:<asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
        </div>
    </form>
</body>
</html>
