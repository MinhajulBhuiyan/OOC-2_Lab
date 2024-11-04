using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCP_Lab04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Lab04.Tests
{
    [TestClass()]
    public class SedanTests
    {
        Sedan _sedan = new Sedan();
        [TestMethod()]
        public void CalculateFareTest()
        {
            bool expected = true;
            Assert.AreEqual(true, _sedan.CanTakeTrip(20, 3));
        }

        [TestMethod()]
        public void CalculateFareTest1()
        {
            int expected = 236;
            Assert.AreEqual(expected, _sedan.CalculateFare(20, 30, 3));
        }
    }
}