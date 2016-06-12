using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsConversion
{
    public class RomanNumeralConverter
    {
        readonly Dictionary<char, int> romanNumerals = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 } }; 
        public int Convert(string romanNumeral)
        {
            int result = 0;

            var remainingRomanNumeral = new StringBuilder(romanNumeral);

            int i;

            for (i = 0; i < romanNumerals.Count; i++)
            {
                while (remainingRomanNumeral.Length > 0 && remainingRomanNumeral[0] == romanNumerals.ElementAt(i).Key)
                {
                    if (remainingRomanNumeral.Length > 1 && romanNumerals.ElementAt(i).Value < romanNumerals[remainingRomanNumeral[1]])
                    {
                        result -= romanNumerals.ElementAt(i).Value;
                    }
                    else
                    {
                        result += romanNumerals.ElementAt(i).Value;
                    }

                    remainingRomanNumeral.Remove(0, 1);
                    i = 0;
                }
            } 
                     
            return result;
        }
    }
}