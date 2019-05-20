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
	public class MpirePrincipalServerChannelSinkProvider : 
		System.Runtime.Remoting.Channels.IServerChannelSinkProvider
	{

		private IServerChannelSinkProvider m_Next = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpirePrincipalServerChannelSinkProvider() 
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="properties">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="providerData">
		///		TODO: Insert documentation.
		/// </param>
		public MpirePrincipalServerChannelSinkProvider(IDictionary properties, ICollection providerData)
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="channelData">
		///		TODO: Insert documentation.
		/// </param>
		public void GetChannelData (IChannelDataStore channelData)
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="channel">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public IServerChannelSink CreateSink (IChannelReceiver channel)
		{

			IServerChannelSink nextSink = null;
			MpirePrincipalServerChannelSink sink = null;

			if (this.m_Next != null) 
			{

				nextSink = this.m_Next.CreateSink(channel);

			}

			sink = new MpirePrincipalServerChannelSink(nextSink);
//			sink.Properties = this.m_Properties;

			return sink;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public IServerChannelSinkProvider Next
		{

			get
			{
				
				return this.m_Next;
			
			}

			set
			{
				
				this.m_Next = value;
			
			}

		}

	}

}