using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;

namespace Logica.Au.Mpire.Framework.Validation
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public class DataValidationRuleCollection : System.Collections.CollectionBase
	{

		private static TraceSwitch ourTraceSwitch = null;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidationRuleCollection()
		{

			DataValidationRuleCollection.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.DataValidationRuleCollection",
				"TraceSwitch for the DataValidationRuleCollection class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataValidationRuleCollection()
		{

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationRuleCollection() constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationRuleCollection() constructor.",
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
		public int Add(DataValidationRule rule)
		{

			int index = 0;

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the Add(DataValidationRule) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (rule == null)
			{

				throw new ArgumentNullException(
					"rule",
					"Rule argument cannot be null."
					);

			}
			#endregion

			index = this.InnerList.Add(rule);

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Add(DataValidationRule) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return index;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="rules">
		///		TODO: Insert documentation.
		/// </param>
		public void AddRange(DataValidationRuleCollection rules)
		{

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the AddRange(DataValidationRuleCollection) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (rules == null)
			{

				throw new ArgumentNullException(
					"rules",
					"Rules argument cannot be null."
					);

			}

			foreach (DataValidationRule rule in rules)
			{

				if (rule == null)
				{

					throw new ArgumentNullException(
						"rules",
						"Rules argument cannot have null elements."
						);

				}

			}
			#endregion

			this.InnerList.AddRange(rules);

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the Add(RangeDataValidationRuleCollection) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dataSetQualifier">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationRuleCollection GetDataSetRules(string dataSetQualifier)
		{

			DataValidationRuleCollection rules = null;

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the GetDataSetRules(string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			rules = this.GetRules(
				dataSetQualifier,
				null,
				DataValidationRuleScope.DataSet
				);

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the GetDataSetRules(string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return rules;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dataSetQualifier">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationRuleCollection GetDataTableRules(string dataSetQualifier, string dataTableQualifier)
		{

			DataValidationRuleCollection rules = null;

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the GetDataTableRules(string, string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			rules = this.GetRules(
				dataSetQualifier,
				dataTableQualifier,
				DataValidationRuleScope.DataTable
				);

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the GetDataSetRules(string, string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return rules;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dataSetQualifier">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationRuleCollection GetDataRowRules(string dataSetQualifier, string dataTableQualifier)
		{

			DataValidationRuleCollection rules = null;

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the GetDataTableRules(string, string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			rules = this.GetRules(
				dataSetQualifier,
				dataTableQualifier, 
				DataValidationRuleScope.DataRow
				);

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the GetDataSetRules(string, string) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return rules;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="dataSetQualifier">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public DataValidationRuleCollection GetRules(string dataSetQualifier, string dataTableQualifier, DataValidationRuleScope scope)
		{

			DataValidationRuleCollection rules = null;
			bool isScopeMatch = false;
			bool isDsQualifierMatch = false;
			bool isDtQualifierMatch = false;
			bool isQualifierMatch = false;
			bool isRuleMatch = false;

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the GetRules(string, string, DataValidationRuleScope) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			rules = new DataValidationRuleCollection();

			foreach (DataValidationRule rule in this.InnerList)
			{

				// Determine if the rule scope is a match.
				isScopeMatch = (rule.Scope == scope);

				// Determine if the rule data-set qualfier is a match.
				isDsQualifierMatch =
					(rule.DataSetNameQualifier == null) ||
					(rule.DataSetNameQualifier == string.Empty) ||
					(rule.DataSetNameQualifier == dataSetQualifier);

				// Determine if the rule data-table qualifier is a match.
				isDtQualifierMatch = 
					(rule.DataTableNameQualifier == null) ||
					(rule.DataTableNameQualifier == string.Empty) ||
					(rule.DataTableNameQualifier == dataTableQualifier);

				// Determine if all the rule qualifiers are a match.
				isQualifierMatch =
					(isDsQualifierMatch == true) &&
					(isDtQualifierMatch == true);

				// Determine if all the rule criteria are a match.
				isRuleMatch =
					(isScopeMatch == true) &&
					(isQualifierMatch == true);

				if (isRuleMatch == true)
				{

					rules.Add(rule);

				}

			}

			#region Tracing . . .
			if (DataValidationRuleCollection.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the GetRules(string, string, DataValidationRuleScope) method.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			return rules;

		}

	}

}