using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contacts_Subscription : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            populateData();
        }
    }

    protected void btSubscribeToList_Click(object sender, EventArgs e)
    {
        //Contact ID
        int contactId = Mailee.Util.parseInt(Request.QueryString["id"]);

        //List ID
        int listId = Mailee.Util.parseInt(drpLists.SelectedValue);

        //Subscribe
        try
        {
            //Fill Contact
            Mailee.Contact contact = new Mailee.Contact(contactId);

            //Subscribe contact to List
            contact.Subscribe(listId);

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

    protected void btUnsubscribeToList_Click(object sender, EventArgs e)
    {
        ///Contact ID
        int contactId = Mailee.Util.parseInt(Request.QueryString["id"]);

        //List ID
        int listId = Mailee.Util.parseInt(drpLists.SelectedValue);

        //Unsubscribe
        try
        {
            //Fill Contact
            Mailee.Contact contact = new Mailee.Contact(contactId);

            //Unsubscribe contact to List
            contact.Unsubscribe(listId);

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

    protected void btUnsubscribeContact_Click(object sender, EventArgs e)
    {
        ///Contact ID
        int contactId = Mailee.Util.parseInt(Request.QueryString["id"]);

        //Unsubscribe
        try
        {
            //Fill Contact
            Mailee.Contact contact = new Mailee.Contact(contactId);

            //Unsubscribe contact
            contact.Unsubscribe();

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

    #region Methods

    private void populateData()
    {
       
        try {

        //Get All Lists
        List<Mailee.List> findLists = Mailee.List.findAll();

        //Populate Lists
        drpLists.DataSource = findLists;
        drpLists.DataBind();

        //Get URL Parameter
        int id = Mailee.Util.parseInt(Request.QueryString["id"]);

        //Get contact by ID
        Mailee.Contact findContact = Mailee.Contact.findById(id);

            if (findContact != null)
            {
                if (findContact.Id != 0)
                {
                    //Fill Controls
                    txtEmail.Text = findContact.Email;
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

    #endregion
}