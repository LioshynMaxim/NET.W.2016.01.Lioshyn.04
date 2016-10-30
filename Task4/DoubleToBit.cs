using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class DoubleToBit
    {
        /// <summary>
        /// Extension Method for the binary representation of real numbers in double-precision IEEE 754 format.
        /// </summary>
        /// <param name="dtb">The entered real number.</param>
        /// <returns>The string representation of a binary number.</returns>
        public static string DoubleToBitConverter(this double dtb)
        {
            if (Double.IsNaN(dtb))
            {
                throw new ArgumentException();
            }

            BitArray bitArray = new BitArray(BitConverter.GetBytes(dtb));
            int size = bitArray.Length;
            StringBuilder stringRepresentation = new StringBuilder(size);

            for (int i = size - 1; i >= 0; i--)
            {
                stringRepresentation.Append(bitArray[i] ? '1' : '0');
            }

            return stringRepresentation.ToString();
        }
    }
}
