using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Arrays
    {
        #region EqualityLeftAndRight

        /// <summary>
        /// The function of finding that the sum of the left and right side.
        /// </summary>
        /// <returns>Index at which are the left and right part.If such an index is not present, it displays -1</returns>
        /// <exception cref="ArgumentException"></exception>

        public static int EqualityLeftAndRight(int[] arr)
        {
            if (arr.Length < 3)
            {
                throw new ArgumentException(nameof(arr) + " it contains no index");
            }

            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr) + " it null no index");
            }
           
            int index = 0;
            bool flag = true;
            while (flag)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int i = 0; i < index; i++)
                {
                    leftSum += arr[i];
                }

                for (int i = ++index; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }

                if ((index == arr.Length))
                {
                    return -1;
                }

                if (leftSum == rightSum || index < 0)
                {
                    flag = false;
                }
            }

            return --index;
        }
        #endregion

    }
}
