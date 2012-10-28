<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Subscription.aspx.cs" Inherits="Contacts_Subscription" Title="Mailee.me - Demos - Contact Subscription" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">

    <h1>Contact Subscription</h1>
    
        <div class="form">

        <p>
            <label>Email</label>
            <asp:TextBox ID="txtEmail" runat="server" Enabled="false" ></asp:TextBox>
        </p>

        <p>
            <label>List</label>
            <asp:DropDownList ID="drpLists" runat="server" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
        </p>

        <div class="butttons">

            <asp:Button ID="btSubscribeToList" runat="server" Text="Subscribe to this list" onclick="btSubscribeToList_Click" />
            <asp:Button ID="btUnsubscribeToList" runat="server" Text="Unsubscribe to this list" onclick="btUnsubscribeToList_Click" />
            <asp:Button ID="btUnsubscribeContact" runat="server" Text="Unsubscribe Contact" onclick="btUnsubscribeContact_Click" />
            <a href="View.aspx">Cancel</a>

        </div>

    </div>

</asp:Content>
