using System;
using System.Data;

namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// Summary description for ListHelper.
	/// </summary>
	public class ListHelper
	{
		private ListHelper()
		{
		}


		// Given a listvaluename, look up the corresponding listvalueid in the given dataTable.
		public static string GetListValueIDFromListValueName( DataTable dataTable, string ListValueName )
		{
			
			if( ListValueName == null )
			{
				throw new ArgumentNullException( "ListValueName", "The ListValueName parameter may not be a Null.");
			}

			if( ListValueName == string.Empty )
			{
				throw new ArgumentException("The ListValueName parameter may not be empty.", "ListValueName" );
			}

			if( dataTable == null )
			{
				throw new ArgumentNullException( "dataTable" , "The dataTable argument must not be null.");
			}

			if( dataTable.Rows.Count == 0 )
			{
				throw new ArgumentException("The dataTable argument must contain at least 1 datarow.", "dataTable");
			}

			if( !( dataTable.Columns.Contains( "ListValueName" ) &&
				   dataTable.Columns.Contains( "ListValueID" ) )    )
			{
				throw new ArgumentException("The dataTable argument must represent an Mpire List Table", "dataTable");
			}
			
			// get the value
			string Filter = string.Format("ListValueName='{0}'", ListValueName );
			DataRow[] myRow = dataTable.Select( Filter );

			if( myRow.GetLength(0) > 1 )
			{
				throw new ConstraintException("The ListValueName parameter value was not unique in the provided dataTable.");
			}

			if( myRow.GetLength(0) < 1 )
			{
				throw new ArgumentOutOfRangeException("The ListValueName parameter value was not in the provided dataTable.", "ListValueName"); 
			}

			return ( myRow[0]["ListValueID"].ToString() );
			
		}




		// Given the listvalueID, lookup the listvalueName in the given datatable.
		public static string GetListValueNameFromListValueID( DataTable dataTable, string ListValueID )
		{
			if( ListValueID == null )
			{
				throw new ArgumentNullException( "ListValueID", "The ListValueID parameter may not be a Null.");
			}

			if( ListValueID == string.Empty )
			{
				throw new ArgumentException("The ListValueID parameter may not be empty.", "ListValueID" );
			}

			if( dataTable == null )
			{
				throw new ArgumentNullException( "dataTable" , "The dataTable argument must not be null.");
			}

			if( dataTable.Rows.Count == 0 )
			{
				throw new ArgumentException("The dataTable argument must contain at least 1 datarow.", "dataTable");
			}

			if( !( dataTable.Columns.Contains( "ListValueID" ) &&
				   dataTable.Columns.Contains( "ListValueName" ) )    )
			{
				throw new ArgumentException("The dataTable argument must represent an Mpire List Table", "dataTable");
			}
			
			// get the value
			string Filter = string.Format("ListValueID='{0}'", ListValueID );
			DataRow[] myRow = dataTable.Select( Filter );

			if( myRow.GetLength(0) > 1 )
			{
				throw new ConstraintException("The ListValueID parameter value was not unique in the provided dataTable.");
			}

			if( myRow.GetLength(0) < 1 )
			{
				throw new ArgumentOutOfRangeException("The ListValueID parameter value was not in the provided dataTable.", "ListValueID"); 
			}

			return ( Convert.ToString( myRow[0]["ListValueName"] ));
		}

	

	}
}
