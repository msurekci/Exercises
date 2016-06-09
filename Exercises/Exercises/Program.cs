using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercises.Fibonacci.Fibonacci;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var fib = GetFibonacciValue(50);
            Console.WriteLine(fib);
            Console.ReadKey();
        }
    }
}
