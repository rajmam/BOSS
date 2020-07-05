<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_regn.aspx.cs" Inherits="admin_regn" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="TABLE1" onclick="return TABLE1_onclick()" style="width: 498px; height: 112px">
        <tr>
            <td style="width: 85px">
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large"
                    Text="REGN FORM" Width="217px"></asp:Label></td>
            <td style="width: 69px">
            </td>
        </tr>
        <tr>
            <td style="width: 85px">
            </td>
            <td>
            </td>
            <td style="width: 69px">
            </td>
        </tr>
        <tr>
            <td style="width: 85px">
                <asp:Label ID="Label1" runat="server" Text="user name" Width="153px"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtuname" runat="server" Width="189px"></asp:TextBox></td>
            <td style="width: 69px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtuname"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 26px; width: 85px;">
                <asp:Label ID="Label2" runat="server" Text="age" Width="150px"></asp:Label></td>
            <td style="height: 26px">
                <asp:TextBox ID="txtage" runat="server" Width="188px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtage"
                    ErrorMessage="sorry, not admittable!" Height="11px" MaximumValue="100" MinimumValue="18"
                    Type="Integer" Width="174px"></asp:RangeValidator></td>
            <td style="height: 26px; width: 69px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtage"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 85px; height: 36px">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Photo" Width="129px" Height="12px"></asp:Label></td>
            <td style="height: 36px">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="214px" /><asp:Label ID="lbfile" runat="server"
                    ForeColor="Red" Width="169px"></asp:Label></td>
            <td style="width: 69px; height: 36px">
                <asp:Label ID="Label11" runat="server" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 85px; height: 26px">
                <asp:Label ID="lbusrname" runat="server" Text="Choose user name" Width="147px"></asp:Label></td>
            <td style="height: 26px">
                <asp:TextBox ID="txtusrname" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td style="width: 69px; height: 26px">
                <asp:Label ID="lbusrname1" runat="server" ForeColor="Red" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 26px; width: 85px;">
                <asp:Label ID="Label3" runat="server" Text="password" Width="147px"></asp:Label></td>
            <td style="height: 26px">
                <asp:TextBox ID="txtpw" runat="server" Width="188px" TextMode="Password"></asp:TextBox></td>
            <td style="height: 26px; width: 69px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtpw"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 85px">
                <asp:Label ID="Label4" runat="server" Text="retype password" Width="154px"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtvpw" runat="server" Width="187px" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpw"
                    ControlToValidate="txtvpw" CultureInvariantValues="True" ErrorMessage="password missmatch"></asp:CompareValidator></td>
            <td style="width: 69px">
                </td>
        </tr>
        <tr>
            <td style="width: 85px">
                <asp:Label ID="Label5" runat="server" Text="address" Width="158px"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtadd" runat="server" Height="95px" Width="186px" TextMode="MultiLine"></asp:TextBox></td>
            <td style="width: 69px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtadd"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 85px">
                <asp:Label ID="Label6" runat="server" Text="e_mail_id" Width="162px"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtemid" runat="server" Width="185px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtemid"
                    ErrorMessage="Not an E_mail id!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            <td style="width: 69px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px; width: 85px;">
                <asp:Label ID="Label7" runat="server" Text="mobile no" Width="156px"></asp:Label></td>
            <td style="height: 26px">
                <asp:TextBox ID="txtmob" runat="server" Width="185px"></asp:TextBox></td>
            <td style="height: 26px; width: 69px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtmob"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 85px">
                <asp:Label ID="Label9" runat="server" Text=" no of buses own" Width="161px"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtnob" runat="server" Width="185px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnob"
                    ErrorMessage="Invalid entry!!" ValidationExpression="[1-99]{1,2}"></asp:RegularExpressionValidator></td>
            <td style="width: 69px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnob"
                    ErrorMessage="Custom entry!!" Width="113px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 22px; width: 85px;">
                <asp:Label ID="Label18" runat="server" Text=" verification" Width="160px"></asp:Label>
                </td>
            <td style="height: 22px">
                
                &nbsp; &nbsp; &nbsp; 
                <asp:RadioButton ID="RadioButton1" runat="server" Text="verified"  Width="96px" GroupName="111" />
                &nbsp; &nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton3" runat="server" Text="verify later" Width="86px" GroupName="111"  />&nbsp;&nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
            <td style="height: 22px; width: 69px;">
                </td>
        </tr>
        <tr>
            <td style="height: 26px; width: 69px;">
            </td>
        </tr>
        <tr>
            <td style="width: 69px; height: 26px">
            </td>
        </tr>
        <tr>
            <td style="width: 85px; height: 26px" valign="top">
            </td>
            <td style="height: 26px">
                <asp:Button ID="Button1" runat="server"
                    BackColor="#FFFFC0" BorderColor="Goldenrod" BorderStyle="Solid" 
                    Text="submit" OnClick="Button1_Click" Width="64px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Cancel" />
            </td>
            <td style="width: 69px; height: 26px">
            </td>
        </tr>
        <tr>
            <td style="width: 85px; height: 26px" valign="top">
                &nbsp;</td>
            <td style="height: 26px">
                &nbsp;</td>
            <td style="width: 69px; height: 26px">
            </td>
        </tr>
        <tr>
            <td style="height: 26px; width: 85px;" valign="top">
            </td>
            <td style="height: 26px">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; 
                </td>
            <td style="width: 69px; height: 26px">
            </td>
        </tr>
    </table>
</asp:Content>
