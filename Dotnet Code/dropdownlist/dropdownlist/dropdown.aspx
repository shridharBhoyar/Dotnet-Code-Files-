<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown.aspx.cs" Inherits="dropdownlist.dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="23px" style="margin-top: 0px" Width="161px"></asp:TextBox>
        <br /> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" Width="87px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="61px" style="margin-left: 0px" Width="110px">
            <asp:ListItem>shri</asp:ListItem>
            <asp:ListItem Selected="True">tushar</asp:ListItem>
            <asp:ListItem>mayur</asp:ListItem>
        </asp:DropDownList>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    </div>
        <div>

        </div>
    </form>
</body>
</html>
