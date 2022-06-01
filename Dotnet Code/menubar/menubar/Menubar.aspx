<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menubar.aspx.cs" Inherits="menubar.Menubar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFF99" BorderStyle="None" ForeColor="Black" Orientation="Horizontal" Width="100%">
            <DynamicMenuItemStyle HorizontalPadding="50px" ItemSpacing="110px" />
            <Items>
                <asp:MenuItem Text="Home" Value="Home" NavigateUrl="~/Home.aspx">
                    <asp:MenuItem Text="edit" Value="edit"></asp:MenuItem>
                    <asp:MenuItem Text="delete" Value="delete"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="About" Value="About" NavigateUrl="~/about.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Contact" Value="Contact" NavigateUrl="~/contact.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Exit" Value="Exit"  NavigateUrl="~/exit.aspx"></asp:MenuItem>
            </Items>
            <StaticMenuItemStyle HorizontalPadding="50px" ItemSpacing="110px" />
            <StaticMenuStyle HorizontalPadding="20px" VerticalPadding="20px" />
            <StaticSelectedStyle ItemSpacing="5px" />
        </asp:Menu>
        <br />
    
    </div>
    </form>
</body>
</html>
