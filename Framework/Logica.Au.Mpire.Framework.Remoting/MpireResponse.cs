// FIXME: Insert tracing code.

using System;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;

namespace Logica.Au.Mpire.Framework.Remoting
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public abstract class MpireResponse
	{

		private Exception myException = null;
		private MpireResponseErrorCollection myErrors = null;
		private RequestResult myResult = RequestResult.Unknown;
		private RequestFailureReason myFailReason = RequestFailureReason.None;
		private string myFailReasonText = null;


		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpireResponse()
		{
			
			// Initialise Error Collection
			myErrors = new MpireResponseErrorCollection();

		}


		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[Obsolete("This is a security risk. Use the Errors collection instead.", false)]
		public Exception Exception
		{
			get
			{

				return this.myException;

			}

			set
			{
		
				this.myException = value;

			}
		}


		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public RequestResult Result
		{
			get
			{
				return this.myResult;
			}

			set
			{
				this.myResult = value;
			}
		}


		public RequestFailureReason FailureReason
		{
			get
			{
				return this.myFailReason;
			}

			set
			{
				this.myFailReason = value;
			}
		}

		public string FailureReasonText
		{
			get
			{
				return this.myFailReasonText;
			}

			set
			{
				this.myFailReasonText = value;
			}
		}




		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpireResponseErrorCollection Errors
		{
			get
			{
				return this.myErrors;
			}
		}

	}

}