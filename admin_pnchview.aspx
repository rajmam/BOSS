<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_pnchview.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 322px">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="choose date"></asp:Label></td>
            <td style="width: 150px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="OK" /></td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC"
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2"
        ForeColor="Black">
        <FooterStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="as" HeaderText="Bus No" />
            <asp:BoundField DataField="ff" HeaderText="Bus Name" />
            <asp:BoundField DataField="11" HeaderText="trip  no" />
            <asp:BoundField DataField="11" HeaderText="p1" />
            <asp:BoundField DataField="11" HeaderText="p2" />
            <asp:BoundField DataField="11" HeaderText="p3" />
            <asp:BoundField DataField="11" HeaderText="p4" />
            <asp:BoundField DataField="11" HeaderText="p5" />
            <asp:BoundField DataField="11" HeaderText="p6" />
            <asp:BoundField DataField="11" HeaderText="fine (if any)" />
        </Columns>
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</asp:Content>

