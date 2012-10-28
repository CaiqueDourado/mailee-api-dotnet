using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Templates_Edit : System.Web.UI.Page
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
        int templateId = Mailee.Util.parseInt(hddId.Value);

        //Save
        update(templateId);
    }

    #endregion

    #region Methods

    private void populateData()
    {
        try {

            //Get URL Parameter
            int id = Mailee.Util.parseInt(Request.QueryString["id"]);

            //Get template by ID
            Mailee.Template findTemplate = Mailee.Template.findById(id);

            if (findTemplate != null)
            {
                if (findTemplate.Id != 0)
                {
                    //Fill Controls
                    hddId.Value = findTemplate.Id.ToString();
                    txtTitle.Text = findTemplate.Title;
                    txtHtml.Text = findTemplate.Html;
                }
                else
                {
                    Response.Write("Template not found");
                }
            }
            else
            {
                Response.Write("An error occurred while returning the template");
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

            //Fill Template
            Mailee.Template template = new Mailee.Template();
            template.Id = id;
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