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
    public class SedanTests
    {
        [TestMethod()]
        public void canTakeTripTest()
        {
            int distanceKM = 20; 
            int timeMinutes = 30; 
            int numberOfPassengers = 4; 
            Sedan sedan = new Sedan(distanceKM, timeMinutes, numberOfPassengers);


            bool result = sedan.canTakeTrip();

            
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void perHeadFareTest()
        {
            int distanceKM = 20;
            int timeMinutes = 30;
            int numberOfPassengers = 4;

            Sedan sedan = new Sedan(distanceKM, timeMinutes, numberOfPassengers);

            
            int fare = sedan.perHeadFare();

            
            int expectedFare = (50 + distanceKM * 30 + timeMinutes * 2) / numberOfPassengers;
            Assert.AreEqual(expectedFare, fare);
        }
    }
}