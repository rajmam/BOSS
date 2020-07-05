<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_bustimeview.aspx.cs" Inherits="admin_bustimeview" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
                BorderStyle="Solid" Caption="BUS TIME TABLE" CellPadding="4" DataKeyNames="brt_id"
                DataSourceID="ObjectDataSource2" Font-Bold="True" ForeColor="#333333" GridLines="None"
                Height="211px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="513px">
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:BoundField DataField="day" HeaderText="day" SortExpression="day" />
                    <asp:BoundField DataField="trip_start_time" HeaderText="time" SortExpression="time" />
                    <asp:BoundField DataField="from" HeaderText="from" SortExpression="from" />
                    <asp:BoundField DataField="to" HeaderText="to" SortExpression="to" />
                    <asp:BoundField DataField="bus_reg_no" HeaderText="register no" SortExpression="reg_no" />
                    <asp:BoundField DataField="trip_no" HeaderText="trip no" SortExpression="trip_no" />
                    <asp:BoundField DataField="trip_category" HeaderText="trip_category" SortExpression="category" />
                    <asp:CommandField HeaderText="select" ShowHeader="True" ShowSelectButton="True" />
                    <asp:CommandField HeaderText="delete" ShowDeleteButton="True" ShowHeader="True" />
                </Columns>
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <EditRowStyle BackColor="#E0E0E0" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            &nbsp;
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="DeleteTrip"
                SelectMethod="ViewAllData" TypeName="add_trip_sp">
                <DeleteParameters>
                    <asp:Parameter Name="brt_id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
        </asp:View>
        <asp:View ID="View2" runat="server">
            &nbsp; &nbsp;
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1"
                Height="82px" Width="409px" OnItemCommand="DetailsView1_ItemCommand" OnItemDeleted="DetailsView1_ItemDeleted" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated" OnPageIndexChanging="DetailsView1_PageIndexChanging">
                <Fields>
                    <asp:BoundField DataField="Trip_no" HeaderText="Trip_no" SortExpression="Trip_no" />
                    <asp:BoundField DataField="From" HeaderText="From" SortExpression="From" />
                    <asp:BoundField DataField="To" HeaderText="To" SortExpression="To" />
                    <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                    <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" />
                    <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                    <asp:BoundField DataField="Regn_no" HeaderText="Regn_no" SortExpression="Regn_no" />
                    <asp:CommandField DeleteText="" ShowEditButton="True" />
                    <asp:CommandField DeleteText="" ShowInsertButton="True" />
                    <asp:ButtonField CommandName="GoBackToView1" Text="Back" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="add_trip_info"
                InsertMethod="Add" SelectMethod="ViewTrip" TypeName="add_trip_sp" UpdateMethod="Update">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="brt_id" PropertyName="SelectedValue"
                        Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </asp:View>
    </asp:MultiView>
</asp:Content>

