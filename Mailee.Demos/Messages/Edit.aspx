<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Messages_Edit" Title="Mailee.me - Demos - Edit Message" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">

    <h1>Edit List</h1>
    
        <div class="form">

        <asp:HiddenField ID="hddId" runat="server" />

        <p>
            <label>Title</label>
            <asp:TextBox ID="txTitle" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Subject</label>
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>FromName</label>
            <asp:TextBox ID="txtFromName" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>FromEmail</label>
            <asp:TextBox ID="txtFromEmail" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>ReplyEmail</label>
            <asp:TextBox ID="txtReplyEmail" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Html</label>
            <asp:TextBox ID="txtHtml" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>

        <p>
            <label>Template</label>
            <asp:DropDownList ID="drpTemplate" runat="server" DataTextField="Title" DataValueField="Id"></asp:DropDownList>
        </p>

        <p>
            <label>Analytics</label>
            <asp:CheckBox ID="chkAnalytics" runat="server" Text="" />
        </p>

        <p>
            <label>Emails</label>
            <asp:TextBox ID="txtEmails" runat="server" TextMode="MultiLine" CssClass="pequeno"></asp:TextBox>
        </p>

        <p>
            <label>List</label>
            <asp:DropDownList ID="drpLists" runat="server" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
        </p>

        <p>
            <label>Segment</label>
            <asp:TextBox ID="txtSegment" runat="server"></asp:TextBox>
        </p>

        <div class="butttons">

            <asp:Button ID="btSave" runat="server" Text="Save" onclick="btSave_Click" />
            <a href="View.aspx">Cancel</a>

        </div>

    </div>

</asp:Content>
