using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Capas.Entities;
using Lab.Logic;
using Lab.ResourseAccess;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodContext()
        {
            NorthwindContext context = new NorthwindContext();

            Assert.IsNotNull(context);
        }
        [TestMethod]
        public void TestMethod()
        {
            SupplierLogic supplierLogic = new SupplierLogic();
            var suppliers = supplierLogic.Suppliers();

            Assert.IsNotNull(suppliers);
        }

    }
}

