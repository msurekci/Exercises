﻿using NUnit.Framework;
using static Exercises.FizzBuzz.FizzBuzz;

namespace UnitTest.FizzBuzz
{
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0, "")]
        [TestCase(1, "1")]
        [TestCase(2, "12")]
        [TestCase(3, "12Fizz")]
        [TestCase(5, "12Fizz4Buzz")]
        [TestCase(15, "12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz")]
        public void FizzBuzzShouldReturnCorrectValue(int input, string expected)
        {
            var result = GetFizzBuzz(input);

            Assert.AreEqual(expected, result);
        }
    }
}
