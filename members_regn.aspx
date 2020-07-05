<%@ Page Language="C#" MasterPageFile="~/members.master" AutoEventWireup="true" CodeFile="members_regn.aspx.cs" Inherits="members_regn" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
    <table id="TABLE1" onclick="return TABLE1_onclick()" style="width: 498px; height: 112px">
        <tr>
            <td style="width: 179px">
            </td>
            <td style="width: 207px">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large"
                    Text="REGN FORM" Width="217px"></asp:Label></td>
            <td style="width: 152px">
            </td>
        </tr>
        <tr>
            <td style="width: 179px">
            </td>
            <td style="width: 207px">
            </td>
            <td style="width: 152px">
            </td>
        </tr>
        <tr>
            <td style="height: 28px; width: 179px;">
                <asp:Label ID="Label1" runat="server" Text="user name" Width="184px"></asp:Label></td>
            <td style="width: 207px; height: 28px">
                <asp:TextBox ID="txtuname" runat="server" Width="189px" ></asp:TextBox></td>
            <td style="width: 152px; height: 28px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtuname"
                    ErrorMessage="please retype" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 55px; width: 179px;">
                <asp:Label ID="Label2" runat="server" Text="age" Width="184px"></asp:Label></td>
            <td style="width: 207px; height: 55px">
                <asp:TextBox ID="txtage" runat="server" Width="188px" OnTextChanged="txtage_TextChanged"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtage"
                    ErrorMessage="sorry, not admittable!" Height="11px" MaximumValue="100" MinimumValue="18"
                    Type="Integer" Width="174px"></asp:RangeValidator></td>
            <td style="width: 152px; height: 55px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtage"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 179px; height: 55px">
                <asp:Label ID="Label10" runat="server" Text="Photo" Width="57px" Font-Bold="True" Height="1px"></asp:Label>&nbsp;
            </td>
            <td style="width: 207px; height: 55px">
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" Height="19px" /><br />
                <asp:Label ID="Label11" runat="server" Visible="False"></asp:Label></td>
            <td style="width: 152px; height: 55px">
                <asp:Label ID="lbfile" runat="server" Visible="False" ForeColor="Red" Width="169px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 179px; height: 8px">
                <asp:Label ID="lbusrname" runat="server" Text="choose user name" Width="184px"></asp:Label></td>
            <td style="width: 207px; height: 8px">
                <asp:TextBox ID="txtusrname" runat="server" Width="189px"></asp:TextBox></td>
            <td style="width: 152px; height: 8px">
                <asp:Label ID="lbusrname1" runat="server" ForeColor="Red" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 40px; width: 179px;">
                <asp:Label ID="Label3" runat="server" Text="password" Width="184px"></asp:Label></td>
            <td style="height: 40px; width: 207px;">
                <asp:TextBox ID="txtpw" runat="server" Width="188px" TextMode="Password"></asp:TextBox></td>
            <td style="height: 40px; width: 152px;">
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtpw"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 45px; width: 179px;">
                <asp:Label ID="Label4" runat="server" Text="retype password" Width="184px"></asp:Label></td>
            <td style="width: 207px; height: 45px">
                <asp:TextBox ID="txtvpw" runat="server" Width="187px" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpw"
                    ControlToValidate="txtvpw" ErrorMessage="password missmatch" CultureInvariantValues="True"></asp:CompareValidator></td>
            <td style="width: 152px; height: 45px;">
                </td>
        </tr>
        <tr>
            <td style="height: 105px; width: 179px;">
                <asp:Label ID="Label5" runat="server" Text="address" Width="184px"></asp:Label></td>
            <td style="height: 105px; width: 207px;">
                <asp:TextBox ID="txtadd" runat="server" Height="95px" Width="186px" TextMode="MultiLine"></asp:TextBox></td>
            <td style="height: 105px; width: 152px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtadd"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 26px; width: 179px;">
                <asp:Label ID="Label6" runat="server" Text="e_mail_id" Width="184px"></asp:Label></td>
            <td style="width: 207px; height: 26px">
                <asp:TextBox ID="txtemid" runat="server" Width="185px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtemid"
                    ErrorMessage="Not an E_mail id!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            <td style="width: 152px; height: 26px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px; width: 179px;">
                <asp:Label ID="Label7" runat="server" Text="mobile no" Width="184px"></asp:Label></td>
            <td style="height: 26px; width: 207px;">
                <asp:TextBox ID="txtmob" runat="server" Width="185px"></asp:TextBox></td>
            <td style="width: 152px; height: 26px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtmob"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 45px; width: 179px;">
                <asp:Label ID="Label9" runat="server" Text=" no of buses own" Width="184px"></asp:Label></td>
            <td style="width: 207px; height: 45px;">
                <asp:TextBox ID="txtnob" runat="server" Width="185px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnob"
                    ErrorMessage="Invalid entry!!" ValidationExpression="[1-99]{1,2}"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 152px; height: 45px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnob"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 26px; width: 179px;" valign="top">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
            <td style="height: 26px; width: 207px;">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:Button ID="Button5" runat="server"
                    BackColor="#FFFFC0" BorderColor="Goldenrod" BorderStyle="Solid" Text="SUBMIT" OnClick="Button1_Click" Width="63px" Font-Bold="True" />
                &nbsp; &nbsp; &nbsp; &nbsp;</td>
            <td style="height: 26px; width: 152px;">
            </td>
        </tr>
        <tr>
            <td style="width: 179px; height: 26px" valign="top">
            </td>
            <td style="width: 207px; height: 26px">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
            <td style="width: 152px; height: 26px">
            </td>
        </tr>
    </table>
        </asp:View>
        <asp:View ID="View2" runat="server">
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp;<br />
            <table style="width: 521px">
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="THANK YOU " Width="184px"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
            </table>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Label ID="Label13" runat="server" Text="hi " Width="32px"></asp:Label>
            <asp:Label ID="lbhiname" runat="server" Width="99px"></asp:Label>
            <asp:Label ID="Label16" runat="server" Text="," Width="32px"></asp:Label><br />
            <table style="width: 521px">
                <tr>
                    <td style="height: 21px">
                    </td>
                    <td style="width: 251px; height: 21px">
                    </td>
                    <td style="height: 21px">
                    </td>
                </tr>
                <tr>
                    <td style="height: 21px">
                    </td>
                    <td style="width: 251px; height: 21px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Label ID="Label12" runat="server" Text="your id is:" Width="71px"></asp:Label></td>
                    <td style="height: 21px">
                        <asp:Label ID="lbid" runat="server" Width="115px"></asp:Label></td>
                </tr>
                <tr>
                    <td style="height: 21px">
                    </td>
                    <td style="width: 251px; height: 21px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Label ID="Label15" runat="server" Text="your user name:" Width="99px"></asp:Label></td>
                    <td style="height: 21px">
                        <asp:Label ID="lbusrname2" runat="server" Width="115px"></asp:Label></td>
                </tr>
            </table>
            <table style="width: 521px">
                <tr>
                    <td style="height: 21px">
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp; &nbsp; &nbsp; &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;<asp:Label ID="Label17" runat="server" Font-Bold="True" Width="519px">AFTER VERIFICATION YOU CAN LOGIN TO BOSS ,ONLY THROUG  THE ABOVE ID & USERNAME .SO PLEASE  REMEMBER THESE.  </asp:Label></td>
                </tr>
                <tr>
                    <td>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server"
                    BackColor="#FFFFC0" BorderColor="Goldenrod" BorderStyle="Solid" Text="OK" OnClick="Button1_Click" Width="63px" /></td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

