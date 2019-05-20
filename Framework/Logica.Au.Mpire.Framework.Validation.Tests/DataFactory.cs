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
	public class DataFactory
	{

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public static CustomerDataSet.CustomersDataTable GetValidCustomersDataTable()
		{

			CustomerDataSet.CustomersDataTable dt = null;

			dt = new CustomerDataSet.CustomersDataTable();
			dt.AddCustomersRow(
				Guid.NewGuid().ToString(),
				"Denny",
				"Mitch",
				DateTime.Parse("06/10/1977")
				);
			dt.AddCustomersRow(
				Guid.NewGuid().ToString(),
				"Denny",
				"Nicola",
				DateTime.Parse("09/12/1970")
				);
			dt.AddCustomersRow(
				Guid.NewGuid().ToString(),
				"Denny",
				"Isabella",
				DateTime.Parse("06/08/2002")
				);

			return dt;

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public static CustomerDataSet.CustomersDataTable GetInvalidCustomersDataTable()
		{

			CustomerDataSet.CustomersDataTable dt = null;

			dt = new CustomerDataSet.CustomersDataTable();
			dt.AddCustomersRow(
				Guid.NewGuid().ToString(),
				"Denny",
				"Hamish",
				DateTime.Parse("12/10/2004")
				);
			dt.AddCustomersRow(
				Guid.NewGuid().ToString(),
				"Denny",
				"Jemma",
				DateTime.Parse("18/12/2006")
				);

			return dt;

		}

	}

}