<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_verification.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84"
                BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"
                DataKeyNames="no" DataSourceID="ObjectDataSource1" Height="203px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AllowPaging="True" AllowSorting="True">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <Columns>
                    <asp:BoundField DataField="nam" HeaderText="Name" />
                    <asp:BoundField DataField="age" HeaderText="Age" />
                    <asp:BoundField DataField="address" HeaderText="Address" />
                    <asp:BoundField DataField="mobile" HeaderText="Mobile" />
                    <asp:BoundField DataField="nob" HeaderText="No Of Buses" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete_Memb"
                SelectMethod="ViewAllMembers" TypeName="Memb_Sp">
                <DeleteParameters>
                    <asp:Parameter Name="newusrname" Type="String" />
                </DeleteParameters>
            </asp:ObjectDataSource>
            &nbsp; &nbsp;
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table style="width: 461px">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name" Width="91px"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="txtname" runat="server" ReadOnly="True" Width="221px"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="txtage" runat="server" ReadOnly="True" Width="220px"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="txtaddress" runat="server" Height="143px" ReadOnly="True" TextMode="MultiLine"
                            Width="223px"></asp:TextBox></td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="149px" Width="160px" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="No of bus"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="txtnob" runat="server" ReadOnly="True" Width="51px"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Mobile"></asp:Label></td>
                    <td style="width: 144px">
                        <asp:TextBox ID="txtmobile" runat="server" ReadOnly="True"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td style="width: 144px">
                        &nbsp; &nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Accept" />
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Reject" /></td>
                    <td>
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>&nbsp;
</asp:Content>

