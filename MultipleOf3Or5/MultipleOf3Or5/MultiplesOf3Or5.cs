namespace MultiplesOf3Or5
{
    public class MultiplesOf3Or5
    {
        /* 
            If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            The sum of these multiples is 23.
            Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. 
            Additionally, if the number is negative, return 0 (for languages that do have them).

            Note: If the number is a multiple of both 3 and 5, only count it once.  
         */
        public static int GetMultiplesOf3Or5(int num)
        {
            if (num < 1) {  return 0; }

            var result = 0;
            var i = 1;
            while (i < num)
            {
                var isMultipleOf3 = i % 3 == 0;
                var isMultipleOf5 = i % 5 == 0;
                if (isMultipleOf3 && isMultipleOf5) 
                {
                    result += i;
                    i++;
                    continue;
                }

                if (isMultipleOf3 || isMultipleOf5)
                {
                    result += i;
                }
                i++;
            }

            return result;
        }
    }
}