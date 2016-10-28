using NUnit.Framework;
using static Task1.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests.NUnit
{
    [TestFixture()]
    public class ArraysTests
    {
        [TestCase(new[] { 1, 1, 1, 1, 1 }, ExpectedResult = 2)]
        [TestCase(new[] { 0, 1, 2, 3, 5, 6 }, ExpectedResult = 4)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1, 1 }, ExpectedResult = -1)]
        public int EqualityLeftAndRight_FindIndexEquality(int[] arr)
        {
            return EqualityLeftAndRight(arr);
        }

        [TestCase(new[] { 1, 2 })]
        [TestCase(new int[] {})]
        public void FindIndex_TestForArgumentException(int[] arr)
        {
            Assert.That(() => EqualityLeftAndRight(arr), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(null)]
        public void FindIndex_TestForArgumentNullException(int[] arr)
        {
            Assert.That(() => EqualityLeftAndRight(arr), Throws.TypeOf<NullReferenceException>());
        }
    }
}