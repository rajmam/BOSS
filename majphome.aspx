<%@ Page Language="C#" MasterPageFile="~/major.master" AutoEventWireup="true" CodeFile="majphome.aspx.cs" Inherits="Default5" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <strong><em>I  WANT TO KNOW THE TIME OF AVAILABLE SERVICES 
    <br />
            </em></strong>
    <marquee style="font-weight: bold; font-style: italic"><asp:Label id="Label4" runat="server" Text="please select" Font-Bold="True" Width="84px" Font-Italic="True" ForeColor="Red" __designer:wfdid="w7"></asp:Label><BR /></marquee>
    <table style="width: 396px; height: 113px">
        <tr>
            <td style="width: 138px">
                &nbsp; &nbsp; &nbsp;
                <asp:Label ID="Label1" runat="server" Text="day"></asp:Label></td>
            <td style="width: 128px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="100px">
                    <asp:ListItem>monday</asp:ListItem>
                    <asp:ListItem>tuesday</asp:ListItem>
                    <asp:ListItem>wednesday</asp:ListItem>
                    <asp:ListItem>thursday</asp:ListItem>
                    <asp:ListItem>friday</asp:ListItem>
                    <asp:ListItem>saturday</asp:ListItem>
                    <asp:ListItem>sunday</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 8px">
            </td>
            <td style="width: 9px">
            </td>
        </tr>
        <tr>
            <td style="width: 138px">
                <asp:Label ID="Label2" runat="server" Text="FROM" Width="45px"></asp:Label></td>
            <td style="width: 128px">
                <asp:DropDownList ID="ddlfrom" runat="server" Width="101px">
                    <asp:ListItem Selected="True">calicut</asp:ListItem>
                </asp:DropDownList>
                &nbsp;
                &nbsp; &nbsp;
            </td>
            <td style="width: 8px">
                <asp:Label ID="Label3" runat="server" Text="TO" Width="26px"></asp:Label></td>
            <td style="width: 9px">
                <asp:DropDownList ID="ddlto" runat="server" Width="101px" DataSourceID="ObjectDataSource2" DataTextField="Punch_Name" DataValueField="Punch_Name">
                </asp:DropDownList><asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="View_BusStation"
                    TypeName="Punch_Station_Sp"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 138px; height: 7px">
            </td>
            <td style="width: 128px; height: 7px">
                <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="Label5" runat="server" Height="3px" Text="not possible" Visible="False" Width="84px"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
            <td style="width: 8px; height: 7px">
                </td>
            <td style="width: 9px; height: 7px">
            </td>
        </tr>
        <tr>
            <td style="width: 138px; height: 20px">
            </td>
            <td style="width: 128px; height: 20px">
            </td>
            <td style="width: 8px; height: 20px">
            </td>
            <td style="width: 9px; height: 20px">
            </td>
        </tr>
    </table>
            <br />
            <table style="width: 545px">
                <tr>
                    <td>
                        I WANT TO KNOW THE OWNER
                    </td>
                </tr>
            </table>
            <table style="width: 545px">
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Enter vehicle No:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtvehicle" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" /></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Text="Sorry,currently unavailable"
                            Visible="False"></asp:Label></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
    <br />
            To Comment On Calicut Bus transportation System
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">click here!</asp:LinkButton><br />
            <table style="width: 568px">
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="comment corner"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton2_Click">Show me all suggetions</asp:LinkButton></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Let me see the complaints</asp:LinkButton></td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="View2" runat="server">
            &nbsp;<asp:GridView ID="GridView1" runat="server" CellPadding="4"
                ForeColor="#333333" GridLines="None">
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            &nbsp;
        </asp:View>
        <asp:View ID="View3" runat="server">
            <table style="width: 562px; height: 80px">
                <tr>
                    <td style="width: 90px; height: 28px">
                        <asp:Label ID="Label8" runat="server" Text="NAME"></asp:Label></td>
                    <td style="width: 178px; height: 28px">
                        <asp:Label ID="lbname" runat="server" Width="150px"></asp:Label></td>
                    <td style="width: 275px; height: 28px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px">
                        <asp:Label ID="Label9" runat="server" Text="AGE"></asp:Label></td>
                    <td style="width: 178px">
                        <asp:Label ID="lbage" runat="server" Width="149px"></asp:Label></td>
                    <td style="width: 275px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 18px">
                        <asp:Label ID="Label10" runat="server" Height="114px" Text="ADDRESS" Width="141px"></asp:Label></td>
                    <td style="width: 178px; height: 18px">
                        <asp:Label ID="lbadd" runat="server" Height="114px" Width="152px"></asp:Label></td>
                    <td style="width: 275px; height: 18px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Image ID="Image1" runat="server" Height="121px" ImageAlign="Middle" Width="115px" /></td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                        <asp:Label ID="Label11" runat="server" Text="E-MAIL ID"></asp:Label></td>
                    <td style="width: 178px; height: 21px">
                        <asp:Label ID="lbemail" runat="server" Width="151px"></asp:Label></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                        <asp:Label ID="Label12" runat="server" Text="PHONE"></asp:Label></td>
                    <td style="width: 178px; height: 21px">
                        <asp:Label ID="lbphno" runat="server" Width="147px"></asp:Label></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 90px; height: 21px">
                        <asp:Label ID="Label13" runat="server" Text="NO. OF BUSES OWNED" Width="139px"></asp:Label></td>
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
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ok" Width="50px" /></td>
                    <td style="width: 275px; height: 21px">
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

