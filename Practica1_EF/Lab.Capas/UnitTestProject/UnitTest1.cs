using System;
using System.Linq;
using Lab.Logic;
using Lab.ResourseAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject 
{
    // FALTA DESARROLLAR

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


    }
}
