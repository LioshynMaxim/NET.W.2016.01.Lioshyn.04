using NUnit.Framework;
using static Task2._7.BinaryInsert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7.Tests.NUnit
{
    [TestFixture()]
    public class BinaryInsertTests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(15, -15, 4, 4, ExpectedResult = 31)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        public long InsertionTest_Exist(int first, int second, int i, int j)
        {
            return Insertion(first, second, i, j);
        }

        [TestCase(8, 15, -1, 0)]
        [TestCase(0, 15, 30, 35)]
        [TestCase(0, 15, 30, 26)]
        public void InsertionTest_Exception(int first, int second, int i, int j)
        {
            Assert.That(()=>Insertion(first, second, i, j), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}