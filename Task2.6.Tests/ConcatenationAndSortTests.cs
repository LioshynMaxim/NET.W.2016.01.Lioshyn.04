using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task2._6.ConcatenationAndSort;
using System;

namespace Task2._6.Tests
{
    [TestClass()]
    public class ConcatenationAndSortTests
    {
        [TestMethod()]
        public void Equals_TwoLongestString_abcdfghjklmnsvxz()
        {
            string str1 = "aksjfhdladkjfhgkfldalskdjfhghfjdkdlslaksjdhfk";
            string str2 = "zmxncbcvgdbcjnzbfhkjhhasdghbhjcbzhjzsvdgzsdhzcbnhgvsd";
            
            var expected = "abcdfghjklmnsvxz";
            var actual = ConcatenationAndSortAndDeleteDuplicate(str1, str2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Exception_AllNullString_Fail()
        {
            ConcatenationAndSortAndDeleteDuplicate(null, null);
            Assert.Fail(); 
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Exception_OneEmptyString_Fail()
        {
            ConcatenationAndSortAndDeleteDuplicate("mmm", null);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Equals_TwoLongestStringWithOverSymbols_Fail()
        {
            string str1 = ".;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;;.;.";
            string str2 = "zmxncbcvgdbcjnzbcvxmnbvcxzahsjdjfhkjhhas";

            ConcatenationAndSortAndDeleteDuplicate(str1, str2);

            Assert.Fail();
        }

        [TestMethod]
        public void Equals_TwoLongestStringWithSmallAndBigLatters_Fail()
        {
            string str1 = "alskdjfhgmznxbcvgdbHBGDSCBJMNBCFKAM";
            string str2 = "zmxzbcvxmnbvSDFcxzahsjdjfhkjhhasdghbhjcbzSDFSDAFFnhgvsd";
            
            var expected = "abcdfghjklmnsvxz";
            var actual = ConcatenationAndSortAndDeleteDuplicate(str1, str2);

            Assert.AreEqual(expected, actual);
        }

    }
}