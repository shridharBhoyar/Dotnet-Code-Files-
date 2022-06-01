<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="loginform1.loginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        UserName<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 149px"></asp:TextBox>
        <br />
&nbsp;Password<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 151px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 221px" Text="Log in" />
    
    </div>
    </form>
</body>
</html>
