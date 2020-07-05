<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_user.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 392px">
        <tr>
            <td>
            </td>
            <td style="width: 293px">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="height: 24px">
                <asp:Label ID="Label1" runat="server" Text="User Type"></asp:Label></td>
            <td style="width: 293px; height: 24px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="152px">
                    <asp:ListItem Value="2">punch operator(bs)</asp:ListItem>
                    <asp:ListItem Selected="True" Value="3">punch operator(ps)</asp:ListItem>
                    <asp:ListItem Value="4">rto</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 24px">
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label></td>
            <td style="width: 293px">
                <asp:TextBox ID="Txtusrname" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
            <td>
                <asp:Label ID="lbusrex" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label></td>
            <td style="width: 293px">
                <asp:TextBox ID="Txtpw" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"
                    ValidationGroup="11" Width="149px"></asp:TextBox></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Verify Password" Width="110px"></asp:Label></td>
            <td style="width: 293px">
                <asp:TextBox ID="Txtvpw" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"
                    ValidationGroup="11" Width="147px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Txtpw"
                    ControlToValidate="Txtvpw" ErrorMessage="Password Mismatch"></asp:CompareValidator></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
            </td>
            <td style="width: 293px; height: 26px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save & Proceed"
                    Width="104px" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save & Close"
                    Width="105px" /></td>
            <td style="height: 26px">
            </td>
        </tr>
    </table>
</asp:Content>

