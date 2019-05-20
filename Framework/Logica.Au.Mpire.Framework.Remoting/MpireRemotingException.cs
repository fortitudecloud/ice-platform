using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;
using System.Runtime;
using System.Runtime.Serialization;

namespace Logica.Au.Mpire.Framework.Remoting
{

	public class MpireRemotingException : Logica.Au.Mpire.Framework.MpireException
	{

		public MpireRemotingException() : base()
		{
		}

		public MpireRemotingException(string message) : base(message)
		{
		}

		public MpireRemotingException(SerializationInfo info, StreamingContext context) :
			base(info, context)
		{
		}

		public MpireRemotingException(string message, Exception innerException) :
			base(message, innerException)
		{
		}

	}

}