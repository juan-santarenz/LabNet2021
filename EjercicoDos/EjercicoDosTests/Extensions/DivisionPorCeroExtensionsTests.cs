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
    public class DivisionPorCeroExtensionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCeroTestException()
        {
            // Arrange
            int numero = 10;

            // Act
            numero.DividirPorCero();
        }
    }
}