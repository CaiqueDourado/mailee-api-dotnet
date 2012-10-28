using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Messages_Add : System.Web.UI.Page
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
        //Save
        add();
    }

    #endregion

    #region Methods

    private void populateData()
    {
        //Get All Lists
        List<Mailee.List> findLists = Mailee.List.findAll();

        //Add empty option
        drpLists.AppendDataBoundItems = true;
        drpLists.Items.Add(new ListItem("Please select", "0", true));

        //Populate Lists
        drpLists.DataSource = findLists;
        drpLists.DataBind();


        //Get All Templates
        List<Mailee.Template> findTemplates = Mailee.Template.findAll();

        //Add empty option
        drpTemplate.AppendDataBoundItems = true;
        drpTemplate.Items.Add(new ListItem("Please select", "0", true));

        //Populate Lists
        drpTemplate.DataSource = findTemplates;
        drpTemplate.DataBind();
        
    }

    private void add()
    {
        try
        {
            //Create Message
            Mailee.Message message = new Mailee.Message();
            message.Title = txTitle.Text;
            message.Subject = txtSubject.Text;
            message.FromName = txtFromName.Text;
            message.FromEmail = txtFromEmail.Text;
            message.ReplyEmail = txtReplyEmail.Text;
            message.Html = txtHtml.Text;
            message.TemplateId = Mailee.Util.parseInt(drpTemplate.SelectedValue);
            message.Analytics = chkAnalytics.Checked;
            message.Emails = txtEmails.Text;
            message.ListId = Mailee.Util.parseInt(drpLists.SelectedValue);
            message.SegmentId = Mailee.Util.parseInt(txtSegment.Text);

            //Save Message
            message.save();

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