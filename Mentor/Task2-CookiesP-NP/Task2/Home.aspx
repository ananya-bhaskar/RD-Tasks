<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Task2.RegSucc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PROFILE :
            <asp:Label ID="lblUser" runat="server"></asp:Label>
        </div>
        <p>
            Name : <asp:Label ID="lblName" runat="server"></asp:Label>
        </p>
        <p>
            Gender : <asp:Label ID="lblGender" runat="server"></asp:Label>
        </p>
        <p>
            Location :
            <asp:Label ID="lblLocation" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="LOG OUT" />
        </p>
    </form>
</body>
</html>
