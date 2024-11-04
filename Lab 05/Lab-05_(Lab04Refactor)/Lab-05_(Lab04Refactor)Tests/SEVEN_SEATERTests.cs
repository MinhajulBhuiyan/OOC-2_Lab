using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Tests
{
    [TestClass()]
    public class SEVEN_SEATERTests
    {
        [TestMethod()]
        public void canTakeTripTest()
        {
            int distanceKM = 15;
            int timeMinutes = 30;
            int numberOfPassengers = 8;
            SEVEN_SEATER sevenSeater = new SEVEN_SEATER(distanceKM, timeMinutes, numberOfPassengers);


            bool result = sevenSeater.canTakeTrip();


            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void perHeadFareTest()
        {
            int distanceKM = 20;
            int timeMinutes = 30;
            int numberOfPassengers = 6;

            SEVEN_SEATER sevenSeater = new SEVEN_SEATER(distanceKM, timeMinutes, numberOfPassengers);

            
            int fare = sevenSeater.perHeadFare();

            
            int expectedFare = distanceKM * 30 / numberOfPassengers;
            Assert.AreEqual(expectedFare, fare);
        }
    }
}