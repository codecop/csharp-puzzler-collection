using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzler
{
    public class Puzzle3
    {
        public void Run()
        {
            Derived d = new Derived();
            d.Foo(a: 1, b: 2);
            // a = 1, b = 2

            Base b = d;
            b.Foo(a: 1, b: 2);
            // a = 2, b = 1


        }
    }

    public class Base
    {
        public virtual void Foo(int a, int b) { }
    }

    public class Derived : Base
    {
        public override void Foo(int b, int a)
        {
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
