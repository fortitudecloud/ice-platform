
using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Validation
{

	[Obsolete("Use DataValidationRule and the DataValidator class.", false)]
	public interface IValidator
	{

		ValidationResultList Validate(DataSet candidate);

		BusinessRuleList Rules
		{

			get;

		}

	}

}