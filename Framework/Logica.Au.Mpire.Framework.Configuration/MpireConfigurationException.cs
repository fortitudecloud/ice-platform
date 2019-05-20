using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Configuration;
using System;
using System.Runtime;
using System.Runtime.Serialization;

namespace Logica.Au.Mpire.Framework.Configuration
{

	public class MpireConfigurationException : Logica.Au.Mpire.Framework.MpireException
	{

		public MpireConfigurationException() : base()
		{
		}

		public MpireConfigurationException(string message) : base(message)
		{
		}

		public MpireConfigurationException(SerializationInfo info, StreamingContext context) :
			base(info, context)
		{
		}

		public MpireConfigurationException(string message, Exception innerException) :
			base(message, innerException)
		{
		}

	}

}