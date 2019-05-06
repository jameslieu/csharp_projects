namespace SumNumbers
{
    /// <summary>
    /// Given a string, return the sum of the numbers appearing in the string, ignoring all other characters.
    /// A number is a series of 1 or more digit chars in a row. 
    /// </summary>
    public class Program
    {
        public static int SumNumbers(string parameter)
        {
            int result = 0;
            string numberString = "";
            for (int i = 0; i < parameter.Length; i++)
            {
                int number;
                bool isNumeric = int.TryParse(parameter[i].ToString(), out number);

                if (isNumeric)
                {
                    numberString += number;
                }
                else
                {
                    HandleSum(ref result, ref numberString);
                }

                if ((parameter.Length - 1) == i)
                {
                    int lastNumber;
                    int.TryParse(numberString, out lastNumber);
                    result += lastNumber;
                }

            }

            return result;
        }

        private static void HandleSum(ref int result, ref string numberString)
        {
            int number;
            bool isNumeric = int.TryParse(numberString, out number);
            if (isNumeric)
            {
                result += number;
                numberString = "";
            }
        }
    }
}

