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
	public class MpirePrincipalClientChannelSink :
		System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties,
		System.Runtime.Remoting.Channels.IClientChannelSink,
		System.Runtime.Remoting.Messaging.IMessageSink
	{	

		private IClientChannelSink m_NextChannelSink = null;
		private IMessageSink m_NextSink = null;

		public MpirePrincipalClientChannelSink (object next) 
		{

			this.m_NextChannelSink = next as IClientChannelSink;
			this.m_NextSink = next as IMessageSink;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="msg">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="replySink">
		///		TODO: Insert documetnation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) 
		{

			IMessageCtrl messageCtrl = null;

			messageCtrl = this.m_NextSink.AsyncProcessMessage(msg, replySink);

			return messageCtrl;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="msg">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public IMessage SyncProcessMessage(IMessage msg) 
		{

			IMessage message = null;

			MpirePrincipalChannelHelper.AttachPrincipalToContext(msg);

			message = this.m_NextSink.SyncProcessMessage(msg);

			return message;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="sinkStack">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="msg">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="headers">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="stream">
		///		TODO: Insert documentation.
		/// </param>
		public void AsyncProcessRequest(
			IClientChannelSinkStack sinkStack,
			IMessage msg,
			ITransportHeaders headers,
			Stream stream) 
		{

			throw new NotSupportedException("The MpirePrincipalClientChannelSink cannot be used as a transport sink.");

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
		/// <param name="headers">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="stream">	
		///		TODO: Insert documentation.
		/// </param>
		public void AsyncProcessResponse(
			IClientResponseChannelSinkStack sinkStack,
			object state,
			ITransportHeaders headers, 
			Stream stream)
		{

			throw new NotSupportedException("The MpirePrincipalClientChannelSink cannot be used as a transport sink.");

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="msg">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="headers">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public Stream GetRequestStream(
			IMessage msg,
			ITransportHeaders headers)
		{

			throw new NotSupportedException("The MpirePrincipalClientChannelSink cannot be used as a transport sink.");

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="msg">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="requestHeaders">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="requestStream">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="responseHeaders">
		///		TODO: Insert documetnation.
		/// </param>
		/// <param name="responseStream">
		///		TODO: Insert documentation.
		/// </param>
		public void ProcessMessage(
			IMessage msg,
			ITransportHeaders requestHeaders,
			Stream requestStream,
			out ITransportHeaders responseHeaders,
			out Stream responseStream)
		{

			throw new NotSupportedException("The MpirePrincipalClientChannelSink cannot be used as a transport sink.");

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public IMessageSink NextSink 
		{
			get
			{
				
				return this.m_NextSink;;
			
			}

		}

		/// <summary>
		///		TODO: Insert documetnation.
		/// </summary>
		public IClientChannelSink NextChannelSink 
		{ 

			get
			{
				
				return this.m_NextChannelSink;
			
			}

		}

	}

}