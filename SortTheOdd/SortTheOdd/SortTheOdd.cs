namespace SortTheOdd
{
    /// <summary>
    /// You will be given an array of numbers. 
    /// You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
    /// </summary>
    public class SortTheOdd
    {
        public static int[] Sort(int[] arr)
        {
            if (arr.Length == 0) { return arr; }
            var odds = new List<int>();
            var index = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odds.Add(arr[i]);
                    index.Add(i);
                }
            }

            var oddsArr = odds.ToArray();
            Array.Sort(oddsArr);

            for (int i = 0; i < index.Count; i++)
            {
                arr[index[i]] = oddsArr[i];
            }
            return arr;
        }
    }
}
