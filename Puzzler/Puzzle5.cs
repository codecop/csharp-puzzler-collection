using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Puzzler
{
    public class Puzzle5
    {
        public void Run()
        {
            Woot.Main2(new string[0]);
        }
    }

    class Woot
    {
        private static float PI;
        private static bool initialized = doInitialize();

        private static bool doInitialize()
        {
            if (!initialized)
            {
                var thread = new Thread(() => { PI = 3.14f; });
                thread.Start();
                thread.Join();
            }
            return true;
        }

        public static void Main2(string[] args)
        {
            Console.WriteLine(PI);
        }
    }
}
