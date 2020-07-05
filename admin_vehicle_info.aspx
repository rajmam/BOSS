<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_vehicle_info.aspx.cs" Inherits="admin_vehicle_info" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table style="width: 416px">
        <tr>
            <td style="width: 173px">
                <asp:Label ID="Label1" runat="server" Text="Owner."></asp:Label></td>
            <td style="width: 61px">
                <asp:Label ID="lbown" runat="server"></asp:Label>
                </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 173px">
                <asp:Label ID="Label3" runat="server" Text="Bus Register No."></asp:Label></td>
            <td style="width: 61px">
                <asp:TextBox ID="Txtbrno" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="lbexists" runat="server" Font-Bold="True" ForeColor="#C00000" Width="126px"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 21px; width: 173px;">
                &nbsp;<asp:Label ID="Label4" runat="server" Text="Model No."></asp:Label></td>
            <td style="width: 61px; height: 21px">
                <asp:TextBox ID="Txtmno" runat="server"></asp:TextBox></td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="height: 21px; width: 173px;">
                &nbsp;<asp:Label ID="Label2" runat="server" Text="Bus Name."></asp:Label></td>
            <td style="width: 61px; height: 21px">
                <asp:TextBox ID="Txtbname" runat="server"></asp:TextBox></td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="height: 21px; width: 173px;">
            </td>
            <td style="width: 61px; height: 21px">
                &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" /></td>
            <td style="height: 21px">
            </td>
        </tr>
    </table>
</asp:Content>

