
using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Validation
{

	[Obsolete("Use DataValidationRule and the DataValidator class.", false)]
	public interface IBusinessRule
	{

		ValidationResultList Validate(DataSet candidate);

	}

}