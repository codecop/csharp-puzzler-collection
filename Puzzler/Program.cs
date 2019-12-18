using System;

namespace Puzzler
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var csharp7 = new CSharpSeven();
            csharp7.Run();

            var puzzle1 = new Puzzle1();
            puzzle1.Run();
            var puzzle2 = new Puzzle2();
            puzzle2.Run();
            var puzzle3 = new Puzzle3();
            puzzle3.Run();
            var puzzle4 = new Puzzle4();
            puzzle4.Run();
            var puzzle5 = new Puzzle5();
            // puzzle5.Run(); // hangs

            Console.ReadKey();
        }

    }
}
