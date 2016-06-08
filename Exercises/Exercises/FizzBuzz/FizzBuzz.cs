using System.Text;

namespace Exercises.FizzBuzz
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            var result = new StringBuilder("");
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {                    
                    result.Append("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Append("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Append("Buzz");
                }
                else
                {
                    result.Append(i);
                }
            }

            return result.ToString();
        }
    }
}
