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

        /// <summary>
        /// Gets a response from the remote endpoint. Handles cross cutting concerns
        /// </summary>
        /// <typeparam name="R">Response object to return</typeparam>
        /// <typeparam name="I">Endpoint proxy object to consume</typeparam>
        /// <param name="configurationName">Request configuration name</param>
        /// <param name="requestExecuter">Remoting callout implementation</param>
        /// <param name="securityDemand"></param>
        /// <returns>Typed Response Object</returns>
        protected R GetResponse<R, I>(string configurationName, Action<I> requestExecuter, string[] securityDemand) where R : MpireResponse where I : class, new()
        {
            // If the security demand is not satisfied, throw a SecurityException to the client caller

            bool secure = false, demands = securityDemand != null && securityDemand.Length > 0;

            if(demands)
            {
                foreach(var demand in securityDemand)
                {
                    if(System.Threading.Thread.CurrentPrincipal.IsInRole(demand))
                    {
                        secure = true;
                    }
                }

                if(!secure)
                {
                    var response = (R)Activator.CreateInstance(typeof(R));

                    CreateSecurityExceptionResponse(response, "Failed pre-flight check");

                    return response;
                }
            }

            return GetResponse<R, I>(configurationName, requestExecuter);
        }
        
        /// <summary>
        /// Gets a response from the remote endpoint. Handles cross cutting concerns
        /// </summary>
        /// <typeparam name="R">Response object to return</typeparam>
        /// <typeparam name="I">Endpoint proxy object to consume</typeparam>
        /// <param name="configurationName">Request configuration name</param>
        /// <param name="requestExecuter">Remoting callout implementation</param>
        /// <returns>Typed Response Object</returns>
        protected R GetResponse<R, I>(string configurationName, Action<I> requestExecuter) where R : MpireResponse where I : class, new()
        {
            string serverUrl = null;
            MpireRequestConfiguration configuration = null;
            I proxy = null;
            var response = (R)Activator.CreateInstance(typeof(R));

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

                response.Result = RequestResult.Success;                
            }
            catch (ConfigurationException ex)
            {
                // Log the exception
                System.Diagnostics.Debug.WriteLine(configurationName + ".GetResponse : Failed to retrieve configuration information." + ex.Message);

                CreateConfigurationExceptionResponse(response, ex.Message);
            }
            catch (SecurityException ex)
            {
                CreateSecurityExceptionResponse(response, ex.Message);
            }
            catch (Exception ex)
            {
                //Log the exception
                System.Diagnostics.Debug.WriteLine(configurationName + ".GetResponse : Failed to get Response: " + ex.Message);

                CreateGeneralExceptionResponse(response, ex.ToString());
            }

            return response;
        }

        #region Response helpers
        private void CreateConfigurationExceptionResponse<R>(R response, string message) where R : MpireResponse
        {
            // Return a valid Response (with a Failure Result)                
            response.Result = RequestResult.Failure;
            response.Errors.Add("Exception occured while obtaining Remoting configuration : " + message);
        }

        private void CreateSecurityExceptionResponse<R>(R response, string message) where R : MpireResponse
        {
            // Return a valid Response (with a Failure Result)                
            response.Result = RequestResult.Failure;
            response.Errors.Add("User does not have Security Permissions to requested Processor : " + message);
        }

        private void CreateGeneralExceptionResponse<R>(R response, string message) where R : MpireResponse
        {
            // Return a valid Response (with a Failure Result)                
            response.Result = RequestResult.Failure;
            response.Errors.Add("Exception occured while retrieving remote proxy reference : " + message);
        }
        #endregion

    }

}