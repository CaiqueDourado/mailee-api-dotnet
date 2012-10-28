using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Messages_Edit : System.Web.UI.Page
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

            //Get All Lists
            List<Mailee.List> findLists = Mailee.List.findAll();

            //Add empty option
            drpLists.AppendDataBoundItems = true;
            drpLists.Items.Add(new ListItem("Please select", "0"));

            //Populate Lists
            drpLists.DataSource = findLists;
            drpLists.DataBind();

            //Get All Templates
            List<Mailee.Template> findTemplates = Mailee.Template.findAll();

            //Add empty option
            drpTemplate.AppendDataBoundItems = true;
            drpTemplate.Items.Add(new ListItem("Please select", "0"));

            //Populate Lists
            drpTemplate.DataSource = findTemplates;
            drpTemplate.DataBind();

            //Get URL Parameter
            int id = Mailee.Util.parseInt(Request.QueryString["id"]);

            //Get message by ID
            Mailee.Message findMessage = Mailee.Message.findById(id);

            if (findMessage != null)
            {
                if (findMessage.Id != 0)
                {
                    //Fill Controls
                    hddId.Value = findMessage.Id.ToString();
                    txTitle.Text = findMessage.Title;
                    txtSubject.Text = findMessage.Subject;
                    txtFromName.Text = findMessage.FromName;
                    txtFromEmail.Text = findMessage.FromEmail;
                    txtReplyEmail.Text = findMessage.ReplyEmail;
                    txtHtml.Text = findMessage.Html;
                    chkAnalytics.Checked = findMessage.Analytics;
                    txtEmails.Text = findMessage.Emails;
                    txtSegment.Text = findMessage.SegmentId.ToString();

                    //Select Dropdown item
                    ListItem templateItem = drpTemplate.Items.FindByValue(findMessage.TemplateId.ToString());
                    if (templateItem != null)
                        templateItem.Selected = true;

                    //Select Dropdown item
                    ListItem listItem = drpLists.Items.FindByValue(findMessage.ListId.ToString());
                    if (listItem != null)
                        listItem.Selected = true;

                }
                else
                {
                    Response.Write("Message not found");
                }
            }
            else
            {
                Response.Write("An error occurred while returning the message");
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

            //Fill Message
            Mailee.Message message = new Mailee.Message();
            message.Id = id;
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

            //Save List
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