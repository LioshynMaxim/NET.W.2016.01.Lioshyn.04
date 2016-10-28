using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task1.Arrays;

namespace Task1.Tests.NUnit
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void Method_OnlyOne_Exist()
        {
            //Arrange Act Assert (AAA)
            //Arrange
            var arr = new[] { 1, 1, 1, 1, 1 };
            int expected = 2;

            //Act
            int actual = EqualityLeftAndRight(arr);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Method_SequencePositiveNumber_Exist()
        {
            var arr = new[] { 0, 1, 2, 3, 5, 6 };
            int expected = 4;
            int actual = EqualityLeftAndRight(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Method_RandonNumber_Exist()
        {
            var arr = new[] { 1, 100, 50, -51, 1, 1 };
            int expected = 1;

            int actual = EqualityLeftAndRight(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Method_RandonNumber_NotExist()
        {
            var arr = new[] { 1, 100, 50, -51, 1, 1, 1 };
            int expected = -1;
            int actual = EqualityLeftAndRight(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void Method_Consist0Elements_NoExist()
        {
            int[] arr = new int[] {};
            int actual = EqualityLeftAndRight(arr);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Method_ConsistNullReference_NoExist()
        {
            int actual = EqualityLeftAndRight(null);
            Assert.Fail();
        }
    }
}
