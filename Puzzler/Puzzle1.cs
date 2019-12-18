using System;

namespace Puzzler
{
    class Puzzle1
    {
        public void Run()
        {
            var i = 1;
            Test(out i, out i);
        }

        static void Test(out int x, out int y)
        {
            x = 42;
            y = 123;
            Console.WriteLine(x == y);
        }
    }
}
