using System;
using System.Threading;

namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// Summary description for MpireUsername.
	/// </summary>
	public class MpireUsername
	{
		public MpireUsername()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Returns the Windows Username of the calling User.
		/// </summary>
		/// <remarks>Currently this function will return a hard-coded value, until the security framework is in place.</remarks>
		/// <returns></returns>
		public static string GetContextUsername()
		{
			string username = null;

			// Get the Username of the calling user
			username = Thread.CurrentPrincipal.Identity.Name;

			// Due to the Security Framework not yet being implemented, we will return a hard-coded value for now
			if (username == null || username == String.Empty)
				username = "CoreServer";

			// Return the Username
			return (username);
		}
	}
}
