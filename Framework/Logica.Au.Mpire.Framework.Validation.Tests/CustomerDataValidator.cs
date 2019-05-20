using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using Logica.Au.Mpire.Framework.Validation.Tests;
using System;

namespace Logica.Au.Mpire.Framework.Validation.Tests
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class CustomerDataValidator : Logica.Au.Mpire.Framework.Validation.DataValidator
	{

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public CustomerDataValidator()
		{

			this.ValidationRules.Add(new DsScopeAnonymousDsAnonymousDtRule());
			this.ValidationRules.Add(new DsScopeNamedDsAnonymousDtRule());
			this.ValidationRules.Add(new DtScopeAnonymousDsAnonymousDtRule());
			this.ValidationRules.Add(new DtScopeNamedDsAnonymousDtRule());
			this.ValidationRules.Add(new DtScopeNamedDsNamedDtRule());
			this.ValidationRules.Add(new DrScopeAnonymousDsAnonymousDtRule());
			this.ValidationRules.Add(new DrScopeNamedDsAnonymousDtRule());
			this.ValidationRules.Add(new DrScopeNamedDsNamedDtRule());
			this.ValidationRules.Add(new DateOfBirthRule());

		}

	}

}