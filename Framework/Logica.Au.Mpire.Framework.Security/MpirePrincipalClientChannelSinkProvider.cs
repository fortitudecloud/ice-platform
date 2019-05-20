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
	public class MpirePrincipalClientChannelSinkProvider : 
		System.Runtime.Remoting.Channels.IClientChannelSinkProvider
	{

		private IClientChannelSinkProvider m_Next = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpirePrincipalClientChannelSinkProvider() 
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="properties"></param>
		/// <param name="providerData"></param>
		public MpirePrincipalClientChannelSinkProvider(IDictionary properties, ICollection providerData)
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="channel">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="url">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="remoteChannelData">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public IClientChannelSink CreateSink(
			IChannelSender channel,
			string url,
			object remoteChannelData)
		{

			IClientChannelSink nextSink = null;
			MpirePrincipalClientChannelSink sink = null;

			nextSink = this.m_Next.CreateSink(channel, url, remoteChannelData);
			sink = new MpirePrincipalClientChannelSink(nextSink);

			return sink;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public IClientChannelSinkProvider Next
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