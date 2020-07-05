<%@ Page Language="C#" AutoEventWireup="true" CodeFile="change_pw.aspx.cs" Inherits="change_pw" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width: 513px">
            <tr>
                <td>
                    </td>
                <td>
                    </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtpw" runat="server" TextMode="Password"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="New Password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtnewpw" runat="server" ValidationGroup="12" TextMode="Password"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Re Type Password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtvnewpw" runat="server" OnTextChanged="TextBox3_TextChanged" ValidationGroup="12" TextMode="Password"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Please re-type" Visible="False"></asp:Label></td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" Width="54px" />
                    &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" /></td>
                <td>
                </td>
            </tr>
        </table>
        &nbsp;
    </form>
</body>
</html>
