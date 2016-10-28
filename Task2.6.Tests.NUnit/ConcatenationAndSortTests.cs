using NUnit.Framework;
using static Task2._6.ConcatenationAndSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6.Tests.NUnit
{
    [TestFixture()]
    public class ConcatenationAndSortTests
    {
        [TestCase("aksjfhdladkjfhgkfldalskdjfhghfjdkdlslaksjdhfk", "zmxncbcvgdbcjnzbcvxmnbvcxzahsjdjfhkjhhasddgzsdhzcbnhgvsd", ExpectedResult = "abcdfghjklmnsvxz")]
        [TestCase("alskdjfhgmznxbcvgdbHBGDSCBJMNBCFKAM", "zmxzbcvxmnbvSDFcxzahsjdjfhkjhhasdghbhjcbzSDFSDAFFnhgvsd", ExpectedResult = "abcdfghjklmnsvxz")]
        public void ConcatenationAndSortAndDeleteDuplicateTest_Exist(string str1, string str2, string expectedResult)
        {
            var actual = ConcatenationAndSortAndDeleteDuplicate(str1, str2);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(null, null)]
        [TestCase(null, "fff")]
        [TestCase("", "fff")]
        [TestCase(".;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;;.;.", "")]
        public void ConcatenationAndSortAndDeleteDuplicateTest_FailNullException(string str1, string str2)
        {
            Assert.That(() => ConcatenationAndSortAndDeleteDuplicate(str1, str2), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase(".;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;;.;.", "zmxncbcvgdbcjnzbcvxmnbvcxzahsjdjfhkjhhas")]
        public void ConcatenationAndSortAndDeleteDuplicateTest_FailArgumentException(string str1, string str2)
        {
            Assert.That(() => ConcatenationAndSortAndDeleteDuplicate(str1, str2), Throws.TypeOf<ArgumentException>());
        }

    }
    
}