using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.IO;
using System.Xml;

namespace Logica.Au.Mpire.Framework.Utilities
{
    public class XmlData
    {
        public XmlData()
        {
        }

        public XmlData(string xmlData)
        {
        }
    }

    public static class Extensions
    {
        public static string GetString(this string xpath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(caseApplicationData);

                XmlNode node = doc.SelectSingleNode(xpath);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
