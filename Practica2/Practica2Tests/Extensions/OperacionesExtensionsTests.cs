using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Extensions.Tests
{
    [TestClass()]
    public class OperacionesExtensionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivCeroTest()
        {
            //Arrange
            int numero = 10;

            try
            {
                numero.DivCero();
            }
            catch
            {
                throw;
            }

            


        }
    } 
}