<%@ Page Language="C#" MasterPageFile="~/major.master" AutoEventWireup="true" CodeFile="majorshowsuggesions.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="Repeater1" runat="server" DataMember="comment_id"  OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="Repeater1_ItemDataBound" >
    
    
    
    <ItemTemplate >
  
      <asp:Literal ID="lbcommentdate"    Text="CommentDate:" runat="server"></asp:Literal><br />
      
      <asp:Literal ID="lbtime"    Text="time:" runat="server"></asp:Literal><br />
      <asp:Literal ID="lbcommentator"    Text="PostedBy:" runat="server"></asp:Literal>  <asp:Literal ID="Literal1"   Text="says," runat="server"></asp:Literal><br />
      
                    &nbsp; &nbsp;&nbsp;    <asp:Literal ID="lbcomment_text"    Text="" runat="server"></asp:Literal><br /> 
      <asp:Button  ID="btnrate" runat="server" Text="click here to support this comment " />
        
    </ItemTemplate>
    <SeparatorTemplate>
    
    <hr />
    </SeparatorTemplate>
    
    
    
    </asp:Repeater>
</asp:Content>

