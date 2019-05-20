using System;

namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// MpireChecksum contains routines for Creating and Validating Checksums for identifiers used in the Mpire System.
	/// </summary>
	public class MpireChecksum
	{
		// Hide the default ctor
		private MpireChecksum()
		{
		}

		/// <summary>
		/// Generates a fully qualified Checksum compliant number for a given 32-bit Integer.
		/// </summary>
		/// <param name="initialValue">The initial 32-bit Integer.</param>
		/// <returns>The Number with it's appended Check Digit.</returns>
		/// <author>Brett Tyrrell.</author>
		/// <date>5/Feb/2003</date>
		public static Int32 GenerateChecksum(Int32 initialValue)
		{
			if ((initialValue > 999999999) || (initialValue < -999999999))
				throw (new ArgumentException("Parameter initialValue is too large to Generate a CheckSum", "initialValue"));
			if (initialValue == 0)
				throw (new ArgumentException("Unable to Generate a CheckSum for Zero", "initialValue"));

			Int32 checkDigit = GetCheckDigit(initialValue);

			string stringValue = Convert.ToString(initialValue) + Convert.ToString(checkDigit);

			// Return an Int32 representation of the CheckSum
			return (Convert.ToInt32(stringValue));
		}


		/// <summary>
		/// Validates that a given 32-bit Integer is Checksum compliant.
		/// </summary>
		/// <param name="initialValue">The 32-bit Integer to validate for compliance.</param>
		/// <returns>True if the Validation succeeded.</returns>
		/// <author>Brett Tyrrell.</author>
		/// <date>5/Feb/2003</date>
		public static bool ValidateChecksum(Int32 checksumValue)
		{
			bool validated = false;
			string stringValue = Convert.ToString(checksumValue);

			if (stringValue.Length > 1)
			{
				// Get the n-1 leftmost characters of the String and convert to to an Integer
				Int32 root = Convert.ToInt32(stringValue.Substring(0, stringValue.Length-1));

				Int32 checkDigit = Convert.ToInt32(stringValue.Substring(stringValue.Length-1));

				// Check if the calculated CheckDigit equals the supplied one
				validated = (GetCheckDigit(root) == checkDigit);
			}

			return (validated);
		}


		// Calculates the Check Digit for a 32-bit integer number
		/// <summary>
		/// Calculates a Check Digit for an Integer number
		/// </summary>
		/// <param name="initial">The initial 32-bit integer.</param>
		/// <returns>The calculated Check Digit</returns>
		/// <remarks>
		/// Algorithm derived from document "Check Digit - SEWL Customer Reference Numbers".
		/// Source Safe : $/Mpire/Project File/03 - Client/3.05 - Customer Supplied Documents/
		/// Supplied : 6/Feb/2003
		/// </remarks>
		public static Int32 GetCheckDigit(Int32 initial)
		{
			// Need to keep a running total
			int runningTotal = 0;
			int checkDigit = 0;

			// Convert the Integer value to a String of Chars
			string stringValue = Convert.ToString(initial);

			int stringLength = stringValue.Length;

			// We process each character in the String
			for (int i=0; i<stringLength; i++)
			{
				// Get the Character at position N (from the Right)
				char theChar = stringValue[(stringLength-1) - i];

				int charVal = (int)char.GetNumericValue(theChar);	// Convert.ToInt32(theChar);

				// The value of each character is muliplied by it's position from the Right (base 1 index)
				runningTotal += (charVal * (i + 1));
				
			}

			// Get the remainder after Modulo 11
			int reminder = runningTotal % 11;

			if (reminder == 0)
				// This is a special case (where the remainder is 0, the Check Digit will be 0)
				checkDigit = 0;
			else
			{
				// Subtract the remainder from 11 to get the Check Digit
				checkDigit = 11 - reminder;

				if (checkDigit == 10)
					// This is a special case (Where Check Digit is 10, substitute 5)
					checkDigit = 5;
			}

			return (checkDigit);
		}
	}
}
