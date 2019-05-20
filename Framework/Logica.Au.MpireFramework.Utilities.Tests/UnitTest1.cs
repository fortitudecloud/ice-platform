using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logica.Au.MpireFramework.Utilities.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetStructureConstantNameFromValue()
        {
            string result;

            result = Logica.Au.Mpire.Framework.Definitions.SysLists.ReceivedMethodList.Api.ToString();

            Assert.AreEqual(result, "Api");
        }
    }
}
