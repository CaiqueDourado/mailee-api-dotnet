<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Contacts_Edit" Title="Mailee.me - Demos - Edit Contact" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">

    <h1>Edit Contact</h1>
    
        <div class="form">

        <asp:HiddenField ID="hddId" runat="server" />
        
        <p>
            <label>Email</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Name</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Internal Id</label>
            <asp:TextBox ID="txtInternalId" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Company</label>
            <asp:TextBox ID="txtCompany" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Position</label>
            <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Sex</label>
            <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Birthday</label>
            <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Age</label>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Phone</label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Mobile</label>
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Address</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>

        <p>
            <label>Notes</label>
            <asp:TextBox ID="txtNotes" runat="server"></asp:TextBox>
        </p>

        <div class="butttons">

            <asp:Button ID="btSave" runat="server" Text="Save" onclick="btSave_Click" />
            <a href="View.aspx">Cancel</a>

        </div>

    </div>

</asp:Content>
