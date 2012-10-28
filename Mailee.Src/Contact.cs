/*
 * Mailee.me API - C# Implementation
 * Caique Dourado
 * http://www.caiquedourado.com.br/
 * Date: 2011-06-09
*/

using System;
using System.Web;
using System.Xml;
using System.Collections.Generic;
using Mailee;

namespace Mailee
{
    public class Contact
    {
        #region Fields

        private int _id;
        private string _email;
        private string _name;
        private int _internalId;
        private string _company;
        private string _position;
        private string _sex;
        private DateTime? _birthday;
        private int _client_id;
        private int _age;
        private string _phone;
        private string _mobile;
        private string _address;
        private string _notes;
        private int _originId;
        private List<KeyValuePair<string, string>> _dynamicValues;
        private DateTime? _createdAt;
        private DateTime? _updatedAt;
        private DateTime? _deletedAt;
        private int _contactStatusId;
        private int _facebookFollowers;
        private int _forwardedBy;
        private int _goodreadsConnections;
        private int _importId;
        private float _kscore;
        private decimal _latitude;
        private decimal _longitude;
        private int _linkedinFollowers;
        private int _linkedinRecomendations;
        private int _orkutFollowers;
        private string _photoContentType;
        private string _photoFileName;
        private int _photoFileSize;
        private DateTime? _photoUpdatedAt;
        private int _plaxoConnections;
        private int _skoobConnections;
        private int _twitterFollowers;

        #endregion

        #region Properties

        /// <summary>
        /// Contact Id
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
        /// Contact Email
        /// </summary>
        public string Email
        {
            get
            {
                return (_email) ?? string.Empty;
            }
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Contact Name
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
        /// Id contact your system
        /// </summary>
        public int InternalId
        {
            get
            {
                return _internalId;
            }
            set
            {
                _internalId = value;
            }
        }

        /// <summary>
        /// Contact Company
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
        /// Contact Position
        /// </summary>
        public string Position
        {
            get
            {
                return (_position) ?? string.Empty;
            }
            set
            {
                _position = value;
            }
        }

        /// <summary>
        /// Contact Sex
        /// </summary>
        public string Sex
        {
            get
            {
                return (_sex) ?? string.Empty;
            }
            set
            {
                _sex = value;
            }
        }

        /// <summary>
        /// Contact Birthday
        /// </summary>
        public DateTime? Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }

        /// <summary>
        /// Your ID in Mailee.me
        /// </summary>
        public int ClientId
        {
            get
            {
                return _client_id;
            }
            set
            {
                _client_id = value;
            }
        }
        
        /// <summary>
        /// Contact Age
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        /// <summary>
        /// Contact Phone
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
        /// Contact Mobile
        /// </summary>
        public string Mobile
        {
            get
            {
                return (_mobile) ?? string.Empty;
            }
            set
            {
                _mobile = value;
            }
        }

        /// <summary>
        /// Contact Address
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
        /// Contact Notes
        /// </summary>
        public string Notes
        {
            get
            {
                return (_notes) ?? string.Empty;
            }
            set
            {
                _notes = value;
            }
        }

        /// <summary>
        /// Origin Id
        /// </summary>
        public int OriginId
        {
            get
            {
                return _originId;
            }
            set
            {
                _originId = value;
            }
        }

        /// <summary>
        /// Contact Dynamic Values
        /// </summary>
        public List<KeyValuePair<string, string>> DynamicValues
        {
            get
            {
                if (_dynamicValues == null)
                    _dynamicValues = new List<KeyValuePair<string,string>>();

                return _dynamicValues;
            }
            set
            {
                _dynamicValues = value;
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
        /// Contact Status Id
        /// </summary>
        public int ContactStatusId
        {
            get
            {
                return _contactStatusId;
            }
            set
            {
                _contactStatusId = value;
            }
        }

        /// <summary>
        /// Facebook Followers
        /// </summary>
        public int FacebookFollowers
        {
            get
            {
                return _facebookFollowers;
            }
            set
            {
                _facebookFollowers = value;
            }
        }

        /// <summary>
        /// Forwarded By
        /// </summary>
        public int ForwardedBy
        {
            get
            {
                return _forwardedBy;
            }
            set
            {
                _forwardedBy = value;
            }
        }

        /// <summary>
        /// Goodreads Connections
        /// </summary>
        public int GoodreadsConnections
        {
            get
            {
                return _goodreadsConnections;
            }
            set
            {
                _goodreadsConnections = value;
            }
        }

        /// <summary>
        /// Import Id
        /// </summary>
        public int ImportId
        {
            get
            {
                return _importId;
            }
            set
            {
                _importId = value;
            }
        }

        /// <summary>
        /// Klout score
        /// </summary>
        public float Kscore
        {
            get
            {
                return _kscore;
            }
            set
            {
                _kscore = value;
            }
        }

        /// <summary>
        /// Latitude
        /// </summary>
        public decimal Latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                _latitude = value;
            }
        }

        /// <summary>
        /// Longitude
        /// </summary>
        public decimal Longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                _longitude = value;
            }
        }

        /// <summary>
        /// Linkedin Followers
        /// </summary>
        public int LinkedinFollowers
        {
            get
            {
                return _linkedinFollowers;
            }
            set
            {
                _linkedinFollowers = value;
            }
        }

        /// <summary>
        /// Linkedin Recomendations
        /// </summary>
        public int LinkedinRecomendations
        {
            get
            {
                return _linkedinRecomendations;
            }
            set
            {
                _linkedinRecomendations = value;
            }
        }

        /// <summary>
        /// Orkut Followers
        /// </summary>
        public int OrkutFollowers
        {
            get
            {
                return _orkutFollowers;
            }
            set
            {
                _orkutFollowers = value;
            }
        }

        /// <summary>
        /// Photo Content Type
        /// </summary>
        public string PhotoContentType
        {
            get
            {
                return (_photoContentType) ?? string.Empty;
            }
            set
            {
                _photoContentType = value;
            }
        }

        /// <summary>
        /// Photo File Name
        /// </summary>
        public string PhotoFileName
        {
            get
            {
                return (_photoFileName) ?? string.Empty;
            }
            set
            {
                _photoFileName = value;
            }
        }

        /// <summary>
        /// Photo File Size
        /// </summary>
        public int PhotoFileSize
        {
            get
            {
                return _photoFileSize;
            }
            set
            {
                _photoFileSize = value;
            }
        }

        /// <summary>
        /// Photo Updated At
        /// </summary>
        public DateTime? PhotoUpdatedAt
        {
            get
            {
                return _photoUpdatedAt;
            }
            set
            {
                _photoUpdatedAt = value;
            }
        }

        /// <summary>
        /// Plaxo Connections
        /// </summary>
        public int PlaxoConnections
        {
            get
            {
                return _plaxoConnections;
            }
            set
            {
                _plaxoConnections = value;
            }
        }

        /// <summary>
        /// Skoob Connections
        /// </summary>
        public int SkoobConnections
        {
            get
            {
                return _skoobConnections;
            }
            set
            {
                _skoobConnections = value;
            }
        }

        /// <summary>
        /// Twitter Followers
        /// </summary>
        public int TwitterFollowers
        {
            get
            {
                return _twitterFollowers;
            }
            set
            {
                _twitterFollowers = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Contact
        /// </summary>
        public Contact() { }

        /// <summary>
        /// New Contact
        /// </summary>
        /// <param name="id">Id</param>
        public Contact(int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// New Contact
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="email">Email</param>
        /// <param name="name">Name</param>
        /// <param name="internal_id">Id contact your system</param>
        /// <param name="company">Contact Company</param>
        /// <param name="position">Contact Position</param>
        /// <param name="sex">Contact Sex</param>
        /// <param name="birthday">Contact Sex</param>
        /// <param name="age">Contact Age</param>
        /// <param name="phone">Contact Phone</param>
        /// <param name="mobile">Contact Mobile</param>
        /// <param name="address">Contact Address</param>
        /// <param name="notes">Contact Notes</param>
        /// <param name="dynamicValues">Contact Dynamic Values</param>
        public Contact(int id, string email, string name, int internalid, string company, string position, string sex, DateTime? birthday, int age, string phone, string mobile, string address, string notes, List<KeyValuePair<string, string>> dynamicValues)
        {
            this.Id = id;
            this.Email = _email;
            this.Name = _name;
            this.InternalId = _internalId;
            this.Company = _company;
            this.Position = _position;
            this.Sex = _sex;
            this.Birthday = _birthday;
            this.Age = _age;
            this.Phone = _phone;
            this.Mobile = _mobile;
            this.Address = _address;
            this.Notes = _notes;
            this.DynamicValues = _dynamicValues;
        }

        #endregion

        #region Methods

        #region Find All by Page

        /// <summary>
        /// Find all Contacts
        /// </summary>
        public static List<Mailee.Contact> findAll()
        {
            return findAll(1);
        }

        /// <summary>
        /// Find all Contacts with pagination
        /// </summary>
        /// <param name="page">Page</param>
        public static List<Mailee.Contact> findAll(int page)
        {
            List<Mailee.Contact> contacts = new List<Mailee.Contact>();

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts)
            string url = string.Format("{0}contacts.xml?page={1}", Mailee.Config.UrlAPI, page);

            //Get data
            string htmlReponse = Mailee.Rest.get(url);
                
            //Create XML
            XmlDocument xmlDoc = new XmlDocument();

            //Load XML
            xmlDoc.LoadXml(htmlReponse);

            //Get Contacts
            XmlNodeList xmlContacts = xmlDoc.GetElementsByTagName("contact");

            //Each Contacts
            foreach (XmlNode xmlContact in xmlContacts)
            {
                //Create new Concat
                Mailee.Contact newContact = new Mailee.Contact();

                //Set properties
                newContact.Address = xmlContact.ChildNodes[0].InnerText;
                newContact.Age = Mailee.Util.parseInt(xmlContact.ChildNodes[1].InnerText);
                newContact.Birthday = Mailee.Util.parseDateTime(xmlContact.ChildNodes[2].InnerText);
                newContact.ClientId = Mailee.Util.parseInt(xmlContact.ChildNodes[3].InnerText);
                newContact.Company = xmlContact.ChildNodes[4].InnerText;
                newContact.ContactStatusId = Mailee.Util.parseInt(xmlContact.ChildNodes[5].InnerText);
                newContact.CreatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[6].InnerText);
                newContact.DeletedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[7].InnerText);
                //contact.DynamicValues = xmlContact.ChildNodes[8].InnerText;
                newContact.Email = xmlContact.ChildNodes[9].InnerText;
                newContact.FacebookFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[10].InnerText);
                newContact.ForwardedBy = Mailee.Util.parseInt(xmlContact.ChildNodes[11].InnerText);
                newContact.GoodreadsConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[12].InnerText);
                newContact.Id = Mailee.Util.parseInt(xmlContact.ChildNodes[13].InnerText);
                newContact.ImportId = Mailee.Util.parseInt(xmlContact.ChildNodes[14].InnerText);
                newContact.InternalId = Mailee.Util.parseInt(xmlContact.ChildNodes[15].InnerText);
                newContact.Kscore = Mailee.Util.parseFloat(xmlContact.ChildNodes[16].InnerText);
                newContact.Latitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[17].InnerText);
                newContact.LinkedinFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[18].InnerText);
                newContact.LinkedinRecomendations = Mailee.Util.parseInt(xmlContact.ChildNodes[19].InnerText);
                newContact.Longitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[20].InnerText);
                newContact.Mobile = xmlContact.ChildNodes[21].InnerText;
                newContact.Name = xmlContact.ChildNodes[22].InnerText;
                newContact.Notes = xmlContact.ChildNodes[23].InnerText;
                newContact.OriginId = Mailee.Util.parseInt(xmlContact.ChildNodes[24].InnerText);
                newContact.OrkutFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[25].InnerText);
                newContact.Phone = xmlContact.ChildNodes[26].InnerText;
                newContact.PhotoContentType = xmlContact.ChildNodes[27].InnerText;
                newContact.PhotoFileName = xmlContact.ChildNodes[28].InnerText;
                newContact.PhotoFileSize = Mailee.Util.parseInt(xmlContact.ChildNodes[29].InnerText);
                newContact.PhotoUpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[30].InnerText);
                newContact.PlaxoConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[31].InnerText);
                newContact.Position = xmlContact.ChildNodes[32].InnerText;
                newContact.Sex = xmlContact.ChildNodes[33].InnerText;
                newContact.SkoobConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[34].InnerText);
                newContact.TwitterFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[35].InnerText);
                newContact.UpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[36].InnerText);

                //Add Contact
                contacts.Add(newContact);
            }

            return contacts;
        }

        #endregion

        #region Find by ID

        /// <summary>
        /// Find Contact by ID
        /// </summary>
        /// <param name="id">Contact ID</param>
        public static Mailee.Contact findById(int id)
        {
            Mailee.Contact contact = new Mailee.Contact();

            //Validation
            if (id == 0)
                return contact;

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts/X.xml)
            string url = string.Format("{0}contacts/{1}.xml", Mailee.Config.UrlAPI, id);

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

                //Get Contact
                XmlNodeList xmlContacts = xmlDoc.GetElementsByTagName("contact");

                if (xmlContacts.Count > 0)
                {
                    XmlNode xmlContact = xmlContacts[0];

                    //Set properties
                    contact.Address = xmlContact.ChildNodes[0].InnerText;
                    contact.Age = Mailee.Util.parseInt(xmlContact.ChildNodes[1].InnerText);
                    contact.Birthday = Mailee.Util.parseDateTime(xmlContact.ChildNodes[2].InnerText);
                    contact.ClientId = Mailee.Util.parseInt(xmlContact.ChildNodes[3].InnerText);
                    contact.Company = xmlContact.ChildNodes[4].InnerText;
                    contact.ContactStatusId = Mailee.Util.parseInt(xmlContact.ChildNodes[5].InnerText);
                    contact.CreatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[6].InnerText);
                    contact.DeletedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[7].InnerText);
                    //contact.DynamicValues = xmlContact.ChildNodes[8].InnerText;
                    contact.Email = xmlContact.ChildNodes[9].InnerText;
                    contact.FacebookFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[10].InnerText);
                    contact.ForwardedBy = Mailee.Util.parseInt(xmlContact.ChildNodes[11].InnerText);
                    contact.GoodreadsConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[12].InnerText);
                    contact.Id = Mailee.Util.parseInt(xmlContact.ChildNodes[13].InnerText);
                    contact.ImportId = Mailee.Util.parseInt(xmlContact.ChildNodes[14].InnerText);
                    contact.InternalId = Mailee.Util.parseInt(xmlContact.ChildNodes[15].InnerText);
                    contact.Kscore = Mailee.Util.parseFloat(xmlContact.ChildNodes[16].InnerText);
                    contact.Latitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[17].InnerText);
                    contact.LinkedinFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[18].InnerText);
                    contact.LinkedinRecomendations = Mailee.Util.parseInt(xmlContact.ChildNodes[19].InnerText);
                    contact.Longitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[20].InnerText);
                    contact.Mobile = xmlContact.ChildNodes[21].InnerText;
                    contact.Name = xmlContact.ChildNodes[22].InnerText;
                    contact.Notes = xmlContact.ChildNodes[23].InnerText;
                    contact.OriginId = Mailee.Util.parseInt(xmlContact.ChildNodes[24].InnerText);
                    contact.OrkutFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[25].InnerText);
                    contact.Phone = xmlContact.ChildNodes[26].InnerText;
                    contact.PhotoContentType = xmlContact.ChildNodes[27].InnerText;
                    contact.PhotoFileName = xmlContact.ChildNodes[28].InnerText;
                    contact.PhotoFileSize = Mailee.Util.parseInt(xmlContact.ChildNodes[29].InnerText);
                    contact.PhotoUpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[30].InnerText);
                    contact.PlaxoConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[31].InnerText);
                    contact.Position = xmlContact.ChildNodes[32].InnerText;
                    contact.Sex = xmlContact.ChildNodes[33].InnerText;
                    contact.SkoobConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[34].InnerText);
                    contact.TwitterFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[35].InnerText);
                    contact.UpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[36].InnerText);
                }

            }

            return contact;
        }

        #endregion

        #region Find Contact by Internal ID

        /// <summary>
        /// Find Contact by Internal ID
        /// </summary>
        /// <param name="internalId">Contact ID</param>
        public static Mailee.Contact findByInternalId(int internalId)
        {
            Mailee.Contact contact = new Mailee.Contact();

            //Validation
            if (internalId == 0)
                return contact;

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts.xml?internal_id=X)
            string url = string.Format("{0}contacts.xml?internal_id={1}", Mailee.Config.UrlAPI, internalId);

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

                //Get Contact
                XmlNodeList xmlContacts = xmlDoc.GetElementsByTagName("contact");

                if (xmlContacts.Count > 0)
                {
                    XmlNode xmlContact = xmlContacts[0];

                    //Set properties
                    contact.Address = xmlContact.ChildNodes[0].InnerText;
                    contact.Age = Mailee.Util.parseInt(xmlContact.ChildNodes[1].InnerText);
                    contact.Birthday = Mailee.Util.parseDateTime(xmlContact.ChildNodes[2].InnerText);
                    contact.ClientId = Mailee.Util.parseInt(xmlContact.ChildNodes[3].InnerText);
                    contact.Company = xmlContact.ChildNodes[4].InnerText;
                    contact.ContactStatusId = Mailee.Util.parseInt(xmlContact.ChildNodes[5].InnerText);
                    contact.CreatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[6].InnerText);
                    contact.DeletedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[7].InnerText);
                    //contact.DynamicValues = xmlContact.ChildNodes[8].InnerText;
                    contact.Email = xmlContact.ChildNodes[9].InnerText;
                    contact.FacebookFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[10].InnerText);
                    contact.ForwardedBy = Mailee.Util.parseInt(xmlContact.ChildNodes[11].InnerText);
                    contact.GoodreadsConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[12].InnerText);
                    contact.Id = Mailee.Util.parseInt(xmlContact.ChildNodes[13].InnerText);
                    contact.ImportId = Mailee.Util.parseInt(xmlContact.ChildNodes[14].InnerText);
                    contact.InternalId = Mailee.Util.parseInt(xmlContact.ChildNodes[15].InnerText);
                    contact.Kscore = Mailee.Util.parseFloat(xmlContact.ChildNodes[16].InnerText);
                    contact.Latitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[17].InnerText);
                    contact.LinkedinFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[18].InnerText);
                    contact.LinkedinRecomendations = Mailee.Util.parseInt(xmlContact.ChildNodes[19].InnerText);
                    contact.Longitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[20].InnerText);
                    contact.Mobile = xmlContact.ChildNodes[21].InnerText;
                    contact.Name = xmlContact.ChildNodes[22].InnerText;
                    contact.Notes = xmlContact.ChildNodes[23].InnerText;
                    contact.OriginId = Mailee.Util.parseInt(xmlContact.ChildNodes[24].InnerText);
                    contact.OrkutFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[25].InnerText);
                    contact.Phone = xmlContact.ChildNodes[26].InnerText;
                    contact.PhotoContentType = xmlContact.ChildNodes[27].InnerText;
                    contact.PhotoFileName = xmlContact.ChildNodes[28].InnerText;
                    contact.PhotoFileSize = Mailee.Util.parseInt(xmlContact.ChildNodes[29].InnerText);
                    contact.PhotoUpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[30].InnerText);
                    contact.PlaxoConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[31].InnerText);
                    contact.Position = xmlContact.ChildNodes[32].InnerText;
                    contact.Sex = xmlContact.ChildNodes[33].InnerText;
                    contact.SkoobConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[34].InnerText);
                    contact.TwitterFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[35].InnerText);
                    contact.UpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[36].InnerText);
                }

            }

            return contact;
        }

        #endregion

        #region Find Contact by Email

        /// <summary>
        /// Find Contact by Email
        /// </summary>
        /// <param name="email">Email</param>
        public static Mailee.Contact findByEmail(string email)
        {
            Mailee.Contact contact = new Mailee.Contact();

            //Validation
            if (email == string.Empty)
                return contact;

            //URL (GET) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts.xml?email=X)
            string url = string.Format("{0}contacts.xml?email={1}", Mailee.Config.UrlAPI,  HttpContext.Current.Server.UrlEncode(email));

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

                //Get Contact
                XmlNodeList xmlContacts = xmlDoc.GetElementsByTagName("contact");

                if (xmlContacts.Count > 0)
                {
                    XmlNode xmlContact = xmlContacts[0];

                    //Set properties
                    contact.Address = xmlContact.ChildNodes[0].InnerText;
                    contact.Age = Mailee.Util.parseInt(xmlContact.ChildNodes[1].InnerText);
                    contact.Birthday = Mailee.Util.parseDateTime(xmlContact.ChildNodes[2].InnerText);
                    contact.ClientId = Mailee.Util.parseInt(xmlContact.ChildNodes[3].InnerText);
                    contact.Company = xmlContact.ChildNodes[4].InnerText;
                    contact.ContactStatusId = Mailee.Util.parseInt(xmlContact.ChildNodes[5].InnerText);
                    contact.CreatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[6].InnerText);
                    contact.DeletedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[7].InnerText);
                    //contact.DynamicValues = xmlContact.ChildNodes[8].InnerText;
                    contact.Email = xmlContact.ChildNodes[9].InnerText;
                    contact.FacebookFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[10].InnerText);
                    contact.ForwardedBy = Mailee.Util.parseInt(xmlContact.ChildNodes[11].InnerText);
                    contact.GoodreadsConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[12].InnerText);
                    contact.Id = Mailee.Util.parseInt(xmlContact.ChildNodes[13].InnerText);
                    contact.ImportId = Mailee.Util.parseInt(xmlContact.ChildNodes[14].InnerText);
                    contact.InternalId = Mailee.Util.parseInt(xmlContact.ChildNodes[15].InnerText);
                    contact.Kscore = Mailee.Util.parseFloat(xmlContact.ChildNodes[16].InnerText);
                    contact.Latitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[17].InnerText);
                    contact.LinkedinFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[18].InnerText);
                    contact.LinkedinRecomendations = Mailee.Util.parseInt(xmlContact.ChildNodes[19].InnerText);
                    contact.Longitude = Mailee.Util.parseDecimal(xmlContact.ChildNodes[20].InnerText);
                    contact.Mobile = xmlContact.ChildNodes[21].InnerText;
                    contact.Name = xmlContact.ChildNodes[22].InnerText;
                    contact.Notes = xmlContact.ChildNodes[23].InnerText;
                    contact.OriginId = Mailee.Util.parseInt(xmlContact.ChildNodes[24].InnerText);
                    contact.OrkutFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[25].InnerText);
                    contact.Phone = xmlContact.ChildNodes[26].InnerText;
                    contact.PhotoContentType = xmlContact.ChildNodes[27].InnerText;
                    contact.PhotoFileName = xmlContact.ChildNodes[28].InnerText;
                    contact.PhotoFileSize = Mailee.Util.parseInt(xmlContact.ChildNodes[29].InnerText);
                    contact.PhotoUpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[30].InnerText);
                    contact.PlaxoConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[31].InnerText);
                    contact.Position = xmlContact.ChildNodes[32].InnerText;
                    contact.Sex = xmlContact.ChildNodes[33].InnerText;
                    contact.SkoobConnections = Mailee.Util.parseInt(xmlContact.ChildNodes[34].InnerText);
                    contact.TwitterFollowers = Mailee.Util.parseInt(xmlContact.ChildNodes[35].InnerText);
                    contact.UpdatedAt = Mailee.Util.parseDateTime(xmlContact.ChildNodes[36].InnerText);
                }

            }

            return contact;
        }

        #endregion

        #region Save

        /// <summary>
        /// Create new or Update existing contact
        /// </summary>
        public string save()
        {
            if (this.Id == 0)
            {
                //Create new Contact
                return Create();
            }
            else
            {
                //Update existing Contact
                return update();
            }
        }

        /// <summary>
        /// Create New Contact
        /// </summary>
        private string Create()
        {
            //URL (POST) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts.xml)
            string url = string.Concat(Mailee.Config.UrlAPI, "contacts.xml");

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("contact[email]", this.Email));
            pars.Add(new RestParameter("contact[name]", this.Name));
            pars.Add(new RestParameter("contact[internal_id]", this.InternalId));
            pars.Add(new RestParameter("contact[company]", this.Company));
            pars.Add(new RestParameter("contact[position]", this.Position));
            pars.Add(new RestParameter("contact[sex]", this.Sex));
            pars.Add(new RestParameter("contact[birthday]", string.Format("{0:yyyy-MM-dd}", this.Birthday)));
            pars.Add(new RestParameter("contact[age]", this.Age));
            pars.Add(new RestParameter("contact[phone]", this.Phone));
            pars.Add(new RestParameter("contact[mobile]", this.Mobile));
            pars.Add(new RestParameter("contact[address]", this.Address));
            pars.Add(new RestParameter("contact[notes]", this.Notes));

            foreach (KeyValuePair<string, string> dynamicValue in this.DynamicValues)
                pars.Add(new RestParameter(string.Format("contact[dynamic_attributes][{0}]", dynamicValue.Key), dynamicValue.Value));

            //Post Data
            string result = Mailee.Rest.post(url, pars);

            #region Fill Contact Data

            //Checks if the xml is valid
            bool isValidXml = Mailee.Util.IsValidXML(result);

            if (isValidXml == true)
            {
                //Create XML
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();

                //Load XML
                xmlDoc.LoadXml(result);

                //Get Contact
                System.Xml.XmlNodeList xmlContacts = xmlDoc.GetElementsByTagName("contact");

                if (xmlContacts.Count > 0)
                {
                    System.Xml.XmlNode xmlContact = xmlContacts[0];

                    //Set properties
                    this.Id = Mailee.Util.parseInt(xmlContact.ChildNodes[13].InnerText);
                }

            }

            #endregion

            return result;
        }

         /// <summary>
        /// Update existing Contact
        /// </summary>
        private string update()
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts.xml)
            string url = string.Format("{0}contacts/{1}.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("contact[id]", this.Id));
            pars.Add(new RestParameter("contact[email]", this.Email));
            pars.Add(new RestParameter("contact[name]", this.Name));
            pars.Add(new RestParameter("contact[internal_id]", this.InternalId));
            pars.Add(new RestParameter("contact[company]", this.Company));
            pars.Add(new RestParameter("contact[position]", this.Position));
            pars.Add(new RestParameter("contact[sex]", this.Sex));
            pars.Add(new RestParameter("contact[birthday]", string.Format("{0:yyyy-MM-dd}", this.Birthday)));
            pars.Add(new RestParameter("contact[age]", this.Age));
            pars.Add(new RestParameter("contact[phone]", this.Phone));
            pars.Add(new RestParameter("contact[mobile]", this.Mobile));
            pars.Add(new RestParameter("contact[address]", this.Address));
            pars.Add(new RestParameter("contact[notes]", this.Notes));

            foreach (KeyValuePair<string, string> dynamicValue in this.DynamicValues)
                pars.Add(new RestParameter(string.Format("contact[dynamic_attributes][{0}]", dynamicValue.Key), dynamicValue.Value));

            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        #endregion

        #region Subscribe to list

        /// <summary>
        /// Subscribe to list
        /// </summary>
        /// <param name="listName">List Name</param>
        public string Subscribe(string listName)
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts/ID/list_subscribe.xml)
            string url = string.Format("{0}contacts/{1}/list_subscribe.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            //pars.Add(new RestParameter("list[name]", listName));
            pars.Add(new RestParameter("list", listName));

            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        /// <summary>
        /// Subscribe to list
        /// </summary>
        /// <param name="listId">List Id</param>
        public string Subscribe(int listId)
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts/ID/list_subscribe.xml)
            string url = string.Format("{0}contacts/{1}/list_subscribe.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("list_id", listId));

            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        #endregion

        #region Unsubscribe to list

        /// <summary>
        /// Unsubscribe to list
        /// </summary>
        /// <param name="listName">List Name</param>
        public string Unsubscribe(string listName)
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts/ID/list_unsubscribe.xml)
            string url = string.Format("{0}contacts/{1}/list_unsubscribe.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("list", listName));

            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        /// <summary>
        /// Unsubscribe to list
        /// </summary>
        /// <param name="listId">List Id</param>
        public string Unsubscribe(int listId)
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts/ID/list_unsubscribe.xml)
            string url = string.Format("{0}contacts/{1}/list_unsubscribe.xml", Mailee.Config.UrlAPI, this.Id);

            //Create url params
            List<RestParameter> pars = new List<RestParameter>();

            pars.Add(new RestParameter("list_id", listId));

            //Post Data
            string result = Mailee.Rest.put(url, pars);

            return result;
        }

        #endregion

        #region Unsubscribe Contact

        /// <summary>
        /// Unsubscribe Contact
        /// </summary>
        public string Unsubscribe()
        {
            //URL (PUT) (api.XXXXXXXXXXXXX.subdomain.mailee.me/contacts/ID/unsubscribe.xml)
            string url = string.Format("{0}contacts/{1}/unsubscribe.xml", Mailee.Config.UrlAPI, this.Id);

            //Post Data
            string result = Mailee.Rest.put(url);

            return result;
        }

        #endregion

        #endregion
    }
}