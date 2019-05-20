using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Diagnostics;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Logica.Au.Mpire.Framework.Diagnostics
{

	/// <summary>
	///		High-level wrapper around debug logging functionality.
	/// </summary>
	public class DebugHelper
	{

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[Conditional("DEBUG")]
		public static void Write(string message)
		{

			TraceHelper.Write(DiagnosticLevel.Debug, message);
            			
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="format">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("DEBUG")]
		public static void Write(string format, params object[] args)
		{

			TraceHelper.Write(DiagnosticLevel.Debug, format, args);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[Conditional("DEBUG")]
		public static void WriteMethodEntry()
		{

			TraceHelper.Write(DiagnosticLevel.Debug, "Entering.");
            			
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[Conditional("DEBUG")]
		public static void WriteMethodExit()
		{
						
			TraceHelper.Write(DiagnosticLevel.Debug, "Exiting.");
            			
		}

	}

}