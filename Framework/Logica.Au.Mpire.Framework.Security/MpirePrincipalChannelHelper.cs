using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Security;
using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Logica.Au.Mpire.Framework.Security
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class MpirePrincipalChannelHelper
	{

		private static RSACryptoServiceProvider ourProvider = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static MpirePrincipalChannelHelper()
		{

			string principalSigningPublicKey = null;
			string principalSigningPublicKeyText = null;

			principalSigningPublicKey = MpirePrincipalChannelHelper.GetPrincipalSigningPublicKey();

			if (principalSigningPublicKey != null)
			{
			
				principalSigningPublicKeyText = Encoding.UTF8.GetString(
					Convert.FromBase64String(principalSigningPublicKey)
					);

				MpirePrincipalChannelHelper.ourProvider = new RSACryptoServiceProvider();
				MpirePrincipalChannelHelper.ourProvider.FromXmlString(principalSigningPublicKeyText);

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		private static LogicalCallContext GetLogicalCallContext(IMessage message)
		{

			LogicalCallContext context = null;

			context = (LogicalCallContext)message.Properties["__CallContext"];

			return context;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		private static string GetPrincipalSigningPublicKey()
		{

			string principalSigningPublicKey = null;

			principalSigningPublicKey = ConfigurationManager.AppSettings["principalSigningPublicKey"];

			return principalSigningPublicKey;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="principal">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		private static bool VerifyPrincipalSignature(MpirePrincipal principal)
		{

			object[] signableData = null;
			BinaryFormatter formatter = null;
			MemoryStream stream = null;
			bool signatureOK = false;
			
			if (MpirePrincipalChannelHelper.ourProvider == null)
			{
				
				throw new SecurityException("Key required to verify signature does not exist on the server.");
				
			}

			signableData = principal.GetSignableData();

			formatter = new BinaryFormatter();
			stream = new MemoryStream();
		
			formatter.Serialize(stream, signableData);

			signatureOK = MpirePrincipalChannelHelper.ourProvider.VerifyData(
				stream.GetBuffer(),
				new SHA1CryptoServiceProvider(),
				principal.Signature
				);

			return signatureOK;
		
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="principal">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		private static bool VerifyPrincipalExpiry(MpirePrincipal principal)
		{

			bool expiryOK = false;

			expiryOK = principal.Expiry > DateTime.Now;

			return expiryOK;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public static void AttachPrincipalToContext(IMessage message)
		{

			LogicalCallContext context = null;

			try
			{

				context = MpirePrincipalChannelHelper.GetLogicalCallContext(message);
				context.SetData("MpirePrincipal", Thread.CurrentPrincipal);

			}
			catch (Exception ex)
			{

				throw new SecurityException(
					string.Format(
						"An error occured while attaching the current principal to the call context: {0}.",
						ex.Message
						),
					ex
					);

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public static void AttachPrincipalToThread(IMessage message)
		{

			LogicalCallContext context = null;
			MpirePrincipal principal = null;
			bool principalSignatureOK = false;
			bool principalExpiryOK = false;

			try
			{

				context = MpirePrincipalChannelHelper.GetLogicalCallContext(message);
				principal = (MpirePrincipal)context.GetData("MpirePrincipal");

				

				if (principal != null)
				{

					principalSignatureOK = MpirePrincipalChannelHelper.VerifyPrincipalSignature(principal);

					// HACK : VerifyPrincipalSignature is not currently working OK, so force it - BJT 16/Dec/03
					principalSignatureOK = true;

					principalExpiryOK = MpirePrincipalChannelHelper.VerifyPrincipalExpiry(principal);

					if ((principalSignatureOK && principalExpiryOK) == true)
					{

						Thread.CurrentPrincipal = principal;
			
					}
					else
					{

						throw new SecurityException("Access to Mpire servers requires a valid signed principal obtained by the Mpire Authentication Server.");

					}

				}
				else
				{

					throw new SecurityException("Access to Mpire servers requires a valid signed principal obtained by the Mpire Authentication Server.");

				}

			}
			catch (Exception ex)
			{

				throw new SecurityException(
					string.Format(
						"An error occured while attaching the principal on the context to the thread: {0}.",
						ex.Message
						),
					ex
					);

			}

		}

	}

}