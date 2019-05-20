using System;
using System.Text.RegularExpressions;

namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// Summary description for MpireGuid.
	/// </summary>
	public class MpireGuid
	{
		public MpireGuid()
		{
		}

		/// <summary>
		/// Returns a new, uppercase Guid, compliant with the Mpire Identifier standard.
		/// </summary>
		/// <returns></returns>
		public static string NewGuid()
		{
			string newGuid = null;

			newGuid = Guid.NewGuid().ToString().ToUpper();

			// Return the new Guid
			return (newGuid);
		}

        /// <summary>
        /// Attempts to convert a string to a GUID by first validating against a regex and then
        /// creating a new GUID if the string matches the regex.  Returns true if it succeeds.
        /// The output parameter will be a new GUID if successful, or an empty GUID if not.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        ///        Thrown if <pararef name="s"/> is <see langword="null"/>.
        /// </exception>
        [Obsolete("Replace this with the standard .NET Guid.TryParse method when the target framework is upgraded to .NET 4.x")]
        public static bool TryParse(string s, out Guid result)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            Regex format = new Regex(
                "^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
            Match match = format.Match(s);
            if (match.Success)
            {
                result = new Guid(s);
                return true;
            }
            else
            {
                result = Guid.Empty;
                return false;
            }
        }
	}
}
