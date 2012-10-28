/*
 * Mailee.me API - C# Implementation
 * Caique Dourado
 * http://www.caiquedourado.com.br/
 * Date: 2011-06-21
*/

using System;
using System.Xml;
using System.Collections.Generic;
using Mailee;

namespace Mailee
{
    public class Report
    {
        #region Fields

        private string _title;
        private string _subject;
        private string _fromEmail;
        private string _fromName;
        private string _signature;
        private string _replyEmail;
        private string _date;
        private string _image;
        private int _newsletterId;
        private string _newsletterTitle;
        private int _listId;
        private int _segmentId;
        private int _templateId;
        private string _templateTitle;
        private int _resultsTotal;
        private int _resultsOpens;
        private int _resultsReturns;
        private int _resultsNotOpened;

        #endregion

        #region Properties

        /// <summary>
        /// Message Title
        /// </summary>
        public string Title
        {
            get
            {
                return (_title) ?? string.Empty;
            }
            set
            {
                _title = value;
            }
        }

        /// <summary>
        /// Message Subject
        /// </summary>
        public string Subject
        {
            get
            {
                return (_subject) ?? string.Empty;
            }
            set
            {
                _subject = value;
            }
        }

        /// <summary>
        /// Message Email From
        /// </summary>
        public string FromEmail
        {
            get
            {
                return (_fromEmail) ?? string.Empty;
            }
            set
            {
                _fromEmail = value;
            }
        }

        /// <summary>
        /// Message Name From
        /// </summary>
        public string FromName
        {
            get
            {
                return (_fromName) ?? string.Empty;
            }
            set
            {
                _fromName = value;
            }
        }

        /// <summary>
        /// List Id
        /// </summary>
        public int ListId
        {
            get
            {
                return _listId;
            }
            set
            {
                _listId = value;
            }
        }

        /// <summary>
        /// Newsletter Id
        /// </summary>
        public int NewsletterId
        {
            get
            {
                return _newsletterId;
            }
            set
            {
                _newsletterId = value;
            }
        }

        /// <summary>
        /// Reply Email
        /// </summary>
        public string ReplyEmail
        {
            get
            {
                return (_replyEmail) ?? string.Empty;
            }
            set
            {
                _replyEmail = value;
            }
        }

        /// <summary>
        /// Segment Id
        /// </summary>
        public int SegmentId
        {
            get
            {
                return _segmentId;
            }
            set
            {
                _segmentId = value;
            }
        }

        /// <summary>
        /// Template Id
        /// </summary>
        public int TemplateId
        {
            get
            {
                return _templateId;
            }
            set
            {
                _templateId = value;
            }
        }

        /// <summary>
        /// Signature
        /// </summary>
        public string Signature
        {
            get
            {
                return (_signature) ?? string.Empty;
            }
            set
            {
                _signature = value;
            }
        }

        /// <summary>
        /// Image
        /// </summary>
        public string Image
        {
            get
            {
                return (_image) ?? string.Empty;
            }
            set
            {
                _image = value;
            }
        }

        /// <summary>
        /// Newsletter Title
        /// </summary>
        public string NewsletterTitle
        {
            get
            {
                return (_newsletterTitle) ?? string.Empty;
            }
            set
            {
                _newsletterTitle = value;
            }
        }

        /// <summary>
        /// Template Title
        /// </summary>
        public string TemplateTitle
        {
            get
            {
                return (_templateTitle) ?? string.Empty;
            }
            set
            {
                _templateTitle = value;
            }
        }

        /// <summary>
        /// Date
        /// </summary>
        public string Date
        {
            get
            {
                return (_date) ?? string.Empty;
            }
            set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Results Total
        /// </summary>
        public int ResultsTotal
        {
            get
            {
                return _resultsTotal;
            }
            set
            {
                _resultsTotal = value;
            }
        }

        /// <summary>
        /// Results Opens
        /// </summary>
        public int ResultsOpens
        {
            get
            {
                return _resultsOpens;
            }
            set
            {
                _resultsOpens = value;
            }
        }

        /// <summary>
        /// Results Returns
        /// </summary>
        public int ResultsReturns
        {
            get
            {
                return _resultsReturns;
            }
            set
            {
                _resultsReturns = value;
            }
        }

        /// <summary>
        /// Results Not Opened
        /// </summary>
        public int ResultsNotOpened
        {
            get
            {
                return _resultsNotOpened;
            }
            set
            {
                _resultsNotOpened = value;
            }
        }
        
        #endregion

        #region Methods

        #region Find Report by Message

        /// <summary>
        /// Find Report by Message
        /// </summary>
        /// <param name="messageId">Message Id</param>
        public static Mailee.Report findByMessage(int messageId)
        {
            Mailee.Report report = new Mailee.Report();

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/reports/X.xml)
            string url = string.Format("{0}reports/{1}.xml", Mailee.Config.UrlAPI, messageId);

            //Get data
            string htmlReponse = Mailee.Rest.get(url);

            //Create XML
            XmlDocument xmlDoc = new XmlDocument();

            //Load XML
            xmlDoc.LoadXml(htmlReponse);

            //Get Message
            XmlNodeList xmlMessage = xmlDoc.GetElementsByTagName("message");

            if (xmlMessage.Count > 0)
            {
                XmlNode xmlReport = xmlMessage[0];

                //Set properties
                report.Title = xmlReport.ChildNodes[0].InnerText;
                report.Subject = xmlReport.ChildNodes[1].InnerText;
                report.FromName = xmlReport.ChildNodes[2].InnerText;
                report.FromEmail = xmlReport.ChildNodes[3].InnerText;
                report.Signature = xmlReport.ChildNodes[4].InnerText;
                report.ReplyEmail = xmlReport.ChildNodes[5].InnerText;
                report.Date = xmlReport.ChildNodes[6].InnerText;
                report.Image = xmlReport.ChildNodes[7].InnerText;
                report.NewsletterId = Mailee.Util.parseInt(xmlReport.ChildNodes[8].InnerText);
                report.NewsletterTitle = xmlReport.ChildNodes[9].InnerText;
                report.ListId = Mailee.Util.parseInt(xmlReport.ChildNodes[10].InnerText);
                report.SegmentId = Mailee.Util.parseInt(xmlReport.ChildNodes[11].InnerText);
                report.TemplateId = Mailee.Util.parseInt(xmlReport.ChildNodes[12].InnerText);
                report.TemplateTitle = xmlReport.ChildNodes[13].InnerText;
            }

            //Get Results
            XmlNodeList xmlResults = xmlDoc.GetElementsByTagName("results");

            if (xmlResults.Count > 0)
            {
                XmlNode xmlResult = xmlResults[0];

                //Set properties
                report.ResultsTotal = Mailee.Util.parseInt(xmlResult.ChildNodes[0].InnerText);
                report.ResultsOpens = Mailee.Util.parseInt(xmlResult.ChildNodes[1].InnerText);
                report.ResultsReturns = Mailee.Util.parseInt(xmlResult.ChildNodes[2].InnerText);
                report.ResultsNotOpened = Mailee.Util.parseInt(xmlResult.ChildNodes[3].InnerText);
            }

            return report;
        }

        #endregion

        #endregion
    }
}