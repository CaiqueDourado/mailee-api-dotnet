using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contacts_Add : System.Web.UI.Page
{
    #region Events

    protected void btSave_Click(object sender, EventArgs e)
    {
        //Save
        add();
    }

    #endregion

    #region Methods

    private void add()
    {
        try
        {
            //Create Contact
            Mailee.Contact contact = new Mailee.Contact();
            contact.Email = txtEmail.Text;
            contact.Name = txtName.Text;
            contact.InternalId = Mailee.Util.parseInt(txtInternalId.Text);
            contact.Company = txtCompany.Text;
            contact.Position = txtPosition.Text;
            contact.Sex = txtSex.Text;
            contact.Birthday = Mailee.Util.parseDateTime(txtBirthday.Text);
            contact.Age = Mailee.Util.parseInt(txtAge.Text);
            contact.Phone = txtPhone.Text;
            contact.Mobile = txtMobile.Text;
            contact.Address = txtAddress.Text;
            contact.Notes = txtNotes.Text;

            //Save Contact
            contact.save();

            //Redirect
            Response.Redirect("View.aspx");

        }
        catch (Mailee.RestExcepction ex)
        {
            //Show http status
            Response.Write(string.Format("statusCode =  {0} <br /> statusDescription = {1}", ex.StatusCode, ex.StatusDesciption));

            //Show error messages
            foreach (string error in ex.ErrorMessages)
                Response.Write("<br />" + error);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    #endregion
}