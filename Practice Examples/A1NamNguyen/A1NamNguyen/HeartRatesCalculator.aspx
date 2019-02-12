<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HeartRatesCalculator.aspx.cs" Inherits="A1NamNguyen.HeartRatesCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Heart Rates Calculator</h1>
            <p>Choose your gender:</p>
            <p>
                <asp:RadioButton ID="radMale" runat="server" GroupName="radGender" Text="Male" Checked="True" />
            </p>
            <p>
                <asp:RadioButton ID="radFemale" runat="server" GroupName="radGender" Text="Female" />
            </p>
            <p>Please provide us with some more information about yourself:</p>
            <p>First name:
                <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFName" Display="Dynamic" ErrorMessage="This field cannot be empty" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </p>
            <p>Last name:
                <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLName" Display="Dynamic" ErrorMessage="This field cannot be empty" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </p>
            <p>Year of Birth:
                <asp:DropDownList ID="lstYoB" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate Your Heart Rate!" BackColor="#66FFCC" ForeColor="#6600CC" />
            </p>
            <p>
                <asp:Label ID="lblResult" runat="server" Text="Your Information" Visible="False"></asp:Label>
            </p></div>
    </form>
</body>
</html>
