using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Xml;
using System.Reflection;
using System.IO;

namespace Logica.Au.Mpire.Framework.Extensions
{
    public static class StringExtensions
    {
        public static HybridDictionary Explode(this string input, char seperator)
        {
            HybridDictionary result = new HybridDictionary();
            string[] parts = input.Split(seperator);

            for (int i = 0; i < parts.Count() - 1; i += 2)
            {
                result.Add(parts[i], parts[i + 1]);
            }

            return result;
        }

        public static bool IsStringGuid(this string input, out Guid output)
        {
            try
            {
                //ClsidFromString returns the empty guid for null strings    
                if ((input == null) || (input == ""))
                {
                    output = Guid.Empty;
                    return false;
                }

                string[] parts = input.Split('-');
                if (parts.Length == 5)
                {
                    if ((parts[0].Length == 8) && (parts[1].Length == 4) && (parts[2].Length == 4) && (parts[3].Length == 4) && (parts[4].Length == 12))
                    {
                        output = new Guid(input);
                    }
                    else
                        output = Guid.Empty;
                }
                else
                    output = Guid.Empty;

                return (output != Guid.Empty);
            }
            catch (Exception ex)
            {
                output = Guid.Empty;
                return false;
            }
        }

        public static bool IsStringGuid(this string input)
        {
            Guid value;
            return IsStringGuid(input, out value);
        }

        public static bool TryGetStringFromXpath(this string input, string xpath, out string value)
        {
            value = string.Empty;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(input);

                XmlNode node = doc.SelectSingleNode(xpath);

                if (node != null)
                {
                    if (!string.IsNullOrEmpty(node.InnerText))
                    {
                        value = node.InnerText;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool TryGetBooleanFromXpath(this string input, string xpath, out bool value)
        {
            value = false;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(input);

                XmlNode node = doc.SelectSingleNode(xpath);

                if (node != null)
                {
                    if (!string.IsNullOrEmpty(node.InnerText))
                    {
                        switch (node.InnerText.ToLower())
                        {
                            case "yes":
                                value = true;
                                break;
                            case "true":
                                value = true;
                                break;
                            case "1":
                                value = true;
                                break;
                            default:
                                value = false;
                                break;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool TryGetDecimalFromXpath(this string input, string xpath, out decimal value)
        {
            value = 0;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(input);

                XmlNode node = doc.SelectSingleNode(xpath);

                if (node != null)
                {
                    if (!string.IsNullOrEmpty(node.InnerText))
                    {
                        value = decimal.Parse(node.InnerText);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool TryGetIntegerFromXpath(this string input, string xpath, out int value)
        {
            value = 0;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(input);

                XmlNode node = doc.SelectSingleNode(xpath);

                if (node != null)
                {
                    if (!string.IsNullOrEmpty(node.InnerText))
                    {
                        value = int.Parse(node.InnerText);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string GetStructureConstantValue(this string input, string SysListName, string defaultValue)
        {
            string DefinitionsSysListsDLL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logica.Au.Mpire.Framework.Definitions.SysLists.dll");

            Assembly asm = System.Reflection.Assembly.LoadFrom(DefinitionsSysListsDLL);

            string value = string.Empty;
            string defValue = string.Empty;

            bool done = false;

            foreach (Type t in asm.GetTypes())
            {
                if (t.Name.ToLower() == SysListName.ToLower())
                {
                    foreach (FieldInfo f in t.GetFields())
                    {
                        if (f.Name.ToLower() == input.ToLower())
                        {
                            value = f.GetRawConstantValue().ToString();
                            done = true;
                            break;
                        }
                        else if (f.Name.ToLower() == defaultValue.ToLower())
                        {
                            defValue = f.GetRawConstantValue().ToString();
                        }
                    }
                }

                if (done)
                    break;
            }

            // If nothing then see if we found the default
            if (string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(defValue))
                value = defValue;

            return value;
        }

        public static string GetStructureConstantNameFromValue(this string input, string SysListName, string defaultValue)
        {
            string DefinitionsSysListsDLL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logica.Au.Mpire.Framework.Definitions.SysLists.dll");

            Assembly asm = System.Reflection.Assembly.LoadFrom(DefinitionsSysListsDLL);

            string value = string.Empty;
            string defValue = string.Empty;

            bool done = false;

            foreach (Type t in asm.GetTypes())
            {
                if (t.Name.ToLower() == SysListName.ToLower())
                {
                    foreach (FieldInfo f in t.GetFields())
                    {
                        if (f.GetValue(f).ToString() == input)
                        {
                            value = f.Name;
                            done = true;
                        }
                    }
                }

                if (done)
                    break;
            }

            // If nothing then see if we found the default
            if (string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(defValue))
                value = defValue;

            return value;
        }


        public static string Capitalize(this string input)
        {
            if (String.IsNullOrEmpty(input))
                return input;

            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1)).ToLower();
        }
        public static string CapitalizeAllWords(this string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
        public static bool IsEmailAddress(this string emailAddress)
        {
            System.Text.RegularExpressions.Regex regex =
                new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+&lt;(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})&gt;$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$");

            if (regex.IsMatch(emailAddress))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GeneratePassword(this string value, int length)
        {
            var chars = "AaBbCcDdEeFfGgHhJjKkMmNnPpQqRrSsTtUuVvWwXxYyZz23456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }
        public static string GetLocalPathFromRelativeUrl(this string url)
        {
            string uri = url.Replace(@"~/", "").Replace(@"/", @"\");
            string codebasePath = new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;

            return Path.Combine(Directory.GetParent(Path.GetDirectoryName(codebasePath)).FullName, uri);
        }

        public static string FullAddress(this string init, string lot, string ref1, string refnumber1, string number, string name, string suburb, string postcode)
        {
            string prefix = string.Empty;

            if (!string.IsNullOrEmpty(lot))
                //prefix = string.Format("LOT {0}", lot);
                prefix = lot;
            else if (!string.IsNullOrEmpty(ref1) && !string.IsNullOrEmpty(refnumber1))
            {
                prefix = string.Format("{0} {1}", ref1, refnumber1);
            }

            if (!string.IsNullOrEmpty(prefix))
                prefix += " ";

            if (!string.IsNullOrEmpty(number))
                number += " ";

            if (!string.IsNullOrEmpty(name))
                name += " ";

            if (!string.IsNullOrEmpty(suburb) && !string.IsNullOrEmpty(postcode))
                suburb += ", ";

            return string.Format("{0}{1}{2}{3}{4}", prefix, number, name, suburb, postcode);
        }
        public static string MakeFileNameSafe(this string input)
        {
            string invalidCharacters = String.Join("|", System.IO.Path.GetInvalidFileNameChars().Select(c => c.ToString()).ToList());
            return System.Text.RegularExpressions.Regex.Replace(input, "[\\|/|:|*|?|\"|<|>||]", "");
        }
        public static string Truncate(this string value, int maxLength)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }

            return value;
        }

        public static string RemoveNonAlphanumeric(this string value)
        {
            return new string(value.Where(c => char.IsDigit(c)).ToArray());
        }

    }
}