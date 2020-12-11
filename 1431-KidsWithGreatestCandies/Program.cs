using System;
using System.Collections.Generic;

namespace _1431_KidsWithGreatestCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] solution1 = (bool[])new Solution().KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
            Console.WriteLine(string.Join(",", solution1));

            bool[] solution2 = (bool[])new Solution().KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
            Console.WriteLine(string.Join(",", solution2));

            bool[] solution3 = (bool[])new Solution().KidsWithCandies(new int[] { 12, 1, 12 }, 10);
            Console.WriteLine(string.Join(",", solution3));
        }
    }

    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int greatestNumber = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                greatestNumber = (greatestNumber > candies[i]) ? greatestNumber : candies[i];
            }

            bool[] results = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                results[i] = (candies[i] + extraCandies >= greatestNumber) ? true : false;
            }
            return results;
        }
    }
    /* Whiteboard
     * First determine what the greatest number is
     * Then loop through each item and add the extra candies to the item and see if it is greater than greatest number
     * Return the list
     */
}
