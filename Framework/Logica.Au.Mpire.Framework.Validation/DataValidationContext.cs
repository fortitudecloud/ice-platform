using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace Logica.Au.Mpire.Framework.Validation
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public class DataValidationContext
	{

		private static TraceSwitch ourTraceSwitch = null;

		private DataSet myCurrentDataSet = null;
		private DataTable myCurrentDataTable = null;
		private DataRow myCurrentDataRow = null;
		private DataValidationErrorCollection myErrors = null;
		private DataValidationRule myCurrentDataValidationRule = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidationContext()
		{

			DataValidationContext.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.DataValidationContext",
				"TraceSwitch for the DataValidationContext class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationContext()
		{

			#region Tracing . . .
			if (DataValidationContext.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationContext() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			this.myErrors = new DataValidationErrorCollection();
			this.myErrors.Context = this;

			#region Tracing . . .
			if (DataValidationContext.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationContext() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataSet CurrentDataSet
		{

			get
			{

				return this.myCurrentDataSet;

			}

			set
			{

				this.myCurrentDataSet = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataTable CurrentDataTable
		{

			get
			{

				return this.myCurrentDataTable;

			}

			set
			{

				this.myCurrentDataTable = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataRow CurrentDataRow
		{

			get
			{

				return this.myCurrentDataRow;

			}

			set
			{

				this.myCurrentDataRow = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationErrorCollection Errors
		{

			get
			{

				return this.myErrors;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationRule CurrentDataValidationRule
		{

			get
			{

				return this.myCurrentDataValidationRule;

			}

			set
			{

				this.myCurrentDataValidationRule = value;

			}

		}

	}

}