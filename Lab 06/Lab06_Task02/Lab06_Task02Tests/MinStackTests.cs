using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab06_Task02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Task02.Tests
{
    [TestClass()]
    public class MinStackTests
    {
        
        [TestMethod]
        public void TestPushPopAndMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(3);
            minStack.Push(2);
            minStack.Push(5);
            minStack.Push(1);

            int min = minStack.Min();

            Assert.AreEqual(1, min);

            minStack.Pop();
            min = minStack.Min();
            Assert.AreEqual(2, min);

            minStack.Push(12);
            minStack.Push(3);
            minStack.Push(4);

            min = minStack.Min();

            Assert.AreNotEqual(3, min);
        }       
      
    }
}