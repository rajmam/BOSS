<%@ Page Language="C#" MasterPageFile="~/owners.master" AutoEventWireup="true" CodeFile="owners_home.aspx.cs" Inherits="owners_home" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <table style="width: 581px">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Font-Names="Times New Roman" Font-Size="Large"
                            Text="Welcome " Width="74px"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Names="Comic Sans MS"
                            Font-Size="Large" Width="77px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Find Bus Owner"
                Width="385px"></asp:Label><table style="width: 545px">
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Enter vehicle No:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtvehicle" runat="server"></asp:TextBox>
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" /></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 22px">
                        </td>
                        <td style="height: 22px">
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Red" Text="Sorry,currently unavailable"
                                Visible="False"></asp:Label></td>
                        <td style="height: 22px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 21px">
                        </td>
                        <td style="height: 21px">
                        </td>
                        <td style="height: 21px">
                        </td>
                    </tr>
                </table>
            <table style="width: 581px">
                <tr>
                    <td style="height: 31px">
                        &nbsp;<strong>Find next Meeting</strong></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" /></td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
            </table>
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
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
        <asp:View ID="View3" runat="server">
            &nbsp;<asp:Repeater ID="Repeater1" runat="server" DataMember="meeting_no" OnItemCommand="Repeater1_ItemCommand"
                OnItemDataBound="Repeater1_ItemDataBound">
                <ItemTemplate>
                    <asp:Literal ID="Literfg" runat="server" Text="Date of Meeting:"></asp:Literal>
                    &nbsp; &nbsp;
                    <asp:Literal ID="lbdate" runat="server" Text=""></asp:Literal><br />
                    <asp:Literal ID="Litfgl2" runat="server" Text="Time:"></asp:Literal>
                    &nbsp; &nbsp;
                    <asp:Literal ID="lbtime" runat="server" Text=""></asp:Literal><br />
                    <asp:Literal ID="Liteghh" runat="server" Text="Location:"></asp:Literal>
                    &nbsp; &nbsp;
                    <asp:Literal ID="lblocation" runat="server" Text=""></asp:Literal>
                    <br />
                    <asp:Literal ID="Literal1" runat="server" Text="Subject:"> </asp:Literal>&nbsp;
                    &nbsp;
                    <asp:Literal ID="lbsubject" runat="server" Text=""></asp:Literal><br />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Literal ID="lbdetails" runat="server" Text=""></asp:Literal><br />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                </ItemTemplate>
                <SeparatorTemplate>
                    <hr />
                </SeparatorTemplate>
            </asp:Repeater>
        </asp:View>
    </asp:MultiView><br />
    <br />
</asp:Content>

