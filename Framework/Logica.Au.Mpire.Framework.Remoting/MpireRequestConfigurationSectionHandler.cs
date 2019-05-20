using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;
using System.Configuration;
using System.Xml;

namespace Logica.Au.Mpire.Framework.Remoting
{

	public class MpireRequestConfigurationSectionHandler : IConfigurationSectionHandler
	{

		public object Create(object parent, object configContext, XmlNode section)
		{
		
			MpireRequestConfigurationCollection configs = null;
			XmlAttribute requestName = null;
			XmlAttribute requestUrl = null;
			XmlAttribute parameterName = null;
			XmlAttribute parameterValue = null;

			configs = new MpireRequestConfigurationCollection();

			// Enumerate over each of the child elements in the configuration section.
			foreach (XmlNode configuration in section.ChildNodes)
			{

				// Zoom in on the ones that are elements named "request".
				if ((configuration.Name == "request") && (configuration.NodeType == XmlNodeType.Element))
				{

					// Grab the two recognised attributes.
					requestName = configuration.Attributes["name"];
					requestUrl = configuration.Attributes["url"];

					// Make sure the request name is valid.
					if ((requestName == null) || (requestName.Value == string.Empty))
					{

						throw new ConfigurationErrorsException(
							"Request name attribute not specified or incorrectly specified.",
							configuration
							);

					}

					// Make sure the request url is valid.
					if ((requestUrl == null) || (requestUrl.Value == string.Empty))
					{

						throw new ConfigurationErrorsException(
							"Request url attribute not specified or incorrectly specified.",
							configuration
							);

					}

					// Add the config entry to the collection.
					configs.Add(
						requestName.Value,
						new MpireRequestConfiguration()
						);

					// Set its URL.
					configs[requestName.Value].Url = requestUrl.Value;

					// Enumerate over the parameters for this individual request.
					foreach (XmlNode parameter in configuration.ChildNodes)
					{

						// Make sure its a valid element.
						if ((parameter.Name == "parameter") && (parameter.NodeType == XmlNodeType.Element))
						{

							// Grab the recognised attributes.
							parameterName = parameter.Attributes["name"];
							parameterValue = parameter.Attributes["value"];

							// Make sure the name is valid.
							if ((parameterName == null) || (parameterName.Value == string.Empty))
							{

								throw new ConfigurationErrorsException(
									"Parameter name attribute not specified or specified incorrectly.",
									parameter
									);

							}

							// Make sure the value is valid.
							if ((parameterValue == null) || (parameterValue.Value == string.Empty))
							{

								throw new ConfigurationErrorsException(
									"Parameter value attribute not specified or specified incorrectly.",
									parameter
									);

							}

							// Add the parameter to the current request configuration.
							configs[requestName.Value].Parameters.Add(
								parameterName.Value,
								parameterValue.Value
								);

						}

					}																  

				}

			}

			return configs;

		}

	}

}