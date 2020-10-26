using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void TestLanzarPropiaExpecion()
        {
            Logic.LanzarExcepcionPersonalizada();
        }

        [TestMethod]
        public void TestOperacion()
        {
            int divisor, dividendo, resultado;

            dividendo = 100;
            divisor = 2;

            resultado = dividendo / divisor;

            Assert.IsNotNull(resultado);
        }
    }
}
