using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using Logica.Au.Mpire.Framework.Validation.Tests;
using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Validation.Tests
{
	
	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class DrScopeNamedDsNamedDtRule : Logica.Au.Mpire.Framework.Validation.DataValidationRule
	{

		public DrScopeNamedDsNamedDtRule()
		{

			this.Scope = DataValidationRuleScope.DataRow;
			this.DataSetNameQualifier = "CustomerDataSet";
			this.DataTableNameQualifier = "Customers";

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

			return context.Errors;

		}

	}

}