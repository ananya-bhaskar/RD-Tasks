<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Task2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRegister" runat="server" ForeColor="Green" Height="10%" Text="Register here!!" Width="100%"></asp:Label>
        </div>
        <p>
            Name :
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </p>
        <p>
            Gender : <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Selected="True">Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            Location :&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">Hyderabad</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Bangalore</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            User
            Name :&nbsp;
            <asp:TextBox ID="tbUserName" runat="server" Height="22px"></asp:TextBox>
        </p>
        <p>
            Password :
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="REGISTER" />
    </form>
</body>
</html>
