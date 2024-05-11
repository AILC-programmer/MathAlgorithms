using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace MathAlgorithms
{
    internal class Reader
    {

        public static List<double> ReadNumbers()
        {
            int n = 0;
            var numbers = new List<double>();
            bool isReadNumbers = true;

            WriteLine("Enter numbers.\nIf you think that is enough, enter 00.");
            while (isReadNumbers)
            {
                var res = ReadL("Enter number: ");
                var nums = res.Split(' ', ',', '-', '_');
                foreach (var num in nums)
                {
                    if (num.Trim() == "00")
                    {
                        isReadNumbers = false;
                        break;
                    }
                    else if (int.TryParse(num.Trim(), out n))
                    {
                        numbers.Add(n);
                    }
                    else
                        break;
                }
            }
            return numbers;
        }

        public static string ReadL(string message)
        {
            Write(message);
            var input = ReadLine().ToLower();
            return input;
        }
    }
}
