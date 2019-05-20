using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;
using System.Runtime.Serialization;

namespace Logica.Au.Mpire.Framework
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public class MpireException : System.ApplicationException
	{

		private static TraceSwitch ourTraceSwitch = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static MpireException()
		{

			MpireException.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.MpireException",
				"TraceSwitch for the MpireException class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public MpireException() : base()
		{

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the MpireException() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the MpireException() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		public MpireException(string message) : base(message)
		{

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the MpireException(string) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the MpireException(string) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="info">	
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="context">
		///		TODO: Insert documentation.
		/// </param>
		public MpireException(SerializationInfo info, StreamingContext context) :
			base(info, context)
		{

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the MpireException(SerializationInfo, StreamingContext) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the MpireException(SerializationInfo, StreamingContext) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="message">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="innerException">
		///		TODO: Insert documentation.
		/// </param>
		public MpireException(string message, Exception innerException) :
			base(message, innerException)
		{

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the MpireException(string, Exception) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (MpireException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the MpireException(string, Exception) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

	}

}