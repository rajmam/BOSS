<%@ Page Language="C#" MasterPageFile="~/owners.master" AutoEventWireup="true" CodeFile="own_bustimeview.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" BorderStyle="Solid" Caption="BUS TIME TABLE" CellPadding="4"
        DataKeyNames="brt_id" DataSourceID="ObjectDataSource2" Font-Bold="True" ForeColor="#333333"
        GridLines="None" Height="211px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
        Width="513px">
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="day" HeaderText="day" SortExpression="day" />
            <asp:BoundField DataField="trip_start_time" HeaderText="time" SortExpression="time" />
            <asp:BoundField DataField="from" HeaderText="from" SortExpression="from" />
            <asp:BoundField DataField="to" HeaderText="to" SortExpression="to" />
            <asp:BoundField DataField="bus_reg_no" HeaderText="register no" SortExpression="reg_no" />
            <asp:BoundField DataField="trip_no" HeaderText="trip no" SortExpression="trip_no" />
            <asp:BoundField DataField="trip_category" HeaderText="trip_category" SortExpression="category" />
        </Columns>
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <EditRowStyle BackColor="#E0E0E0" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="DeleteTrip"
        SelectMethod="ViewAllData" TypeName="add_trip_sp">
        <DeleteParameters>
            <asp:Parameter Name="brt_id" Type="Int32" />
        </DeleteParameters>
    </asp:ObjectDataSource>
</asp:Content>

