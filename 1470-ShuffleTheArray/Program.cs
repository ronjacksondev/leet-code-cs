using System;

namespace _1470_ShuffleTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] solution1 = (int[])new Solution().Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);
            Console.WriteLine(string.Join(",", solution1));

            int[] solution2 = (int[])new Solution().Shuffle(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4);
            Console.WriteLine(string.Join(",", solution2));

            int[] solution3 = (int[])new Solution().Shuffle(new int[] { 1, 1, 2, 2 }, 2);
            Console.WriteLine(string.Join(",", solution3));
        }
    }

    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] shuffleArray = new int[2 * n];
            int index = 0;
            for (int i = 0; i < nums.Length; i=i+2)
            {
                shuffleArray[i] = nums[index];
                shuffleArray[i + 1] = nums[index + n];
                index++;
            }
            return shuffleArray;
        }
    }
    /*
     * loop though half the array
     * take the first number and then take i + n index
     *  0  1  2  3  4  5
     * [2, 5, 1, 3, 4, 7]
     *  0  2  4  1  3  5
     */
}
