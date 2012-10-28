using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contacts_View : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            populateData();
        }
    }

    #endregion

    #region Methods

    private void populateData()
    {
        try
        {
            //Get All Contacts
            List<Mailee.Contact> findContacts = Mailee.Contact.findAll(1);

            //Populate Data
            gridContacts.DataSource = findContacts;
            gridContacts.DataBind();
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