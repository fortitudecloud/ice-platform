using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// Summary description for ColumnArray.
	/// </summary>
	public class ColumnArray
	{
		public ColumnArray()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		// Retrieve a single column from out of a DataTable as a one-dimensional array
		public static string[] GetColumnArray(DataTable dataTable, string columnName)
		{
			// Size the array to the count of the non-deleted rows in the DataTable
			string[] theArray = new string[dataTable.Select().GetLength(0)];
			int rowNum = 0;

			// Iterate through each row in the DataTable
			foreach (DataRow theRow in dataTable.Rows)
			{
				// We must explicitly avoid deleted rows, as we cannot reference their data
				if (theRow.RowState != DataRowState.Deleted)
				{
					// Get the value from the DataTable's enumerator
					theArray[rowNum] = theRow[columnName].ToString();

					// Increment the array indexer
					rowNum++;
				}
			}

			// Return the array of string
			return (theArray);
		}


	}
}
