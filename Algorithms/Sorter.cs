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
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double[] BubbleSort(params double[] numbers)
        {
            var len = numbers.Length;
            bool state = false;

            for (int i = 1; i < len; i++)
            {
                state = false;
                for (int j = 0; j < len-i; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        Tools.Swap(ref numbers[j], ref numbers[j+1]);
                        state = true;
                    }
                }
                if (!state) break;
            }

            return numbers;
        }
    }
}
