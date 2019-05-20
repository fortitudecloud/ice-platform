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
	public class DebugHelperTestFixture
	{

		public DebugHelperTestFixture()
		{
		}

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
		public void WriteMethodEntry1()
		{

			DebugHelper.WriteMethodEntry();

		}

		/// <summary>
		///		TODO: Insert documentation.
		/// </summary>
		[TestMethod]
		public void WriteMethodExit1()
		{

			DebugHelper.WriteMethodExit();

		}

	}

}