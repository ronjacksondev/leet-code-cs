using System;

namespace _1672_RichestCustomerWealth
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution = new Solution().MaximumWealth(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            });
            Console.WriteLine(solution.ToString());

            int solution2 = new Solution().MaximumWealth(new int[][] {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
            });
            Console.WriteLine(solution2.ToString());

            int solution3 = new Solution().MaximumWealth(new int[][] {
                new int[] { 2, 8, 7 },
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
            });
            Console.WriteLine(solution3.ToString());
        }
    }

    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int greatest = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int customerTotal = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    customerTotal += accounts[i][j];
                }
                greatest = (customerTotal > greatest) ? customerTotal : greatest;
            }
            return greatest;
        }
    }

    /*
     * White Board
     * Look at first array and add up numbers
     * Look up next array and add up numbers and see which one is greatest
     * Look up next array and add up numbers and see which one is greatest
    */
}
