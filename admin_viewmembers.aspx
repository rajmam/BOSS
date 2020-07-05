<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_viewmembers.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:MultiView ID="MultiView1" runat="server">
        &nbsp;
        <asp:View ID="View1" runat="server">
            &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="OWNERS DETAILS"
                CellPadding="4" DataKeyNames="no" DataSourceID="ObjectDataSource1" Font-Bold="True"
                GridLines="None" Height="184px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                Width="459px" ForeColor="#333333" AllowPaging="True">
                <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                <Columns>
                    <asp:BoundField DataField="nam" HeaderText="NAME" />
                    <asp:BoundField ConvertEmptyStringToNull="False" DataField="mobile" HeaderText="MOBILE" />
                    <asp:CommandField SelectText="More" ShowSelectButton="True" />
                </Columns>
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                SelectMethod="ViewAuthorisedMembers" TypeName="Memb_Sp"></asp:ObjectDataSource>
            &nbsp;<br />
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Button ID="BtnOk" runat="server" Text="OK" Width="107px" OnClick="BtnOk_Click" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp;&nbsp;
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table style="width: 562px; height: 80px">
                <tr>
                    <td style="width: 90px; height: 28px">
                        <asp:Label ID="Label1" runat="server" Text="NAME"></asp:Label></td>
                    <td style="width: 178px; height: 28px">
                        <asp:Label ID="lbname" runat="server" Width="150px"></asp:Label></td>
                    <td style="width: 275px; height: 28px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px">
                        <asp:Label ID="Label2" runat="server" Text="AGE"></asp:Label></td>
                    <td style="width: 178px">
                        <asp:Label ID="lbage" runat="server" Width="149px"></asp:Label></td>
                    <td style="width: 275px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 18px">
                        <asp:Label ID="Label3" runat="server" Height="114px" Text="ADDRESS" Width="141px"></asp:Label></td>
                    <td style="width: 178px; height: 18px">
                        <asp:Label ID="lbadd" runat="server" Height="114px" Width="152px"></asp:Label></td>
                    <td style="width: 275px; height: 18px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Image ID="Image1" runat="server" Height="121px" ImageAlign="Middle" Width="115px" /></td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                        <asp:Label ID="Label4" runat="server" Text="E-MAIL ID"></asp:Label></td>
                    <td style="width: 178px; height: 21px">
                        <asp:Label ID="lbemail" runat="server" Width="151px"></asp:Label></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                        <asp:Label ID="Label5" runat="server" Text="PHONE"></asp:Label></td>
                    <td style="width: 178px; height: 21px">
                        <asp:Label ID="lbphno" runat="server" Width="147px"></asp:Label></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                        <asp:Label ID="Label6" runat="server" Text="NO. OF BUSES OWNED" Width="139px"></asp:Label></td>
                    <td style="width: 178px; height: 21px">
                        <asp:Label ID="lbnob" runat="server" Height="24px"></asp:Label></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 9px">
                    </td>
                    <td style="width: 178px; height: 9px">
                    </td>
                    <td style="width: 275px; height: 9px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                    </td>
                    <td style="width: 178px; height: 21px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="106px" /></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

