
using System;

namespace Logica.Au.Mpire.Framework.Validation
{

	[Obsolete("Use DataValidationRule and the DataValidator class.", false)]
	public class ValidationResult
	{

		public string Description
		{

			get
			{

				return this.m_description;

			}

			set
			{

				this.m_description = value;

			}

		}

		public ValidationStatus Status
		{

			get
			{

				return this.m_status;

			}

			set
			{

				this.m_status = value;

			}

		}

		public object Reference
		{

			get
			{

				return this.m_reference;

			}

			set
			{

				this.m_reference = value;

			}

		}

		private string m_description = null;
		private ValidationStatus m_status = ValidationStatus.Unknown;
		private object m_reference = null;

	}

}