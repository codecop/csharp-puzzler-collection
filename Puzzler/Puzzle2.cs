using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzler
{
    class Puzzle2
    {
        public void Run()
        {
            double x = double.NaN;
            double y = double.NaN;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Print(x, y);
        }

        /*
           EXPECTED RESULT
            x > y is False
            !(x <= y) is True
        */
        private static void Print(double x, double y)
        {
            Console.WriteLine($"x > y is {x > y}");
            Console.WriteLine($"!(x <= y) is {!(x <= y)}");
        }
    }
}
