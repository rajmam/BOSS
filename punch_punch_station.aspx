<%@ Page Language="C#" MasterPageFile="~/punch.master" AutoEventWireup="true" CodeFile="punch_punch_station.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 536px">
        <tr>
            <td style="width: 184px; height: 21px">
            </td>
            <td style="width: 199px; height: 21px">
            </td>
            <td style="width: 254px; height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 184px; height: 23px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Choose Day&Date" Width="134px"></asp:Label></td>
            <td style="width: 199px; height: 23px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="98px">
                </asp:DropDownList></td>
            <td style="width: 254px; height: 23px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="98px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 184px">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Bus No" Width="60px"></asp:Label></td>
            <td style="width: 199px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="width: 254px">
            </td>
        </tr>
        <tr>
            <td style="width: 184px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Trip No" Width="60px"></asp:Label></td>
            <td style="width: 199px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td style="width: 254px">
            </td>
        </tr>
        <tr>
            <td style="width: 184px; height: 21px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="From" Width="60px"></asp:Label></td>
            <td style="width: 199px; height: 21px">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Width="60px"></asp:Label></td>
            <td style="width: 254px; height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 184px">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="To" Width="60px"></asp:Label></td>
            <td style="width: 199px">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Width="60px"></asp:Label></td>
            <td style="width: 254px">
            </td>
        </tr>
        <tr>
            <td style="width: 184px; height: 21px">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="current bus time:" Width="117px"></asp:Label></td>
            <td style="width: 199px; height: 21px">
                <asp:TextBox ID="TextBox4" runat="server" Width="82px"></asp:TextBox>
                &nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="required:" Width="64px"></asp:Label></td>
            <td style="width: 254px; height: 21px">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Width="60px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 184px">
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Fine" Width="60px"></asp:Label></td>
            <td style="width: 199px">
                <asp:TextBox ID="TextBox5" runat="server" Width="82px"></asp:TextBox>
                &nbsp; &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton1" runat="server" Text="paid" /></td>
            <td style="width: 254px">
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Not paid" /></td>
        </tr>
        <tr>
            <td style="width: 184px">
            </td>
            <td style="width: 199px">
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Trip cut" /></td>
            <td style="width: 254px">
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Block" /></td>
        </tr>
        <tr>
            <td style="width: 184px">
            </td>
            <td style="width: 199px">
                <asp:Button ID="Button1" runat="server" Text="Submit" Width="66px" /></td>
            <td style="width: 254px">
            </td>
        </tr>
    </table>
</asp:Content>

