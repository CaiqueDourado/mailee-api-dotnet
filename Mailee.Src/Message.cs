/*
 * Mailee.me API - C# Implementation
 * Caique Dourado
 * http://www.caiquedourado.com.br/
 * Date: 2011-06-15
*/

using System;
using System.Xml;
using System.Collections.Generic;
using Mailee;

namespace Mailee
{
    public class Message
    {
        #region Fields

        private int _id;
        private string _title;
        private string _subject;
        private bool _analytics;
        private bool _checkd;
        private int _clientId;
        private int _contentFrom;
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private string _fromEmail;
        private string _fromName;
        private int _listId;
        private string _log;
        private int _newsletterId;
        private string _replyEmail;
        private string _rss;
        private int _segmentId;
        private DateTime? _sendAfter;
        private string _sendWhen;
        private int _status;
        private int _templateId;
        private string _text;
        private int _total;
        private string _html;
        private string _htmlFromUrl;
        private List<KeyValuePair<int, string>> _edit;
        private List<KeyValuePair<int, string>> _repeats;
        private string _emails;
        private string _thumbContentType;
        private string _thumbFileName;
        private int _thumbFileSize;
        private DateTime? _thumbUpdatedAt;
        private string _url;

        #endregion

        #region Properties

        /// <summary>
        /// Message Id
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

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
        /// Use Google Analytics?
        /// </summary>
        public bool Analytics
        {
            get
            {
                return _analytics;
            }
            set
            {
                _analytics = value;
            }
        }

        /// <summary>
        /// Checkd
        /// </summary>
        public bool Checkd
        {
            get
            {
                return _checkd;
            }
            set
            {
                _checkd = value;
            }
        }

        /// <summary>
        /// Your ID in Mailee.me
        /// </summary>
        public int ClientId
        {
            get
            {
                return _clientId;
            }
            set
            {
                _clientId = value;
            }
        }

        /// <summary>
        /// Content From
        /// </summary>
        public int ContentFrom
        {
            get
            {
                return _contentFrom;
            }
            set
            {
                _contentFrom = value;
            }
        }
        
        /// <summary>
        /// Created At
        /// </summary>
        public DateTime? CreatedAt
        {
            get
            {
                return _createdAt;
            }
            set
            {
                _createdAt = value;
            }
        }

        /// <summary>
        /// Deleted At
        /// </summary>
        public DateTime? DeletedAt
        {
            get
            {
                return _deletedAt;
            }
            set
            {
                _deletedAt = value;
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
        /// Message Log
        /// </summary>
        public string Log
        {
            get
            {
                return (_log) ?? string.Empty;
            }
            set
            {
                _log = value;
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
        /// RSS
        /// </summary>
        public string RSS
        {
            get
            {
                return (_rss) ?? string.Empty;
            }
            set
            {
                _rss = value;
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
        /// Send After
        /// </summary>
        public DateTime? SendAfter
        {
            get
            {
                return _sendAfter;
            }
            set
            {
                _sendAfter = value;
            }
        }
      
        /// <summary>
        /// Send When
        /// </summary>
        public string SendWhen
        {
            get
            {
                return (_sendWhen) ?? string.Empty;
            }
            set
            {
                _sendWhen = value;
            }
        }
        
        /// <summary>
        /// Status
        /// </summary>
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
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
        /// Text
        /// </summary>
        public string Text
        {
            get
            {
                return (_text) ?? string.Empty;
            }
            set
            {
                _text = value;
            }
        }

        /// <summary>
        /// Total
        /// </summary>
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

        /// <summary>
        /// Message Html
        /// </summary>
        public string Html
        {
            get
            {
                return (_html) ?? string.Empty;
            }
            set
            {
                _html = value;
            }
        }

        /// <summary>
        /// Html From Url
        /// </summary>
        public string HtmlFromUrl
        {
            get
            {
                return (_htmlFromUrl) ?? string.Empty;
            }
            set
            {
                _htmlFromUrl = value;
            }
        }

        /// <summary>
        /// Content to be placed in an editable region of the message
        /// </summary>
        public List<KeyValuePair<int, string>> Edit
        {
            get
            {
                if (_edit == null)
                    _edit = new List<KeyValuePair<int, string>>();

                return _edit;
            }
            set
            {
                _edit = value;
            }
        }

        /// <summary>
        /// Content to be added in an iteration of the message
        /// </summary>
        public List<KeyValuePair<int, string>> Repeats
        {
            get
            {
                if (_repeats == null)
                    _repeats = new List<KeyValuePair<int, string>>();

                return _repeats;
            }
            set
            {
                _repeats = value;
            }
        }

        /// <summary>
        /// Mailing list for the message
        /// </summary>
        public string Emails
        {
            get
            {
                return (_emails) ?? string.Empty;
            }
            set
            {
                _emails = value;
            }
        }

        /// <summary>
        /// Thumbnail Content Type
        /// </summary>
        public string ThumbContentType
        {
            get
            {
                return (_thumbContentType) ?? string.Empty;
            }
            set
            {
                _thumbContentType = value;
            }
        }

        /// <summary>
        /// Thumbnail File Name
        /// </summary>
        public string ThumbFileName
        {
            get
            {
                return (_thumbFileName) ?? string.Empty;
            }
            set
            {
                _thumbFileName = value;
            }
        }

        /// <summary>
        /// Thumbnail File Size
        /// </summary>
        public int ThumbFileSize
        {
            get
            {
                return _thumbFileSize;
            }
            set
            {
                _thumbFileSize = value;
            }
        }

        /// <summary>
        /// Thumbnail Updated At
        /// </summary>
        public DateTime? ThumbUpdatedAt
        {
            get
            {
                return _thumbUpdatedAt;
            }
            set
            {
                _thumbUpdatedAt = value;
            }
        }

        /// <summary>
        /// Url
        /// </summary>
        public string Url
        {
            get
            {
                return (_url) ?? string.Empty;
            }
            set
            {
                _url = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Message
        /// </summary>
        public Message() { }

        /// <summary>
        /// New Message
        /// </summary>
        /// <param name="title">Message Title</param>
        /// <param name="subject">Message Subject</param>
        /// <param name="fromName">Message Name From</param>
        /// <param name="fromEmail">Message Email From</param>
        /// <param name="analytics">Use Analytics?</param>
        /// <param name="listId">List Id</param>
        /// <param name="templateId">Template Id</param>
        public Message(string title, string subject, string fromName, string fromEmail, string replyEmail, string html, int templateId, List<KeyValuePair<int, string>> edit, List<KeyValuePair<int, string>> repeats, bool analytics, string emails, int listId)
        {
            this.Title = title;
            this.Subject = subject; 
            this.FromName = fromName;
            this.FromEmail = fromEmail;
            this.ReplyEmail = replyEmail;
            this.Html = html;
            this.TemplateId = templateId;
            this.Edit = edit;
            this.Repeats = repeats;
            this.Analytics = analytics;
            this.Emails = emails;
            this.ListId = listId;
            this.SegmentId = listId;
        }

        #endregion

        #region Methods

        #region Find Messages

        /// <summary>
        /// Find all Messages
        /// </summary>
        public static List<Mailee.Message> findAll()
        {
            List<Mailee.Message> messages = new List<Mailee.Message>();

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/messages)
            string url = string.Concat(Mailee.Config.UrlAPI, "messages.xml");

            //Get data
            string htmlReponse = Mailee.Rest.get(url);
                
            //Create XML
            XmlDocument xmlDoc = new XmlDocument();

            //Load XML
            xmlDoc.LoadXml(htmlReponse);

            //Get Messagess
            XmlNodeList xmlMessages = xmlDoc.GetElementsByTagName("message");

            //Each Messages
            foreach (XmlNode xmlMessage in xmlMessages)
            {
                //Create new Message
                Mailee.Message newMessage = new Mailee.Message();

                //Set properties
                newMessage.Analytics = Mailee.Util.parseBool(xmlMessage.ChildNodes[0].InnerText);
                newMessage.CreatedAt = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[1].InnerText);
                newMessage.DeletedAt = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[2].InnerText);
                newMessage.FromEmail = xmlMessage.ChildNodes[3].InnerText;
                newMessage.FromName = xmlMessage.ChildNodes[4].InnerText;
                newMessage.Id = Mailee.Util.parseInt(xmlMessage.ChildNodes[5].InnerText);
                //newMessage.ListId = Mailee.Util.parseInt(xmlMessage.ChildNodes[6].InnerText);
                newMessage.Log = xmlMessage.ChildNodes[6].InnerText;
                newMessage.NewsletterId = Mailee.Util.parseInt(xmlMessage.ChildNodes[7].InnerText);
                newMessage.ReplyEmail = xmlMessage.ChildNodes[8].InnerText;
                newMessage.SegmentId = Mailee.Util.parseInt(xmlMessage.ChildNodes[9].InnerText);
                newMessage.SendAfter = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[10].InnerText);
                newMessage.SendWhen = xmlMessage.ChildNodes[11].InnerText;
                newMessage.Status = Mailee.Util.parseInt(xmlMessage.ChildNodes[12].InnerText);
                newMessage.Subject = xmlMessage.ChildNodes[13].InnerText;
                newMessage.TemplateId = Mailee.Util.parseInt(xmlMessage.ChildNodes[14].InnerText);
                newMessage.Title = xmlMessage.ChildNodes[15].InnerText;
                newMessage.Total = Mailee.Util.parseInt(xmlMessage.ChildNodes[16].InnerText);
               
                //Add Message
                messages.Add(newMessage);
            }

            return messages;
        }

        #endregion

        #region Find by ID

        /// <summary>
        /// Find Message by ID
        /// </summary>
        /// <param name="id">Message ID</param>
        public static Mailee.Message findById(int id)
        {
            Mailee.Message message = new Mailee.Message();

            //Validation
            if (id == 0)
                return message;

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/messages/X.xml)
            string url = string.Format("{0}messages/{1}.xml", Mailee.Config.UrlAPI, id);
           
            //Get data
            string htmlReponse = Mailee.Rest.get(url);

            //Checks if the xml is valid
            bool isValidXml = Mailee.Util.IsValidXML(htmlReponse);

            if (isValidXml == true)
            {
                //Create XML
                XmlDocument xmlDoc = new XmlDocument();

                //Load XML
                xmlDoc.LoadXml(htmlReponse);

                //Get Message
                XmlNodeList xmlMessages = xmlDoc.GetElementsByTagName("message");

                if (xmlMessages.Count > 0)
                {
                    XmlNode xmlMessage = xmlMessages[0];

                    //Set properties
                    message.Analytics = Mailee.Util.parseBool(xmlMessage.ChildNodes[0].InnerText);
                    message.Checkd = Mailee.Util.parseBool(xmlMessage.ChildNodes[1].InnerText);
                    message.ClientId = Mailee.Util.parseInt(xmlMessage.ChildNodes[2].InnerText);
                    message.ContentFrom = Mailee.Util.parseInt(xmlMessage.ChildNodes[3].InnerText);
                    message.CreatedAt = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[4].InnerText);
                    message.DeletedAt = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[5].InnerText);
                    message.FromEmail = xmlMessage.ChildNodes[6].InnerText;
                    message.FromName = xmlMessage.ChildNodes[7].InnerText;
                    message.Html = xmlMessage.ChildNodes[8].InnerText;
                    message.HtmlFromUrl = xmlMessage.ChildNodes[9].InnerText;
                    message.Id = Mailee.Util.parseInt(xmlMessage.ChildNodes[10].InnerText);
                    message.ListId = Mailee.Util.parseInt(xmlMessage.ChildNodes[11].InnerText);
                    message.Log = xmlMessage.ChildNodes[12].InnerText;
                    message.NewsletterId = Mailee.Util.parseInt(xmlMessage.ChildNodes[13].InnerText);
                    message.ReplyEmail = xmlMessage.ChildNodes[14].InnerText;
                    message.RSS = xmlMessage.ChildNodes[15].InnerText;
                    message.SegmentId = Mailee.Util.parseInt(xmlMessage.ChildNodes[16].InnerText);
                    message.SendAfter = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[17].InnerText);
                    message.SendWhen = xmlMessage.ChildNodes[18].InnerText;
                    message.Status = Mailee.Util.parseInt(xmlMessage.ChildNodes[19].InnerText);
                    message.Subject = xmlMessage.ChildNodes[20].InnerText;
                    message.TemplateId = Mailee.Util.parseInt(xmlMessage.ChildNodes[21].InnerText);
                    message.Text = xmlMessage.ChildNodes[22].InnerText;
                    message.ThumbContentType = xmlMessage.ChildNodes[23].InnerText;
                    message.ThumbFileName = xmlMessage.ChildNodes[24].InnerText;
                    message.ThumbFileSize = Mailee.Util.parseInt(xmlMessage.ChildNodes[25].InnerText);
                    message.ThumbUpdatedAt = Mailee.Util.parseDateTime(xmlMessage.ChildNodes[26].InnerText);
                    message.Title = xmlMessage.ChildNodes[27].InnerText;
                    message.Total = Mailee.Util.parseInt(xmlMessage.ChildNodes[28].InnerText);
                    message.Url = xmlMessage.ChildNodes[29].InnerText;
                }

            }

            return message;
        }

        #endregion

        #region Save

        /// <summary>
        /// Create new or Update existing Message
        /// </summary>
        public string save()
        {
            if (this.Id == 0)
            {
                //Create new Message
                return Create();
            }
            else
            {
                //Update existing Message
                return update();
            }
        }

        /// <summary>
        /// Create New Message
        /// </summary>
        private string Create()
        {
            //URL (POST) (api.XXXXXXXXXXXXX.subdomain.mailee.me/messages.xml)
            string url = string.Concat(Mailee.Config.UrlAPI, "messages.xml");

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("message[title]", this.Title));
            pars.Add(new RestParameter("message[subject]", this.Subject));
            pars.Add(new RestParameter("message[from_name]", this.FromName));
            pars.Add(new RestParameter("message[from_email]", this.FromEmail));
            pars.Add(new RestParameter("message[analytics]", this.Analytics.ToString().ToLower()));

            if (this.ReplyEmail != string.Empty)
                pars.Add(new RestParameter("message[reply_email]", this.ReplyEmail));

            if (this.Html != string.Empty)
                pars.Add(new RestParameter("message[html]", this.Html));

            if (this.TemplateId != 0)
            {
                pars.Add(new RestParameter("message[template_id]", this.TemplateId));

                foreach (KeyValuePair<int, string> item in this.Edit)
                    pars.Add(new RestParameter(string.Format("message[edit][{0}]", item.Key), item.Value));

                foreach (KeyValuePair<int, string> item in this.Repeats)
                    pars.Add(new RestParameter(string.Format("message[repeats][{0}]", item.Key), item.Value));
            }

            if (this.Emails != string.Empty)
                pars.Add(new RestParameter("message[emails]", this.Emails));

            if (this.ListId != 0)
            {
                pars.Add(new RestParameter("message[list_id]", this.ListId));

                if (this.SegmentId > 0)
                    pars.Add(new RestParameter("message[segment_id]", this.SegmentId));
            }

            //Post Data
            string result = Mailee.Rest.post(url, pars);

            return result;
        }

         /// <summary>
        /// Update existing Mesage
        /// </summary>
        private string update()
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/messages)
            string url = string.Format("{0}messages/{1}.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("message[title]", this.Title));
            pars.Add(new RestParameter("message[subject]", this.Subject));
            pars.Add(new RestParameter("message[from_name]", this.FromName));
            pars.Add(new RestParameter("message[from_email]", this.FromEmail));
            pars.Add(new RestParameter("message[analytics]", this.Analytics.ToString().ToLower()));

            if (this.ReplyEmail != string.Empty)
                pars.Add(new RestParameter("message[reply_email]", this.ReplyEmail));

            if (this.Html != string.Empty)
                pars.Add(new RestParameter("message[html]", this.Html));

            if (this.TemplateId != 0)
            {
                pars.Add(new RestParameter("message[template_id]", this.TemplateId));

                foreach (KeyValuePair<int, string> item in this.Edit)
                    pars.Add(new RestParameter(string.Format("message[edit][{0}]", item.Key), item.Value));

                foreach (KeyValuePair<int, string> item in this.Repeats)
                    pars.Add(new RestParameter(string.Format("message[repeats][{0}]", item.Key), item.Value));
            }

            if (this.Emails != string.Empty)
                pars.Add(new RestParameter("message[emails]", this.Emails));

            if (this.ListId != 0)
            {
                pars.Add(new RestParameter("message[list_id]", this.ListId));

                if (this.SegmentId > 0)
                    pars.Add(new RestParameter("message[segment_id]", this.SegmentId));
            }
            
            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        #endregion
 
        #endregion
    }
}