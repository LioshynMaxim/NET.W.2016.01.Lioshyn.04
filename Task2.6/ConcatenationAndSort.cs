using System;
using System.Linq;

namespace Task2._6
{
    public static class ConcatenationAndSort
    {

        #region ConcatenationAndSortAndDeleteDuplicate
        
        /// <summary>
        /// String concatenation and Delete duplicate letters.
        /// </summary>
        /// <param name="str1">First string.</param>
        /// <param name="str2">Second String.</param>
        /// <returns>String line without deplicate letters.</returns>

        public static string ConcatenationAndSortAndDeleteDuplicate(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str1) + " or/and " + nameof(str2) + " is/are empty or null.");
            }

            string strNew = "";
            string strAll = str1 + str2;

            if (!IllegalSymbol(str1))
            {
                throw new ArgumentException(nameof(str1) + " or/and " + nameof(str2) + " have illegal symbol.");
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (strAll.IndexOf(i) > -1)
                {
                    strNew += i;
                }
            }
           
            return strNew;
        }

        #endregion

        #region Filter Laters

        /// <summary>
        /// Inspect string for illegal symbol.
        /// </summary>
        /// <param name="str">String for inspection.</param>
        /// <returns>True, if string have illegal symbol or false, if string is good.</returns>

        private static bool IllegalSymbol(string str)
        {
            return str.Any(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
        }

        #endregion
    }
}
