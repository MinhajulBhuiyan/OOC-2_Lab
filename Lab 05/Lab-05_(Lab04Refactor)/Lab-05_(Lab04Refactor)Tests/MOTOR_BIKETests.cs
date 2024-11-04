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
    public class MOTOR_BIKETests
    {
        [TestMethod()]
        public void canTakeTripTest()
        {
            // Arrange
            int distanceKM = 8; 
            int timeMinutes = 30; 
            int numberOfPassengers = 1; 
            MOTOR_BIKE motorBike = new MOTOR_BIKE(distanceKM, timeMinutes, numberOfPassengers);

            // Act
            bool result = motorBike.canTakeTrip();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void perHeadFareTest()
        {
            // Arrange
            int distanceKM = 20;
            int timeMinutes = 30;
            int numberOfPassengers = 2;
            MOTOR_BIKE motorBike = new MOTOR_BIKE(distanceKM, timeMinutes, numberOfPassengers);

            // Act
            int fare = motorBike.perHeadFare();

            // Assert
            int expectedFare = Math.Max(25, distanceKM * 20) / numberOfPassengers;
            Assert.AreEqual(expectedFare, fare);
        }
    }
}
