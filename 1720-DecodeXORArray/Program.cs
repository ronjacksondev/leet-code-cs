using System;

namespace _1720_DecodeXORArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] solution = new Solution().Decode(new int[] {1,2,3}, 1);
            Console.WriteLine(string.Join(",",solution));

            int[] solution2 = new Solution().Decode(new int[] { 6,2,7,3 }, 4);
            Console.WriteLine(string.Join(",", solution2));


        }
    }

    public class Solution
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] array = new int[encoded.Length + 1];
            array[0] = first;
            for (int i = 0; i < encoded.Length; i++)
            {
                Console.WriteLine(i);
                array[i + 1] = array[i] ^ encoded[i];
            }
            return array;
        }
    }

    /*Whiteboard
     * Loop through the encoded array
     * encoded[i] = arr[i] XOR arr[i+1]
     * return the encoded array
     */
}
