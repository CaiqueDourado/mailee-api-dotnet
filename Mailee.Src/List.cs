/*
 * Mailee.me API - C# Implementation
 * Caique Dourado
 * http://www.caiquedourado.com.br/
 * Date: 2011-06-09
*/

using System;
using System.Xml;
using System.Collections.Generic;
using Mailee;

namespace Mailee
{
    public class List
    {
        #region Fields

        private int _id;
        private string _name;
        private string _description;
        private int _clientId;
        private bool _active;
        private string _company;
        private string _address;
        private int _listsContactsCount;
        private string _phone;
        private string _site;
        private string _facebook;
        private string _twitter;
        private int _total;
        private DateTime? _createdAt;
        private DateTime? _deletedAt;

        #endregion

        #region Properties

        /// <summary>
        /// List Id
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
        /// List Name
        /// </summary>
        public string Name
        {
            get
            {
                return (_name) ?? string.Empty;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// List Description
        /// </summary>
        public string Description
        {
            get
            {
                return (_description) ?? string.Empty;
            }
            set
            {
                _description = value;
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
        /// List Active
        /// </summary>
        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }

        /// <summary>
        /// List Company
        /// </summary>
        public string Company
        {
            get
            {
                return (_company) ?? string.Empty;
            }
            set
            {
                _company = value;
            }
        }

        /// <summary>
        /// List Address
        /// </summary>
        public string Address
        {
            get
            {
                return (_address) ?? string.Empty;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Total count of contacts
        /// </summary>
        public int ListsContactsCount
        {
            get
            {
                return _listsContactsCount;
            }
            set
            {
                _listsContactsCount = value;
            }
        }

        /// <summary>
        /// List Phone
        /// </summary>
        public string Phone
        {
            get
            {
                return (_phone) ?? string.Empty;
            }
            set
            {
                _phone = value;
            }
        }

        /// <summary>
        /// List Site
        /// </summary>
        public string Site
        {
            get
            {
                return (_site) ?? string.Empty;
            }
            set
            {
                _site = value;
            }
        }

        /// <summary>
        /// List Facebook
        /// </summary>
        public string Facebook
        {
            get
            {
                return (_facebook) ?? string.Empty;
            }
            set
            {
                _facebook = value;
            }
        }

        /// <summary>
        /// List Twitter
        /// </summary>
        public string Twitter
        {
            get
            {
                return (_twitter) ?? string.Empty;
            }
            set
            {
                _twitter = value;
            }
        }

        /// <summary>
        /// List Total
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

        #endregion

        #region Constructor

        /// <summary>
        /// List
        /// </summary>
        public List() { }

        /// <summary>
        /// New List
        /// </summary>
        /// <param name="name">List Name</param>
        /// <param name="description">List Description</param>
        /// <param name="company">List Company</param>
        /// <param name="address">List Address</param>
        /// <param name="phone">List Phone</param>
        /// <param name="site">List Site</param>
        public List(string name, string description, string company, string address, string phone, string site)
        {
            this.Name = name;
            this.Description = description;
            this.Company = company;
            this.Address = address;
            this.Phone = phone;
            this.Site = site;
        }

        #endregion

        #region Methods

        #region Find All

        /// <summary>
        /// Find all Lists
        /// </summary>
        public static List<Mailee.List> findAll()
        {
            List<Mailee.List> lists = new List<Mailee.List>();

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/lists)
            string url = string.Concat(Mailee.Config.UrlAPI, "lists.xml");

            //Get data
            string htmlReponse = Mailee.Rest.get(url);
                
            //Create XML
            XmlDocument xmlDoc = new XmlDocument();

            //Load XML
            xmlDoc.LoadXml(htmlReponse);

            //Get Lists
            XmlNodeList xmlLists = xmlDoc.GetElementsByTagName("list");

            //Each Lists
            foreach (XmlNode xmlList in xmlLists)
            {
                //Create new List
                Mailee.List newList = new Mailee.List();

                //Set properties
                newList.Active = Mailee.Util.parseBool(xmlList.ChildNodes[0].InnerText);
                newList.Address = xmlList.ChildNodes[1].InnerText;
                newList.ClientId = Mailee.Util.parseInt(xmlList.ChildNodes[2].InnerText);
                newList.Company = xmlList.ChildNodes[3].InnerText;
                newList.CreatedAt = Mailee.Util.parseDateTime(xmlList.ChildNodes[4].InnerText);
                newList.DeletedAt = Mailee.Util.parseDateTime(xmlList.ChildNodes[5].InnerText);
                newList.Description = xmlList.ChildNodes[6].InnerText;
                newList.Facebook = xmlList.ChildNodes[7].InnerText;
                newList.Id = Mailee.Util.parseInt(xmlList.ChildNodes[8].InnerText);
                newList.ListsContactsCount = Mailee.Util.parseInt(xmlList.ChildNodes[10].InnerText);
                newList.Name = xmlList.ChildNodes[11].InnerText;
                newList.Phone = xmlList.ChildNodes[12].InnerText;
                newList.Site = xmlList.ChildNodes[13].InnerText;
                newList.Total = Mailee.Util.parseInt(xmlList.ChildNodes[14].InnerText);
                newList.Twitter = xmlList.ChildNodes[15].InnerText;

                //Add List
                lists.Add(newList);
            }

            return lists;
        }

        #endregion

        #region Find by ID

        /// <summary>
        /// Find List by ID
        /// </summary>
        /// <param name="id">List ID</param>
        public static Mailee.List findById(int id)
        {
            Mailee.List list = new Mailee.List();

            //Validation
            if (id == 0)
                return list;

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/lists/X.xml)
            string url = string.Format("{0}lists/{1}.xml", Mailee.Config.UrlAPI, id);
           
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

                //Get List
                XmlNodeList xmlLists = xmlDoc.GetElementsByTagName("list");

                if (xmlLists.Count > 0)
                {
                    XmlNode xmlList = xmlLists[0];

                    //Set properties
                    list.Active = Mailee.Util.parseBool(xmlList.ChildNodes[0].InnerText);
                    list.Address = xmlList.ChildNodes[1].InnerText;
                    list.ClientId = Mailee.Util.parseInt(xmlList.ChildNodes[2].InnerText);
                    list.Company = xmlList.ChildNodes[3].InnerText;
                    list.CreatedAt = Mailee.Util.parseDateTime(xmlList.ChildNodes[4].InnerText);
                    list.DeletedAt = Mailee.Util.parseDateTime(xmlList.ChildNodes[5].InnerText);
                    list.Description = xmlList.ChildNodes[6].InnerText;
                    list.Facebook = xmlList.ChildNodes[7].InnerText;
                    list.Id = Mailee.Util.parseInt(xmlList.ChildNodes[8].InnerText);
                    list.ListsContactsCount = Mailee.Util.parseInt(xmlList.ChildNodes[10].InnerText);
                    list.Name = xmlList.ChildNodes[11].InnerText;
                    list.Phone = xmlList.ChildNodes[12].InnerText;
                    list.Site = xmlList.ChildNodes[13].InnerText;
                    list.Total = Mailee.Util.parseInt(xmlList.ChildNodes[14].InnerText);
                    list.Twitter = xmlList.ChildNodes[15].InnerText;
                    
                }

            }

            return list;
        }

        #endregion

        #region Save

        /// <summary>
        /// Create new or Update existing List
        /// </summary>
        public string save()
        {
            if (this.Id == 0)
            {
                //Create new List
                return Create();
            }
            else
            {
                //Update existing List
                return update();
            }
        }

        /// <summary>
        /// Create New List
        /// </summary>
        private string Create()
        {
            //URL (POST) (api.XXXXXXXXXXXXX.subdomain.mailee.me/lists.xml)
            string url = string.Concat(Mailee.Config.UrlAPI, "lists.xml");

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("list[name]", this.Name));
            pars.Add(new RestParameter("list[company]", this.Company));
            pars.Add(new RestParameter("list[facebook]", this.Facebook));
            pars.Add(new RestParameter("list[twitter]", this.Twitter));
            pars.Add(new RestParameter("list[site]", this.Site));
            pars.Add(new RestParameter("list[address]", this.Address));
            pars.Add(new RestParameter("list[phone]", this.Phone));
            pars.Add(new RestParameter("list[description]", this.Description));
            pars.Add(new RestParameter("list[active]", this.Active.ToString().ToLower()));

            //Post Data
            string result = Mailee.Rest.post(url, pars);

            return result;
        }

         /// <summary>
        /// Update existing List
        /// </summary>
        private string update()
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/lists)
            string url = string.Format("{0}lists/{1}.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("list[id]", this.Id));
            pars.Add(new RestParameter("list[name]", this.Name));
            pars.Add(new RestParameter("list[company]", this.Company));
            pars.Add(new RestParameter("list[site]", this.Site));
            pars.Add(new RestParameter("list[facebook]", this.Facebook));
            pars.Add(new RestParameter("list[twitter]", this.Twitter));
            pars.Add(new RestParameter("list[address]", this.Address));
            pars.Add(new RestParameter("list[phone]", this.Phone));
            pars.Add(new RestParameter("list[description]", this.Description));
            pars.Add(new RestParameter("list[active]", this.Active.ToString().ToLower()));

            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        #endregion

        #endregion
    }
}