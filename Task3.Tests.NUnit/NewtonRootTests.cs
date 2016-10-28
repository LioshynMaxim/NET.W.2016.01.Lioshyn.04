using NUnit.Framework;
using static Task3.NewtonRoot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tests.NUnit
{
    [TestFixture()]
    public class NewtonRootTests
    {
        [TestCase(2, 4, 0.0001)]
        [TestCase(2, 5, 0.0001)]
        [TestCase(2, 16, 0.00001)]
        [TestCase(3, 81, 0.00001)]
        public void NewtonRoot_СalculateNewtonRootWithAccuracy(int n, double a, double eps)
        {
            var exactValue = Math.Pow(a, 1.0/n);
            var actuality = NewtonRootN(n, a, eps);
            var aaa = Math.Abs(exactValue - actuality) <= eps;
            Assert.AreEqual(Math.Abs(exactValue - actuality) <= eps, true);
        }

        [TestCase(2, 8, 124.1)]
        [TestCase(0, 8, 0.0000001)]
        public void NewtonRoot_СalculateNewtonRootWithException(int n, double a, double eps)
        {
            Assert.That(() => NewtonRootN(n, a, eps), Throws.TypeOf<ArgumentException>());
        }
    }
}