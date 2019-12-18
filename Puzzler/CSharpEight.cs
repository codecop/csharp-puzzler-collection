using System;
using System.Collections.Generic;

namespace Puzzler
{
    public class CSharpEight
    {
        public void Run()
        {

        }

    }

    public struct PointReadonlyProperty
    {
        public double X { get; set; }
        public double Y { get; set; }

        // needs readonly modifier because of ToString
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly override string ToString() =>
           $"({X}, {Y}) is {Distance} from the origin";
    }

    public interface ICustomer
    {
        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }

        // Default method in interfaces
        public string HelloCustomer()
        {
            return "hi";
        }
    }

    public class Customer : ICustomer
    {
        public DateTime DateJoined => throw new NotImplementedException();

        public DateTime? LastOrder => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public IDictionary<DateTime, string> Reminders => throw new NotImplementedException();
    }

}
