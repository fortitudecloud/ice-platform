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

	[Serializable()]
	public abstract class DataValidationRule
	{

		private static TraceSwitch ourTraceSwitch = null;

		private DataValidationRuleScope myScope = DataValidationRuleScope.DataRow;
		private string myDataSetNameQualifier = null;
		private string myDataTableNameQualifier = null;
		private string myDescription = null;
		private string myErrorMessage = null;
		private string[] myColumnNames = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidationRule()
		{
	
			DataValidationRule.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.DataValidationRule",
				"TraceSwitch for the DataValidationRule class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationRule()
		{

			#region Tracing . . .
			if (DataValidationRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationRule() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			// Default the description to the class name of the rule.
			this.myDescription = this.GetType().Name;

			#region Tracing . . .
			if (DataValidationRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationRule() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}
		
		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="context">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public abstract DataValidationErrorCollection Validate(DataValidationContext context);

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="ds">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="dt">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="dr">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationErrorCollection Validate(DataSet ds, DataTable dt, DataRow dr)
		{

			DataValidationContext context = null;

			#region Tracing . . .
			if (DataValidationRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataSet, DataTable, DataRow) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			context = new DataValidationContext();
			context.CurrentDataSet = ds;
			context.CurrentDataTable = dt;
			context.CurrentDataRow = dr;

			this.Validate(context);

			#region Tracing . . .
			if (DataValidationRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataSet, DataTable, DataRow) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return context.Errors;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public override string ToString()
		{

			string output = null;

			#region Tracing . . .
			if (DataValidationRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the ToString() method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			output = string.Format(
				"Type = {0}, Scope = {1}, DataSetNameQualifier = {2}, DataTableNameQualifier = {3}",
				this.GetType().ToString(),
				this.Scope,
				this.DataSetNameQualifier,
				this.DataTableNameQualifier
				);

			#region Tracing . . .
			if (DataValidationRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the ToString() method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return "{" + output + "}";

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationRuleScope Scope
		{

			get
			{

				return this.myScope;

			}

			set
			{

				this.myScope = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string DataSetNameQualifier
		{

			get
			{

				return this.myDataSetNameQualifier;

			}
			
			set
			{

				this.myDataSetNameQualifier = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string DataTableNameQualifier
		{

			get
			{

				return this.myDataTableNameQualifier;

			}

			set
			{

				this.myDataTableNameQualifier = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string Description
		{

			get
			{

				return this.myDescription;

			}

			set
			{

				this.myDescription = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string ErrorMessage
		{

			get
			{

				return this.myErrorMessage;

			}

			set
			{

				this.myErrorMessage = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string[] ColumnNames
		{

			get
			{

				return this.myColumnNames;

			}

			set
			{

				this.myColumnNames = value;

			}

		}
	
		/// <summary>
		/// Check if string is null or empty
		/// </summary>
		/// <param name="RowIn">String Value</param>
		/// <returns>True or False</returns>
		[Obsolete("This code has been refactored, you should now is the IsNullOrEmpty method on the DataValidationRuleHelper class.", false)]
		protected bool CheckColumnNullOrEmpty(string value)
		{

			bool result = false;

			result = DataValidationRuleHelper.IsNullOrEmpty(value);

			return result;

		}

		/// <summary>
		/// Check if an object is null or empty
		/// </summary>
		/// <param name="RowIn">String Value</param>
		/// <returns>True or False</returns>
		[Obsolete("This code has been refactored, you should now is the IsNullOrEmpty method on the DataValidationRuleHelper class.", false)]
		protected bool CheckColumnNullOrEmpty(object value)
		{

			bool result = false;

			result = DataValidationRuleHelper.IsNullOrEmpty(value);

			return result;

		}

	}

}