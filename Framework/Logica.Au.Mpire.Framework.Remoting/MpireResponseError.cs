using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Text;

namespace Logica.Au.Mpire.Framework.Remoting
{

	[Serializable()]
	public class MpireResponseError
	{

		private string m_Source = null;
		private string m_Message = null;
		private MpireResponseErrorType m_Type = MpireResponseErrorType.Unknown;
		private DataValidationError m_ValidationError = null;

		public MpireResponseError(string message, string source, MpireResponseErrorType type)
		{

			this.m_Message = message;
			this.m_Source = source;
			this.m_Type = type;

		}

		public MpireResponseError(string message, string source)
		{

			this.m_Message = message;
			this.m_Source = source;
		
		}

		public MpireResponseError(string message, MpireResponseErrorType type)
		{

			this.m_Message = message;
			this.m_Type = type;

		}

		public MpireResponseError(string message)
		{

			this.m_Message = message;

		}
		
		public override string ToString()
		{
			
			string errorString = null;
			
			errorString = string.Format(
				"{0}, {1}: {2}",
				this.Type,
				this.Source,
				this.Message
				);
				
			return errorString;
			
		}

		public string Source
		{
			
			get
			{
				
				return m_Source;
			
			}

		}

		public string Message
		{

			get
			{
				
				return m_Message;
			
			}

		}
		
		public MpireResponseErrorType Type
		{

			get
			{

				return this.m_Type;

			}

		}

		public DataValidationError ValidationError
		{

			get
			{

				return this.m_ValidationError;

			}

			set
			{

				this.m_ValidationError = value;

			}

		}

	}

}
