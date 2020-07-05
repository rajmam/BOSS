<%@ Page Language="C#" MasterPageFile="~/major.master" AutoEventWireup="true" CodeFile="majpass_time.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="Solid"
        Caption="BUS TIME TABLE" CellPadding="4" Font-Bold="True" ForeColor="#333333"
        GridLines="None" Width="398px" Height="207px" AllowSorting="True" DataSourceID="ObjectDataSource1">
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <EditRowStyle BackColor="#E0E0E0" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ViewAllBusOfGivenRoot"
        TypeName="add_trip_sp">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="to" PropertyName="SelectedValue"
                Type="String" />
            <asp:Parameter Name="day" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    &nbsp; &nbsp;&nbsp; &nbsp;
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" Width="82px"><-- BACK</asp:LinkButton>
</asp:Content>

