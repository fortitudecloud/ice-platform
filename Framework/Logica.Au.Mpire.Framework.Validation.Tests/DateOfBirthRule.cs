using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace Logica.Au.Mpire.Framework.Validation.Tests
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class DateOfBirthRule : Logica.Au.Mpire.Framework.Validation.DataValidationRule
	{

		private static TraceSwitch ourTraceSwitch = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DateOfBirthRule()
		{

			DateOfBirthRule.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.Tests.DateOfBirthRule",
				"TraceSwitch for the DateOfBirthRule class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DateOfBirthRule()
		{

			#region Tracing . . .
			if (DateOfBirthRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DateOfBirthRule() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			this.Scope = DataValidationRuleScope.DataRow;
			this.DataTableNameQualifier = "Customers";

			#region Tracing . . .
			if (DateOfBirthRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DateOfBirthRule() constructor.",
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
		public override DataValidationErrorCollection Validate(DataValidationContext context)
		{

			DataRow currentDataRow = null;
			DateTime specifiedDate = DateTime.MinValue;

			#region Tracing . . .
			if (DateOfBirthRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Validate(DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			currentDataRow = context.CurrentDataRow;
			specifiedDate = (DateTime)currentDataRow["DateOfBirth"];

			if (specifiedDate > DateTime.Now)
			{

				currentDataRow.SetColumnError(
					"DateOfBirth",
					"Date of birth is set in the future."
					);

				context.Errors.Add(
					"It is not possible to have a customer whose date of birth is set in the future.",
					currentDataRow
					);

			}

			#region Tracing . . .
			if (DateOfBirthRule.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Validate(DataValidationContext) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return context.Errors;

		}

	}

}