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
        /// option .0. for exit.
        /// option .a. for input numbers.
        /// option .1. for bubble sort.
        /// </summary>
        /// <returns>returns a selected option.</returns>
        public static string WriteMenu()
        {
            var builder = new StringBuilder();

            builder.AppendLine("Choose one options:");
            builder.AppendLine();
            builder.AppendLine("0_ Exit.");
            builder.AppendLine();
            builder.AppendLine("_______________________________________");
            builder.AppendLine();
            builder.AppendLine("a_ Enter numbers.");
            builder.AppendLine("---------------------------------------");
            builder.AppendLine("1_ Bubble sort.");
            builder.AppendLine();

            Write(builder.ToString());

            return Reader.ReadL("Enter option: ");
        }

        public static void WriteList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                WriteLine(item.ToString() + '\t');
            }
        }
    }
}
