using System;
using System.Collections.Generic;

namespace Puzzler
{
    public class CSharpSeven
    {
        public void Run()
        {
            NewTuple();
            IsObjectAnInt();
            YieldTest();
            DefaultKeyword();
            TupleDoesNotRename();
            GenericInPatternMatching();
        }

        private void GenericInPatternMatching()
        {
            Console.WriteLine(GenericMethod<int>(5));
        }

        private T GenericMethod<T>(object obj)
        {
            switch (obj)
            {
                case T obj2:
                    return obj2;
                default:
                    return default;
            }
        }

        private static void TupleDoesNotRename()
        {
            int count2 = 5;
            string label = "Colors used in the map";
            var pair = (count2, label); // element names are "count" and "label"
            var cnt = pair.count2;
        }

        private static void DefaultKeyword()
        {
            System.Numerics.Complex fillValue = default;
            Console.WriteLine(fillValue);

            Func<string, bool> whereClause = default;
            whereClause?.Invoke("hello");
        }

        private void YieldTest()
        {
            var variable = EndlessInt();
            //Console.WriteLine(variable.Sum());
        }

        private IEnumerable<long> EndlessInt()
        {
            while (true)
            {
                yield return 1;
            }
        }

        private static void IsObjectAnInt()
        {
            object obj = 1;
            Console.WriteLine(obj is int);
            Console.WriteLine(obj.GetType());
        }

        private static void NewTuple()
        {
            // deconstruction of classic Tuple
            var range = new Tuple<int, int>(1, 2);
            (int max, int min) = range;
            Console.WriteLine(max);
            Console.WriteLine(min);

            // classic Tuple is not the same type as new Tuple
            // (int max, int min) newRange = range;

            // creating a new Tuple looks like that
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            // all new Tuples don't care for the name
            (string a, string b) name2 = namedLetters;

            var anon = new
            {
                apple = "apple",
                banana = "banana"
            };

            // anon class would need method Deconstruct implementation
            // (string c, string d) = anon;
        }
    }
}
