using System;

namespace Puzzler
{
    public class Program
    {

        public static void Main()
        {
            var c7 = new CSharpSeven();
            var c8 = new CSharpEight();
            c7.Run();
            c8.Run();

            Console.ReadKey();
        }

    }
}
