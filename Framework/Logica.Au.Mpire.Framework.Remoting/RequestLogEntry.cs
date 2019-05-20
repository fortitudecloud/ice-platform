using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;

namespace Logica.Au.Mpire.Framework.Remoting
{

	[Serializable()]
	public class RequestLogEntry
	{

		private string myMessage = null;
		private string myDescription = null;
		private RequestLogEntryLevel myLevel = RequestLogEntryLevel.Verbose;
		private DateTime myTimeStamp = DateTime.Now;

		public RequestLogEntry(string message)
		{

			this.Message = message;

		}

		public RequestLogEntry(string message, DateTime timeStamp)
		{

			this.Message = message;
			this.TimeStamp = timeStamp;

		}

		public RequestLogEntry(string message, RequestLogEntryLevel level)
		{
		
			this.Message = message;
			this.Level = level;

		}

		public RequestLogEntry(string message, RequestLogEntryLevel level, DateTime timeStamp)
		{
			
			this.Message = message;
			this.Level = level;
			this.TimeStamp = timeStamp;

		}

		public RequestLogEntry(string message, string description)
		{

			this.Message = message;
			this.Description = description;

		}

		public RequestLogEntry(string message, string description, DateTime timeStamp)
		{

			this.Message = message;
			this.Description = description;
			this.TimeStamp = timeStamp;

		}

		public RequestLogEntry(string message, string description, RequestLogEntryLevel level)
		{

			this.Message = message;
			this.Description = description;
			this.Level = level;

		}

		public RequestLogEntry(string message, string description, RequestLogEntryLevel level, DateTime timeStamp)
		{
	
			this.Message = message;
			this.Description = description;
			this.Level = level;
			this.TimeStamp = timeStamp;

		}

		public string Message
		{

			get
			{

				return this.myMessage;

			}

			set
			{

				this.myMessage = value;

			}

		}

		public string Description
		{

			get
			{

				return this.myDescription;

			}

			set
			{

				this.myDescription = value;

			}

		}

		public RequestLogEntryLevel Level
		{

			get
			{

				return this.myLevel;

			}

			set
			{

				this.myLevel = value;

			}

		}

		public DateTime TimeStamp
		{

			get
			{

				return this.myTimeStamp;

			}

			set
			{

				this.myTimeStamp = value;

			}

		}

		public override string ToString()
		{

			return new OutOfMemoryException().ToString();			

		}

	}

}