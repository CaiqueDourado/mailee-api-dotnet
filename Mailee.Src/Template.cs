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
    public class Template
    {
        #region Fields

        private int _id;
        private string _title;
        private string _html;
        private int _clientId;
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private DateTime? _updatedAt;
        private string _simulations;
        private string _thumbContentType;
        private string _thumbFileName;
        private int _thumbFileSize;
        private DateTime? _thumbUpdatedAt;

        #endregion

        #region Properties

        /// <summary>
        /// Template Id
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
        /// Template Title
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
        /// Template HTML Content
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
        /// Updated At
        /// </summary>
        public DateTime? UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
            set
            {
                _updatedAt = value;
            }
        }

        /// <summary>
        /// Simulations
        /// </summary>
        public string Simulations
        {
            get
            {
                return (_simulations) ?? string.Empty;
            }
            set
            {
                _simulations = value;
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

        #endregion

        #region Constructor

        /// <summary>
        /// Template
        /// </summary>
        public Template() { }

        /// <summary>
        /// New Template
        /// </summary>
        /// <param name="title">Template Title</param>
        /// <param name="html">Template HTML</param>
        public Template(string title, string html)
        {
            this.Title = title;
            this.Html = html;
        }

        #endregion

        #region Methods

        #region Find Templates

        /// <summary>
        /// Find all Templates
        /// </summary>
        public static List<Mailee.Template> findAll()
        {
            List<Mailee.Template> templates = new List<Mailee.Template>();

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/templates)
            string url = string.Concat(Mailee.Config.UrlAPI, "templates.xml");

            //Get data
            string htmlReponse = Mailee.Rest.get(url);
                
            //Create XML
            XmlDocument xmlDoc = new XmlDocument();

            //Load XML
            xmlDoc.LoadXml(htmlReponse);

            //Get Templates
            XmlNodeList xmlTemplates = xmlDoc.GetElementsByTagName("template");

            //Each Tenplates
            foreach (XmlNode xmlTemplate in xmlTemplates)
            {
                //Create new Template
                Mailee.Template newTemplate = new Mailee.Template();

                //Set properties
                newTemplate.ClientId = Mailee.Util.parseInt(xmlTemplate.ChildNodes[0].InnerText);
                newTemplate.CreatedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[1].InnerText);
                newTemplate.DeletedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[2].InnerText);
                newTemplate.Html = xmlTemplate.ChildNodes[3].InnerText;
                newTemplate.Id = Mailee.Util.parseInt(xmlTemplate.ChildNodes[4].InnerText);
                newTemplate.Simulations = xmlTemplate.ChildNodes[5].InnerText;
                newTemplate.ThumbContentType = xmlTemplate.ChildNodes[6].InnerText;
                newTemplate.ThumbFileName = xmlTemplate.ChildNodes[7].InnerText;
                newTemplate.ThumbFileSize = Mailee.Util.parseInt(xmlTemplate.ChildNodes[8].InnerText);
                newTemplate.ThumbUpdatedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[9].InnerText);
                newTemplate.Title = xmlTemplate.ChildNodes[10].InnerText;
                newTemplate.UpdatedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[11].InnerText);
                
                //Add Template
                templates.Add(newTemplate);
            }

            return templates;
        }

        #endregion

        #region Find by ID

        /// <summary>
        /// Find Template by ID
        /// </summary>
        /// <param name="id">Template ID</param>
        public static Mailee.Template findById(int id)
        {
            Mailee.Template template = new Mailee.Template();

            //Validation
            if (id == 0)
                return template;

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/templates/X.xml)
            string url = string.Format("{0}templates/{1}.xml", Mailee.Config.UrlAPI, id);
           
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

                //Get Template
                XmlNodeList xmlTemplates = xmlDoc.GetElementsByTagName("template");

                if (xmlTemplates.Count > 0)
                {
                    XmlNode xmlTemplate = xmlTemplates[0];

                    //Set properties
                    template.ClientId = Mailee.Util.parseInt(xmlTemplate.ChildNodes[0].InnerText);
                    template.CreatedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[1].InnerText);
                    template.DeletedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[2].InnerText);
                    template.Html = xmlTemplate.ChildNodes[3].InnerText;
                    template.Id = Mailee.Util.parseInt(xmlTemplate.ChildNodes[4].InnerText);
                    template.Simulations = xmlTemplate.ChildNodes[5].InnerText;
                    template.ThumbContentType = xmlTemplate.ChildNodes[6].InnerText;
                    template.ThumbFileName = xmlTemplate.ChildNodes[7].InnerText;
                    template.ThumbFileSize = Mailee.Util.parseInt(xmlTemplate.ChildNodes[8].InnerText);
                    template.ThumbUpdatedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[9].InnerText);
                    template.Title = xmlTemplate.ChildNodes[10].InnerText;
                    template.UpdatedAt = Mailee.Util.parseDateTime(xmlTemplate.ChildNodes[11].InnerText);
                }

            }

            return template;
        }

        #endregion

        #region Save

        /// <summary>
        /// Create new or Update existing Template
        /// </summary>
        public string save()
        {
            if (this.Id == 0)
            {
                //Create new Template
                return Create();
            }
            else
            {
                //Update existing Template
                return update();
            }
        }

        /// <summary>
        /// Create New Template
        /// </summary>
        private string Create()
        {
            //URL (POST) (api.XXXXXXXXXXXXX.subdomain.mailee.me/templates.xml)
            string url = string.Concat(Mailee.Config.UrlAPI, "templates.xml");

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("template[title]", this.Title));
            pars.Add(new RestParameter("template[html]", this.Html));

            //Post Data
            string result = Mailee.Rest.post(url, pars);

            return result;
        }

         /// <summary>
        /// Update existing Template
        /// </summary>
        private string update()
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/templates)
            string url = string.Format("{0}templates/{1}.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("template[title]", this.Title));
            pars.Add(new RestParameter("template[html]", this.Html));
            
            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        #endregion
 
        #endregion
    }
}