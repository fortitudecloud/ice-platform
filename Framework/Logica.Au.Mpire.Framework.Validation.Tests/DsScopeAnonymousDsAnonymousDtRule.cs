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
	public class DsScopeAnonymousDsAnonymousDtRule : Logica.Au.Mpire.Framework.Validation.DataValidationRule
	{

		public DsScopeAnonymousDsAnonymousDtRule()
		{

			this.Scope = DataValidationRuleScope.DataSet;

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