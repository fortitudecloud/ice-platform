using System;
using System.Threading;
using System.Diagnostics;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using Logica.Au.Mpire.Framework.Diagnostics;

namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// ProcessWaitTimeoutException will be thrown when the ProcessSingleton cannot indicate that no other 
	/// instances of a given Process (or Processes) are running on the system within the given timeout.
	/// </summary>
	public class ProcessWaitTimeoutException : ApplicationException
	{
		public ProcessWaitTimeoutException() : base()
		{
		}

		public ProcessWaitTimeoutException(string message) : base(message)
		{
		}

		public ProcessWaitTimeoutException(string message, System.Exception innerException) : base(message, innerException)
		{
		}
	}


	public class ProcessSingletonConfigSettings
	{
		public string[] ProcessNames = null;
		public int WaitPeriodMs = 0;
		public int RetryTimes = 0;
		public bool KillProcess = false;
	}


	public class ProcessSingleton
	{
		private static DiagnosticSwitch diagnosticSwitch = null;
		
		private string[] m_processNames = null;
		private int m_waitPeriodMs = 0;
		private int m_retryTimes = 0;
		private bool m_killProcess = false;

		static ProcessSingleton()
		{
			diagnosticSwitch = new DiagnosticSwitch
				( "ProcessSingleton"
				, new string[] { "ProcessSingleton" } );
		}

		// Hide the default ctor
		private ProcessSingleton()
		{
		}


		public ProcessSingleton(ProcessSingletonConfigSettings settings)
			: this(settings.ProcessNames, settings.WaitPeriodMs, settings.RetryTimes, settings.KillProcess)
		{
		}


		public ProcessSingleton(string processName, int waitPeriodMs, int retryTimes, bool killProcess)
			: this(new string[] {processName}, waitPeriodMs, retryTimes, killProcess)
		{
		}


		public ProcessSingleton(string[] processNames, int waitPeriodMs, int retryTimes, bool killProcess)
		{
			#region Validate the arguments
			if (processNames == null)
				throw (new ArgumentNullException("Argument \"processNames\" cannot be null"));

			if (processNames.Length == 0)
				throw (new ArgumentException("Argument \"processNames\" cannot be an empty array"));

			foreach (string processName in processNames)
			{
				if (processName == null)
					throw (new ArgumentNullException("Argument \"processNames\" cannot contain a null string"));

				if (processName == String.Empty)
					throw (new ArgumentException("Argument \"processNames\" cannot contain an empty string"));
			}

			if (waitPeriodMs <= 0)
				throw (new ArgumentException("Argument \"waitPeriodMs\" must be greater than zero"));

			if (retryTimes < 0)
				throw (new ArgumentException("Argument \"retryTimes\" must not be less than zero"));
			#endregion
			
			m_processNames = processNames;
			m_waitPeriodMs = waitPeriodMs;
			m_retryTimes = retryTimes;
			m_killProcess = killProcess;
		}


		public void WaitForProcessEnd()
		{
			int loopCount = 0;
			bool keepLooping = false;
			Process[] processes = null;

			do
			{
				// Get the list of processes for the given names
				processes =  this.GetProcessList(m_processNames);

				// If we have at least one process, and we are going to loop again
				if (processes.Length != 0 && loopCount < m_retryTimes)
				{
					#region Tracing . . .
					if(diagnosticSwitch.TraceVerbose == true)
					{
						TraceHelper.WriteVerbose(
							"Waiting on {0} running Process(es) to terminate [# of retries : {1}]",
							processes.GetLength(0),
							loopCount
							);
					}
					#endregion

					// Send this current thread to sleep for a while
					Thread.Sleep(m_waitPeriodMs);

				}

				// Keep going while we have Processes still live and we can still retry
				keepLooping = (processes.Length > 0 && loopCount < m_retryTimes);

				// Increment the try counter
				loopCount++;

			} while (keepLooping);

			// If we still have any processes at this point, we have to do something about it!!!
			if (processes.Length != 0)
			{
				if (m_killProcess)
				{
					// We have to kill all the Process instances
					foreach (Process process in processes)
					{
						// Log an error so that it gets into the Event Log
						TraceHelper.WriteError(
							"Forcibly killing off Process \"{0}\" [ProcessID : {1}]",
							process.ProcessName,
							process.Id
							);

						// Kaaa-chop!!!
						process.Kill();

						#region Tracing . . .
						if(diagnosticSwitch.TraceVerbose == true)
						{
							TraceHelper.WriteVerbose(
								"Process successfully killed."
								);
						}
						#endregion
					}
				}
				else
				{
					// Here is where we throw an exception
			
					#region Tracing . . .
					if(diagnosticSwitch.TraceVerbose == true)
					{
						TraceHelper.WriteVerbose(
							"Processes did not terminate within allowed timeout.  Throwing new {0}",
							typeof(ProcessWaitTimeoutException).Name
							);
					}
					#endregion

					string processList = null;

					foreach (Process process in processes)
					{
						processList += String.Format(
							"[\"{0}\" (Process ID:{1})]",
							process.ProcessName,
							process.Id);
					}
	
					string msg = String.Format("The Process (or Processes) \"{0}\" did not terminate within the allowed timeframe.  Unable to proceed while these Processes are running on the system.",
						processList
						);

					// Throw the exception
					throw (new ProcessWaitTimeoutException(msg));

				}
			}

		}


		// Return an array of Process object for a given array of Process Names
		private Process[] GetProcessList(string[] processNames)
		{
			ArrayList list = new ArrayList();
			Process[] processArray = null;

			foreach (string processName in processNames)
			{
				// Need to copy processName, as we might modify it!
				string thisProcessName = processName;

				if (thisProcessName.ToLower().EndsWith(".exe"))
					// Trim off the .exe, as we dont need it
					thisProcessName = thisProcessName.Substring(thisProcessName.Length - ".exe.".Length);

				#region Tracing . . .
				if(diagnosticSwitch.TraceVerbose == true)
				{
					TraceHelper.WriteVerbose(
						"Checking for running Processes named \"{0}\"",
						thisProcessName
						);
				}
				#endregion

				Process[] processList = Process.GetProcessesByName(thisProcessName);

				#region Tracing . . .
				if(diagnosticSwitch.TraceVerbose == true)
				{
					TraceHelper.WriteVerbose(
						"Found {0} running Process instances",
						processList.GetLength(0)
						);
				}
				#endregion
				
				list.AddRange(processList);
			}

			if (list.Count > 0)
			{
				// Convert the generic list array to an array of Process
				processArray = (Process[])list.ToArray(typeof(Process));
			}
			else
			{
				// Return an empty array
				processArray = new Process[0];
			}

			// Return the array
			return (processArray);
		}


		public static ProcessSingletonConfigSettings ParseConfigSettings(NameValueCollection appSettings)
		{
			ProcessSingletonConfigSettings settings = new ProcessSingletonConfigSettings();

			string processNamesVal = appSettings["ProcessSingletonNames"];

			// Validate the ProcessSingletonNames config value
			if (processNamesVal == null || processNamesVal == String.Empty)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"The required configuration setting \"{0}\" does not exist",
					"ProcessSingletonNames"))
					);
			}

			// Set the Names setting by splitting the config entry by pipes
			settings.ProcessNames = processNamesVal.Split(new char[] {'|'});



			string waitPeriodMsVal = appSettings["ProcessSingletonWaitMs"];

			// Validate the ProcessSingletonWaitMs config value
			if (waitPeriodMsVal == null || waitPeriodMsVal == String.Empty)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"The required configuration setting \"{0}\" does not exist",
					"ProcessSingletonWaitMs"))
					);
			}

			try
			{
				settings.WaitPeriodMs = int.Parse(waitPeriodMsVal);
			}
			catch (FormatException)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"Unable to convert the configuration setting \"{0}\" to the required type '{1}'",
					"ProcessSingletonWaitMs",
					settings.WaitPeriodMs.GetType().FullName))
					);
			}


			string retryTimesVal = appSettings["ProcessSingletonRetries"];

			// Validate the ProcessSingletonRetries config value
			if (retryTimesVal == null || retryTimesVal == String.Empty)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"The required configuration setting \"{0}\" does not exist",
					"ProcessSingletonRetries"))
					);
			}

			try
			{
				settings.RetryTimes = int.Parse(retryTimesVal);
			}
			catch (FormatException)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"Unable to convert the configuration setting \"{0}\" to the required type '{1}'",
					"ProcessSingletonRetries",
					settings.RetryTimes.GetType().FullName))
					);
			}

			
			
			string killProcessVal = appSettings["ProcessSingletonKillProcess"];

			// Validate the ProcessSingletonKillProcess config value
			if (killProcessVal == null || killProcessVal == String.Empty)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"The required configuration setting \"{0}\" does not exist",
					"ProcessSingletonKillProcess"))
					);
			}

			try
			{
				settings.KillProcess = bool.Parse(killProcessVal);
			}
			catch (FormatException)
			{
				throw (new ConfigurationErrorsException(String.Format(
					"Unable to convert the configuration setting \"{0}\" to the required type '{1}'",
					"ProcessSingletonKillProcess",
					settings.KillProcess.GetType().FullName))
					);
			}


			// Return the Settings object
			return (settings);

		}

	}
}