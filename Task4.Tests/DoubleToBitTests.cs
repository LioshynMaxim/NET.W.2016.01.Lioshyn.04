using NUnit.Framework;
using static Task4.DoubleToBit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Tests
{
    [TestFixture()]
    public class DoubleToBitTests
    {
        [TestCase(1325.25, ExpectedResult = "0100000010010100101101010000000000000000000000000000000000000000")]
        [TestCase(6546545.545, ExpectedResult = "0100000101011000111110010001110001100010111000010100011110101110")]
        [TestCase(-124.55, ExpectedResult = "1100000001011111001000110011001100110011001100110011001100110011")]
        [TestCase(155856.546, ExpectedResult = "0100000100000011000001101000010001011110001101010011111101111100")]
        [TestCase(15458799817.15458, ExpectedResult = "0100001000001100110010110101010010000110010010010011110010010100")]
        public string TestDoubleToBitConverter(double number)
        {
            return number.DoubleToBitConverter();
        }
    }
}