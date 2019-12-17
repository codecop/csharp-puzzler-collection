using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzler
{
    public class Puzzle4
    {
        public void Run()
        {
            //var x = new FooBar();

            //bool b = x is FooBar;

            //Console.WriteLine(b);

            //FooBar fooBar = (Baz)x;

            Frob<int>();

        }

        private void Frob<FooBar>()
        {

            int x = 1;

            bool b = x is FooBar;

            Console.WriteLine(b);

            //FooBar fooBar = (FooBar)x;

        }
    }

    public struct FooBar
    {
        public int X;
    }
}
