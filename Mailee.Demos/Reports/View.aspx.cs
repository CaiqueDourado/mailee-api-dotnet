using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Messages_View : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            populateData();
        }
    }

    protected void drpMessage_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Message ID
        int messageId = Mailee.Util.parseInt(drpMessage.SelectedValue);

        //Show Report
        showReport(messageId);
    }

    #endregion

    #region Methods

    private void populateData()
    {
        //Get All Messages
        List<Mailee.Message> findMessages = Mailee.Message.findAll();

        //Add empty option
        drpMessage.AppendDataBoundItems = true;
        drpMessage.Items.Add(new ListItem("Please select", "0", true));

        //Populate Messages
        drpMessage.DataSource = findMessages;
        drpMessage.DataBind();
    }

    private void showReport(int messageId)
    {
        try
        {
            //Show result
            pnlResult.Visible = true;

            //Get Report
            Mailee.Report findReport = Mailee.Report.findByMessage(messageId);

            if (findReport != null)
            {
                //Fill Controls
                lblTitle.InnerText = findReport.Title;
                lblSubject.InnerText = findReport.Subject;
                lblFromName.InnerText = findReport.FromName;
                lblFromEmail.InnerText = findReport.FromEmail;
                lblSignature.InnerText = findReport.Signature;
                lblReplyEmail.InnerText = findReport.ReplyEmail;
                lblDate.InnerText = findReport.Date;
                lblImage.InnerText = findReport.Image;
                lblNewsletterId.InnerText = findReport.NewsletterId.ToString();
                lblNewsletterTitle.InnerText = findReport.NewsletterTitle;
                lblListId.InnerText = findReport.ListId.ToString();
                lblSegmentId.InnerText = findReport.SegmentId.ToString();
                lblTemplateId.InnerText = findReport.TemplateId.ToString();
                lblTemplateTitle.InnerText = findReport.TemplateTitle;
                lblResultsTotal.InnerText = findReport.ResultsTotal.ToString();
                lblResultsOpens.InnerText = findReport.ResultsOpens.ToString();
                lblResultsReturns.InnerText = findReport.ResultsReturns.ToString();
                lblResultsNotOpened.InnerText = findReport.ResultsNotOpened.ToString();
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