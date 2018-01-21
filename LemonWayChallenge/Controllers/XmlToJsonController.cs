using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.Xml.Linq;

namespace LemonWayAPI.Controllers
{
    [Route("xmltojson")]
    public class XmlToJsonController
    {
        [HttpPost]
        public string XmlToJson(string xml)
        {
            string result;
            if (TryParseXml(xml))
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                result = JsonConvert.SerializeObject(xmlDoc);
            }
            else
            {
                result = "Bad Xml format";
            }

            return result;
        }

        /// <summary>
        /// Tries to parse a text to an xml format.
        /// </summary>
        /// <param name="text">The text to parse.</param>
        /// <returns>True if the text is in the right xml format, otherwise false.</returns>
        private static bool TryParseXml(string text)
        {
            try
            {
                XDocument.Parse(text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
