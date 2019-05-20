using System;
using System.Data;
using System.Text;
//using Logica.Au.Mpire.Framework;
//using Logica.Au.Mpire.Framework.Remoting;

namespace Logica.Au.Mpire.Framework.Tests
{
	/// <summary>
	/// Summary description for MpireTestHelper.
	/// </summary>
	public class MpireTestHelper
	{
		private static DateTime startTime = DateTime.Now;

		// No need for a constructor
		private MpireTestHelper()
		{
		}

		public static void OutputData(DataSet theDataSet)
		{
			OutputData(theDataSet, Console.Out, 0);
		}

		public static void OutputData(DataSet theDataSet, int maxRows)
		{
			OutputData(theDataSet, Console.Out, maxRows);
		}

		public static void OutputData(DataSet theDataSet, System.IO.TextWriter writer)
		{
			OutputData(theDataSet, writer, 0);
		}

		public static void OutputData(DataSet theDataSet, System.IO.TextWriter writer, int maxRows)
		{
			if (theDataSet == null)
			{
				writer.WriteLine("DataSet : <null>");
				writer.WriteLine("----------------");
			}
			else
			{
				writer.WriteLine(String.Format("DataSet : {0} - [{1} DataTable(s)]", theDataSet.DataSetName, theDataSet.Tables.Count));
				writer.WriteLine("----------" + new System.Text.StringBuilder().Append('-', theDataSet.DataSetName.Length));

				foreach (DataTable theTable in theDataSet.Tables)
				{
					OutputData(theTable, writer, maxRows);
				}
			}

			// Write a seperator line
			writer.WriteLine("");
		}

		public static void OutputData(DataTable theTable)
		{
			OutputData(theTable, Console.Out, 0);
		}

		public static void OutputData(DataTable theTable, System.IO.TextWriter writer)
		{
			OutputData(theTable, writer, 0);
		}

		public static void OutputData(DataTable theTable, System.IO.TextWriter writer, int maxRows)
		{
			if (theTable == null)
			{
				writer.WriteLine("DataTable : <null>");
				writer.WriteLine("------------------");
			}
			else
			{
				System.Collections.Hashtable formatSpecs = new System.Collections.Hashtable();

				// Write out the Table name
				writer.WriteLine(String.Format("DataTable : {0} - [{1} Record(s)]",theTable.TableName, theTable.Rows.Count));
				writer.WriteLine("------------" + new System.Text.StringBuilder().Append('-', theTable.TableName.Length));

				string seperator = String.Empty;

				// Iterate through the columns to get the column layout
				for (int j=0; j<theTable.Columns.Count; j++)
				{
					DataColumn column = theTable.Columns[j];

					string columnName = column.ColumnName;

					int columnWidth = 0;

					string formatSpec = "{0} ";
					string columnSpec = "{0} ";

					if (column.DataType == System.Type.GetType("System.String"))
					{
						// We need this check during development
						//System.Diagnostics.Trace.Assert(column.MaxLength > 0, String.Format("DataTable \"{0}\" does not contain a MaxLength value for string field \"{1}\"", theTable.TableName, columnName));

						// Get the width of the column, to a maximum of 50 chars
						columnWidth = System.Math.Min(column.MaxLength, 50);

						// Need to account for columns that have not been assigned a max length (assume 30)
						if (columnWidth == -1)
							columnWidth = 30;

						// Alter the format spec
						formatSpec = "{0,-" + columnWidth + "} ";
						columnSpec = formatSpec;
					}
					else if(column.DataType == System.Type.GetType("System.DateTime"))
					{
						columnWidth = "dd/MM/yyyy HH:mm:ss".Length;
						formatSpec = "{0:dd/MM/yyyy HH:mm:ss} ";
						columnSpec = "{0,-" + columnWidth.ToString() + "} ";
					}
					else if(column.DataType == System.Type.GetType("System.Int32"))
					{
						columnWidth = System.Math.Max(columnName.Length, 8);
						formatSpec = "{0, -" + columnWidth.ToString() + "} ";
						columnSpec = formatSpec;
					}
					else if(column.DataType == System.Type.GetType("System.Decimal"))
					{
						columnWidth = System.Math.Max(columnName.Length, 8);
						formatSpec = "{0, -" + columnWidth.ToString() + "} ";
						columnSpec = formatSpec;
					}
					else if(column.DataType == System.Type.GetType("System.Boolean"))
					{
						columnWidth = System.Math.Max(columnName.Length, 5);
						formatSpec = "{0, -" + columnWidth.ToString() + "} ";
						columnSpec = formatSpec;
					}

					// TODO : Format specifiers for numeric / boolean types


					formatSpecs.Add(columnName, formatSpec);

					writer.Write(String.Format(columnSpec, columnName));


					for(int i=0; i<columnWidth; i++ )
						seperator+="-";
				
					seperator += " ";

				}

				writer.WriteLine("");
				writer.WriteLine(seperator);

				int rowCount = 0;

				if (maxRows == 0)
					rowCount = theTable.Rows.Count;
				else
					rowCount = Math.Min(maxRows, theTable.Rows.Count);



				for (int i=0; i<rowCount; i++)
				{

					StringBuilder output = new StringBuilder();
					DataRow row = theTable.Rows[i];

					if (row.RowState != DataRowState.Deleted)
					{
						for (int j=0; j<theTable.Columns.Count; j++)
						{
							string columnName = theTable.Columns[j].ColumnName;

							string formatSpec = (string)formatSpecs[columnName];

							//writer.Write(String.Format(formatSpec, row[columnName]));
							output.AppendFormat(formatSpec, row[columnName]);
						}

						if (row.HasErrors)
						{
							string error = null;

							error = row.RowError;
							if (error != null && error != String.Empty)
								output.AppendFormat("[row error : \"{0}\"] ", error);

							DataColumn[] errCols = row.GetColumnsInError();

							if (errCols != null && errCols.GetLength(0) > 0)
							{
								foreach (DataColumn errCol in errCols)
								{
									output.AppendFormat("[col error : \"{0}\"] ", row.GetColumnError(errCol));
								}
							}

						}
					}
					else
					{
						// This is a deleted row
						output.Append("[Record deleted]");
					}

					writer.WriteLine(output.ToString());
				}

				// If we truncated the Records, display the number not shown
				if (rowCount < theTable.Rows.Count)
					writer.WriteLine(String.Format("[{0} Record(s) not shown]", theTable.Rows.Count - rowCount));
			}

			// Add a seperator line
			writer.WriteLine("");

		}



		public static void StartTiming()
		{
			StartTiming(Console.Out);
		}

		public static void StartTiming(System.IO.TextWriter writer)
		{
			// Hold onto the current DateTime
			startTime = DateTime.Now;

			writer.WriteLine("Start time : {0:HH:mm:ss}", startTime);
		}

		public static void StopTiming()
		{
			StopTiming(Console.Out);
		}

		public static void StopTiming(System.IO.TextWriter writer)
		{
			DateTime endTime = DateTime.Now;
			TimeSpan elapsedTime = endTime.Subtract(startTime);

			// Default resolution is milliseconds
			string units = "ms.";
			long qty = (long)elapsedTime.TotalMilliseconds;

			if(elapsedTime.TotalSeconds >= 10)
			{
				// Resolution is in seconds
				qty = (long)elapsedTime.TotalSeconds;
				units = "secs.";
			}
			else if (elapsedTime.TotalMinutes >= 60)
			{
				// Resolution is in minutes
				qty = (long)elapsedTime.TotalMinutes;
				units = "min.";
			}
			// Write out the Stop Time and the Elapsed Time
			writer.WriteLine("Stop time  : {0:HH:mm:ss} - (Elapsed time : {1} {2})", endTime, qty, units);

		}

	}
}
