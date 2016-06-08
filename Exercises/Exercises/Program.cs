using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var fib = new Fibonacci.Fibonacci().GetFibonacciValue(50);
            Console.WriteLine(fib);
            Console.ReadKey();
        }
    }
}
