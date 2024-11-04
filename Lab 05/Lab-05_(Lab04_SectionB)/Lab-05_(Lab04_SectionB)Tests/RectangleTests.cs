using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_05__Lab04_SectionB_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05__Lab04_SectionB_.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            // Arrange
            var rectangle = new Lab_05__Lab04_SectionB_.Rectangle(2, 3, 4, 5);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            double expectedArea = 4 * 5;
            Assert.AreEqual(expectedArea, area, 0.001);
        }
    }
}