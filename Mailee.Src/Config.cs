/*
 * Mailee.me API - C# Implementation
 * Caique Dourado
 * http://www.caiquedourado.com.br/
 * Date: 2011-06-09
*/

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;

namespace Mailee
{
    public static class Config
    {
        #region API URL

        /// <summary>
        /// URL Access API
        /// </summary>
        public static string UrlAPI
        {
            get
            {
                //Takes value of configuration key 'MaileeKey' in Web.Config
                string secretKey = System.Configuration.ConfigurationManager.AppSettings["MaileeKey"];

                //Takes value of configuration key 'MaileeSubdomain' in Web.Config
                string subdomain = System.Configuration.ConfigurationManager.AppSettings["MaileeSubdomain"];

                //Make URL to access the API
                string urlAPI = string.Format("http://api.{0}.{1}.mailee.me/", secretKey, subdomain);

                //Return URL
                return urlAPI;
            }
        }
        #endregion
    }
}
