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
	public class DataValidationRuleCollectionTestFixture
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
		public void GetDataSetRules1()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataSetRules(
				"CustomerDataSet"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    2,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataSetRules2()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataSetRules(
				string.Empty
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataSetRules3()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataSetRules(
				null
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataSetRules4()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataSetRules(
				"OtherDataSet"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules1()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"CustomerDataSet",
				null
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    2,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules2()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				string.Empty,
				null
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules3()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				null,
				null
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules4()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"OtherDataSet",
				null
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules5()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"CustomerDataSet",
				"Customers"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    3,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules6()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"CustomerDataSet",
				string.Empty
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    2,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules7()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"CustomerDataSet",
				"Other"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    2,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules8()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				string.Empty,
				"Customers"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules9()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				string.Empty,
				string.Empty
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules10()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				string.Empty,
				"Other"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules11()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				string.Empty,
				"Other"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules12()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				null,
				"Customers"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules13()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				null,
				string.Empty
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules14()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				null,
				"Others"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

            }

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules15()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"OtherDataSet",
				"Customers"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules16()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"OtherDataSet",
				string.Empty
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules17()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"OtherDataSet",
				null
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void GetDataTableRules18()
		{

			CustomerDataValidator validator = null;
			DataValidationRuleCollection rules = null;

			validator = new CustomerDataValidator();
			rules = validator.ValidationRules.GetDataTableRules(
				"OtherDataSet",
				"Other"
				);

			Console.WriteLine("Rules:");

			foreach (DataValidationRule rule in rules)
			{

				Console.WriteLine(rule.GetType().ToString());

			}

            //Assertion.AssertEquals(
            //    1,
            //    rules.Count
            //    );

		}

	}

}