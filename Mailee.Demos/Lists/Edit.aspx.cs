using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lists_Edit : System.Web.UI.Page
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

            //Get list by ID
            Mailee.List findList = Mailee.List.findById(id);

            if (findList != null)
            {
                if (findList.Id != 0)
                {
                    //Fill Controls
                    hddId.Value = findList.Id.ToString();
                    txtName.Text = findList.Name;
                    txtAddress.Text = findList.Address;
                    chkActive.Checked = findList.Active;
                    txtCompany.Text = findList.Company;
                    txtDescription.Text = findList.Description;
                    txtPhone.Text = findList.Phone;
                    txtSite.Text = findList.Site;
                    txtFacebook.Text = findList.Facebook;
                    txtTwitter.Text = findList.Twitter;
                }
                else
                {
                    Response.Write("List not found");
                }
            }
            else
            {
                Response.Write("An error occurred while returning the list");
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

            //Fill List
            Mailee.List list = new Mailee.List();
            list.Id = id;
            list.Name = txtName.Text;
            list.Description = txtDescription.Text;
            list.Company = txtCompany.Text;
            list.Address = txtAddress.Text;
            list.Phone = txtPhone.Text;
            list.Site = txtSite.Text;
            list.Facebook = txtFacebook.Text;
            list.Twitter = txtTwitter.Text;
            list.Active = chkActive.Checked;

            //Save List
            list.save();

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