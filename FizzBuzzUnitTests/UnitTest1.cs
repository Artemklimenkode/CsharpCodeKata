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

        }
       
    }
}
