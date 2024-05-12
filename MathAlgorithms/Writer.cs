using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace MathAlgorithms
{
    internal class Writer
    {
        /// <summary>
        /// op .0. for exit.
        /// op .a. for input numbers.
        /// op .1. for bubble sort.
        /// op .2. for find index.
        /// op .3. for binary search.
        /// </summary>
        /// <returns>returns a selected option.</returns>
        public static string WriteMenu()
        {
            var builder = new StringBuilder();

            builder.AppendLine("-----------------------------------------------------");
            builder.AppendLine("Choose one options:");
            builder.AppendLine();
            builder.AppendLine("0_ Exit.");
            builder.AppendLine();
            builder.AppendLine("_______________________________________");
            builder.AppendLine();
            builder.AppendLine("a_ Enter numbers.");
            builder.AppendLine("---------------------------------------");
            builder.AppendLine("1_ Bubble sort.");
            builder.AppendLine("2_ Find Index.");
            builder.AppendLine("3_ Binary search.");

            builder.AppendLine("-----------------------------------------------------");
            Write(builder.ToString());

            return Reader.ReadL("Enter option: ");
        }

        public static void WriteList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Write(item.ToString() + '\t');
            }
            WriteLine();
        }
    }
}
