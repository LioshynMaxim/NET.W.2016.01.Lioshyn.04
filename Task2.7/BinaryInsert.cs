using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    public static class BinaryInsert
    {
        #region Insertion

        /// <summary>
        /// Function returned integer decimal answer
        /// </summary>
        /// <param name="firstNumberInt">First integer number</param>
        /// <param name="secondNumberNumberInt">Second integer number</param>
        /// <param name="i">Index i-th position</param>
        /// <param name="j">Index j-th position</param>
        /// <returns>Decimal answer</returns>

        public static long Insertion(int firstNumberInt, int secondNumberNumberInt, int i, int j)
        {
            if ((j < i) || (j < 0) || (j > 31) || (i < 0) || (i > 31))
            {
                throw new ArgumentOutOfRangeException();
            }

            if ((firstNumberInt > int.MaxValue) || (secondNumberNumberInt > int.MaxValue) || (i > int.MaxValue) || (j > int.MaxValue))
            {
                throw new TypeAccessException();
            }

            BitArray firstNumberBitArray = ToBinary(firstNumberInt);
            BitArray secondNumberBitArray = ToBinary(secondNumberNumberInt);
        
            for (int index1 = i, index2 = 0; index1 <= j; index1++, index2++)
            {
                firstNumberBitArray[index1] = secondNumberBitArray[index2];
            }

            return ToNumeral(firstNumberBitArray);
        }

        #endregion

        #region ToBinary

        /// <summary>
        /// Translations into bits from integer
        /// </summary>
        /// <param name="numeral">Integer numtral</param>
        /// <returns>Bit array</returns>

        private static BitArray ToBinary(int numeral)
        {
            return new BitArray(new[] { numeral });
        }

        #endregion

        #region ToNumeral

        /// <summary>
        /// Translations into integer from bits
        /// </summary>
        /// <param name="binary">Binary array</param>
        /// <returns>Numeral</returns>

        private static long ToNumeral(BitArray binary)
        {
            if (binary == null)
                throw new ArgumentNullException("binary");
            if (binary.Length > 32)
                throw new ArgumentException("must be at most 32 bits long");

            var result = new int[1];
            binary.CopyTo(result, 0);
            return result[0];
        }

        #endregion
    }
}
