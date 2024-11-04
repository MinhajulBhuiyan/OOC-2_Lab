using Microsoft.VisualStudio.TestTools.UnitTesting;
using BottleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleProject.Tests
{

    [TestClass()]
    public class BottlesTests
    {
        Bottles _bottles = new Bottles();
        [TestMethod()]
        public void verseTest()
        {
            int lineNumber = 88;
            string expected = $"{lineNumber} bottles of beer on the wall , {lineNumber} bottles of beer .\n" +
                              $" Take one down and pass it around , {lineNumber - 1} bottles of beer on the wall .\n";
            Assert.AreEqual(expected, _bottles.verse(lineNumber));
        }

        [TestMethod()]
        public void versesTest()
        {

        }
    }
}