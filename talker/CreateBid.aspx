<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CreateBid.aspx.cs" Inherits="talker.CreateBid" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <section>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <asp:Label ID="Label2" runat="server" Text="At how much do you want to sell?"></asp:Label>
                    
            <asp:TextBox ID="TextBox1" runat="server" Height="17px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Advertize" OnClick="Advertize_Click" />
                <asp:Label ID="Label1" runat="server" Text="What do you want to talk about?"></asp:Label>
                <asp:DropDownList ID="CategoriesDropDown" runat="server"></asp:DropDownList>
        </section>
    
</asp:Content>