using Exercises.RomanNumerals;
using NUnit.Framework;

namespace UnitTest.RomanNumerals
{
    public class RomanNumeralsToNumbersTests
    {
        [TestCase(null, null)]
        [TestCase("aaa", null)]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IIII", 4)]//shouldnt
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        public void RomanNumeralShouldBeConvertedToCorrectArabicNumbers(string romanNumeral, int expectedArabicNumber)
        {
            var result = new RomanNumeralConverter().Convert(romanNumeral);

            Assert.AreEqual(expectedArabicNumber, result);
        }
    }
}
