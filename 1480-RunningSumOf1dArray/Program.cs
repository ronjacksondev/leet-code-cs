using System;

namespace _1480_RunningSumOf1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] solution1 = new Solution().RunningSum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(string.Join(",", solution1));

            int[] solution2 = new Solution().RunningSum(new int[] { 1, 1, 1, 1, 1 });
            Console.WriteLine(string.Join(",", solution2));

            int[] solution3 = new Solution().RunningSum(new int[] { 3, 1, 2, 10, 1 });
            Console.WriteLine(string.Join(",", solution3));
        }
    }

    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int[] sumArray = new int[nums.Length];
            sumArray[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sumArray[i] = nums[i] + sumArray[i - 1];
            }
            return sumArray;
        }
    }

    /*
     * White Board
     *  The first number in the array will be the first number in the array, ha!
     *  The subsequent numbers will be x[n] + x[n-1]
    */
}
