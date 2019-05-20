using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Diagnostics;
using System;
using System.Diagnostics;

namespace Logica.Au.Mpire.Framework.Diagnostics
{

	/// <summary>
	///		Represents a tracing context
	/// </summary>
	public class DiagnosticSwitch
	{

		private bool myTraceError = false;
		private bool myTraceWarning = false;
		private bool myTraceInfo = false;
		private bool myTraceVerbose = false;

		/// <summary>
		///		Constructor for the DiagnosticSwitch class.
		/// </summary>
		/// <param name="vetoSwitchName">
		///		A string containing the name of the TraceSwitch that
		///		has veto rights over the diagnostic levels.
		/// </param>
		/// <param name="classSwitchName">
		///		A single TraceSwitch that determines the effective
		///		tracing level for this diagnostic switch.
		/// </param>
		public DiagnosticSwitch(string vetoSwitchName, string classSwitchName) : this(vetoSwitchName, new string[1] { classSwitchName })
		{
		}

		/// <summary>
		///		Constructor for the DiagnosticSwitch class.
		/// </summary>
		/// <param name="vetoSwitchName">
		///		A string containing the name of the TraceSwitch that
		///		has veto rights over the diagnostic levels.
		/// </param>
		/// <param name="relevantSwitchNames">
		///		A string array containing the names of TraceSwitches
		///		which are combined to determined the diagnostic levels.
		/// </param>
		public DiagnosticSwitch(string vetoSwitchName, string[] relevantSwitchNames)
		{

			TraceSwitch vetoSwitch = null;
			TraceSwitch[] relevantSwitches = null;

			vetoSwitch = new TraceSwitch(vetoSwitchName, null);
			relevantSwitches = this.LoadSwitches(relevantSwitchNames);

			this.myTraceError =
				(vetoSwitch.TraceError == true) &&
				(this.EvaluateSwitches(DiagnosticLevel.Error, relevantSwitches) == true);

			this.myTraceWarning =
				(vetoSwitch.TraceWarning == true) &&
				(this.EvaluateSwitches(DiagnosticLevel.Warning, relevantSwitches) == true);

			this.myTraceInfo = 
				(vetoSwitch.TraceInfo == true) &&
				(this.EvaluateSwitches(DiagnosticLevel.Info, relevantSwitches) == true);

			this.myTraceVerbose =
				(vetoSwitch.TraceVerbose == true) &&
				(this.EvaluateSwitches(DiagnosticLevel.Verbose, relevantSwitches) == true);

		}

		/// <summary>
		///		Loads a group of trace switches based on the names provided.
		/// </summary>
		/// <param name="names">
		///		A string array containing the names of the switches.
		/// </param>
		/// <returns>
		///		A TraceSwitch array.
		/// </returns>
		private TraceSwitch[] LoadSwitches(string[] names)
		{

			TraceSwitch[] switches = null;

			switches = new TraceSwitch[names.Length];

			for (int counter = 0; counter < names.Length; counter++)
			{

				switches[counter] = new TraceSwitch(names[counter], null);

			}

			return switches;

		}

		/// <summary>
		///		Given an array of trace switches and a diagnostic level, evaluates
		///		whether any of them turn tracing on. If any of the traces are turned
		///		on this the result is true.
		/// </summary>
		/// <param name="level">
		///		The diagnostic level the evaluate against.
		/// </param>
		/// <param name="switches">
		///		An array of TraceSwitch instances.
		/// </param>
		/// <returns>
		///		A boolean indicating whether or not tracing is enabled at
		///		the specified diagnostic level.
		/// </returns>
		private bool EvaluateSwitches(DiagnosticLevel level, TraceSwitch[] switches)
		{

			bool evaluation = false;

			foreach (TraceSwitch tSwitch in switches)
			{

				switch (level)
				{

					case DiagnosticLevel.Error:

						evaluation = tSwitch.TraceError || evaluation;

						break;

					case DiagnosticLevel.Warning:

						evaluation = tSwitch.TraceWarning || evaluation;

						break;

					case DiagnosticLevel.Info:

						evaluation = tSwitch.TraceInfo || evaluation;

						break;

					case DiagnosticLevel.Verbose:

						evaluation = tSwitch.TraceVerbose || evaluation;

						break;

				}

			}

			return evaluation;

		}

		/// <summary>
		///		Returns true if tracing of error messages is enabled. Otherwise false.
		/// </summary>
		public bool TraceError
		{
	
			get
			{

				return this.myTraceError;

			}

		}

		/// <summary>
		///		Returns true if tracing of warning messages is enabled. Otherwise false.
		/// </summary>
		public bool TraceWarning
		{
	
			get
			{

				return this.myTraceWarning;

			}

		}

		/// <summary>
		///		Returns true if tracing of info messages is enabled. Otherwise false.
		/// </summary>
		public bool TraceInfo
		{
	
			get
			{

				return this.myTraceInfo;

			}

		}

		/// <summary>
		///		Returns true if tracing of verbose messages is enabled. Otherwise false.
		/// </summary>
		public bool TraceVerbose
		{
	
			get
			{

				return this.myTraceVerbose;

			}

		}
		
	}

}