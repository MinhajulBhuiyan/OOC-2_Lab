using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab06_Task01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Task01.Tests
{
    [TestClass()]
    public class FizzbuzzTests
    {
        [TestMethod]
        public void TestFizz()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            string result = fizzbuzz.getFizzyBuzz(9); 
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void TestBuzz()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            string result = fizzbuzz.getFizzyBuzz(14); 
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            string result = fizzbuzz.getFizzyBuzz(21); 
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void TestGotcha()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            string result = fizzbuzz.getFizzyBuzz(5); 
            Assert.AreEqual("Gotcha", result);
        }
    }
}