<%@ Page Language="C#" MasterPageFile="~/owners.master" AutoEventWireup="true" CodeFile="owners_details.aspx.cs" Inherits="owners_details" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function imght_onclick() {

}

// ]]>
</script>

    &nbsp;<asp:MultiView ID="MultiView1" runat="server">
        &nbsp;
        <asp:View ID="View1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" Caption="OWNERS DETAILS"
        CellPadding="3" Font-Bold="True" GridLines="Vertical" Width="459px" DataSourceID="ObjectDataSource1" Height="184px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="no" AllowPaging="True" AllowSorting="True">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <Columns>
            <asp:BoundField DataField="nam" HeaderText="NAME" />
            <asp:BoundField ConvertEmptyStringToNull="False" DataField="mobile" HeaderText="MOBILE" />
            <asp:CommandField SelectText="More" ShowSelectButton="True" />
        </Columns>
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ViewAuthorisedMembers"
        TypeName="Memb_Sp" OnSelecting="ObjectDataSource1_Selecting"></asp:ObjectDataSource>
            <br />
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
                        <asp:Label ID="Label3" runat="server" Text="ADDRESS" Height="114px" Width="141px"></asp:Label></td>
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
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
                            Text="OK" Width="106px" /></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

