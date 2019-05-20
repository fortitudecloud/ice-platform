using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Configuration;
using Logica.Au.Mpire.Framework.Configuration.Install;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace Logica.Au.Mpire.Framework.Configuration.Install
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class ConfigurationFileInstaller : System.Configuration.Install.Installer
	{

		private StringCollection m_AllowedTokens = null;
		private string m_ConfigurationFile = null;
		private bool m_Filter = false;

		public ConfigurationFileInstaller()
		{

			this.m_AllowedTokens = new StringCollection();
			this.m_ConfigurationFile = this.GetDefaultConfigurationFile();

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		private string DetermineConfigurationFile()
		{

			string configurationFile = null;

			configurationFile = this.m_ConfigurationFile;
			if (File.Exists(configurationFile) == false)
			{

				configurationFile = string.Format(
					@"{0}\{1}",
					Environment.CurrentDirectory,
					this.m_ConfigurationFile
					);
				if (File.Exists(configurationFile) == false)
				{

					configurationFile = string.Format(
						@"{0}\{1}",
						new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName,
						this.m_ConfigurationFile
						);
					if (File.Exists(configurationFile) == false)
					{

						configurationFile = null;

					}

				}

			}

			return configurationFile;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		private string GetDefaultConfigurationFile()
		{

			string configurationFile = null;

			configurationFile = string.Format(
				"{0}.config",
				Assembly.GetExecutingAssembly().Location
				);

			return configurationFile;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="tokenName">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="tokenValue">
		///		TODO: Insert documentation.
		/// </param>
		private void UpdateConfigurationFile(string tokenName, string tokenValue)
		{

			string configurationFile = null;
			StreamReader reader = null;
			string configurationData = null;
			StreamWriter writer = null;

			configurationFile = this.DetermineConfigurationFile();

			if (configurationFile != null)
			{

				// Read configuration file.
				reader = new StreamReader(configurationFile);
				configurationData = reader.ReadToEnd();
				reader.Close();

				// Modify configuration file.
				configurationData = configurationData.Replace(
					string.Format("[{0}]", tokenName).ToLower(),
					tokenValue
					);

				// Write configuration file.
				writer = new StreamWriter(configurationFile);
				writer.Write(configurationData);
				writer.Flush();
				writer.Close();

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="stateSaver">
		///		TODO: Insert documentation.
		/// </param>
		public override void Install(IDictionary stateSaver)
		{

			string tokenKey = null;
			string tokenValue = null;

			base.Install(stateSaver);

			foreach (DictionaryEntry entry in this.Context.Parameters)
			{

				tokenKey = (string)entry.Key;
				tokenValue = (string)entry.Value;

				if ((this.m_AllowedTokens.Contains(tokenKey) == true) ||
					(this.m_Filter == false))
				{

					this.UpdateConfigurationFile(
						tokenKey,
						tokenValue
						);

				}

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public StringCollection AllowedTokens
		{

			get
			{

				return this.m_AllowedTokens;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string ConfigurationFile
		{

			get
			{

				return this.m_ConfigurationFile;

			}

			set
			{

				this.m_ConfigurationFile = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public bool Filter
		{

			get
			{

				return this.m_Filter;

			}

			set
			{

				this.m_Filter = value;

			}

		}

	}

}