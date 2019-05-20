using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using Logica.Au.Mpire.Framework.Validation.Tests;
using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logica.Au.Mpire.Framework.Validation.Tests
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[TestClass]
	public class DataValidatorTestFixture
	{

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void VerifyTestingAparatus()
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void Validate1()
		{

			CustomerDataSet.CustomersDataTable dt = null;
			CustomerDataValidator validator = null;
			DataValidationErrorCollection errors = null;

			dt = DataFactory.GetValidCustomersDataTable();

			validator = new CustomerDataValidator();
			errors = validator.Validate(dt);

            //Assertion.AssertEquals(
            //    "Errors collection should contain zero errors.",
            //    0,
            //    errors.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void Validate2()
		{

			CustomerDataSet.CustomersDataTable dt = null;
			CustomerDataValidator validator = null;
			DataValidationErrorCollection errors = null;

			dt = DataFactory.GetInvalidCustomersDataTable();

			validator = new CustomerDataValidator();
			errors = validator.Validate(dt);

            //Assertion.AssertEquals(
            //    "Errors collection should contain two errors.",
            //    2,
            //    errors.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(DataValidationException))]
		public void Validate3()
		{

			CustomerDataSet.CustomersDataTable dt = null;
			CustomerDataValidator validator = null;
			DataValidationErrorCollection errors = null;

			dt = DataFactory.GetValidCustomersDataTable();

			validator = new CustomerDataValidator();
			validator.ValidationRules.Add(new FlakeyRule());
			errors = validator.Validate(dt);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void Validate4()
		{

			CustomerDataSet.CustomersDataTable dt = null;
			CustomerDataValidator validator = null;
			DataValidationErrorCollection errors = null;

			dt = DataFactory.GetValidCustomersDataTable();

			validator = new CustomerDataValidator();
			validator.ValidationRules.Add(new FlakeyRule());
			validator.ThrowOnException = false;
			errors = validator.Validate(dt);

            //Assertion.AssertEquals(
            //    "Errors collection should contain two errors.",
            //    3,
            //    errors.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(DataValidationException))]
		public void Validate5()
		{

			CustomerDataSet.CustomersDataTable dt = null;
			CustomerDataValidator validator = null;
			DataValidationErrorCollection errors = null;

			dt = DataFactory.GetInvalidCustomersDataTable();

			validator = new CustomerDataValidator();
			validator.ThrowOnError = true;
			errors = validator.Validate(dt);

		}

	}

}