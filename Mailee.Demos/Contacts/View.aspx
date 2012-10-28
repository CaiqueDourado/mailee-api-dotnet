<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="Contacts_View" Title="Mailee.me - Demos - Contacts" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <h1>Contacts</h1>

    <p><a href="Add.aspx">New Contact</a></p>

    <asp:GridView ID="gridContacts" runat="server" GridLines="None" CssClass="mGrid" AlternatingRowStyle-CssClass="alt">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFormatString="Edit.aspx?id={0}" DataNavigateUrlFields="Id" Text="Edit" />
            <asp:HyperLinkField DataNavigateUrlFormatString="Subscription.aspx?id={0}" DataNavigateUrlFields="Id" Text="Subscription" />
        </Columns>
    </asp:GridView>

</asp:Content>