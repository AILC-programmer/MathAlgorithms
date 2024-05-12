using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Sorter
    {
        /// <summary>
        /// T(n) = (n (n - 1)) / 2
        /// B(n) = n - 1
        /// O(n^2)
        /// </summary>
        /// <param name="numbers">List of numbers.</param>
        /// <returns>Returns sorted array of those numbers.</returns>
        public static double[] BubbleSort(params double[] numbers)
        {
            var len = numbers.Length;
            bool isContinue = false;

            for (int i = 1; i < len; i++)
            {
                isContinue = false;
                for (int j = 0; j < len-i; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        Tools.Swap(ref numbers[j], ref numbers[j+1]);
                        isContinue = true;
                    }
                }
                if (!isContinue) break;
            }

            return numbers;
        }
    }
}
