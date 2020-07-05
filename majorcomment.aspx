<%@ Page Language="C#" MasterPageFile="~/major.master" AutoEventWireup="true" CodeFile="majorcomment.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 525px">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="name"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtcomntatr" runat="server"></asp:TextBox></td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Choose Type"></asp:Label></td>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="complaint" GroupName="1113" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="suggetion" Width="95px" GroupName="1113" ValidationGroup="1113" /></td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="description"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtcomment" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox></td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                &nbsp; &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" /></td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

