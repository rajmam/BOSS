<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="workers.aspx.cs" Inherits="workers" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function imag_wrkr_onclick() {

}

// ]]>
</script>

    <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
        <asp:View ID="View1" runat="server">
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
                Text="Add New" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" Width="560px" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="worker_id" Height="170px">
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:BoundField DataField="worker_name" HeaderText="NAME" />
                    <asp:BoundField DataField="work_category" HeaderText="CATEGORY" />
                    <asp:CommandField ShowSelectButton="True" SelectText="More Options" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                <RowStyle BackColor="#E3EAEB" />
                <EditRowStyle BackColor="#7C6F57" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ViewAllWorkers" TypeName="Worker_Sp" DeleteMethod="Delete_Worker">
                <DeleteParameters>
                    <asp:Parameter Name="worker_id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table style="width: 508px">
                <tr>
                    <td style="width: 86px">
                        <asp:Label ID="Label1" runat="server" Text="NAME" Width="89px"></asp:Label></td>
                    <td style="width: 513px">
                        <asp:TextBox ID="txtname" runat="server" Width="166px" OnTextChanged="txtname_TextChanged"></asp:TextBox></td>
                    <td style="width: 114px">
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 86px; height: 24px;">
                        <asp:Label ID="Label2" runat="server" Text="TYPE" Width="87px"></asp:Label></td>
                    <td style="width: 513px; height: 24px;">
                        <asp:DropDownList ID="txttype" runat="server" Width="121px" OnSelectedIndexChanged="txttype_SelectedIndexChanged">
                            <asp:ListItem Value="Conductor">Conductor</asp:ListItem>
                            <asp:ListItem Value="Driver">Driver</asp:ListItem>
                            <asp:ListItem Selected="True" Value="Conductor/Driver">Conductor/Driver</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label5" runat="server" Width="117px"></asp:Label></td>
                    <td style="width: 114px; height: 24px;">
                    </td>
                    <td style="height: 24px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 86px">
                        <asp:Label ID="Label6" runat="server" Text="License No."></asp:Label></td>
                    <td style="width: 513px">
                        <asp:TextBox ID="txtid" runat="server" OnTextChanged="txtid_TextChanged"></asp:TextBox></td>
                    <td style="width: 114px">
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="width: 86px; height: 24px;">
                        <asp:Label ID="Label4" runat="server" Font-Bold="False" Text="PHOTO" Width="87px"></asp:Label></td>
                    <td style="width: 513px; height: 24px;">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="280px" /></td>
                    <td style="width: 114px; height: 24px;">
                        </td>
                    <td style="height: 24px">
                        </td>
                </tr>
                <tr>
                    <td style="width: 86px">
                        <asp:Label ID="Label3" runat="server" Text="ADDRESS" Width="88px"></asp:Label></td>
                    <td style="width: 513px">
                        <asp:TextBox ID="txtaddress" runat="server" Height="99px" TextMode="MultiLine" Width="273px"></asp:TextBox></td>
                    <td style="width: 114px">
                        <asp:Image ID="Image1" runat="server" Height="102px" Width="97px" /></td>
                    <td>
                        </td>
                </tr>
                <tr>
                    <td style="width: 86px; height: 26px">
                    </td>
                    <td style="width: 513px; height: 26px">
                        &nbsp; &nbsp; &nbsp;
                        <asp:Label ID="lbfile" runat="server" Width="229px"></asp:Label></td>
                    <td style="width: 114px; height: 26px">
                    </td>
                    <td style="height: 26px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 86px; height: 26px">
                    </td>
                    <td style="width: 513px; height: 26px">
                        <asp:Button ID="Btnsubmit" runat="server" Text="Submit" OnClick="Btnsubmit_Click" />
                        &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="Btncancel" runat="server" Text="cancel" /></td>
                    <td style="width: 114px; height: 26px">
                        </td>
                    <td style="height: 26px">
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="View3" runat="server">
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource2"
                Height="160px" OnItemCommand="DetailsView1_ItemCommand" OnItemInserted="DetailsView1_ItemInserted"
                OnItemUpdated="DetailsView1_ItemUpdated" Width="265px" OnPageIndexChanging="DetailsView1_PageIndexChanging">
                <Fields>
                    <asp:BoundField DataField="Worker_Name" HeaderText="Worker_Name" SortExpression="Worker_Name" />
                    <asp:BoundField DataField="Licence_No" HeaderText="Licence_No" SortExpression="Licence_No" />
                    <asp:BoundField DataField="Adress" HeaderText="Adress" SortExpression="Adress" />
                    <asp:BoundField DataField="Bus_Id" HeaderText="Bus_Id" SortExpression="Bus_Id" />
                    <asp:BoundField DataField="Work_Category" HeaderText="Work_Category" SortExpression="Work_Category" />
                    <asp:BoundField DataField="Worker_Id" HeaderText="Worker_Id" SortExpression="Worker_Id" />
                    <asp:BoundField DataField="Worker_Photo" HeaderText="Worker_Photo" SortExpression="Worker_Photo" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" DeleteText="" />
                    <asp:ButtonField CommandName="GoBackToView1" Text="Back" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="Worker_Info"
                DeleteMethod="Delete_Worker" InsertMethod="Add_Worker" SelectMethod="View_Worker"
                TypeName="Worker_Sp" UpdateMethod="Update_Worker">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="wrkr_id" PropertyName="SelectedValue"
                        Type="Int32" />
                </SelectParameters>
                <DeleteParameters>
                    <asp:Parameter Name="worker_id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
        </asp:View>
    </asp:MultiView>
</asp:Content>

