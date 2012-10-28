<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="Lists_View" Title="Mailee.me - Demos - Lists" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <h1>Lists</h1>

    <p><a href="Add.aspx">New List</a></p>

    <asp:GridView ID="gridLists" runat="server" GridLines="None" CssClass="mGrid" AlternatingRowStyle-CssClass="alt">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFormatString="Edit.aspx?id={0}" DataNavigateUrlFields="Id" Text="Edit" />
        </Columns>
    </asp:GridView>

</asp:Content>