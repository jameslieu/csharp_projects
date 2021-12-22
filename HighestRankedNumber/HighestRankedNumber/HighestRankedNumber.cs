namespace HighestRankedNumber
{
    public class HighestRankedNumber
    {
        public static int HighestRank(int[] arr)
        {
            Array.Sort(arr);
            var dict = new Dictionary<int, int>();
            var highestCount = 0;
            var highestRank = 0;
            var highestNoDups = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    var currentCount = dict[arr[i]] + 1;
                    dict[arr[i]] = currentCount;
                    if (currentCount >= highestCount)
                    {
                        highestCount = currentCount;
                        highestRank = highestRank > arr[i]
                            ? highestRank
                            : arr[i];
                    }
                }
                else
                {
                    dict.Add(arr[i], 1);
                    if (arr[i] > highestNoDups)
                        highestNoDups = arr[i];
                }
            }

            return highestRank > 0
                ? highestRank
                : highestNoDups;
        }
    }
}