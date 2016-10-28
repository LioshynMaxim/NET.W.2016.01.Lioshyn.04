using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task3.NewtonRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tests
{
    [TestClass()]
    public class NewtonRootTests
    {
        [TestMethod]
        public void Radical_2Form4_accuracy2()
        {
            var actual = NewtonRootN(4, 2, 2);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Radical_2Form5_accuracy3()
        {
            NutonRadical nutonRadical = new NutonRadical(5, 2, 3);
            var actual = nutonRadical.Radical();

            var actual = NewtonRootN(4, 2, 2);
            var expected = Math.Round(Math.Pow(5, 1.0 / 2), 3);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Radical_20Form5_accuracy3()
        {
            NutonRadical nutonRadical = new NutonRadical(5, 20, 3);
            var actual = nutonRadical.Radical();

            var actual = NewtonRootN(4, 2, 2);
            var expected = Math.Round(Math.Pow(5, 1.0 / 20), 3);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Radical_NaNNumber_accuracy3()
        {
            NutonRadical nutonRadical = new NutonRadical(double.NaN, 20, 3);
            var actual = nutonRadical.Radical();

            var actual = NewtonRootN(4, 2, 2);
            var expected = Math.Round(Math.Pow(5, 1.0 / 20), 3);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Radical_NaNPower_accuracy3()
        {
            NutonRadical nutonRadical = new NutonRadical(10, double.NaN, 3);
            var actual = nutonRadical.Radical();

            var actual = NewtonRootN(4, 2, 2);
            var expected = Math.Round(Math.Pow(5, 1.0 / 20), 3);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Radical_NaNAccuracy_accuracy3()
        {
            NewtonRootN(10, 3, double.NaN);
            
            Assert.Fal;
        }
    }
}