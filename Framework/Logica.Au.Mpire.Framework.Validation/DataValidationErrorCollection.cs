using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace Logica.Au.Mpire.Framework.Validation
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public class DataValidationErrorCollection : System.Collections.CollectionBase
	{

		private static TraceSwitch ourTraceSwitch = null;

		private DataValidationContext myContext = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidationErrorCollection()
		{

			DataValidationErrorCollection.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.DataValidationErrorCollection",
				"TraceSwitch for the DataValidationErrorCollection class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationErrorCollection()
		{

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationErrorCollection() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationErrorCollection() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="error">
		///		TODO: Insert documentation.
		/// </param>
		public int Add(DataValidationError error)
		{

			int index = 0;

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Add(DataValidationError) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			// Attach source information to the error if it is available.
			if ((this.myContext != null) && (this.myContext.CurrentDataValidationRule != null))
			{
	
				error.Source = this.myContext.CurrentDataValidationRule.Description;

			}

			index = this.InnerList.Add(error);

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Add(DataValidationError) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return index;

		}

		/// <summary>
		///		Overload of the Add method to allow a DataValidationError to be added without an 
		///		associated DataRow. BJT 28/3/03.
		/// </summary>
		/// <param name="description">
		///		TODO: Insert documentation.
		/// </param>
		public int Add(string description)
		{

			DataValidationError error = null;
			int index = 0;

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Add(string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			error = new DataValidationError(description);

			index = this.Add(error);

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Add(string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return index;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="description">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="row">
		///		TODO: Insert documentation.
		/// </param>
		public int Add(string description, DataRow row)
		{

			DataValidationError error = null;
			int index = 0;

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Add(string, DataRow) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			error = new DataValidationError(description, row);

			index = this.Add(error);

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Add(string, DataRow) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return index;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="description">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="rows">
		///		TODO: Insert documentation.
		/// </param>
		public int Add(string description, DataRow[] rows)
		{

			DataValidationError error = null;
			int index = 0;

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Add(string, DataRow[]) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			error = new DataValidationError(description, rows);

			index = this.Add(error);

			#region Tracing . . .
			if (DataValidationErrorCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Add(string, DataRow[]) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return index;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationError this[int index]
		{

			get
			{

				return (DataValidationError)this.InnerList[index];

			}

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