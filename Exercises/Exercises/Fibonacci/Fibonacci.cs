using System.Collections.Generic;

namespace Exercises.Fibonacci
{
    public class Fibonacci
    {
        private readonly Dictionary<int, long> FibonacciSequence = new Dictionary<int, long>(); 

        public int GetFibonacciValue(int n)
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
    }
}
