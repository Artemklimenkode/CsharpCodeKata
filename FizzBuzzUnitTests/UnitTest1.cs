using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzCodeKata;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDivByThree()
        {
            FizzBuzz BuzzThree = new FizzBuzz();
            Assert.AreEqual(false, BuzzThree.isDevidableByThree(2));
            Assert.AreEqual(true, BuzzThree.isDevidableByThree(3));
            Assert.AreEqual(false, BuzzThree.isDevidableByThree(1));
            Assert.AreEqual(false, BuzzThree.isDevidableByThree(4));
            Assert.AreEqual(false, BuzzThree.isDevidableByThree(5));
            Assert.AreEqual(true, BuzzThree.isDevidableByThree(6));
            Assert.AreEqual(true, BuzzThree.isDevidableByThree(0));
            Assert.AreEqual(false, BuzzThree.isDevidableByThree(-1));
        }

        [TestMethod]
        public void testIsDividableByFive() {
            FizzBuzz testObject = new FizzBuzz();

            Assert.IsTrue(testObject.isDevidableByFive(0));
            Assert.IsTrue(testObject.isDevidableByFive(5));
            Assert.IsTrue(testObject.isDevidableByFive(10));
            Assert.IsTrue(testObject.isDevidableByFive(50));

            Assert.IsFalse(testObject.isDevidableByFive(1));
            Assert.IsFalse(testObject.isDevidableByFive(2));
            Assert.IsFalse(testObject.isDevidableByFive(3));
            Assert.IsFalse(testObject.isDevidableByFive(11));
        }
    }
}
