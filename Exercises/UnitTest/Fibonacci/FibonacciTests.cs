using NUnit.Framework;


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
            var result = new Exercises.Fibonacci.Fibonacci().GetFibonacciValue(value);

            Assert.AreEqual(result, expected);
        }
    }
}
