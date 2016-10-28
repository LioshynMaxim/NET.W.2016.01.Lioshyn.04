using NUnit.Framework;
using static Task3.NewtonRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tests.NUnit
{
    [TestFixture()]
    public class NewtonRootTests
    {
        [TestCase(2, 8, 0.0001)]
        [TestCase(2, 8, 0.0001)]
        [TestCase(3, 8, 0.0000001)]
        public bool NewtonRoot_СalculateNewtonRootWithAccuracy(int n, double a, double eps)
        {
            return (Math.Abs(Math.Pow(a,1.0/n) - NewtonRootN(n, a, eps)) < eps);
        }

        [TestCase(2, 8, 124.1)]
        [TestCase(0, 8, 0.0000001)]
        public void NewtonRoot_СalculateNewtonRootWithException(int power, double a, double eps)
        {
            Assert.That(() => NewtonRootN(power, a, eps), Throws.TypeOf<ArgumentException>());
        }
    }
}