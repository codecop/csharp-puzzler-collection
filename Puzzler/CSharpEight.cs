using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzler
{
    class CSharpEight
    {
        public void Run()
        {

        }


    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);

        //public readonly override string ToString() =>
        //    $"({X}, {Y}) is {Distance} from the origin";
    }
    public interface ICustomer
    {
        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }
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
