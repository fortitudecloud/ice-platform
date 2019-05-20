using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Validation
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	public class DataValidationRuleHelper
	{

		/// <summary>
		///		Private constructor for the DataValidationRuleHelper class.
		/// </summary>
		/// <remarks>
		///		Needs to be private to stop people using it like it has state.
		/// </remarks>
		private DataValidationRuleHelper()
		{
		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="row">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="errorMessage">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="columnNames">
		///		TODO: Insert documentation.
		/// </param>
		/// <returns>
		///		TODO: Insert documentation.
		/// </returns>
		public static string GenerateErrorMessage(DataRow row, string errorMessage, string[] columnNames)
		{

			string[] columnValues = null;
			string actualErrorMessage = null;

			if (columnNames != null)
			{

				columnValues = new string[columnNames.Length];
				for (int columnNumber = 0; columnNumber < columnNames.Length; columnNumber++)
				{

					// Extract the column value from the row using the specified
					// column name, identified by the column number. Phew!
					columnValues[columnNumber] = (string)row[columnNames[columnNumber]];

				}

				actualErrorMessage = string.Format(errorMessage, columnValues);

			}
			else
			{

				actualErrorMessage = errorMessage;

			}

			return actualErrorMessage;

		}

		/// <summary>
		///		Check if string is null or empty.
		/// </summary>
		/// <param name="value">
		///		The string instance containing the value to be checked.
		///	</param>
		/// <returns>
		///		True if the value is null or empty, otherwise false.
		///	</returns>
		public static bool IsNullOrEmpty(string value)
		{

			bool isNullOrEmpty = false;

			if ((value == null) || (value == string.Empty))
			{

				isNullOrEmpty = true;

			}

			return isNullOrEmpty;
													
		}

		/// <summary>
		///		Check if object is null or empty.
		/// </summary>
		/// <param name="value">
		///		The object instance containing the value to be checked.
		///	</param>
		/// <returns>
		///		True if the value is null or empty, otherwise false.
		///	</returns>
		public static bool IsNullOrEmpty(object value)
		{

			bool isNullOrEmpty = false;

			if (value is string)
			{

				isNullOrEmpty = DataValidationRuleHelper.IsNullOrEmpty((string)value);

			}
			else if (value == null)
			{

				isNullOrEmpty = true;

			}
			else if (value == (DBNull.Value as object))
			{

				isNullOrEmpty = true;

			}

			return isNullOrEmpty;

		}

	}		

}