using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicoDos.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoDos.Extensions.Tests
{
    [TestClass()]
    public class DivisionExtensionsTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            // Arrange
            double divisor = 10;
            double dividendo = 4;
            double esperado = 2.5;

            // Act
            double resultado = divisor.Division(dividendo);

            // Assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivicionPorCeroException()
        {
            // Arrgange
            double divisor = 10;
            double dividendo = 0;

            // Act
            divisor.Division(dividendo);
        }
    }
}