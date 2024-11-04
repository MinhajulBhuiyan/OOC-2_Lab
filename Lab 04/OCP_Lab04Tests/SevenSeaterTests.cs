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
    public class SevenSeaterTests
    {
        SevenSeater _sevenseater = new SevenSeater();
        [TestMethod()]
        public void CanTakeTripTest()
        {
            bool expected = true;
            Assert.IsTrue(_sevenseater.CanTakeTrip(10, 7));
        }

        [TestMethod()]
        public void CalculateFareTest()
        {
            Assert.Equals(100, _sevenseater.CalculateFare(10,10,3));
        }
    }
}