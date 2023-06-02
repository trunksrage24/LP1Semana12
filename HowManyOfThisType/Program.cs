using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    /// <summary>
    /// class Program where the Main method controls what happens in the code
    /// </summary>
    public class Program
    {
        private const double x = 1.23;

        //main method where all code runs
        private static void Main()
        {
            Random rng = new Random();
            ICollection<object> items = new List<object>();

            //make list of possible outcomes
            items.Add(1);                    // int
            items.Add(1.3);                  // double
            items.Add(-0.5f);                // float
            items.Add("hello");              // string
            items.Add(true);                 // bool
            items.Add(false);                // bool
            items.Add(rng.NextDouble() > x); // bool
            items.Add(Math.PI);              // double
            items.Add(Math.E);               // double
            items.Add(rng.NextDouble());     // double
            items.Add(rng.Next());           // int

            //print randomly chosen outcomes
            Console.WriteLine($"int   : {Checker.HowManyOfType<int>(items)}");
            Console.WriteLine($"float : {Checker.HowManyOfType<float>(items)}");
            Console.WriteLine($"double: {Checker.HowManyOfType<double>(items)}");
            Console.WriteLine($"bool  : {Checker.HowManyOfType<bool>(items)}");
            Console.WriteLine($"string: {Checker.HowManyOfType<string>(items)}");
            Console.WriteLine($"byte  : {Checker.HowManyOfType<byte>(items)}");

            // Expected output
            // int   : 2
            // float : 1
            // double: 4
            // bool  : 3
            // string: 1
            // byte  : 0
        }
    }
}
