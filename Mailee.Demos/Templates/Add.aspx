<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Templates_Add" Title="Mailee.me - Demos - Add Template" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <div class="form">

        <h1>New Template</h1>
    
        <p>
            <label>Title</label>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>HTML</label>
            <asp:TextBox ID="txtHtml" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>

        <div class="butttons">
            <asp:Button ID="btSave" runat="server" Text="Save" onclick="btSave_Click" />
            <a href="View.aspx">Cancel</a>
        </div>

    </div>

</asp:Content>