<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="Templates_View" Title="Mailee.me - Demos - Templates" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <h1>Templates</h1>

    <p><a href="Add.aspx">New Template</a></p>

    <asp:GridView ID="gridTemplates" runat="server" GridLines="None" CssClass="mGrid" AlternatingRowStyle-CssClass="alt">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFormatString="Edit.aspx?id={0}" DataNavigateUrlFields="Id" Text="Edit" />
        </Columns>
    </asp:GridView>

</asp:Content>