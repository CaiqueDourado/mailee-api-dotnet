using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contacts_Edit : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            populateData();
        }
    }

    protected void btSave_Click(object sender, EventArgs e)
    {
        //Get ID
        int listId = Mailee.Util.parseInt(hddId.Value);

        //Save
        update(listId);
    }

    #endregion

    #region Methods

    private void populateData()
    {
        try {

            //Get URL Parameter
            int id = Mailee.Util.parseInt(Request.QueryString["id"]);

            //Get contact by ID
            Mailee.Contact findContact = Mailee.Contact.findById(id);

            if (findContact != null)
            {
                if (findContact.Id != 0)
                {
                    //Fill Controls
                    hddId.Value = findContact.Id.ToString();
                    txtEmail.Text = findContact.Email;
                    txtName.Text = findContact.Name;
                    txtInternalId.Text = findContact.InternalId.ToString();
                    txtCompany.Text = findContact.Company;
                    txtPosition.Text = findContact.Position;
                    txtSex.Text = findContact.Sex;
                    txtBirthday.Text = findContact.Birthday.ToString();
                    txtAge.Text = findContact.Age.ToString();
                    txtPhone.Text = findContact.Phone;
                    txtMobile.Text = findContact.Mobile;
                    txtAddress.Text = findContact.Address;
                    txtNotes.Text = findContact.Notes;
                }
                else
                {
                    Response.Write("Contact not found");
                }
            }
            else
            {
                Response.Write("An error occurred while returning the contact");
            }

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

    private void update(int id)
    {
        try {

            //Fill Contact
            Mailee.Contact contact = new Mailee.Contact();
            contact.Id = id;
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