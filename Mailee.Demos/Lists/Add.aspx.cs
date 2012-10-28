using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lists_Add : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {

    }

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
            //Create List
            Mailee.List list = new Mailee.List();
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