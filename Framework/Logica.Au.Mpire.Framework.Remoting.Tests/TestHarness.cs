using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Logica.Au.Mpire.Framework.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logica.Au.Mpire.Framework.Remoting.Tests
{
	
	[TestClass]
	public class TestHarness
	{
		public TestHarness()
		{
		}

		[TestMethod]
		public void Test000()
		{

			MpireTestHelper.StartTiming();
			MpireResponseErrorCollection col = new MpireResponseErrorCollection();
			col.Add(new MpireResponseError("World", "Hello"));
			col.Add(new MpireResponseError("World", "Hello"));
			foreach(MpireResponseError err in col)
			{
				Console.WriteLine("Error: '{0}' in '{1}'", err.Message, err.Source);
			}
			MpireTestHelper.StopTiming();

		}

		[TestMethod]
		public void Test001()
		{

			MpireTestHelper.StartTiming();
			TestResponse response = new TestResponse();
			response.Errors.Add(new MpireResponseError("World", "Hello"));
			response.Errors.Add(new MpireResponseError("World", "Hello"));
			foreach(MpireResponseError err in response.Errors)
			{
				Console.WriteLine("Response Error: '{0}' in '{1}'", err.Message, err.Source);
			}
			MpireTestHelper.StopTiming();

		}

		[TestMethod]
		public void Test002()
		{

			MpireTestHelper.StartTiming();
			TestResponse response = new TestResponse();
			response.Errors.Add(new MpireResponseError("World", "Hello"));
			response.Errors.Add(new MpireResponseError("World", "Hello"));
			for (int i=0; i<response.Errors.Count;i++)
			{
				Console.WriteLine("Response Error: '{0}' in '{1}'", response.Errors[i].Message, response.Errors[i].Source);
			}
			MpireTestHelper.StopTiming();

		}
// the following code has error during compilation. 
//		[TestMethod]
//		public void Test003()
//		{
//
//			MpireTestHelper.StartTiming();
//			MpireResponseErrorCollection col = new MpireResponseErrorCollection();
//			col.Add(new MpireResponseError("World", "Hello"));
//			col.Add(new MpireResponseError("World", "Hello"));
//
//			MpireResponseError err = null;
//			
//			err = (MpireResponseError) col.Current;
//			Assertion.AssertNull("Current is Null", err);
//			
//			col.Reset();
//			
//			err = (MpireResponseError) col.Current;
//			Assertion.AssertNull("Current is Null", err);
//			
//			col.MoveNext();
//
//			err = (MpireResponseError) col.Current;
//			Assertion.AssertNotNull("Current is Not Null", err);
//
//		}
//
	}

	public class TestResponse : MpireResponse
	{

	}

}
