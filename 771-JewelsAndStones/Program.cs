using System;

namespace _771_JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution1 = new Solution().NumJewelsInStones("aA", "aAAbbbb");
            Console.WriteLine(string.Join(",", solution1));

            int solution2 = new Solution().NumJewelsInStones("z", "ZZ");
            Console.WriteLine(string.Join(",", solution2));
        }
    }

    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            char[] jewelTypes = J.ToCharArray();
            char[] stones = S.ToCharArray();
            for (int i = 0; i < jewelTypes.Length ; i++)
            {
                for (int j = 0; j < stones.Length; j++)
                {
                    if(stones[j] == jewelTypes[i])
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }

    /* Whiteboard
     * Loop though each jewel type
     * As doing so loop through each stone and compare with jeweltype
    */
}
