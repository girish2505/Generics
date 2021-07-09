using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Generic;
namespace TestingGeneric
{
    [TestClass]
    public class UnitTest1
    {
        MaxOfThreeNumbers maxOfThreeNumbers;
        [TestInitialize]
        public void SetUp()
        {
            maxOfThreeNumbers = new MaxOfThreeNumbers();
        }
        [TestMethod]
        public void TestMethod1()
        {

            int num1, num2, num3, actual, expected;
            //TC 1.1
            //AAA Methodology Arrange,Act,Assert
            num1 = 3; num2 = 2; num3 = 1;
            expected = num1;
            actual = maxOfThreeNumbers.MaxOfThree(num1, num2, num3);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //TC 1.2
            //AAA
            int num1, num2, num3, actual, expected;
            num1 = 1; num2 = 3; num3 = 2;
                expected = num2;
            //Act
            actual = maxOfThreeNumbers.MaxOfThree(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Tc 1.3
            //Arrange
            int num1, num2, num3, actual, expected;
            num1 = 1; num2 = 2; num3 = 3;
            expected = num3;
            //Act
            actual = maxOfThreeNumbers.MaxOfThree(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
