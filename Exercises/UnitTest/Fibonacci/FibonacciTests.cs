using NUnit.Framework;
using static Exercises.Fibonacci.Fibonacci;

namespace UnitTest.Fibonacci
{
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(46, 1836311903)]
        public void FibonacciNthShouldReturnCorrectValue(int value, int expected)
        {
            var result = GetFibonacciValue(value);

            Assert.AreEqual(result, expected);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(46, 1836311903)]
        public void FibonacciNthShouldReturnCorrectValueIterative(int value, int expected)
        {
            var result = GetFibonacciValueIteratively(value);

            Assert.AreEqual(result, expected);
        }
    }
}
