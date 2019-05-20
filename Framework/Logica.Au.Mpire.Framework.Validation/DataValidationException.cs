using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;
using System.Runtime.Serialization;

namespace Logica.Au.Mpire.Framework.Validation
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public class DataValidationException : Logica.Au.Mpire.Framework.MpireException
	{

		private static TraceSwitch ourTraceSwitch = null;

		private DataValidationContext myContext = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidationException()
		{

			DataValidationException.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.DataValidationException",
				"TraceSwitch for the DataValidationException class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationException() : base()
		{

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationException() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationException() constructor.",
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
		public DataValidationException(string message, DataValidationContext context) : base(message)
		{

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationException(string) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			this.myContext = context;

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationException(string) constructor.",
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
		public DataValidationException(SerializationInfo info, StreamingContext context) :
			base(info, context)
		{

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationException(SerializationInfo, StreamingContext) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationException(SerializationInfo, StreamingContext) constructor.",
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
		public DataValidationException(string message, Exception innerException, DataValidationContext context) :
			base(message, innerException)
		{

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationException(string, Exception) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			this.myContext = context;

			#region Tracing . . .
			if (DataValidationException.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationException(string, Exception) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationContext Context
		{

			get
			{

				return this.myContext;

			}

			set
			{

				this.myContext = value;

			}

		}

	}

}