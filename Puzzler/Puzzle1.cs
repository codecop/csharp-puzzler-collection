using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzler
{
    class Puzzle1
    {
        public void Run()
        {
            var i = 1;
            var j = 2;
            Test(out i, out i);
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
        static void Test(out int x, out int y)
        {
            //Console.WriteLine(x);
            x = 42;
            Console.WriteLine(x);
            y = 123;
            Console.WriteLine(x == y);
        }
    }
}
