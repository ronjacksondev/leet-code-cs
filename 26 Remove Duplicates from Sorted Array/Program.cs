using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 2 };
            int[] expectedNums = { 1, 2 };
            int k1 = new Solution().RemoveDuplicates(nums1);
            Console.WriteLine(k1.ToString());
            Console.WriteLine(string.Join(",", nums1));
            Debug.Assert(k1 == expectedNums.Length);
            for (int i = 0; i < k1; i++)
            {
                Debug.Assert(nums1[i] == expectedNums[i]);
            }

            int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] expectedNums2 = { 0, 1, 2, 3, 4 };
            int k2 = new Solution().RemoveDuplicates(nums2);
            Console.WriteLine(k2.ToString());
            Console.WriteLine(string.Join(",", nums2));
            Debug.Assert(k2 == expectedNums2.Length);
            for (int i = 0; i < k2; i++)
            {
                Debug.Assert(nums2[i] == expectedNums2[i]);
            }

            int[] nums3 = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            int[] expectedNums3 = { 1, 2, 3 };
            int k3 = new Solution().RemoveDuplicates(nums3);
            Console.WriteLine(k3.ToString());
            Console.WriteLine(string.Join(",", nums3));
            Debug.Assert(k3 == expectedNums3.Length);
            for (int i = 0; i < k3; i++)
            {
                Debug.Assert(nums3[i] == expectedNums3[i]);
            }
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int counter = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        nums[i + 1] = nums[j];
                        counter++;
                        if (nums[j] == nums[nums.Length - 1])
                        {
                            return counter;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return counter;
        }

        /* Whiteboard
            Loop through each item (1 less than whole thing)
            On each iteration loop through looking for items where A < B
            Once found assign B value to A + 1 index
            Move up the loop to the B index to pickup where you left off
        End */
    }
}
