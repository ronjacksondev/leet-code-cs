using System;

namespace _1512_NumberOfGoodPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution1 = new Solution().NumIdenticalPairs(new[] {1,2,3,1,1,3});
            Console.WriteLine(string.Join(",", solution1));

            int solution2 = new Solution().NumIdenticalPairs(new[] { 1, 1, 1, 1 });
            Console.WriteLine(string.Join(",", solution2));

            int solution3 = new Solution().NumIdenticalPairs(new[] { 1, 2, 3 });
            Console.WriteLine(string.Join(",", solution3));
        }
    }

    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int matches = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        matches++;
                    }
                }
            }
            return matches;
        }
    }

    /* Whiteboard
     * Loop through each item
     * Inside each iteration loop through items again starting at j = i + 1
     * Inside the nested loop you can compare i and j for matches
     * create a counter to hold the number of matches
     * 0,1,2,3,4
     * 1,2,3,4
    */
}
