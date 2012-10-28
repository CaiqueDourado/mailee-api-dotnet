<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="Messages_View" Title="Mailee.me - Demos - Reports" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <h1>Reports</h1>

    <div class="form">

        <p>
            <label>Message</label>
            <asp:DropDownList ID="drpMessage" runat="server" DataTextField="Title" DataValueField="Id" AutoPostBack="True" onselectedindexchanged="drpMessage_SelectedIndexChanged"></asp:DropDownList>
        </p>

        <br />

        <asp:Panel ID="pnlResult" runat="server" Visible="false">

            <p>
                <strong>Title</strong>
                <label id="lblTitle" runat="server"></label>
            </p>

            <p>
                <strong>Subject</strong>
                <label id="lblSubject" runat="server"></label>
            </p>

             <p>
                <strong>From Name</strong>
                <label id="lblFromName" runat="server"></label>
            </p>

            <p>
                <strong>From Email</strong>
                <label id="lblFromEmail" runat="server"></label>
            </p>

            <p>
                <strong>Signature</strong>
                <label id="lblSignature" runat="server"></label>
            </p>

            <p>
                <strong>Reply Email</strong>
                <label id="lblReplyEmail" runat="server"></label>
            </p>

            <p>
                <strong>Date</strong>
                <label id="lblDate" runat="server"></label>
            </p>

            <p>
                <strong>Image</strong>
                <label id="lblImage" runat="server"></label>
            </p>

            <p>
                <strong>Newsletter Id</strong>
                <label id="lblNewsletterId" runat="server"></label>
            </p>

            <p>
                <strong>Newsletter Title</strong>
                <label id="lblNewsletterTitle" runat="server"></label>
            </p>

            <p>
                <strong>Lis tId</strong>
                <label id="lblListId" runat="server"></label>
            </p>

            <p>
                <strong>Segment Id</strong>
                <label id="lblSegmentId" runat="server"></label>
            </p>

            <p>
                <strong></strong>
                <label id="Label10" runat="server"></label>
            </p>

            <p>
                <strong>Template Id</strong>
                <label id="lblTemplateId" runat="server"></label>
            </p>

            <p>
                <strong>Template Title</strong>
                <label id="lblTemplateTitle" runat="server"></label>
            </p>

            <p>
                <strong>Results Total</strong>
                <label id="lblResultsTotal" runat="server"></label>
            </p>

            <p>
                <strong>Results Opens</strong>
                <label id="lblResultsOpens" runat="server"></label>
            </p>

            <p>
                <strong>Results Returns</strong>
                <label id="lblResultsReturns" runat="server"></label>
            </p>

            <p>
                <strong>Results Not Opened</strong>
                <label id="lblResultsNotOpened" runat="server"></label>
            </p>
    
        </asp:Panel>

    </div>

</asp:Content>