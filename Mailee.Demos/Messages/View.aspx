<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="Messages_View" Title="Mailee.me - Demos - Messages" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <h1>Messages</h1>

    <p><a href="Add.aspx">New Message</a></p>

    <asp:GridView ID="gridMessages" runat="server" GridLines="None" CssClass="mGrid" AlternatingRowStyle-CssClass="alt">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFormatString="Edit.aspx?id={0}" DataNavigateUrlFields="Id" Text="Edit" />
        </Columns>
    </asp:GridView>

</asp:Content>