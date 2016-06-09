using System.Collections.Generic;

namespace Exercises.Fibonacci
{
    public static class Fibonacci
    {
        private static readonly Dictionary<int, long> FibonacciSequence = new Dictionary<int, long>(); 

        public static int GetFibonacciValue(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }

            if (FibonacciSequence.ContainsKey(n))
            {
                return (int)FibonacciSequence[n];
            }

            var value = GetFibonacciValue(n - 1) + GetFibonacciValue(n - 2);

            FibonacciSequence.Add(n, value);

            return value;
        }

        public static int GetFibonacciValueIteratively(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            var a = 0;
            var b = 1;
            var fibonacciValue = 0;

            for (int i = 2; i <= n; i++)
            {
                fibonacciValue = a + b;
                a = b;
                b = fibonacciValue;
            }

            return fibonacciValue;
        }
    }
}
