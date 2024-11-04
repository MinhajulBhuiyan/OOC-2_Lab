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
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            var circle = new Circle(39, 78, 12);
            double expected = Math.PI * 144;

            double result = circle.CalculateArea();

            Assert.AreEqual(expected, result);
        }
    }
}