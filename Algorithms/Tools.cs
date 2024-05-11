using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Algorithms
{
    public class Tools
    {
        public static void Swap(ref double leftElement, ref double rightElement)
        {
            double temp = leftElement;
            leftElement = rightElement;
            rightElement = temp;
        }

    }
}
