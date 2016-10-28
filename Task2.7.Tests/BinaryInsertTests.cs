using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task2._7.BinaryInsert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7.Tests
{
    [TestClass()]
    public class BinaryInsertTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = Insertion(8, 15, 0, 0);
            var actual = 9;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            var expected = Insertion(0, 15, 30, 30);
            var actual = 1073741824;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            var expected = Insertion(0, 15, 0, 30);
            var actual = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            var expected = Insertion(15, -15, 4, 4);
            var actual = 31;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod5()
        {
            var expected = Insertion(15, int.MaxValue, 3, 5);
            var actual = 63;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod6()
        {
            var expected = Insertion(15, int.MaxValue, -3, 5);
            var actual = 63;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod7()
        {
            var expected = Insertion(15, int.MaxValue, -3, -5);
            Assert.Fail();
        }
        
    }
}