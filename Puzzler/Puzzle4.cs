using System;

namespace Puzzler
{
    public class Puzzle4
    {
        public void Run()
        {
            Frob<int>();
        }

        private void Frob<FooBar>()
        {
            int x = 1;
            bool b = x is FooBar;
            Console.WriteLine(b);
            // does not compile
            //FooBar fooBar = (FooBar)x;
        }
    }
}
