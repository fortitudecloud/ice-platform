using System;

namespace Logica.Au.Mpire.Framework.Definitions.Constants
{
	/// <summary>
	/// General constants that will be used in the Mpire application.
	/// </summary>
	public class MpireConstants
	{

		// This Constant should be used as a parameter when creating a new record that has an 
		// allocated Identifier (e.g. Customer.CustomerNo).
		public const string AllocatedIdentifier = "ALLOCATE";

		//this constant is to be used when a not null field requires a value ie relatedEntity in DeliveryAddress table
		public const string ValueNotSet = "NOTSET";

		public MpireConstants()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
