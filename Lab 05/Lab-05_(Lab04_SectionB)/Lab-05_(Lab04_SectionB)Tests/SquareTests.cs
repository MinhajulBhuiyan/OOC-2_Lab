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
    public class SquareTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            var square = new Square(3, 4, 5); 

            
            double area = square.CalculateArea();

            
            double expectedArea = 25; 
            Assert.AreEqual(expectedArea, area); 
        }    
    }
}
