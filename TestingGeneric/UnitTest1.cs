using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Generic;
namespace TestingGeneric
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 101, 55, 77, 23, 67, 51 };
            int actual = new MaxOfThreeNumbers<int>(array).MaxValue();
            int expected = 101;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestMethodString()
        {
            string[] array = { "Cat", "Bat", "Rat", "Fat" };
            string actual = new MaxOfThreeNumbers<string>(array).MaxValue();
            string expected = "Rat";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDouble1()
        {
            double[] array = { 10.1, 5.5, 7.7, 2.3, 6.7, 5.1 };
            double actual = new MaxOfThreeNumbers<double>(array).MaxValue();
            double expected = 10.1;
            Assert.AreEqual(expected, actual);
        }
    }
}
       
