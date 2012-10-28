using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Templates_Add : System.Web.UI.Page
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
            //Create Template
            Mailee.Template template = new Mailee.Template();
            template.Title = txtTitle.Text;
            template.Html = txtHtml.Text;

            //Save Template
            template.save();

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