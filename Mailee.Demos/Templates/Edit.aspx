<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Templates_Edit" Title="Mailee.me - Demos - Edit Template" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">

    <h1>Edit Template</h1>
    
        <div class="form">

        <asp:HiddenField ID="hddId" runat="server" />

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
