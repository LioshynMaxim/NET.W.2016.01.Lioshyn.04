using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class NewtonRoot
    {
        #region NewtonRoot

        /// <summary>
        /// The basic method of calculating the root of n-th degree of Newton's method.
        /// </summary>
        /// <param name="n">Power degree</param>
        /// <param name="a">The number from which the root is removed</param>
        /// <param name="eps">Accyraty</param>
        /// <returns>Radical of a</returns>
        public static double NewtonRootN(int n, double a, double eps = 0.0001)
        {
            if (Double.IsNaN(a) || Double.IsNaN(eps) || (n == null))
            {
                throw new ArgumentNullException();
            }

            if ((eps >= 1) || (eps < 0) || ((a < 0) && (n % 2 == 0)))
            {
                throw new ArgumentException();
            }

            var x0 = a / n;
            var x1 = SolutionX1(n, x0, a);

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = SolutionX1(n, x0, a);
                
            }

            return x1;
        }

        #endregion

        #region solution x1

        /// <summary>
        /// Solution part x1 from method
        /// </summary>
        /// <param name="n">Root level</param>
        /// <param name="x0">x0 from method</param>
        /// <param name="a">Number</param>
        /// <returns>x1 from method</returns>

        private static double SolutionX1(int n, double x0, double a)
        {
            return (1.0 / n) * ((n - 1) * x0 + a / Math.Pow(x0, n - 1)); ;
        }

        #endregion

    }
}
