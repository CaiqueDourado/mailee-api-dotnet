<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Lists_Edit" Title="Mailee.me - Demos - Edit List" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">

    <h1>Edit List</h1>
    
        <div class="form">

        <asp:HiddenField ID="hddId" runat="server" />

        <p>
            <label>Name</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Description</label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Company</label>
            <asp:TextBox ID="txtCompany" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Address</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Phone</label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Site</label>
            <asp:TextBox ID="txtSite" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Facebook</label>
            <asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Twitter</label>
            <asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Active</label>
            <asp:CheckBox ID="chkActive" runat="server" Text="" />
        </p>

        <div class="butttons">

            <asp:Button ID="btSave" runat="server" Text="Save" onclick="btSave_Click" />
            <a href="View.aspx">Cancel</a>

        </div>

    </div>

</asp:Content>
