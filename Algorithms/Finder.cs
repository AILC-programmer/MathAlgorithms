using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Finder
    {
        /// <summary>
        /// T(n) = n,
        /// B(n) = 1,
        /// W(n) = T(n) = n,
        /// A(n) = 1 * (1/n) + 2 * (1/n) + ... n * (1/n) = (n + 1) / 2,
        /// O(n)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int FindIndexOfX(double x, params double[] numbers)
        {
            int len = numbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (x == numbers[i])
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int BinarySearch(double x, params double[] numbers)
        {
            int len = numbers.Length;
            int low = 0, high = len;
            int mid = (low + high) / 2;

            while (low < high)
            {
                if (x == numbers[mid]) return mid;
                else if (x < numbers[mid])
                {
                    high = mid;
                    mid = (low + high) / 2;
                    continue;
                }
                else
                {
                    low = mid;
                    mid = (low + high) / 2;
                    continue;
                }
            }

            return -1;
        }
    }
}
