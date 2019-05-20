using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Diagnostics;
using Logica.Au.Mpire.Framework.Diagnostics.Tests;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logica.Au.Mpire.Framework.Diagnostics.Tests
{

	/// <summary>
	///		TODO: Insert documentation.
	/// </summary>
	[TestClass]
	public class DiagnosticSwitchTestFixture
	{

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError0000()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError0000VetoSwitch",
				new string[3]
					{
						"TraceError0000RelevantSwitch1",
						"TraceError0000RelevantSwitch2",
						"TraceError0000RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    false,
            //    dSwitch.TraceError
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError0100()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError0100VetoSwitch",
				new string[3]
					{
						"TraceError0100RelevantSwitch1",
						"TraceError0100RelevantSwitch2",
						"TraceError0100RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    false,
            //    dSwitch.TraceError
            //    );

			TraceHelper.Write(DiagnosticLevel.Verbose, "Oi!");

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError1111()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError1111VetoSwitch",
				new string[3]
					{
						"TraceError1111RelevantSwitch1",
						"TraceError1111RelevantSwitch2",
						"TraceError1111RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    true,
            //    dSwitch.TraceError
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError1011()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError1011VetoSwitch",
				new string[3]
					{
						"TraceError1011RelevantSwitch1",
						"TraceError1011RelevantSwitch2",
						"TraceError1011RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    true,
            //    dSwitch.TraceError
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError2222()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError2222VetoSwitch",
				new string[3]
					{
						"TraceError2222RelevantSwitch1",
						"TraceError2222RelevantSwitch2",
						"TraceError2222RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    true,
            //    dSwitch.TraceError
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError3333()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError3333VetoSwitch",
				new string[3]
					{
						"TraceError3333RelevantSwitch1",
						"TraceError3333RelevantSwitch2",
						"TraceError3333RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    true,
            //    dSwitch.TraceError
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError4444()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError4444VetoSwitch",
				new string[3]
					{
						"TraceError4444RelevantSwitch1",
						"TraceError4444RelevantSwitch2",
						"TraceError4444RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    true,
            //    dSwitch.TraceError
            //    );

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void TraceError4000()
		{

			DiagnosticSwitch dSwitch = null;

			dSwitch = new DiagnosticSwitch(
				"TraceError4000VetoSwitch",
				new string[3]
					{
						"TraceError4000RelevantSwitch1",
						"TraceError4000RelevantSwitch2",
						"TraceError4000RelevantSwitch3"
					}
				);

            //Assertion.AssertEquals(
            //    false,
            //    dSwitch.TraceError
            //    );

		}

	}

}