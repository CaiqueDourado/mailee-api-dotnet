/*
 * Mailee.me API - C# Implementation
 * Caique Dourado
 * http://www.caiquedourado.com.br/
 * Date: 2011-06-09
*/

using System;
using System.Xml;
using System.IO;
using System.Net;
using System.Text;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;

namespace Mailee
{
    public static class Util
    {
        #region Conversions

        /// <summary>
        /// Converts Integer
        /// </summary>
        /// <param name="obj">Object</param>
        public static int parseInt(object obj)
        {
            int ret;

            try
            {
                string str = parseString(obj);
                ret = int.Parse(str);
            }
            catch
            {
                ret = 0;
            }

            return ret;
        }

        /// <summary>
        /// Converts Float
        /// </summary>
        /// <param name="obj">Object</param>
        public static float parseFloat(object obj)
        {
            float ret;

            try
            {
                string str = parseString(obj);
                ret = float.Parse(str);
            }
            catch
            {
                ret = 0;
            }

            return ret;
        }

        /// <summary>
        /// Converts Decimal
        /// </summary>
        /// <param name="obj">Object</param>
        public static decimal parseDecimal(object obj)
        {
            decimal ret;

            try
            {
                string str = parseString(obj);
                ret = decimal.Parse(str);
            }
            catch
            {
                ret = 0;
            }

            return ret;
        }

        /// <summary>
        /// Converts String
        /// </summary>
        /// <param name="obj">Object</param>
        public static String parseString(object obj)
        {
            return (obj != null) ? obj.ToString() : String.Empty;
        }

        /// <summary>
        /// Converts Boolean
        /// </summary>
        /// <param name="obj">Object</param>
        public static bool parseBool(object obj)
        {
            bool retorno;

            try
            {
                if ((obj.ToString().ToLower() == "0") || (obj.ToString().ToLower() == "false") || (obj.ToString().ToLower() == String.Empty))
                    retorno = false;
                else
                    retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Converts Datetime
        /// </summary>
        /// <param name="obj">Object</param>
        public static DateTime? parseDateTime(object obj)
        {
            try
            {
                string str = parseString(obj);
                return DateTime.Parse(str);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Validation

        /// <summary>
        /// Validate XML Format
        /// </summary>
        /// <param name="text">XML string</param>
        public static bool IsValidXML(string text)
        {
            bool errored;

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(text);
            MemoryStream stream = new MemoryStream(byteArray);

            XmlTextReader xmlr = new XmlTextReader(stream);
            XmlValidatingReader reader = new XmlValidatingReader(xmlr);

            try
            {
                while (reader.Read()) { ; }
                errored = false;
            }
            catch
            {
                errored = true;
            }
            finally
            {
                reader.Close();
            }

            return !errored;
        }

        #endregion
    }
}
