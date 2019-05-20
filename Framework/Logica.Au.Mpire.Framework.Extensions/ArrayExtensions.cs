using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Logica.Au.Mpire.Framework.Extensions
{
    public static class MpireExtensions
    {
        public static string Join(this System.Array array)
        {
            return Join(array, ',');
        }

        public static string Join(this System.Array array, char seperator)
        {
            string output = null;
            foreach (string obj in array)
            {
                output += (obj.ToString() + seperator);
            }
            // strip the last seperator character if an array with items was passed in
            if ((output != null) && (output.Length > 0))
                output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
