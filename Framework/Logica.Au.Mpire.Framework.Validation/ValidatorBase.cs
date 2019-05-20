
using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Validation
{

	[Obsolete("Use DataValidationRule and the DataValidator class.", false)]
	public class ValidatorBase : Logica.Au.Mpire.Framework.Validation.IValidator
	{

		public ValidatorBase()
		{

			this.m_rules = new BusinessRuleList();

		}

		public virtual ValidationResultList Validate(DataSet candidate)
		{

			ValidationResultList results = null;

			results = new ValidationResultList();

			foreach (IBusinessRule rule in this.Rules)
			{

				results.AddRange(rule.Validate(candidate));

			}

			return results;

		}

		public virtual BusinessRuleList Rules
		{

			get
			{

				return this.m_rules;

			}

		}

		private BusinessRuleList m_rules = null;

	}

}