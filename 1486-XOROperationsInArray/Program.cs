using System;

namespace _1486_XOROperationsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = new Solution().XorOperation(n: 5, start: 0);
            Console.WriteLine($"The result is {result}");

            int result2 = new Solution().XorOperation(n: 4, start: 3);
            Console.WriteLine($"The result is {result2}");

            int result3 = new Solution().XorOperation(n: 1, start: 7);
            Console.WriteLine($"The result is {result3}");

            int result4 = new Solution().XorOperation(n: 10, start: 5);
            Console.WriteLine($"The result is {result4}");
        }
    }

    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            int[] array = new int[n];
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = start + (2 * i);
                result = result ^ array[i];
                Console.WriteLine(i + " = " + (start + (2 * i)).ToString() + "(" + result + ")");
            }
            return result;
        }
    }

    /*WhiteBoard
     *  create an array of numbers [#,#,#,#] (0 indexed)
     *  there is a variable called start
     *  each value of the array = start + 2*index
     *  There is a variable called n that defines the array's length
     *  So to first generate the array we pass in start to the equation (start +1*index)
     *  Repeat that operation for the number of items in array as defined by the length
     *  Then return the bitwise XOR of all of the elements of nums
     *  bitwise xor of 0 ^ 2 ^ 4 ^ 6 ^ 8
     *  0 = 0000
     *  2 = 0010
     *  ---------
     *  x = 0010 = 2
     *  4 = 0100
     *  --------
     *  x = 0110 = 6
     *  6 = 0110
     *  --------
     *  x = 0000
     *  8 = 1000
     *  --------
     *  x = 1000 = 8
     */
}
