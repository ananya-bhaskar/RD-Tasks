<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Task2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="User Name : "></asp:Label>
            <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPwd" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="tbPwd" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="height: 26px" Text="LOGIN" />
&nbsp;&nbsp;
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="REGISTER" />
            <br />
            <br />
            <asp:Label ID="lblUserMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
