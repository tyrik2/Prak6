using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prak6;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TestF
    {
        [TestMethod]
        public void TestF1()
        {
            int x = 123;
            int expected = 3;
            int actual = MainWindow.f(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestF2()
        {
            int x = 456;
            int expected = 6;
            int actual = expected.f(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestF3()
        {
            int x = 789;
            int expected = 9;
            int actual = MainWindow.f(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
