using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;
using System.Configuration;

namespace Logica.Au.Mpire.Framework.Remoting
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class MpireRequestConfiguration
	{

		private string myUrl = null;
		private MpireRequestConfigurationParameterCollection myParameters = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpireRequestConfiguration()
		{

			this.myParameters = new MpireRequestConfigurationParameterCollection();

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="requestName">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public static MpireRequestConfiguration GetConfiguration(string requestName)
		{

			MpireRequestConfigurationCollection configurations = null;
			MpireRequestConfiguration configuration = null;

			// Load the configuration data from the config section handler.
			configurations = (MpireRequestConfigurationCollection)ConfigurationManager.GetSection("logica.au.mpire/requests");
			if(configurations == null)
			{

				throw new ConfigurationErrorsException( "Failed to load 'logica.au.mpire/requests' configuration. Is the application configuration file missing?" );

			}

			// Get the individual configuration from the configuration data.
			configuration = configurations[requestName];
			if (configuration == null)
			{

				throw new ConfigurationErrorsException(
					string.Format(
						"Failed to load 'logica.au.mpire/requests/request[@name={0}]'. Configuration file may be invalid.",
						requestName
						)
					);

			}

			return configuration;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string Url
		{

			get
			{

				return this.myUrl;

			}

			set
			{

				this.myUrl = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpireRequestConfigurationParameterCollection Parameters
		{

			get
			{

				return this.myParameters;

			}

			set
			{

				this.myParameters = value;

			}

		}

	}

}