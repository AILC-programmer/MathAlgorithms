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
        public static double[] Swap(double[] array, int leftElement, int rightElement)
        {
            var temp = array[leftElement];
            array[leftElement] = array[rightElement];
            array[rightElement] = temp;
            return array;
        }

    }
}
