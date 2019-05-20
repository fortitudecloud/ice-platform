using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Diagnostics;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace Logica.Au.Mpire.Framework.Diagnostics
{

	public class TraceHelper
	{

		private static MethodBase GetInvokingMethod(int hops)
		{

			StackFrame frame = null;
			MethodBase method = null;

			frame = new StackFrame(hops);
			method = frame.GetMethod();

			return method;

		}

		// Determine the name of the authenticated user attached to the current thread
		private static string GetCurrentIdentity()
		{
			string identityName = "unknown";

			try
			{
				// Get the Identity name from the current call context
				identityName = Thread.CurrentPrincipal.Identity.Name;

				// If no authenticated principal attached, supply an "unknown" value
				if (identityName == String.Empty)
					identityName = "unknown";
			}
			catch {}


			return (identityName);

		}


		private static string GenerateMethodSignature(MethodBase method)
		{

			StringBuilder builder = null;
			ParameterInfo[] parameters = null;
			string signature = null;

			// Start building the signature.
			builder = new StringBuilder();

			builder.AppendFormat(
				"{0}(",
				method.Name
				);

			parameters = method.GetParameters();

			if (parameters.Length != 0)
			{

				for (int pCount = 0; pCount < parameters.Length; pCount++)
				{

					if (pCount == (parameters.Length - 1))
					{

						builder.AppendFormat(
							"{0}",
							parameters[pCount].ParameterType.Name
							);

					}
					else
					{

						builder.AppendFormat(
							"{0}, ",
							parameters[pCount].ParameterType.Name
							);

					}

				}

			}

			builder.Append(")");

			// Get the resulting string.
			signature = builder.ToString();

			return signature;

		}

		[Conditional("TRACE")]
		public static void Write(DiagnosticLevel level, string message)
		{

			int hops = 0;
			MethodBase method = null;
			string finalMessage = null;

			// HACK: Done temporarily, should probably find a better
			//       way to walk back the stack, and should probably
			//       put completely into a seperate sub-routine. Was
			//       originally set to 2, but found that in certain
			//       instances it jumped right into null territory.
			hops = 1;
			do
			{

				method = TraceHelper.GetInvokingMethod(hops);
				hops++;
				
			} while(method.ReflectedType.Namespace == "Logica.Au.Mpire.Framework.Diagnostics");

			// Get the current identity name
			string identity = TraceHelper.GetCurrentIdentity();

			// Pull together the final message.
			finalMessage = string.Format(
				"[{0}] [Thd {1:0000}] [{2}] [{3}.{4}] [{5}]",
				DateTime.Now.ToString("yy-MM-dd HH:mm:ss.fff", DateTimeFormatInfo.InvariantInfo),
				Thread.CurrentThread.ManagedThreadId,
				identity,
				method.ReflectedType.Name,
				TraceHelper.GenerateMethodSignature(method),
				message
				);

			// Switch to determine correct category.
			switch (level)
			{

				case DiagnosticLevel.Error:

					Trace.WriteLine(finalMessage, "Err");
					break;

				case DiagnosticLevel.Warning:

					Trace.WriteLine(finalMessage, "Wrn");
					break;

				case DiagnosticLevel.Info:

					Trace.WriteLine(finalMessage, "Inf");
					break;

				case DiagnosticLevel.Verbose:

					Trace.WriteLine(finalMessage, "Vrb");
					break;

				case DiagnosticLevel.Debug:

					Trace.WriteLine(finalMessage, "Dbg");
					break;

			}

		}

		[Conditional("TRACE")]
		public static void WriteError(string message)
		{

			TraceHelper.Write(DiagnosticLevel.Error, message);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteWarning(string message)
		{

			TraceHelper.Write(DiagnosticLevel.Warning, message);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteInfo(string message)
		{

			TraceHelper.Write(DiagnosticLevel.Info, message);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteVerbose(string message)
		{
	
			TraceHelper.Write(DiagnosticLevel.Verbose, message);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("DEBUG")]
		public static void WriteDebug(string message)
		{

			TraceHelper.Write(DiagnosticLevel.Debug, message);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="level">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="format">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void Write(DiagnosticLevel level, string format, params object[] args)
		{

			string message = null;

			message = string.Format(format, args);

			TraceHelper.Write(level, message);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="format">
		///		TODO: Insert documetnation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteError(string format, params object[] args)
		{

			TraceHelper.Write(DiagnosticLevel.Error, format, args);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="format">
		///		TODO: Insert documetnation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteWarning(string format, params object[] args)
		{

			TraceHelper.Write(DiagnosticLevel.Warning, format, args);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="format">
		///		TODO: Insert documetnation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteInfo(string format, params object[] args)
		{

			TraceHelper.Write(DiagnosticLevel.Info, format, args);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="format">
		///		TODO: Insert documetnation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("TRACE")]
		public static void WriteVerbose(string format, params object[] args)
		{

			TraceHelper.Write(DiagnosticLevel.Verbose, format, args);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="format">
		///		TODO: Insert documetnation.
		/// </param>
		/// <param name="args">
		///		TODO: Insert documentation.
		/// </param>
		[Conditional("DEBUG")]
		public static void WriteDebug(string format, params object[] args)
		{

			TraceHelper.Write(DiagnosticLevel.Debug, format, args);

		}

	}

}