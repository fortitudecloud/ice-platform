using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Validation;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace Logica.Au.Mpire.Framework.Validation
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[Serializable()]
	public class DataValidationError
	{

		private static TraceSwitch ourTraceSwitch = null;

		private string myDescription = null;
		private DataRow[] myDataRows = null;
		private string mySource = null;
        private bool isWarning = false;

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		static DataValidationError()
		{

			DataValidationError.ourTraceSwitch = new TraceSwitch(
				"Logica.Au.Mpire.Framework.Validation.DataValidationError",
				"TraceSwitch for the DataValidationError class."
				);

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="description">
		///		TODO: Insert documentation.
		/// </param>
		public DataValidationError(string description)
		{

			#region Tracing . . .
			if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationError(string) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (description == null)
			{

				throw new ArgumentNullException(
					"description",
					"Description cannot be null."
					);

			}

			if (description == string.Empty)
			{

				throw new ArgumentException(
					"Description cannot be an empty string.",
					description
					);

			}
			#endregion

			this.myDescription = description;
			this.myDataRows = new DataRow[0];

			#region Tracing . . .
			if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationError(string) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

        /// <summary>
        ///		TODO: Insert documentation.
        /// </summary>
        /// <param name="description">
        ///		TODO: Insert documentation.
        /// </param>
        public DataValidationError(string description, bool isWarning)
        {

            #region Tracing . . .
            if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
            {

                Trace.WriteLine(
                    "Entering the DataValidationError(string) constructor.",
                    MethodInfo.GetCurrentMethod().ReflectedType.Name
                    );

            }
            #endregion

            #region Validation . . .
            if (description == null)
            {

                throw new ArgumentNullException(
                    "description",
                    "Description cannot be null."
                    );

            }

            if (description == string.Empty)
            {

                throw new ArgumentException(
                    "Description cannot be an empty string.",
                    description
                    );

            }
            #endregion

            this.myDescription = description;
            this.isWarning = isWarning;
            this.myDataRows = new DataRow[0];

            #region Tracing . . .
            if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
            {

                Trace.WriteLine(
                    "Leaving the DataValidationError(string) constructor.",
                    MethodInfo.GetCurrentMethod().ReflectedType.Name
                    );

            }
            #endregion

        }


		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="row">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="description">
		///		TODO: Insert documentation.
		/// </param>
		public DataValidationError(string description, DataRow row)
		{

			#region Tracing . . .
			if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationError(string, DataRow) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (description == null)
			{

				throw new ArgumentNullException(
					"description",
					"Description cannot be null."
					);

			}

			if (description == string.Empty)
			{

				throw new ArgumentException(
					"Description cannot be an empty string.",
					description
					);

			}

			if (row == null)
			{

				throw new ArgumentNullException(
					"row",
					"Row cannot be null."
					);

			}
			#endregion

			this.myDescription = description;
			this.myDataRows = new DataRow[1] { row };

			#region Tracing . . .
			if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationError(string, DataRow) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		/// <param name="row">
		///		TODO: Insert documentation.
		/// </param>
		/// <param name="description">
		///		TODO: Insert documentation.
		/// </param>
		public DataValidationError(string description, DataRow[] rows)
		{

			#region Tracing . . .
			if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Entering the DataValidationError(string, DataRow[]) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

			#region Validation . . .
			if (description == null)
			{

				throw new ArgumentNullException(
					"description",
					"Description cannot be null."
					);

			}

			if (description == string.Empty)
			{

				throw new ArgumentException(
					"Description cannot be an empty string.",
					description
					);

			}

			if (rows == null)
			{

				throw new ArgumentNullException(
					"rows",
					"Rows cannot be null."
					);

			}
			#endregion

			this.myDescription = description;
			this.myDataRows = rows;

			#region Tracing . . .
			if (DataValidationError.ourTraceSwitch.TraceVerbose == true)
			{
			
				Trace.WriteLine(
					"Leaving the DataValidationError(string, DataRow[]) constructor.",
					MethodInfo.GetCurrentMethod().ReflectedType.Name
					);

			}
			#endregion

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string Description
		{

			get
			{

				return this.myDescription;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public DataRow[] DataRows
		{
		
			get
			{

				return this.myDataRows;

			}

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		public string Source
		{

			get
			{

				return this.mySource;

			}

			set
			{

				this.mySource = value;

			}

		}

        /// <summary>
        ///		TODO: Insert documentation.
        /// </summary>
        public bool IsWarning
        {

            get
            {

                return this.isWarning;

            }

        }

	}

}