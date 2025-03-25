using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace leet_code_cs
{
    [TestClass]
    public sealed class LC_0027_RemoveItem
    {

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums = [3, 2, 2, 3];
            int val = 3;
            int[] expectedNums = [2, 2];

            // Act
            int k = RemoveElement(nums, val);

            // Assert
            Assert.AreEqual(k, expectedNums.Length);
            Array.Sort(nums, 0, k);
            for(int i = 0; i < k; i++)
            {
                Assert.AreEqual(nums[i], expectedNums[i]);
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;
            int[] expectedNums = [0, 1, 4, 0, 3];

            // Act
            int k = RemoveElement(nums, val);
            Debug.WriteLine(k);
            Debug.WriteLine(string.Join(", ", nums));

            // Assert
            Assert.AreEqual(k, expectedNums.Length);
            Array.Sort(nums, 0, k);
            Array.Sort(expectedNums, 0, k);
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(nums[i], expectedNums[i]);
            }
        }


        /* Whiteboard
         * k = number of elements remaining after removing the val param
         * setup 2 pointers, one for your insertion point and one for your inspection point
         * loop through the array
         * if the item != val 
         *   if the pointers are looking at different indexes then set the array at index insertion pointer to value of index of inspection pointer
         *   advance both pointers
         * if the item == val
         *   then only advance the inspection pointer and perform the test above
         * k will equal insertion pointer +1
         */

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
