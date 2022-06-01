<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="singupPage.aspx.cs" Inherits="SingUpForm.singupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            width: 130px;
            height: 28px;
        }
        .auto-style5 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="2" class="auto-style1">
            <tr>
                <td class="auto-style3">First name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="149px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Last name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="149px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Age</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="148px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Gender</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="168px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="153px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" style="margin-left: 152px" Text="Submit" Width="133px" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
