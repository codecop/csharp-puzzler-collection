using System;

namespace Puzzler
{
    public class Program
    {

        public static void Main()
        {
            var csharp7 = new CSharpSeven();
            csharp7.Run();

            var puzzle2 = new Puzzle2();
            var puzzle3 = new Puzzle3();
            var puzzle4 = new Puzzle4();
            var puzzle5 = new Puzzle5();
            puzzle5.Run();

            Console.ReadKey();
        }

    }
}
