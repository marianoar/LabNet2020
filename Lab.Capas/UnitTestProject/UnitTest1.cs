using System;
using Errores;
using Lab.ResourceAcces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodContext()
        {
            NorthwindContext context;

            context = new NorthwindContext();

            Assert.IsNotNull(context);
        }

        [ExpectedException(typeof(SaveLogsException))]
        [TestMethod]
        public void TestMethodSaveLogs()
        {
            throw new SaveLogsException("Test Method");
        }


    }
}


