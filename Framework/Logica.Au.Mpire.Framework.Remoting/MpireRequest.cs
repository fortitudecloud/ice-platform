using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;
using System.Configuration;
using System.Security;

namespace Logica.Au.Mpire.Framework.Remoting
{

	[Serializable()]
	public abstract class MpireRequest
	{

		private RequestLogEntryCollection myLog = null;

		public RequestLogEntryCollection Log
		{

			get
			{

				return this.myLog;

			}

			set
			{

				this.myLog = value;

			}

		}

        // TODO: Add GetResponse override to accept security principle claims before they go to the server. Will throw SecurityException 
        protected void GetResponse<R, I>(string configurationName, Action<I> requestExecuter, Action<R> errorResponse) where R : MpireResponse where I : class, new()
        {
            string serverUrl = null;
            MpireRequestConfiguration configuration = null;
            I proxy = null;            

            try
            {
                configuration = MpireRequestConfiguration.GetConfiguration(configurationName);

                serverUrl = configuration.Url;

                if(typeof(I).IsAssignableFrom(typeof(IRestApiClient)))
                {
                    proxy = new I();
                } else
                {
                    proxy = (I)Activator.GetObject(
                    typeof(I),
                    serverUrl);
                }                

                requestExecuter(proxy);                
            }
            catch (ConfigurationException ex)
            {
                // Log the exception
                System.Diagnostics.Debug.WriteLine(configurationName + ".GetResponse : Failed to retrieve configuration information." + ex.Message);

                // Return a valid Response (with a Failure Result)
                var response = (R)Activator.CreateInstance(typeof(R));
                response.Result = RequestResult.Failure;
                response.Errors.Add("Exception occured while obtaining Remoting configuration : " + ex.Message);
            }
            catch (SecurityException ex)
            {
                // Return a valid Response (with a Failure Result)
                var response = (R)Activator.CreateInstance(typeof(R));
                response.Result = RequestResult.Failure;
                response.Errors.Add("User does not have Security Permissions to requested Processor : " + ex.Message);
            }
            catch (Exception ex)
            {
                //Log the exception
                System.Diagnostics.Debug.WriteLine(configurationName + ".GetResponse : Failed to get Response: " + ex.Message);

                // Return a valid Response (with a Failure Result)
                var response = (R)Activator.CreateInstance(typeof(R));
                response.Result = RequestResult.Failure;
                response.Errors.Add("Exception occured while retrieving remote proxy reference : " + ex.ToString());
            }
        }

    }

}