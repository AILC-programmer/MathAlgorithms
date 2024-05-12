using Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace MathAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            List<double> numbers = new List<double>();
            string option = string.Empty;

            while (isContinue)
            {
                option = Writer.WriteMenu();

                switch (option)
                {
                    case "0":
                        isContinue = false; break;
                    case "a":
                        {
                            numbers = Reader.ReadNumbers();
                        }break;
                    case "1":
                        {
                            Writer.WriteList(numbers);
                            numbers = Sorter.BubbleSort(numbers.ToArray()).ToList<double>();
                            WriteLine('\n');
                            Writer.WriteList(numbers);
                        }
                        break;
                    case "2":
                        {
                            double n = double.Parse(Reader.ReadL("Find index of: "));
                            WriteLine(Finder.FindIndexOfX(n,numbers.ToArray()));
                        }break;
                    case "3":
                        {
                            double n = double.Parse(Reader.ReadL("Binary search for: "));
                            WriteLine(Finder.BinarySearch(n,numbers.ToArray()));
                        }
                        break;

                    default:
                        continue;
                }
            }
        }
    }
}
