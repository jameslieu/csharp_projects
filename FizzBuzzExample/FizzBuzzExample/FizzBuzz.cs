using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzExample
{
    public class FizzBuzz
    {
        public static List<string> results(int number)
        {
            List<string> fizzBuzzList = new List<string>();
            
            for (int i = 1; i <= number; i++)
            {
                bool isFizz = i % 3 == 0;
                bool isBuzz = i % 5 == 0;
                string result = "";

                if (isFizz)
                {
                    result += "Fizz";
                }

                if (isBuzz)
                {
                    result += "Buzz";
                }
                
                if (String.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }

                fizzBuzzList.Add(result);
            }

            return fizzBuzzList;
        }
    }
}
