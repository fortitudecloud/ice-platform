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
	public class DataValidator
	{

		private static TraceSwitch ourTraceSwitch = null;

		private bool myThrowOnException = false;
		private bool myThrowOnError = false;
		private DataValidationRuleCollection myValidationRules = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidator()
		{

			DataValidator.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.DataValidator",
				"TraceSwitch for the DataValidator class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidator()
		{

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidator() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			this.myThrowOnException = true;
			this.myThrowOnError = false;
			this.myValidationRules = new DataValidationRuleCollection();

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidator() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="rule">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="context">
		///		TODO: Insert documentation.
		/// </param>
		private void ExecuteRule(DataValidationRule rule, DataValidationContext context)
		{

			int originalErrorCount = 0;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the ExecuteRule(DataValidationRule, DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (rule == null)
			{

				throw new ArgumentNullException(
					"rule",
					"Data validation rule argument cannot be null."
					);

			}

			if (context == null)
			{

				throw new ArgumentNullException(
					"context",
					"Data validation context argument cannot be null."
					);

			}
			#endregion

			try
			{

				originalErrorCount = context.Errors.Count;

				#region Tracing . . .
				if (DataValidator.ourTraceSwitch.TraceVerbose == true)
				{
			
					Trace.WriteLine(
						string.Format(
						"Executing the rule '{0}'.",
						rule.ToString()
						),
						MethodInfo.GetCurrentMethod().ReflectedType.Name
						);

				}
				#endregion

				// Execute the rule.
				context.CurrentDataValidationRule = rule;
				rule.Validate(context);

				if (this.myThrowOnError == true)
				{

					if (context.Errors.Count != originalErrorCount)
					{

						throw new DataValidationException(
							context.Errors[context.Errors.Count - 1].Description,
							context
							);

					}

				}

			}
			catch (Exception ex)
			{

				#region Tracing . . .
				if (DataValidator.ourTraceSwitch.TraceVerbose == true)
				{
			
					Trace.WriteLine(
						ex,
						MethodInfo.GetCurrentMethod().ReflectedType.Name
						);

				}
				#endregion

				if (ex is DataValidationException)
				{

					throw ex;

				}
				else
				{

					context.Errors.Add(
						new DataValidationError(
						ex.Message
						)
						);

					if (this.myThrowOnException == true)
					{

						throw new DataValidationException(
							ex.Message,
							ex,
							context
							);

					}

				}

			}
			finally
			{

				context.CurrentDataValidationRule = null;

			}

		}
        
		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="ds">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationErrorCollection Validate(DataSet ds)
		{

			DataValidationContext context = null;
			DataValidationRuleCollection rules = null;
			DataValidationErrorCollection errors = null;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataSet) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (ds == null)
			{

				throw new ArgumentNullException(
					"ds",
					"Data-set argument cannot be null."
					);

			}
			#endregion

			// Setup context.
			context = new DataValidationContext();
			context.CurrentDataSet = ds;

			// Execute table rules.
			foreach (DataTable dt in ds.Tables)
			{

				// Setup context.
				context.CurrentDataTable = dt;

				this.Validate(dt, context);

			}

			// Clean-up context.
			context.CurrentDataTable = null;
			context.CurrentDataRow = null;

			// Get data-set scoped rules.
			rules = this.ValidationRules.GetDataSetRules(
				context.CurrentDataSet.DataSetName
				);

			// Execute data-set scoped rules.
			foreach (DataValidationRule rule in rules)
			{

				this.ExecuteRule(rule, context);

			}

			errors = context.Errors;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataSet) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return errors;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dt">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationErrorCollection Validate(DataTable dt)
		{

			DataValidationContext context = null;
			DataValidationErrorCollection errors = null;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataTable) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (dt == null)
			{

				throw new ArgumentNullException(
					"dt",
					"Data-table argument cannot be null."
					);

			}
			#endregion

			// Setup context.
			context = new DataValidationContext();
			context.CurrentDataTable = dt;

			// Redirect to full implementation.
			this.Validate(dt, context);

			errors = context.Errors;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataTable) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return errors;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dt">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="context">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationErrorCollection Validate(DataTable dt, DataValidationContext context)
		{

			string dataSetName = null;
			DataValidationErrorCollection errors = null;
			DataValidationRuleCollection rules = null;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataTable, DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (dt == null)
			{

				throw new ArgumentNullException(
					"dt",
					"Data-table argument cannot be null."
					);

			}
			
			if (context == null)
			{

				throw new ArgumentNullException(
					"context",
					"Data validation context argument cannot be null."
					);

			}

			if (dt != context.CurrentDataTable)
			{

				throw new ArgumentException(
					"dt",
					"Data-table must reference the same object as context.CurrentDataTable."
					);

			}
			#endregion

			// Execute rules at row rules.
			foreach (DataRow dr in dt.Rows)
			{

				// Setup context.
				context.CurrentDataRow = dr;

				this.Validate(dr, dt.TableName, context);

			}

			// Clean-up context.
			context.CurrentDataRow = null;

			// Defend against a null data-set.
			if (context.CurrentDataSet != null)
			{

				dataSetName = context.CurrentDataSet.DataSetName;

			}

			// Get rules at table scope.
			rules = this.ValidationRules.GetDataTableRules(
				dataSetName,
				context.CurrentDataTable.TableName
				);

			// Execute data-table scoped rules.
			foreach (DataValidationRule rule in rules)
			{

				this.ExecuteRule(rule, context);

			}

			errors = context.Errors;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataTable, DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return errors;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dr">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="qualifier">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationErrorCollection Validate(DataRow dr, string dataTableQualifier)
		{

			DataValidationContext context = null;
			DataValidationErrorCollection errors = null;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataRow, string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (dr == null)
			{

				throw new ArgumentNullException(
					"dr",
					"Data-row argument cannot be null."
					);

			}
			
			if (dataTableQualifier == null)
			{

				throw new ArgumentNullException(
					"dataTableQualifier",
					"Data-table qualifier argument cannot be null."
					);

			}
			#endregion

			// Setup context.
			context = new DataValidationContext();
			context.CurrentDataRow = dr;

			// Call to full implementation.
			this.Validate(dr, dataTableQualifier, context);

			errors = context.Errors;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataRow, string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return errors;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dr">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="qualifier">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationErrorCollection Validate(DataRow dr, string dataTableQualifier, DataValidationContext context)
		{

			string dataSetName = null;
			DataValidationRuleCollection rules = null;
			DataValidationErrorCollection errors = null;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataRow, string, DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (dr == null)
			{

				throw new ArgumentNullException(
					"dr",
					"Data-row argument cannot be null."
					);

			}
			
			if (dataTableQualifier == null)
			{

				throw new ArgumentNullException(
					"dataTableQualifier",
					"Data-table qualifier argument cannot be null."
					);

			}

			if (context == null)
			{

				throw new ArgumentNullException(
					"context",
					"Data validation context argument cannot be null."
					);

			}

			if (dr != context.CurrentDataRow)
			{

				throw new ArgumentException(
					"dr",
					"Data-row must reference the same object as context.CurrentDataRow."
					);

			}
			#endregion

			// Defend against null data-set.
			if (context.CurrentDataSet != null)
			{

				dataSetName = context.CurrentDataSet.DataSetName;

			}

			// Get data-row scoped rules.
			rules = this.ValidationRules.GetDataRowRules(
				dataSetName,
				dataTableQualifier
				);

			// Execute data-row scoped rules.
			foreach (DataValidationRule rule in rules)
			{

				this.ExecuteRule(rule, context);

			}

			errors = context.Errors;

			#region Tracing . . .
			if (DataValidator.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataRow, string, DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return errors;			

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationRuleCollection ValidationRules
		{

			get
			{

				return this.myValidationRules;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public bool ThrowOnError
		{

			get
			{

				return this.myThrowOnError;

			}

			set
			{

				this.myThrowOnError = value;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public bool ThrowOnException
		{

			get
			{

				return this.myThrowOnException;

			}

			set
			{
				
				this.myThrowOnException = value;

			}

		}

	}

}