using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab07_Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Stack.Tests
{
    [TestClass()]
    public class GenericMaxStackTests
    {

        // Test cases for Integer, Double, and String
        // Create instances of GenericMaxStack for Integer, Double, and String
        GenericMaxStack<int> stackInt = new GenericMaxStack<int>();
        GenericMaxStack<double> stackDouble = new GenericMaxStack<double>();
        GenericMaxStack<string> stackString = new GenericMaxStack<string>();

        [TestMethod()]
        public void PushTest()
        {
            
        }       

        [TestMethod()]
        public void PopTest1()
        {
            stackInt.Push(2);
            stackInt.Push(1);
            stackInt.Push(2);
            stackInt.Push(5);
            Assert.AreEqual(5,stackInt.Pop());
        }

        [TestMethod()]
        public void PopTest2()
        {
            stackDouble.Push(49.75);
            stackDouble.Push(23.54);
            stackDouble.Push(100.0);
            

            
            Assert.AreEqual(100.0, stackDouble.Pop());
        }

        [TestMethod()]
        public void PopTest3()
        {
            stackString.Push("OOC is bad");
            stackString.Push("Nothing to understand");
            stackString.Push("Try hard");

            Assert.AreEqual("Try hard", stackString.Pop());
        }

        [TestMethod()]
        public void MaxTest1()
        {
            stackInt.Push(3);
            stackInt.Push(5);
            stackInt.Push(2);

            Assert.AreEqual(5, stackInt.Max());
        }
        [TestMethod()]
        public void MaxTest2()
        {
            stackInt.Push(2);
            stackInt.Push(1);
            stackInt.Push(2);
            stackInt.Push(5);
            stackInt.Pop();

            Assert.AreEqual(2, stackInt.Max());

            stackInt.Pop();

            Assert.AreEqual(2, stackInt.Max());
        }
        [TestMethod()]
        public void MaxTest3()
        {
            stackDouble.Push(49.75);
            stackDouble.Push(23.54);
            stackDouble.Push(100.0);
            Assert.AreEqual(100.0, stackDouble.Max());

            stackDouble.Pop();
            Assert.AreEqual(49.75, stackDouble.Max());
        }
        [TestMethod()]
        public void MaxTest4()
        {
            stackString.Push("OOC is bad");
            stackString.Push("Nothing to understand");
            stackString.Push("Try hard");

            Assert.AreEqual("Try hard", stackString.Max());

            stackString.Pop();
            Assert.AreEqual("OOC is bad", stackString.Max());
        }
    }
}

