using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Validation
{

	[Obsolete("Use DataValidationRule and the DataValidator class.", false)]
	public  class BusinessRuleBase : Logica.Au.Mpire.Framework.Validation.IBusinessRule
	{

		public virtual ValidationResultList Validate(DataSet candidate)
		{

			return new ValidationResultList();

		}

		/// <summary>
		/// Check if string is null or empty
		/// </summary>
		/// <param name="RowIn">String Value</param>
		/// <returns>True or False</returns>
		public bool CheckColumnNullOrEmpty(string valIn)
		{
			try
			{
				if( ((valIn == null) || (valIn == ""))) 
						return true;
				return false;
			}
			catch(System.Exception Xcp)
			{
				Console.WriteLine(Xcp);
				return false;
			}

		}

	}

}