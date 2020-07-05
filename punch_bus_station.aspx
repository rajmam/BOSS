<%@ Page Language="C#" MasterPageFile="~/punch.master" AutoEventWireup="true" CodeFile="punch_bus_station.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="brt_id" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table style="width: 536px">
                <tr>
                    <td style="width: 184px; height: 21px">
                        <asp:Label ID="lbday" runat="server"></asp:Label></td>
                    <td style="width: 199px; height: 21px">
                        <asp:Label ID="lbdate" runat="server" Font-Bold="True" Width="134px"></asp:Label></td>
                    <td style="width: 254px; height: 21px">
                        <asp:Label ID="lbtime" runat="server" Font-Bold="True" Width="134px"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 23px">
                    </td>
                    <td style="width: 199px; height: 23px">
                        <asp:Label ID="lbpunchstname" runat="server" Font-Bold="True" Width="134px"></asp:Label></td>
                    <td style="width: 254px; height: 23px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Bus No" Width="60px"></asp:Label></td>
                    <td style="width: 199px">
                        <asp:Label ID="lbbus_no" runat="server" Font-Bold="True" Text="Bus No" Width="60px"></asp:Label></td>
                    <td style="width: 254px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 21px">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Trip No" Width="60px"></asp:Label></td>
                    <td style="width: 199px; height: 21px">
                        <asp:Label ID="lbtrip_no" runat="server" Font-Bold="True" Text="Trip No" Width="60px"></asp:Label></td>
                    <td style="width: 254px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 21px">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="From" Width="60px"></asp:Label></td>
                    <td style="width: 199px; height: 21px">
                        <asp:Label ID="lbfrom" runat="server" Font-Bold="True" Width="60px"></asp:Label></td>
                    <td style="width: 254px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 21px">
                        <asp:Label ID="lb_current_date" runat="server" Font-Bold="True" Text="To" Width="60px"></asp:Label></td>
                    <td style="width: 199px; height: 21px">
                        <asp:Label ID="lbto" runat="server" Font-Bold="True" Width="60px"></asp:Label></td>
                    <td style="width: 254px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Expected time"></asp:Label></td>
                    <td style="width: 199px">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Width="60px"></asp:Label></td>
                    <td style="width: 254px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 21px">
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Arrival time" Width="117px"></asp:Label></td>
                    <td style="width: 199px; height: 21px">
                        <asp:Label ID="lbarrtime" runat="server" Font-Bold="True"></asp:Label>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    </td>
                    <td style="width: 254px; height: 21px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 22px">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Late By" Width="117px"></asp:Label></td>
                    <td style="width: 199px; height: 22px">
                        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Width="79px"></asp:Label>&nbsp;
                    </td>
                    <td style="width: 254px; height: 22px">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px; height: 22px">
                        <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Fine" Width="60px"></asp:Label></td>
                    <td style="width: 199px; height: 22px">
                        <asp:TextBox ID="txtfine" runat="server"></asp:TextBox></td>
                    <td style="width: 254px; height: 22px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px">
                    </td>
                    <td style="width: 199px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="66px" /></td>
                    <td style="width: 254px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 184px">
                    </td>
                    <td style="width: 199px">
                    </td>
                    <td style="width: 254px">
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

