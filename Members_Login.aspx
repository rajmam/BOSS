<%@ Page Language="C#" MasterPageFile="~/members.master" AutoEventWireup="true" CodeFile="Members_Login.aspx.cs" Inherits="Members_Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%
        Response.Buffer = true;
        Response.Expires = 0;
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
        Response.CacheControl = "no-Cache";
        
         %>
    <asp:MultiView ID="MultiView1" runat="server" >
        <asp:View ID="View1" runat="server">
            &nbsp;&nbsp;
            <table style="width: 494px">
                <tr>
                    <td style="width: 251px">
            <asp:Image ID="Image1" runat="server" Height="198px" ImageUrl="~/Images/shakehand.gif"
                Width="324px" /></td>
                    <td style="width: 21px">
            <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4"
                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
                ForeColor="#333333" OnAuthenticate="Login1_Authenticate" Height="174px" RememberMeSet="True" Width="174px">
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <TextBoxStyle Font-Size="0.8em" />
                <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            </asp:Login>
                        <asp:Label ID="lbunexpcted" runat="server" Font-Bold="True" ForeColor="#FF8080" Width="200px"></asp:Label></td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="View2" runat="server">
            &nbsp;<br />
        </asp:View>
    </asp:MultiView>
    
</asp:Content>

