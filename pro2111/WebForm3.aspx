<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="pro2111.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>salary</td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>commision</td>
                <td>
                    <asp:TextBox ID="txtCommission" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>bonce</td>
                <td>
                    <asp:TextBox ID="txtBonce" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>over time</td>
                <td>
                    <asp:TextBox ID="txtOvertime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="calc" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
