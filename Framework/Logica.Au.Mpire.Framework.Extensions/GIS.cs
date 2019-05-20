using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logica.Au.Mpire.Framework.Extensions
{
    public static class GIS
    {
        public static double Area(this string gml)
        {
            XmlDocument gmlDocument = new XmlDocument();
            XmlNamespaceManager gmlDocumentNamespaceManager = new XmlNamespaceManager(gmlDocument.NameTable);

            gmlDocumentNamespaceManager.AddNamespace("gml", "http://www.opengis.net/gml");
            gmlDocumentNamespaceManager.AddNamespace("onecallgml", "http://www.pelicancorp.com/onecallgml");

            gmlDocument.Load(gml);

            return Area(gmlDocument, gmlDocumentNamespaceManager);
        }

        public static double Area(this XmlDocument gml, XmlNamespaceManager xnmsp)
        {
            List<Double> lats = new List<double>();
            List<Double> lons = new List<double>();

            XmlNode node = gml.SelectSingleNode(@"//gml:FeatureCollection/gml:featureMember/onecallgml:OneCallReferral[@id='digsite']/onecallgml:LocationDetails
                                                        /gml:surfaceProperty/gml:Polygon/gml:exterior/gml:LinearRing/gml:posList", xnmsp);

            if (node != null)
            {
                List<string> nodes = node.InnerText.Split(' ').ToList();

                for (int i = 0; i < nodes.Count; i += 2)
                {
                    lats.Add(Double.Parse(nodes[i]));
                    lons.Add(Double.Parse(nodes[i + 1]));
                }
            }

            return Area(lats, lons);
        }

        private static double Area(List<Double> lats, List<Double> lons)
        {
            double sum = 0;
            double prevcolat = 0;
            double prevaz = 0;
            double colat0 = 0;
            double az0 = 0;

            for (int i = 0; i < lats.Count; i++)
            {
                double colat = 2 * Math.Atan2(Math.Sqrt(Math.Pow(Math.Sin(lats[i] * Math.PI / 180 / 2), 2) + Math.Cos(lats[i] * Math.PI / 180) * Math.Pow(Math.Sin(lons[i] * Math.PI / 180 / 2), 2)), Math.Sqrt(1 - Math.Pow(Math.Sin(lats[i] * Math.PI / 180 / 2), 2) - Math.Cos(lats[i] * Math.PI / 180) * Math.Pow(Math.Sin(lons[i] * Math.PI / 180 / 2), 2)));
                double az = 0;
                if (lats[i] >= 90)
                {
                    az = 0;
                }
                else if (lats[i] <= -90)
                {
                    az = Math.PI;
                }
                else
                {
                    az = Math.Atan2(Math.Cos(lats[i] * Math.PI / 180) * Math.Sin(lons[i] * Math.PI / 180), Math.Sin(lats[i] * Math.PI / 180)) % (2 * Math.PI);
                }
                if (i == 0)
                {
                    colat0 = colat;
                    az0 = az;
                }
                if (i > 0 && i < lats.Count)
                {
                    sum = sum + (1 - Math.Cos(prevcolat + (colat - prevcolat) / 2)) * Math.PI * ((Math.Abs(az - prevaz) / Math.PI) - 2 * Math.Ceiling(((Math.Abs(az - prevaz) / Math.PI) - 1) / 2)) * Math.Sign(az - prevaz);
                }
                prevcolat = colat;
                prevaz = az;
            }

            sum = sum + (1 - Math.Cos(prevcolat + (colat0 - prevcolat) / 2)) * (az0 - prevaz);
            return 5.10072E14 * Math.Min(Math.Abs(sum) / 4 / Math.PI, 1 - Math.Abs(sum) / 4 / Math.PI);
        }

    }
}
