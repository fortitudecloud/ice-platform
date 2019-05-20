using System;

namespace Logica.Au.Mpire.Framework.Definitions.Constants
{

	/// <summary>
	/// These string values represent the security roles used by the Front End to check against required rights.
	/// </summary>
	/// <author>Patrick Bettels</author>
	/// <date>3/04/2003 1:56:47 PM</date>
	public struct  SecurityRole
	{
		public const string UserRead = "ICE Users Read";
		public const string UserWrite = "ICE Users Write";
		public const string AdminRead = "ICE Admins Read";
		public const string AdminWrite = "ICE Admins Write";

		// DAL 14/4/2004  For Service Installation/Removal search screen
		public const string ServicesReset = "ICE Services Reset";

        // michael pine, to control access to the Remote Meter Flag button
        public const string ServicesUser = "ICE Services User";

        // To control access to the credit note status dropdown and update button
        public const string FinanceAdmin = "ICE Finance Admin";
    }
}
