<%@ Page Title="Place Bid" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="PlaceBid.aspx.cs" Inherits="talker.PlaceBid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" 
        ItemType="talker.Models.LiveBid" SelectMethod ="GetLiveBid" 
        RenderOuterTable="false" OnPageIndexChanging="productDetail_PageIndexChanging">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProvidingUserName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align:left;">
                        <span><b>Minimum Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.DesiredBidPrice) %></span><br /><span></span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="CreateBid" runat="server" Text="Buy their time" OnClick ="PlaceBid_Click"/>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>