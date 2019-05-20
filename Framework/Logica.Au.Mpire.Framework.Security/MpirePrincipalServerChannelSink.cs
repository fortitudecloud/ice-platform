using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Security;
using System;
using System.Collections;
using System.IO;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace Logica.Au.Mpire.Framework.Security
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class MpirePrincipalServerChannelSink :
		System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties,
		System.Runtime.Remoting.Channels.IServerChannelSink
	{	

		private IServerChannelSink m_NextChannelSink;

		public MpirePrincipalServerChannelSink (IServerChannelSink next) 
		{

			this.m_NextChannelSink = next;

		}

		private bool IsInExclusionList(IMessage message)
		{

			string[] exclusionList = null;
			bool isInExclusionList = false;

			exclusionList = new string[16]
				{
					// HACK (GROSS) - Added another 5 Request types to the exclusion list so that we can get the CFE working - BJT 31/7/03
					// ANOTHER HACK (GROSS) - Added a lot more request types to this list - DKO 13/10/04, TT 5417
					// YET ANOTHER HACK - Added requests to the list for searching for a case and loading associated ServiceInstallations - DKO 03/02/06, TT 1817
					"Logica.Au.Mpire.CoreServer.CustomerFacade.Remoting.CreateWebCustomerRequest",
					"Logica.Au.Mpire.CoreServer.CustomerFacade.Remoting.SaveWebCustomerRequest",
					"Logica.Au.Mpire.CoreServer.CustomerFacade.Remoting.CreateCustomerRequest",
					"Logica.Au.Mpire.CoreServer.CustomerFacade.Remoting.SaveCustomerRequest",
					"Logica.Au.Mpire.CoreServer.CustomerFacade.Remoting.ResetCustomerPasswordRequest",
					"Logica.Au.Mpire.CoreServer.ListFacade.Remoting.LoadListRequest",
					"Logica.Au.Mpire.CoreServer.RoleFacade.Remoting.LoadRoleRequest",
					"Logica.Au.Ice.Processes.InformationStatementsFacade.Remoting.FinancialUpdateCaseSearchRequest",
					"Logica.Au.Ice.Processes.InformationStatementsFacade.Remoting.FinancialUpdateCaseUpdateRequest",
					"Logica.Au.Mpire.ProcessServer.QueueFacade.Remoting.ListCaseWorkItemsRequest",
					"Logica.Au.Mpire.CoreServer.DeliveryAddressFacade.Remoting.SaveDeliveryAddressRequest",
					"Logica.Au.Mpire.ProcessServer.QueueFacade.Remoting.ReleaseQueueItemsRequest",
					"Logica.Au.Mpire.CoreServer.SearchFacade.Remoting.SubmitCFECaseSearchRequest",
					"Logica.Au.Mpire.CoreServer.SearchFacade.Remoting.CreateCFECaseSearchCriteriaRequest",
					"Logica.Au.Ice.Processes.ProcessSupportingFacade.Remoting.LoadServiceInstallationRequest",
					"Logica.Au.Ice.Processes.ProcessSupportingFacade.Remoting.SaveServiceInstallationRequest",
				};


			MethodCall callerMethod = (MethodCall)message;
			string callerName = callerMethod.Args[0].ToString();

			if (Array.IndexOf(exclusionList, callerName) != -1)
			{
				isInExclusionList = true;

//				System.Diagnostics.Trace.WriteLine(
//					String.Format("MpirePrincipalServerChannelSink.IsInExclusionList : Caller Name = \"{0}\"; In exclusion list = {1}",
//					callerName,
//					true.ToString())
//					);
			}
            else if (callerName.EndsWith("External", StringComparison.CurrentCultureIgnoreCase))
            {
                // Added by Michael Pine, once I found this section of code if any of the above people were still around
                // here I was going to kill them, lucky you are gone DKO...!!! :)
                isInExclusionList = true;
            }
            else
            {

                isInExclusionList = false;

                //				System.Diagnostics.Trace.WriteLine(
                //					String.Format("MpirePrincipalServerChannelSink.IsInExclusionList : Caller Name = \"{0}\"; In exclusion list = {1}",
                //					callerName,
                //					false.ToString())
                //					);
            }

			return isInExclusionList;

		}

		public ServerProcessing ProcessMessage(
			IServerChannelSinkStack sinkStack,
			IMessage requestMsg,
			ITransportHeaders requestHeaders,
			Stream requestStream,
			out IMessage responseMsg,
			out ITransportHeaders responseHeaders,
			out Stream responseStream)
		{

			ServerProcessing serverProcessing = ServerProcessing.Complete;

			if (this.m_NextChannelSink != null)
			{

				if (this.IsInExclusionList(requestMsg) != true)
				{

					MpirePrincipalChannelHelper.AttachPrincipalToThread(requestMsg);

				}

				serverProcessing = this.m_NextChannelSink.ProcessMessage(
					sinkStack,
					requestMsg,
					requestHeaders,
					requestStream,
					out responseMsg,
					out responseHeaders,
					out responseStream
					);

			}
			else
			{

				responseMsg = null;
				responseHeaders = null;
				responseStream = null;

			}

			return serverProcessing;

		}

		public void AsyncProcessResponse(
			IServerResponseChannelSinkStack sinkStack,
			object state,
			IMessage msg,
			ITransportHeaders headers,
			Stream stream) 
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="sinkStack">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="state">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="msg">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="headers">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>	
		///		TODO: Insert documentation.
		/// </returns>
		public Stream GetResponseStream (
			IServerResponseChannelSinkStack sinkStack,
			object state,
			IMessage msg,
			ITransportHeaders headers ) 
		{
			
			return null;
		
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public IServerChannelSink NextChannelSink 
		{

			get
			{
				
				return this.m_NextChannelSink;
			
			}

			set
			{
				
				this.m_NextChannelSink = value;
			
			}

		}
	
	}

}