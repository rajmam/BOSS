<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_punchsettings.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <table style="width: 412px">
                <tr>
                    <td style="width: 85px">
                        <asp:Label ID="Label1" runat="server" Text="view all punching" Width="130px"></asp:Label></td>
                    <td>
                        <asp:Button ID="btnview" runat="server" OnClick="btnview_Click" Text="View" /></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 85px">
                        <asp:Label ID="Label2" runat="server" Text="clear all"></asp:Label></td>
                    <td>
                        <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="delelte" /></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 85px">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table style="width: 409px">
                <tr>
                    <td>
                        ARE YOU SURE TO DELETE ALL ENTRIES</td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" Text="YES" />
                        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:Button ID="btnno" runat="server" OnClick="btnno_Click" Text="NO" Width="43px" />
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><=back</asp:LinkButton></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Font-Italic="True" ForeColor="Red" Visible="False">successfully removed.</asp:Label></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="View3" runat="server">
            &nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="punch_fine_date" HeaderText="Date" SortExpression="punch_fine_date" />
                    <asp:BoundField DataField="bus_no" HeaderText="Bus No" />
                    <asp:BoundField DataField="punch_name" HeaderText="Punch Name" />
                    <asp:BoundField DataField="punched_time" HeaderText="Punched Time" />
                    <asp:BoundField DataField="late_by" HeaderText="Late By" />
                    <asp:BoundField DataField="fine_amount" HeaderText="Fine Amount" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="View_All_Punch_Fine"
                TypeName="Punch_Fine_Sp"></asp:ObjectDataSource>
        </asp:View>
    </asp:MultiView>
</asp:Content>

